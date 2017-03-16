using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ModbusTcp
{
    public static class DbHelper
    {

        public static string ServerName { get; set; }
        public static string DatabaseName { get; set; }
        public static string UserId { get; set; }
        public static string Password { get; set; }
        public static string DbConnectionString { get; set; }

        public static void setSqlConnectionString(string dbConString)
        {
            DbConnectionString = dbConString;
        }

        public static DataTable getFcmTokens()
        {
            string query = @"SELECT * FROM MobileFcmTokens WHERE   AllowPush = 'Y' ";

            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();

            using (SqlConnection sqlCon = new SqlConnection(DbConnectionString))
            {
                try
                {
                    cmd.Connection = sqlCon;
                    cmd.CommandText = query;

                    cmd.Parameters.Clear();

                    adapter.SelectCommand = cmd;
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    cmd.Dispose();
                    adapter.Dispose();

                    return dataSet.Tables[0];
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw ex;
                }
            }
        }

        public static Dictionary<string,string> getPreviousErrorStates(string machineCode)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();
            string query = @"
                            SELECT ERROR_CODE, ERROR_STATE 
                            FROM ERROR_LIST
                            WHERE MACHINE_CODE = @MACHINE_CODE
                            ";
            Dictionary<string, string> errorStates = new Dictionary<string, string>();
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(DbConnectionString))
                {
                    cmd.Connection = sqlCon;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MACHINE_CODE", machineCode);
                    adapter.SelectCommand = cmd;
                    adapter.Fill(dataSet);

                    DataTable table =  dataSet.Tables[0];
                    
                    for(int i = 0 ;i < table.Rows.Count; i++){
                        DataRow row = table.Rows[i];
                        string code = row["ERROR_CODE"].ToString();
                        string state = row["ERROR_STATE"].ToString();
                        errorStates.Add(code,state);
                    }
                    return errorStates;
                }
            }
            catch (Exception ex)
            {
                LogWriter.WriteLog_Error(ex);
                return errorStates;
            }

        }
        
        public static void InsertMachineData(SqlCommand [] commands)
        {
            
            using (SqlConnection sqlCon = new SqlConnection(DbConnectionString))
            {
                sqlCon.Open();
               
                for (int i = 0; i < commands.Length; i++)
                {
                   
                    try
                    {
                        DateTime d1 = DateTime.Now;

                        SqlCommand cmd = commands[i];
                        cmd.Connection = sqlCon;
                        
                        cmd.ExecuteNonQuery();

                        DateTime d2 = DateTime.Now;
                        Console.WriteLine("excute non query" + (d2.Ticks - d1.Ticks) / 10000);
                    }
                    catch(Exception ex)
                    {
                        LogWriter.WriteLog_Error(ex);
                    }
                }

                sqlCon.Close();
            }
            
        }
    
        
        public static void InsertMachineData(MachineInformation machineInfo,
                            Dictionary<string, string> machineData, DateTime dateTime, string moldName, string cycleCount)
        {
            using (SqlConnection sqlConnection = new SqlConnection(DbConnectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    #region query
                    string query = @"
                    SET NOCOUNT ON
                    
                    BEGIN TRAN

                    INSERT INTO    ActualData_1
                    VALUES 
                    (
                            @DATETIME, @MACHINECODE,  @CYCLE, @MOLDNAME,
                            @A00010, @A00011, @A00012, @A00013, @A00014, 
                            @A00015, @A00016, @A00017, @A00018, @A00019, 
                            @A00020, @A00021, @A00022, @A00023, @A00024, 
                            @A00025, @A00026, @A00027, @A00028, @A00029, 
                            @A00030, @A00031, @A00032, @A00033, @A00034, 
                            @A00035 
                    )";
                    query += @"
                    INSERT INTO ActualData_2
                    VALUES
                    (
                            @DATETIME, 
                            @A00036, @A00037, @A00038, @A00039, @A00040,
                            @A00041, @A00042, @A00043, @A00044, @A00045,
                            @A00046, @A00047, @A00048, @A00049, @A00050,
                            @A00051, @A00052, @A00053, @A00054, @A00055,
                            @A00056, @A00057, @A00058, @A00059, @A00060,
                            @A00061, @A00062
                    )";

                    query += @"INSERT INTO    SetData_1
                    VALUES 
                    (
                            @DATETIME, 
                            @S00001, @S00002, @S00003, @S00004, @S00005, 
                            @S00006, @S00007, @S00008, @S00009, @S00010, 
                            @S00011, @S00012, @S00013, @S00014, @S00015, 
                            @S00016, @S00017, @S00018, @S00019, @S00020, 
                            @S00021, @S00022, @S00023, @S00024, @S00025, 
                            @S00026, @S00027, @S00028, @S00029, @S00030, 
                            @S00031, @S00032, @S00033, @S00034, @S00035
                    )";

                    query += @"INSERT INTO    SetData_2
                    VALUES 
                    (       
                            @DATETIME, 
                            @S00036, @S00037, @S00038, @S00039, @S00040, 
                            @S00041, @S00042, @S00043, @S00044, @S00045, 
                            @S00046, @S00047, @S00048, @S00049, @S00050, 
                            @S00051, @S00052, @S00053, @S00054, @S00055, 
                            @S00056, @S00057, @S00058, @S00059, @S00060, 
                            @S00061, @S00062, @S00063, @S00064, @S00065, 
                            @S00066, @S00067, @S00068, @S00069, @S00070
                    )";


                    query += @"INSERT INTO    SetData_3
                    VALUES 
                    (
                            @DATETIME, 
                            @S00071, @S00072, @S00073, @S00074, @S00075, 
                            @S00076, @S00077, @S00078, @S00079, @S00080, 
                            @S00081, @S00082, @S00083, @S00084, @S00085, 
                            @S00086, @S00087, @S00088, @S00089, @S00090, 
                            @S00091, @S00092, @S00093, @S00094, @S00095, 
                            @S00096, @S00097, @S00098, @S00099, @S00100, 
                            @S00101, @S00102, @S00103, @S00104, @S00105
                    )";
                    query += @"INSERT INTO    SetData_4
                    VALUES 
                    (
                            @DATETIME, 
                            @S00106, @S00107, @S00108, @S00109, @S00110, 
                            @S00111, @S00112, @S00113, @S00114, @S00115, 
                            @S00116, @S00117, @S00118, @S00119, @S00120, 
                            @S00121, @S00122, @S00123, @S00124, @S00125, 
                            @S00126, @S00127, @S00128, @S00129, @S00130, 
                            @S00131, @S00132, @S00133, @S00134, @S00135, 
                            @S00136, @S00137, @S00138, @S00139, @S00140
                    )";
                    query += @"
                            IF @@ERROR > 0
                                ROLLBACK TRAN
                            ELSE
                                COMMIT TRAN
                          ";
                    #endregion query

                    #region sql command parameters
                    cmd.Parameters.AddWithValue("@A00010", machineData.ContainsKey("A00010") ? machineData["A00010"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00011", machineData.ContainsKey("A00011") ? machineData["A00011"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00012", machineData.ContainsKey("A00012") ? machineData["A00012"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00013", machineData.ContainsKey("A00013") ? machineData["A00013"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00014", machineData.ContainsKey("A00014") ? machineData["A00014"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00015", machineData.ContainsKey("A00015") ? machineData["A00015"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00016", machineData.ContainsKey("A00016") ? machineData["A00016"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00017", machineData.ContainsKey("A00017") ? machineData["A00017"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00018", machineData.ContainsKey("A00018") ? machineData["A00018"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00019", machineData.ContainsKey("A00019") ? machineData["A00019"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00020", machineData.ContainsKey("A00020") ? machineData["A00020"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00021", machineData.ContainsKey("A00021") ? machineData["A00021"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00022", machineData.ContainsKey("A00022") ? machineData["A00022"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00023", machineData.ContainsKey("A00023") ? machineData["A00023"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00024", machineData.ContainsKey("A00024") ? machineData["A00024"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00025", machineData.ContainsKey("A00025") ? machineData["A00025"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00026", machineData.ContainsKey("A00026") ? machineData["A00026"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00027", machineData.ContainsKey("A00027") ? machineData["A00027"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00028", machineData.ContainsKey("A00028") ? machineData["A00028"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00029", machineData.ContainsKey("A00029") ? machineData["A00029"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00030", machineData.ContainsKey("A00030") ? machineData["A00030"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00031", machineData.ContainsKey("A00031") ? machineData["A00031"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00032", machineData.ContainsKey("A00032") ? machineData["A00032"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00033", machineData.ContainsKey("A00033") ? machineData["A00033"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00034", machineData.ContainsKey("A00034") ? machineData["A00034"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00035", machineData.ContainsKey("A00035") ? machineData["A00035"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00036", machineData.ContainsKey("A00036") ? machineData["A00036"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00037", machineData.ContainsKey("A00037") ? machineData["A00037"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00038", machineData.ContainsKey("A00038") ? machineData["A00038"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00039", machineData.ContainsKey("A00039") ? machineData["A00039"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00040", machineData.ContainsKey("A00040") ? machineData["A00040"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00041", machineData.ContainsKey("A00041") ? machineData["A00041"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00042", machineData.ContainsKey("A00042") ? machineData["A00042"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00043", machineData.ContainsKey("A00043") ? machineData["A00043"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00044", machineData.ContainsKey("A00044") ? machineData["A00044"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00045", machineData.ContainsKey("A00045") ? machineData["A00045"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00046", machineData.ContainsKey("A00046") ? machineData["A00046"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00047", machineData.ContainsKey("A00047") ? machineData["A00047"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00048", machineData.ContainsKey("A00048") ? machineData["A00048"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00049", machineData.ContainsKey("A00049") ? machineData["A00049"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00050", machineData.ContainsKey("A00050") ? machineData["A00050"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00051", machineData.ContainsKey("A00051") ? machineData["A00051"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00052", machineData.ContainsKey("A00052") ? machineData["A00052"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00053", machineData.ContainsKey("A00053") ? machineData["A00053"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00054", machineData.ContainsKey("A00054") ? machineData["A00054"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00055", machineData.ContainsKey("A00055") ? machineData["A00055"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00056", machineData.ContainsKey("A00056") ? machineData["A00056"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00057", machineData.ContainsKey("A00057") ? machineData["A00057"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00058", machineData.ContainsKey("A00058") ? machineData["A00058"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00059", machineData.ContainsKey("A00059") ? machineData["A00059"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00060", machineData.ContainsKey("A00060") ? machineData["A00060"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00061", machineData.ContainsKey("A00061") ? machineData["A00061"] : String.Empty);
                    cmd.Parameters.AddWithValue("@A00062", machineData.ContainsKey("A00062") ? machineData["A00062"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00001", machineData.ContainsKey("S00001") ? machineData["S00001"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00002", machineData.ContainsKey("S00002") ? machineData["S00002"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00003", machineData.ContainsKey("S00003") ? machineData["S00003"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00004", machineData.ContainsKey("S00004") ? machineData["S00004"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00005", machineData.ContainsKey("S00005") ? machineData["S00005"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00006", machineData.ContainsKey("S00006") ? machineData["S00006"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00007", machineData.ContainsKey("S00007") ? machineData["S00007"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00008", machineData.ContainsKey("S00008") ? machineData["S00008"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00009", machineData.ContainsKey("S00009") ? machineData["S00009"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00010", machineData.ContainsKey("S00010") ? machineData["S00010"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00011", machineData.ContainsKey("S00011") ? machineData["S00011"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00012", machineData.ContainsKey("S00012") ? machineData["S00012"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00013", machineData.ContainsKey("S00013") ? machineData["S00013"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00014", machineData.ContainsKey("S00014") ? machineData["S00014"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00015", machineData.ContainsKey("S00015") ? machineData["S00015"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00016", machineData.ContainsKey("S00016") ? machineData["S00016"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00017", machineData.ContainsKey("S00017") ? machineData["S00017"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00018", machineData.ContainsKey("S00018") ? machineData["S00018"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00019", machineData.ContainsKey("S00019") ? machineData["S00019"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00020", machineData.ContainsKey("S00020") ? machineData["S00020"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00021", machineData.ContainsKey("S00021") ? machineData["S00021"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00022", machineData.ContainsKey("S00022") ? machineData["S00022"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00023", machineData.ContainsKey("S00023") ? machineData["S00023"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00024", machineData.ContainsKey("S00024") ? machineData["S00024"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00025", machineData.ContainsKey("S00025") ? machineData["S00025"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00026", machineData.ContainsKey("S00026") ? machineData["S00026"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00027", machineData.ContainsKey("S00027") ? machineData["S00027"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00028", machineData.ContainsKey("S00028") ? machineData["S00028"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00029", machineData.ContainsKey("S00029") ? machineData["S00029"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00030", machineData.ContainsKey("S00030") ? machineData["S00030"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00031", machineData.ContainsKey("S00031") ? machineData["S00031"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00032", machineData.ContainsKey("S00032") ? machineData["S00032"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00033", machineData.ContainsKey("S00033") ? machineData["S00033"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00034", machineData.ContainsKey("S00034") ? machineData["S00034"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00035", machineData.ContainsKey("S00035") ? machineData["S00035"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00036", machineData.ContainsKey("S00036") ? machineData["S00036"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00037", machineData.ContainsKey("S00037") ? machineData["S00037"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00038", machineData.ContainsKey("S00038") ? machineData["S00038"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00039", machineData.ContainsKey("S00039") ? machineData["S00039"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00040", machineData.ContainsKey("S00040") ? machineData["S00040"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00041", machineData.ContainsKey("S00041") ? machineData["S00041"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00042", machineData.ContainsKey("S00042") ? machineData["S00042"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00043", machineData.ContainsKey("S00043") ? machineData["S00043"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00044", machineData.ContainsKey("S00044") ? machineData["S00044"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00045", machineData.ContainsKey("S00045") ? machineData["S00045"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00046", machineData.ContainsKey("S00046") ? machineData["S00046"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00047", machineData.ContainsKey("S00047") ? machineData["S00047"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00048", machineData.ContainsKey("S00048") ? machineData["S00048"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00049", machineData.ContainsKey("S00049") ? machineData["S00049"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00050", machineData.ContainsKey("S00050") ? machineData["S00050"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00051", machineData.ContainsKey("S00051") ? machineData["S00051"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00052", machineData.ContainsKey("S00052") ? machineData["S00052"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00053", machineData.ContainsKey("S00053") ? machineData["S00053"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00054", machineData.ContainsKey("S00054") ? machineData["S00054"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00055", machineData.ContainsKey("S00055") ? machineData["S00055"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00056", machineData.ContainsKey("S00056") ? machineData["S00056"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00057", machineData.ContainsKey("S00057") ? machineData["S00057"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00058", machineData.ContainsKey("S00058") ? machineData["S00058"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00059", machineData.ContainsKey("S00059") ? machineData["S00059"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00060", machineData.ContainsKey("S00060") ? machineData["S00060"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00061", machineData.ContainsKey("S00061") ? machineData["S00061"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00062", machineData.ContainsKey("S00062") ? machineData["S00062"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00063", machineData.ContainsKey("S00063") ? machineData["S00063"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00064", machineData.ContainsKey("S00064") ? machineData["S00064"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00065", machineData.ContainsKey("S00065") ? machineData["S00065"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00066", machineData.ContainsKey("S00066") ? machineData["S00066"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00067", machineData.ContainsKey("S00067") ? machineData["S00067"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00068", machineData.ContainsKey("S00068") ? machineData["S00068"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00069", machineData.ContainsKey("S00069") ? machineData["S00069"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00070", machineData.ContainsKey("S00070") ? machineData["S00070"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00071", machineData.ContainsKey("S00071") ? machineData["S00071"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00072", machineData.ContainsKey("S00072") ? machineData["S00072"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00073", machineData.ContainsKey("S00073") ? machineData["S00073"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00074", machineData.ContainsKey("S00074") ? machineData["S00074"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00075", machineData.ContainsKey("S00075") ? machineData["S00075"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00076", machineData.ContainsKey("S00076") ? machineData["S00076"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00077", machineData.ContainsKey("S00077") ? machineData["S00077"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00078", machineData.ContainsKey("S00078") ? machineData["S00078"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00079", machineData.ContainsKey("S00079") ? machineData["S00079"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00080", machineData.ContainsKey("S00080") ? machineData["S00080"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00081", machineData.ContainsKey("S00081") ? machineData["S00081"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00082", machineData.ContainsKey("S00082") ? machineData["S00082"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00083", machineData.ContainsKey("S00083") ? machineData["S00083"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00084", machineData.ContainsKey("S00084") ? machineData["S00084"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00085", machineData.ContainsKey("S00085") ? machineData["S00085"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00086", machineData.ContainsKey("S00086") ? machineData["S00086"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00087", machineData.ContainsKey("S00087") ? machineData["S00087"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00088", machineData.ContainsKey("S00088") ? machineData["S00088"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00089", machineData.ContainsKey("S00089") ? machineData["S00089"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00090", machineData.ContainsKey("S00090") ? machineData["S00090"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00091", machineData.ContainsKey("S00091") ? machineData["S00091"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00092", machineData.ContainsKey("S00092") ? machineData["S00092"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00093", machineData.ContainsKey("S00093") ? machineData["S00093"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00094", machineData.ContainsKey("S00094") ? machineData["S00094"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00095", machineData.ContainsKey("S00095") ? machineData["S00095"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00096", machineData.ContainsKey("S00096") ? machineData["S00096"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00097", machineData.ContainsKey("S00097") ? machineData["S00097"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00098", machineData.ContainsKey("S00098") ? machineData["S00098"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00099", machineData.ContainsKey("S00099") ? machineData["S00099"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00100", machineData.ContainsKey("S00100") ? machineData["S00100"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00101", machineData.ContainsKey("S00101") ? machineData["S00101"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00102", machineData.ContainsKey("S00102") ? machineData["S00102"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00103", machineData.ContainsKey("S00103") ? machineData["S00103"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00104", machineData.ContainsKey("S00104") ? machineData["S00104"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00105", machineData.ContainsKey("S00105") ? machineData["S00105"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00106", machineData.ContainsKey("S00106") ? machineData["S00106"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00107", machineData.ContainsKey("S00107") ? machineData["S00107"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00108", machineData.ContainsKey("S00108") ? machineData["S00108"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00109", machineData.ContainsKey("S00109") ? machineData["S00109"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00110", machineData.ContainsKey("S00110") ? machineData["S00110"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00111", machineData.ContainsKey("S00111") ? machineData["S00111"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00112", machineData.ContainsKey("S00112") ? machineData["S00112"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00113", machineData.ContainsKey("S00113") ? machineData["S00113"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00114", machineData.ContainsKey("S00114") ? machineData["S00114"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00115", machineData.ContainsKey("S00115") ? machineData["S00115"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00116", machineData.ContainsKey("S00116") ? machineData["S00116"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00117", machineData.ContainsKey("S00117") ? machineData["S00117"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00118", machineData.ContainsKey("S00118") ? machineData["S00118"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00119", machineData.ContainsKey("S00119") ? machineData["S00119"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00120", machineData.ContainsKey("S00120") ? machineData["S00120"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00121", machineData.ContainsKey("S00121") ? machineData["S00121"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00122", machineData.ContainsKey("S00122") ? machineData["S00122"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00123", machineData.ContainsKey("S00123") ? machineData["S00123"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00124", machineData.ContainsKey("S00124") ? machineData["S00124"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00125", machineData.ContainsKey("S00125") ? machineData["S00125"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00126", machineData.ContainsKey("S00126") ? machineData["S00126"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00127", machineData.ContainsKey("S00127") ? machineData["S00127"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00128", machineData.ContainsKey("S00128") ? machineData["S00128"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00129", machineData.ContainsKey("S00129") ? machineData["S00129"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00130", machineData.ContainsKey("S00130") ? machineData["S00130"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00131", machineData.ContainsKey("S00131") ? machineData["S00131"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00132", machineData.ContainsKey("S00132") ? machineData["S00132"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00133", machineData.ContainsKey("S00133") ? machineData["S00133"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00134", machineData.ContainsKey("S00134") ? machineData["S00134"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00135", machineData.ContainsKey("S00135") ? machineData["S00135"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00136", machineData.ContainsKey("S00136") ? machineData["S00136"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00137", machineData.ContainsKey("S00137") ? machineData["S00137"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00138", machineData.ContainsKey("S00138") ? machineData["S00138"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00139", machineData.ContainsKey("S00139") ? machineData["S00139"] : String.Empty);
                    cmd.Parameters.AddWithValue("@S00140", machineData.ContainsKey("S00140") ? machineData["S00140"] : String.Empty);
                    cmd.Parameters.AddWithValue("@CYCLE", cycleCount);
                    cmd.Parameters.AddWithValue("@MOLDNAME", moldName);
                    cmd.Parameters.AddWithValue("@MACHINECODE", machineInfo.MachineCode);
                    cmd.Parameters.AddWithValue("@DATETIME", dateTime);

                    #endregion

                    cmd.Connection = sqlConnection;
                    cmd.CommandText = query;

                    sqlConnection.Open();
                    cmd.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    LogWriter.WriteLog_Error(ex);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }

        }



        public static void UpdateErrorList(MachineInformation machineInfo,
                            string errorCode, string errorState, DateTime dateTime)
        {
            SqlCommand cmd = new SqlCommand();
            string query = @"
            DECLARE @EX_STATE CHAR(1)
            IF NOT EXISTS 
	        (
		        SELECT * FROM ERROR_LIST
		        WHERE MACHINE_CODE = @MACHINE_CODE
		        AND ERROR_CODE = @ERROR_CODE
	        )
	            BEGIN
	            INSERT INTO ERROR_LIST
                (MACHINE_CODE, ERROR_CODE,  ERROR_STATE, UPDATE_TIME)
                VALUES 
                (@MACHINE_CODE, @ERROR_CODE, @ERROR_STATE, @UPDATE_TIME)
	
	            IF(@ERROR_STATE = '1')
		            INSERT INTO ERROR_HISTORY 
                    (MACHINE_CODE, ERROR_CODE,  SAVE_TIME)
		            VALUES 
                    (@MACHINE_CODE, @ERROR_CODE, @UPDATE_TIME)
	            END
            ELSE 
	            BEGIN
	            SELECT @EX_STATE = ERROR_STATE FROM ERROR_LIST 
						            WHERE MACHINE_CODE = @MACHINE_CODE
						            AND ERROR_CODE = @ERROR_CODE

			            IF(@EX_STATE != @ERROR_STATE)
				            BEGIN
				            UPDATE ERROR_LIST
				            SET UPDATE_TIME = @UPDATE_TIME, ERROR_STATE = @ERROR_STATE
                            WHERE MACHINE_CODE = @MACHINE_CODE
                            AND ERROR_CODE = @ERROR_CODE
				
				            IF(@ERROR_STATE = '1')
				            INSERT INTO ERROR_HISTORY 
                            (MACHINE_CODE, ERROR_CODE,  SAVE_TIME)   
				            VALUES 
                            (@MACHINE_CODE, @ERROR_CODE, @UPDATE_TIME)
				            END
	            END
                ";
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(DbConnectionString))
                {
                    cmd.Connection = sqlCon;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@MACHINE_CODE", machineInfo.MachineCode);
                    cmd.Parameters.AddWithValue("@ERROR_CODE", errorCode);
                    cmd.Parameters.AddWithValue("@ERROR_STATE", errorState);
                    cmd.Parameters.AddWithValue("@UPDATE_TIME", dateTime);

                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {
                LogWriter.WriteLog_Error(ex);
            }
        }


        public static DataTable LoadMemoryMap(string mapType)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();
            string query = @"
                            SELECT A.*, B.FieldName 
                            FROM MachineMemoryMap as A
                            JOIN BaseMemoryMap as B   
                            ON A.FieldCode = B.FieldCode
                            WHERE MapType = @MapType";

            try
            {
                cmd.Connection = new SqlConnection(DbConnectionString);
                cmd.CommandText = query;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@MapType", mapType);

                adapter.SelectCommand = cmd;
                adapter.Fill(dataSet);

                cmd.Dispose();
                adapter.Dispose();

                if (dataSet.Tables[0].Rows.Count > 0)
                    return dataSet.Tables[0];
                else
                    return null;
            }
            catch (Exception ex)
            {
                LogWriter.WriteLog_Error(ex);
                return null;
            }

        }


        public static DataTable LoadMachineList()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();
            string query = @"
                            select a.*, b.Offset from SEOLBI as a
                            join MemoryMapType as b
                            on a.MapType = b.MapType
                            order by a.MACHINE_NUMBER
                    ";

            try
            {
                cmd.Connection = new SqlConnection(DbConnectionString);
                cmd.CommandText = query;

                adapter.SelectCommand = cmd;
                adapter.Fill(dataSet);

                if (dataSet.Tables[0].Rows.Count > 0)
                    return dataSet.Tables[0];
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }

        }





    }
}
