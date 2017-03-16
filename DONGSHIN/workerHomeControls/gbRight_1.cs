using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DevExpress.XtraEditors;

namespace DONGSHIN
{
    public partial class gbRight_1 : BaseControl
    {
        
        public gbRight_1()
        {
            InitializeComponent();
            AddTextEditor();
           
        }


        protected override void AddTextEditor()
        {
            TextEditors["S00230"] = pt1_1; //형폐토크
            TextEditors["S00231"] = pt1_2; //형개토크
            TextEditors["A00079"] = pt1_3; //크로스헤드 실제위치       
            TextEditors["A00030"] = pt1_4; //금형실제위치
            TextEditors["S00232"] = pt1_5; //금형보호 감시시간(좌)
            TextEditors["S00233"] = pt1_6; //금형보호 감시시간(우)
            TextEditors["S00202"] = pt1_7; //형체력
            


            TextEditors["S00274"] = pt2_1; //이젝터횟수(좌)
            TextEditors["S00275"] = pt2_2; //이젝터횟수(우)

            TextEditors["A00031"] = pt2_3; //이젝터위치            
            
            TextEditors["S00299"] = pt2_4;//이젝터 공정 지연시간(좌)
            TextEditors["S00300"] = pt2_5;//이젝터 공정 지연시간(우)

            TextEditors["S00301"] = pt2_6;//이젝터 전진 감시시간(좌)
            TextEditors["S00302"] = pt2_7;//이젝터 전진 감시시간(우)

            TextEditors["S00303"] = pt2_8; //이젝터 후진 감시시간(좌)
            TextEditors["S00304"] = pt2_9; //이젝터 후진 감시시간(우)

            TextEditors["S00270"] = pt2_10; //이젝터 전진 지연시간(좌)
            TextEditors["S00271"] = pt2_11; //이젝터 전진 지연시간(우)

            TextEditors["S00272"] = pt2_12; //이젝터 후진 지연시간(좌)
            TextEditors["S00273"] = pt2_13; //이젝터 후진 지연시간(우)


            //CheckEdit

            TextEditors["S00281"] = pt3_1;//이젝터사용
            TextEditors["S00282"] = pt3_2;//발진이젝터
            TextEditors["S00283"] = pt3_3;//프리 이젝터
            TextEditors["S00284"] = pt3_4;//이젝터 전진유지
        }

    }
}
