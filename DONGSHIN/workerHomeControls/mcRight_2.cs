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
    public partial class mcRight_2 : BaseControl
    {

        public mcRight_2()
        {
            InitializeComponent(); 
            AddTextEditor();
           
        }
        protected override void AddTextEditor()
        {
            //기능 및 실제값
            TextEditors["S00004"] = pt1_2; //사출감시시간
            TextEditors["S00123"] = pt1_3; //사출지연시간
            TextEditors["S00122"] = pt1_4; //가스사출스타트위치
            TextEditors["S00006"] = pt1_5; //냉각시간
            
            TextEditors["S00125"] = pt2_1; //계량지연시간
            TextEditors["S00005"] = pt2_2; //계량감시시간
            TextEditors["A00034"] = pt2_3; //계량RPM

            TextEditors["S00010"] = pt2_4; //절환시간
            TextEditors["S00011"] = pt2_5; //절환압력
            TextEditors["S00012"] = pt2_6; //절환위치


        }



    }
}
