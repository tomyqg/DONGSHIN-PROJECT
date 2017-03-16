using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DONGSHIN
{
   public static class fx_resinCode
    {

        public static commonReturn readResinRecords(SqlConnection pCON, string chk) //조회함수
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            if ( chk == "Y" )
            {
                str = @"select * from SUJI where use_chk = 'Y' order by sj_id";
            }
            else
            {
                str = @"select * from SUJI order by sj_id ";
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

        public static commonReturn readResinRecordsForRef(SqlConnection pCON) //조회함수
        {
            commonReturn return2 = new commonReturn();
            string str = "";


            str = @"select * from SUJI where use_chk = 'Y' order by sj_id";
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

        public static commonReturn findByName(SqlConnection pCON, string name, string chk) //조회함수
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            if ( chk == "Y" )
            {
                str = @"select *
                            from SUJI
                            where use_chk = 'Y' 
                                    and sj_name like '%' +  @sj_name + '%' order by sj_id ";
            }
            else
                str = @"select *
                            from SUJI
                            where sj_name like '%' +  @sj_name + '%' order by sj_id ";

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@sj_name", name);
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

            str = @"select *
                            from SUJI
                            where sj_id = @id ";

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };

                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@id", id);
                return2 = DBsql.SQLExecuteDS(pCON, pCMD);
            }
            catch ( Exception exception )
            {
                return2.Message = exception.ToString();
            }
            return return2;
        }


        public static commonReturn writeResinRecord(SqlConnection pCON, bool is_add, SqlCommand pCMD)
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            if ( is_add == true ) //추가일때
            {
                str = @"insert into SUJI
                            (sj_id, sj_name, grade, maker, chk_gbn, ms_spec,
                            sj_color, color_name, opt_stock, loss_rate,
                            unit, unit_price, use_chk, memo, auto_wr_date)

                            values
                            (@sj_id, @sj_name, @grade, @maker, @chk_gbn, @ms_spec,
                            @sj_color, @color_name, @opt_stock, @loss_rate,
                            @unit, @unit_price, @use_chk, @memo, getdate())";

            }
            else //수정일때
            {
                str = @"update SUJI
                            set 
                            sj_name=@sj_name, grade=@grade, maker=@maker, chk_gbn=@chk_gbn, ms_spec=@ms_spec,
                            sj_color=@sj_color, color_name=@color_name, opt_stock=@opt_stock, loss_rate=@loss_rate,
                            unit=@unit, unit_price =@unit_price, use_chk=@use_chk, memo=@memo, auto_upd_date=getdate()

                            where sj_id = @sj_id";
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

        public static commonReturn deleteResinRecord(SqlConnection pCON, string id)
        {
            commonReturn return2 = new commonReturn();
            string str = "";
            try
            {
                SqlCommand pCMD = new SqlCommand();
                str = "delete from SUJI where sj_id = @id";
                pCMD.CommandText = str;
                pCMD.Connection = pCON;
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@id", id);
                return2 = DBsql.SQLExecuteDS(pCON, pCMD);
            }
            catch ( Exception exception )
            {
                return2.Message = exception.ToString();
            }
            return return2;
        }



    }//class
}//namespcae
