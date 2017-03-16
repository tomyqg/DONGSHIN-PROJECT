using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Xml;

namespace ModbusTcp
{
    public static class MethodMain
    {

        public enum ConnectionState
        {
            Connected, Disconnected
        }

        public class ThreadObject
        {

            public PcTcpClient ClientPc { get; set; }
            public string MachineCode { get; set; }
            public string[] FieldCodes { get; set; }
            public ThreadObject(PcTcpClient clientSocket, string machineCode, string[] fieldCodes)
            {
                MachineCode = machineCode;
                ClientPc = clientSocket;
                FieldCodes = fieldCodes;
            }
        }
        // <machineCode, 접속 상태>
        private static Dictionary<ModbusTcpClient, ConnectionState> modbusConnectedList = new Dictionary<ModbusTcpClient, ConnectionState>();
        private static Dictionary<ModbusTcpClient, ConnectionState> clientConnectedList = new Dictionary<ModbusTcpClient, ConnectionState>();
        //<client, 접속 시도중 유무>
        private static Dictionary<ModbusTcpClient, bool> ModbusThreadStates = new Dictionary<ModbusTcpClient, bool>();

        //<설비코드,<항목코드, 항목값>>
        private static Dictionary<string, Dictionary<string, string>> EntireMachineData = new Dictionary<string, Dictionary<string, string>>();

        private static System.Timers.Timer Reconnectiontimer = new System.Timers.Timer();
        //private static Dictionary<Thread, ModbusTcpClient> ModbusConnectThreads;

        private static PcTcpServer ServerPc;
        public static IPEndPoint ServerIpEnd { get; set; }

        public static string CompanyCode { get; set; }

        //설비별 메모리맵
        private static Dictionary<string, MapRow[]> MemoryMaps = new Dictionary<string, MapRow[]>();
        //설비별 저장할 항목 메모리맵
        private static Dictionary<string, MapRow[]> MemoryMapsToSave = new Dictionary<string, MapRow[]>();
        
        public static DataTable LoadCompanyInfo(string companyCode)
        {   
            try
            {
                WebReference.WebService1 w = new WebReference.WebService1();
                return w.getCompanyInfo(companyCode);
            }
            catch
            {
                throw;
            }
        }

        public static DataTable LoadMachineList(string companyCode)
        {
            try
            {

                WebReference.WebService1 w = new WebReference.WebService1();
                //MessageBox.Show(w.Url);
                return w.getMachineIpList(companyCode);
            }
            catch
            {
                throw;
            }
        }

        public static DataTable LoadMemoryMap(string companyCode, string memoryMap)
        {
            try
            {

                WebReference.WebService1 w = new WebReference.WebService1();

                //MessageBox.Show(w.Url);
                return w.getMemorymap(companyCode, memoryMap);
            }
            catch
            {
                throw;
            }
        }


        public static DataTable LoadMachineListWithExcel(string filePath)
        {
            DataTable dt = GetDataTableFromExcel(filePath);
            return dt;
        }

        public static void ReadDbInformation(string filePath)
        {
            FileInfo fi = new FileInfo(filePath);

            if (fi.Exists)
            {
                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(filePath);

                    XmlElement root = doc.FirstChild as XmlElement;
                    XmlNodeList fieldList = root.ChildNodes;
                    string serverName = Encoding.UTF8.GetString(Convert.FromBase64String(fieldList.Item(0).InnerText));
                    string dbName = Encoding.UTF8.GetString(Convert.FromBase64String(fieldList.Item(1).InnerText));
                    string id = Encoding.UTF8.GetString(Convert.FromBase64String(fieldList.Item(2).InnerText));
                    string pw = Encoding.UTF8.GetString(Convert.FromBase64String(fieldList.Item(3).InnerText));
                }
                catch
                {
                    throw new Exception("SQL 정보가 잘못되었습니다.");
                }
            }
            throw new Exception("SQL파일이 존재하지 않습니다");
        }

        private static DataTable GetDataTableFromExcel(string filePath)
        {
            try
            {
                string oledbConString = string.Empty;
                DataTable resultTable = new DataTable();
                FileInfo fi = new FileInfo(filePath);
                if (fi.Exists)
                {
                    if (filePath.IndexOf(".xlsx") > -1)
                    {
                        oledbConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath
                            + ";Extended Properties=\"Excel 12.0\"";
                    }
                    else
                    {
                        oledbConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath
                               + ";Extended Properties=\"Excel 8.0\"";
                    }


                    using (OleDbConnection oleExcelCon = new OleDbConnection(oledbConString))
                    {
                        oleExcelCon.Open();

                        System.Data.DataTable dt = oleExcelCon.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                        string sheetName = dt.Rows[0]["TABLE_NAME"].ToString();
                        string query = string.Format("SELECT * FROM [{0}]", sheetName);



                        OleDbDataAdapter adt = new OleDbDataAdapter(query, oleExcelCon);
                        adt.Fill(resultTable);
                    }
                }

                return resultTable;
            }
            catch
            {
                throw;
            }
        }

        public static void ModbusConnect(MachineInformation[] machineInfos)
        {

            for (int i = 0; i < machineInfos.Length; i++)
            {
                MachineInformation machineInfo = machineInfos[i];

                try
                {
                    string machineCode = machineInfo.MachineCode;
                    MapRow[] memoryMap = machineInfo.Memorymap;
                    MemoryMaps[machineCode] = memoryMap;
                    MemoryMapsToSave[machineCode] = FindMapRowsToSave(memoryMap);

                    EntireMachineData[machineCode] = new Dictionary<string, string>(); ;

                    ModbusTcpClient modbusClient = new ModbusTcpClient(machineInfo);

                    modbusClient.ConSuccess += new ModbusTcpClient.ConnectionSuccess(ModbusConnected);
                    modbusClient.ConLost += new ModbusTcpClient.ConnectionLost(ModbusLost);
                    //modbusClient.ModbusDataReceived += new ModbusTcpClient.ModbusDataReceiveHandler(HandleModbusDataReceive);
                    modbusClient.CycleCompleted += new ModbusTcpClient.MachineCycleComplete(HandleSaveMachineData);
                    modbusClient.ErrorUpdated += new ModbusTcpClient.MachineErrorUpdate(HandleSaveMachineError);

                    modbusConnectedList.Add(modbusClient, ConnectionState.Disconnected);


                    Thread modThread = new Thread(new ParameterizedThreadStart(ModbusClientStart));
                    modThread.IsBackground = true;
                    modThread.Start(modbusClient);
                    ModbusThreadStates.Add(modbusClient, true);

                }
                catch(Exception ex)
                {
                    LogWriter.WriteLog_Error(ex);
                }
            }

            //재접속 타이머 실행
            Reconnectiontimer.Elapsed += new System.Timers.ElapsedEventHandler(ReconnectionTimer_Tick);
            Reconnectiontimer.Interval = 30000;
            Reconnectiontimer.Enabled = true;
        }

        private static MapRow[] GetMemoryRowsFromDataTable(DataTable memoryTable)
        {
            ArrayList mapList = new ArrayList();
            for (int i = 0; i < memoryTable.Rows.Count; i++)
            {
                DataRow dataRow = memoryTable.Rows[i];
                int address;
                if (int.TryParse(dataRow["FieldAddress"].ToString(), out address))
                {
                    MapRow map = new MapRow();
                    map.Address = address;
                    map.Code = dataRow["FieldCode"].ToString();
                    map.Name = dataRow["FieldName"].ToString();
                    int dataLength;
                    if (int.TryParse(dataRow["DataLength"].ToString(), out dataLength) == false)
                        dataLength = 1;
                    int decPoint;
                    if (int.TryParse(dataRow["DecimalPoint"].ToString(), out decPoint) == false)
                        decPoint = 0;

                    map.DataLength = dataLength;
                    map.DecimalPoint = decPoint;
                    map.IsUsed = dataRow["UseOrNot"].ToString().ToUpper().Equals("Y") ? true : false;
                    map.IsSaved = dataRow["SaveOrNot"].ToString().ToUpper().Equals("Y") ? true : false;
                    map.Reference = dataRow["Reference"].ToString();

                    mapList.Add(map);
                }
            }
            MapRow[] memorymap = (MapRow[])mapList.ToArray(typeof(MapRow));
            return memorymap;

        }

        private static void ReconnectionTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < modbusConnectedList.Count; i++)
            {
                KeyValuePair<ModbusTcpClient, ConnectionState> pair = modbusConnectedList.ToList()[i];
                ModbusTcpClient modClient = pair.Key;
                Console.WriteLine(pair.Key.MachineInfo.IpEnd + "    " + pair.Value + " " + ModbusThreadStates[modClient]);
                if (pair.Value == ConnectionState.Disconnected && ModbusThreadStates[modClient] == false)
                {
                    Thread modThread = new Thread(new ParameterizedThreadStart(ModbusClientStart));
                    modThread.IsBackground = true;
                    modThread.Start(modClient);
                    ModbusThreadStates[modClient] = true;
                }
            }

        }

        private static void ModbusClientStart(object _obj)
        {
            ModbusTcpClient mod = (ModbusTcpClient)_obj;
            mod.DoWork();
        }

        private static void ModbusConnected(ModbusTcpClient client)
        {
            modbusConnectedList[client] = ConnectionState.Connected;
        }

        private static void ModbusLost(ModbusTcpClient client)
        {
            modbusConnectedList[client] = ConnectionState.Disconnected;
            ModbusThreadStates[client] = false;

        }

        //사이클 증가된 경우에만 db저장 . 시간 지나서 데이터 업데이트 된경우에는 저장 x 
        //나중에 수정이 필요하다
        private static void HandleSaveMachineData(MachineInformation machineInfo,
                                Dictionary<string, string> newMachineData, string cycleCount, bool cycleIncreased)
        {
            System.Diagnostics.Stopwatch SW = new System.Diagnostics.Stopwatch();
            SW.Start();
            string machineCode = machineInfo.MachineCode;
            try
            {
                DateTime now = DateTime.Now;

                string moldName = getMoldNameFromServerSide(machineInfo.MachineCode);
                if (EntireMachineData.ContainsKey(machineCode))
                {
                    EntireMachineData[machineCode] = newMachineData;

                    if (cycleIncreased)
                    {
                        MapRow[] saveRows = MemoryMapsToSave[machineCode];
                        Dictionary<string, string> saveData = new Dictionary<string, string>();
                        for (int i = 0; i < saveRows.Length; i++)
                        {
                            string fieldCode = saveRows[i].Code;
                            if (newMachineData.ContainsKey(fieldCode))
                                saveData[fieldCode] = newMachineData[fieldCode];
                        }
                        //db save part
                        DbHelper.InsertMachineData(machineInfo, saveData, now, moldName, cycleCount);
                        //DbHelper.InsertMachineData(commands);

                        //text save part
                        string msg = string.Empty;
                        string[] keys = newMachineData.Keys.ToArray();
                        msg += "현재 시간:" + now.ToString("HH:mm:ss") + " 현재 사이클: " + cycleCount + "\n    ";
                        for (int i = 0; i < keys.Length; i++)
                        {
                            string key = keys[i];
                            msg += key + ":" + newMachineData[key] + "  ";
                        }
                        LogWriter.WriteLog_Data(msg, "SaveData", machineCode);
                    }
                    SW.Stop();
                    Console.WriteLine(machineCode + " :" + cycleCount + "회차 총 저장 소요시간 " + SW.ElapsedMilliseconds);

                }
               
            }
            catch (Exception ex)
            {
                LogWriter.WriteLog_Error(ex);
            }



        }

        private static void HandleSaveMachineError(MachineInformation machineInfo,
                                Dictionary<string, string> newMachineData)
        {
            System.Diagnostics.Stopwatch SW = new System.Diagnostics.Stopwatch();
            SW.Start();
            string machineCode = machineInfo.MachineCode;
            EntireMachineData[machineCode] = newMachineData;
            try
            {
                DateTime now = DateTime.Now;
                if (EntireMachineData.ContainsKey(machineCode))
                {
                    System.Diagnostics.Stopwatch SW2 = new System.Diagnostics.Stopwatch();
                    SW2.Start();
                    //이전 machineData 에 error와 현재 machineData error 비교 후 sql 실행
                    //Dictionary<string, string> preMachineData = EntireMachineData[machineCode];
                    Dictionary<string, string> preErrorStates = DbHelper.getPreviousErrorStates(machineCode);
                    string[] fieldCodes = newMachineData.Keys.ToArray();
                    MapRow[] memorymap = MemoryMaps[machineCode];

                    for (int i = 0; i < newMachineData.Count; i++)
                    {
                        string fieldCode = fieldCodes[i];
                        string errorText = string.Empty;

                        if (fieldCode.Substring(0, 1).ToUpper().Equals("M"))
                        {
                            MapRow row = new MapRow();
                            for (int rowIndex = 0; rowIndex < memorymap.Length; rowIndex++)
                            {
                                if (memorymap[rowIndex].Code == fieldCode)
                                    row = memorymap[rowIndex];
                            }

                            string newErrorState = newMachineData[fieldCode];
                            string preErrorState = preErrorStates.GetValueOrDefault(fieldCode);

                            if (newErrorState != preErrorState)
                            {
                                DbHelper.UpdateErrorList(machineInfo, fieldCode, newErrorState, now);

                                if (newErrorState.Trim() == "1")
                                {
                                    //Send Android Push Alarm    
                                    string title = machineInfo.MachineName;
                                    string body = row.Name;
                                    AndroidFcmSender.SendNotificationToTopic(CompanyCode, title, body);
                                }
                            }
                        }

                    }
                    SW2.Stop();
                 
                    Console.WriteLine(machineCode + " :" + "오류 총 저장 소요시간 " + SW2.ElapsedMilliseconds);

                    
                }
                SW.Stop();
            }
            catch (Exception ex)
            {
                LogWriter.WriteLog_Error(ex);
            }
        }


        private static void HandleModbusDataReceive(string machineCode, string fieldCode, string value)
        {
            if (EntireMachineData.ContainsKey(machineCode))
            {
                //머신 에러 개별 저장
                //if (fieldCode.Substring(0, 1).ToUpper().Equals("M"))
                //{
                //    string exErrorState = EntireMachineData[machineCode][fieldCode];
                //    if (exErrorState != value)
                //    {
                //        DbHelper.UpdateErrorList(machineCode, fieldCode, value);
                //    }
                //}
                EntireMachineData[machineCode][fieldCode] = value;
            }
            else
            {
                Dictionary<string, string> data = new Dictionary<string, string>();
                data[fieldCode] = value;
                EntireMachineData[machineCode] = data;
            }

        }

        public static string getMoldNameFromServerSide(string machineCode)
        {
            string[] fieldCodesForMoldname = new string[]{
                                "A00063","A00064","A00065","A00066", "A00067", 
                                "A00068", "A00069", "A00070", "A00071", "A00072",
                                "A00073", "A00074", "A00075","A00076", "A00077", "A00078"};

            string moldName = string.Empty;
            for (int i = 0; i < fieldCodesForMoldname.Length; i++)
            {
                string fieldCode = fieldCodesForMoldname[i];
                string valueString = EntireMachineData[machineCode].GetValueOrDefault(fieldCode);
                decimal valueDecimal;
                if (decimal.TryParse(valueString, out valueDecimal))
                {
                    char charA = (char)(valueDecimal / 256);
                    char charB = (char)(valueDecimal % 256);
                    moldName += charA;
                    moldName += charB;
                }
            }
            return moldName;
        }

        public static void showMachineDataFromClient(DataDisplayParameter parameter)
        {
            try
            {
                PcTcpClient client = new PcTcpClient(ServerIpEnd);
                client.getMachineDataAndDisplayFromClient(parameter);
            }
            catch
            {
            }
        }

        public static void showMachineDataFromServer(DataDisplayParameter parameter)
        {
            string[] machineCodes = parameter.MachineCodes;
            string[] fieldCodes = parameter.FieldCodes;
            DataDisplayCallback displayCallback = parameter.Callback;

            TcpResponse tcpResponse = new TcpResponse();

            MachineResponseData []responseDatas = new MachineResponseData[machineCodes.Length];

            for (int i = 0; i < machineCodes.Length; i++)
            {
                responseDatas[i] = new MachineResponseData();
                Dictionary<string, string> codesAndvalues = new Dictionary<string, string>();
                string machineCode = machineCodes[i];
                if (EntireMachineData.ContainsKey(machineCode))
                {
                    Dictionary<string, string> singleMachineData = EntireMachineData[machineCode];
                    for (int j = 0; j < fieldCodes.Length; j++)
                    {
                        if (singleMachineData.ContainsKey(fieldCodes[j]))
                            codesAndvalues[fieldCodes[j]] = EntireMachineData[machineCode][fieldCodes[j]];
                        else
                            codesAndvalues[fieldCodes[j]] = string.Empty;
                    }
                    responseDatas[i].MachineCode = machineCode;
                    responseDatas[i].MachineData = codesAndvalues;
                    
                }responseDatas[i].IsConnected = GetMachineConnectionStateByMachineCode(machineCode);
            }
            tcpResponse.MachineResponses = responseDatas;

            displayCallback(tcpResponse);
        }


        public static void ServerPcOpen(int port)
        {
            if (ServerPc == null)
            {
                ServerPc = new PcTcpServer(port);

                Thread serverThread = new Thread(new ParameterizedThreadStart(ServerPcStart));
                serverThread.IsBackground = true;
                serverThread.Start(ServerPc);
            }

        }

        private static void ServerPcStart(object obj)
        {
            PcTcpServer server = (PcTcpServer)obj;
            server.DoAll();
        }




        public static string[] GetMachineData(string machineCode, string[] fieldCodes)
        {
            string[] values = new string[fieldCodes.Length];
            if (EntireMachineData.ContainsKey(machineCode))
            {
                Dictionary<string, string> singleMachineData = EntireMachineData[machineCode];
                for (int i = 0; i < fieldCodes.Length; i++)
                {
                    if (singleMachineData.ContainsKey(fieldCodes[i]))
                        values[i] = singleMachineData[fieldCodes[i]];
                    else
                        values[i] = string.Empty;
                }
                
            }
            return values;
        }


        public static bool GetMachineConnectionStateByMachineCode(string machineCode)
        {
            ConnectionState state = ConnectionState.Disconnected;
            for (int i = 0; i < modbusConnectedList.Count; i++)
            {
                KeyValuePair<ModbusTcpClient, ConnectionState> pair = modbusConnectedList.ToArray()[i];
                if (pair.Key.MachineInfo.MachineCode == machineCode)
                    state = pair.Value;
            }
            if (state == ConnectionState.Connected)
                return true;
            else
                return false;

        }

        public static MachineInformation[] getMachineInformations(DataTable machineInfoTable)
        {
            MachineInformation[] machineInformations = new MachineInformation[machineInfoTable.Rows.Count];
            for (int i = 0; i < machineInfoTable.Rows.Count; i++)
            {
                DataRow row = machineInfoTable.Rows[i];
                string machineName = row["MACHINE_NAME"].ToString();
                int machineNumber;
                if (int.TryParse(row["MACHINE_NUMBER"].ToString(), out machineNumber) == false)
                    machineNumber = 0;
                string machineIp = row["MACHINE_IP"].ToString();
                int machinePort;
                if (int.TryParse(row["MACHINE_PORT"].ToString(), out machinePort) == false)
                    machinePort = 502;
                string machineCode = row["MACHINE_CODE"].ToString();
                string machineType = row["MACHINE_TYPE"].ToString();

                IPAddress ipAddress;
                IPEndPoint ipEnd;
                if (IPAddress.TryParse(machineIp, out ipAddress))
                    ipEnd = new IPEndPoint(ipAddress, machinePort);
                else
                    ipEnd = null;

                string mapType = row["MapType"].ToString();

                MachineInformation machineInfo = new MachineInformation();
                machineInfo.MachineName = machineName;
                machineInfo.MachineNumber = machineNumber;
                machineInfo.MachineType = machineType;
                machineInfo.MachineCode = machineCode;
                machineInfo.IpEnd = ipEnd;

                DataTable mapTable = DbHelper.LoadMemoryMap(mapType);
                if (mapTable != null)
                {
                    MapRow[] memoryMap = GetMemoryRowsFromDataTable(mapTable);
                    int offset;
                    if (int.TryParse(row["Offset"].ToString(), out offset) == false)
                        offset = 0;
                    for (int j = 0; j < memoryMap.Length; j++)
                    {
                        memoryMap[j].Address += offset;
                    }
                    machineInfo.Memorymap = memoryMap;
                }
                else
                    machineInfo.Memorymap = new MapRow[] { };
                
                machineInformations[i] = machineInfo;
            }
            return machineInformations;
           

        }

        public static void StartServerMode(MachineInformation [] machineInformations, int serverPort)
        {
            try
            {
                ModbusConnect(machineInformations);
                ServerPcOpen(serverPort);
            }
            catch
            {
                throw;
            }

        }
        public static void StartClientMode(string serverIp, int serverPort)
        {
            try
            {
                //start client modetry
                IPAddress ipAddress;

                if (IPAddress.TryParse(serverIp, out ipAddress) == false)
                    throw new Exception("유효하지 않은 IP");
                IPEndPoint ipEnd = new IPEndPoint(ipAddress, serverPort);

                ServerIpEnd = ipEnd;
            }
            catch
            {
                throw;
            }
        }


        public static bool MakeAuthenticFile(string appPath, string serverName, string dbName, string id, string pw)
        {
            try
            {
                string filePath = appPath + @"\" + "SqlServer.xml";
                FileInfo fi = new FileInfo(filePath);
                if (fi.Exists == false)
                {
                    XmlDocument doc = new XmlDocument();
                    XmlElement root = doc.CreateElement("ROOT");
                    doc.AppendChild(root);

                    XmlElement fieldElement = doc.CreateElement("SERVER");
                    fieldElement.InnerText = Convert.ToBase64String(Encoding.UTF8.GetBytes(serverName));
                    root.AppendChild(fieldElement);

                    fieldElement = doc.CreateElement("DBNAME");
                    fieldElement.InnerText = Convert.ToBase64String(Encoding.UTF8.GetBytes(dbName));
                    root.AppendChild(fieldElement);

                    fieldElement = doc.CreateElement("ID");
                    fieldElement.InnerText = Convert.ToBase64String(Encoding.UTF8.GetBytes(id));
                    root.AppendChild(fieldElement);

                    fieldElement = doc.CreateElement("PW");
                    fieldElement.InnerText = Convert.ToBase64String(Encoding.UTF8.GetBytes(pw));
                    root.AppendChild(fieldElement);

                    doc.Save(filePath);

                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch
            {
                return false;
            }
        }


        public static string GetValueOrDefault(this Dictionary<string, string> dic, string key)
        {
            string returnValue = "";
            bool found = dic.TryGetValue(key, out returnValue);
            if (found)
            {
                return returnValue;
            }
            return returnValue;
        }

        public static MapRow[] FindMapRowsToSave(MapRow[] memorymap)
        {
            ArrayList rows = new ArrayList();
            try
            {
                for (int i = 0; i < memorymap.Length; i++)
                {
                    if (memorymap[i].IsSaved == true)
                        rows.Add(memorymap[i]);
                }
                return (MapRow[])rows.ToArray(typeof(MapRow));
            }
            catch (Exception ex) { LogWriter.WriteLog_Error(ex); return null; }
        }


    }
}
