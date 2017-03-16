using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.IO;
using System.Drawing.Imaging;

namespace DONGSHIN
{
    public partial class ctl_machineEdit : UserControl
    {
        ctl_machineCode machineCode;
        public ctl_machineEdit(ctl_machineCode machineCode)
        {
            InitializeComponent();
            this.machineCode = machineCode;
            commonFX.setThisLanguage(this);
            getMachineMap();
        }
     
        private DataRow targetRow; //수정할때 사용

        private bool is_ValueChanged = false;
        private bool is_add;
        private bool is_read = false;
        private bool is_loading = false;

        private string machineID = "";
        private string downloadedImgPath = ""; //DB에서 읽어온 이미지 경로
        private string downloadedImgName = "";//DB에서 읽어온 이미지 이름
        private string registeredImgName = ""; //새로 등록된 이미지 이름
        private string imgDBpath = "http://drumshow1.cdn3.cafe24.com/DONGSHIN/";
        private string imgLocalPath = "";

        private SqlCommand cmd; //SEOLBI 테이블
        private SqlCommand cmd2;

        private void setDeptInfo(frm_deptRef.deptInformation selectedDeptInfo)
        {
            txt_dept.Text = selectedDeptInfo.deptName;
            txt_dept.Tag = selectedDeptInfo.deptID;
        }

        private void setAdmin1Info(frm_empRef.empInformation selectedEmpInfo)
        {
            txt_admin1.Text = selectedEmpInfo.empName;
            txt_admin1.Tag = selectedEmpInfo.empID;
        }


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
                txt_name.ReadOnly = true;
                cbx_gbn.ReadOnly = true;
                txt_ip.ReadOnly = true;
                txt_num.ReadOnly = true;
                txt_port.ReadOnly = true;
                txt_operation.ReadOnly = true;
                cbx_memorymap.ReadOnly = true;
                txt_admin1.ReadOnly = true;
                txt_dept.ReadOnly = true;
                txt_inspect.ReadOnly = true;

                cbx_nation.ReadOnly = true;
                txt_maker.ReadOnly = true;
                txt_model.ReadOnly = true;
                txt_mnfdate.ReadOnly = true;
                txt_mnfnum.ReadOnly = true;
                txt_buydate.ReadOnly = true;
                txt_price.ReadOnly = true;
                txt_cost.ReadOnly = true;
                cbx_use.ReadOnly = true;

                txt_size.ReadOnly = true;
                txt_ctlr.ReadOnly = true;
                pic_machine.ReadOnly = true;
                txt_memo.ReadOnly = true;

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

                txt_name.ReadOnly = false;
                cbx_gbn.ReadOnly = false;
                txt_ip.ReadOnly = false;
                txt_num.ReadOnly = false;
                txt_port.ReadOnly = false;
                txt_operation.ReadOnly = false;
                cbx_memorymap.ReadOnly = false;
                txt_admin1.ReadOnly = false;
                txt_dept.ReadOnly = false;
                txt_inspect.ReadOnly = false;

                cbx_nation.ReadOnly = false;
                txt_maker.ReadOnly = false;
                txt_model.ReadOnly = false;
                txt_mnfdate.ReadOnly = false;
                txt_mnfnum.ReadOnly = false;
                txt_buydate.ReadOnly = false;
                txt_price.ReadOnly = false;
                txt_cost.ReadOnly = false;
                cbx_use.ReadOnly = false;

                txt_size.ReadOnly = false;
                txt_ctlr.ReadOnly = false;
                pic_machine.ReadOnly = false;
                txt_memo.ReadOnly = false;

                btn_picAdd.Enabled = true;
                btn_picDel.Enabled = true;
            }
        }



        public void setID(string parentID)
        {
            machineID = parentID;
        }

        public void setDataRow(ref DataRow parentRow)
        {
            targetRow = parentRow;
        }

        public void clear()
        {
            txt_id.Text = "";
            txt_name.Text = "";
            cbx_gbn.Text = "";
            txt_ip.EditValue = "0.0.0.0";
            txt_num.EditValue = 0;
            txt_port.EditValue = 0;
            txt_operation.Value = 0;
            cbx_memorymap.SelectedIndex = -1;
            txt_admin1.Text = "";
            txt_dept.Text = "";
            txt_inspect.Text = "";

            cbx_nation.Text = "";
            txt_maker.Text = "";
            txt_model.Text = "";
            txt_mnfdate.Text = "";
            txt_mnfnum.Text = "";
            txt_buydate.Text = "";
            txt_price.Value = 0;
            txt_cost.Value = 0;

            txt_size.EditValue = "0000*0000*0000";
            txt_ctlr.Text = "";
            pic_machine.Text = "";
            txt_memo.Text = "";

            pic_machine.Image = null;
            downloadedImgPath = "";
            registeredImgName = "";
            imgLocalPath = "";

            cbx_use.SelectedIndex = 0;

            is_ValueChanged = false;

            setModeFlag(false);
        } //모든 컨트롤 내용 초기화

        private bool chkDuplicate() //중복항목 체크함수
        {
            string MachineCode = Convert.ToString(txt_id.Text);
            string MachineName = Convert.ToString(txt_name.Text);
            int MachineNumber = Convert.ToInt32(txt_num.EditValue);
            string MachineIP = Convert.ToString(txt_ip.Text);
            
            commonReturn Return = new commonReturn();
            Return = fx_machineCode.findByRequirements(commonVar.DBconn, MachineCode, MachineName, MachineNumber, MachineIP);

            if ( Return.Dataset.Tables[0].Rows.Count > 0 )
                return false;
            else
                return true;
        }

        private void getMachineMap() 
        {
            string query = @"select * from MemoryMapType";
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd.Connection = commonVar.DBconn;
                cmd.CommandText = query;
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);

                if ( ds.Tables[0].Rows.Count > 0 )
                {
                    foreach ( DataRow row in ds.Tables[0].Rows )
                    {
                        cbx_memorymap.Properties.Items.Add(Convert.ToString(row["MapType"]));
                    }
                }
            }
            catch ( Exception ex ) { throw ex; }
        }
        private bool save() //저장버튼 누를 때 호출되는 함수
        {
            
            if ( (txt_id.Text.Length == 0) || (txt_name.Text.Length == 0) || 
                (cbx_gbn.Text.Length == 0) || (txt_ip.Text.Equals("0.0.0.0")) ||
                (txt_num.EditValue.Equals(0)) || (txt_port.Text.Length==0) || (cbx_memorymap.SelectedIndex.Equals(-1)) )
            {
                MessageBox.Show("필수입력 항목을 확인하세요.", "주의");
                return false;
            }
            else
            {
                if ( (is_add == true) && (chkDuplicate() == false) )
                {
                    MessageBox.Show("필수입력 항목 중 중복된 항목이 존재합니다.", "주의");
                    return false;
                }

                cmd = new SqlCommand();

                // 설비코드 설비이름 설비구분 공정명 표준가동 표준임률 관리부서 관리자1 관리자2 점검주기 제조국가 메이커명 모델명 제조년월 제조번호 구입일자 구입가격 부대비용 컨트롤러 메모 사용
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@MACHINE_CODE", SqlDbType.NVarChar, 20).Value = Convert.ToString(txt_id.Text.Trim());
                cmd.Parameters.Add("@MACHINE_NAME", SqlDbType.NVarChar, 20).Value = Convert.ToString(txt_name.Text.Trim());
                cmd.Parameters.Add("@MACHINE_TYPE", SqlDbType.NVarChar, 20).Value = Convert.ToString(cbx_gbn.Text);
                cmd.Parameters.Add("@MACHINE_IP", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_ip.Text);
                cmd.Parameters.Add("@MACHINE_NUMBER", SqlDbType.Int).Value = txt_num.Value;
                cmd.Parameters.Add("@MACHINE_PORT", SqlDbType.Int).Value = txt_port.Value;
                cmd.Parameters.Add("@MapType", SqlDbType.NVarChar, 20).Value = Convert.ToString(cbx_memorymap.Text);
                cmd.Parameters.Add("@std_op_hr", SqlDbType.Int).Value = Convert.ToDecimal(txt_operation.Value);
                cmd.Parameters.Add("@admin_bs", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_dept.Text);
                cmd.Parameters.Add("@admin_main", SqlDbType.NVarChar, 20).Value = Convert.ToString(txt_admin1.Text);
                cmd.Parameters.Add("@chk_term", SqlDbType.NVarChar, 20).Value = Convert.ToString(txt_inspect.Text);
                cmd.Parameters.Add("@nation", SqlDbType.NVarChar, 20).Value = Convert.ToString(cbx_nation.Text);
                cmd.Parameters.Add("@maker", SqlDbType.NVarChar, 40).Value = Convert.ToString(txt_maker.Text);
                cmd.Parameters.Add("@model", SqlDbType.NVarChar, 40).Value = Convert.ToString(txt_model.Text);
                cmd.Parameters.Add("@mnf_date", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_mnfdate.Text);
                cmd.Parameters.Add("@mnf_num", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_mnfnum.Text);
                cmd.Parameters.Add("@buy_date", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_buydate.Text);
                cmd.Parameters.Add("@buy_price", SqlDbType.Money).Value = Convert.ToDecimal(txt_price.Value);
                cmd.Parameters.Add("@xtra_cost", SqlDbType.Money).Value = Convert.ToDecimal(txt_cost.Value);
                cmd.Parameters.Add("@size", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_size.Text);
                cmd.Parameters.Add("@ctlr", SqlDbType.NVarChar, 20).Value = Convert.ToString(txt_ctlr.Text);
                cmd.Parameters.Add("@memo", SqlDbType.NVarChar, 500).Value = Convert.ToString(txt_memo.Text);
                cmd.Parameters.Add("@use_chk", SqlDbType.Char, 1).Value = Convert.ToString(cbx_use.Text.Trim());

                if ( pic_machine.Image == null ) //컨트롤에 이미지 없을때 
                    cmd.Parameters.Add("@sb_img", SqlDbType.NVarChar, 500).Value = "no image"; //사진없을때
                else
                {
                    //컨트롤에 이미지가 있을때 path읽어오기
                    //기존경로가 존재하고 수정되지 않았을경우에는 원래 경로 저장
                    if ( (downloadedImgPath != "") && (registeredImgName == "") )
                        cmd.Parameters.Add("@sb_img", SqlDbType.NVarChar, 500).Value = downloadedImgPath;
                    else
                        cmd.Parameters.Add("@sb_img", SqlDbType.NVarChar, 500).Value = imgDBpath + registeredImgName;
                       

                    if ( saveImg() == false )
                    {
                        MessageBox.Show("이미지 저장에 실패했습니다");
                        return false;
                    }
                }

                commonReturn Return1 = new commonReturn();
                Return1 = fx_machineCode.write(commonVar.DBconn, is_add, cmd);
                if ( Return1.Message == "")
                {                    
                    return true;
                }
                else
                {
                    MessageBox.Show(Return1.Message);
                    return false;
                }

            }

           
        }


        private void chkValueChanged(object sender, EventArgs e) //컨트롤 내 값의 변화를 감지
        {
            if ( !is_loading )
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
            if ( pic_machine.Image != null )
            {
                MessageBox.Show("등록된 이미지가 있습니다. \n\r기존 이미지를 먼저 삭제 하세요.", "이미지 로드 에러");
            }
            else
            {
                pic_machine.LoadImage();
                imgLocalPath = pic_machine.GetLoadedImageLocation();
                string filename = imgLocalPath.Substring(imgLocalPath.LastIndexOf("\\") + 1); //.tag = 이전에 등록되어있던 url
                registeredImgName = filename;

                chkValueChanged(this, e);
            }
        }

        private void btn_picDel_Click(object sender, EventArgs e)
        {
            if ( pic_machine.Image == null )
            {
                MessageBox.Show("등록된 이미지가 없습니다. \n\r이미지를 먼저 등록 하세요.", "이미지 삭제 에러");
            }
            else
            {
                if ( (is_add == true) || (downloadedImgPath == "") )
                {
                    pic_machine.Image = null;
                }
                else
                {
                    FtpWebRequest req = (FtpWebRequest)WebRequest.Create(commonVar.userFTPServerIP + downloadedImgName);
                    req.Credentials = new NetworkCredential(commonVar.userFTPID, commonVar.userFTPPassword);
                    req.Method = WebRequestMethods.Ftp.DeleteFile;
                    FtpWebResponse response = (FtpWebResponse)req.GetResponse();
                    response.Close();
                    pic_machine.Image = null;
                }
                imgLocalPath = "";
                registeredImgName = "";
                downloadedImgPath = "";
                downloadedImgName = "";

                chkValueChanged(this, e);
            }
        }
        #endregion

   



        #endregion



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


        private void btn_close_Click(object sender, EventArgs e)
        {
            if ( is_ValueChanged == true )
            {
                DialogResult nRet;
                nRet = MessageBox.Show("변경된 자료가 있습니다. \n\r\n\r 저장할까요?", "주의", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if ( nRet == DialogResult.Yes )
                {   //Yes                
                    if ( save() == true )
                    {
                            is_ValueChanged = false;
                            clear();
                            this.Hide();
                            this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("등록에 실패했습니다.");
                    }
                }
                else if ( nRet == DialogResult.No )   //No
                    is_ValueChanged = false;
            }

            is_ValueChanged = false;

            clear();
            this.Hide();
            this.Visible = false;

        }





        #region (버튼컨트롤클릭제외) 이벤트

        private void ctl_machineEdit_Load(object sender, EventArgs e)
        {
            is_loading = true;

            //공통코드에서 읽어오기
            commonFX.commonRef("국가구분", cbx_nation);
            

            if ( (is_add == false) || (is_read == true) ) //수정 또는 단순조회
            {
                txt_id.ReadOnly = true;

                if ( is_read == true )
                    readOnlyMode(true);

                commonReturn Return = new commonReturn();
                Return = fx_machineCode.findByID(commonVar.DBconn, machineID);


                if ( Return.Message == "" )
                {
                    DataRow tempRow = Return.Dataset.Tables[0].Rows[0];
                    txt_id.Text = Convert.ToString(tempRow["MACHINE_CODE"]);
                    txt_name.Text = Convert.ToString(tempRow["MACHINE_NAME"]);
                    txt_num.EditValue = Convert.ToInt32(tempRow["MACHINE_NUMBER"]);
                    cbx_gbn.Text = Convert.ToString(tempRow["MACHINE_TYPE"]);
                    txt_ip.Text = Convert.ToString(tempRow["MACHINE_IP"]);

                    txt_port.EditValue = Convert.ToInt32(tempRow["MACHINE_PORT"]);
                    txt_operation.Value = Convert.ToDecimal(tempRow["std_op_hr"]);
                    cbx_memorymap.Text = Convert.ToString(tempRow["MapType"]);                  
                    txt_admin1.Text = Convert.ToString(tempRow["admin_main"]);
                    txt_dept.Text = Convert.ToString(tempRow["admin_bs"]);
                    txt_inspect.Text = Convert.ToString(tempRow["chk_term"]);

                    cbx_nation.Text = Convert.ToString(tempRow["nation"]);
                    txt_maker.Text = Convert.ToString(tempRow["model"]);
                    txt_model.Text = Convert.ToString(tempRow["model"]);
                    txt_mnfdate.Text = Convert.ToString(tempRow["mnf_date"]);
                    txt_mnfnum.Text = Convert.ToString(tempRow["mnf_num"]);
                    txt_buydate.Text = Convert.ToString(tempRow["buy_date"]);
                    txt_price.Value = Convert.ToDecimal(tempRow["buy_price"]);
                    txt_cost.Value = Convert.ToDecimal(tempRow["xtra_cost"]);

                    txt_size.Text = Convert.ToString(tempRow["size"]);
                    txt_ctlr.Text = Convert.ToString(tempRow["ctlr"]);
                    txt_memo.Text = Convert.ToString(tempRow["memo"]);

                    if ( Convert.ToString(tempRow["use_chk"]) == "Y" )
                        cbx_use.SelectedIndex = 0;
                    else
                        cbx_use.SelectedIndex = 1;
                    //이미지
                    downloadedImgPath = Convert.ToString(tempRow["sb_img"]);
                    if ( downloadedImgPath == "no image" )
                    {
                        pic_machine.Image = null;
                        downloadedImgPath = "";
                    }
                    else
                    {
                        pic_machine.LoadAsync(downloadedImgPath);
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

            is_loading = false;
        }

        private void ctl_machineEdit_VisibleChanged(object sender, EventArgs e)
        {
            if ( this.Visible == true )
                this.ctl_machineEdit_Load(this, e);
            else
                machineCode.editCompleted();
        }




        private void txt_admin1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Image img = Properties.Resources.black_opacity;
            bgimg.Appearance.Image = commonFX.change_opacity(img, 0.5f);
            bgimg.Dock = DockStyle.Fill;
            bgimg.Visible = true;

            frm_empRef empRef = new frm_empRef();
            empRef.SendEmpInfoEvent += new frm_empRef.SendEmpDataHandler(setAdmin1Info);
            empRef.ShowDialog();

            bgimg.Visible = false;

        }



        private void txt_bs_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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



        #endregion

        private void pic_machine_DoubleClick(object sender, EventArgs e)
        {
            if ( pic_machine.Image == null ) 
            {
                MessageBox.Show("사진이 존재하지 않습니다.","에러");
            }
            else
            {
                frm_imageContainer imgContainer;
                int width = pic_machine.Image.Width;
                int height = pic_machine.Image.Height;

                if ( imgLocalPath != "" )
                    imgContainer  = new frm_imageContainer(width,height,imgLocalPath,"설비사진");
                else
                    imgContainer = new frm_imageContainer(width, height, downloadedImgPath, "설비사진");

                imgContainer.ShowDialog();
            }
        }




    }//class
}//namespace
