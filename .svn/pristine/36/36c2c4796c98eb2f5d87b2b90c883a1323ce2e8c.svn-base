using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Xml;
using System.IO;
using System.Diagnostics;
using System.Web.Services.Description;



namespace SmartQUpdate
{

    public partial class ClientAuthentication : Form
    {        
        
        public ClientAuthentication()
        {
            InitializeComponent();
        }


        private void ClientAuthentication_Load(object sender, EventArgs e)
        {
            //clientAuthInfo.xml이 존재하면 정보 확인 후 업데이트 
            string infoFilePath = Application.StartupPath + "/Authentication/clientAuthInfo.xml";
            FileInfo AuthFile = new FileInfo(infoFilePath);
            if ( AuthFile.Exists )
            {
              //getCompanyInfoFromXml(infoFilePath);
                gotoNextProcess();     
            }
        }



        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter )
            {
                buttonOK.PerformClick();
            }
        }             



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            try
            {
                DataTable CompanyTable = checkIfRegistered(txtCompanyRegNum.Text);
                if ( CompanyTable != null )
                {
                    //설치 가능하면 xml에 pc정보 저장(xml, DB)
                        companyInformation companyInfo = new companyInformation();
                        companyInfo.companyCode = Convert.ToString(CompanyTable.Rows[0]["COMPANY_CODE"]);
                        companyInfo.companyName = Convert.ToString(CompanyTable.Rows[0]["COMPANY_NAME"]);                        
                        companyInfo.MACaddress = getMACaddress();           

                        writeCompanyInfo(companyInfo);

                    //AccessDatabaseEngine 설치 후 업데이트 실행
                        Process.Start(Application.StartupPath + "\\" + "AccessDatabaseEngine.exe").WaitForExit();
                        gotoNextProcess();                        
                }
                else
                {
                    MessageBox.Show("해당 사업자번호가 존재하지 않습니다.");
                }
            }
            catch ( Exception ex ) { MessageBox.Show(ex.Message); }

        }




        private DataTable checkIfRegistered(string CompanyRegNum)
        {
            //사업자번호가 등록 되어있는지 
            try
            {
                ModbusTcp.WebReference.WebService1 w1 = new ModbusTcp.WebReference.WebService1();
                DataTable table = w1.getCompanyInfoWithRegiNumber(CompanyRegNum);

                if ( table.Rows.Count > 0 )
                    return table;
                else
                    return null;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }


        private string getMACaddress()
        {
            string MACAddr = string.Empty;
            
            try
            {
                //mac주소 형식 바꿔준 후에 companyinfo에 저장
                string originalAddr = NetworkInterface.GetAllNetworkInterfaces()[0].GetPhysicalAddress().ToString();
                StringBuilder SB = new StringBuilder();
                char[] chrArr = originalAddr.ToCharArray();
                for ( int i = 0 ; i < chrArr.Length ; i++ )
                {
                    int n = i + 1;
                    if ( SB.Length > 0 && n % 2 != 0 )
                        SB.Append("-");
                    SB.Append(chrArr[i].ToString());
                }

                MACAddr = SB.ToString();

                return MACAddr;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        private void writeCompanyInfo(companyInformation companyInfo)
        {
            try
            {
                string infoFilePath = Application.StartupPath + "/Authentication/clientAuthInfo.xml";

                XmlDocument newXmlDoc = new XmlDocument();
                newXmlDoc.AppendChild(newXmlDoc.CreateXmlDeclaration("1.0", "utf-8", "yes"));

                XmlNode root = newXmlDoc.CreateElement("", "ClientInformation", "");
                newXmlDoc.AppendChild(root);

                XmlNode clientCompany = newXmlDoc.CreateElement("ClientCompany");
                root.AppendChild(clientCompany);

                XmlNode companyName = newXmlDoc.CreateElement("CompanyName");
                companyName.InnerText = companyInfo.companyName;
                clientCompany.AppendChild(companyName);

                XmlElement companyCode = newXmlDoc.CreateElement("CompanyCode");
                companyCode.InnerText = companyInfo.companyCode;
                clientCompany.AppendChild(companyCode);

                XmlElement MACaddr = newXmlDoc.CreateElement("MACAddress");
                MACaddr.InnerText = companyInfo.MACaddress;
                clientCompany.AppendChild(MACaddr);

                FileInfo newXmlFile = new FileInfo(infoFilePath);
                DirectoryInfo xmlFolder = new DirectoryInfo(Application.StartupPath + "/Authentication");

                if ( !xmlFolder.Exists )
                    xmlFolder.Create();

                if ( newXmlFile.Exists )
                    newXmlFile.Delete();

                newXmlDoc.Save(infoFilePath);

            }
            catch ( Exception ex )
            {
                throw ex;
            }
        }


        //private void getCompanyInfoFromXml(string path)
        //{
        //    try
        //    {
        //        XmlDocument existXmlDoc = new XmlDocument();
        //        existXmlDoc.Load(path);
        //        string xpath_name = "/ClientInformation/ClientCompany/CompanyName";
        //        string xpath_code = "/ClientInformation/ClientCompany/CompanyCode";
        //        string xpath_mac = "/ClientInformation/ClientCompany/MACAddress";

        //        XmlNode nameNode = existXmlDoc.SelectSingleNode(xpath_name);
        //        companyInfo.companyName = nameNode.InnerText.Trim();

        //        XmlNode codeNode = existXmlDoc.SelectSingleNode(xpath_code);
        //        companyInfo.companyCode = codeNode.InnerText.Trim();

        //        XmlNode macNode = existXmlDoc.SelectSingleNode(xpath_mac);
        //        companyInfo.MACaddress = macNode.InnerText.Trim();
        //    }
        //    catch ( Exception ex )
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}


        private void gotoNextProcess()
        {
            AutoUpdate update = new AutoUpdate();
            Program.AppContext.MainForm = update;
            update.Show();

            this.Close();
        }
    }
}
