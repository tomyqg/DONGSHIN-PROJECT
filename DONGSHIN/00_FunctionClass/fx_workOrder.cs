using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DONGSHIN
{
    public static class fx_workOrder
    {
        public static DataTable getWorkOrderInfo(string MachineCode) //사출조건(mcRight6,gbRight6,rbRight6)
        {
            DataSet dataset = new DataSet();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlConnection conn = new SqlConnection(commonVar.dbConnectionString);

            string today = DateTime.Today.ToShortDateString();

            string query = @"select a.jp_id as ProductID, a.memo, b.jp_name as ProductName, b.car, b.cavity, c.MACHINE_NAME as MachineName
                                        from JAKEOP_JISI a 
                                               inner join JEPUM b on (a.jp_id = b.jp_id)
                                               inner join SEOLBI c on (a.MACHINE_CODE = c.MACHINE_CODE)
                                        where  a.MACHINE_CODE = @MachineCode
                                                    and a.jisi_date >= @today
													and (a.jisi_gbn='시작' or a.jisi_gbn='등록')";

            cmd.Parameters.AddWithValue("@MachineCode", MachineCode);
            cmd.Parameters.AddWithValue("@today", today);
            try
            {
                cmd.CommandText = query;
                cmd.Connection = conn;

                adapter.SelectCommand = cmd;
                adapter.Fill(dataset);

                if ( dataset.Tables[0].Rows.Count == 1 )
                    return dataset.Tables[0];
                else
                    return null;
            }
            catch ( Exception ex ) { throw ex; }
        }

        public static commonReturn readWorkHistory(SqlConnection pCON, string start, string end, string product) //조회함수
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            str = @"select a.*, b.jp_name, b.jp_num, b.car, b.model, b.mtrl_num, b.now_stock, b.cavity as original_cavity, b.cycle_t as original_cycle, b.sj_id,
                                b.sj_id, b.jp_stdpaper, c.MACHINE_NAME, d.sw_name, e.bs_name, f.ec_name, g.sj_name

                       from JAKEOP_JISI a left outer join JEPUM b on (a.jp_id = b.jp_id)
                                                left outer join SEOLBI c on (a.MACHINE_CODE = c.MACHINE_CODE)
                                                left outer join SAWON d on (a.wr_sw_id = d.sw_id)
                                                left outer join BUSEO e on (a.wr_bs_id = e.bs_id)
                                                left outer join EOPCHE f on (a.mnf_id = f.ec_id)
                                                left outer join SUJI g on (b.sj_id = g.sj_id)

                       where a.jisi_date >= @start 
                                and a.jisi_date <= @end
                                and a.jp_id like '%' + @product + '%' 

                       order by a.jisi_date desc ";

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@start", start);
                pCMD.Parameters.AddWithValue("@end", end);
                pCMD.Parameters.AddWithValue("@product", product);
                return2 = DBsql.SQLExecuteDS(pCON, pCMD);
            }
            catch ( Exception exception )
            {
                return2.Message = exception.ToString();
            }
            return return2;
        }

        public static commonReturn findByID(SqlConnection pCON, string id) //조회함수
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            str = @"select a.*, b.jp_name, b.jp_num, b.car, b.model, b.mtrl_num, b.now_stock, b.cavity as original_cavity, b.cycle_t as original_cycle, 
                                b.sj_id, b.jp_stdpaper, c.MACHINE_NAME, d.sw_name, e.bs_name, f.ec_name, g.sj_name

                        from JAKEOP_JISI a left outer join JEPUM b on (a.jp_id = b.jp_id)
                                                   left outer join SEOLBI c on (a.MACHINE_CODE = c.MACHINE_CODE)
                                                   left outer join SAWON d on (a.wr_sw_id = d.sw_id)
                                                   left outer join BUSEO e on (a.wr_bs_id = e.bs_id)
                                                   left outer join EOPCHE f on (a.mnf_id = f.ec_id)
                                                   left outer join SUJI g on (b.sj_id = g.sj_id)

                        where a.jisi_id = @id";

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


        public static commonReturn write(SqlConnection pCON, bool is_add, SqlCommand pCMD)
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            if ( is_add == true ) //추가일때
            {
                str = @"insert into JAKEOP_JISI
                            (jisi_id, jisi_date, wr_bs_id, wr_sw_id, 
                            gj_gbn, jisi_gbn, 
                            mnf_id, MACHINE_CODE, line_id, gh_id,
                            qt_plan, plan_t,
                            jp_id, cavity, cycle_t,
                            is_work_started, memo, wr_id, auto_wr_date)

                            values
                            (@jisi_id, @jisi_date, @wr_bs_id, @wr_sw_id,
                            @gj_gbn, @jisi_gbn,
                            @mnf_id, @MACHINE_CODE, @line_id, @gh_id,
                            @qt_plan, @plan_t,
                            @jp_id, @cavity, @cycle_t,
                            @is_work_started, @memo, @wr_id, getdate())";

            }
            else //수정일때
            {
                str = @"update JAKEOP_JISI
                            set 
                            jisi_date =@jisi_date , wr_bs_id =@wr_bs_id , wr_sw_id =@wr_sw_id , 
                            gj_gbn =@gj_gbn , jisi_gbn =@jisi_gbn , 
                            mnf_id =@mnf_id , MACHINE_CODE =@MACHINE_CODE , line_id =@line_id , gh_id =@gh_id ,
                            qt_plan =@qt_plan , plan_t =@plan_t ,
                            jp_id =@jp_id, cavity =@cavity, cycle_t =@cycle_t ,
                            is_work_started =@is_work_started , 
                            memo =@memo , upd_id =@wr_id , auto_upd_date =getdate()

                            where jisi_id = @jisi_id";
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


        public static commonReturn deleteSingleOrder(SqlConnection pCON, string id)
        {
            commonReturn return2 = new commonReturn();
            string str = "";
            try
            {
                SqlCommand pCMD = new SqlCommand();
                str = "delete from JAKEOP_JISI where jisi_id = @id";
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
