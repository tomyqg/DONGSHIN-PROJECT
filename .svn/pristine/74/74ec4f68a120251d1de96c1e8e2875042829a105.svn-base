using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace DONGSHIN
{
    public static class fx_moldCode
    {

        public static commonReturn readMoldRecords(SqlConnection pCON, string chk) //조회함수
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            if ( chk == "Y" )
            {
                str = @"select a.*, (select ec_name from EOPCHE where a.balju_id = ec_id) as balju_name,
                                          (select ec_name from EOPCHE where a.jejak_id = ec_id)as jejak_name,
                                          (select ec_name from EOPCHE where a.yangsan_id = ec_id) as yangsan_name,
                                          (select ec_name from EOPCHE where a.wonsuju_id = ec_id) as wonsuju_name,
                                          (select ec_name from EOPCHE where a.buy_id = ec_id) as buy_name,
                                          (select ec_name from EOPCHE where a.where_id = ec_id) as where_name, c.MACHINE_NAME
                            from GEUMHYEONG a left outer join EOPCHE b on (a.balju_id = b.ec_id)
                                              left outer join SEOLBI c on (a.MACHINE_CODE = c.MACHINE_CODE)
                            where a.use_chk = 'Y' ";
            }
            else
            {
                str = @"select a.* , (select ec_name from EOPCHE where a.balju_id = ec_id) as balju_name,
                                            (select ec_name from EOPCHE where a.jejak_id = ec_id) as jejak_name,
                                            (select ec_name from EOPCHE where a.yangsan_id = ec_id) as yangsan_name,
                                            (select ec_name from EOPCHE where a.wonsuju_id = ec_id) as wonsuju_name,
                                            (select ec_name from EOPCHE where a.buy_id = ec_id) as buy_name,
                                            (select ec_name from EOPCHE where a.where_id = ec_id) as where_name, c.MACHINE_NAME
                            from GEUMHYEONG a left outer join EOPCHE b on (a.balju_id = b.ec_id)
                                              left outer join SEOLBI c on (a.MACHINE_CODE = c.MACHINE_CODE) ";
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

        public static commonReturn readMoldRecordsForRef(SqlConnection pCON, string balju, string gbn) //조회함수
        {
            commonReturn return2 = new commonReturn();
            string str = "";


            str = @"select a.* , (select ec_name from EOPCHE where a.balju_id = ec_id) as balju_name,
                                            (select ec_name from EOPCHE where a.jejak_id = ec_id) as jejak_name,
                                            (select ec_name from EOPCHE where a.yangsan_id = ec_id) as yangsan_name,
                                            (select ec_name from EOPCHE where a.wonsuju_id = ec_id) as wonsuju_name,
                                            (select ec_name from EOPCHE where a.buy_id = ec_id) as buy_name,
                                            (select ec_name from EOPCHE where a.where_id = ec_id) as where_name, c.MACHINE_NAME
                            from GEUMHYEONG a left outer join EOPCHE b on (a.balju_id = b.ec_id)
                                              left outer join SEOLBI c on (a.MACHINE_CODE = c.MACHINE_CODE) 
                            where a.use_chk = 'Y' 
                                    and ec_name like '%' +  @balju_name + '%' 
                                    and jj_gbn like '%' + @jj_gbn + '%' ";
            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@balju_name", balju);
                pCMD.Parameters.AddWithValue("@jj_gbn", gbn);

                return2 = DBsql.SQLExecuteDS(pCON, pCMD);
            }
            catch ( Exception exception )
            {
                return2.Message = exception.ToString();
            }
            return return2;
        }

        public static commonReturn findByCondition(SqlConnection pCON, string balju, string gbn, string chk) //조회함수
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            if ( chk == "Y" )
            {
                    str = @"select a.* , (select ec_name from EOPCHE where a.balju_id = ec_id) as balju_name,
                                            (select ec_name from EOPCHE where a.jejak_id = ec_id) as jejak_name,
                                            (select ec_name from EOPCHE where a.yangsan_id = ec_id) as yangsan_name,
                                            (select ec_name from EOPCHE where a.wonsuju_id = ec_id) as wonsuju_name,
                                            (select ec_name from EOPCHE where a.buy_id = ec_id) as buy_name,
                                            (select ec_name from EOPCHE where a.where_id = ec_id) as where_name, c.MACHINE_NAME
                            from GEUMHYEONG a left outer join EOPCHE b on (a.balju_id = b.ec_id)
                                              left outer join SEOLBI c on (a.MACHINE_CODE = c.MACHINE_CODE) 
                            where a.use_chk = 'Y' 
                                    and ec_name like '%' +  @balju_name + '%' 
                                    and jj_gbn like '%' + @jj_gbn + '%' ";
            }
            else
                str = @"select a.* , (select ec_name from EOPCHE where a.balju_id = ec_id) as balju_name,
                                            (select ec_name from EOPCHE where a.jejak_id = ec_id) as jejak_name,
                                            (select ec_name from EOPCHE where a.yangsan_id = ec_id) as yangsan_name,
                                            (select ec_name from EOPCHE where a.wonsuju_id = ec_id) as wonsuju_name,
                                            (select ec_name from EOPCHE where a.buy_id = ec_id) as buy_name,
                                            (select ec_name from EOPCHE where a.where_id = ec_id) as where_name, c.MACHINE_NAME
                            from GEUMHYEONG a left outer join EOPCHE b on (a.balju_id = b.ec_id) 
                                              left outer join SEOLBI c on (a.MACHINE_CODE = c.MACHINE_CODE) 
                            where ec_name like '%' +  @balju_name + '%' 
                                    and jj_gbn like '%' + @jj_gbn + '%' ";

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@balju_name", balju);
                pCMD.Parameters.AddWithValue("@jj_gbn", gbn);
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

            str = @"select a.* , (select ec_name from EOPCHE where a.balju_id = ec_id) as balju_name,
                                            (select ec_name from EOPCHE where a.jejak_id = ec_id) as jejak_name,
                                            (select ec_name from EOPCHE where a.yangsan_id = ec_id) as yangsan_name,
                                            (select ec_name from EOPCHE where a.wonsuju_id = ec_id) as wonsuju_name,
                                            (select ec_name from EOPCHE where a.buy_id = ec_id) as buy_name,
                                            (select ec_name from EOPCHE where a.where_id = ec_id) as where_name, c.MACHINE_NAME
                            from GEUMHYEONG a left outer join EOPCHE b on (a.balju_id = b.ec_id)
                                              left outer join SEOLBI c on (a.MACHINE_CODE = c.MACHINE_CODE) 
                            where gh_id = @id ";

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


        public static commonReturn findByMachineID(SqlConnection pCON, string id)
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            str = @"select * from GEUMHYEONG where MACHINE_CODE = @id ";

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


        public static commonReturn write(SqlConnection pCON, bool is_add, SqlCommand pCMD) 
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            if ( is_add == true ) //추가일때
            {
                str = @"insert into GEUMHYEONG
                            (gh_id, model, gh_name, gh_num, nation, currency, gh_gbn, jj_gbn, MACHINE_CODE,
                                jj_goal, buy_dd, design_dd1, design_dd2, jj_dd1, jj_dd2, 
                                balju_num, balju_id, jejak_id, yangsan_id, wonsuju_id, buy_id, where_id, 
                                wr_date, fix_date, nego_date, t0_date, t1_date, init_date, okay_date,
                                out_date, ship_date, arrive_date, ys_date, dump_date, location,
                                chk_shot, chk_month, chk_freq, chk_final_date, chk_final_shot,
                                spec_freq, error_freq, blueprint_freq, sample_freq, warranty, limit,
                                init_shot, accumulated, auth_num, size, weight, spec, cavity,
                                mtrl_core, qt_core, mtrl_cavity, qt_cavity, mtrl_upSL, qt_upSL,
                                mtrl_lowSL, qt_lowSL, mtrl_angular, qt_angular, shrink, gate_type,
                                runner_eject, jp_eject, machine_type, inject_type, cycle_t,
                                gh_img1, gh_img2, gh_img3, gh_img4, memo, use_chk)

                            values
                            (@gh_id, @model, @gh_name, @gh_num, @nation, @currency, @gh_gbn, @jj_gbn, @MACHINE_CODE,
                                @jj_goal, @buy_dd, @design_dd1, @design_dd2, @jj_dd1, @jj_dd2, 
                                @balju_num, @balju_id, @jejak_id, @yangsan_id, @wonsuju_id, @buy_id, @where_id, 
                                @wr_date, @fix_date, @nego_date, @t0_date, @t1_date, @init_date, @okay_date,
                                @out_date, @ship_date, @arrive_date, @ys_date, @dump_date, @location,
                                @chk_shot, @chk_month, @chk_freq, @chk_final_date, @chk_final_shot,
                                @spec_freq, @error_freq, @blueprint_freq, @sample_freq, @warranty, @limit,
                                @init_shot, @accumulated, @auth_num, @size, @weight, @spec, @cavity,
                                @mtrl_core, @qt_core, @mtrl_cavity, @qt_cavity, @mtrl_upSL, @qt_upSL,
                                @mtrl_lowSL, @qt_lowSL, @mtrl_angular, @qt_angular, @shrink, @gate_type,
                                @runner_eject, @jp_eject, @machine_type, @inject_type, @cycle_t,
                                @gh_img1, @gh_img2, @gh_img3, @gh_img4, @memo, @use_chk)";

            }
            else //수정일때
            {
                str = @"update GEUMHYEONG
                            set 
                            model=@model , gh_name=@gh_name , gh_num=@gh_num , nation=@nation , currency=@currency , gh_gbn=@gh_gbn , jj_gbn=@jj_gbn , MACHINE_CODE=@MACHINE_CODE,
                                jj_goal=@jj_goal , buy_dd=@buy_dd , design_dd1=@design_dd1 , design_dd2=@design_dd2 , jj_dd1=@jj_dd1 , jj_dd2=@jj_dd2 , 
                                balju_num=@balju_num , balju_id=@balju_id , jejak_id=@jejak_id , yangsan_id=@yangsan_id , wonsuju_id=@wonsuju_id , buy_id=@buy_id , where_id=@where_id , 
                                wr_date=@wr_date , fix_date=@fix_date , nego_date=@nego_date , t0_date=@t0_date , t1_date=@t1_date , init_date=@init_date , okay_date=@okay_date ,
                                out_date=@out_date , ship_date=@ship_date , arrive_date=@arrive_date , ys_date=@ys_date , dump_date=@dump_date , location=@location ,
                                chk_shot=@chk_shot , chk_month=@chk_month , chk_freq=@chk_freq , chk_final_date=@chk_final_date , chk_final_shot=@chk_final_shot ,
                                spec_freq=@spec_freq , error_freq=@error_freq , blueprint_freq=@blueprint_freq , sample_freq=@sample_freq , warranty=@warranty , limit=@limit ,
                                init_shot=@init_shot , accumulated=@accumulated , auth_num=@auth_num , size=@size , weight=@weight , spec=@spec , cavity=@cavity , 
                                mtrl_core=@mtrl_core , qt_core=@qt_core , mtrl_cavity=@mtrl_cavity , qt_cavity=@qt_cavity , mtrl_upSL=@mtrl_upSL , qt_upSL=@qt_upSL ,
                                mtrl_lowSL=@mtrl_lowSL , qt_lowSL=@qt_lowSL , mtrl_angular=@mtrl_angular , qt_angular=@qt_angular , shrink=@shrink , gate_type=@gate_type ,
                                runner_eject=@runner_eject , jp_eject=@jp_eject , machine_type=@machine_type , inject_type=@inject_type , cycle_t=@cycle_t ,
                                gh_img1=@gh_img1 , gh_img2=@gh_img2 , gh_img3=@gh_img3 , gh_img4=@gh_img4 , memo=@memo , use_chk=@use_chk

                            where gh_id = @gh_id";
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
                str = "delete from GEUMHYEONG where gh_id = @id";
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
