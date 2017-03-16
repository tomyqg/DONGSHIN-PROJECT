using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;
using System.Net;
using DevExpress.XtraEditors;

namespace DONGSHIN
{
    
    public partial class ctl_empedit : UserControl
    {
        ctl_empcode empCode;
        public ctl_empedit(ctl_empcode empCode)
        {
            InitializeComponent();
            this.empCode = empCode;
            commonFX.setThisLanguage(this);
        }
        private DataRow targetRow; //수정할때 사용

        private bool is_ValueChanged = false;
        private bool is_add;
        private bool is_read = false;
        private bool is_loading = false;
       
        private string empID ="";
        private string downloadedImgPath = ""; //DB에서 읽어온 이미지 경로
        private string downloadedImgName = "";//DB에서 읽어온 이미지 이름
        private string registeredImgName = ""; //새로 등록된 이미지 이름
        private string imgDBpath = "http://drumshow1.cdn3.cafe24.com/DONGSHIN/";
        private string imgLocalPath = "";
        
        private SqlCommand cmd;

        private void setButtonFontColor(object sender, EventArgs e) 
        {
            SimpleButton[] buttons = new SimpleButton[] { btn_close,btn_picAdd,btn_picDel,btn_save };
            for ( int i = 0 ; i < buttons.Length ; i++ ) 
            {
                if ( buttons[i].Enabled == true )
                    buttons[i].Appearance.ForeColor = Color.WhiteSmoke;
                else
                    buttons[i].Appearance.ForeColor = Color.Red;
            }
        }

        private void setDeptInfo(frm_deptRef.deptInformation selectedDeptInfo)
        {
            txt_dept.Text = selectedDeptInfo.deptName;
            txt_dept.Tag = selectedDeptInfo.deptID;
        }

        private void pic_back_Click(object sender, EventArgs e)
        {
            btn_close.PerformClick();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if(is_ValueChanged==true)
            {
                DialogResult nRet;
                nRet = MessageBox.Show("변경된 자료가 있습니다. \n\r\n\r 저장할까요?", "주의", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if ( nRet == DialogResult.Yes )   //Yes을 누르면                
                    btn_save.PerformClick();                
                else if ( nRet == DialogResult.No )   //No을 누르면
                    is_ValueChanged = false;         
            }

            is_ValueChanged = false;
            clear();
            this.Hide();
            this.Visible = false;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if ( save() == true )
            {              
                
                DialogResult question;
                question = MessageBox.Show("등록에 성공했습니다. 추가 등록하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if ( question == DialogResult.Yes )
                {
                    is_add = true;
                    is_ValueChanged = false;
                    clear();
                    txt_id.ReadOnly = false;
                }
                else
                {
                    is_ValueChanged = false;
                    clear();
                    this.Hide();
                    this.Visible = false; 
                }
            }
            else
            {
                MessageBox.Show("등록에 실패했습니다.");
            }
        }

        private void txt_dept_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {      
            Image img = Properties.Resources.black_opacity;
            bgimg.Appearance.Image = commonFX.change_opacity(img, 0.5f);
            bgimg.Dock = DockStyle.Fill;      
            bgimg.Visible = true;

            frm_deptRef deptRef = new frm_deptRef();
            deptRef.SendDeptInfoEvent += new frm_deptRef.SendDeptDataHandler(setDeptInfo);
            deptRef.ShowDialog();

            bgimg.Visible = false;

        }

        #region (클릭 제외)이벤트

        private void ctl_empedit_Load(object sender, EventArgs e)
        {
            is_loading = true;
            if ( (is_add == false) || (is_read == true) ) //수정 또는 단순조회
            {
                txt_id.ReadOnly = true;

                if ( is_read == true )
                    readOnlyMode(true);

                commonReturn Return = new commonReturn();
                Return = fx_empCode.findByID(commonVar.DBconn, empID);


                if ( Return.Message == "" )
                {
                    DataRow tempRow = Return.Dataset.Tables[0].Rows[0];
                    txt_id.Text = Convert.ToString(tempRow["sw_id"]);
                    txt_dept.Tag = Convert.ToString(tempRow["bs_id"]);
                    txt_dept.Text = Convert.ToString(tempRow["bs_name"]);
                    txt_kor.Text = Convert.ToString(tempRow["sw_name"]);
                    txt_mail.Text = Convert.ToString(tempRow["mail"]);
                    txt_memo.Text = Convert.ToString(tempRow["memo"]);
                    txt_mobi.Text = Convert.ToString(tempRow["mobi"]);
                    txt_pos.Text = Convert.ToString(tempRow["pos"]);
                    txt_stdlab.Value = Convert.ToDecimal(tempRow["std_lab_rt"]);
                    txt_stdhr.Value = Convert.ToDecimal(tempRow["std_lab_t"]);
                    cbx_gbn.Text = Convert.ToString(tempRow["user_gbn"]);
                    if ( Convert.ToString(tempRow["pw"]).Length > 0 )
                        txt_pw.Text = encodeDecode.DecryptString(Convert.ToString(tempRow["pw"]));
                    else
                        txt_pw.Text = "1111";

                    if ( Convert.ToString(tempRow["use_chk"]) == "Y" )
                        cbx_use.SelectedIndex = 0;
                    else
                        cbx_use.SelectedIndex = 1;

                    if ( Convert.ToString(tempRow["ALARM_CHK"]) == "Y" )
                        cbx_alarm.SelectedIndex = 0;
                    else
                        cbx_alarm.SelectedIndex = 1;
                    //이미지
                    downloadedImgPath = Convert.ToString(tempRow["sw_img"]);
                    if ( downloadedImgPath == "no image" )
                    {
                        pic_profile.Image = null;
                        downloadedImgPath = "";
                    }
                    else
                    {
                        pic_profile.LoadAsync(downloadedImgPath);
                        string filename = downloadedImgPath.Substring(downloadedImgPath.LastIndexOf("/") + 1);
                        downloadedImgName = filename;
                    }
                    
                }
                else
                {
                    MessageBox.Show(Return.Message);
                }
            }//if
            if ( is_add == true ) //추가
            {
                clear();
                txt_id.ReadOnly = false;
                txt_id.Focus();
            }

            btn_save.Enabled = false;
            is_ValueChanged = false;
            is_loading = false;
        }//load

        private void ctl_empedit_VisibleChanged(object sender, EventArgs e) //컨트롤이 나타날때 마다 실행될 이벤트
        {
            if ( this.Visible == true )
                this.ctl_empedit_Load(this, e);
            else
                empCode.editCompleted();
        } 


        #endregion
          
      



        #region 함수

        public void setAddFlag(bool parentFlag) //추가-수정 구분할 때 사용하는 함수 (추가: is_add=true , 수정: is_add=false)
        {
            is_add = parentFlag;
            if ( is_add == true )
                clear();
        }

        public void setModeFlag(bool parentFlag2) //단순조회시 사용
        {
            is_read = parentFlag2;
        }

        public void readOnlyMode(bool flag) //단순조회시 컨트롤 속성 설정
        {
            if ( flag == true )
            {
                is_read = true;

                txt_id.ReadOnly = true;
                txt_pw.ReadOnly = true;
                txt_kor.ReadOnly = true;
                txt_dept.ReadOnly = true;
                txt_pos.ReadOnly = true;
                txt_mobi.ReadOnly = true;
                txt_mail.ReadOnly = true;
                txt_stdlab.ReadOnly = true;
                txt_stdhr.ReadOnly = true;
                cbx_use.ReadOnly = true;
                txt_memo.ReadOnly = true;
                cbx_gbn.ReadOnly = true;
                cbx_alarm.ReadOnly = true;
                pic_profile.ReadOnly = true;

                btn_picAdd.Enabled = false;
                btn_picDel.Enabled = false;
            }
            else
            {
                is_read = false;

                if ( is_add == true )
                    txt_id.ReadOnly = false;
                else
                    txt_id.ReadOnly = true;

                txt_pw.ReadOnly = false;
                txt_kor.ReadOnly = false;
                txt_dept.ReadOnly = false;
                txt_pos.ReadOnly = false;
                txt_mobi.ReadOnly = false;
                txt_mail.ReadOnly = false;
                txt_stdlab.ReadOnly = false;
                txt_stdhr.ReadOnly = false;
                cbx_use.ReadOnly = false;
                txt_memo.ReadOnly = false;
                cbx_gbn.ReadOnly = false;
                cbx_alarm.ReadOnly = false;
                pic_profile.ReadOnly = false;

                btn_picAdd.Enabled = true;
                btn_picDel.Enabled = true;
            }
        }


        public void setID(string parentID)
        {
            empID = parentID;
        }

        public void setDataRow(ref DataRow parentRow)
        {
            targetRow = parentRow;
        }

        public void clear()
        {
            txt_id.Text = "";
            txt_kor.Text = "";
            txt_dept.Text = "";
            txt_mail.Text = "";
            txt_memo.Text = "";
            txt_mobi.Text = "";
            txt_pos.Text = "";
            txt_pw.Text = "";
            txt_stdhr.Value = 0;
            txt_stdlab.Value = 0;
            
            pic_profile.Image = null;
            downloadedImgPath = "";
            registeredImgName = "";
            imgLocalPath = "";            
            
            cbx_use.SelectedIndex = 0;
            cbx_gbn.SelectedIndex = 0;
            cbx_alarm.SelectedIndex = 0;

            is_ValueChanged = false;

            setModeFlag(false);
        } //모든 컨트롤 내용 초기화

        private bool chkDuplicate()
        {
            commonReturn Return = new commonReturn();
            Return = fx_empCode.findByID(commonVar.DBconn, txt_id.Text);

            if ( Return.Dataset.Tables[0].Rows.Count > 0 )
                return false;
            else
                return true;
        }

        private bool save() //저장버튼 누를 때 호출되는 함수
        {

            if ( txt_id.Text.Length == 0 )
            {
                MessageBox.Show("사원번호를 입력하세요.", "주의");
                return false;
            }
            else if ( txt_kor.Text.Length == 0 )
            {
                MessageBox.Show("사원이름을 입력하세요.", "주의");
                return false;
            }
            else if(cbx_gbn.Text.Length==0)
            {
                MessageBox.Show("사용자 구분을 선택하세요.","주의");
                return false;
            }
            else
            {
                if ( (is_add == true) && (chkDuplicate() == false) )
                {
                    MessageBox.Show("사원번호가 중복되었습니다.", "주의");
                    return false;
                }

                cmd = new SqlCommand();
                
                //사원번호 사원이름 영어이름 비밀번호 부서코드 직위직책 휴대전화 사원메일 표준임률 표준시간 사용여부 메모내용 사원사진 유저구분(x)
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@sw_id", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_id.Text.Trim());
                cmd.Parameters.Add("@sw_name", SqlDbType.NVarChar, 20).Value = Convert.ToString(txt_kor.Text.Trim());
                cmd.Parameters.Add("@sw_eng_name", SqlDbType.VarChar, 20).Value = ""; //현재안쓰임
                cmd.Parameters.Add("@pw", SqlDbType.VarChar, 250).Value = encodeDecode.EncryptString(txt_pw.Text);
                cmd.Parameters.Add("@bs_id", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_dept.Tag);
                cmd.Parameters.Add("@pos", SqlDbType.NVarChar, 20).Value = Convert.ToString(txt_pos.Text);
                cmd.Parameters.Add("@mobi", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_mobi.Text);
                cmd.Parameters.Add("@mail", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_mail.Text);
                cmd.Parameters.Add("@std_lab_rt", SqlDbType.Money).Value = Convert.ToDecimal(txt_stdlab.Value);
                cmd.Parameters.Add("@std_lab_t", SqlDbType.Money).Value = Convert.ToDecimal(txt_stdhr.Value);
                cmd.Parameters.Add("@use_chk", SqlDbType.Char, 1).Value = Convert.ToString(cbx_use.Text.Trim());
                cmd.Parameters.Add("@ALARM_CHK", SqlDbType.Char, 1).Value = Convert.ToString(cbx_alarm.Text.Trim());
                cmd.Parameters.Add("@memo", SqlDbType.NVarChar, 500).Value = Convert.ToString(txt_memo.Text);

                if ( cbx_gbn.Text == "사용자" )
                    cmd.Parameters.Add("@user_gbn", SqlDbType.NVarChar, 1).Value = "U";
                else
                    cmd.Parameters.Add("@user_gbn", SqlDbType.NVarChar, 1).Value = "M";

                if ( pic_profile.Image == null ) //컨트롤에 이미지 없을때 
                    cmd.Parameters.Add("@sw_img", SqlDbType.NVarChar, 500).Value = "no image"; //사진없을때
                else
                {
                    //컨트롤에 이미지가 있을때 path읽어오기                    
                    if ( (downloadedImgPath != "") && (registeredImgName == "") )//기존경로가 존재하고 수정되지 않았을경우에는 원래 경로 저장 -> saveImg()함수 필요없음
                        cmd.Parameters.Add("@sw_img", SqlDbType.NVarChar, 500).Value = downloadedImgPath;
                    else
                        cmd.Parameters.Add("@sw_img", SqlDbType.NVarChar, 500).Value = imgDBpath + registeredImgName;

                    if ( saveImg() == false )
                    {
                        MessageBox.Show("이미지 저장에 실패했습니다");
                        return false;
                    }
                    
                }
                

                commonReturn Return = new commonReturn();
                Return = fx_empCode.write(commonVar.DBconn, is_add, cmd);

                if ( Return.Message == "" )
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(Return.Message);
                    return false;
                }
            }
        }


        private void chkValueChanged(object sender, EventArgs e) //컨트롤 내 값의 변화를 감지
        {
           if(!is_loading)
                is_ValueChanged = true;

            btn_save.Enabled = true;
        }



        #region 이미지 업/다운로드 관련 함수
        private bool saveImg() //사진 업로드 (ftp)
        {
            try
            {
                if ( !((downloadedImgPath != "") && (registeredImgName == "")) )
                {
                    FtpWebRequest req = (FtpWebRequest)WebRequest.Create(commonVar.userFTPServerIP + registeredImgName);
                    req.UseBinary = true;
                    req.Method = WebRequestMethods.Ftp.UploadFile;
                    req.Credentials = new NetworkCredential(commonVar.userFTPID, commonVar.userFTPPassword);
                    byte[] fileData = File.ReadAllBytes(imgLocalPath);
                    req.ContentLength = fileData.Length;
                    Stream reqStream = req.GetRequestStream();
                    reqStream.Write(fileData, 0, fileData.Length);
                    reqStream.Close();
                }
                return true;
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message + "\n\r 이미지 업로드에 실패했습니다.", "이미지 업로드 에러");
                return false;
            }

        }

        private void btn_picAdd_Click(object sender, EventArgs e) //로컬에서 사진 불러오기
        {
            if ( pic_profile.Image != null )
            {
                MessageBox.Show("등록된 이미지가 있습니다. \n\r기존 이미지를 먼저 삭제 하세요.", "이미지 로드 에러");
            }
            else
            {
                pic_profile.LoadImage();
                imgLocalPath = pic_profile.GetLoadedImageLocation();
                string filename = imgLocalPath.Substring(imgLocalPath.LastIndexOf("\\") + 1); //.tag = 이전에 등록되어있던 url
                registeredImgName = filename;

                chkValueChanged(this, e);
            }
        }

        private void btn_picDel_Click(object sender, EventArgs e)
        {
            if ( pic_profile.Image == null )
            {
                MessageBox.Show("등록된 이미지가 없습니다. \n\r이미지를 먼저 등록 하세요.", "이미지 삭제 에러");
            }
            else
            {
                if ( (is_add == true) || (downloadedImgPath == ""))
                {                    
                    pic_profile.Image = null;
                }
                else
                {
                    FtpWebRequest req = (FtpWebRequest)WebRequest.Create(commonVar.userFTPServerIP + downloadedImgName);
                    req.Credentials = new NetworkCredential(commonVar.userFTPID, commonVar.userFTPPassword);
                    req.Method = WebRequestMethods.Ftp.DeleteFile;
                    FtpWebResponse response = (FtpWebResponse)req.GetResponse();
                    response.Close();
                    pic_profile.Image = null;
                }
                imgLocalPath = "";
                registeredImgName = "";
                downloadedImgPath = "";
                downloadedImgName = "";

                chkValueChanged(this, e);
            }
        }
        #endregion  

        private void pic_profile_DoubleClick(object sender, EventArgs e)
        {
            if ( pic_profile.Image == null )
            {
                MessageBox.Show("사진이 존재하지 않습니다.", "에러");
            }
            else
            {
                frm_imageContainer imgContainer;
                int width = pic_profile.Image.Width;
                int height = pic_profile.Image.Height;

                if ( imgLocalPath != "" )
                    imgContainer = new frm_imageContainer(width, height, imgLocalPath, txt_kor.Text);
                else
                    imgContainer = new frm_imageContainer(width, height, downloadedImgPath, txt_kor.Text);

                imgContainer.ShowDialog();
            }
        }





        #endregion





    }//class
}//namespace
