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
    public partial class rbBody_1 : BaseControl
    {
    

        public rbBody_1()
        {
            InitializeComponent(); AddTextEditor();
           
        }

        

       
        protected override void AddTextEditor() 
        {
            //형개폐 파라미터
            
            TextEditors["S00204"] = pt1_1; //형폐속도3
            TextEditors["S00205"] = pt1_2; //형폐속도2
            TextEditors["S00206"] = pt1_3; //형폐속도1
            TextEditors["S00207"] = pt1_4; //금형보호
            TextEditors["S00208"] = pt1_5; //형체고압

            TextEditors["S00214"] = pt1_6; //형개속도5
            TextEditors["S00215"] = pt1_7; //4
            TextEditors["S00216"] = pt1_8; //3
            TextEditors["S00217"] = pt1_9; //2
            TextEditors["S00218"] = pt1_10; //1

            TextEditors["S00209"] = pt1_11; //형폐위치
            TextEditors["S00210"] = pt1_12; 
            TextEditors["S00211"] = pt1_13; 
            TextEditors["S00212"] = pt1_14; 

            TextEditors["S00219"] = pt1_15; //형개위치5
            TextEditors["S00220"] = pt1_16; //4
            TextEditors["S00221"] = pt1_17; //3
            TextEditors["S00222"] = pt1_18; //2
            TextEditors["S00223"] = pt1_19;//1

            TextEditors["S00226"] = pt1_20; //금형보호 토크

            TextEditors["S00229"] = pt1_21; //크로스헤드 위치
            TextEditors["S00228"] = pt1_22;
            TextEditors["S00227"] = pt1_23; 

            //이젝터 파라미터
            TextEditors["S00286"] = pt2_1; //후진속도3
            TextEditors["S00287"] = pt2_2; //후진속도2
            TextEditors["S00288"] = pt2_3; //후진속도1

            TextEditors["S00262"] = pt2_4; //후진위치3
            TextEditors["S00261"] = pt2_5; //후진위치2
            TextEditors["S00260"] = pt2_6; //후진위치1

            
            TextEditors["S00293"] = pt2_7; //발진이젝터 속도
            TextEditors["S00296"] = pt2_8; //발진이젝터 위치
            

            TextEditors["S00290"] = pt3_1; //전진속도1
            TextEditors["S00291"] = pt3_2; //전진속도2
            TextEditors["S00292"] = pt3_3; //전진속도3

            TextEditors["S00256"] = pt3_4; //전진위치1
            TextEditors["S00257"] = pt3_5; //전진위치2
            TextEditors["S00258"] = pt3_6; //전진위치3

            
            TextEditors["S00294"] = pt3_7; //프리이젝터 속도1
            TextEditors["S00295"] = pt3_8; //프리이젝터 속도2

            TextEditors["S00297"] = pt3_9; //프리이젝터 위치1
            TextEditors["S00298"] = pt3_10; //프리이젝터 위치2
            

            //에어브라스트 파라미터
            TextEditors["S00313"] = pt4_1; //1 - 지연시간
            TextEditors["S00317"] = pt4_2; //1 - 동작시간
            TextEditors["S00321"] = pt4_3; //1 - 위치

            TextEditors["S00314"] = pt4_4; //2 - 지연시간
            TextEditors["S00318"] = pt4_5;//2 - 동작시간
            TextEditors["S00322"] = pt4_6;//2 - 위치

            
            TextEditors["S00315"] = pt4_7;//3 - 지연시간
            TextEditors["S00319"] = pt4_8;//3 - 동작시간
            TextEditors["S00323"] = pt4_9;//3 - 위치

            TextEditors["S00316"] = pt4_10;//4 - 지연시간
            TextEditors["S00320"] = pt4_11;//4 - 동작시간
            TextEditors["S00324"] = pt4_12;//4 - 위치
             
        }




    }
}
