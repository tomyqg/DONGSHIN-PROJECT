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
    public partial class gbRight_3 : BaseControl
    {



        public gbRight_3()
        {
            InitializeComponent();
            AddTextEditor();
        }


        protected override void AddTextEditor()
        {
            
            TextEditors["S00444"] = pt1_1; //대기모드 온도
            TextEditors["S00445"] = pt1_2; //단락경보시간

            TextEditors["S00446"] = pt1_3; //자동대기모드(좌)
            TextEditors["S00447"] = pt1_4; //자동대기모드(우)
            TextEditors["S00412"] = pt1_5; //스크류 냉간기동(좌)
            TextEditors["S00413"] = pt1_6; //스크류 냉간기동(우)

            
            TextEditors["S00448"] = pt2_1; //온도제어
            TextEditors["S00449"] = pt2_2; //온도상한
            TextEditors["S00450"] = pt2_3; //경보제어
            


        }



    }
}
