using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DONGSHIN
{
    public static class fx_commonCode
    {
        public static commonReturn read_all(SqlConnection pCON) //조회함수
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            str = @"select * from GONGTONG order by gt_grp, gt_name";

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


        public static commonReturn findByName(SqlConnection pCON, string grpName)
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            str = @"select * from GONGTONG where gt_grp like '%' + @grpName + '%'  order by gt_grp";

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@grpName", grpName);
                return2 = DBsql.SQLExecuteDS(pCON, pCMD);
            }
            catch ( Exception exception )
            {
                return2.Message = exception.ToString();
            }
            return return2;
        }

        public static commonReturn findForRef(SqlConnection pCON, string grpName)
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            str = @"select * from GONGTONG where gt_grp like '%' + @grpName + '%' and use_chk ='Y' ";

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@grpName", grpName);
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

            str = @"select * from GONGTONG where gt_id = @gt_id ";

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };

                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@gt_id", id);
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
                //공통그룹, 공통이름, 사용여부
                str = @"select @gt_id = isnull(max(gt_id), 0) + 1 from GONGTONG 
				                if @gt_id = 0
					                set @gt_id = 1

                            insert into GONGTONG
                            (gt_id, gt_grp, gt_name, use_chk)

                            values
                            (@gt_id, @gt_grp, @gt_name, @use_chk)";
            }
            else //수정일때
            {
                str = @"update GONGTONG
                            set 
                            gt_grp=@gt_grp, gt_name=@gt_name, use_chk = @use_chk

                            where gt_id = @gt_id";
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
                str = "delete from GONGTONG where gt_id = @gt_id";
                pCMD.CommandText = str;
                pCMD.Connection = pCON;
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@gt_id", id);
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
