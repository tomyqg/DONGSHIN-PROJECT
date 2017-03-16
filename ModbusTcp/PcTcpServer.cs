using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ModbusTcp
{
    public class PcTcpServer
    {

        public delegate void ConnectionSuccess(Socket Client);
        public event ConnectionSuccess ConSuccess;

        public delegate void ConnectionLost(Socket Client);
        public event ConnectionLost ConLost;

        //client에 해당 fieldCode에 대한 값들 전송
        public delegate void DataRequested(int machineId, List<string> fieldCodeList, Socket client);
        public event DataRequested DataRequest;

        private Socket ServerSocket;
        public List<Socket> ClientSocketList { get; set; }
        public int PortNumber { get; set; }

        public PcTcpServer(int port)
        {
            ClientSocketList = new List<Socket>();
            PortNumber = port;
            
        }

        public void DoAll()
        {
            ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, PortNumber);
            ServerSocket.Bind(endPoint);

            ServerSocket.Listen(30);
            while (true)
            {
                try
                {
                    Socket client = ServerSocket.Accept();

                    ThreadPool.QueueUserWorkItem(receiveMessage, client);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }

        private void startServer(object state)
        {
            int portNumber = (int)state;

            try
            {
                ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, portNumber);
                ServerSocket.Bind(endPoint);

                ServerSocket.Listen(30);
                while (true)
                {
                    try
                    {
                        Socket client = ServerSocket.Accept();

                        Thread dataReceiveThread = new Thread(new ParameterizedThreadStart(receiveMessage));
                        dataReceiveThread.Name = "dataReceiveThread at PcTcpServer";
                        dataReceiveThread.IsBackground = true;
                        dataReceiveThread.Start(client);
                    }
                    catch(Exception ex)
                    {
                        throw ex;
                    }
                    
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        /// <summary>
        /// packet info
        /// index 0: 요청/응답 코드 110 클라이언트 요청 코드 120 서버응답
        /// index 1,2: 설비명 바이트 길이 N
        /// idex 3~ 3+N
        /// </summary>
        /// <param name="state"></param>
        public void receiveMessage(object state)
        {

            Socket client = state as Socket;
            try
            {

                Console.WriteLine("receiveMessage 진입");
                byte[] receivedData = new byte[4096];
                int dataLength = client.Receive(receivedData);
                if (dataLength > 0)
                {
                    Console.WriteLine("받은 데이터 길이:" + dataLength);
                    if (receivedData[0] == 110)
                    {
                        //check Checksum
                        int checksum = 0;
                        for (int i = 0; i < dataLength - 2; i++)
                        {
                            checksum += receivedData[i];
                        }
                        int packetCheckSum = receivedData[dataLength - 2] * 128 + receivedData[dataLength - 1];
                        //if (checksum == packetCheckSum)
                        //checksum 말고 다른방법 구현
                        if (true)
                        {
                            //parse machineCode
                            int machineBytesLength = receivedData[1] * 128 + receivedData[2];
                            byte[] machineBytes = new byte[machineBytesLength];

                            int fieldBytesLength = receivedData[machineBytesLength + 3] * 128 + receivedData[machineBytesLength + 4];
                            byte[] fieldBytes = new byte[fieldBytesLength];

                            Array.Copy(receivedData, 3, machineBytes, 0, machineBytesLength);
                            Array.Copy(receivedData, machineBytesLength + 5, fieldBytes, 0, fieldBytesLength);

                            //getValues from modbus then send back value data

                            string machineCode = Encoding.UTF8.GetString(machineBytes);
                            string fields = Encoding.UTF8.GetString(fieldBytes);
                            string[] fieldCodes = fields.Split('=');
                            Console.WriteLine(machineCode + "             " + fields);

                            bool isConnected = MethodMain.GetMachineConnectionStateByMachineCode(machineCode);
                            string[] values = MethodMain.GetMachineData(machineCode, fieldCodes);

                            byte[] sendPacket = makeResponsePacket(machineCode, isConnected, values);
                            client.Send(sendPacket, SocketFlags.None);

                        }
                    }
                }

            }
            catch
            {
            }
            finally
            {
                client.Close();
                client.Dispose();
            }
        }

        public byte[] makeResponsePacket(string machineCode, bool isConnected, string[] fieldValues)
        {
            string fields = string.Empty;
            for (int i = 0; i < fieldValues.Length; i++)
            {
                fields += fieldValues[i];
                if (i < fieldValues.Length - 1)
                    fields += "=";
            }
            byte[] machineBytes = Encoding.UTF8.GetBytes(machineCode);
            byte[] fieldBytes = Encoding.UTF8.GetBytes(fields);

            int machineBytesLength = machineBytes.Length;
            int fieldBytesLength = fieldBytes.Length;


            //순서대로 응답/요청 코드, 설비상태,  설비명길이1, 길이2, 설비명, 항목값길이1, 길이2, 항목값, 체크섬
            byte[] responsePacket = new byte[1 + 1 + 2 + machineBytesLength + 2 + fieldBytesLength +  2];
            
            responsePacket[0] = 120; // requestCode 
            responsePacket[1] = isConnected ? (byte)1 : (byte)0;
            responsePacket[2] = (byte)(int)(machineBytesLength / 128);
            responsePacket[3] = (byte)(int)(machineBytesLength % 128);
            Array.Copy(machineBytes, 0, responsePacket, 4, machineBytesLength);


            responsePacket[machineBytesLength +4] = (byte)(int)(fieldBytesLength / 128);
            responsePacket[machineBytesLength +5] = (byte)(int)(fieldBytesLength % 128);
            Array.Copy(fieldBytes, 0, responsePacket, machineBytesLength + 6, fieldBytesLength);

            int checksum = 0;
            for (int i = 0; i < responsePacket.Length - 2; i++)
            {
                checksum += responsePacket[i];
            }

            responsePacket[responsePacket.Length - 2] = (byte)(int)(checksum / 128);
            responsePacket[responsePacket.Length - 1] = (byte)(int)(checksum % 128);
            return responsePacket;
        }



        private void SendMessage(object _obj)
        {
            AsyncObject obj = (AsyncObject)_obj;
            Socket client = obj.SocketWorkingClient;
            byte[] sendData = obj.ByteArray;
            
            try
            {
                client.BeginSend(sendData, 0, sendData.Length, SocketFlags.None,new AsyncCallback(SendMessageCallBack), obj);
            }
            catch (SocketException ex)
            {
                ConLost(client);
                ClientSocketList.Remove(client);
                if (ex.SocketErrorCode == SocketError.ConnectionReset)
                {
                }
            }
        }

        private void SendMessageCallBack(IAsyncResult result)
        {
        }

        public void SendData(byte[] data, Socket client)
        {
            try
            {
                client.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendMessageCallBack), client);
            }
            catch (SocketException ex)
            {
                ConLost(client);
                ClientSocketList.Remove(client);
                LogWriter.WriteLog_Error(ex);
            }
        }

        public void SendDataToConnectedClient(byte[] data)
        {
            
            for (int i = 0; i < ClientSocketList.Count; i++)
            {
                Socket client = ClientSocketList[i];
                SendData(data, client);
            }
        }

        public void Dispose()
        {
            if (ServerSocket != null)
            {
                if (ServerSocket.Connected)
                {
                    try
                    {
                        ServerSocket.Shutdown(SocketShutdown.Both);
                    }
                    catch (Exception ex)
                    {
                        LogWriter.WriteLog_Error(ex);
                    }
                    ServerSocket.Close();
                }
                ServerSocket = null;
            }
        }

    }
}
