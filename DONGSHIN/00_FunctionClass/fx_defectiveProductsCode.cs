using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DONGSHIN
{
    public static class fx_defectiveProductsCode
    {

        public static commonReturn read_all(SqlConnection pCON) //조회함수
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            str = @"select * from BULRYANG_WONIN order by br_gbn, br_id";

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


        public static commonReturn findByDetail(SqlConnection pCON, string detail)
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            str = @"select * from BULRYANG_WONIN where br_detail like '%' + @br_detail + '%'  order by br_id";

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@br_detail", detail);
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

            str = @"select * from BULRYANG_WONIN where br_id = @br_id ";

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };

                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@br_id", id);
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
                str = @"insert into BULRYANG_WONIN
                            (br_id, br_detail, br_gbn, use_chk, seq_num)

                            values
                            (@br_id, @br_detail, @br_gbn, @use_chk, @seq_num)";
            }
            else //수정일때
            {
                str = @"update BULRYANG_WONIN
                            set 
                            br_detail=@br_detail, br_gbn=@br_gbn, use_chk = @use_chk, seq_num = @seq_num

                            where br_id = @br_id";
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
                str = "delete from BULRYANG_WONIN where br_id = @br_id";
                pCMD.CommandText = str;
                pCMD.Connection = pCON;
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@br_id", id);
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
