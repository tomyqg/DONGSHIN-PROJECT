using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DONGSHIN
{
    public static class fx_bizCode
    {
        #region 업체코드

        public static commonReturn read_all_ec(SqlConnection pCON, string chk) //조회함수
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            if ( chk == "Y" )
                str = @"select * from EOPCHE where trade_chk = 'Y' order by ec_name";
            else
                str = @"select * from EOPCHE order by ec_name";

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

        public static commonReturn findByID(SqlConnection pCON, string id)
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            str = @"select * from EOPCHE where ec_id = @ec_id ";

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };

                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@ec_id", id);
                return2 = DBsql.SQLExecuteDS(pCON, pCMD);
            }
            catch ( Exception exception )
            {
                return2.Message = exception.ToString();
            }
            return return2;
        }

        public static commonReturn findByGbn(SqlConnection pCON, string gbn, string chk)
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            if ( chk == "Y" )
                str = @"select * from EOPCHE where ec_gbn_name like '%' + @gbn + '%' and trade_chk = @chk";
            else
                str = @"select * from EOPCHE where ec_gbn like '%' + @gbn + '%' ";

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@gbn", gbn);
                pCMD.Parameters.AddWithValue("@chk", chk);
                return2 = DBsql.SQLExecuteDS(pCON, pCMD);
            }
            catch ( Exception exception )
            {
                return2.Message = exception.ToString();
            }
            return return2;
        }

        public static commonReturn findByCondition(SqlConnection pCON, string gbn, string name)
        {
            commonReturn return2 = new commonReturn();
            string str = "";

                str = @"select * from EOPCHE where ec_gbn_name like '%' + @gbn + '%' and ec_name like '%' + @name + '%' ";

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@gbn", gbn);
                pCMD.Parameters.AddWithValue("@name", name);
                return2 = DBsql.SQLExecuteDS(pCON, pCMD);
            }
            catch ( Exception exception )
            {
                return2.Message = exception.ToString();
            }
            return return2;
        }

        public static commonReturn write_ec(SqlConnection pCON, bool is_add, SqlCommand pCMD)
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            if ( is_add == true ) //추가일때
            {
                //업체구분 등급 국가 통화 업체코드 상호 세액적용 세금용상호 대표자 사업자번호 업태 종목 전번 팩스 기타 메일 홈피 우편번호 주소시군 주소번지 거래유무 거래중지사유 메모
                str = @"insert into EOPCHE
                            (ec_gbn, ec_grade, nation, currency, ec_id,
                            ec_name, tax_app, tax_ec_name, ceo, service_num, 
                            ec_type, ec_item, tel, fax, etc_tel,
                            mail, homepage, trade_chk, trade_end, memo,
                            post_num, city, street, wr_date)

                            values
                            (@ec_gbn, @ec_grade, @nation, @currency, @ec_id,
                            @ec_name, @tax_app, @tax_ec_name, @ceo, @service_num, 
                            @ec_type, @ec_item, @tel, @fax, @etc_tel,
                            @mail, @homepage, @trade_chk, @trade_end, @memo,
                            @post_num, @city, @street, convert(varchar(10), getdate(), 121) )";
            }
            else //수정일때
            {
                str = @"update EOPCHE
                            set 
                            ec_gbn=@ec_gbn, ec_grade=@ec_grade, nation=@nation, currency=@currency,
                            ec_name=@ec_name, tax_app=@tax_app, tax_ec_name=@tax_ec_name, ceo=@ceo, service_num=@service_num, 
                            ec_type=@ec_type, ec_item=@ec_item, tel=@tel, fax=@fax, etc_tel=@etc_tel,
                            mail=@mail, homepage=@homepage, trade_chk=@trade_chk, trade_end=@trade_end, memo=@memo,
                            post_num=@post_num, city=@city, street=@street

                            where ec_id = @ec_id";
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

        public static commonReturn delete_ec(SqlConnection pCON, string id)
        {
            commonReturn return2 = new commonReturn();
            string str = "";
            try
            {
                SqlCommand pCMD = new SqlCommand();
                str = @"delete from EOPCHE_DAMDANG where ec_id = @ec_id;
                            delete from EOPCHE where ec_id=@ec_id; ";
                pCMD.CommandText = str;
                pCMD.Connection = pCON;
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@ec_id", id);
                return2 = DBsql.SQLExecuteDS(pCON, pCMD);
            }
            catch ( Exception exception )
            {
                return2.Message = exception.ToString();
            }
            return return2;
        }
        #endregion



        #region 업체담당

        public static commonReturn read_dd(SqlConnection pCON, string ec_id) //조회함수
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            str = @"select * from EOPCHE_DAMDANG where ec_id = @ec_id order by dd_name";

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@ec_id", ec_id);
                return2 = DBsql.SQLExecuteDS(pCON, pCMD);
            }
            catch ( Exception exception )
            {
                return2.Message = exception.ToString();
            }
            return return2;
        }

        public static commonReturn write_dd(SqlConnection pCON, bool is_add, SqlCommand pCMD)
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            if ( is_add == true ) //추가일때
            {
                //담당코드, 담당이름, 부서이름, 직위직책, 전화번호, 팩스번호, 휴대전화, 메일, 메모, 사용여부, 업체코드
                str = @"select @dd_id = isnull(max(dd_id), 0) + 1 from EOPCHE_DAMDANG 
				                if @dd_id = 0
					                set @dd_id = 1

                            insert into EOPCHE_DAMDANG
                            (dd_id,dd_name,bs_name,pos,
                            tel,fax,mobi,mail,
                            memo,use_chk, ec_id)

                            values
                            (@dd_id, @dd_name, @bs_name, @pos,
                            @tel, @fax, @mobi, @mail,
                            @memo, @use_chk, @ec_id)";
            }
            else //수정일때
            {
                str = @"update EOPCHE_DAMDANG

                            set 
                            dd_name=@dd_name, bs_name=@bs_name, pos=@pos,
                            tel=@tel, fax=@fax, mobi=@mobi, mail=@mail,
                            memo=@memo, use_chk=@use_chk

                            where dd_id = @dd_id";
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

        public static commonReturn delete_dd(SqlConnection pCON, string id)
        {
            commonReturn return2 = new commonReturn();
            string str = "";
            try
            {
                SqlCommand pCMD = new SqlCommand();
                str = " delete From EOPCHE_DAMDANG  where dd_id = @dd_id ";
                pCMD.CommandText = str;
                pCMD.Connection = pCON;
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@dd_id", id);
                return2 = DBsql.SQLExecuteNonQuery(pCON, pCMD);
            }
            catch ( Exception exception )
            {
                return2.Message = exception.ToString();
            }
            return return2;
        }

        #endregion



    }//class
}//namespace
