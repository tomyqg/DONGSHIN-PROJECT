using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DONGSHIN
{
    public static class fx_login //로그인화면에서 쓰이는 함수
    {
        public static commonReturn read(SqlConnection pCON, string empid, string pw) //조회함수
        {
            commonReturn return2 = new commonReturn();
            string str = "";

            str = @"select * from sawon where sw_id = @사원번호 and pw = @비밀번호";

//            @" select	a.사원번호, a.사원이름, a.영어이름, a.비밀번호, a.직위직책, 
//					                            a.부서코드, a.사원등급, b.부서이름, a.시작주ID, a.시작부ID,  제품번호, a.사용여부 
//					                   from 사원코드 a join 부서코드 b on(a.부서코드 = b.부서코드) 
//					                   where a.사원번호 = @사용자ID 
//                                       and   a.비밀번호 = @비밀번호 ";

            try
            {
                SqlCommand pCMD = new SqlCommand
                {
                    CommandText = str,
                    Connection = pCON
                };
                pCMD.Parameters.Clear();
                pCMD.Parameters.AddWithValue("@사원번호", empid);
                pCMD.Parameters.AddWithValue("@비밀번호", pw);
                return2 = DBsql.SQLExecuteDS(pCON, pCMD);
            }
            catch ( Exception exception )
            {
                return2.Message = exception.ToString();
            }
            return return2;
        }

    }//클래스
}//네임스페이스
