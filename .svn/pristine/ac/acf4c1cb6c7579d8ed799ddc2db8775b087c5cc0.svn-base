using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace DONGSHIN
{
    public static class fx_machineCode
    {
        

        public static commonReturn read_all(SqlConnection pCON, string chk) //조회함수
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            if ( chk == "Y" )
            {
                str = @"select * from SEOLBI where use_chk = 'Y' order by MACHINE_NUMBER";
            }
            else 
            {
                str = @"select * from SEOLBI order by MACHINE_NUMBER";
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

        public static commonReturn findByName(SqlConnection pCON, string name, string chk)
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            if ( chk == "Y" )
                str = @"select *
                            from SEOLBI 
                            where MACHINE_NAME like '%' + @name + '%' 
                            and use_chk = @chk order by MACHINE_NUMBER";
            else
                str = @"select *
                            from SEOLBI 
                            where MACHINE_NAME like '%' + @name + '%' order by MACHINE_NUMBER";

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


        public static commonReturn findByID(SqlConnection pCON, string MACHINE_CODE)
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            str = @"select *
                        from SEOLBI 
                        where MACHINE_CODE = @MACHINE_CODE ";

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };

                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@MACHINE_CODE", MACHINE_CODE);
                return2 = DBsql.SQLExecuteDS(pCON, pCMD);
            }
            catch ( Exception exception )
            {
                return2.Message = exception.ToString();
            }
            return return2;
        }



        public static commonReturn findByRequirements(SqlConnection pCON, string MACHINE_CODE, string MACHINE_NAME, int MACHINE_NUMBER, string MACHINE_IP)
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            str = @"select *
                        from SEOLBI 
                        where MACHINE_CODE = @MACHINE_CODE
                                or MACHINE_NAME = @MACHINE_NAME
                                or MACHINE_NUMBER = @MACHINE_NUMBER
                                or MACHINE_IP = @MACHINE_IP ";

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };

                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@MACHINE_CODE", MACHINE_CODE);
                pCMD.Parameters.AddWithValue("@MACHINE_NAME", MACHINE_NAME);
                pCMD.Parameters.AddWithValue("@MACHINE_NUMBER", MACHINE_NUMBER);
                pCMD.Parameters.AddWithValue("@MACHINE_IP", MACHINE_IP);
                return2 = DBsql.SQLExecuteDS(pCON, pCMD);
            }
            catch ( Exception exception )
            {
                return2.Message = exception.ToString();
            }
            return return2;
        }

        public static commonReturn write(SqlConnection pCON, bool is_add, SqlCommand pCMD) //SEOLBI 테이블
        {            
            commonReturn return2 = new commonReturn();
            string str = "";
            if ( is_add == true ) //추가일때
            {
                //설비코드 설비이름 설비구분 ip 포트 메모리맵 설비번호 표준가동 표준임률 관리부서 관리자 점검주기 제조국가 메이커명 모델명 제조년월 제조번호 구입날짜 부대비용 규격 컨트롤러 이미지경로 메모 사용여부 

                str = @"BEGIN TRY
                                    BEGIN TRAN

                                    insert into SEOLBI
                                    (MACHINE_CODE, MACHINE_NAME, MACHINE_TYPE, MACHINE_IP, MACHINE_NUMBER, MapType, std_op_hr,
                                    admin_bs, admin_main, chk_term, 
                                    nation, maker, model, mnf_date, mnf_num,
                                    buy_date, buy_price, xtra_cost, size, ctlr,
                                    sb_img, memo, use_chk )

                                    values
                                    (@MACHINE_CODE, @MACHINE_NAME, @MACHINE_TYPE, @MACHINE_IP, @MACHINE_NUMBER, @MapType, @std_op_hr,
                                    @admin_bs, @admin_main, @chk_term, 
                                    @nation, @maker, @model, @mnf_date, @mnf_num,
                                    @buy_date, @buy_price, @xtra_cost, @size, @ctlr,
                                    @sb_img, @memo, @use_chk);

                                    
                                    COMMIT TRAN
                            END TRY

                            BEGIN CATCH
                                    ROLLBACK TRAN
                                    PRINT ERROR_MESSAGE();
                            END CATCH ";
            }
            else //수정일때
            {
                str = @"BEGIN TRY
                                    BEGIN TRAN

                                    update SEOLBI
                                    set 
                                    MACHINE_NAME=@MACHINE_NAME, MACHINE_TYPE=@MACHINE_TYPE, MACHINE_IP=@MACHINE_IP, 
                                    MACHINE_NUMBER=@MACHINE_NUMBER, MapType = @MapType, std_op_hr=@std_op_hr, 
                                    admin_bs=@admin_bs, admin_main=@admin_main, chk_term=@chk_term, 
                                    nation=@nation, maker=@maker, model=@model, mnf_date=@mnf_date, mnf_num=@mnf_num,
                                    buy_date=@buy_date, buy_price=@buy_price, xtra_cost=@xtra_cost, size=@size, ctlr=@ctlr,
                                    sb_img=@sb_img, memo=@memo, use_chk=@use_chk

                                    where MACHINE_CODE = @MACHINE_CODE;

                                    
                                    COMMIT TRAN
                            END TRY

                            BEGIN CATCH
                                    ROLLBACK TRAN
                                    PRINT ERROR_MESSAGE();
                            END CATCH ";
            }

            try
            {
                string ErrorMessage = string.Empty;

                pCON.InfoMessage += delegate(object sender, SqlInfoMessageEventArgs e)
                {
                    ErrorMessage = e.Message;
                };
                pCMD.CommandText = str;
                pCMD.Connection = pCON;
                return2 = DBsql.SQLExecuteNonQuery(pCON, pCMD);

                if ( ErrorMessage.Length > 0 )
                    return2.Message = ErrorMessage;
                
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
                str = @"BEGIN TRY
                                    BEGIN TRAN
                                    update SEOLBI set Maptype=null where MACHINE_CODE=@MACHINE_CODE
                                    delete from SEOLBI where MACHINE_CODE = @MACHINE_CODE

                                    update SEOLBI set MapType=null where MACHINE_CODE = @MACHINE_CODE
                                    delete from SEOLBI where MACHINE_CODE = @MACHINE_CODE
                                    COMMIT TRAN
                            END TRY

                            BEGIN CATCH
                                    ROLLBACK TRAN
                            END CATCH ";
                pCMD.CommandText = str;
                pCMD.Connection = pCON;
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@MACHINE_CODE", id);
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
