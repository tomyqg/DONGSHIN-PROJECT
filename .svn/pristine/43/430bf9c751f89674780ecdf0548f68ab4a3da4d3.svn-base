using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DONGSHIN
{
    public static class PerformanceSettingHelper
    {

        private static string getQuery_SelectShotCount() 
        {
            return "select top(1) CYCLE_COUNT, A00010 from ActualData_1 where MACHINE_CODE = 'GB-01' order by SAVE_DATETIME desc";
            //return "select A00011 from ActualData_1 where MACHINE_CODE = 'GB-01' order by SAVE_DATETIME desc";
        }

        public static DataTable getShotCount() 
        {
            string query = getQuery_SelectShotCount();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataset = new DataSet();

            string exceptionMessage = string.Empty;
            using ( SqlConnection sqlCon = new SqlConnection(commonVar.dbConnectionString) )
            {
                try
                {
                    cmd.Connection = sqlCon;
                    cmd.CommandText = query;

                    adapter.SelectCommand = cmd;
                    adapter.Fill(dataset);

                    if ( dataset.Tables[0].Rows.Count > 0 )
                    {
                        //DataTable table = new DataTable();
                        //table.Columns.Add("A00010", typeof(Int32));
                        //table.Columns.Add("A00011", typeof(Int32));

                        //DataRow row = table.NewRow();
                        //int a = Convert.ToInt32(dataset.Tables[0].Rows[0]["A00010"]);
                        //row["A00010"] = a;
                        //row["A00011"] = Convert.ToInt32(dataset.Tables[0].Rows[0]["A00011"]);

                        //table.Rows.Add(row);

                        //return table;
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
        }



        private static string getQuery_SelectProductCodes(string[] Codes) 
        {
            string query = string.Empty;
            int count = Codes.Length;
                       

            for ( int i = 0 ; i < count ; i++ ) 
            {
               query += "Select a.*, b.sj_name, 0 as qt_plan from JEPUM a left outer join SUJI b on (a.sj_id = b.sj_id) where a.jp_id = '" + Codes[i] + "' \n";

               if ( i < count - 1 )
                    query += "UNION \n";
            }
            query += ";";
            return query;
        }


        public static DataTable getProductsInformation(string[] Codes) 
        {
            string query = getQuery_SelectProductCodes(Codes);

            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dataset = new DataSet();

            string exceptionMessage = string.Empty;
            using ( SqlConnection sqlCon = new SqlConnection(commonVar.dbConnectionString) )
            {
                try
                {
                    cmd.Connection = sqlCon;
                    cmd.CommandText = query;

                    adapter.SelectCommand = cmd;
                    adapter.Fill(dataset);

                    if ( dataset.Tables[0].Rows.Count > 0 )
                        return dataset.Tables[0];
                    else
                        return null;
                }
                catch ( Exception ex )
                {
                    throw ex;
                }

            }
        }




    }
}
