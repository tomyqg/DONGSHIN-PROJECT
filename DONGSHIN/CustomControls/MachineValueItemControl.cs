using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace DONGSHIN
{
    public partial class MachineValueItemControl : UserControlBase
    {
        

        public MachineValueItemControl()
        {
            InitializeComponent();
        }


        public override string Text
        {
            get
            {
                return TextValue;
            }
            set
            {
                TextValue = value;
            }
        }

        public override Color BackColor
        {
            get
            {
                return tableLayoutPanel1.BackColor;
            }
            set
            {
                labelTitle.BackColor = value;
                labelUnit.BackColor = value;
                labelValue.BackColor =value;
                tableLayoutPanel1.BackColor = value;
            }
        }

        [Category("Text"), Description("값 지정")]
        public string TextValue
        {
            get
            {
                return labelValue.Text;
            }
            set 
            {
                this.labelValue.Text = value;
            }
        }

        [Category("Text"), Description("값 지정")]
        public int TextValueSize
        {
            get
            {
                return (int)labelValue.Font.Size;
            }
            set
            {
                Font font = this.labelValue.Font;
                font = new Font("나눔고딕", value);
                this.labelValue.Font = font;
            }
        }

        [Category("Text"), Description("타이틀 지정")]
        public string TextTitle
        {
            get
            {
                return labelTitle.Text;
            }
            set
            {
                this.labelTitle.Text = value;
            }
        }

        [Category("Text"), Description("타이틀 지정")]
        public int TextTitleSize
        {
            get
            {
                return (int)labelTitle.Font.Size;
            }
            set
            {
                Font font = this.labelTitle.Font;
                font = new Font("나눔고딕", value);
                this.labelTitle.Font = font;
            }
        }

        [Category("Text"), Description("단위 지정")]
        public string TextUnit
        {
            get
            {
                return labelUnit.Text;
            }
            set
            {
                this.labelUnit.Text = value;
            }
        }

        [Category("Text"), Description("단위 지정")]
        public int TextUnitSize
        {
            get
            {
                return (int)labelUnit.Font.Size;
            }
            set
            {
                Font font = this.labelUnit.Font;
                font = new Font("나눔고딕", value);
                this.labelUnit.Font = font;
            }
        }


     

        
       
    }
}
