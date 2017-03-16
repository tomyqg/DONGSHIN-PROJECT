using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DONGSHIN
{
    public static class fx_workPerf
    {

        public static commonReturn readWorkPerformance(SqlConnection pCON, string start, string end, string product) //조회함수
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            str = @"select a.*, b.*, c.MACHINE_NAME, d.sw_name, e.bs_name, f.gm_name, g.sj_name,
                                h.jp_name, h.jp_num, h.car, h.model, h.mtrl_num, h.cavity, h.cycle_t

                       from JAKEOP_SILJEOK a left outer join JAKEOP_JISI b on (a.jisi_id = b.jisi_id)
                                                left outer join SEOLBI c on (b.MACHINE_CODE = c.MACHINE_CODE)
                                                left outer join SAWON d on (a.sw_id = d.sw_id)
                                                left outer join BUSEO e on (a.bs_id = e.bs_id)
                                                left outer join GEUNMU f on (a.gm_id = f.gm_id)
                                                left outer join SUJI g on (h.sj_id = g.sj_id)
                                                left outer join JEPUM h on (b.jp_id = h.jp_id)

                       where a.work_date >= @start 
                                and a.work_date <= @end
                                and b.jp_id like '%' + @product + '%' ";

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

        public static commonReturn findByPerformanceID(SqlConnection pCON, string id) //작업실적 기준 조회
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            str = @"select a.*, b.*, c.MACHINE_NAME, d.sw_name, e.bs_name, f.gm_name, g.sj_name,
                                h.jp_name, h.jp_num, h.car, h.model, h.mtrl_num, h.cavity, h.cycle_t

                       from JAKEOP_SILJEOK a left outer join JAKEOP_JISI b on (a.jisi_id = b.jisi_id)
                                                left outer join SEOLBI c on (b.MACHINE_CODE = c.MACHINE_CODE)
                                                left outer join SAWON d on (a.sw_id = d.sw_id)
                                                left outer join BUSEO e on (a.bs_id = e.bs_id)
                                                left outer join GEUNMU f on (a.gm_id = f.gm_id)
                                                left outer join JEPUM h on (b.jp_id = h.jp_id)
                                                left outer join SUJI g on (h.sj_id = g.sj_id)

                       where a.siljeok_id= @siljeok_id ";

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@siljeok_id", id);
                return2 = DBsql.SQLExecuteDS(pCON, pCMD);
            }
            catch ( Exception exception )
            {
                return2.Message = exception.ToString();
            }
            return return2;
        }

        public static commonReturn findByWorkOrderID(SqlConnection pCON, string id) //작업지시 기준 조회
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            str = @"select a.*, b.*, c.MACHINE_NAME, d.sw_name, e.bs_name, f.gm_name, g.sj_name,
                                h.jp_name, h.jp_num, h.car, h.model, h.mtrl_num, h.cavity, h.cycle_t

                       from JAKEOP_SILJEOK a left outer join JAKEOP_JISI b on (a.jisi_id = b.jisi_id)
                                                left outer join SEOLBI c on (b.MACHINE_CODE = c.MACHINE_CODE)
                                                left outer join SAWON d on (a.sw_id = d.sw_id)
                                                left outer join BUSEO e on (a.bs_id = e.bs_id)
                                                left outer join GEUNMU f on (a.gm_id = f.gm_id)
                                                left outer join JEPUM h on (b.jp_id = h.jp_id)
                                                left outer join SUJI g on (h.sj_id = g.sj_id)

                       where a.jisi_id= @jisi_id ";
            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@jisi_id", id);
                return2 = DBsql.SQLExecuteDS(pCON, pCMD);
            }
            catch ( Exception exception )
            {
                return2.Message = exception.ToString();
            }
            return return2;
        }

        public static commonReturn ReadWorkOrder(SqlConnection pCON, string id) //작업지시 조회
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
                        where a.jisi_id = @jisi_id";
            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@jisi_id", id);
                return2 = DBsql.SQLExecuteDS(pCON, pCMD);
            }
            catch ( Exception exception )
            {
                return2.Message = exception.ToString();
            }
            return return2;
        }

        #region 불량내역

        public static commonReturn ReadErrorDetails(SqlConnection pCON,bool is_add, string id) 
        {
            commonReturn return2 = new commonReturn();
            string str = string.Empty;

            if ( is_add )
            {
                str = @"select a.*, 0 as qt_br 
                        from BULRYANG_WONIN a";
            }
            else
            {
                str = @"select a.*, b.qt_br 
                        from BULRYANG_WONIN a 
                                left outer join JAKEOP_SILJEOK_BR b on (a.br_id = b.br_id)
                        where siljeok_id like '%' + @siljeok_id + '%' ;";
            }

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@siljeok_id", id);
                return2 = DBsql.SQLExecuteDS(pCON, pCMD);
            }
            catch ( Exception exception )
            {
                return2.Message = exception.ToString();
            }
            return return2;
        }

        private static string getQuery_InsertErrorDetails(DataRow row) 
        {
            string ErrorCode = Convert.ToString(row["br_id"]);
            int ErrorQty = Convert.ToInt32(row["qt_br"]);
            string ID = Convert.ToString(row["siljeok_id"]);

            string query = @"insert into JAKEOP_SILJEOK_BR
                                    (br_id, qt_br, siljeok_id)
                                   values
                                    ('"+ErrorCode+"',"+ErrorQty+",'"+ID+"') ; \n";

            return query;
        }

        private static string getQuery_UpdateErrorDetails(DataRow row) 
        {
            string ErrorCode = Convert.ToString(row["br_id"]);
            int ErrorQty = Convert.ToInt32(row["qt_br"]);
            string ID = Convert.ToString(row["siljeok_id"]);

            string query = @"update JAKEOP_SILJEOK_BR
                                    set qt_br = "+ErrorQty+"  where br_id = '"+ErrorCode+"' and siljeok_id = '"+ID+"' ;";

            return query;
        }

        public static string SetErrorDetails(DataTable table, bool is_add, string id) 
        {
            string ErrorMessage = string.Empty;
            string Query = string.Empty;

            if ( is_add ) 
            {
                for ( int i = 0 ; i < table.Rows.Count ; i++ ) 
                   Query += getQuery_InsertErrorDetails(table.Rows[i]);
            }
            else
            {
                for ( int i = 0 ; i < table.Rows.Count ; i++ )
                    Query += getQuery_UpdateErrorDetails(table.Rows[i]);
            }

            if ( Query.Length != 0 )
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = Query;
                    cmd.Connection = commonVar.DBconn;
                    cmd.ExecuteNonQuery();
                }
                catch ( Exception ex )
                {
                    ErrorMessage = ex.Message;
                }
            }

            return ErrorMessage;
        }

        public static string DeleteErrorDetails(SqlConnection pCON, string id) 
        {
            string ErrorMessage = string.Empty;
            string str = string.Empty;

            try
            {
                SqlCommand pCMD = new SqlCommand();
                str = "delete from JAKEOP_SILJEOK_BR where siljeok_id = @id";
                pCMD.CommandText = str;
                pCMD.Connection = pCON;
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@id", id);
                pCMD.ExecuteNonQuery();
            }
            catch ( Exception exception )
            {
                ErrorMessage = exception.ToString();
            }
            return ErrorMessage;
        }


        #endregion


        #region 비가동내역
        public static commonReturn ReadBreakTimeDetails(SqlConnection pCON, bool is_add, string id)
        {
            commonReturn return2 = new commonReturn();
            string str = string.Empty;

            if ( is_add )
            {
                str = @"select a.*, '00:00' as start_time, '00:00' as end_time, '00:00' as bgd_time
                        from BIGADONG a;";
            }
            else
            {
                str = @"select a.*, b.start_time, b.end_time, b.bgd_time
                           from BIGADONG a 
                                 left outer join JAKEOP_SILJEOK_BGD b on (a.bgd_id = b.bgd_id)
                           where siljeok_id like '%' + @siljeok_id + '%' ";
            }

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@siljeok_id", id);
                return2 = DBsql.SQLExecuteDS(pCON, pCMD);
            }
            catch ( Exception exception )
            {
                return2.Message = exception.ToString();
            }
            return return2;
        }


        private static string getQuery_InsertBreakTimeDetails(DataRow row)
        {
            string BreakCode = Convert.ToString(row["bgd_id"]);
            string StartTime = Convert.ToString(row["start_time"]);
            string EndTime = Convert.ToString(row["end_time"]);
            string BreakTime = Convert.ToString(row["bgd_time"]);
            string Trimming = BreakTime.Substring(0, 5);
            string ID = Convert.ToString(row["siljeok_id"]);

            string query = @"insert into JAKEOP_SILJEOK_BGD
                                    (bgd_id, start_time, end_time, bgd_time, siljeok_id)
                                   values
                                    ('" + BreakCode + "','" + StartTime + "','" + EndTime + "','" + Trimming + "','" + ID + "') ; \n";
            return query;
        }

        private static string getQuery_UpdateBreakTimeDetails(DataRow row)
        {
            string BreakCode = Convert.ToString(row["bgd_id"]);
            string StartTime = Convert.ToString(row["start_time"]);
            string EndTime = Convert.ToString(row["end_time"]);
            string BreakTime = Convert.ToString(row["bgd_time"]);
            string Trimming = BreakTime.Substring(0, 5);
            string ID = Convert.ToString(row["siljeok_id"]);

            string query = @"update JAKEOP_SILJEOK_BGD
                                    set start_time = '" + StartTime + "', end_time = '" + EndTime + "', bgd_time = '" + Trimming + "' where bgd_id = '" + BreakCode + "' and siljeok_id = '" + ID + "' ;";

            return query;
        }

        public static string SetBreakTimeDetails(DataTable table, bool is_add, string id)
        {
            string ErrorMessage = string.Empty;
            string Query = string.Empty;

            if ( is_add )
            {
                for ( int i = 0 ; i < table.Rows.Count ; i++ )
                    Query += getQuery_InsertBreakTimeDetails(table.Rows[i]);
            }
            else
            {
                for ( int i = 0 ; i < table.Rows.Count ; i++ )
                    Query += getQuery_UpdateBreakTimeDetails(table.Rows[i]);
            }

            if ( Query.Length != 0 )
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = Query;
                    cmd.Connection = commonVar.DBconn;
                    cmd.ExecuteNonQuery();
                }
                catch ( Exception ex )
                {
                    ErrorMessage = ex.Message;
                }
            }

            return ErrorMessage;
        }


        public static string DeleteBreakTimeDetails(SqlConnection pCON, string id)
        {
            string ErrorMessage = string.Empty;
            string str = string.Empty;

            try
            {
                SqlCommand pCMD = new SqlCommand();
                str = "delete from JAKEOP_SILJEOK_BGD where siljeok_id = @id";
                pCMD.CommandText = str;
                pCMD.Connection = pCON;
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@id", id);
                pCMD.ExecuteNonQuery();
            }
            catch ( Exception exception )
            {
                ErrorMessage = exception.ToString();
            }
            return ErrorMessage;
        }

        #endregion

        public static string WritePerformanceByUser(SqlCommand CMD) 
        { 
            string ErrorMessage = string.Empty;

            string query = @"insert into JAKEOP_SILJEOK
                                    (jisi_id, work_date, 
                                    start_time, end_time, work_time, bgd_time,
                                    qt_total, qt_manuf, qt_error)

                                    values
                                    (@jisi_id, @work_date,
                                    @start_time, @end_time, @work_time, @bgd_time,
                                    @qt_total, @qt_manuf, @qt_error)";

            try
            {
                CMD.CommandText = query;
                CMD.Connection = commonVar.DBconn;
                CMD.ExecuteNonQuery();
            }
            catch ( Exception exception )
            {
                ErrorMessage = exception.Message;
            }
            return ErrorMessage;
        }
        
        public static commonReturn write(SqlConnection pCON, bool is_add, bool isCompleted, SqlCommand pCMD)
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            if ( is_add == true ) //추가일때
            {
                str = @"insert into JAKEOP_SILJEOK
                            (siljeok_id, jisi_id, work_date, bs_id, sw_id, gm_id,
                            lot_number, start_time, end_time, work_time, bgd_time,
                            qt_total, qt_manuf, qt_init, qt_error)

                            values
                            (@siljeok_id, @jisi_id, @work_date, @bs_id, @sw_id, @gm_id,
                            @lot_number, @start_time, @end_time, @work_time, @bgd_time,
                            @qt_total, @qt_manuf, @qt_init, @qt_error)";

            }
            else //수정일때
            {
                str = @"update JAKEOP_SILJEOK
                            set 
                            work_date=@work_date, bs_id=@bs_id, sw_id=@sw_id, gm_id=@gm_id,
                            lot_number=@lot_number, start_time=@start_time, end_time=@end_time, work_time=@work_time, bgd_time =@bgd_time,
                            qt_total=@qt_total, qt_manuf=@qt_manuf, qt_init=@qt_init, qt_error=@qt_error

                            where siljeok_id = @siljeok_id";
            }

            if ( isCompleted )
            {
                str += @"update JAKEOP_JISI 
                            set jisi_gbn = @jisi_gbn, is_work_started=@is_work_started
                            where jisi_id = @jisi_id;";
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


        public static commonReturn deletePerformance(SqlConnection pCON, string id)
        {
            commonReturn return2 = new commonReturn();
            string str = "";
            try
            {
                SqlCommand pCMD = new SqlCommand();
                str = "delete from JAKEOP_SILJEOK where siljeok_id = @id";
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




    }
}
