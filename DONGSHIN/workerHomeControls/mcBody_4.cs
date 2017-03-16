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
    public partial class mcBody_4 : BaseControl
    {

        public mcBody_4()
        {
            InitializeComponent(); AddTextEditor();
        }



        protected override void AddTextEditor()
        {
            //유압코어
            //코어1                                 //컨트롤텍스트(xls파일 내 명칭)
            TextEditors["S00457"] = pt1_1; //IN 속도
            TextEditors["S00477"] = pt1_2; //IN 압력
            TextEditors["S00497"] = pt1_3; //IN 위치
            TextEditors["S00517"] = pt1_4; //IN 시간
            TextEditors["S00537"] = pt1_5; //IN 카운터
//            TextEditors[""] = pt1_6; //IN 사용유무/동작모드
//            TextEditors[""] = pt1_7; //IN 완료모드
//            TextEditors[""] = pt1_8; //IN 증압
                        
            TextEditors["S00467"] = pt1_9; //OUT 속도
            TextEditors["S00487"] = pt1_10; //OUT 압력
            TextEditors["S00507"] = pt1_11; //OUT 위치
            TextEditors["S00527"] = pt1_12; //OUT 시간
            TextEditors["S00547"] = pt1_13; //OUT 카운터
//            TextEditors[""] = pt1_14; //OUT 사용유무/동작모드
 //           TextEditors[""] = pt1_15; //OUT 완료모드
  //          TextEditors[""] = pt1_16; //OUT 증압


            
            //코어2                                
            TextEditors["S00458"] = pt1_17; //IN 속도
            TextEditors["S00478"] = pt1_18; //IN 압력
            TextEditors["S00498"] = pt1_19; //IN 위치
            TextEditors["S00518"] = pt1_20; //IN 시간
            TextEditors["S00538"] = pt1_21; //IN 카운터
  //          TextEditors[""] = pt1_22; //IN 사용유무/동작모드
  //          TextEditors[""] = pt1_23; //IN 완료모드
  //          TextEditors[""] = pt1_24; //IN 증압

            TextEditors["S00468"] = pt1_25; //OUT 속도
            TextEditors["S00488"] = pt1_26; //OUT 압력
            TextEditors["S00508"] = pt1_27; //OUT 위치
            TextEditors["S00528"] = pt1_28; //OUT 시간
            TextEditors["S00548"] = pt1_29; //OUT 카운터
//            TextEditors[""] = pt1_30; //OUT 사용유무/동작모드
//            TextEditors[""] = pt1_31; //OUT 완료모드
//            TextEditors[""] = pt1_32; //OUT 증압



            //코어3                               
            TextEditors["S00459"] = pt1_33; //IN 속도
            TextEditors["S00479"] = pt1_34; //IN 압력
            TextEditors["S00499"] = pt1_35; //IN 위치
            TextEditors["S00519"] = pt1_36; //IN 시간
            TextEditors["S00539"] = pt1_37; //IN 카운터
  //          TextEditors[""] = pt1_38; //IN 사용유무/동작모드
  //          TextEditors[""] = pt1_39; //IN 완료모드
  //          TextEditors[""] = pt1_40; //IN 증압

            TextEditors["S00469"] = pt1_41; //OUT 속도
            TextEditors["S00489"] = pt1_42; //OUT 압력
            TextEditors["S00509"] = pt1_43; //OUT 위치
            TextEditors["S00529"] = pt1_44; //OUT 시간
            TextEditors["S00549"] = pt1_45; //OUT 카운터
//            TextEditors[""] = pt1_46; //OUT 사용유무/동작모드
//            TextEditors[""] = pt1_47; //OUT 완료모드
//            TextEditors[""] = pt1_48; //OUT 증압



            //코어4       
            TextEditors["S00460"] = pt1_49; //IN 속도
            TextEditors["S00480"] = pt1_50; //IN 압력
            TextEditors["S00500"] = pt1_51; //IN 위치
            TextEditors["S00520"] = pt1_52; //IN 시간
            TextEditors["S00540"] = pt1_53; //IN 카운터
//            TextEditors[""] = pt1_54; //IN 사용유무/동작모드
//            TextEditors[""] = pt1_55; //IN 완료모드
//            TextEditors[""] = pt1_56; //IN 증압

            TextEditors["S00470"] = pt1_57; //OUT 속도
            TextEditors["S00490"] = pt1_58; //OUT 압력
            TextEditors["S00510"] = pt1_59; //OUT 위치
            TextEditors["S00530"] = pt1_60; //OUT 시간
            TextEditors["S00550"] = pt1_61; //OUT 카운터
//            TextEditors[""] = pt1_62; //OUT 사용유무/동작모드
//            TextEditors[""] = pt1_63; //OUT 완료모드
//            TextEditors[""] = pt1_64; //OUT 증압





            //회전코어/정회전
            TextEditors["S00557"] = pt2_1; //위치
            TextEditors["S00558"] = pt2_2; //카운터
            TextEditors["S00559"] = pt2_3; //동작지연
            TextEditors["S00560"] = pt2_4; //작동시간


            //회전코어/역회전
            TextEditors["S00561"] = pt2_5; //위치
            TextEditors["S00562"] = pt2_6; //카운터
            TextEditors["S00563"] = pt2_7; //동작지연
            TextEditors["S00564"] = pt2_8; //작동시간


        }

    }//class
}//namespace
