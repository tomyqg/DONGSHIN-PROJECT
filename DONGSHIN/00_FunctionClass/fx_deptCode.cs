using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DONGSHIN
{
    public static class fx_deptCode
    {
        public static commonReturn read_all(SqlConnection pCON, string chk) //조회함수
        {
            commonReturn return2 = new commonReturn();
            
            string str = "";

            if ( chk == "Y" )
            {
                str = @"select * from BUSEO where use_chk = 'Y' order by bs_id";
            }
            else 
            {
                str = @"select * from BUSEO order by bs_id";
            }

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

        public static commonReturn findByName(SqlConnection pCON, string name, string chk)
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            if ( chk == "Y" )
                str = @"select * from BUSEO where bs_name like '%' + @name + '%' and use_chk = @chk";
            else
                str = @"select * from BUSEO where bs_name like '%' + @name + '%' ";

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@name", name);
                pCMD.Parameters.AddWithValue("@chk", chk);
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

            str = @"select * from BUSEO where bs_id = @bs_id ";

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };

                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@bs_id", id);
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
                str = @"insert into BUSEO
                            (bs_id, bs_name, use_chk)

                            values
                            (@bs_id, @bs_name, @use_chk)";
            }
            else //수정일때
            {
                str = @"update BUSEO
                            set 
                            bs_name=@bs_name, use_chk=@use_chk

                            where bs_id = @bs_id";
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
                str = "delete from BUSEO where bs_id = @bs_id";
                pCMD.CommandText = str;
                pCMD.Connection = pCON;
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@bs_id", id);
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
