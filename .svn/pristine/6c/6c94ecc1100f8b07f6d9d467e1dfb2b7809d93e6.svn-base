using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartQUpdate
{
    public class companyInformation
    {
        public string companyName { get; set; }
        public string companyCode { get; set; }
        public string MACaddress { get; set; }
    }        

    public static class AuthenticationHelper
    {
        private static string connectionString { get; set; }
        
        public static void setConnectinoString(string serverName, string dbName, string id, string pw)
        {
            connectionString = "Data Source=" + serverName + "; "
                                            + "Initial Catalog=" + dbName + "; "
                                            + "User Id=" + id + "; "
                                            + "Password=" + pw + ";";
        }

        private static string getQuery_SelectCompanyRegNum(string companyNumber)
        {
            string query = @"select * from COMPANY_LIST where CompanyRegiNumber= '" + companyNumber + "'";

            return query;
        }

        public static DataTable getCompanyInformation(string companyNumber)
        {
            string query = getQuery_SelectCompanyRegNum(companyNumber);
            SqlCommand cmd = new SqlCommand();
            SqlConnection DBconn = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet DS = new DataSet();

            try
            {
                cmd.Connection = DBconn;
                cmd.CommandText = query;
                adapter.SelectCommand = cmd;
                adapter.Fill(DS);

                if ( DS.Tables[0].Rows.Count > 0 )
                    return DS.Tables[0];
                else
                    return null;
            }
            catch ( Exception ex)
            {
                throw ex;
            }
        }

        private static string getQuery_SelectPCCertification(string companyCode)
        {
            string query = @"select * from PC_CERTIFICATION where COMPANY_CODE ='" + companyCode + "'";

            return query;
        }

        public static int getHowmanyRegistered(string companyCode) 
        {
            string query = getQuery_SelectPCCertification(companyCode);
            SqlCommand cmd = new SqlCommand();
            SqlConnection DBconn = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet DS = new DataSet();

            try 
            {
                cmd.Connection = DBconn;
                cmd.CommandText = query;
                adapter.SelectCommand = cmd;
                adapter.Fill(DS);

                return DS.Tables[0].Rows.Count;
            }
            catch ( Exception ex ) 
            {
                throw ex;
            }
        }

        private static string getQuery_InsertPCCertification(companyInformation companyInfo) 
        {
            string query = @"IF NOT EXISTS 
                                        (SELECT * FROM   PC_CERTIFICATION
                                         WHERE  MAC_ADDRESS = '" + companyInfo.MACaddress + 
                                                  "' AND COMPANY_CODE ='"+companyInfo.companyCode+"')"+
                                @"BEGIN
                                        INSERT INTO PC_CERTIFICATION (MAC_ADDRESS,CERTIFICATION,COMPANY_CODE)
                                        VALUES ('" + companyInfo.MACaddress+"','Y','"+companyInfo.companyCode+
                                   "') END";

            return query;
        }
        
        
        public static string insertPCCertification(companyInformation companyInfo) 
        {
            string errorMessage = string.Empty;
            string query = getQuery_InsertPCCertification(companyInfo);

            SqlCommand cmd = new SqlCommand();
            SqlConnection DBconn = new SqlConnection(connectionString);

            try
            {
                cmd.Connection = DBconn;
                cmd.CommandText = query;

                if ( DBconn.State == ConnectionState.Closed )
                    DBconn.Open();

                cmd.ExecuteNonQuery();

                DBconn.Close();
            }
            catch(Exception ex)
            {
                errorMessage = ex.Message;
            }
            return errorMessage;
        }


        

    }
}
