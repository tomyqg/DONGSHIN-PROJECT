using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ModbusTcp
{
    public static class SpecialFieldCodes
    {
       /*
        * A1~A9 , A11
        * 수동 운전(Manual Mode)
            반자동 운전(Seml Auto Mode)
            전자동 운전(Full Auto Mode)
            자동운전 1CYCLE 완료
            사출기 전원 ON상태
            사출기 경보 상태
            히터 ON
            전동기 ON
            총 성형 횟수
        **/
        public static string[] stateCodes = {
                                          "A00001","A00002","A00003",
                                          "A00004", "A00005", "A00006",
                                          "A00007","A00008","A00009","A00011","S00002"
                                        };
        public static string[] moldNameCodes = new string[]{
                                "A00063","A00064","A00065","A00066", "A00067", 
                                "A00068", "A00069", "A00070", "A00071", "A00072",
                                "A00073", "A00074", "A00075","A00076", "A00077", "A00078"};
    }

    public class MachineInformation
    {
        public string MachineCode { get; set; }
        public string MachineName { get; set; }
        public int MachineNumber { get; set; }
        public string MachineType { get; set; }
        public MapRow[] Memorymap { get; set; }
        public IPEndPoint IpEnd { get; set; }
        public bool MachineState { get; set; }

        public MachineInformation(string machineCode, string machineName, int machineNumber,
            string machineType, MapRow[] memorymap, IPEndPoint ipEnd, int offset)
        {
            MachineCode = machineCode;
            MachineName = machineName;
            MachineNumber = machineNumber;
            MachineType = machineType;
            Memorymap = memorymap;
            IpEnd = ipEnd;
        }
        public MachineInformation() { }
    }

    public class MapRow
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Address { get; set; }
        public int DecimalPoint { get; set; }
        public int DataLength { get; set; }
        public bool IsUsed { get; set; }
        public bool IsSaved { get; set; }
        public string Reference { get; set; }
    }


    public class AsyncObject
    {
        
        public Byte[] ByteArray { get; set; }
        public Socket SocketWorkingClient { get; set; }

        public string unitId { get; set; }
        public string transactionId { get; set; }
        public string value { get; set; }

        public AsyncObject()
        {
            ByteArray = new Byte[1024];
        }
        public AsyncObject(int arraySize)
        {
            ByteArray = new Byte[arraySize];
        }
    }


    /// <summary>
    /// 쓰레드 파라미터
    /// machinecode 및 fieldcode로 요청
    /// 쓰레드 종료시 datadisplay 콜백실행
    /// </summary>
    public class DataDisplayParameter
    {
        public string[] MachineCodes { get; set; }
        public string[] FieldCodes { get; set; }
        public DataDisplayCallback Callback;
    }


    public class TcpResponse
    {
        public MachineResponseData[] MachineResponses { get; set; }
        public Exception Exception { get; set; }
    }
    public delegate void DataDisplayCallback(TcpResponse tcpResponse);

    /// <summary>
    /// 스레드 콜백으로 사용될 dataDisplay 콜백 파라미터
    /// 사출기별 코드 , 접속상태, 데이터 포함
    /// </summary>
    public class MachineResponseData
    {
        public string MachineCode { get; set; }
        public bool IsConnected { get; set; }
        public Dictionary<string, string> MachineData { get; set; }
        /// <summary>
        /// 데이터가 없거나 오류가 발생하거나 등등
        /// 기타사항을 표기. 
        /// 정상적인 결과에는 항상 string.empty
        /// </summary>
        public string Message { get; set; }

        public MachineResponseData()
        {
            IsConnected = false;
            Message = string.Empty;
            MachineData = new Dictionary<string, string>();

        }

    }
}
