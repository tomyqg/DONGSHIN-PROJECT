﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ModbusTcp
{
    public class PcTcpClient
    {
        public delegate void Thread1Completed(Dictionary<string, string> machineData);
        public event Thread1Completed thread1Complete;

        public Dictionary<string, string>[] DataResponse { get; set; }
        public Exception CaughtException { get; set; }


        private Socket ClientSocket;
        private IPEndPoint ServerIpEnd;

        private TcpResponse tcpResponseData;

        
        public PcTcpClient(IPEndPoint serverIpEnd)
        {
            ServerIpEnd = serverIpEnd;
        }

        public Dictionary<string, string>[] getMultipleMachineData(string[] machineCodes, string[] fieldCodes)
        {
            DataDisplayParameter parameter = new DataDisplayParameter();
            parameter.MachineCodes = machineCodes;
            parameter.FieldCodes = fieldCodes;

            Thread tcpThread = new Thread(new ParameterizedThreadStart(DoAll));
            tcpThread.IsBackground = true;
            tcpThread.Start(parameter);
            tcpThread.Join(500);

            return DataResponse;
        }


        /// <summary>
        /// 스레드를 2번 실행시켜 join할때 메인 스레드를 멈추지 않도록 한다
        /// </summary>
        /// <param name="parameter"></param>
        public void getMachineDataAndDisplayFromClient(DataDisplayParameter parameter)
        {
            //ThreadPool.QueueUserWorkItem(ThreadStart, parameter);
            Thread tcpThread = new Thread(new ParameterizedThreadStart(ThreadStart));
            tcpThread.IsBackground = true;
            tcpThread.Start(parameter);
        }

        private void ThreadStart(object obj)
        {
            
            Thread tcpThread = new Thread(new ParameterizedThreadStart(ThreadWorkFromClient));
            tcpThread.IsBackground = true;
            tcpThread.Start(obj);
            

            if (tcpThread.Join(3000) == false)
                tcpResponseData.Exception = (new Exception ("Connection Timeout"));

            DataDisplayParameter parameter = obj as DataDisplayParameter;
            parameter.Callback(this.tcpResponseData);
        }

        public byte[] makeRequestPacket(string machineCode, string[] fieldCodes)
        {
            string fields = string.Empty;
            for (int i = 0; i < fieldCodes.Length; i++)
            {
                fields += fieldCodes[i];
                if (i < fieldCodes.Length - 1)
                    fields += "=";
            }
            byte[] machineBytes = Encoding.UTF8.GetBytes(machineCode);
            byte[] fieldBytes = Encoding.UTF8.GetBytes(fields);

            int machineBytesLength = machineBytes.Length;
            int fieldBytesLength = fieldBytes.Length;


            byte[] requestPacket = new byte[1 + 2 + machineBytesLength + 2 + fieldBytesLength + 2];
            requestPacket[0] = 110; // requestCode
            requestPacket[1] = (byte)(int)(machineBytesLength / 128);
            requestPacket[2] = (byte)(int)(machineBytesLength % 128);
            Array.Copy(machineBytes, 0, requestPacket, 3, machineBytesLength);

            requestPacket[machineBytesLength + 3] = (byte)(int)(fieldBytesLength / 128);
            requestPacket[machineBytesLength + 4] = (byte)(int)(fieldBytesLength % 128);
            Array.Copy(fieldBytes, 0, requestPacket, machineBytesLength + 5, fieldBytesLength);

            int checksum = 0;
            for (int i = 0; i < requestPacket.Length - 2; i++)
            {
                checksum += requestPacket[i];
            }
            requestPacket[requestPacket.Length - 2] = (byte)(int)(checksum / 128);
            requestPacket[requestPacket.Length - 1] = (byte)(int)(checksum % 128);
            return requestPacket;
        }

       
        /*
         * 콜백 메소드 적용 쓰레드 구현중
         * */
       

       
        private void ThreadWorkFromClient(object obj)
        {
            DataDisplayParameter parameter = obj as DataDisplayParameter;
            string[] machineCodes = parameter.MachineCodes;
            string[] fieldCodes = parameter.FieldCodes;
            DataDisplayCallback displayCallback = parameter.Callback;

            this.tcpResponseData = new TcpResponse();
            MachineResponseData[] responseDatas = new MachineResponseData[machineCodes.Length];
            try
            {
                DataResponse = new Dictionary<string, string>[machineCodes.Length];
                for (int i = 0; i < machineCodes.Length; i++)
                {

                    responseDatas[i] = new MachineResponseData();

                    ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                    ClientSocket.Connect(ServerIpEnd);

                    byte[] requestPacket = makeRequestPacket(machineCodes[i], fieldCodes);
                    ClientSocket.Send(requestPacket, SocketFlags.None);

                    byte[] receivedData = new byte[4096];
                    int dataLength = ClientSocket.Receive(receivedData, SocketFlags.None);

                    if (dataLength > 0)
                    {
                        if (receivedData[0] == 120)
                        {
                            //check Checksum
                            int checksum = 0;
                            for (int j = 0; j < dataLength - 2; j++)
                            {
                                checksum += receivedData[j];
                            }
                            int packetCheckSum = receivedData[dataLength - 2] * 128 + receivedData[dataLength - 1];

                            //checksum error 발생
                            //if (checksum == packetCheckSum)
                            if (true)
                            {
                                //parse machineCode
                                bool isConnnected = receivedData[1] == 1 ? true : false;

                                int machineBytesLength = receivedData[2] * 128 + receivedData[3];
                                byte[] machineBytes = new byte[machineBytesLength];
                                Array.Copy(receivedData, 4, machineBytes, 0, machineBytesLength);

                                int fieldBytesLength = receivedData[machineBytesLength + 4] * 128 + receivedData[machineBytesLength + 5];
                                byte[] fieldBytes = new byte[fieldBytesLength];
                                Array.Copy(receivedData, machineBytesLength + 6, fieldBytes, 0, fieldBytesLength);

                                //getValues from modbus then send back value data
                                string machineCode = Encoding.UTF8.GetString(machineBytes);
                                string value = Encoding.UTF8.GetString(fieldBytes);
                                string[] values = value.Split('=');

                                Dictionary<string, string> codesAndValues = new Dictionary<string, string>();
                                for (int j = 0; j < fieldCodes.Length; j++)
                                {
                                    codesAndValues[fieldCodes[j]] = values[j];
                                }
                                responseDatas[i].MachineCode = machineCode;
                                responseDatas[i].MachineData = codesAndValues;
                                responseDatas[i].IsConnected = isConnnected;
                            }
                        }
                        else
                            responseDatas[i].Message = "수신 데이터가 없습니다";
                    }
                    ClientSocket.Disconnect(true);
                }

                tcpResponseData.MachineResponses = responseDatas;

            }
            catch (Exception ex)
            {
                CaughtException = ex;
                tcpResponseData.Exception = ex;
            }
            
        }



        /*
         * 콜백 메소드 적용 스레드 구현중
         * */
        public void DoAll(object obj)
        {
            DataDisplayParameter parameter = obj as DataDisplayParameter;
            string[] machineCodes = parameter.MachineCodes;
            string[] fieldCodes = parameter.FieldCodes;

            try
            {
                DataResponse = new Dictionary<string, string>[machineCodes.Length];
                for (int i = 0; i < machineCodes.Length; i++)
                {
                    ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                    ClientSocket.Connect(ServerIpEnd);


                    byte[] requestPacket = makeRequestPacket(machineCodes[i], fieldCodes);
                    ClientSocket.Send(requestPacket, SocketFlags.None);

                    byte[] receivedData = new byte[4096];
                    int dataLength = ClientSocket.Receive(receivedData, SocketFlags.None);

                    if (dataLength > 0)
                    {
                        if (receivedData[0] == 120)
                        {
                            //check Checksum
                            int checksum = 0;
                            for (int j = 0; j < dataLength - 2; j++)
                            {
                                checksum += receivedData[j];
                            }
                            int packetCheckSum = receivedData[dataLength - 2] * 128 + receivedData[dataLength - 1];

                            if (checksum == packetCheckSum)
                            {
                                //parse machineCode
                                bool isConnnected = receivedData[1] == 1 ? true : false;

                                int machineBytesLength = receivedData[2] * 128 + receivedData[3];
                                byte[] machineBytes = new byte[machineBytesLength];
                                Array.Copy(receivedData, 4, machineBytes, 0, machineBytesLength);

                                int fieldBytesLength = receivedData[machineBytesLength + 4] * 128 + receivedData[machineBytesLength + 5];
                                byte[] fieldBytes = new byte[fieldBytesLength];
                                Array.Copy(receivedData, machineBytesLength + 6, fieldBytes, 0, fieldBytesLength);

                                //getValues from modbus then send back value data
                                string value = Encoding.UTF8.GetString(fieldBytes);

                                string[] values = value.Split('=');

                                Dictionary<string, string> codesAndValues = new Dictionary<string, string>();
                                for (int j = 0; j < fieldCodes.Length; j++)
                                {
                                    codesAndValues[fieldCodes[j]] = values[j];
                                }
                                DataResponse[i] = codesAndValues;
                                
                            }
                        }
                    }
                    ClientSocket.Disconnect(true);

                }// end of for(;;)


            }
            catch (Exception ex)
            {
                CaughtException = ex;
            }
            finally
            {
                
            }
        }



        private Dictionary<string, string> ByteArrayToDictionary(byte[] data)
        {
            int dataLength = data.Length;
            if (dataLength > 1)
            {
                int index = 0;
                Dictionary<string, string> codeAndValue = new Dictionary<string, string>();
                while (index < dataLength)
                {
                    byte fieldCodeLength = data[index++];
                    byte valueLength = data[index++];
                    byte[] fieldCodeArray = new byte[fieldCodeLength];
                    byte[] valueArray = new byte[valueLength];

                    Array.Copy(data, index, fieldCodeArray, 0, fieldCodeLength);
                    string fieldCode = Encoding.UTF8.GetString(fieldCodeArray);
                    index += fieldCodeLength;

                    Array.Copy(data, index, valueArray, 0, valueLength);
                    string value = Encoding.UTF8.GetString(valueArray);
                    index += valueLength;

                    codeAndValue[fieldCode] = value;
                }
                return codeAndValue;
            }
            return null;
        }

        public void Dispose()
        {

            if (ClientSocket != null)
            {
                if (ClientSocket.Connected)
                {
                    try
                    {
                        ClientSocket.Shutdown(SocketShutdown.Both);
                    }
                    catch (Exception ex)
                    {
                        LogWriter.WriteLog_Error(ex);
                    }
                    ClientSocket.Close();
                }
                ClientSocket = null;
            }
        }



    }
}
