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
    public partial class MachineStateItemControl : UserControl
    {

        public MachineStateItemControl()
        {
            InitializeComponent();
        }
        private bool[] borderPostions = new bool[4] { false, false, false, false };
        private Color borderColor = Color.Gray;
        [Category("Color"), Description("set border color")]
        public Color BorderColor
        {
            get
            {
                return this.borderColor;
            }
            set
            {
                this.borderColor = value;
            }
        }

        [Category("Text"), Description("set true if top border needs")]
        public bool BorderTop
        {
            get
            {
                return this.borderPostions[0];
            }
            set
            {

                this.borderPostions[0] = value;
            }
        }

        [Category("Text"), Description("set true if left border needs")]
        public bool BorderLeft
        {
            get
            {
                return this.borderPostions[1];
            }
            set
            {

                this.borderPostions[1] = value;
            }
        }

        [Category("Text"), Description("set true if right border needs")]
        public bool BorderRight
        {
            get
            {
                return this.borderPostions[2];
            }
            set
            {

                this.borderPostions[2] = value;
            }
        }

        [Category("Text"), Description("set true if bot border needs")]
        public bool BorderBottom
        {
            get
            {
                return this.borderPostions[3];
            }
            set
            {

                this.borderPostions[3] = value;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int width = this.DisplayRectangle.Width + Padding.Left + Padding.Right;
            int height = this.DisplayRectangle.Height + Padding.Left + Padding.Right;
            int x = this.DisplayRectangle.X - this.Padding.Left;
            int y = this.DisplayRectangle.Y - this.Padding.Top;

            Pen pen = new Pen(this.borderColor);

            if (this.borderPostions[0] == true)
            {
                e.Graphics.DrawLine(pen, new Point(x, y), new Point(x + width, y));
            }
            if (this.borderPostions[1] == true)
            {
                e.Graphics.DrawLine(pen, new Point(x, y), new Point(x, y + height));
            }
            if (this.borderPostions[2] == true)
            {
                e.Graphics.DrawLine(pen, new Point(x + width - 1, y), new Point(x + width - 1, y + height));
            }
            if (this.borderPostions[3] == true)
            {
                e.Graphics.DrawLine(pen, new Point(x, y + height - 1), new Point(x + width, y + height - 1));
            }

        }


        public delegate void StateItemDoubleClicked(string name);
        public StateItemDoubleClicked itemDoubleClick;

        

        public override Color BackColor
        {
            get
            {
                return tableLayoutPanel1.BackColor;
            }
            set
            {
                tableLayoutPanel1.BackColor = value;
            }
        }

        public override string Text
        {
            get
            {
                return labelTitle.Text;
            }
            set
            {
                labelTitle.Text = value;
            }
        }

        [Category("Text"), Description("값 지정")]
        public string TextTitle
        {
            get
            {
                return labelTitle.Text;
            }
            set
            {
                labelTitle.Text = value;
            }
        }

        [Category("Text"), Description("값 지정")]
        public int TextSize
        {
            get
            {
                return (int)labelTitle.Font.Size;
            }
            set
            {
                Font font = this.labelTitle.Font;
                font = new Font(font.FontFamily, value);
                this.labelTitle.Font = font;
            }
        }

        public override Image BackgroundImage
        {
            get
            {
                return panelMain.BackgroundImage;
            }
            set
            {
                panelMain.BackgroundImage = value;
            }
        }

        private void panelMain_DoubleClick(object sender, EventArgs e)
        {
            itemDoubleClick(this.Name);
        }

        
    }
}
