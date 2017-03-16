using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace DONGSHIN
{
    public partial class mcBody_1 : BaseControl
    {

 
        public mcBody_1()
        {
            InitializeComponent(); AddTextEditor();
           
        }


        protected override void AddTextEditor()
        {
            //형개폐파라미터
            //형폐                                   //컨트롤텍스트
            TextEditors["S00156"] = pt1_1; //고속 속도
            TextEditors["S00157"] = pt1_2; //감속 속도
            TextEditors["S00158"] = pt1_3; //금형보호1 속도
            TextEditors["S00159"] = pt1_4; //금형보호2 속도
            TextEditors["S00160"] = pt1_5; //고압1속도

            TextEditors["S00161"] = pt1_6; //고속 압력
            TextEditors["S00162"] = pt1_7; //감속 압력
            TextEditors["S00163"] = pt1_8; //금형보호1 압력
            TextEditors["S00164"] = pt1_9; //금형보호2 압력

            TextEditors["S00165"] = pt1_10; //고속 위치
            TextEditors["S00166"] = pt1_11; //감속 위치

            TextEditors["S00169"] = pt1_12; //금형보호 위치(좌)
            TextEditors["S00170"] = pt1_13; //금형보호 위치(우)
            TextEditors["S00175"] = pt1_14; //금형보호 시간(좌)
            TextEditors["S00176"] = pt1_15; //금형보호 시간(우)



            //형개
            TextEditors["S00188"] = pt2_1; //저속 속도 (형개저속1 속도)
            TextEditors["S00187"] = pt2_2; //감속 속도
            TextEditors["S00186"] = pt2_3; //고속 속도
            TextEditors["S00185"] = pt2_4; //저속 속도 (형개저속2 속도)

            TextEditors["S00193"] = pt2_5; //저속 압력 (형개저속1 압력)
            TextEditors["S00192"] = pt2_6; //감속 압력
            TextEditors["S00191"] = pt2_7; //고속 압력
            TextEditors["S00190"] = pt2_8; //저속 압력 (형개저속2 압력)

            TextEditors["S00198"] =  pt2_9; //저속 위치 (형개저속1 위치)
            TextEditors["S00197"] =  pt2_10; //감속 위치
            TextEditors["S00196"] =  pt2_11; //고속 위치
            TextEditors["S00195"] =  pt2_12; //저속 위치 (형개저속2 위치)


            //이젝터 파라미터            
            //후진
            TextEditors["S00240"] = pt3_1; //후진완료 속도 (이젝터후진2차속도)
            TextEditors["S00239"] = pt3_2; //후진1차 속도 (이젝터후진1차속도)

            TextEditors["S00251"] = pt3_3; //후진완료 압력 (이젝터후진2차압력)
            TextEditors["S00250"] = pt3_4; //후진1차 압력 (이젝터후진1차압력)

            TextEditors["S00268"] = pt3_5; //후진완료시간
            TextEditors["S00269"] = pt3_6;//후진1차 시간

            TextEditors["S00261"] = pt3_7; //후진완료 위치 (이젝터후진2차위치)
            TextEditors["S00260"] = pt3_8; //후진1차 위치 (이젝터후진1차위치)

            TextEditors["S00272"] = pt3_9; //후진완료 지연시간
            TextEditors["S00273"] = pt3_10; //후진1차 지연시간



            //전진
            TextEditors["S00236"] = pt4_1; //전진완료 속도
            TextEditors["S00237"] = pt4_2; //전진1차 속도

            TextEditors["S00246"] = pt4_3; //전진완료 압력
            TextEditors["S00247"] = pt4_4; //전진1차 압력

            TextEditors["S00266"] = pt4_5; //전진완료시간
            TextEditors["S00267"] = pt4_6;//전진1차 시간

            TextEditors["S00256"] = pt4_7; //전진완료 위치
            TextEditors["S00257"] = pt4_8; //전진1차 위치

            TextEditors["S00270"] = pt4_9; //전진완료 지연시간
            TextEditors["S00271"] = pt4_10; //전진1차 지연시간

            


            //에어브라스트 파라미터
            //이동
            TextEditors["S00305"] = pt5_1; //동작위치
 //           TextEditors[""] = pt5_2; //

            TextEditors["S00306"] = pt5_3; //지연시간
//            TextEditors[""] = pt5_4; //

            TextEditors["S00307"] = pt5_5; //작동시간(좌)
            TextEditors["S00311"] = pt5_6; //작동시간(우)

            //고정
            TextEditors["S00308"] = pt6_1; //동작위치
//            TextEditors[""] = pt6_2; //

            TextEditors["S00309"] = pt6_3; //지연시간
//            TextEditors[""] = pt6_4; //

            TextEditors["S00310"] = pt6_5; //작동시간(좌)
            TextEditors["S00312"] = pt6_6; //작동시간(우)
        }







    }//class
}//namespace
