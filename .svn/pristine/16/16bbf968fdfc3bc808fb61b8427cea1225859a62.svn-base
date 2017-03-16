using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DONGSHIN
{
    public static class fx_productCode
    {
        public static commonReturn read_all(SqlConnection pCON, string chk) //조회함수
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            if ( chk == "Y" )
                str = @"select a.*, b.sj_name
                            from JEPUM a
                                    left outer join SUJI b on (a.sj_id = b.sj_id)
                            where a.use_chk = 'Y' ";
            else
                str = @"select *, b.sj_name
                            from JEPUM a
                                    left outer join SUJI b on (a.sj_id = b.sj_id)";

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

        public static commonReturn findByName(SqlConnection pCON, string model, string chk)
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            if ( chk == "Y" )
                str = @"select a.*, b.sj_name
                            from JEPUM  a
                                    left outer join SUJI b on (a.sj_id = b.sj_id)
                            where a.model like '%' + @model + '%' 
                            and a.use_chk = @chk";
            else
                str = @"select a.*, b.sj_name
                            from JEPUM  a
                                    left outer join SUJI b on (a.sj_id = b.sj_id)
                            where a.model like '%' + @model + '%' ";

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@model", model);
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

            str = @"select a.*, b.sj_name
                        from JEPUM  a
                               left outer join SUJI b on (a.sj_id = b.sj_id) where a.jp_id = @id ";

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

        public static commonReturn findByMoldID(SqlConnection pCON, string id)
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            str = @"select * from JEPUM where gh_id = @id ";

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
            catch (Exception exception)
            {
                return2.Message = exception.ToString();
            }
            return return2;

        }
        public static commonReturn write(SqlConnection pCON, bool is_add, SqlCommand pCMD) //공정코드 테이블 추가시 수정필요 gj_name -> gj_id
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            if ( is_add == true ) //추가일때
            {
                //제품코드 제품이름 제품번호 차종 모델 자재번호 규격 색상 색상이름 등록일자 승인일자 양산일자 단종일자 단종사유 적정재고 캐비티 포장수량 사이클타임 메모 사용여부 사진1,2,3,4
                str = @"insert into JEPUM
                            (jp_id, jp_name, jp_num, 
                            car, model, mtrl_num, spec, jp_color, color_name, sj_id, gh_id,
                            wr_date, aprv_date, mass_date, discont_date, discont_why,
                            opt_stock, now_stock, cavity, cavity_num, qt_pkg, cycle_t, memo, use_chk,
                            jp_img1, jp_img2, jp_img3, jp_img4, jp_stdpaper, auto_wr_date)

                            values
                            (@jp_id, @jp_name, @jp_num, 
                            @car, @model, @mtrl_num, @spec, @jp_color, @color_name, @sj_id, @gh_id,
                            @wr_date, @aprv_date, @mass_date, @discont_date, @discont_why,
                            @opt_stock, @now_stock, @cavity, @cavity_num, @qt_pkg, @cycle_t, @memo, @use_chk,
                            @jp_img1, @jp_img2, @jp_img3, @jp_img4, @jp_stdpaper, getdate())";
            }
            else //수정일때
            {
                str = @"update JEPUM
                            set 
                            jp_name=@jp_name, jp_num=@jp_num, 
                            car=@car, model=@model, mtrl_num=@mtrl_num, spec=@spec, jp_color=@jp_color, color_name=@color_name, sj_id = @sj_id,gh_id=@gh_id,
                            wr_date=@wr_date, aprv_date=@aprv_date, mass_date=@mass_date, discont_date=@discont_date, discont_why=@discont_why, now_stock=@now_stock,
                            opt_stock=@opt_stock, cavity=@cavity, cavity_num = @cavity_num, qt_pkg=@qt_pkg, cycle_t=@cycle_t, memo=@memo, use_chk=@use_chk,
                            jp_img1=@jp_img1, jp_img2=@jp_img2, jp_img3=@jp_img3, jp_img4=@jp_img4, jp_stdpaper =@jp_stdpaper, auto_upd_date = getdate()

                            where jp_id = @jp_id";
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
                str = "delete from JEPUM where jp_id = @id";
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
}//namespace
