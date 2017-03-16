using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DONGSHIN
{
    public static class fx_DBPermission
    {
        public static commonReturn read_menu(SqlConnection pCON, string sw_id) 
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            //(case when y.child_id = 0 then '▶ ' + y.menu_name else '    ▷ ' + y.menu_name end) menu_name,
            str = @"select isnull(x.permission_id, -1) as pemission_id , isnull(x.sw_id, '-1x') as sw_id , y.parent_id, y.child_id,
                        y.menu_name,
                        cast(isnull(x.super, 0) as bit) super, 
                        cast(isnull(x.menu_access, 0) as bit) menu_access,
                        cast(isnull(x.menu_add, 0) as bit) menu_add,
                        cast(isnull(x.menu_upd, 0) as bit) menu_upd,
                        cast(isnull(x.menu_del, 0) as bit) menu_del,
                        cast(isnull(x.menu_search, 0) as bit) menu_search,
                        cast(isnull(x.menu_print, 0) as bit) menu_print,
                        cast(isnull(x.menu_convert, 0) as bit) menu_convert

                        from (select * from MENU_PERMISSION where sw_id = @sw_id) x
                        right outer join MENU_TYPE y on (x.parent_id = y.parent_id and x.child_id = y.child_id)

                        where y.use_chk = 'Y'
                        order by y.parent_id, y.child_id ";


            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@sw_id", sw_id);
                return2 = DBsql.SQLExecuteDS(pCON, pCMD);
            }
            catch ( Exception exception )
            {
                return2.Message = exception.ToString();
            }
            return return2;
        }

        public static commonReturn findByID(SqlConnection pCON, string sw_id) //기존 권한 내역이 존재하는지 여부를 알아내기위해
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            str = @"select * from MENU_PERMISSION where sw_id = @sw_id";

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };

                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@sw_id", sw_id);
                return2 = DBsql.SQLExecuteDS(pCON, pCMD);
            }
            catch ( Exception exception )
            {
                return2.Message = exception.ToString();
            }
            return return2;
        }

        public static commonReturn write(SqlConnection pCON, SqlCommand pCMD)
        {
            commonReturn return2 = new commonReturn();
            string str = "";

                str = @"insert into MENU_PERMISSION
                            (sw_id, menu_access, menu_add, menu_upd, menu_del,
                             menu_search, menu_print, menu_convert, parent_id, child_id)

                            values
                             (@sw_id, @menu_access, @menu_add, @menu_upd, @menu_del,
                             @menu_search, @menu_print, @menu_convert, @parent_id, @child_id)";

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


        public static commonReturn delete(SqlConnection pCON, string sw_id)
        {
            commonReturn return2 = new commonReturn();
            string str = "";
            try
            {
                SqlCommand pCMD = new SqlCommand();
                str = "delete from MENU_PERMISSION where sw_id = @id";
                pCMD.CommandText = str;
                pCMD.Connection = pCON;
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@id", sw_id);
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
