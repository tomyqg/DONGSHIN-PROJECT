using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DONGSHIN
{
    public partial class frm_imageContainer : Form
    {
        private string imgPath;

        public frm_imageContainer(int width, int height, string imgPath, string title)
        {
            InitializeComponent();
            this.Width = width;
            this.Height = height;
            this.imgPath = imgPath;
            this.Text = title;
        }

        private void frm_imageContainer_Load(object sender, EventArgs e)
        {
            pictureEdit1.LoadAsync(imgPath);
        }

    }
}
