using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DONGSHIN
{
    public static class fx_empCode
    {

        public static commonReturn read_all(SqlConnection pCON, string chk) //조회함수
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            if ( chk == "Y" )
            {
                str = @"select a.*, b.bs_name 
                            from SAWON a left outer join BUSEO b on (a.bs_id = b.bs_id) 
                            where a.use_chk = 'Y'
                            order by b.bs_name, a.sw_id";
            }
            else
            {
                str = @"select a.*, b.bs_name
                            from SAWON a left outer join BUSEO b on (a.bs_id = b.bs_id)
                            order by b.bs_name, a.sw_id";
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
        

        public static commonReturn findBy2Param(SqlConnection pCON, string name, string dept) 
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            str = @"select a.*, b.bs_name 
                        from SAWON a left outer join BUSEO b on (a.bs_id = b.bs_id) 
                        where a.use_chk = 'Y'
                        and a.sw_name like '%' + @name + '%'
                        and b.bs_name like '%' + @dept + '%'
                        order by b.bs_name, a.sw_id";

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@name", name);
                pCMD.Parameters.AddWithValue("@dept", dept);
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
                str = @"select a.*, b.bs_name from SAWON a left outer join BUSEO b on (a.bs_id = b.bs_id) where a.sw_name like '%' + @name + '%' and a.use_chk = @chk";
            else
                str = @"select a.*, b.bs_name from SAWON a left outer join BUSEO b on (a.bs_id = b.bs_id) where a.sw_name like '%' + @name + '%' ";

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

            str = @"select a.*, b.bs_name from SAWON a left outer join BUSEO b on (a.bs_id = b.bs_id) where a.sw_id = @sw_id ";

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };

                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@sw_id", id);
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
                //사원번호, 비밀번호, 사원이름, 영어이름, 부서코드, 직위, 핸드폰, 메일, 표준임률, 표준시간, 메모, 사용여부, 유저구분(사용자/관리자), 사진
                str = @"insert into SAWON
                            (sw_id, pw, sw_name, sw_eng_name, 
                            bs_id, pos, mobi, mail, std_lab_rt, std_lab_t,
                            memo, use_chk, user_gbn, sw_img, auto_wr_date, ALARM_CHK)

                            values
                            (@sw_id, @pw, @sw_name, @sw_eng_name, 
                            @bs_id, @pos, @mobi, @mail, @std_lab_rt, @std_lab_t,
                            @memo, @use_chk, @user_gbn, @sw_img, getdate(), @ALARM_CHK)";
            }
            else //수정일때
            {
                str = @"update SAWON
                            set 
                            pw=@pw, sw_name=@sw_name, sw_eng_name=@sw_eng_name, 
                            bs_id=@bs_id, pos=@pos, mobi=@mobi, mail=@mail, std_lab_rt=@std_lab_rt, std_lab_t=@std_lab_t,
                            memo=@memo, use_chk=@use_chk, user_gbn=@user_gbn, sw_img=@sw_img, auto_upd_date=getdate(),
                            ALARM_CHK=@ALARM_CHK

                            where sw_id = @sw_id";
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
                str = "delete from SAWON where sw_id = @sw_id";
                pCMD.CommandText = str;
                pCMD.Connection = pCON;
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@sw_id", id);
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
