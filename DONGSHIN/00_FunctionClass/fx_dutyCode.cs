using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DONGSHIN
{
    public static class fx_dutyCode
    {

        public static commonReturn read_all(SqlConnection pCON) //조회함수
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            str = @"select * from GEUNMU order by gm_id";

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


        public static commonReturn findByName(SqlConnection pCON, string name)
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            str = @"select * from GEUNMU where gm_name like '%' + @gm_name + '%'  order by gm_id";

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@gm_name", name);
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

            str = @"select * from GEUNMU where gm_id = @gm_id ";

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };

                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@gm_id", id);
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
                str = @"insert into GEUNMU
                            (gm_id, gm_name, start_time, end_time, gm_time, gm_span)

                            values
                            (@gm_id, @gm_name, @start_time, @end_time , @gm_time, @gm_span)";
            }
            else //수정일때
            {
                str = @"update GEUNMU
                            set 
                            gm_name=@gm_name, start_time=@start_time, end_time = @end_time, gm_time = @gm_time, gm_span=@gm_span

                            where gm_id = @gm_id";
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
                str = "delete from GEUNMU where gm_id = @gm_id";
                pCMD.CommandText = str;
                pCMD.Connection = pCON;
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@gm_id", id);
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
