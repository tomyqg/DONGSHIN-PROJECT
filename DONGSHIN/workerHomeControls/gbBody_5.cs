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
    public partial class gbBody_5 : BaseControl
    {

        public gbBody_5()
        {
            InitializeComponent();
            AddTextEditor();
        }



        protected override void AddTextEditor()
        {
            //기능선택
            TextEditors["S00598"] = pt1_1; //9.

            //시간설정
            TextEditors["S00270"] = pt2_1; //1.
            TextEditors["S00272"] = pt2_3; //2.
            TextEditors["S00144"] = pt2_5; //3.
            TextEditors["S00138"] = pt2_7; //4.
            TextEditors["S00123"] = pt2_9; //5.
            TextEditors["S00125"] = pt2_11; //6.
            TextEditors["S00006"] = pt2_13; //7.
            TextEditors["S00607"] = pt2_15; //8.
            TextEditors["S00609"] = pt2_17; //9.

            TextEditors["S00301"] = pt2_2; //10.
            TextEditors["S00303"] = pt2_4; //11.
            TextEditors["S00146"] = pt2_6; //12.
            TextEditors["S00148"] = pt2_8; //13.
            TextEditors["S00611"] = pt2_10; //14.
            TextEditors["S00613"] = pt2_12; //15.
            TextEditors["S00615"] = pt2_14; //16.
            TextEditors["S00175"] = pt2_16; //17.           
            TextEditors["S00617"] = pt2_18; //18.

            //checkedit
            TextEditors["S00592"] = pt3_1; //1.
            TextEditors["S00281"] = pt3_2; //2.
            TextEditors["S00282"] = pt3_3; //3.
            TextEditors["S00283"] = pt3_4; //4.
            TextEditors["S00284"] = pt3_5; //5.
            TextEditors["S00593"] = pt3_6; //6.
            TextEditors["S00594"] = pt3_7; //7.
            TextEditors["S00595"] = pt3_8; //8.

            TextEditors["S00597"] = pt3_9; //9.
            TextEditors["S00600"] = pt3_10; //10.
            TextEditors["S00601"] = pt3_11; //11.
            TextEditors["S00602"] = pt3_12; //12.
            TextEditors["S00603"] = pt3_13; //13.
            TextEditors["S00604"] = pt3_14; //14.
            TextEditors["S00605"] = pt3_15; //15.
            TextEditors["S00606"] = pt3_16; //16.
            
        }



    }
}
