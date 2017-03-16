using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DONGSHIN
{
    public partial class mcBody_6 : BaseControl
    {

        public mcBody_6()
        {
            InitializeComponent(); 
            AddTextEditor();
        }



        protected override void AddTextEditor()
        {
            //보압
            TextEditors["S00038"] = pt1_1; //보압1 속도
            TextEditors["S00056"] = pt1_2; //보압3 압력
            TextEditors["S00055"] = pt1_3; //보압2 압력
            TextEditors["S00054"] = pt1_4; //보압1 압력
            TextEditors["S00076"] = pt1_5; //보압3 시간
            TextEditors["S00075"] = pt1_6; //보압2 시간
            TextEditors["S00074"] = pt1_7; //보압1 시간
 
            TextEditors["S00008"] = pt1_8; //최대 쿠션
            TextEditors["S00009"] = pt1_9; //최소 쿠션


            //사출
            TextEditors["S00027"] = pt2_1; //사출5 속도
            TextEditors["S00026"] = pt2_2;//사출4 속도
            TextEditors["S00025"] = pt2_3;//사출3 속도
            TextEditors["S00024"] = pt2_4;//사출2 속도
            TextEditors["S00023"] = pt2_5;//사출1 속도

            TextEditors["S00047"] = pt2_6; //사출5 압력
            TextEditors["S00046"] = pt2_7;  //사출4 압력
            TextEditors["S00045"] = pt2_8; //사출3 압력
            TextEditors["S00044"] = pt2_9; //사출2 압력
            TextEditors["S00043"] = pt2_10; //사출1 압력

            TextEditors["S00068"] = pt2_11; //사출5 위치
            TextEditors["S00067"] = pt2_12; //사출4 위치
            TextEditors["S00066"] = pt2_13; //사출3 위치
            TextEditors["S00065"] = pt2_14; //사출2 위치
            TextEditors["S00064"] = pt2_15; //사출1 위치



            //계량
            TextEditors["S00105"] = pt3_1; //석백1 속도
            TextEditors["S00085"] = pt3_2; //계량1 속도
            TextEditors["S00086"] = pt3_3; //계량2 속도
            TextEditors["S00087"] = pt3_4; //계량3 속도
            TextEditors["S00106"] = pt3_5; //석백2 속도

            TextEditors["S00109"] = pt3_6; //석백1 압력
            TextEditors["S00090"] = pt3_7;//계량1 압력
            TextEditors["S00091"] = pt3_8;//계량2 압력
            TextEditors["S00092"] = pt3_9;//계량3 압력
            TextEditors["S00110"] = pt3_10; //석백2 압력

            TextEditors["S00107"] = pt3_11;//석백1 위치
            TextEditors["S00100"] = pt3_12;//계량1 위치
            TextEditors["S00101"] = pt3_13;//계량2 위치
            TextEditors["S00102"] = pt3_14;//계량3 위치
            TextEditors["S00108"] = pt3_15;//석백2 위치

            TextEditors["S00095"] = pt3_16; //계량1 배압
            TextEditors["S00096"] = pt3_17; //계량2 배압
            TextEditors["S00097"] = pt3_18; //계량3 배압


            //형폐
            TextEditors["S00156"] = pt4_1; //고속 속도
            TextEditors["S00157"] = pt4_2; //감속 속도
            TextEditors["S00158"] = pt4_3; //금형보호1 속도
            TextEditors["S00159"] = pt4_4; //금형보호2 속도
            TextEditors["S00160"] = pt4_5; //고압1 속도

            TextEditors["S00161"] = pt4_6;//고속 압력
            TextEditors["S00162"] = pt4_7;//감속 압력
            TextEditors["S00163"] = pt4_8;//금형보호1 압력
            TextEditors["S00164"] = pt4_9;//금형보호2 압력

            TextEditors["S00165"] = pt4_10; //고속 위치
            TextEditors["S00166"] = pt4_11; //감속 위치

            TextEditors["S00169"] = pt4_12; //금형보호 위치(좌)
            TextEditors["S00170"] = pt4_13; //금형보호 위치(우)
            TextEditors["S00175"] = pt4_14; //금형보호 시간


            //형개
            TextEditors["S00188"] = pt5_1; //저속2 속도
            TextEditors["S00187"] = pt5_2; //감속 속도
            TextEditors["S00186"] = pt5_3; //고속 속도
            TextEditors["S00185"] = pt5_4; //저속1 속도

            TextEditors["S00193"] = pt5_5;//저속2 압력
            TextEditors["S00192"] = pt5_6;//감속 압력
            TextEditors["S00191"] = pt5_7;//고속 압력
            TextEditors["S00190"] = pt5_8;//저속1 압력

            TextEditors["S00198"] = pt5_9;//저속2 위치
            TextEditors["S00197"] = pt5_10;//감속 위치
            TextEditors["S00196"] = pt5_11;//고속 위치
            TextEditors["S00195"] = pt5_12;//저속1 위치


            /*
            //금형온도
            TextEditors[""] = pt6_1; //이동1
            TextEditors[""] = pt6_2;//2
            TextEditors[""] = pt6_3;//3
            TextEditors[""] = pt6_4;//4
            TextEditors[""] = pt6_5;//5

            TextEditors[""] = pt6_6;//고정1
            TextEditors[""] = pt6_7;//2
            TextEditors[""] = pt6_8;//3
            TextEditors[""] = pt6_9;//4
            TextEditors[""] = pt6_10;//5
            */

            //이젝터
            TextEditors["S00240"] = pt7_1;//후진완료 속도
            TextEditors["S00239"] = pt7_2; //후진1차 속도
            TextEditors["S00236"] = pt7_3;//전친1차 속도
            TextEditors["S00237"] = pt7_4;//전진완료 속도

            TextEditors["S00251"] = pt7_5;//후진완료 압력
            TextEditors["S00250"] = pt7_6;//후진1차 압력
            TextEditors["S00246"] = pt7_7;//전친1차 압력
            TextEditors["S00247"] = pt7_8;//전진완료 압력

            TextEditors["S00268"] = pt7_9; //후진완료 시간
            TextEditors["S00266"] = pt7_10; //전진1차 시간

            TextEditors["S00261"] = pt7_11; //후진완료 위치
            TextEditors["S00260"] = pt7_12; //후진1차 위치
            TextEditors["S00256"] = pt7_13; //전진1차 위치
            TextEditors["S00257"] = pt7_14; //전진완료 위치

            TextEditors["S00272"] = pt7_15; //후진완료 지연시간
            TextEditors["S00270"] = pt7_16; //전진1차 지연시간


            //실린더 온도
            TextEditors["S00112"] = pt8_1; //Nz
            TextEditors["S00113"] = pt8_2;//h1
            TextEditors["S00114"] = pt8_3;//h2
            TextEditors["S00115"] = pt8_4;//h3
            TextEditors["S00116"] = pt8_5;//h4
            TextEditors["S00117"] = pt8_6;//h5
            TextEditors["S00118"] = pt8_7;//h6
            TextEditors["S00119"] = pt8_8;//작동유
        }



    }
}
