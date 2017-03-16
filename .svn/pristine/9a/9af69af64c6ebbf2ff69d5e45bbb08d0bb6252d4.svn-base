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
    public partial class customCheckControl : UserControl
    {
        public customCheckControl()
        {
            InitializeComponent();
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                if (value.Equals("1"))
                    checkEdit1.Checked = true;
                else
                    checkEdit1.Checked = false;
            }
        }

    }
}
