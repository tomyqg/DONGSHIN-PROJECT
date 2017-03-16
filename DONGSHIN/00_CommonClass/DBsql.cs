using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DONGSHIN
{
    public class DBsql //sql쿼리문 실행시 필요한 클래스 (원: clsDB.cs)
    {
        public static commonReturn SQLExecuteDS(SqlConnection pCON, SqlCommand pCMD)
        {
            commonReturn commonReturn = new commonReturn();
            SqlDataAdapter DA = new SqlDataAdapter();

            try
            {
                if ( pCON.State != ConnectionState.Open )
                    pCON.Open();

                pCMD.Connection = pCON;
                pCMD.CommandTimeout = 0;
                if ( pCMD.CommandType != CommandType.StoredProcedure )
                    pCMD.CommandType = System.Data.CommandType.Text;
                DA.SelectCommand = pCMD;
                DA.Fill(commonReturn.Dataset);
                commonReturn.Code = 1;
            }
            catch ( Exception ex )
            {
                commonReturn.Code = -1;
                commonReturn.Message = ex.ToString();
            }
            finally
            {
                pCMD.Dispose();
            }

            return commonReturn;
        }
        
        public static commonReturn SQLExecuteNonQuery(SqlConnection pCON, SqlCommand pCMD)
        {
            commonReturn commonReturn = new commonReturn();

            try
            {
                if ( pCON.State != ConnectionState.Open )
                    pCON.Open();

                pCMD.Connection = pCON;
                pCMD.CommandTimeout = 120;
                commonReturn.ExeCount = pCMD.ExecuteNonQuery();
                commonReturn.Code = 1;
                commonReturn.Message = "";

                return commonReturn;
            }
            catch ( Exception ex )
            {
                commonReturn.Code = -1;
                commonReturn.Message = ex.ToString();
            }
            finally
            {
                pCMD.Dispose();
            }
            return commonReturn;
        }
    }//클래스
}//네임스페이스
