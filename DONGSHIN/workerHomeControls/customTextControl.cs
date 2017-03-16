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
    public partial class customTextControl : UserControl
    {
        public customTextControl()
        {
            InitializeComponent();
        }

        public override string Text
        {
            get
            {
                return labelControl1.Text;
            }
            set
            {
                labelControl1.Text = value;               
            }
        }
        
     
    }
}
