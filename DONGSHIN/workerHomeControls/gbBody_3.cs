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
    public partial class gbBody_3 : BaseControl
    {
        public gbBody_3()
        {
            InitializeComponent();
            AddTextEditor();
        }



        protected override void AddTextEditor()
        {
            //온도
            TextEditors["A00045"] = pt1_1; //실제온도 Nz
            TextEditors["A00046"] = pt1_2; //실제온도1
            TextEditors["A00047"] = pt1_3;  //실제온도2
            TextEditors["A00048"] = pt1_4;  //실제온도3
            TextEditors["A00049"] = pt1_5;  //실제온도4
            TextEditors["A00050"] = pt1_6;  //실제온도5

            TextEditors["S00112"] = pt1_7;  //설정온도 Nz
            TextEditors["S00113"] = pt1_8; //설정온도1
            TextEditors["S00114"] = pt1_9; //설정온도2
            TextEditors["S00115"] = pt1_10; //설정온도3
            TextEditors["S00116"] = pt1_11; //설정온도4
            TextEditors["S00117"] = pt1_12; //설정온도5

            
            //온도설정
            TextEditors["S00395"] = pt2_1; //PWM Nz
            TextEditors["S00396"] = pt2_2; //PWM1
            TextEditors["S00397"] = pt2_3; //PWM2
            TextEditors["S00398"] = pt2_4;  //PWM3
            TextEditors["S00399"] = pt2_5; //PWM4
            TextEditors["S00400"] = pt2_6; //PWM5

            TextEditors["S00335"] = pt2_7; //상한 Nz
            TextEditors["S00336"] = pt2_8; //상한1
            TextEditors["S00337"] = pt2_9; //상한2
            TextEditors["S00338"] = pt2_10; //상한3
            TextEditors["S00339"] = pt2_11; //상한4
            TextEditors["S00340"] = pt2_12; //상한5

            TextEditors["S00351"] = pt2_13; //하한 Nz
            TextEditors["S00352"] = pt2_14; //하한1
            TextEditors["S00353"] = pt2_15; //하한2
            TextEditors["S00354"] = pt2_16; //하한3
            TextEditors["S00355"] = pt2_17; //하한4
            TextEditors["S00356"] = pt2_18; //하한5

        }


        
    }
}
