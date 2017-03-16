using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DONGSHIN
{
    static class StatusInfoHelper
    {

        #region 사출조건 현황
        private static string getQuery_SelectFirstMachine() 
        {
            string query = "select TOP(1) MACHINE_CODE, MACHINE_NAME from SEOLBI order by MACHINE_NUMBER";

            return query;
        }

        public static string[] getInitMachine() 
        {
            string query = getQuery_SelectFirstMachine();
            string[] machineInfo = new string[2];
            DataSet dataset = new DataSet();
            
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection conn = new SqlConnection(commonVar.dbConnectionString);

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = query;

                adapter.SelectCommand = cmd;
                adapter.Fill(dataset);

                if ( dataset.Tables[0].Rows.Count > 0 )
                {
                    DataRow row = dataset.Tables[0].Rows[0];
                    machineInfo[0] = row["MACHINE_CODE"].ToString();
                    machineInfo[1] = row["MACHINE_NAME"].ToString();
                    return machineInfo;
                }
                else
                    return null;
            }
            catch ( Exception ex )
            {
                throw ex;
            }

        }


        private static string getQuery_SelectMachineState(string MachineCode, string startday, string endday)
        {
            string query = string.Empty;

            if ( startday.Equals(endday) )
            {
                query = @"select a1.*, a2.*, b.MACHINE_NAME, b.MACHINE_NUMBER, b.MACHINE_TYPE
                                    from ActualData_1 a1
                                            left outer join SEOLBI b on (a1.MACHINE_CODE = b.MACHINE_CODE)
                                            left outer join ActualData_2 a2 on (a1.SAVE_DATETIME = a2.SAVE_DATETIME)
                                    where a1.MACHINE_CODE = '" + MachineCode + "' and a1.SAVE_DATETIME >= '" + startday +
                                @"'order by a1.SAVE_DATETIME desc";
            }
            else
            {
                query = @"select a1.*, a2.*, b.MACHINE_NAME, b.MACHINE_NUMBER, b.MACHINE_TYPE
                                    from ActualData_1 a1
                                            left outer join ActualData_2 a2 on (a1.SAVE_DATETIME = a2.SAVE_DATETIME)
                                            left outer join SEOLBI b on (a1.MACHINE_CODE = b.MACHINE_CODE)
                                    where a1.MACHINE_CODE = '" + MachineCode + "' and a1.SAVE_DATETIME >= '" + startday + 
                                                               "' and a1.SAVE_DATETIME <= getdate() order by a1.SAVE_DATETIME desc";
            }

            return query;
        }


        public static DataTable getMachineState(string MachineCode, string startday, string endday) 
        {
            string query = string.Empty;

            query = getQuery_SelectMachineState(MachineCode, startday, endday);

            DataSet dataset = new DataSet();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection conn = new SqlConnection(commonVar.dbConnectionString);

            try 
            {
                cmd.Connection = conn;
                cmd.CommandText = query;

                adapter.SelectCommand = cmd;
                adapter.Fill(dataset);

                if ( dataset.Tables[0].Rows.Count > 0 )
                    return dataset.Tables[0];
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion


        #region 에러현황

        //private static string getQuery_SelectErrorMachineCount()
        //{
        //    string today = DateTime.Today.ToShortDateString();
        //    string query = "SELECT DISTINCT MACHINE_CODE FROM ERROR_LIST WHERE UPDATE_TIME >= '"+today+"'";

        //    return query;
        //}

        ////사출기 몇대가 에러났는지 확인
        //public static DataTable getErrorMachineCount() 
        //{
        //    string query = string.Empty;

        //    query = getQuery_SelectErrorMachineCount();

        //    DataSet dataset = new DataSet();
        //    SqlCommand cmd = new SqlCommand();
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    SqlConnection conn = new SqlConnection(commonVar.dbConnectionString);

        //    try
        //    {
        //        cmd.Connection = conn;
        //        cmd.CommandText = query;

        //        adapter.SelectCommand = cmd;
        //        adapter.Fill(dataset);

        //        //if ( dataset.Tables[0].Rows.Count > 0 )
        //        //    count = dataset.Tables[0].Rows.Count;
        //    }
        //    catch ( Exception ex )
        //    {
        //        throw ex;
        //    }

        //    return dataset.Tables[0];
        //}



//        private static string getQuery_SelectErrorStateByMachine(string[] MachineCodes, string today) 
//        {
//            int dataLength = MachineCodes.Length;
//            string[] ScalaVariables = new string[dataLength];

//            string query = string.Empty;

//            //스칼라변수 설정
//            for ( int i = 0 ; i < dataLength ; i++ ) 
//            {
//                ScalaVariables[i] = "@"+MachineCodes[i].Replace("-","") + "_COUNT";
//            }

//            //스칼라변수 값 할당
//            for ( int i = 0 ; i < dataLength ; i++ ) 
//            {
//                query += "DECLARE "+ScalaVariables[i]+" INT; \n";
//                query += "SET " + ScalaVariables[i] + " = (SELECT COUNT(MACHINE_CODE) AS ERRORS FROM ERROR_LIST WHERE MACHINE_CODE = '" + MachineCodes[i] + "' AND UPDATE_TIME >= '" + today + "'); \n";
//            }

//            //조회 결과값 UNION
//            for ( int i = 0 ; i < dataLength ; i++ )
//            {
//                query += "SELECT * FROM (SELECT " + ScalaVariables[i] + " AS OCCUR_NUM, A.MACHINE_CODE, ERROR_CODE, CONVERT(NVARCHAR(30), UPDATE_TIME,121) AS UPDATE_TIME, B.FieldName as ErrorText, C.MACHINE_NAME, C.MACHINE_NUMBER, C.MACHINE_TYPE";
//                query+= @" FROM ERROR_LIST as A
//                                        JOIN BaseMemoryMap as B on A.ERROR_CODE = b.FieldCode 
//                                        JOIN SEOLBI as C on A.MACHINE_CODE = C.MACHINE_CODE
//                                        WHERE ERROR_STATE = '1'	
//                                        AND A.MACHINE_CODE = '" + MachineCodes[i] + "'AND A.UPDATE_TIME >= '" + today + "') AS TEMPORARY_TABLE \n";


//                if ( i < dataLength - 1 )
//                    query += "UNION \n";
//                else
//                    query += "ORDER BY MACHINE_CODE;";
//            }
            

//            return query;
//        }


        //public static DataTable getErrorStateByMachine(string[] MachineCodes, string today) 
        //{
        //    string query = string.Empty;

        //    query = getQuery_SelectErrorStateByMachine(MachineCodes,today);
        //    DataSet dataset = new DataSet();
        //    SqlCommand cmd = new SqlCommand();
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    SqlConnection conn = new SqlConnection(commonVar.dbConnectionString);

        //    try
        //    {
        //        cmd.Connection = conn;
        //        cmd.CommandText = query;

        //        adapter.SelectCommand = cmd;
        //        adapter.Fill(dataset);

        //        if ( dataset.Tables[0].Rows.Count > 0 )
        //        {
        //            DataTable preTable = dataset.Tables[0];
        //            DataTable newTable = preTable;
        //            newTable.Clear();
        //            string condition = "MACHINE_CODE = '" + MachineCodes[0] + "' AND UPDATE_TIME = MAX(UPDATE_TIME)";
        //            DataRow[] rows = preTable.Select(condition);

        //            foreach ( DataRow row in rows)
        //                newTable.Rows.Add(row);

        //            return preTable;
        //        }
        //        else
        //            return null;
        //    }
        //    catch ( Exception ex )
        //    {
        //        throw ex;
        //    }
        //}



        private static string getQuery_SelectErrorStateByMachine(string startDay, string endDay)
        {
            string query = string.Empty;
                    query += @"SELECT A.*, B.MACHINE_NAME, B.MACHINE_NUMBER, C.FieldName as ErrorText, D.SAVE_TIME
                                    FROM ERROR_LIST A
                                            LEFT OUTER JOIN SEOLBI B ON (A.MACHINE_CODE = B.MACHINE_CODE)
                                            LEFT OUTER JOIN BaseMemoryMap C ON (A.ERROR_CODE = C.FieldCode)
                                            LEFT OUTER JOIN ERROR_HISTORY D ON (A.MACHINE_CODE = D.MACHINE_CODE AND A.ERROR_CODE = D.ERROR_CODE)

                                    WHERE A.UPDATE_TIME >= '" + startDay + "' AND A.UPDATE_TIME <= '" + endDay + "' \n";
                    query += "ORDER BY A.UPDATE_TIME DESC, A.MACHINE_NUMBER ASC; ";

            return query;
        }



        public static DataTable getErrorStateByMachine(string startDay, string endDay)
        {
            string query = string.Empty;

            query = getQuery_SelectErrorStateByMachine(startDay, endDay);
            DataSet dataset = new DataSet();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection conn = new SqlConnection(commonVar.dbConnectionString);

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = query;

                adapter.SelectCommand = cmd;
                adapter.Fill(dataset);

                if ( dataset.Tables[0].Rows.Count > 0 )
                {
                    return dataset.Tables[0];
                }
                else
                    return null;
            }
            catch ( Exception ex )
            {
                throw ex;
            }
        }

//        private static string getQuery_PresentErrorDetail(string MachineCode, string today) 
//        {
//            string query = string.Empty;

//            query = @"SELECT A.MACHINE_CODE, ERROR_CODE, CONVERT(NVARCHAR(30), UPDATE_TIME,121) AS UPDATE_TIME,
//                                      B.FieldName as ErrorText, C.MACHINE_NAME, C.MACHINE_NUMBER, C.MACHINE_TYPE
//
//                                FROM ERROR_LIST as A
//                                JOIN BaseMemoryMap as B on A.ERROR_CODE = b.FieldCode
//                                JOIN SEOLBI as C on A.MACHINE_CODE = C.MACHINE_CODE
//
//                                WHERE ERROR_STATE = '1'	
//                                        AND A.MACHINE_CODE = '" + MachineCode +
//                                      @"'AND A.UPDATE_TIME >= '" + today + "' ORDER BY UPDATE_TIME DESC";

//            return today;
//        }


//        public static DataTable getPresentErrorDetail(string MachineCode, string today) 
//        {
//            string query = getQuery_PresentErrorDetail(MachineCode, today);

//            DataSet dataset = new DataSet();
//            SqlCommand cmd = new SqlCommand();
//            SqlDataAdapter adapter = new SqlDataAdapter();
//            SqlConnection conn = new SqlConnection(commonVar.dbConnectionString);

//            try
//            {
//                cmd.Connection = conn;
//                cmd.CommandText = query;

//                adapter.SelectCommand = cmd;
//                adapter.Fill(dataset);

//            }
//            catch ( Exception ex )
//            {
//                throw ex;
//            }

//            return dataset.Tables[0];
//        }


//        private static string getQuery_ErrorHistory(string MachineCode) 
//        {
//            string query = @"select A.*, B.FieldName as ErrorText 
//                                    from ERROR_HISTORY A 
//                                    join BaseMemoryMap as B on a.ERROR_CODE = b.FieldCode 
//                                    where a.MACHINE_CODE='"+MachineCode+"'";

//            return query;
//        }

//        public static DataTable getErrorHistory(string MachineCode) 
//        {
//            string query = getQuery_ErrorHistory(MachineCode);

//            DataSet dataset = new DataSet();
//            SqlCommand cmd = new SqlCommand();
//            SqlDataAdapter adapter = new SqlDataAdapter();
//            SqlConnection conn = new SqlConnection(commonVar.dbConnectionString);

//            try
//            {
//                cmd.Connection = conn;
//                cmd.CommandText = query;

//                adapter.SelectCommand = cmd;
//                adapter.Fill(dataset);

//            }
//            catch ( Exception ex )
//            {
//                throw ex;
//            }

//            return dataset.Tables[0];
//        }
        #endregion



    }
}
