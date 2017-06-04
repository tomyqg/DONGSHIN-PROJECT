using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DONGSHIN
{
    public partial class FormAuthentication_StandAlone : Form
    {
        public bool Certified { get; set; }
        private TextBox[] boxes;
        public FormAuthentication_StandAlone()
        {
            InitializeComponent();
            Certified = false;
            boxes = new TextBox[]{
                textBox1, textBox2, textBox3, textBox4, textBox5, textBox6
            };
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            foreach (TextBox editor in boxes)
                if (!(editor.Text.Length > 0))
                {
                    MessageBox.Show("입력창 확인");
                    return;
                }

            if (textBox6.Text.Equals("dongshin"))
            {
                //sql connection test
                string dbConString = getConnectionString(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                using (SqlConnection con = new SqlConnection(dbConString))
                {
                    con.Open(); 
                    try
                    {
                        Cursor = Cursors.WaitCursor;
                        //if 주소가 맞다면
                        //save settings
                        Settings.SettingHelper.SaveSetting("CompanyName", textBox1.Text);
                        Settings.SettingHelper.SaveSetting("SqlAddress", textBox2.Text);
                        Settings.SettingHelper.SaveSetting("DbName", textBox3.Text);
                        Settings.SettingHelper.SaveSetting("DbId", textBox4.Text);
                        Settings.SettingHelper.SaveSetting("DbPw", textBox5.Text);
                        Settings.SettingHelper.SaveSetting("Authentication", "true");
                        Certified = true;
                        this.Close();
                    }
                    catch{ MessageBox.Show("DB에 접속할 수 없습니다"); }
                    finally{ Cursor = Cursors.Arrow; }
                }
            }
            else
            {
                MessageBox.Show("인증번호 확인");
            }
        }

        string getConnectionString(string serverName, string dbName, string userId, string userPw)
        {
            return "Data Source=" + serverName + "; Initial Catalog=" + dbName + "; User Id=" + userId + "; Password=" + userPw + ";";
        }
    }
}
