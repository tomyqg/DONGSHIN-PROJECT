﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace DONGSHIN
{
    public static class memorymapSettingHelper
    {
        #region 베이스 메모리맵 코드

        public static string getQuery_Select_BaseMemoryMap()
        {
            return "SELECT * FROM BaseMemoryMap";
        }

        public static DataTable getBaseMemoryMap()
        {
            string query = getQuery_Select_BaseMemoryMap();
            SqlCommand com = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            string exceptionMessage = string.Empty;
            using ( SqlConnection sqlCon = new SqlConnection(commonVar.dbConnectionString) )
            {
                try
                {
                    com.Connection = sqlCon;
                    com.CommandText = query;

                    adapter.SelectCommand = com;
                    adapter.Fill(dataSet);

                    if ( dataSet.Tables[0].Rows.Count > 0 )
                        return dataSet.Tables[0];
                    else
                        return null;
                }
                catch ( Exception ex )
                {
                    throw ex;
                }

            }

        }
        

        public static string getQuery_Delete_BaseMemoryMap()
        {
            return "delete BaseMemoryMap";
        }

        public static string getQuery_Delete_BaseMemoryMap(string fieldCode)
        {
            return "delete BaseMemoryMap where FieldCode = '"+fieldCode+"'";
        }
        
        public static string deleteBaseMemoryMap()
        {
            string query = getQuery_Delete_BaseMemoryMap();

            SqlCommand com = new SqlCommand();
            string exceptionMessage = string.Empty;
            using ( SqlConnection sqlCon = new SqlConnection(commonVar.dbConnectionString) )
            {
                try
                {
                    com.Connection = sqlCon;
                    com.CommandText = query;
                    sqlCon.Open();
                    com.ExecuteNonQuery();
                    sqlCon.Close();
                }
                catch ( Exception ex )
                {
                    exceptionMessage = ex.Message;
                }

            }

            return exceptionMessage;

        }

        public static string deleteSingleBaseMemoryMapRecord(string fieldCode)
        {
            string query = getQuery_Delete_BaseMemoryMap(fieldCode);

            SqlCommand com = new SqlCommand();
            string exceptionMessage = string.Empty;
            using ( SqlConnection sqlCon = new SqlConnection(commonVar.dbConnectionString) )
            {
                try
                {
                    com.Connection = sqlCon;
                    com.CommandText = query;
                    sqlCon.Open();
                    com.ExecuteNonQuery();
                    sqlCon.Close();
                }
                catch ( Exception ex )
                {
                    exceptionMessage = ex.Message;
                }

            }

            return exceptionMessage;

        }
        

        private static string getQuery_Update_BaseMemoryMap(DataRow row, string originalCode)
        {
            string query = string.Empty;
            string[] columns = new string[] { "FieldCode", "FieldName" ,"FieldUnit"};
            int dataLength = columns.Length;

            query += "update BaseMemoryMap set FieldCode = '";
            query += row["FieldCode"].ToString() + "' ,";
            
            query += "FieldName = '";
            query += row["FieldName"].ToString() + "' ,";

            query += "FieldUnit = '";
            query+= row["FieldUnit"].ToString() + "'";

            query += " where FieldCode = '" + originalCode + "'";

            return query;
        }

        public static string updateBaseMemoryMap(DataRow row, string originalCode)
        {
            string query = getQuery_Update_BaseMemoryMap(row, originalCode);

            SqlCommand com = new SqlCommand();
            string exceptionMessage = string.Empty;
            using ( SqlConnection sqlCon = new SqlConnection(commonVar.dbConnectionString) )
            {
                try
                {
                    com.Connection = sqlCon;
                    com.CommandText = query;
                    sqlCon.Open();
                    com.ExecuteNonQuery();
                    sqlCon.Close();
                }
                catch ( Exception ex )
                {
                    exceptionMessage = ex.Message;
                }

            }

            return exceptionMessage;
        }


        private static string getQuery_Insert_BaseMemoryMap(DataRow row)
        {
            string query = string.Empty;
            string[] columns = new string[] { "FieldCode", "FieldName", "FieldUnit" };
            int dataLength = columns.Length;

            query += "INSERT INTO BaseMemoryMap " + "(";
            for ( int i = 0 ; i < dataLength ; i++ )
            {
                query += columns[i];
                if ( i < dataLength - 1 )
                    query += ",";
            }
            query += ") ";
            query += "VALUES(";

            for ( int i = 0 ; i < dataLength ; i++ )
            {
                if ( row.Table.Columns.Contains(columns[i]) )
                {
                    string item = "'" + row[columns[i]].ToString() + "'";
                    query += item;
                    if ( i < dataLength - 1 )
                        query += ",";
                }

            }
            query += ")\n";

            return query;
        }

        public static string insertBaseMemoryMap(DataTable excelTable)
        {
            string query = string.Empty;
            for ( int i = 0 ; i < excelTable.Rows.Count ; i++ )
            {
                DataRow row = excelTable.Rows[i];
                query += getQuery_Insert_BaseMemoryMap(row);
            }
            SqlCommand com = new SqlCommand();
            string exceptionMessage = string.Empty;
            using ( SqlConnection sqlCon = new SqlConnection(commonVar.dbConnectionString) )
            {
                try
                {
                    com.Connection = sqlCon;
                    com.CommandText = query;
                    sqlCon.Open();
                    com.ExecuteNonQuery();
                    sqlCon.Close();
                }
                catch ( Exception ex )
                {
                    exceptionMessage = ex.Message;
                }

            }

            return exceptionMessage;

        }

        public static string insertBaseMemoryMap(DataRow row)
        {
            string query = getQuery_Insert_BaseMemoryMap(row);
            
            SqlCommand com = new SqlCommand();
            string exceptionMessage = string.Empty;
            using ( SqlConnection sqlCon = new SqlConnection(commonVar.dbConnectionString) )
            {
                try
                {
                    com.Connection = sqlCon;
                    com.CommandText = query;
                    sqlCon.Open();
                    com.ExecuteNonQuery();
                    sqlCon.Close();
                }
                catch ( Exception ex )
                {
                    exceptionMessage = ex.Message;
                }

            }

            return exceptionMessage;

        }
        #endregion





        #region 메모리맵 타입

        private static string getQuery_Select_MemoryMapType()
        {
            return "SELECT * FROM MemoryMapType";
        }

        public static DataTable getMemorymapType()
        {
            string query = getQuery_Select_MemoryMapType();
            SqlCommand com = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            string exceptionMessage = string.Empty;
            using ( SqlConnection sqlCon = new SqlConnection(commonVar.dbConnectionString) )
            {
                try
                {
                    com.Connection = sqlCon;
                    com.CommandText = query;

                    adapter.SelectCommand = com;
                    adapter.Fill(dataSet);

                    if ( dataSet.Tables[0].Rows.Count > 0 )
                        return dataSet.Tables[0];
                    else
                        return null;
                }
                catch ( Exception ex )
                {
                    throw ex;
                }

            }

        }

        

        private static string getQuery_Delete_MemoryMapType(string mapType)
        {
            return "delete from MemoryMapType where MapType = '" + mapType + "'";
        }

        public static string deleteMemoryMapType(string maptype)
        {
            string query = getQuery_Delete_MemoryMapType(maptype);

            SqlCommand com = new SqlCommand();
            string exceptionMessage = string.Empty;
            using ( SqlConnection sqlCon = new SqlConnection(commonVar.dbConnectionString) )
            {
                try
                {
                    com.Connection = sqlCon;
                    com.CommandText = query;
                    sqlCon.Open();
                    com.ExecuteNonQuery();
                    sqlCon.Close();
                }
                catch ( Exception ex )
                {
                    exceptionMessage = ex.Message;
                }

            }

            return exceptionMessage;

        }



        private static string getQuery_Insert_MemoryMapType(DataRow row) 
        {
            string query = string.Empty;
            string[] columns = new string[] { "MapType", "Offset" };
            int dataLength = columns.Length;

            query += "INSERT INTO MemoryMapType " + "(";
            for ( int i = 0 ; i < dataLength ; i++ )
            {
                query += columns[i];
                if ( i < dataLength - 1 )
                    query += ",";
            }
            query += ") ";
            query += "VALUES(";

            for ( int i = 0 ; i < dataLength ; i++ )
            {
                if ( row.Table.Columns.Contains(columns[i]) )
                {
                    string item = "'" + row[columns[i]].ToString() + "'";
                    query += item;
                    if ( i < dataLength - 1 )
                        query += ",";
                }

            }
            query += ")\n";

            return query;
        }

        public static string insertMemoryMapType(DataRow row)
        {
            string query = getQuery_Insert_MemoryMapType(row);
           
            SqlCommand com = new SqlCommand();
            string exceptionMessage = string.Empty;
            using ( SqlConnection sqlCon = new SqlConnection(commonVar.dbConnectionString) )
            {
                try
                {
                    com.Connection = sqlCon;
                    com.CommandText = query;
                    sqlCon.Open();
                    com.ExecuteNonQuery();
                    sqlCon.Close();
                }
                catch ( Exception ex )
                {
                    exceptionMessage = ex.Message;
                }

            }

            return exceptionMessage;
        }



        private static string getQuery_Update_MemoryMapType(DataRow row, string originalType)
        {
            string query = string.Empty;
            string[] columns = new string[] { "MapType", "Offset" };
            int dataLength = columns.Length;

            query += "update MemoryMapType set MapType = '";
            query += row["MapType"].ToString() + "' ,";
            query += "Offset =";
            query += row["Offset"].ToString();
            query += " where MapType = '" + originalType + "'";

            return query;
        }

        public static string updateMemoryMapType(DataRow row, string originalType)
        {
            string query = getQuery_Update_MemoryMapType(row, originalType);

            SqlCommand com = new SqlCommand();
            string exceptionMessage = string.Empty;
            using ( SqlConnection sqlCon = new SqlConnection(commonVar.dbConnectionString) )
            {
                try
                {
                    com.Connection = sqlCon;
                    com.CommandText = query;
                    sqlCon.Open();
                    com.ExecuteNonQuery();
                    sqlCon.Close();
                }
                catch ( Exception ex )
                {
                    exceptionMessage = ex.Message;
                }

            }

            return exceptionMessage;
        }

        #endregion




        #region 설비별 메모리맵

        private static string getQuery_Select_MachineMemorymap(string mapType)
        {
            return "select * from MachineMemoryMap where MapType = '" + mapType + "'";
        }

        public static DataTable getMachineMemorymap(string mapType)
        {
            string query = getQuery_Select_MachineMemorymap(mapType);
            SqlCommand com = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            string exceptionMessage = string.Empty;
            using ( SqlConnection sqlCon = new SqlConnection(commonVar.dbConnectionString) )
            {
                try
                {
                    com.Connection = sqlCon;
                    com.CommandText = query;

                    adapter.SelectCommand = com;
                    adapter.Fill(dataSet);

                    if ( dataSet.Tables[0].Rows.Count > 0 )
                        return dataSet.Tables[0];
                    else
                        return null;
                }
                catch ( Exception ex )
                {
                    throw ex;
                }

            }

        }



        private static string getQuery_Insert_MachineMemoryMap(DataRow row, string mapType)
        {
            string query = string.Empty;
            string item = string.Empty;
            string[] columns = new string[] { "FieldCode", "FieldAddress", "DataLength", "DecimalPoint", "Reference", "UseOrNot", "SaveOrNot"};
            int dataLength = columns.Length;


            if (row["FieldCode"].ToString().Length > 0)
            {
                query += "INSERT INTO MachineMemoryMap " + "(MapType,";
                for (int i = 0; i < dataLength; i++)
                {
                    query += columns[i];
                    if (i < dataLength - 1)
                        query += ",";
                }
                query += ") ";
                query += "VALUES(";
                query += "'" + mapType + "'" + ",";
                for (int i = 0; i < dataLength; i++)
                {
                    if (row.Table.Columns.Contains(columns[i]))
                    {

                        item = "'" + row[columns[i]].ToString() + "'";
                        query += item;
                        if (i < dataLength - 1)
                            query += ",";
                    }


                }
                query += ")\n";
            }

            return query;
        }

        public static string insertMachineMemoryMap(DataTable excelTable, string maptype)
        {
            string query = string.Empty;
            for ( int i = 0 ; i < excelTable.Rows.Count ; i++ )
            {
                DataRow row = excelTable.Rows[i];
                query += getQuery_Insert_MachineMemoryMap(row, maptype);
            }
            SqlCommand com = new SqlCommand();
            string exceptionMessage = string.Empty;
            using ( SqlConnection sqlCon = new SqlConnection(commonVar.dbConnectionString) )
            {
                try
                {
                    com.Connection = sqlCon;
                    com.CommandText = query;
                    sqlCon.Open();
                    com.ExecuteNonQuery();
                    sqlCon.Close();
                }
                catch ( Exception ex )
                {
                    exceptionMessage = ex.Message;
                }

            }

            return exceptionMessage;

        }

        public static string insertMachineMemoryMap(DataRow row, string maptype)
        {
            string query = getQuery_Insert_MachineMemoryMap(row, maptype);
           
            SqlCommand com = new SqlCommand();
            string exceptionMessage = string.Empty;
            using ( SqlConnection sqlCon = new SqlConnection(commonVar.dbConnectionString) )
            {
                try
                {
                    com.Connection = sqlCon;
                    com.CommandText = query;
                    sqlCon.Open();
                    com.ExecuteNonQuery();
                    sqlCon.Close();
                }
                catch ( Exception ex )
                {
                    exceptionMessage = ex.Message;
                }

            }

            return exceptionMessage;

        }

        private static string getQuery_Update_MachineMemoryMap(DataRow row, string maptype)
        {
            string query = string.Empty;
            string[] columns = new string[] { "FieldCode", "MapType", "FieldAddress","DataLength", "DecimalPoint", "Reference", "UseOrNot", "SaveOrNot" };
            int dataLength = columns.Length;

            query += "update MachineMemoryMap set FieldCode = '";
            query += row["FieldCode"].ToString() + "' ,";

            query += "MapType = '";
            query += maptype + "' ,";

            query += "FieldAddress = '";
            query += row["FieldAddress"].ToString() + "' ,";

            query += "DataLength = '";
            query += row["DataLength"].ToString() + "' ,";

            query += "DecimalPoint = '";
            query += row["DecimalPoint"].ToString() + "' ,";

            query += "Reference = '";
            query += row["Reference"].ToString() + "' ,";

            query += "UseOrNot = '";
            query += row["UseOrNot"].ToString() + "' ,";

            query += "SaveOrNot = '";
            query += row["SaveOrNot"].ToString() + "'";

            query += " where Id = " + Convert.ToInt32(row["Id"]);

            return query;
        }

        public static string updateMachineMemoryMap(DataRow row, string maptype)
        {
            string query = getQuery_Update_MachineMemoryMap(row, maptype);

            SqlCommand com = new SqlCommand();
            string exceptionMessage = string.Empty;
            using ( SqlConnection sqlCon = new SqlConnection(commonVar.dbConnectionString) )
            {
                try
                {
                    com.Connection = sqlCon;
                    com.CommandText = query;
                    sqlCon.Open();
                    com.ExecuteNonQuery();
                    sqlCon.Close();
                }
                catch ( Exception ex )
                {
                    exceptionMessage = ex.Message;
                }

            }

            return exceptionMessage;
        }



        private static string getQuery_DeleteAll_MachineMemoryMap(string mapType)
        {
            return "delete from MachineMemoryMap where MapType = '" + mapType + "'";
        }

        private static string getQuery_DeleteSingle_MachineMemoryMap(string id)
        {
            return "delete from MachineMemoryMap where Id = '"+id+"'";
        }

        public static string deleteMachineMemoryMap(DataRow row, string gbn)
        {

            string query = string.Empty;
            string id = row["Id"].ToString();
            string maptype = row["MapType"].ToString();

            if ( gbn == "all" )
                query = getQuery_DeleteAll_MachineMemoryMap(maptype);
            else
                query = getQuery_DeleteSingle_MachineMemoryMap(id);

            SqlCommand com = new SqlCommand();
            string exceptionMessage = string.Empty;
            using ( SqlConnection sqlCon = new SqlConnection(commonVar.dbConnectionString) )
            {
                try
                {
                    com.Connection = sqlCon;
                    com.CommandText = query;
                    sqlCon.Open();
                    com.ExecuteNonQuery();
                    sqlCon.Close();
                }
                catch ( Exception ex )
                {
                    exceptionMessage = ex.Message;
                }

            }

            return exceptionMessage;

        }


        
        #endregion


        #region 엑셀파일 불러오기

        public static DataTable GetDataTableFromExcel(string filePath)
        {
            try
            {
                string oledbConString = string.Empty;
                DataTable resultTable = new DataTable();
                FileInfo fi = new FileInfo(filePath);
                if ( fi.Exists )
                {
                    if ( filePath.IndexOf(".xlsx") > -1 )
                    {
                        oledbConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath
                            + ";Extended Properties=\"Excel 12.0\"";
                    }
                    else
                    {
                        oledbConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath
                               + ";Extended Properties=\"Excel 8.0\"";
                    }


                    using ( OleDbConnection oleExcelCon = new OleDbConnection(oledbConString) )
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

        #endregion

    }//class
}//namespace
