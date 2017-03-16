using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using System.Net;
using System.IO;

namespace DONGSHIN
{
    public partial class ctl_moldEdit : UserControl
    {
        ctl_moldCode moldCode;
        public ctl_moldEdit(ctl_moldCode moldCode)
        {
            InitializeComponent();
            this.moldCode = moldCode;
            commonFX.setThisLanguage(this);
        }

        private DataRow targetRow; //수정할때 사용

        private bool is_ValueChanged = false;
        private bool is_add;
        private bool is_read = false;
        private bool is_loading = false;

        private string moldID = "";

        private string imgDBpath = "http://drumshow1.cdn3.cafe24.com/DONGSHIN/";

        private SqlCommand cmd;


        public class productImage
        {
            public PictureEdit ctl { get; set; }
            public string registeredImgName { get; set; }
            public string imgLocalPath { get; set; }
            public string downloadedImgPath { get; set; }
            public string downloadedImgName { get; set; }
            public string parameter { get; set; }
            public productImage() { }
        }

        productImage img1 = new productImage();
        productImage img2 = new productImage();
        productImage img3 = new productImage();
        productImage img4 = new productImage();

        private void ctl_moldEdit_Load(object sender, EventArgs e)
        {

            is_loading = true;

            commonFX.commonRef("국가구분", cbx_nation);
            commonFX.commonRef("통화", cbx_money);


            //이미지컨트롤 초기화
            img1.ctl = pic_img1;
            img1.downloadedImgName = "";
            img1.downloadedImgPath = "";
            img1.registeredImgName = "";
            img1.imgLocalPath = "";
            img1.parameter = "";

            img2.ctl = pic_img2;
            img2.downloadedImgName = "";
            img2.downloadedImgPath = "";
            img2.registeredImgName = "";
            img2.imgLocalPath = "";
            img2.parameter = "";

            img3.ctl = pic_img3;
            img3.downloadedImgName = "";
            img3.downloadedImgPath = "";
            img3.registeredImgName = "";
            img3.imgLocalPath = "";
            img3.parameter = "";

            img4.ctl = pic_img4;
            img4.downloadedImgName = "";
            img4.downloadedImgPath = "";
            img4.registeredImgName = "";
            img4.imgLocalPath = "";
            img4.parameter = "";


            if ( (is_add == false) || (is_read == true) ) //수정 또는 단순조회
            {
                txt_id.ReadOnly = true;

                if ( is_read == true )
                    readOnlyMode(true);

                commonReturn Return = new commonReturn();
                Return = fx_moldCode.findByID(commonVar.DBconn, moldID);


                if ( Return.Message == "" )
                {
                    DataRow tempRow = Return.Dataset.Tables[0].Rows[0];

                    //기본정보

                    txt_id.Text = Convert.ToString(tempRow["gh_id"]);
                    txt_model.Text = Convert.ToString(tempRow["model"]);
                    txt_name.Text = Convert.ToString(tempRow["gh_name"]);
                    txt_num.Text = Convert.ToString(tempRow["gh_num"]);
                    cbx_nation.Text = Convert.ToString(tempRow["nation"]);
                    cbx_money.Text = Convert.ToString(tempRow["currency"]);
                    cbx_moldGbn.Text = Convert.ToString(tempRow["gh_gbn"]);
                    cbx_jjGbn.Text = Convert.ToString(tempRow["jj_gbn"]);
                    cbx_goal.Text = Convert.ToString(tempRow["jj_goal"]);
                    txt_machine.Text = Convert.ToString(tempRow["MACHINE_NAME"]);
                    txt_machine.Tag = Convert.ToString(tempRow["MACHINE_CODE"]);
                    cbx_use.Text = Convert.ToString(tempRow["use_chk"]);
                    txt_memo.Text = Convert.ToString(tempRow["memo"]);

                    txt_baljuNum.Text = Convert.ToString(tempRow["balju_num"]);
                    txt_baljuBiz.Text = Convert.ToString(tempRow["balju_name"]);
                    txt_baljuBiz.Tag = Convert.ToString(tempRow["balju_id"]);
                    txt_buy.Text = Convert.ToString(tempRow["buy_name"]);
                    txt_buy.Tag = Convert.ToString(tempRow["buy_id"]);
                    txt_buyDD.Text = Convert.ToString(tempRow["buy_dd"]);
                    txt_design1.Text = Convert.ToString(tempRow["design_dd1"]);
                    txt_design2.Text = Convert.ToString(tempRow["design_dd2"]);
                    txt_jejak.Text = Convert.ToString(tempRow["jejak_name"]);
                    txt_jejak.Tag = Convert.ToString(tempRow["jejak_id"]);
                    txt_jjDD1.Text = Convert.ToString(tempRow["jj_dd1"]);
                    txt_jjDD2.Text = Convert.ToString(tempRow["jj_dd2"]);
                    txt_yangsanBiz.Text = Convert.ToString(tempRow["yangsan_name"]);
                    txt_yangsanBiz.Tag = Convert.ToString(tempRow["yangsan_id"]);
                    txt_wonsuju.Text = Convert.ToString(tempRow["wonsuju_name"]);
                    txt_wonsuju.Tag = Convert.ToString(tempRow["wonsuju_id"]);
                    txt_where.Text = Convert.ToString(tempRow["where_name"]);
                    txt_where.Tag = Convert.ToString(tempRow["where_id"]);

                    //관리 정보
                    txt_write.Text = Convert.ToString(tempRow["wr_date"]);
                    txt_fix.Text = Convert.ToString(tempRow["fix_date"]);
                    txt_nego.Text = Convert.ToString(tempRow["nego_date"]);
                    txt_t0.Text = Convert.ToString(tempRow["t0_date"]);
                    txt_t1.Text = Convert.ToString(tempRow["t1_date"]);
                    txt_initDate.Text = Convert.ToString(tempRow["init_date"]);
                    txt_okay.Text = Convert.ToString(tempRow["okay_date"]);
                    txt_out.Text= Convert.ToString(tempRow["out_date"]);
                    txt_ship.Text = Convert.ToString(tempRow["ship_date"]);
                    txt_arrive.Text = Convert.ToString(tempRow["arrive_date"]);
                    txt_ysDate.Text = Convert.ToString(tempRow["ys_date"]);
                    txt_dump.Text = Convert.ToString(tempRow["dump_date"]);

                    txt_warranty.Value = Convert.ToInt32(tempRow["warranty"]);
                    txt_limit.Value = Convert.ToInt32(tempRow["limit"]);
                    txt_location.Text = Convert.ToString(tempRow["location"]);
                    txt_initShot.Value = Convert.ToInt32(tempRow["init_shot"]);
                    txt_accum.Value = Convert.ToInt32(tempRow["accumulated"]);
                    txt_specFreq.Value = Convert.ToInt32(tempRow["spec_freq"]);
                    txt_errFreq.Value = Convert.ToInt32(tempRow["error_freq"]);
                    txt_blueprintFreq.Value = Convert.ToInt32(tempRow["blueprint_freq"]);
                    txt_sampleFreq.Value = Convert.ToInt32(tempRow["sample_freq"]);

                    txt_chkShot.Value = Convert.ToInt32(tempRow["chk_shot"]);
                    txt_chkMon.Value = Convert.ToInt32(tempRow["chk_month"]);
                    txt_finalShot.Value = Convert.ToInt32(tempRow["chk_final_shot"]);
                    txt_chkDate.Text = Convert.ToString(tempRow["chk_final_date"]);
                    txt_chkNum.Value = Convert.ToInt32(tempRow["chk_freq"]);


                    //사양
                    txt_auth.Text = Convert.ToString(tempRow["auth_num"]);
                    txt_size.Text = Convert.ToString(tempRow["size"]);
                    txt_weight.Value = Convert.ToDecimal(tempRow["weight"]);
                    txt_spec.Text = Convert.ToString(tempRow["spec"]);
                    txt_cycle.Value = Convert.ToDecimal(tempRow["cycle_t"]);
                    txt_cavity.Text = Convert.ToString(tempRow["cavity"]);
                    cbx_gate.Text = Convert.ToString(tempRow["gate_type"]);
                    cbx_runnerEject.Text = Convert.ToString(tempRow["runner_eject"]);
                    cbx_jpEject.Text = Convert.ToString(tempRow["jp_eject"]);
                    cbx_machineType.Text = Convert.ToString(tempRow["machine_type"]);
                    cbx_inject.Text = Convert.ToString(tempRow["inject_type"]);
                    txt_shrink.Text = Convert.ToString(tempRow["shrink"]);

                    txt_ghMtrl.Text = Convert.ToString(tempRow["mtrl_gh"]);
                    txt_coreMtrl.Text = Convert.ToString(tempRow["mtrl_core"]);
                    txt_cavityMtrl.Text = Convert.ToString(tempRow["mtrl_cavity"]);
                    txt_upMtrl.Text = Convert.ToString(tempRow["mtrl_upSL"]);
                    txt_lowMtrl.Text = Convert.ToString(tempRow["mtrl_lowSL"]);
                    txt_angularMtrl.Text = Convert.ToString(tempRow["mtrl_angular"]);

                    txt_coreQ.Value = Convert.ToInt32(tempRow["qt_core"]);
                    txt_cavityQ.Value = Convert.ToInt32(tempRow["qt_cavity"]);
                    txt_upQ.Value = Convert.ToInt32(tempRow["qt_upSL"]);
                    txt_lowQ.Value = Convert.ToInt32(tempRow["qt_lowSL"]);
                    txt_angularQ.Value = Convert.ToInt32(tempRow["qt_angular"]);                    


                    //이미지로딩
                    productImage[] images = new productImage[4] { img1, img2, img3, img4 };
                    string[] paths = new string[4] { 
                                                                Convert.ToString(tempRow["gh_img1"]), 
                                                                Convert.ToString(tempRow["gh_img2"]),
                                                                Convert.ToString(tempRow["gh_img3"]),
                                                                Convert.ToString(tempRow["gh_img4"])
                                                                };
                    int i = 0;
                    foreach ( productImage myImage in images )
                    {
                        myImage.downloadedImgPath = paths[i];
                        if ( paths[i] == "no image" )
                        {
                            myImage.ctl.Image = null;
                            myImage.downloadedImgPath = "";
                        }
                        else
                        {
                            myImage.ctl.LoadAsync(paths[i]);
                            string filename = myImage.downloadedImgPath.Substring(myImage.downloadedImgPath.LastIndexOf("/") + 1);
                            myImage.downloadedImgName = filename;
                        }
                        i++;
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

        private void ctl_moldEdit_VisibleChanged(object sender, EventArgs e)
        {
            if ( this.Visible == true )
                this.ctl_moldEdit_Load(this, e);
            else
                moldCode.editCompleted();
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
                txt_model.ReadOnly = true;
                txt_name.ReadOnly = true;
                txt_num.ReadOnly = true;
                cbx_nation.ReadOnly=true;
                cbx_money.ReadOnly=true;
                cbx_moldGbn.ReadOnly=true;
                cbx_jjGbn.ReadOnly=true;
                cbx_goal.ReadOnly=true;
                txt_machine.ReadOnly=true;
                cbx_use.ReadOnly=true;
                txt_memo.ReadOnly=true;

                txt_baljuNum.ReadOnly=true;
                txt_baljuBiz.ReadOnly=true;
                txt_buy.ReadOnly=true;
                txt_buyDD.ReadOnly=true;
                txt_design1.ReadOnly=true;
                txt_design2.ReadOnly=true;
                txt_jejak.ReadOnly=true;
                txt_jjDD1.ReadOnly=true;
                txt_jjDD2.ReadOnly=true;
                txt_yangsanBiz.ReadOnly=true;
                txt_wonsuju.ReadOnly=true;
                txt_where.ReadOnly=true;

                txt_write.ReadOnly=true;
                txt_fix.ReadOnly=true;
                txt_nego.ReadOnly=true;
                txt_t0.ReadOnly=true;
                txt_t1.ReadOnly=true;
                txt_initDate.ReadOnly=true;
                txt_okay.ReadOnly=true;
                txt_out.ReadOnly=true;
                txt_ship.ReadOnly=true;
                txt_arrive.ReadOnly=true;
                txt_ysDate.ReadOnly=true;
                txt_dump.ReadOnly=true;

                txt_warranty.ReadOnly=true;
                txt_limit.ReadOnly=true;
                txt_location.ReadOnly=true;
                txt_initShot.ReadOnly=true;
                txt_accum.ReadOnly=true;
                txt_specFreq.ReadOnly=true;
                txt_errFreq.ReadOnly=true;
                txt_blueprintFreq.ReadOnly=true;
                txt_sampleFreq.ReadOnly=true;

                txt_chkShot.ReadOnly=true;
                txt_chkMon.ReadOnly=true;
                txt_chkDate.ReadOnly=true;
                txt_finalShot.ReadOnly=true;
                txt_chkNum.ReadOnly=true;

                txt_auth.ReadOnly=true;
                txt_spec.ReadOnly=true;
                txt_size.ReadOnly = true;
                txt_weight.ReadOnly=true;
                txt_cycle.ReadOnly=true;
                txt_cavity.ReadOnly=true;
                cbx_gate.ReadOnly=true;
                cbx_runnerEject.ReadOnly=true;
                cbx_jpEject.ReadOnly=true;
                cbx_machineType.ReadOnly=true;
                cbx_inject.ReadOnly=true;
                txt_shrink.ReadOnly=true;

                txt_ghMtrl.ReadOnly=true;
                txt_coreMtrl.ReadOnly=true;
                txt_coreQ.ReadOnly=true;
                txt_cavityMtrl.ReadOnly=true;
                txt_cavityQ.ReadOnly=true;
                txt_upMtrl.ReadOnly=true;
                txt_upQ.ReadOnly=true;
                txt_lowMtrl.ReadOnly=true;
                txt_lowQ.ReadOnly=true;
                txt_angularMtrl.ReadOnly=true;
                txt_angularQ.ReadOnly=true;

                pic_img1.ReadOnly = true;
                pic_img2.ReadOnly = true;
                pic_img3.ReadOnly = true;
                pic_img4.ReadOnly = true;

                btn_picAdd1.Enabled = false;
                btn_picDel1.Enabled = false;

                btn_picAdd2.Enabled = false;
                btn_picDel2.Enabled = false;

                btn_picAdd3.Enabled = false;
                btn_picDel3.Enabled = false;

                btn_picAdd4.Enabled = false;
                btn_picDel4.Enabled = false;
            }
            else
            {
                is_read = false;

                if ( is_add == true )
                    txt_id.ReadOnly = false;
                else
                    txt_id.ReadOnly = true;

                txt_model.ReadOnly = false;
                txt_name.ReadOnly = false;
                txt_num.ReadOnly = false;
                cbx_nation.ReadOnly = false;
                cbx_money.ReadOnly = false;
                cbx_moldGbn.ReadOnly = false;
                cbx_jjGbn.ReadOnly = false;
                cbx_goal.ReadOnly = false;
                txt_machine.ReadOnly = false;
                cbx_use.ReadOnly = false;
                txt_memo.ReadOnly = false;

                txt_baljuNum.ReadOnly = false;
                txt_baljuBiz.ReadOnly = false;
                txt_buy.ReadOnly = false;
                txt_buyDD.ReadOnly = false;
                txt_design1.ReadOnly = false;
                txt_design2.ReadOnly = false;
                txt_jejak.ReadOnly = false;
                txt_jjDD1.ReadOnly = false;
                txt_jjDD2.ReadOnly = false;
                txt_yangsanBiz.ReadOnly = false;
                txt_wonsuju.ReadOnly = false;
                txt_where.ReadOnly = false;

                txt_write.ReadOnly = false;
                txt_fix.ReadOnly = false;
                txt_nego.ReadOnly = false;
                txt_t0.ReadOnly = false;
                txt_t1.ReadOnly = false;
                txt_initDate.ReadOnly = false;
                txt_okay.ReadOnly = false;
                txt_out.ReadOnly = false;
                txt_ship.ReadOnly = false;
                txt_arrive.ReadOnly = false;
                txt_ysDate.ReadOnly = false;
                txt_dump.ReadOnly = false;

                txt_warranty.ReadOnly = false;
                txt_limit.ReadOnly = false;
                txt_location.ReadOnly = false;
                txt_initShot.ReadOnly = false;
                txt_accum.ReadOnly = false;
                txt_specFreq.ReadOnly = false;
                txt_errFreq.ReadOnly = false;
                txt_blueprintFreq.ReadOnly = false;
                txt_sampleFreq.ReadOnly = false;

                txt_chkShot.ReadOnly = false;
                txt_chkMon.ReadOnly = false;
                txt_chkDate.ReadOnly = false;
                txt_finalShot.ReadOnly = false;
                txt_chkNum.ReadOnly = false;

                txt_auth.ReadOnly = false;
                txt_spec.ReadOnly = false;
                txt_size.ReadOnly = false;
                txt_weight.ReadOnly = false;
                txt_cycle.ReadOnly = false;
                txt_cavity.ReadOnly = false;
                cbx_gate.ReadOnly = false;
                cbx_runnerEject.ReadOnly = false;
                cbx_jpEject.ReadOnly = false;
                cbx_machineType.ReadOnly = false;
                cbx_inject.ReadOnly = false;
                txt_shrink.ReadOnly = false;

                txt_ghMtrl.ReadOnly = false;
                txt_coreMtrl.ReadOnly = false;
                txt_coreQ.ReadOnly = false;
                txt_cavityMtrl.ReadOnly = false;
                txt_cavityQ.ReadOnly = false;
                txt_upMtrl.ReadOnly = false;
                txt_upQ.ReadOnly = false;
                txt_lowMtrl.ReadOnly = false;
                txt_lowQ.ReadOnly = false;
                txt_angularMtrl.ReadOnly = false;
                txt_angularQ.ReadOnly = false;

                pic_img1.ReadOnly = false;
                pic_img2.ReadOnly = false;
                pic_img3.ReadOnly = false;
                pic_img4.ReadOnly = false;

                btn_picAdd1.Enabled = true;
                btn_picDel1.Enabled = true;

                btn_picAdd2.Enabled = true;
                btn_picDel2.Enabled = true;

                btn_picAdd3.Enabled = true;
                btn_picDel3.Enabled = true;

                btn_picAdd4.Enabled = true;
                btn_picDel4.Enabled = true;
            }
        }


        public void setID(string parentID)
        {
            moldID = parentID;
        }

        public void setDataRow(ref DataRow parentRow)
        {
            targetRow = parentRow;
        }

        public void clear()
        {
            txt_id.Text = "";
            txt_model.Text = "";
            txt_name.Text = "";
            txt_num.Text = "";
            cbx_nation.SelectedIndex = 0;
            cbx_money.SelectedIndex = 0;
            cbx_moldGbn.SelectedIndex = 0;
            cbx_jjGbn.SelectedIndex = 0;
            cbx_goal.SelectedIndex = 0;
            txt_machine.Text = string.Empty;
            txt_machine.Tag = "";
            cbx_use.SelectedIndex = 0;
            txt_memo.Text = "";

            txt_baljuNum.Text = "";
            txt_baljuBiz.Text = "";
            txt_buy.Text = "";
            txt_buyDD.Text = "";
            txt_design1.Text = "";
            txt_design2.Text = "";
            txt_jejak.Text = "";
            txt_jjDD1.Text = "";
            txt_jjDD2.Text = "";
            txt_yangsanBiz.Text = "";
            txt_wonsuju.Text = "";
            txt_where.Text = "";

            txt_write.Text = "";
            txt_fix.Text = "";
            txt_nego.Text = "";
            txt_t0.Text = "";
            txt_t1.Text = "";
            txt_initDate.Text = "";
            txt_okay.Text = "";
            txt_out.Text = "";
            txt_ship.Text = "";
            txt_arrive.Text = "";
            txt_ysDate.Text = "";
            txt_dump.Text = "";

            txt_warranty.Value = 0;
            txt_limit.Value = 0;
            txt_location.Text = "";
            txt_initShot.Value = 0;
            txt_accum.Value = 0;
            txt_specFreq.Value = 0;
            txt_errFreq.Value = 0;
            txt_blueprintFreq.Value = 0;
            txt_sampleFreq.Value = 0;

            txt_chkShot.Value = 0;
            txt_chkMon.Value = 0;
            txt_chkDate.Text = "";
            txt_finalShot.Value = 0;
            txt_chkNum.Value = 0;

            txt_auth.Text = "";
            txt_size.Text = txt_size.Properties.NullText;
            txt_spec.Text = "";
            txt_weight.Value = 0;
            txt_cycle.Value = 0;
            txt_cavity.Text = txt_cavity.Properties.NullText;
            cbx_gate.SelectedIndex = 0;
            cbx_runnerEject.SelectedIndex = 0;
            cbx_jpEject.SelectedIndex = 0;
            cbx_machineType.SelectedIndex = 0;
            cbx_inject.SelectedIndex = 0;
            txt_shrink.Text = txt_shrink.Properties.NullText;

            txt_ghMtrl.Text = "";
            txt_coreMtrl.Text = "";
            txt_coreQ.Value = 0;
            txt_cavityMtrl.Text = "";
            txt_cavityQ.Value = 0;
            txt_upMtrl.Text = "";
            txt_upQ.Value = 0;
            txt_lowMtrl.Text = "";
            txt_lowQ.Value = 0;
            txt_angularMtrl.Text = "";
            txt_angularQ.Value = 0;


            pic_img1.Image = null;
            pic_img2.Image = null;
            pic_img3.Image = null;
            pic_img4.Image = null;

            //  img1.ctl.Image = pic_img1.Image;
            img1.downloadedImgName = "";
            img1.downloadedImgPath = "";
            img1.registeredImgName = "";
            img1.imgLocalPath = "";

            //  img2.ctl.Image = pic_img2.Image;
            img2.downloadedImgName = "";
            img2.downloadedImgPath = "";
            img2.registeredImgName = "";
            img2.imgLocalPath = "";

            //   img3.ctl.Image = pic_img3.Image;
            img3.downloadedImgName = "";
            img3.downloadedImgPath = "";
            img3.registeredImgName = "";
            img3.imgLocalPath = "";

            //  img4.ctl.Image = pic_img4.Image;
            img4.downloadedImgName = "";
            img4.downloadedImgPath = "";
            img4.registeredImgName = "";
            img4.imgLocalPath = "";


            is_ValueChanged = false;

            setModeFlag(false);
        } //모든 컨트롤 내용 초기화

        private bool chkDuplicate() //중복항목 체크함수
        {

            commonReturn Return = new commonReturn();
            Return = fx_moldCode.findByID(commonVar.DBconn, txt_id.Text);

            if ( Return.Dataset.Tables[0].Rows.Count > 0 )
                return false;
            else
                return true;
        }

        private bool save() //저장버튼 누를 때 호출되는 함수
        {

            if ( txt_id.Text.Length == 0 )
            {
                MessageBox.Show("금형코드를 입력하세요.", "주의");
                return false;
            }
            else if ( txt_name.Text.Length == 0 )
            {
                MessageBox.Show("금형이름을 입력하세요.", "주의");
                return false;
            }
            else if ( txt_num.Text.Length == 0 )
            {
                MessageBox.Show("금형번호를 입력하세요.", "주의");
                return false;
            }
            else if(txt_model.Text.Length == 0 )
            {
                MessageBox.Show("모델명을 입력하세요.", "주의");
                return false;
            }
            else
            {
                if ( (is_add == true) && (chkDuplicate() == false) )
                {
                    MessageBox.Show("금형코드가 중복되었습니다.", "주의");
                    return false;
                }

                cmd = new SqlCommand();

                cmd.Parameters.Clear();

              
                cmd.Parameters.Add("@gh_id", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_id.Text.Trim());
                cmd.Parameters.Add("@model", SqlDbType.NVarChar, 40).Value = Convert.ToString(txt_model.Text.Trim());
                cmd.Parameters.Add("@gh_name", SqlDbType.NVarChar, 40).Value = Convert.ToString(txt_name.Text.Trim());
                cmd.Parameters.Add("@gh_num", SqlDbType.NVarChar, 40).Value = Convert.ToString(txt_num.Text.Trim());
                cmd.Parameters.Add("@nation", SqlDbType.VarChar, 20).Value = Convert.ToString(cbx_nation.Text.Trim());
                cmd.Parameters.Add("@currency", SqlDbType.VarChar, 10).Value = Convert.ToString(cbx_money.Text.Trim());
                cmd.Parameters.Add("@gh_gbn", SqlDbType.NVarChar, 20).Value = Convert.ToString(cbx_moldGbn.Text.Trim());
                cmd.Parameters.Add("@jj_gbn", SqlDbType.NVarChar, 20).Value = Convert.ToString(cbx_jjGbn.Text.Trim());
                cmd.Parameters.Add("@jj_goal", SqlDbType.NVarChar, 20).Value = Convert.ToString(cbx_goal.Text.Trim());
                cmd.Parameters.Add("@MACHINE_CODE", SqlDbType.NVarChar, 20).Value = Convert.ToString(txt_machine.Tag);

                cmd.Parameters.Add("@buy_dd", SqlDbType.NVarChar, 20).Value = Convert.ToString(txt_buyDD.Text.Trim());
                cmd.Parameters.Add("@design_dd1", SqlDbType.NVarChar, 20).Value = Convert.ToString(txt_design1.Text.Trim());
                cmd.Parameters.Add("@design_dd2", SqlDbType.NVarChar, 20).Value = Convert.ToString(txt_design2.Text.Trim());
                cmd.Parameters.Add("@jj_dd1", SqlDbType.NVarChar, 20).Value = Convert.ToString(txt_jjDD1.Text.Trim());
                cmd.Parameters.Add("@jj_dd2", SqlDbType.NVarChar, 20).Value = Convert.ToString(txt_jjDD2.Text.Trim());
                cmd.Parameters.Add("@balju_num", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_baljuNum.Text.Trim());
                cmd.Parameters.Add("@balju_id", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_baljuBiz.Tag);
                cmd.Parameters.Add("@jejak_id", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_jejak.Tag);
                cmd.Parameters.Add("@yangsan_id", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_yangsanBiz.Tag);
                cmd.Parameters.Add("@wonsuju_id", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_wonsuju.Tag);
                cmd.Parameters.Add("@buy_id", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_buy.Tag);
                cmd.Parameters.Add("@where_id", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_where.Tag);

                cmd.Parameters.Add("@wr_date", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_write.Text);
                cmd.Parameters.Add("@fix_date", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_fix.Text);
                cmd.Parameters.Add("@nego_date", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_nego.Text);
                cmd.Parameters.Add("@t0_date", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_t0.Text);
                cmd.Parameters.Add("@t1_date", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_t1.Text);
                cmd.Parameters.Add("@init_date", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_initDate.Text);
                cmd.Parameters.Add("@okay_date", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_okay.Text);
                cmd.Parameters.Add("@out_date", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_out.Text);
                cmd.Parameters.Add("@ship_date", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_ship.Text);
                cmd.Parameters.Add("@arrive_date", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_arrive.Text);
                cmd.Parameters.Add("@ys_date", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_ysDate.Text);
                cmd.Parameters.Add("@dump_date", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_dump.Text);

                cmd.Parameters.Add("@location", SqlDbType.NVarChar, 50).Value = Convert.ToString(txt_location.Text);
                cmd.Parameters.Add("@chk_shot", SqlDbType.Int).Value = Convert.ToInt32(txt_chkShot.Value);
                cmd.Parameters.Add("@chk_month", SqlDbType.Int).Value = Convert.ToInt32(txt_chkMon.Value);
                cmd.Parameters.Add("@chk_freq", SqlDbType.Int).Value = Convert.ToInt32(txt_chkNum.Value);
                cmd.Parameters.Add("@chk_final_date", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_chkDate.Text);
                cmd.Parameters.Add("@chk_final_shot", SqlDbType.Int).Value = Convert.ToInt32(txt_finalShot.Value);

                cmd.Parameters.Add("@spec_freq", SqlDbType.Int).Value = Convert.ToInt32(txt_specFreq.Value);
                cmd.Parameters.Add("@error_freq", SqlDbType.Int).Value = Convert.ToInt32(txt_errFreq.Value);
                cmd.Parameters.Add("@blueprint_freq", SqlDbType.Int).Value = Convert.ToInt32(txt_blueprintFreq.Value);
                cmd.Parameters.Add("@sample_freq", SqlDbType.Int).Value = Convert.ToInt32(txt_sampleFreq.Value);
                cmd.Parameters.Add("@warranty", SqlDbType.Int).Value = Convert.ToInt32(txt_warranty.Value);
                cmd.Parameters.Add("@limit", SqlDbType.Int).Value = Convert.ToInt32(txt_limit.Value);
                cmd.Parameters.Add("@init_shot", SqlDbType.Int).Value = Convert.ToInt32(txt_initShot.Value);
                cmd.Parameters.Add("@accumulated", SqlDbType.Int).Value = Convert.ToInt32(txt_accum.Value);
                cmd.Parameters.Add("@auth_num", SqlDbType.VarChar, 30).Value = Convert.ToString(txt_auth.Text);
                cmd.Parameters.Add("@size", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_size.Text);
                cmd.Parameters.Add("@weight", SqlDbType.Money).Value = Convert.ToInt32(txt_weight.Value);
                cmd.Parameters.Add("@spec", SqlDbType.NVarChar, 40).Value = Convert.ToString(txt_spec.Text);

                cmd.Parameters.Add("@mtrl_gh", SqlDbType.NVarChar, 50).Value = Convert.ToString(txt_ghMtrl.Text);
                cmd.Parameters.Add("@cavity", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_cavity.Text);
                cmd.Parameters.Add("@mtrl_core", SqlDbType.NVarChar, 20).Value = Convert.ToString(txt_coreMtrl.Text);
                cmd.Parameters.Add("@mtrl_cavity", SqlDbType.NVarChar, 20).Value = Convert.ToString(txt_cavityMtrl.Text);
                cmd.Parameters.Add("@mtrl_upSL", SqlDbType.NVarChar, 20).Value = Convert.ToString(txt_upMtrl.Text);
                cmd.Parameters.Add("@mtrl_lowSL", SqlDbType.NVarChar, 20).Value = Convert.ToString(txt_lowMtrl.Text);
                cmd.Parameters.Add("@mtrl_angular", SqlDbType.NVarChar, 20).Value = Convert.ToString(txt_angularMtrl.Text);
                cmd.Parameters.Add("@qt_core", SqlDbType.Int).Value = Convert.ToInt32(txt_coreQ.Value);
                cmd.Parameters.Add("@qt_cavity", SqlDbType.Int).Value = Convert.ToInt32(txt_cavityQ.Value);
                cmd.Parameters.Add("@qt_upSL", SqlDbType.Int).Value = Convert.ToInt32(txt_upQ.Value);
                cmd.Parameters.Add("@qt_lowSL", SqlDbType.Int).Value = Convert.ToInt32(txt_lowQ.Value);
                cmd.Parameters.Add("@qt_angular", SqlDbType.Int).Value = Convert.ToInt32(txt_angularQ.Value);

                cmd.Parameters.Add("@shrink", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_shrink.Text);
                cmd.Parameters.Add("@gate_type", SqlDbType.NVarChar, 20).Value = Convert.ToString(cbx_gate.Text);
                cmd.Parameters.Add("@runner_eject", SqlDbType.NVarChar, 20).Value = Convert.ToString(cbx_runnerEject.Text);
                cmd.Parameters.Add("@jp_eject", SqlDbType.NVarChar, 20).Value = Convert.ToString(cbx_jpEject.Text);
                cmd.Parameters.Add("@inject_type", SqlDbType.NVarChar, 20).Value = Convert.ToString(cbx_inject.Text);
                cmd.Parameters.Add("@machine_type", SqlDbType.NVarChar, 20).Value = Convert.ToString(cbx_machineType.Text);
                cmd.Parameters.Add("@cycle_t", SqlDbType.NVarChar, 20).Value = Convert.ToString(txt_cycle.Text);

                cmd.Parameters.Add("@memo", SqlDbType.NVarChar, 200).Value = Convert.ToString(txt_memo.Text);
                cmd.Parameters.Add("@use_chk", SqlDbType.Char, 1).Value = Convert.ToString(cbx_use.Text.Trim());

               

                //---------------------------------------------------------------------------------이미지 저장
                string imgEmpty = "no image";
                productImage[] pictureBoxes = new productImage[4] { img1, img2, img3, img4 };
                foreach ( productImage singlePictureBox in pictureBoxes )
                {
                    if ( singlePictureBox.ctl.Image == null ) //컨트롤에 이미지 없을때 
                        singlePictureBox.parameter = imgEmpty;
                    else
                    {
                        //컨트롤에 이미지가 있을때 path읽어오기
                        //기존경로가 존재하고 수정되지 않았을경우에는 원래 경로 저장
                        if ( (singlePictureBox.downloadedImgPath != "") && (singlePictureBox.registeredImgName == "") )
                            singlePictureBox.parameter = singlePictureBox.downloadedImgPath;
                        else
                            singlePictureBox.parameter = imgDBpath + singlePictureBox.registeredImgName;
                    }

                    if ( !saveImg(singlePictureBox) )
                    {
                        MessageBox.Show("이미지 저장 실패", "단일 이미지 저장");
                        return false;
                    }
                }
                //--------------------------------------------------------------------------------스칼라변수 설정
                cmd.Parameters.Add("gh_img1", SqlDbType.VarChar, 250).Value = img1.parameter;
                cmd.Parameters.Add("gh_img2", SqlDbType.VarChar, 250).Value = img2.parameter;
                cmd.Parameters.Add("gh_img3", SqlDbType.VarChar, 250).Value = img3.parameter;
                cmd.Parameters.Add("gh_img4", SqlDbType.VarChar, 250).Value = img4.parameter;


                commonReturn Return = new commonReturn();
                Return = fx_moldCode.write(commonVar.DBconn, is_add, cmd);

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


        #region 이미지 업/다운로드/VIEW 관련 이벤트 및 함수


        private bool saveImg(productImage pic) //사진 업로드 (ftp)
        {
            try
            {
                if ( !((pic.parameter == "no image") || (pic.registeredImgName == "")) )
                {
                    FtpWebRequest req = (FtpWebRequest)WebRequest.Create(commonVar.userFTPServerIP + pic.registeredImgName);
                    req.UseBinary = true;
                    req.Method = WebRequestMethods.Ftp.UploadFile;
                    req.Credentials = new NetworkCredential(commonVar.userFTPID, commonVar.userFTPPassword);
                    byte[] fileData = File.ReadAllBytes(pic.imgLocalPath);
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
            string ctlName = ((SimpleButton)sender).Name;
            string filename = "";
            string local = "";
            PictureEdit pic = null;
            productImage singleImage = null;
            switch ( ctlName )
            {
                case "btn_picAdd1":
                    singleImage = img1;
                    pic = img1.ctl;
                    break;
                case "btn_picAdd2":
                    singleImage = img2;
                    pic = img2.ctl;
                    break;
                case "btn_picAdd3":
                    singleImage = img3;
                    pic = img3.ctl;
                    break;
                case "btn_picAdd4":
                    singleImage = img4;
                    pic = img4.ctl;
                    break;
            }

            if ( pic.Image != null )
            {
                MessageBox.Show("등록된 이미지가 있습니다. \n\r기존 이미지를 먼저 삭제 하세요.", "이미지 로드 에러");
            }
            else
            {
                pic.LoadImage();
                local = pic.GetLoadedImageLocation();
                filename = local.Substring(local.LastIndexOf("\\") + 1);

                singleImage.registeredImgName = filename;
                singleImage.imgLocalPath = local;

                chkValueChanged(this, e);
            }
        }

        private void btn_picDel_Click(object sender, EventArgs e)
        {
            string ctlName = ((SimpleButton)sender).Name;
            string imgName = "";
            PictureEdit pic = null;
            productImage singleImage = null;
            switch ( ctlName )
            {
                case "btn_picDel1":
                    pic = img1.ctl;
                    imgName = img1.downloadedImgName;
                    singleImage = img1;
                    break;
                case "btn_picDel2":
                    pic = img2.ctl;
                    imgName = img2.downloadedImgName;
                    singleImage = img2;
                    break;
                case "btn_picDel3":
                    pic = img3.ctl;
                    imgName = img3.downloadedImgName;
                    singleImage = img3;
                    break;
                case "btn_picDel4":
                    pic = img4.ctl;
                    imgName = img4.downloadedImgName;
                    singleImage = img4;
                    break;
            }

            if ( pic.Image == null )
            {
                MessageBox.Show("등록된 이미지가 없습니다. \n\r이미지를 먼저 등록 하세요.", "이미지 삭제 에러");
            }
            else
            {
                if ( (is_add == true) || (singleImage.downloadedImgPath == "") )
                {
                    pic.Image = null;
                }
                else
                {
                    FtpWebRequest req = (FtpWebRequest)WebRequest.Create(commonVar.userFTPServerIP + imgName);
                    req.Credentials = new NetworkCredential(commonVar.userFTPID, commonVar.userFTPPassword);
                    req.Method = WebRequestMethods.Ftp.DeleteFile;
                    FtpWebResponse response = (FtpWebResponse)req.GetResponse();
                    response.Close();
                    pic.Image = null;
                }

                singleImage.imgLocalPath = "";
                singleImage.registeredImgName = "";
                singleImage.downloadedImgPath = "";
                singleImage.downloadedImgName = "";

                chkValueChanged(this, e);
            }
        }


        private void img_DoubleClick(object sender, EventArgs e)
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

                string name = ((PictureEdit)sender).Name;
                string imgLocalPath = "";
                string downloadedImgPath = "";
                string description = "";

                switch ( name )
                {
                    case "pic_img1":
                        imgLocalPath = img1.imgLocalPath;
                        downloadedImgPath = img1.downloadedImgPath;
                        description = "금형전체";
                        break;
                    case "pic_img2":
                        imgLocalPath = img2.imgLocalPath;
                        downloadedImgPath = img2.downloadedImgPath;
                        description = "제품";
                        break;
                    case "pic_img3":
                        imgLocalPath = img3.imgLocalPath;
                        downloadedImgPath = img3.downloadedImgPath;
                        description = "상금형";
                        break;
                    case "pic_img4":
                        imgLocalPath = img4.imgLocalPath;
                        downloadedImgPath = img4.downloadedImgPath;
                        description = "하금형";
                        break;
                }
                if ( imgLocalPath != "" )
                    imgContainer = new frm_imageContainer(width, height, imgLocalPath, description);
                else
                    imgContainer = new frm_imageContainer(width, height, downloadedImgPath, description);

                imgContainer.ShowDialog();
            }
        }

        #endregion

        private void bizReference(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Image img = Properties.Resources.black_opacity;
            bgimg.Appearance.Image = commonFX.change_opacity(img, 0.5f);
            bgimg.Dock = DockStyle.Fill;
            bgimg.Visible = true;

            frm_bizRef bizRef = new frm_bizRef();
            string controlName = ((ButtonEdit)sender).Name;
            switch ( controlName ) 
            { 
                case "txt_baljuBiz":
                    bizRef.SendBizInfoEvent += new frm_bizRef.SendBizDataHandler(baljuInfo);
                    break;
                case "txt_buy":
                    bizRef.SendBizInfoEvent += new frm_bizRef.SendBizDataHandler(buyInfo);
                    break;
                case "txt_jejak":
                    bizRef.SendBizInfoEvent += new frm_bizRef.SendBizDataHandler(jejakInfo);
                    break;
                case "txt_yangsanBiz":
                    bizRef.SendBizInfoEvent += new frm_bizRef.SendBizDataHandler(yangsanInfo);
                    break;
                case "txt_wonsuju":
                    bizRef.SendBizInfoEvent += new frm_bizRef.SendBizDataHandler(wonsujuInfo);
                    break;
                case "txt_where":
                    bizRef.SendBizInfoEvent += new frm_bizRef.SendBizDataHandler(whereInfo);
                    break;
            }
            bizRef.ShowDialog();

            bgimg.Visible = false;
        }


        private void bizDDReference(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Image img = Properties.Resources.black_opacity;
            bgimg.Appearance.Image = commonFX.change_opacity(img, 0.5f);
            bgimg.Dock = DockStyle.Fill;
            bgimg.Visible = true;

            frm_empRef empRef = new frm_empRef();

            string controlName = ((ButtonEdit)sender).Name;

            switch ( controlName ) 
            {
                case "txt_jjDD1":
                    empRef.SendEmpInfoEvent += new frm_empRef.SendEmpDataHandler(jjDD1Info);
                    break;
                case "txt_jjDD2":
                    empRef.SendEmpInfoEvent += new frm_empRef.SendEmpDataHandler(jjDD2Info);
                    break;
                case "txt_design1":
                    empRef.SendEmpInfoEvent += new frm_empRef.SendEmpDataHandler(design1Info);
                    break;
                case "txt_design2":
                    empRef.SendEmpInfoEvent += new frm_empRef.SendEmpDataHandler(design2Info);
                    break;
                case "txt_buyDD":
                    empRef.SendEmpInfoEvent += new frm_empRef.SendEmpDataHandler(buyDDInfo);
                    break;
            }
            
            empRef.ShowDialog();
            
            bgimg.Visible = false;
        }

        #region 사원참조함수

        private void jjDD1Info(frm_empRef.empInformation selectedEmpInfo)
        {
            txt_jjDD1.Text = selectedEmpInfo.empName;
            txt_jjDD1.Tag = selectedEmpInfo.empID;
        }

        private void jjDD2Info(frm_empRef.empInformation selectedEmpInfo)
        {
            txt_jjDD2.Text = selectedEmpInfo.empName;
            txt_jjDD2.Tag = selectedEmpInfo.empID;
        }

        private void design1Info(frm_empRef.empInformation selectedEmpInfo)
        {
            txt_design1.Text = selectedEmpInfo.empName;
            txt_design1.Tag = selectedEmpInfo.empID;
        }

        private void design2Info(frm_empRef.empInformation selectedEmpInfo)
        {
            txt_design2.Text = selectedEmpInfo.empName;
            txt_design2.Tag = selectedEmpInfo.empID;
        }

        private void buyDDInfo(frm_empRef.empInformation selectedEmpInfo)
        {
            txt_buyDD.Text = selectedEmpInfo.empName;
            txt_buyDD.Tag = selectedEmpInfo.empID;
        }

        #endregion

        #region 업체참조함수

        private void baljuInfo(frm_bizRef.bizInformation selectedBizInfo)
        {
            txt_baljuBiz.Text = selectedBizInfo.bizName;
            txt_baljuBiz.Tag = selectedBizInfo.bizID;
        }
        private void buyInfo(frm_bizRef.bizInformation selectedBizInfo)
        {
            txt_buy.Text = selectedBizInfo.bizName;
            txt_buy.Tag = selectedBizInfo.bizID;
        }
        private void jejakInfo(frm_bizRef.bizInformation selectedBizInfo)
        {
            txt_jejak.Text = selectedBizInfo.bizName;
            txt_jejak.Tag = selectedBizInfo.bizID;
        }
        private void yangsanInfo(frm_bizRef.bizInformation selectedBizInfo)
        {
            txt_yangsanBiz.Text = selectedBizInfo.bizName;
            txt_yangsanBiz.Tag = selectedBizInfo.bizID;
        }
        private void wonsujuInfo(frm_bizRef.bizInformation selectedBizInfo)
        {
            txt_wonsuju.Text = selectedBizInfo.bizName;
            txt_wonsuju.Tag = selectedBizInfo.bizID;
        }
        private void whereInfo(frm_bizRef.bizInformation selectedBizInfo)
        {
            txt_where.Text = selectedBizInfo.bizName;
            txt_where.Tag = selectedBizInfo.bizID;
        }
        #endregion

        #region 설비참조

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

        private void setMachineInfo(frm_machineRef.machineInformation selectedMachineInfo)
        {
            txt_machine.Text = selectedMachineInfo.machineName;
            txt_machine.Tag = selectedMachineInfo.machineID;
        }

        #endregion


    }//class
}//namespcae
