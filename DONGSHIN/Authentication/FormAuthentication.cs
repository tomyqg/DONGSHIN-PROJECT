using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace DONGSHIN
{
    public partial class FormAuthentication : Form
    {
        public bool Certified { get; set; }
        public FormAuthentication()
        {
            InitializeComponent();
            Certified = false;
        }

        private void txtCompanyRegNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonOK.PerformClick();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            try
            {
                DataTable CompanyTable = getCompanyInfo(txtCompanyRegNum.Text);
                if (CompanyTable != null)
                {
                    string companyCode = Convert.ToString(CompanyTable.Rows[0]["COMPANY_CODE"]);
                    string companyName = Convert.ToString(CompanyTable.Rows[0]["COMPANY_NAME"]);

                    Settings.SettingHelper.SaveSetting("CompanyName", companyName);
                    Settings.SettingHelper.SaveSetting("CompanyCode", companyCode);
                    Settings.SettingHelper.SaveSetting("Authentication", "true");

                    Certified = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("해당 사업자번호가 존재하지 않습니다.");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }




        private DataTable getCompanyInfo(string CompanyRegNum)
        {
            //사업자번호가 등록 되어있는지 
            try
            {
                ModbusTcp.WebReference.WebService1 w1 = new ModbusTcp.WebReference.WebService1();
                DataTable table = w1.getCompanyInfoWithRegiNumber(CompanyRegNum);

                if (table.Rows.Count > 0)
                    return table;
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

       

    }
}
