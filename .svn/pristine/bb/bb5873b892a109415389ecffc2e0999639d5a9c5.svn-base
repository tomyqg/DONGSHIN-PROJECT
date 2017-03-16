using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using DevExpress.XtraEditors;

namespace DONGSHIN
{
    public partial class ctl_workOrderEdit : UserControl
    {
        ctl_workOrder workOrder;
        public ctl_workOrderEdit(ctl_workOrder workOrder)
        {
            InitializeComponent();
            this.workOrder = workOrder;
            commonFX.setThisLanguage(this);
        }

        
        private bool is_ValueChanged = false;
        private bool is_add;
        private bool is_read = false;
        private bool is_loading = false;
        private bool is_copy = false;
        private string workOrderID = "";

        private SqlCommand cmd;


        private void setMoldInfo(frm_moldRef.moldInformation selectedMoldInfo) 
        {
            txt_mold.Text = selectedMoldInfo.moldID;
        }

        private void setMachineInfo(frm_machineRef.machineInformation selectedMachineInfo) 
        {
            txt_machine.Text = selectedMachineInfo.machineName;
            txt_machine.Tag = selectedMachineInfo.machineID;
        }

        private void setProductInfo(frm_productRef.productInformation selectedProductInfo) 
        {
            txt_jpID.Text = selectedProductInfo.productID;
            txt_jpName.Text = selectedProductInfo.productName;
            txt_jpNum.Text = selectedProductInfo.productNum;
            txt_jpCar.Text = selectedProductInfo.carName;
            txt_jpModel.Text = selectedProductInfo.modelName;
            txt_jpMtrl.Text = selectedProductInfo.mtrlNum;
            txt_cycle.EditValue = selectedProductInfo.cycleTime;
            txt_cycleValid.EditValue = selectedProductInfo.cycleTime;
            txt_cavity.Text = selectedProductInfo.cavity;
            txt_cavityValid.Text = selectedProductInfo.cavity;
            txt_resin.Text = selectedProductInfo.resinName;
            txt_resin.Tag = selectedProductInfo.resinID;
            string stdPaperURL = selectedProductInfo.standardPaperURL;
            if ( !stdPaperURL.Equals("no image") ) 
            {
                pic_stdPaper.LoadAsync(stdPaperURL);
                pic_stdPaper.Tag = stdPaperURL;
            }
        }

        private void setBizInfo(frm_bizRef.bizInformation selectedBizInfo) 
        {
            txt_mnf.Text = selectedBizInfo.bizName;
            txt_mnf.Tag = selectedBizInfo.bizID;
        }

        private void setDeptInfo(frm_deptRef.deptInformation selectedDeptInfo) 
        {
            txt_dept.Text = selectedDeptInfo.deptName;
            txt_dept.Tag = selectedDeptInfo.deptID;
        }

        private void setEmpInfo(frm_empRef.empInformation selectedEmpInfo) 
        {
            txt_emp.Text = selectedEmpInfo.empName;
            txt_emp.Tag = selectedEmpInfo.empID;
        }

        private void ctl_workOrderEdit_Load(object sender, EventArgs e)
        {            
            is_loading = true;

            commonFX.commonRef("공정", cbx_gj);

            if ( (is_add == false) || (is_read == true) ) //수정 또는 단순조회
            {

                if ( is_read == true )
                    readOnlyMode(true);

                commonReturn Return = new commonReturn();
                Return = fx_workOrder.findByID(commonVar.DBconn, workOrderID);


                if ( Return.Message == "" )
                {
                    DataRow tempRow = Return.Dataset.Tables[0].Rows[0];

                    //기본정보
                    if(is_copy==true)
                        txt_date.Text = commonVar.getDate.ToShortDateString();
                    else
                        txt_date.Text = Convert.ToString(tempRow["jisi_date"]);

                    txt_dept.Text = Convert.ToString(tempRow["bs_name"]);
                    txt_dept.Tag = Convert.ToString(tempRow["wr_bs_id"]);
                    txt_emp.Text = Convert.ToString(tempRow["sw_name"]);
                    txt_emp.Tag = Convert.ToString(tempRow["wr_sw_id"]);
                    cbx_gj.Text = Convert.ToString(tempRow["gj_gbn"]);
                    cbx_startOrStop.Text = Convert.ToString(tempRow["jisi_gbn"]);

                    //생산정보
                    txt_mnf.Text = Convert.ToString(tempRow["ec_name"]);
                    txt_mnf.Tag = Convert.ToString(tempRow["mnf_id"]);
                    txt_machine.Text = Convert.ToString(tempRow["MACHINE_NAME"]);
                    txt_machine.Tag = Convert.ToString(tempRow["MACHINE_CODE"]);
                    txt_line.Text = "";
                    txt_mold.Text = Convert.ToString(tempRow["gh_id"]);

                    //생산계획
                    txt_planQT.Value = Convert.ToInt32(tempRow["qt_plan"]);
                    txt_planTime.EditValue = Convert.ToString(tempRow["plan_t"]);
                    txt_planTimeDecimal.Value = stringToDecimal(txt_planTime.Text);

                    //제품정보
                    txt_resin.Text = Convert.ToString(tempRow["sj_name"]);
                    txt_resin.Tag = Convert.ToString(tempRow["sj_id"]);
                    txt_jpID.Text = Convert.ToString(tempRow["jp_id"]);
                    txt_jpName.Text = Convert.ToString(tempRow["jp_name"]);
                    txt_jpNum.Text = Convert.ToString(tempRow["jp_num"]);
                    txt_jpCar.Text = Convert.ToString(tempRow["car"]);
                    txt_jpModel.Text = Convert.ToString(tempRow["model"]);
                    txt_jpMtrl.Text = Convert.ToString(tempRow["mtrl_num"]);
                    txt_jpStock.Value = Convert.ToDecimal(tempRow["now_stock"]);
                    txt_cavity.Text = Convert.ToString(tempRow["original_cavity"]);
                    txt_cavityValid.Text = Convert.ToString(tempRow["cavity"]);
                    txt_cycle.Value = Convert.ToDecimal(tempRow["original_cycle"]);
                    txt_cycleValid.Value = Convert.ToDecimal(tempRow["cycle_t"]);
                    string stdPaperURL = Convert.ToString(tempRow["jp_stdpaper"]);
                    if ( !stdPaperURL.Equals("no image") ) 
                    {
                        pic_stdPaper.LoadAsync(stdPaperURL);
                        pic_stdPaper.Tag = stdPaperURL;
                    }

                    txt_memo.Text = Convert.ToString(tempRow["memo"]);


                }
                else
                {
                    MessageBox.Show(Return.Message);
                }
            }//if
            if ( is_add == true ) //추가
            {
                clear();
                txt_date.Text = commonVar.getDate.ToShortDateString();
                txt_date.Focus();
            }

            if ( is_copy == true )
                btn_save.Enabled = true;
            else
                btn_save.Enabled = false;

            is_loading = false;
        }

        private void ctl_workOrderEdit_VisibleChanged(object sender, EventArgs e)
        {
            if ( this.Visible == true )
                this.ctl_workOrderEdit_Load(this, e);
            else
                workOrder.editCompleted();
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

                    txt_mnf.ReadOnly = false;
                    txt_jpID.ReadOnly = false;
                    cbx_gj.ReadOnly = false;
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

                if ( nRet == DialogResult.Yes )   //Yes을 누르면                
                    btn_save.PerformClick();
            }

            is_ValueChanged = false;

            clear();
            this.Hide();
            this.Visible = false;
        }


        #region 함수

        public void setAddFlag(bool parentFlag) //추가-수정 구분할 때 사용하는 함수 (추가: is_add=true , 수정: is_add=false)
        {
            is_add = parentFlag;
            if ( is_add == true )
                clear();
        }

        public void setModeFlag(bool readFlag, bool copyFlag) //단순조회 및 복사 사용
        {
            is_read = readFlag;
            is_copy = copyFlag;
        }

        public void readOnlyMode(bool flag) //단순조회시 컨트롤 속성 설정
        {
            if ( flag == true )
            {
                is_read = true;
                is_copy = false;

                //기본정보
                txt_date.ReadOnly = true;
                txt_dept.ReadOnly = true;
                txt_emp.ReadOnly = true;
                cbx_gj.ReadOnly = true;
                cbx_startOrStop.ReadOnly = true;

                //생산정보
                txt_mnf.ReadOnly = true;
                txt_machine.ReadOnly = true;
                txt_line.ReadOnly = true;
                txt_mold.ReadOnly = true;

                //생산계획
                txt_planQT.ReadOnly = true;
                txt_planTime.ReadOnly = true;

                //제품정보                
                txt_jpID.ReadOnly = true;
                txt_cavityValid.ReadOnly = true;
                txt_cycleValid.ReadOnly = true;

                txt_memo.ReadOnly = true;


            }
            else
            {
                is_read = false;

                if ( is_add == true || is_copy == true ) 
                {
                    txt_mnf.ReadOnly = false;
                    txt_jpID.ReadOnly = false;
                    cbx_gj.ReadOnly = false;
                }
                else 
                {
                    txt_jpID.ReadOnly = true;
                    txt_mnf.ReadOnly = true;
                    cbx_gj.ReadOnly = true;
                }


                //기본정보
                txt_date.ReadOnly = false;
                txt_dept.ReadOnly = false;
                txt_emp.ReadOnly = false;
                cbx_startOrStop.ReadOnly = false;

                //생산정보
                txt_machine.ReadOnly = false;
                txt_line.ReadOnly = false;
                txt_mold.ReadOnly = false;

                //생산계획
                txt_planQT.ReadOnly = false;
                txt_planTime.ReadOnly = false;

                //제품정보
                txt_jpID.ReadOnly = false;
                txt_cavityValid.ReadOnly = false;
                txt_cycleValid.ReadOnly = false;

                txt_memo.ReadOnly = false;


            }
        }


        public void setID(string parentID)
        {
            workOrderID = parentID;
        }



        public void clear()
        {
            //기본정보
            txt_date.Text = commonVar.getDate.ToShortDateString();
            txt_dept.Text = "";
            txt_dept.Tag = "";
            txt_emp.Text = "";
            txt_emp.Tag = "";
            cbx_gj.SelectedIndex = -1;
            cbx_startOrStop.SelectedIndex = 0;

            //생산정보
            txt_mnf.Text = "";
            txt_mnf.Tag = "";
            txt_machine.Text = "";
            txt_machine.Tag = "";
            txt_line.Text = "";
            txt_mold.Text = "";

            //생산계획
            txt_planQT.Value = 0;
            txt_planTime.EditValue = txt_planTime.Properties.NullText;
            txt_planTimeDecimal.Value = 0;

            //제품정보
            txt_resin.Text = "";
            txt_resin.Tag = "";
            txt_jpID.Text = "";
            txt_jpName.Text = "";
            txt_jpNum.Text = "";
            txt_jpCar.Text = "";
            txt_jpModel.Text = "";
            txt_jpMtrl.Text = "";
            txt_jpStock.Value = 0;
            txt_cavity.EditValue = txt_cavity.Properties.NullText;
            txt_cavityValid.EditValue = txt_cavity.Properties.NullText;
            txt_cycle.EditValue = txt_cavity.Properties.NullText;
            txt_cycleValid.EditValue = 0;
            pic_stdPaper.Image = null;
            pic_stdPaper.Tag = "";
            txt_memo.Text = "";

            is_ValueChanged = false;

            is_copy = false;
            is_read = false;
            setModeFlag(is_read,is_copy);
        } //모든 컨트롤 내용 초기화



        private bool save() //저장버튼 누를 때 호출되는 함수
        {
            if ( txt_jpID.Text.Length == 0 )
            {
                MessageBox.Show("제품코드를 입력하세요.", "주의");
                return false;
            }
            else if ( txt_machine.Text.Length == 0 )
            {
                MessageBox.Show("설비이름을 입력하세요.", "주의");
                return false;
            }
            else if ( txt_mold.Text.Length == 0 )
            {
                MessageBox.Show("금형번호를 입력하세요.", "주의");
                return false;
            }
            else if ( txt_mnf.Text.Length == 0 )
            {
                MessageBox.Show("생산업체를 입력하세요.", "주의");
                return false;
            }
            else
            {                

                cmd = new SqlCommand();

                cmd.Parameters.Clear();

                if ( is_add || is_copy )
                    cmd.Parameters.Add("@jisi_id", SqlDbType.VarChar, 25).Value = Regex.Replace(DateTime.Now.ToString() + DateTime.Now.Millisecond.ToString(), @"\D", "");
                else
                    cmd.Parameters.Add("@jisi_id", SqlDbType.VarChar, 25).Value = workOrderID;

                cmd.Parameters.Add("@jisi_date", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_date.Text.Trim());
                cmd.Parameters.Add("@wr_bs_id", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_dept.Tag);
                cmd.Parameters.Add("@wr_sw_id", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_emp.Tag);
                cmd.Parameters.Add("@gj_gbn", SqlDbType.NVarChar, 20).Value = Convert.ToString(cbx_gj.Text.Trim());
                cmd.Parameters.Add("@jisi_gbn", SqlDbType.NVarChar, 10).Value = Convert.ToString(cbx_startOrStop.Text.Trim());

                cmd.Parameters.Add("@mnf_id", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_mnf.Tag);
                cmd.Parameters.Add("@MACHINE_CODE", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_machine.Tag);
                cmd.Parameters.Add("@line_id", SqlDbType.VarChar, 20).Value = "";//현재안쓰임
                cmd.Parameters.Add("@gh_id", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_mold.Text.Trim());

                cmd.Parameters.Add("@qt_plan", SqlDbType.Int).Value = Convert.ToInt32(txt_planQT.Value);
                cmd.Parameters.Add("@plan_t", SqlDbType.NVarChar, 20).Value = Convert.ToString(txt_planTime.Text.Trim());
                
                cmd.Parameters.Add("@jp_id", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_jpID.Text.Trim());
                cmd.Parameters.Add("@cavity", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_cavityValid.Text.Trim());
                cmd.Parameters.Add("@cycle_t", SqlDbType.Money).Value = Convert.ToString(txt_cycleValid.Text.Trim());

                if ( cbx_startOrStop.Text == "시작" )
                    cmd.Parameters.Add("@is_work_started", SqlDbType.Char, 1).Value = "Y";
                else 
                    cmd.Parameters.Add("@is_work_started", SqlDbType.Char, 1).Value = "N";

                cmd.Parameters.Add("@memo", SqlDbType.NVarChar, 200).Value = Convert.ToString(txt_memo.Text.Trim());
                cmd.Parameters.Add("@wr_id", SqlDbType.VarChar, 10).Value = commonVar.login_id;



                bool insert;
                if ( is_add || is_copy )
                    insert = true;
                else
                    insert = false;
                        
                commonReturn Return = new commonReturn();
                Return = fx_workOrder.write(commonVar.DBconn, insert, cmd);


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
            if ( !is_loading )
                is_ValueChanged = true;

            btn_save.Enabled = true;
        }


        #endregion

        #region 참조 및 계획시간 이벤트

        private void txt_planTime_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string timeOriginal = txt_planTime.Text.Trim();
                string timeDecimal = Regex.Replace(timeOriginal, @"\D", "");
                txt_planTimeDecimal.Text = "";
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

        private void txt_emp_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Image img = Properties.Resources.black_opacity;
            bgimg.Appearance.Image = commonFX.change_opacity(img, 0.5f);
            bgimg.Dock = DockStyle.Fill;
            bgimg.Visible = true;

            frm_empRef empRef = new frm_empRef();
            empRef.SendEmpInfoEvent += new frm_empRef.SendEmpDataHandler(setEmpInfo);
            empRef.ShowDialog();

            bgimg.Visible = false;
        }

        private void txt_mnf_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Image img = Properties.Resources.black_opacity;
            bgimg.Appearance.Image = commonFX.change_opacity(img, 0.5f);
            bgimg.Dock = DockStyle.Fill;
            bgimg.Visible = true;

            frm_bizRef bizRef = new frm_bizRef();
            bizRef.SendBizInfoEvent += new frm_bizRef.SendBizDataHandler(setBizInfo);
            bizRef.ShowDialog();

            bgimg.Visible = false;
        }

        private void txt_line_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Image img = Properties.Resources.black_opacity;
            //bgimg.Appearance.Image = commonFX.change_opacity(img, 0.5f);
            //bgimg.Dock = DockStyle.Fill;
            //bgimg.Visible = true;

            //commonFX.bizRef(sender);

            //bgimg.Visible = false;
        }

        private void txt_mold_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Image img = Properties.Resources.black_opacity;
            bgimg.Appearance.Image = commonFX.change_opacity(img, 0.5f);
            bgimg.Dock = DockStyle.Fill;
            bgimg.Visible = true;

            frm_moldRef moldRef = new frm_moldRef();
            moldRef.SendMoldInfoEvent += new frm_moldRef.SendMoldDataHandler(setMoldInfo);
            moldRef.ShowDialog();

            bgimg.Visible = false;
        }

        private void txt_jpID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Image img = Properties.Resources.black_opacity;
            bgimg.Appearance.Image = commonFX.change_opacity(img, 0.5f);
            bgimg.Dock = DockStyle.Fill;
            bgimg.Visible = true;

            frm_productRef productRef = new frm_productRef();
            productRef.SendProductInfoEvent += new frm_productRef.SendProductDataHandler(setProductInfo);
            productRef.ShowDialog();

            bgimg.Visible = false;
        }


        private void txt_machine_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Image img = Properties.Resources.black_opacity;
            bgimg.Appearance.Image = commonFX.change_opacity(img, 0.5f);
            bgimg.Dock = DockStyle.Fill;
            bgimg.Visible = true;

            frm_machineRef machineRef = new frm_machineRef();
            machineRef.SendMachineInfoEvent += new frm_machineRef.SendMachineDataHandler(setMachineInfo);
            machineRef.ShowDialog();

            bgimg.Visible = false;
        }

        private void validQuantityCalculate(object sender, EventArgs e)
        {
            /*
             * 계획수량(B) = ( 계획시간(A) * 유효캐비티수(C) ) / 유효사이클타임(D) 
             */

            if ( !is_loading )
            {
                if ( txt_planTime.Text != txt_planTime.Properties.NullText )
                {
                    int validCavity = Convert.ToInt32(txt_cavityValid.Text.Substring(0, 2));

                    string originalTime = txt_planTime.Text;
                    string decimalTime = Regex.Replace(originalTime, @"\D", "");

                    int hour = Convert.ToInt32(decimalTime.Substring(0, 2));
                    int min = Convert.ToInt32(decimalTime.Substring(decimalTime.Length -2));

                    int planQuantity = (hour * 3600 + min * 60) * validCavity / (int)(txt_cycleValid.Value);
                    txt_planQT.Value = planQuantity;

                    is_ValueChanged = true;
                    btn_save.Enabled = true;
                }
            }
        }

        private void validTimeCalculate(object sender, EventArgs e)
        {
            /*
             * 계획시간(A) = ( 계획수량(B) / 유효캐비티수(C) ) * 유효사이클타임(D) 
             */

            if ( !is_loading )
            {
                decimal planTime = 0;

                decimal validCavity = Convert.ToDecimal(txt_cavityValid.Text.Substring(0, 2));

                if ( validCavity != 0 )
                {

                    planTime = (txt_planQT.Value / validCavity) * txt_cycleValid.Value;
                    
                    decimal time = Math.Round((planTime / 3600), 2);

                    if ( time > 24 )
                    {
                        //작업시간이 24시간이 넘을 경우 경고메세지 출력
                        MessageBox.Show("작업 시간이 제한된 범위를 초과합니다.\n\r(최대 24시간)", "작업시간 설정 에러");

                        txt_planQT.Value = 0;
                        txt_planTime.EditValue = txt_planTime.Properties.NullText;
                        txt_planTimeDecimal.Value = 0;

                    }
                    else
                    {

                        int hh = Convert.ToInt32(decimal.Truncate(time));
                        string hour = Convert.ToString(hh);
                        if ( (hh >= 0) && (hh < 10) )
                            hour = string.Format("{0:00}", hh);

                        int mm = Convert.ToInt32(Math.Round((time - hh) * 60));
                        string min = Convert.ToString(mm);
                        if ( (mm >= 0) && (mm < 10) )
                            min = string.Format("{0:00}", mm);

                        txt_planTime.EditValue = hour + min;
                        txt_planTimeDecimal.EditValue = Math.Round(time, 2);
                    }

                    is_ValueChanged = true;
                    btn_save.Enabled = true;
                }
            }
        }


        private decimal stringToDecimal(string time)
        {
            try
            {
                string timeDecimal = Regex.Replace(time, @"\D", "");
                string hour = timeDecimal.Substring(0, 2);
                string min = timeDecimal.Substring(timeDecimal.Length - 2);
                int hh = Convert.ToInt32(hour);
                decimal mm =  Math.Round((Convert.ToDecimal(min) / 60), 2) ;

                return (hh + mm);
            }
            catch 
            {
                return 0;
            }
        }
        #endregion

        private void pic_stdPaper_DoubleClick(object sender, EventArgs e)
        {
            if ( ((PictureEdit)sender).Image == null )
            {
                MessageBox.Show("사진이 존재하지 않습니다.", "에러");
            }
            else
            {
                frm_imageContainer imgContainer;
                int width = ((PictureEdit)sender).Image.Width;
                int height = ((PictureEdit)sender).Image.Height;

                string stdPaperURL = Convert.ToString(pic_stdPaper.Tag);
                string description = txt_jpName.Text + " 작업표준서";
                imgContainer = new frm_imageContainer(width, height, stdPaperURL, description);

                imgContainer.Show();
            }
        }









    }//class
}//namespace
