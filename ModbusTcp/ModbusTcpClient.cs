﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;


namespace ModbusTcp
{
    public class ModbusTcpClient
    {
        
        /*
         * 개별 Byte는 Big-Endian로 전송된다. Byte내의 Bit는 LSB가 낮은 주소.
         * ex) 레지스터1, 레지스터2 의 Data를 받으면
         * ....[reg1][reg2].... 순서로 온다.
         * [reg1]이 3일때 bit값을 살펴보면
         * 00000110  2,3번 주소의 bit값이 1.
         * Array 사용시 Index와 주소 매칭을 위해 Array.Reverse 사용한다.
         * */
        public class ModbusProtocol
        {
            public readonly byte[] TransactionId = new byte[2];
            public readonly byte[] FrameLength = new byte[] { 0x00, 0x06 };
            public readonly byte UnitId;
            public readonly byte FunctionCode;
            public readonly byte[] StartAddress;
            public readonly byte[] NumberOfDatas;
            public ModbusProtocol(Enums.ModbusFunctionTypes _functionType, int transactionId, int _startAddress, int _numofDatas, int _unitId)
            {
                try
                {
                    int startAddress = _startAddress;
                    //
                    TransactionId = IntToByte(transactionId);
                    FunctionCode = (byte)_functionType;
                    StartAddress = IntToByte(startAddress);
                    NumberOfDatas = IntToByte(_numofDatas);
                    UnitId = (byte)_unitId;
                }
                catch
                {
                    throw new Exception("error while creating modbus protocol");
                }
               
            }

            public static ModbusProtocol ReadHoldingRegisterProtocol(int transactionId, int _startAddress, int _numofDatas, int _unitId)
            {
                return new ModbusProtocol(Enums.ModbusFunctionTypes.ReadHoldingRegisters, transactionId, _startAddress, _numofDatas, _unitId);
            }
        }

        /*
         * fields about Socket
         * */

        public delegate void ModbusDataReceiveHandler(string machineCode, string fieldCode, string value);
        public event ModbusDataReceiveHandler ModbusDataReceived;

        //public delegate void MachineCycleComplete(Dictionary<string, string> machineData, 
        //    MachineInfomation machineInfo, DateTime datetime, string cycleCount);
        public delegate void MachineCycleComplete(MachineInformation machineInfo, Dictionary<string,string> machineData, string cycleCount, bool cycleIncreased);
        public event MachineCycleComplete CycleCompleted;

        public delegate void MachineErrorUpdate(MachineInformation machineInfo, Dictionary<string, string> machineData);
        public event MachineErrorUpdate ErrorUpdated;

        public delegate void ConnectionSuccess(ModbusTcpClient client);
        public event ConnectionSuccess ConSuccess;

        public delegate void ConnectionLost(ModbusTcpClient client);
        public event ConnectionLost ConLost;

        //총성형횟수 ID를 찾아서 자동으로 등록.. ID를 찾는 방법 생각하기

        
        private readonly string[] machineStateCodes = {"A00001","A00002","A00003",
                                          "A00004", "A00005", "A00006",
                                          "A00007","A00008","A00009","A00011","A00080"};
        //아마 A00080으로 바뀔것
        private const string CYCLE_END_CODE = "A00080";
        private int ExCycleCount = -1;

        public Socket ClientSocket { get; set; }

        public MachineInformation MachineInfo { get; set; }
        private MapRow[] DataMap;
        private MapRow[] ErrorMap;

        private Dictionary<int, ArrayList> DataGroupConsecutive2 = new Dictionary<int, ArrayList>();
        private Dictionary<int, ArrayList> ErrorGroupConsecutive2 = new Dictionary<int, ArrayList>();

        private Dictionary<int, int> DataGroupConsecutive = new Dictionary<int, int>();
        private Dictionary<int, int> ErrorGroupConsecutive = new Dictionary<int, int>();

        System.Diagnostics.Stopwatch SW = new System.Diagnostics.Stopwatch();
        System.Diagnostics.Stopwatch SW2 = new System.Diagnostics.Stopwatch();


        //TXT 및 DB 저장용 자료구조
        private Dictionary<string, string> MachineDataDict = new Dictionary<string, string>();
        //<    transaction Id(address head), address tail>
        private Dictionary<int, ArrayList> AddressGroupLength100 = new Dictionary<int, ArrayList>();

        private Exception MainThreadException;


        public ModbusTcpClient(MachineInformation machineInfo)
        {
            try
            {
                this.MachineInfo = machineInfo;
                MapRow[] memorymap = machineInfo.Memorymap;

                //data 조회, error 조회  구분
                ArrayList errorList = new ArrayList();
                ArrayList dataList = new ArrayList();
                for (int i = 0; i < memorymap.Length; i++)
                {
                    MapRow row = memorymap[i];
                    if (row.IsUsed)
                    {
                        if (row.Code.Substring(0, 1).ToUpper().Equals("M"))
                            errorList.Add(row);
                        else
                            dataList.Add(row);
                    }
                }

                ErrorMap = (MapRow[])errorList.Cast<MapRow>().ToArray();
                DataMap = (MapRow[])dataList.Cast<MapRow>().ToArray();

                DataGroupConsecutive = GetConsecutiveAddressGroup(DataMap);
                ErrorGroupConsecutive = GetConsecutiveAddressGroup(ErrorMap);

                DataGroupConsecutive2 = GetConsecutiveAddressGroup2(DataMap);
                ErrorGroupConsecutive2 = GetConsecutiveAddressGroup2(ErrorMap);

                InitializeAddressGroupLength100(memorymap);
                InitializeAddressGroupConsecutive(memorymap);
                    
            }
            catch(Exception ex)
            {
                Console.WriteLine("ModbusTcpClient Exception");
                throw ex;
            }
        }

        ~ModbusTcpClient()
        {
            Dispose();
        }
        

        /// <summary>
        /// 사이클 횟수 증가여부 확인
        /// </summary>
        /// <returns>returns -1 if cycleis not completed </returns>
        private int getCycleCount()
        {
            MapRow cycleRow = FindMapRowByCode(CYCLE_END_CODE);
            //배열인덱스를 transaction id로 사용
            int transactionId = FindMapIndexByCode(CYCLE_END_CODE);
            int dataLength = cycleRow.DataLength;
            try
            {
                ModbusProtocol modbusProtocol =
                    ModbusProtocol.ReadHoldingRegisterProtocol(transactionId, cycleRow.Address, dataLength, MachineInfo.MachineNumber);
                byte[] dataToBeSent; 
                dataToBeSent = MakeReadFrame(modbusProtocol);

                ClientSocket.Send(dataToBeSent, SocketFlags.None);
                byte[] buffer = new byte[1024];
                int byteReceived = ClientSocket.Receive(buffer);
                if (byteReceived > 0)
                {

                    Dictionary<string, string> responseData = SingleDataParse(buffer);
                    //현재 사이클 업데이트
                    MachineDataDict[CYCLE_END_CODE] = responseData[CYCLE_END_CODE];
                    
                    if (responseData != null)
                    {
                        decimal currentCycleDecimal = Convert.ToDecimal(responseData[CYCLE_END_CODE]);
                        int currentCycle = Convert.ToInt32(currentCycleDecimal);

                        return currentCycle;
                        
                    }
                }
                throw new Exception("수신된 자료가 없습니다");
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
            
        
        }

        /// <summary>
        /// 머신 상태값들 조회 후 현재 사이클 갯수 반환
        /// </summary>
        /// <returns></returns>
        private int getMachineStates()
        {
            int currentCycle = 0;
            for (int i = 0; i < machineStateCodes.Length; i++)
            {
                MapRow cycleRow = FindMapRowByCode(machineStateCodes[i]);
                if (cycleRow != null)
                {
                    int dataLength = cycleRow.DataLength;
                    int transactionId = i;
                    string fieldCode = cycleRow.Code;
                    try
                    {
                        ModbusProtocol modbusProtocol =
                            ModbusProtocol.ReadHoldingRegisterProtocol(transactionId, cycleRow.Address, dataLength, MachineInfo.MachineNumber);
                        byte[] dataToBeSent;
                        dataToBeSent = MakeReadFrame(modbusProtocol);

                        ClientSocket.Send(dataToBeSent, SocketFlags.None);
                        byte[] buffer = new byte[1024];
                        int byteReceived = ClientSocket.Receive(buffer);
                        if (byteReceived > 0)
                        {

                            Dictionary<string, string> responseData = DataParse_MachineStates(buffer);
                            //현재 사이클 업데이트
                            MachineDataDict[fieldCode] = responseData[fieldCode];
                            
                            if(fieldCode == CYCLE_END_CODE)
                            {
                                decimal currentCycleDecimal = Convert.ToDecimal(responseData[CYCLE_END_CODE]);
                                currentCycle = Convert.ToInt32(currentCycleDecimal);
                            }
                        }
                        else
                            throw new Exception("수신된 자료가 없습니다");
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            return currentCycle;
            
           
        }



        public void DoWork()
        {
            try
            {
                ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                ClientSocket.SendTimeout = 2000;
                ClientSocket.ReceiveTimeout = 2000;
                ClientSocket.NoDelay = true;

                ClientSocket.Connect(MachineInfo.IpEnd);

                ConSuccess(this);

                DataTransferConsecutively2();
               

            }
            catch (SocketException ex)
            {
                string option = "error code = " + ex.ErrorCode;
                //code 10060 응답이없음(ex 전원off)
                //code 10061 연결거부 (ex 서버소켓 closed)
                Console.WriteLine("Do All Exception " + MachineInfo.IpEnd + option);
                MainThreadException = ex;
                LogWriter.WriteLog_Error(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Do All Exception " + MachineInfo.IpEnd + "    " + ex.Message);
                MainThreadException = ex;
                LogWriter.WriteLog_Error(ex);
               
            }
            finally
            {
                //통신 문제가 없다면 절대 실행되지 않음
                ConLost(this);
                Dispose();
            }
        }


        /// <summary>
        /// 개별 항목별로 데이터 송수신
        /// </summary>
        private void DataTransferSingle()
        {
            byte[] dataToBeSent;
            byte[] buffer;
            int byteReceived;
            while (true)
            {
                SW.Reset();
                SW.Start();

                int cycleCount = getCycleCount();
                if (cycleCount != ExCycleCount) //cycleCount > 0)
                {
                    ExCycleCount = cycleCount;
                    long sum = 0;
                    for (int i = 0; i < MachineInfo.Memorymap.Length; i++)
                    {
                        if (MachineInfo.Memorymap[i].IsUsed == true)
                        {
                            try
                            {
                                //maprow 순서 -> transactionId
                                int transactionId = i;

                                int startAddress = MachineInfo.Memorymap[i].Address;
                                int dataLength = 1;
                                ModbusProtocol mod = ModbusProtocol.ReadHoldingRegisterProtocol
                                    (transactionId, startAddress , dataLength, MachineInfo.MachineNumber);
                                
                                dataToBeSent = MakeReadFrame(mod);

                                SW2.Reset();
                                SW2.Start();

                                ClientSocket.Send(dataToBeSent, SocketFlags.None);
                                buffer = new byte[1024];

                                byteReceived = ClientSocket.Receive(buffer);

                                SW2.Stop();
                                sum += SW2.ElapsedMilliseconds;
                                if (byteReceived > 0)
                                {
                                    Dictionary<string, string> responseData = SingleDataParse(buffer);
                                    if (responseData != null)
                                    {
                                        string fieldCode = responseData.Keys.ToArray()[0];
                                        string value = responseData.Values.ToArray()[0];

                                        int machineNumber = Convert.ToInt16(MachineInfo.MachineNumber);
                                        string machineCode = MachineInfo.MachineCode;


                                        //THIS 에 저장
                                        MachineDataDict[fieldCode] = value;
                                        //CALLER 에 데이터 전달
                                        //ModbusDataReceived(machineCode, fieldCode, value);
                                    }

                                }
                            }
                            catch (SocketException socketEx)
                            {
                                throw socketEx;
                            }
                            catch (Exception ex)
                            {
                                LogWriter.WriteLog_Error(ex);
                            }
                        }

                    }//모든 항목 조회 완료
                    Console.WriteLine(MachineInfo.MachineCode + " 송수신 + 파싱 시간 합 " + sum);
                    //CycleCompleted(MachineInfo, MachineDataDict, Convert.ToString(cycleCount));

                    SW.Stop();
                    Console.WriteLine("경과시간2 " + SW.ElapsedMilliseconds);

                    
                    //start save data on db

                }
                //every 2sec inquery new cycle or not
                Thread.Sleep(2000);

               
            }

        }
        /// <summary>
        /// 100개단위로
        /// </summary>
        private void DataTransferLength100()
        {
            byte[] dataToBeSent;
            byte[] buffer;
            int byteReceived;
            while (true)
            {
                SW.Reset();
                SW.Start();

                int cycleCount = getCycleCount();
                if (cycleCount != ExCycleCount)//cycleCount > 0)
                {
                    ExCycleCount= cycleCount;
                    long sum = 0;
                    long sum2 = 0;
                    int[] heads = AddressGroupLength100.Keys.ToArray();
                    for (int i = 0; i < AddressGroupLength100.Count; i++)
                    {
                        int transactionId = heads[i];
                        int startAddress = heads[i] * 100;
                        int dataLength = 100;
                        ModbusProtocol mod = ModbusProtocol.ReadHoldingRegisterProtocol
                            (transactionId, startAddress, dataLength, MachineInfo.MachineNumber);

                        dataToBeSent = MakeReadFrame(mod);

                        DateTime d1 = DateTime.Now;

                        ClientSocket.Send(dataToBeSent, SocketFlags.None);
                        buffer = new byte[2048];

                        byteReceived = ClientSocket.Receive(buffer);

                        DateTime d2 = DateTime.Now;
                        sum += (d2 - d1).Ticks / 10000;
                        if (byteReceived > 0)
                        {
                            DateTime d3 = DateTime.Now;
                            DataParse_Length100(buffer);
                            DateTime d4 = DateTime.Now;
                            sum2 += (d4 - d3).Ticks / 10000;
                        }


                    }
                    Console.WriteLine(MachineInfo.MachineCode + " 데이터 송수신 합계: " + sum);
                    Console.WriteLine(MachineInfo.MachineCode + " 데이터 파싱 합계: " + sum2);
                    //CycleCompleted(MachineInfo, MachineDataDict, Convert.ToString(cycleCount));
                    //start save data on db
                    SW.Stop();
                    Console.WriteLine(MachineInfo.MachineCode + " 총 경과시간 " + SW.ElapsedMilliseconds);
                }
                //every 2sec inquery new cycle or not
                //for test frequncy 10sec
                Thread.Sleep(500);


            }
        }

        /// <summary>
        /// 연속된 숫자 그룹
        /// </summary>
        private void DataTransferConsecutively()
        {
            byte[] dataToBeSent;
            byte[] buffer;
            int byteReceived;

            int errorChecker = 0;
            //기본적으로 사이클 갯수가 업데이트 될때 데이터를 갱신한다.
            //사출기 사이클 갯수가 업데이트 되지 않을 경우 default 시간을 정해서 
            //해당 시간 마다 데이터 조회
            int dataChecker = 0;

            while (true)
            {
                SW.Reset();
                SW.Start();

                int cycleCount = getCycleCount();
                bool cycleIncreased = cycleCount != ExCycleCount ? true : false;
                bool needDataRefresh = cycleIncreased || dataChecker > 100 ? true : false;
                
                if (needDataRefresh)
                {
                    //데이터 조회
                    ExCycleCount = cycleCount;
                    dataChecker = 0;
                    long sum = 0;
                    long sum2 = 0;
                    int[] startAddresses = DataGroupConsecutive.Keys.ToArray();
                    for (int i = 0; i < DataGroupConsecutive.Count; i++)
                    {
                        int transactionId = i;
                        int startAddress = startAddresses[i];
                        int dataLength = DataGroupConsecutive[startAddress];
                        ModbusProtocol mod = ModbusProtocol.ReadHoldingRegisterProtocol
                            (transactionId, startAddress, dataLength, MachineInfo.MachineNumber);

                        dataToBeSent = MakeReadFrame(mod);

                        DateTime d1 = DateTime.Now;

                        ClientSocket.Send(dataToBeSent, SocketFlags.None);
                        buffer = new byte[2048];

                        byteReceived = ClientSocket.Receive(buffer);

                        DateTime d2 = DateTime.Now;
                        sum += (d2 - d1).Ticks / 10000;
                        if (byteReceived > 0)
                        {
                            dataToBeSent = MakeReadFrame(mod);

                            DateTime d3 = DateTime.Now;
                            DataParse_Consecutive(buffer, true);
                            DateTime d4 = DateTime.Now;
                            sum2 += (d4 - d3).Ticks / 10000;
                        }


                    }
                    Console.WriteLine(MachineInfo.MachineCode + " 데이터 송수신 합계: " + sum);
                    Console.WriteLine(MachineInfo.MachineCode + " 데이터 파싱 합계: " + sum2);
                    CycleCompleted(MachineInfo, MachineDataDict, Convert.ToString(cycleCount), cycleIncreased);
                    //start save data on db
                    SW.Stop();
                    Console.WriteLine(MachineInfo.MachineCode + " 데이터 총 경과시간 " + SW.ElapsedMilliseconds);
                }
                //every 500mSec inquery new cycle or not
                Thread.Sleep(500);
                dataChecker++;
                errorChecker++;

                //10회마다 에러 코드 조회
                if (errorChecker == 10)
                {
                    errorChecker = 0;
                    SW.Reset();
                    SW.Start();
                    //에러 조회
                    long sum = 0;
                    long sum2 = 0;
                    int[] startAddresses = ErrorGroupConsecutive.Keys.ToArray();
                    for (int i = 0; i < ErrorGroupConsecutive.Count; i++)
                    {
                        int transactionId = i;
                        int startAddress = startAddresses[i];
                        int dataLength = ErrorGroupConsecutive[startAddress];
                        ModbusProtocol mod = ModbusProtocol.ReadHoldingRegisterProtocol
                            (transactionId, startAddress, dataLength, MachineInfo.MachineNumber);

                        dataToBeSent = MakeReadFrame(mod);
                        DateTime d1 = DateTime.Now;

                        ClientSocket.Send(dataToBeSent, SocketFlags.None);
                        buffer = new byte[2048];
                        byteReceived = ClientSocket.Receive(buffer);

                        DateTime d2 = DateTime.Now;
                        sum += (d2 - d1).Ticks / 10000;
                        if (byteReceived > 0)
                        {
                            dataToBeSent = MakeReadFrame(mod);

                            DateTime d3 = DateTime.Now;
                            DataParse_Consecutive(buffer, false);
                            DateTime d4 = DateTime.Now;
                            sum2 += (d4 - d3).Ticks / 10000;
                        }


                    }
                    Console.WriteLine(MachineInfo.MachineCode + " 에러 송수신 합계: " + sum);
                    Console.WriteLine(MachineInfo.MachineCode + " 에러 파싱 합계: " + sum2);
                    ErrorUpdated(MachineInfo, MachineDataDict);
                    //start save data on db
                    SW.Stop();
                    Console.WriteLine(MachineInfo.MachineCode + " 에러 총 경과시간 " + SW.ElapsedMilliseconds);
                }
                

            }
        }

        /// <summary>
        /// 연속된 숫자 그룹
        /// </summary>
        private void DataTransferConsecutively2()
        {
            byte[] dataToBeSent;
            byte[] buffer;
            int byteReceived;

            int errorChecker = 0;
            //기본적으로 사이클 갯수가 업데이트 될때 데이터를 갱신한다.
            //사출기 사이클 갯수가 업데이트 되지 않을 경우 default 시간을 정해서 
            //해당 시간 마다 데이터 조회
            int dataChecker = 0;
            while (true)
            {
                SW.Reset();
                SW.Start();

                //int cycleCount = getCycleCount();
                int cycleCount = -100;
                try
                {
                    cycleCount = getMachineStates();
                }
                catch(Exception ex)
                {
                    LogWriter.WriteLog_Error(ex);
                }
               
                bool cycleIncreased = cycleCount != ExCycleCount ? true : false;
                bool needDataRefresh = cycleIncreased || dataChecker > 100 ? true : false;

                if (needDataRefresh)
                {
                    //데이터 조회
                    ExCycleCount = cycleCount;
                    dataChecker = 0;
                    long sum = 0;
                    long sum2 = 0;
                    int[] startAddresses = DataGroupConsecutive2.Keys.ToArray();
                    try
                    {
                        for (int i = 0; i < DataGroupConsecutive2.Count; i++)
                        {
                            int transactionId = i;
                            int startAddress = startAddresses[i];
                            int dataLength = getLengthSum(DataGroupConsecutive2[startAddress]);
                            ModbusProtocol mod = ModbusProtocol.ReadHoldingRegisterProtocol
                                (transactionId, startAddress, dataLength, MachineInfo.MachineNumber);

                            dataToBeSent = MakeReadFrame(mod);

                            DateTime d1 = DateTime.Now;

                            ClientSocket.Send(dataToBeSent, SocketFlags.None);
                            buffer = new byte[2048];

                            byteReceived = ClientSocket.Receive(buffer);

                            DateTime d2 = DateTime.Now;
                            sum += (d2 - d1).Ticks / 10000;
                            if (byteReceived > 0)
                            {
                                DateTime d3 = DateTime.Now;
                                DataParse_Consecutive2(buffer, true);
                                DateTime d4 = DateTime.Now;
                                sum2 += (d4 - d3).Ticks / 10000;
                            }


                        }
                    }
                    catch(Exception ex)
                    {
                        LogWriter.WriteLog_Error(ex);
                    }
                    
                    Console.WriteLine(MachineInfo.MachineCode + " 데이터 송수신 합계: " + sum);
                    Console.WriteLine(MachineInfo.MachineCode + " 데이터 파싱 합계: " + sum2);
                    CycleCompleted(MachineInfo, MachineDataDict, Convert.ToString(cycleCount), cycleIncreased);
                    //start save data on db
                    SW.Stop();
                    Console.WriteLine(MachineInfo.MachineCode + " 데이터 총 경과시간 " + SW.ElapsedMilliseconds);
                }
                //every 500mSec inquery new cycle or not
                Thread.Sleep(500);
                dataChecker++;
                errorChecker++;

                //20회마다 에러 코드 조회
                if (errorChecker > 20)
                {
                    errorChecker = 0;
                    SW.Reset();
                    SW.Start();
                    //에러 조회
                    long sum = 0;
                    long sum2 = 0;
                    int[] startAddresses = ErrorGroupConsecutive2.Keys.ToArray();
                    try
                    {
                        for (int i = 0; i < ErrorGroupConsecutive2.Count; i++)
                        {
                            int transactionId = i;
                            int startAddress = startAddresses[i];
                            int dataLength = getLengthSum(ErrorGroupConsecutive2[startAddress]);

                            ModbusProtocol mod = ModbusProtocol.ReadHoldingRegisterProtocol
                                (transactionId, startAddress, dataLength, MachineInfo.MachineNumber);

                            dataToBeSent = MakeReadFrame(mod);
                            DateTime d1 = DateTime.Now;

                            ClientSocket.Send(dataToBeSent, SocketFlags.None);
                            buffer = new byte[2048];
                            byteReceived = ClientSocket.Receive(buffer);

                            DateTime d2 = DateTime.Now;
                            sum += (d2 - d1).Ticks / 10000;
                            if (byteReceived > 0)
                            {
                                DateTime d3 = DateTime.Now;
                                DataParse_Consecutive2(buffer, false);
                                DateTime d4 = DateTime.Now;
                                sum2 += (d4 - d3).Ticks / 10000;
                            }


                        }
                    }
                    catch(Exception ex)
                    {
                        LogWriter.WriteLog_Error(ex);
                    }
                    
                    Console.WriteLine(MachineInfo.MachineCode + " 에러 송수신 합계: " + sum);
                    Console.WriteLine(MachineInfo.MachineCode + " 에러 파싱 합계: " + sum2);
                    ErrorUpdated(MachineInfo, MachineDataDict);
                    //start save data on db
                    SW.Stop();
                    Console.WriteLine(MachineInfo.MachineCode + " 에러 총 경과시간 " + SW.ElapsedMilliseconds);
                }

            }//end of while
        }




        private Dictionary<string,string> makeErrorDictionary(DataTable memoryMap)
        {
            Dictionary<string,string> errorDict = new Dictionary<string,string>();
            foreach (DataRow row in memoryMap.Rows)
            {
                string fieldCode = row["FIELD_CODE"].ToString();
                if (fieldCode.Substring(0, 1).ToUpper().Equals("M"))
                {
                    errorDict[fieldCode] = "0";
                }
            }
            return errorDict;
        }

        private Dictionary<string,string> SingleDataParse(byte[] sourceData)
        {
            try
            {
                int functionCode = sourceData[(int)Enums.ModbusIndex.FunctionCode];
                if (functionCode < 0x80)
                {
                    ushort transactionId = (ushort)(sourceData[(int)Enums.ModbusIndex.TransactionId_1st] * 256
                        + sourceData[(int)Enums.ModbusIndex.TransactionId_2nd]);

                    MapRow row = MachineInfo.Memorymap[transactionId];
                   
                    //memoryMap에 등록된 것은 맵에서 정보 읽기
                    if (row != null)
                    {
                        string fieldCode = row.Code;
                        int decimalPoint = row.DecimalPoint;
                        
                        int dataLength = sourceData[(int)Enums.ModbusIndex.ResponseByteLength];
                        double[] dataArray = new double[dataLength / 2];

                        double totalValue = 0;
                        int powerIndex = 0;
                        for (int i = 0; i < dataArray.Length; i++)
                        {
                            double value = sourceData[(int)Enums.ModbusIndex.ResponseData_1st + (2 * i)] * 256
                                + sourceData[(int)Enums.ModbusIndex.ResponseData_2nd + (2 * i)];

                            totalValue += value * Math.Pow(65536, powerIndex++) ;
                        }
                        double doubleValue = DivideByDecimalPoint(totalValue, decimalPoint);
                        string stringValue = ValueToString(doubleValue, decimalPoint);

                        //자료구조에 값 저장
                        return new Dictionary<string, string>() { { fieldCode, stringValue } };

                        
                    }
                    return null;
                }
                else if (functionCode > 0x80)//erexception occurs
                {
                    int exceptionCode = sourceData[(int)Enums.ModbusIndex.ExceptionCode];
                    Enums.ModbusExceptionCode code = (Enums.ModbusExceptionCode)exceptionCode;
                    string msg = "ModbusException FunctionCode : " + functionCode;
                    msg += code.ToString();
                    LogWriter.WriteLog_Data(msg, "ModbusException", MachineInfo.MachineName);
                    return null;
                }
                return null;
                
            }
            catch (Exception ex)
            {
                LogWriter.WriteLog_Error(ex);
                return null;
            }


        }

        private Dictionary<string, string> DataParse_MachineStates(byte[] sourceData)
        {
            try
            {
                int functionCode = sourceData[(int)Enums.ModbusIndex.FunctionCode];
                if (functionCode < 0x80)
                {
                    ushort transactionId = (ushort)(sourceData[(int)Enums.ModbusIndex.TransactionId_1st] * 256
                        + sourceData[(int)Enums.ModbusIndex.TransactionId_2nd]);

                    string fieldCode = machineStateCodes[transactionId];
                    MapRow row = FindMapRowByCode(fieldCode);
                    if (row != null)
                    {
                        int decimalPoint = row.DecimalPoint;

                        int dataLength = sourceData[(int)Enums.ModbusIndex.ResponseByteLength];
                        double[] dataArray = new double[dataLength / 2];

                        double totalValue = 0;
                        int powerIndex = 0;
                        for (int i = 0; i < dataArray.Length; i++)
                        {
                            double value = sourceData[(int)Enums.ModbusIndex.ResponseData_1st + (2 * i)] * 256
                                + sourceData[(int)Enums.ModbusIndex.ResponseData_2nd + (2 * i)];

                            totalValue += value * Math.Pow(65536, powerIndex++);
                        }
                        double doubleValue = DivideByDecimalPoint(totalValue, decimalPoint);
                        string stringValue = ValueToString(doubleValue, decimalPoint);

                        //자료구조에 값 저장
                        return new Dictionary<string, string>() { { fieldCode, stringValue } };


                    }
                    return null;
                }
                else if (functionCode > 0x80)//erexception occurs
                {
                    int exceptionCode = sourceData[(int)Enums.ModbusIndex.ExceptionCode];
                    Enums.ModbusExceptionCode code = (Enums.ModbusExceptionCode)exceptionCode;
                    string msg = "ModbusException FunctionCode : " + functionCode;
                    msg += code.ToString();
                    LogWriter.WriteLog_Data(msg, "ModbusException", MachineInfo.MachineName);
                    return null;
                }
                return null;

            }
            catch (Exception ex)
            {
                LogWriter.WriteLog_Error(ex);
                return null;
            }


        }



        private void DataParse_Length100(byte[] sourceData)
        {
            try
            {
                int functionCode = sourceData[(int)Enums.ModbusIndex.FunctionCode];
                if (functionCode < 0x80)
                {
                    ushort transactionId = (ushort)(sourceData[(int)Enums.ModbusIndex.TransactionId_1st] * 256
                        + sourceData[(int)Enums.ModbusIndex.TransactionId_2nd]);

                    int addressHead = transactionId;
                    ArrayList tails = AddressGroupLength100[addressHead];
                    int dataLength = sourceData[(int)Enums.ModbusIndex.ResponseByteLength];
                    //dataLength sholud be 200
                    double[] dataArray = new double[dataLength / 2];
                    string valueString = string.Empty;

                   
                    for (int i = 0; i < dataArray.Length; i++)
                    {
                        double value = sourceData[(int)Enums.ModbusIndex.ResponseData_1st + (2 * i)] * 256
                            + sourceData[(int)Enums.ModbusIndex.ResponseData_2nd + (2 * i)];
                        int addressTail = i; 
                        if (tails.Contains(addressTail))
                        {
                            int startAddress = addressHead * 100 + addressTail;

                            MapRow row = FindMapRowByAddress(startAddress);
                            if (row != null)
                            {
                                string fieldCode = row.Code;
                                int decimalPoint = row.DecimalPoint;
                                
                                dataArray[i] = DivideByDecimalPoint(value, decimalPoint);
                                valueString = ValueToString(dataArray[i], decimalPoint);

                                MachineDataDict[fieldCode] = valueString;
                            }
                        }
                    }
                  
                }
                else if (functionCode > 0x80)//erexception occurs
                {
                    int exceptionCode = sourceData[(int)Enums.ModbusIndex.ExceptionCode];
                    Enums.ModbusExceptionCode code = (Enums.ModbusExceptionCode)exceptionCode;
                    string msg = "ModbusException FunctionCode : " + functionCode;
                    msg += code.ToString();
                    LogWriter.WriteLog_Data(msg, "ModbusException", MachineInfo.MachineName);
                   
                }

            }
            catch (Exception ex)
            {
                LogWriter.WriteLog_Error(ex);
            }


        }

        /// <summary>
        /// data 및 error 조회 구분
        /// </summary>
        /// <param name="sourceData"></param>
        /// <param name="isData"></param>
        private void DataParse_Consecutive(byte[] sourceData, bool isData)
        {
            try
            {
                int functionCode = sourceData[(int)Enums.ModbusIndex.FunctionCode];
                if (functionCode < 0x80)
                {
                    ushort transactionId = (ushort)(sourceData[(int)Enums.ModbusIndex.TransactionId_1st] * 256
                        + sourceData[(int)Enums.ModbusIndex.TransactionId_2nd]);

                    Dictionary<int, int> AddressGroupConsecutive = new Dictionary<int, int>(); ;
                    if (isData == true)
                        AddressGroupConsecutive = DataGroupConsecutive;
                    else
                        AddressGroupConsecutive = ErrorGroupConsecutive;

                    int[] startAddresses = AddressGroupConsecutive.Keys.ToArray();
                    int startAddress = startAddresses[transactionId];
                    int dataLength = sourceData[(int)Enums.ModbusIndex.ResponseByteLength];
                    double[] dataArray = new double[dataLength / 2];
                    string valueString = string.Empty;

                    for (int i = 0; i < dataArray.Length; i++)
                    {
                        double value = sourceData[(int)Enums.ModbusIndex.ResponseData_1st + (2 * i)] * 256
                            + sourceData[(int)Enums.ModbusIndex.ResponseData_2nd + (2 * i)];
                        int address = startAddress + i;
                        MapRow row = FindMapRowByAddress(address);
                        dataArray[i] = DivideByDecimalPoint(value, row.DecimalPoint);
                        valueString = ValueToString(dataArray[i], row.DecimalPoint);
                        //생산 수량은 생산수량 확인할때 자료 미리 갱신
                        if(row.Code.ToUpper().Equals(CYCLE_END_CODE) == false)
                            MachineDataDict[row.Code] = valueString;
                        
                    }

                }
                else if (functionCode > 0x80)//erexception occurs
                {
                    int exceptionCode = sourceData[(int)Enums.ModbusIndex.ExceptionCode];
                    Enums.ModbusExceptionCode code = (Enums.ModbusExceptionCode)exceptionCode;
                    string msg = "ModbusException FunctionCode : " + functionCode;
                    msg += code.ToString();
                    LogWriter.WriteLog_Data(msg, "ModbusException", MachineInfo.MachineName);

                }

            }
            catch (Exception ex)
            {
                LogWriter.WriteLog_Error(ex);
            }


        }

        /// <summary>
        /// data 및 error 조회 구분
        /// </summary>
        /// <param name="sourceData"></param>
        /// <param name="isData"></param>
        private void DataParse_Consecutive2(byte[] sourceData, bool isData)
        {
            try
            {
                int functionCode = sourceData[(int)Enums.ModbusIndex.FunctionCode];
                if (functionCode < 0x80)
                {
                    ushort transactionId = (ushort)(sourceData[(int)Enums.ModbusIndex.TransactionId_1st] * 256
                        + sourceData[(int)Enums.ModbusIndex.TransactionId_2nd]);

                    Dictionary<int, ArrayList> AddressGroupConsecutive = new Dictionary<int, ArrayList>(); ;
                    if (isData == true)
                        AddressGroupConsecutive = DataGroupConsecutive2;
                    else
                        AddressGroupConsecutive = ErrorGroupConsecutive2;

                    int[] startAddresses = AddressGroupConsecutive.Keys.ToArray();
                    int startAddress = startAddresses[transactionId];
                    ArrayList singleDataLengthList = AddressGroupConsecutive[startAddress];

                    int totalDataLength = sourceData[(int)Enums.ModbusIndex.ResponseByteLength];

                    int address = startAddress;
                    for (int i = 0; i < singleDataLengthList.Count; i++)
                    {
                        //MapRow row = FindMapRowByAddress(address);
                        MapRow[] rows = FindEveryMapRowsByAddress(address);

                        MapRow row = rows[0];
                        int singleDataLength = (int)singleDataLengthList[i];
                        int decimalPoint = row.DecimalPoint;

                        double totalValue = 0;
                        int powerIndex = 0;
                        for (int j = i; j < i + singleDataLength; j++)
                        {
                            double value = sourceData[(int)Enums.ModbusIndex.ResponseData_1st + (2 * j)] * 256
                              + sourceData[(int)Enums.ModbusIndex.ResponseData_2nd + (2 * j)];

                            //totalValue += value * Math.Pow(ushort.MaxValue, powerIndex++);
                            totalValue += value * Math.Pow(65536, powerIndex++);
                        }
                        double doubleValue = DivideByDecimalPoint(totalValue, decimalPoint);
                        string stringValue = ValueToString(doubleValue, decimalPoint);

                        //같은 주소를 가지는 모든코드에 값 저장
                        for (int rowIndex = 0; rowIndex < rows.Length; rowIndex++)
                        {
                            MachineDataDict[rows[rowIndex].Code] = stringValue;
                        }

                        address += singleDataLength;

                    }

                }
                else if (functionCode > 0x80)//erexception occurs
                {
                    int exceptionCode = sourceData[(int)Enums.ModbusIndex.ExceptionCode];
                    Enums.ModbusExceptionCode code = (Enums.ModbusExceptionCode)exceptionCode;
                    string msg = "ModbusException FunctionCode : " + functionCode;
                    msg += code.ToString();
                    LogWriter.WriteLog_Data(msg, "ModbusException", MachineInfo.MachineName);

                }

            }
            catch (Exception ex)
            {
                LogWriter.WriteLog_Error(ex);
            }


        }

        public double DivideByDecimalPoint(double originalValue, int decimalPoint)
        {
            if (decimalPoint > -1)
            {
                int divide = (int)Math.Pow(10, decimalPoint);
                return originalValue / divide;
            }
            return -1;
        }

        public string ValueToString(double value, int decimalPoint)
        {
            if (decimalPoint > -1)
            {
                string format = "N" + decimalPoint.ToString();
                return value.ToString(format);
            }
            return "";
        }


        public MapRow FindMapRowByAddress(int startAddress)
        {
            for (int i = 0; i < MachineInfo.Memorymap.Length; i++)
            {
                if (MachineInfo.Memorymap[i].Address == startAddress)
                    return MachineInfo.Memorymap[i];
            }
            return null;
            
        }

        public MapRow[] FindEveryMapRowsByAddress(int startAddress)
        {
            ArrayList arraylist = new ArrayList();
            for (int i = 0; i < MachineInfo.Memorymap.Length; i++)
            {
                if (MachineInfo.Memorymap[i].Address == startAddress)
                    arraylist.Add(MachineInfo.Memorymap[i]);
            }
            return (MapRow[])arraylist.Cast<MapRow>().ToArray();
        }

       
        public MapRow FindMapRowByCode(string fieldCode)
        {
            for (int i = 0; i < MachineInfo.Memorymap.Length; i++)
            {
                if (MachineInfo.Memorymap[i].Code == fieldCode)
                    return MachineInfo.Memorymap[i];
            }
            return null;
        }

        public int FindMapIndexByCode(string fieldCode)
        {
            for (int i = 0; i < MachineInfo.Memorymap.Length; i++)
            {
                if (MachineInfo.Memorymap[i].Code == fieldCode)
                    return i;
            }
            return -1;
        }

        public static int[] ByteToBitArray(byte _number)
        {
            int[] bitArray = new int[8];
            int i = 7;
            int number = (int)_number;
            int bitValue;
            while (number > 0)
            {
                bitValue = number % 2;
                number /= 2;
                bitArray[i--] = bitValue;
            }
            //ArrayIndex와 bit순서를 맞추기위함
            Array.Reverse(bitArray);
            return bitArray;
        }

        /// <summary>
        /// returns Uint16 from startIndex to startIndex+1 at source array
        /// </summary>
        internal static ushort ByteArrayToUint16(byte[] source, int startIndex)
        {
            if (startIndex > -1 && startIndex < source.Length - 1)
            {
                return (ushort)(source[startIndex] * 256 + source[startIndex + 1]);
            }
            else
                throw new Exception("Invalid startIndex");

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

        private byte[] MakeReadFrame(ModbusProtocol _modbus)
        {
            byte[] dataFrame = new byte[12];

            dataFrame[(int)Enums.ModbusIndex.TransactionId_1st] = _modbus.TransactionId[0];
            dataFrame[(int)Enums.ModbusIndex.TransactionId_2nd] = _modbus.TransactionId[1];
            dataFrame[(int)Enums.ModbusIndex.Length_1st] = _modbus.FrameLength[0];
            dataFrame[(int)Enums.ModbusIndex.Length_2nd] = _modbus.FrameLength[1];
            dataFrame[(int)Enums.ModbusIndex.UnitId] = _modbus.UnitId;

            //part of PDU
            dataFrame[(int)Enums.ModbusIndex.FunctionCode] = _modbus.FunctionCode;
            dataFrame[(int)Enums.ModbusIndex.StartAddress_1st] = _modbus.StartAddress[0];
            dataFrame[(int)Enums.ModbusIndex.StartAddress_2nd] = _modbus.StartAddress[1];
            dataFrame[(int)Enums.ModbusIndex.NumbersToRead_1st] = _modbus.NumberOfDatas[0];
            dataFrame[(int)Enums.ModbusIndex.NumbersToRead_2nd] = _modbus.NumberOfDatas[1];

            return dataFrame;
        }

        /// <summary>
        /// Return byte array with length 2, big-endian(NetworkByteOrder)
        /// </summary>
        public static byte[] IntToByte(ushort input)
        {
            byte[] output = BitConverter.GetBytes(input);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(output);

            return output;
        }

        public static byte[] IntToByte(int input)
        {
            return IntToByte((ushort)input);
        }

       

        public int[] FindIdToSave(DataTable mapTable)
        {
            try
            {
                int[] result = mapTable.AsEnumerable().Where(e => e.Field<string>("FIELD_SAVE") == "Y").Select(e => Convert.ToInt32(e.Field<double>("FIELD_ID"))).ToArray();
                return result;
            }
            catch { Console.WriteLine("FindFieldToSave"); return null; }
        }


        private Dictionary<int, int> getContinousNumbers(int[] numbers)
        {
            Array.Sort(numbers);
            int start = 0;

            //start, length
            Dictionary<int, int> con = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    start = numbers[0];
                    con[start] = 1;
                }
                else
                {
                    if (numbers[i] - numbers[i - 1] == 1 && con[start] <= 100)
                        con[start] += 1;
                    else
                    {
                        start = numbers[i];
                        con[start] = 1;
                    }
                }

            }
            return con;
        }




        private void InitializeAddressGroupLength100(MapRow[] memorymap)
        {
            //100개단위로 나누기
            for (int i = 0; i < memorymap.Length; i++)
            {
                if (memorymap[i].IsUsed == true)
                {
                    int address = memorymap[i].Address;
                        
                    int head = address / 100;
                    int tail = address % 100;
                    if (AddressGroupLength100.ContainsKey(head) == false)
                    {
                        ArrayList al = new ArrayList();
                        al.Add(tail);
                        AddressGroupLength100.Add(head, al);
                    }
                    else
                    {
                        ArrayList tails = AddressGroupLength100[head];
                        tails.Add(tail);
                        AddressGroupLength100[head] = tails;
                    }
                       
                }
            }
        }

        private void InitializeAddressGroupConsecutive(MapRow[] memorymap)
        {
            ///연속된 수 구하기
            ArrayList originalNumbers = new ArrayList();
            for (int i = 0; i < memorymap.Length; i++)
            {
                if (memorymap[i].IsUsed == true)
                {
                    int address = memorymap[i].Address;
                    originalNumbers.Add(address);
                }
            }

            int[] numbers = (int[])originalNumbers.ToArray(typeof(int));
        }

        /// <summary>
        /// 연속된 주소들을 찾는다. <시작번지, 갯수>
        /// </summary>
        /// <param name="memorymap"></param>
        /// <returns></returns>
        private Dictionary<int,int> GetConsecutiveAddressGroup(MapRow[] memorymap)
        {
            ///연속된 수 구하기
            ArrayList originalNumbers = new ArrayList();
            for (int i = 0; i < memorymap.Length; i++)
            {
                if (memorymap[i].IsUsed == true)
                {
                    int address = memorymap[i].Address;
                    originalNumbers.Add(address);
                }
            }

            int[] numbers = (int[])originalNumbers.ToArray(typeof(int));
            return getContinousNumbers(numbers);
        }

        /// <summary>
        /// 연속된 주소들을 찾는다. <시작번지, 각 주소별 데이터길이>
        /// </summary>
        /// <param name="memorymap"></param>
        /// <returns></returns>
        private Dictionary<int, ArrayList> GetConsecutiveAddressGroup2(MapRow[] memorymap)
        {
            IEnumerable<MapRow> IEnumerableMemorymap = from MapRow in memorymap
                                                       orderby MapRow.Address
                                                       where MapRow.IsUsed == true
                                                       select MapRow;


            MapRow[] sortedMemorymap = IEnumerableMemorymap.ToArray();

            int start = 0;

            //start, length list
            Dictionary<int, ArrayList> addressGroup = new Dictionary<int, ArrayList>();

            for (int i = 0; i < sortedMemorymap.Length; i++)
            {
                if (i == 0)
                {
                    start = sortedMemorymap[i].Address;
                    addressGroup[start] = new ArrayList();
                    addressGroup[start].Add(sortedMemorymap[i].DataLength);
                }
                else
                {
                    //i번재 항목 주소가 i-1번째보다 크고
                    //i-1번째 항목의 데이터 길이뒤에 다음항목주소이면 두 항목은 연결된 주소
                    bool isLarger = sortedMemorymap[i].Address > sortedMemorymap[i - 1].Address ? true : false;
                    bool isConsecutive = sortedMemorymap[i].Address - sortedMemorymap[i - 1].Address == sortedMemorymap[i - 1].DataLength
                        ? true : false;
                    //
                    if (isLarger)
                    {
                       

                        if (isConsecutive && getLengthSum(addressGroup[start]) <= 100)
                        {
                            addressGroup[start].Add(sortedMemorymap[i].DataLength);
                        }
                        else
                        {
                            start = sortedMemorymap[i].Address;
                            addressGroup[start] = new ArrayList();
                            addressGroup[start].Add(sortedMemorymap[i].DataLength);
                          
                        }

                    }

                }


            }
            return addressGroup;
        }


        private int getLengthSum(ArrayList list) {
            int sum = 0;
            foreach (object obj in list)
            {
                sum += (int)obj;
            }
            return sum;
        }

    }

}