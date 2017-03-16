using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DONGSHIN
{
    public static class fx_nonOperationCode
    {

        public static commonReturn read_all(SqlConnection pCON) //조회함수
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            str = @"select * from BIGADONG order by bgd_gbn, bgd_id";

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };
                pCMD.Parameters.Clear();
                return2 = DBsql.SQLExecuteDS(pCON, pCMD);
            }
            catch ( Exception exception )
            {
                return2.Message = exception.ToString();
            }
            return return2;
        }


        public static commonReturn findByReason(SqlConnection pCON, string why)
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            str = @"select * from BIGADONG where bgd_why like '%' + @bgd_why + '%'  order by bgd_id";

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@bgd_why", why);
                return2 = DBsql.SQLExecuteDS(pCON, pCMD);
            }
            catch ( Exception exception )
            {
                return2.Message = exception.ToString();
            }
            return return2;
        }


        public static commonReturn findByID(SqlConnection pCON, string id)
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            str = @"select * from BIGADONG where bgd_id = @bgd_id ";

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };

                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@bgd_id", id);
                return2 = DBsql.SQLExecuteDS(pCON, pCMD);
            }
            catch ( Exception exception )
            {
                return2.Message = exception.ToString();
            }
            return return2;
        }


        public static commonReturn write(SqlConnection pCON, bool is_add, SqlCommand pCMD)
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            if ( is_add == true ) //추가일때
            {
                str = @"insert into BIGADONG
                            (bgd_id, bgd_why, bgd_gbn, use_chk, bgd_t)

                            values
                            (@bgd_id, @bgd_why, @bgd_gbn, @use_chk, @bgd_t)";
            }
            else //수정일때
            {
                str = @"update BIGADONG
                            set 
                            bgd_why=@bgd_why, bgd_gbn=@bgd_gbn, bgd_t = @bgd_t, use_chk = @use_chk

                            where bgd_id = @bgd_id";
            }

            try
            {
                pCMD.CommandText = str;
                pCMD.Connection = pCON;
                return2 = DBsql.SQLExecuteNonQuery(pCON, pCMD);
            }
            catch ( Exception exception )
            {
                return2.Message = exception.ToString();
            }
            return return2;
        }


        public static commonReturn delete(SqlConnection pCON, string id)
        {
            commonReturn return2 = new commonReturn();
            string str = "";
            try
            {
                SqlCommand pCMD = new SqlCommand();
                str = "delete from BIGADONG where bgd_id = @bgd_id";
                pCMD.CommandText = str;
                pCMD.Connection = pCON;
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@bgd_id", id);
                return2 = DBsql.SQLExecuteDS(pCON, pCMD);
            }
            catch ( Exception exception )
            {
                return2.Message = exception.ToString();
            }
            return return2;
        }


    }//class
}//namespace
