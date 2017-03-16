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
    public partial class mcRight_1 : BaseControl
    {



        public mcRight_1()
        {
            InitializeComponent(); AddTextEditor();

        }


        protected override void AddTextEditor()
        {
            //기능및실제값

            TextEditors["S00202"] = pt1_1; //형체력
            TextEditors["S00200"] = pt1_3; //형개중 로봇위치
            TextEditors["S00201"] = pt1_4; //형개완료 모니터시간



            TextEditors["S00274"] = pt2_1; //이젝터횟수(좌)
            TextEditors["S00275"] = pt2_2; //이젝터횟수(우)
            TextEditors["S00276"] = pt2_3; //이젝터 전진유지(좌)
            TextEditors["S00277"] = pt2_4; //이젝터 전진유지(우)

            TextEditors["S00278"] = pt2_5; //발진이젝터/후진완료위치
            TextEditors["S00279"] = pt2_6; //형개중이젝터/시작위치

        }


    }//class
}//namespace
