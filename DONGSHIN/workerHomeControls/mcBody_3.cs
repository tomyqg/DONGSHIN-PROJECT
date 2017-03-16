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
    public partial class mcBody_3 : BaseControl
    {



        public mcBody_3()
        {
            InitializeComponent(); AddTextEditor();
        }



        protected override void AddTextEditor()
        {
            //온도
            TextEditors["A00045"] = pt1_1; //Nz
            TextEditors["A00046"] = pt1_2; //H1
            TextEditors["A00047"] = pt1_3; //H2
            TextEditors["A00048"] = pt1_4; //H3
            TextEditors["A00049"] = pt1_5; //H4
            TextEditors["A00050"] = pt1_6; //H5
            TextEditors["A00051"] = pt1_7; //H6
            TextEditors["A00052"] = pt1_8; //작동유





            //온도설정
            //설정
            TextEditors["S00112"] = pt2_1;
            TextEditors["S00113"] = pt2_2;
            TextEditors["S00114"] = pt2_3;
            TextEditors["S00115"] = pt2_4;
            TextEditors["S00116"] = pt2_5;
            TextEditors["S00117"] = pt2_6;
            TextEditors["S00118"] = pt2_7;
            TextEditors["S00119"] = pt2_8; 

            //보온
            TextEditors["S00367"] = pt2_9;
            TextEditors["S00368"] = pt2_10;
            TextEditors["S00369"] = pt2_11;
            TextEditors["S00370"] = pt2_12;
            TextEditors["S00371"] = pt2_13;
            TextEditors["S00372"] = pt2_14;
            TextEditors["S00373"] = pt2_15; 

            //상한
            TextEditors["S00335"] = pt2_16;
            TextEditors["S00336"] = pt2_17;
            TextEditors["S00337"] = pt2_18;
            TextEditors["S00338"] = pt2_19;
            TextEditors["S00339"] = pt2_20;
            TextEditors["S00340"] = pt2_21;
            TextEditors["S00341"] = pt2_22;
            TextEditors["S00342"] = pt2_23; 

            //하한
            TextEditors["S00351"] = pt2_24;
            TextEditors["S00352"] = pt2_25;
            TextEditors["S00353"] = pt2_26;
            TextEditors["S00354"] = pt2_27;
            TextEditors["S00355"] = pt2_28;
            TextEditors["S00356"] = pt2_29;
            TextEditors["S00357"] = pt2_30;
            TextEditors["S00358"] = pt2_31; 

            //단선
            TextEditors["S00381"] = pt2_32;
            TextEditors["S00382"] = pt2_33;
            TextEditors["S00383"] = pt2_34;
            TextEditors["S00384"] = pt2_35;
            TextEditors["S00385"] = pt2_36;
            TextEditors["S00386"] = pt2_37;
            TextEditors["S00387"] = pt2_38; 

            //PWM
            TextEditors["S00395"] = pt2_39;
            TextEditors["S00396"] = pt2_40;
            TextEditors["S00397"] = pt2_41;
            TextEditors["S00398"] = pt2_42;
            TextEditors["S00399"] = pt2_43;
            TextEditors["S00400"] = pt2_44;
            TextEditors["S00401"] = pt2_45; 


        }





    }//class
}//namespace
