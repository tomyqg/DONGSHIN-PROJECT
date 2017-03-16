﻿using DevExpress.XtraSplashScreen;
using ModbusTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace DONGSHIN
{
    public partial class frm_login : Form
    {

       
        public frm_login()
        {
            InitializeComponent();
        }

        private bool managerOn = false;
        private bool userOn = false;
        private DataSet ds_login = new DataSet();

        private void frm_login_Load(object sender, EventArgs e)
        {
            //A-1611 PDMTECH
            //B-1000 동신
            //authenticationInfoXml.writeClientInfo("B-1000");

            string companyCode = authenticationInfoXml.getCompanyCode();
            //string companyCode = "T-1000";
            Console.WriteLine("load : "+companyCode);
            initializeSetting(companyCode);

            userInfoLoad();
            
        }



        private void initializeSetting(string companyCode)
        {
            try
            {
                //로그 생성 경로 지정
                LogWriter.FileBasePath = Application.StartupPath;

                commonVar.CompanyCode = companyCode;

                DataTable companyTable = MethodMain.LoadCompanyInfo(companyCode);
                if (companyTable.Rows.Count > 0)
                {
                    commonVar.ServerPublicIpAddress = companyTable.Rows[0]["PUBLIC_IP"].ToString();
                    commonVar.ServerPublicPort = (int)companyTable.Rows[0]["PUBLIC_PORT"];
                    commonVar.ServerPrivateIpAddress = companyTable.Rows[0]["PRIVATE_IP"].ToString();
                    commonVar.ServerPrivatePort = (int)companyTable.Rows[0]["PRIVATE_PORT"];

                    string serverPrivateIp = companyTable.Rows[0]["PRIVATE_IP"].ToString();
                    string thisPrivateIp = string.Empty;

                    IPAddress[] addresses = Dns.GetHostAddresses(Dns.GetHostName());
                    foreach (IPAddress addr in addresses)
                    {
                        if (addr.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            thisPrivateIp = addr.ToString();
                    }

                    if (serverPrivateIp == thisPrivateIp)
                        commonVar.IsThisServer = true;
                    else
                        commonVar.IsThisServer = false;


                    string serverName = companyTable.Rows[0]["SQL_SERVERNAME"].ToString();
                    string dbName = companyTable.Rows[0]["SQL_DBNAME"].ToString();
                    string id = companyTable.Rows[0]["SQL_ID"].ToString();
                    string pw = companyTable.Rows[0]["SQL_PW"].ToString();

                    commonVar.setDbConString(serverName, dbName, id, pw);
                }
                else
                    throw new Exception("서버 정보 읽기가 실패하였습니다");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }

        }


        private void login_user_Click(object sender, EventArgs e)
        {
            userOn = true;
            flyoutPanel1.ShowPopup();
        }

        private void login_manager_Click(object sender, EventArgs e)
        {
            managerOn = true;
            flyoutPanel1.ShowPopup();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                //--------------------------------------------로그인 정보 체크
                if (txt_empid.Text == "")
                {
                    MessageBox.Show("사원번호를 입력하세요.", "주의");
                    txt_empid.Focus();
                    return;
                }

                if (txt_pw.Text == "")
                {
                    MessageBox.Show("비밀번호를 입력하세요.", "주의");
                    txt_pw.Focus();
                    return;
                }
                
                //------------------------------------------유효성 검사 후 로그인 성공시 화면 전환
                if ( user_chk() )
                {
                    userInfoSave();

                    if (commonVar.user_gbn == "U" || (userOn == true && commonVar.user_gbn == "M"))
                    {  
                        frm_worker_main worker = new frm_worker_main();
                        Program.ac.MainForm = worker;
                        worker.Show();
                    }
                    else
                    {
                        frm_manager_home manager = new frm_manager_home();
                        Program.ac.MainForm = manager;
                        manager.Show();
                    }

                    this.Close();
                    flyoutPanel1.HidePopup();
                    
                }



            }//try문
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            userOn = false;
            managerOn = false;
            txt_empid.Text = "";
            txt_pw.Text = "";
            flyoutPanel1.HidePopup();
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        #region 함수 및 이벤트
        private bool user_chk()
        {
            try
            {

                if (commonVar.DBconn.State == ConnectionState.Closed)
                    commonVar.DBconn.ConnectionString = commonVar.dbConnectionString;

                commonReturn Return = new commonReturn();

                Return = fx_login.read(commonVar.DBconn, txt_empid.Text, encodeDecode.EncryptString(txt_pw.Text));
                ds_login.Clear();
                if (Return.Message == "")
                    ds_login = Return.Dataset;
                else
                    MessageBox.Show(Return.Message, "DB 에러!");


                if (ds_login.Tables.Count >= 1)//테이블이 존재하면
                {
                    if (ds_login.Tables[0].Rows.Count == 1)
                    {
                        if (Convert.ToString(ds_login.Tables[0].Rows[0]["use_chk"]).ToUpper() == "Y")
                        {
                            commonVar.login_id = Convert.ToString(ds_login.Tables[0].Rows[0]["sw_id"]);
                            commonVar.login_name = Convert.ToString(ds_login.Tables[0].Rows[0]["sw_name"]);
                            commonVar.user_gbn = Convert.ToString(ds_login.Tables[0].Rows[0]["user_gbn"]).ToUpper();

                            if ((managerOn == true && commonVar.user_gbn == "M") || (userOn == true && commonVar.user_gbn == "U") || (userOn == true && commonVar.user_gbn == "M")) //사용자구분과 접속모드가 일치 했을때
                            {
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("해당 모드 접속에 대한 권한이 없습니다.", "로그인오류");
                                return false;
                            }
                        }
                        else //사용구분이 Y가 아닐때
                        {
                            MessageBox.Show("사용 권한이 없습니다.", "로그인오류");
                            return false;
                        }
                        
                    }//결과값이 나오지 않거나 여러개가 나왔을때
                    else
                    {
                        MessageBox.Show("사원번호가 존재하지 않거나 비밀번호가 맞지 않습니다.", "로그인오류");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("사원번호가 존재하지 않거나 비밀번호가 맞지 않습니다.", "로그인오류");
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n\r\n잠시 후에 다시 하세요.", "네트워크 연결 에러!");
                commonVar.login_id = "";
                commonVar.login_name = "";                
                this.Close();

                return false;
            }
        }

        private void userInfoSave() 
        {
            string xmlFilePath = Application.StartupPath + @"\Check.xml";
            FileInfo xmlFileInfo = new FileInfo(xmlFilePath);

            try
            {
                if ( chk_idSave.Checked )
                {
                    if ( xmlFileInfo.Exists )
                    {
                        XmlDocument existXmlDoc = new XmlDocument();

                        existXmlDoc.Load(xmlFilePath);

                        string xpath = "/Setting/UserInfo/ID";  //xpath에 조건을 걸어서 검색
                        XmlNode idNode = existXmlDoc.SelectSingleNode(xpath);
                        idNode.InnerText = txt_empid.Text.Trim();

                        xpath = "/Setting/UserInfo/Language";
                        XmlNode langNode = existXmlDoc.SelectSingleNode(xpath);
                        langNode.InnerText = cbx_lang.Text.Trim();

                        existXmlDoc.Save(xmlFilePath);
                    }
                    else
                    {
                        XmlDocument newXmlDoc = new XmlDocument();
                        newXmlDoc.AppendChild(newXmlDoc.CreateXmlDeclaration("1.0", "utf-8", "yes"));

                        XmlNode root = newXmlDoc.CreateElement("Setting");
                        newXmlDoc.AppendChild(root);

                        XmlNode userInfo = newXmlDoc.CreateElement("UserInfo");
                        root.AppendChild(userInfo);

                        XmlNode userID = newXmlDoc.CreateElement("ID");
                        userID.InnerText = txt_empid.Text.Trim();
                        userInfo.AppendChild(userID);

                        XmlNode language = newXmlDoc.CreateElement("Language");
                        language.InnerText = cbx_lang.Text.Trim();
                        userInfo.AppendChild(language);

                        newXmlDoc.Save(xmlFilePath);
                    }

                }
                else
                {
                    if ( xmlFileInfo.Exists )
                        xmlFileInfo.Delete();
                }

                if ( !(commonVar.whichLang.Equals(cbx_lang.Text)) ) 
                    commonVar.whichLang = cbx_lang.Text;

            }
            catch { }
        }

        private void userInfoLoad() 
        {
            string xmlFilePath = Application.StartupPath + @"\Check.xml";
            FileInfo xmlFileInfo = new FileInfo(xmlFilePath);

            try
            {
                if ( xmlFileInfo.Exists )
                {
                    chk_idSave.Checked = true;

                    XmlDocument settingDoc = new XmlDocument();
                    settingDoc.Load(xmlFilePath);

                    string xpath = "/Setting/UserInfo/ID";
                    XmlNode idNode = settingDoc.SelectSingleNode(xpath);
                    txt_empid.Text = idNode.InnerText;

                    xpath =  "/Setting/UserInfo/Language";
                    XmlNode langNode = settingDoc.SelectSingleNode(xpath);
                    cbx_lang.Text = langNode.InnerText;
                    commonVar.whichLang = cbx_lang.Text.Trim();
                }
                else
                    return;
            }
            catch { }

        }

        private void flyoutPanel1_Hiding(object sender, DevExpress.Utils.FlyoutPanelEventArgs e)
        {
            bgimg.Visible = false;
        }

        private void flyoutPanel1_Showing(object sender, DevExpress.Utils.FlyoutPanelEventArgs e) //로그인화면 나타날때
        {
            Image img = Properties.Resources.black_opacity;
            bgimg.Appearance.Image = commonFX.change_opacity(img, 0.5f);
            bgimg.Dock = DockStyle.Fill;
            bgimg.Visible = true;

            if ( cbx_lang.Text.Equals("English") )
                commonFX.setThisLanguage(this);
            else 
            {
                lbl_empid.Text = "사원번호";
                lbl_pw.Text = "비밀번호";
                btn_ok.Text = "확인";
                btn_close.Text = "닫기";
                chk_idSave.Text = "저장";
            }
        }

        private void flyoutPanel1_Shown(object sender, DevExpress.Utils.FlyoutPanelEventArgs e)
        {
            if ( txt_empid.Text.Length > 0 )
                txt_pw.Focus();
            else
                txt_empid.Focus();
        }


        #endregion


        #region 엔터키->로그인
        private void txt_pw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_ok.PerformClick();
        }

        private void txt_empid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_pw.Focus();
        }
        #endregion

        private void cbx_lang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string langText = cbx_lang.Text.Trim();
            commonVar.whichLang = langText;
            switch ( langText ) 
            { 
                case "한국어":
                    login_user.Text = "사용자";
                    login_manager.Text = "관리자";
                    break;

                case "English":
                    login_user.Text = "USER";
                    login_manager.Text = "MANAGER";
                    break;

                case "中國語":
                    login_user.Text = "使用者";
                    login_manager.Text = "管理者";
                    break;

                default:
                    login_user.Text = "사용자";
                    login_manager.Text = "관리자";
                    break;
            }
        }









    }//클래스
}//네임스페이스
