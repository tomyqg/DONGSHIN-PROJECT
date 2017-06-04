using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;

namespace DONGSHIN
{
    public partial class ctl_Settings : UserControl
    {
        public string LocalFilePath { get; set; }
        public ctl_Settings()
        {
            InitializeComponent();

            this.LocalFilePath = commonVar.LocalFilePath;
            buttonSaveLocation.ButtonClick+=buttonSaveLocation_ButtonClick;
            buttonSaveLocation.DataBindings.Add(new Binding("Text", this, "LocalFilePath")
            {
                DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged,
                ControlUpdateMode = ControlUpdateMode.OnPropertyChanged
            });  
        }

        private void buttonSaveLocation_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            FolderBrowserDialog  file = new FolderBrowserDialog ();
            file.SelectedPath = buttonSaveLocation.Text;
            file.ShowDialog();
            string path;
            if ((path = file.SelectedPath).Length > 0)
                buttonSaveLocation.Text = file.SelectedPath;
            
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            DialogResult question;
            question = MessageBox.Show("적용하시겠습니까?", "주의", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (question == DialogResult.Yes)
            {
                commonVar.LocalFilePath = this.LocalFilePath;
                Settings.SettingHelper.SaveSetting("LocalFilePath", LocalFilePath);
            }
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
