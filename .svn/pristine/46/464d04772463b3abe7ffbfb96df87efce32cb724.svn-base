using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DONGSHIN
{
    public partial class ctl_resinEdit : UserControl
    {
        ctl_resinCode resinCode;

        public ctl_resinEdit(ctl_resinCode resinCode)
        {
            InitializeComponent();
            this.resinCode = resinCode;
            commonFX.setThisLanguage(this);
        }

        private bool is_ValueChanged = false;
        private bool is_add;
        private bool is_read = false;
        private bool is_loading = false;

        private string resinID = "";

        private SqlCommand cmd;

        private void ctl_resinEdit_Load(object sender, EventArgs e)
        {
            is_loading = true;

            if ( (is_add == false) || (is_read == true) ) //수정 또는 단순조회
            {
                txt_id.ReadOnly = true;

                if ( is_read == true )
                    readOnlyMode(true);

                commonReturn Return = new commonReturn();
                Return = fx_resinCode.findByID(commonVar.DBconn, resinID);


                if ( Return.Message == "" )
                {
                    DataRow tempRow = Return.Dataset.Tables[0].Rows[0];
                    txt_id.Text = Convert.ToString(tempRow["sj_id"]);
                    
                    txt_name.Text =  Convert.ToString(tempRow["sj_name"]);
                    txt_maker.Text =  Convert.ToString(tempRow["maker"]);
                    txt_grade.Text =  Convert.ToString(tempRow["grade"]);

                    cbx_chk.Text = Convert.ToString(tempRow["chk_gbn"]);
                    txt_spec.Text =  Convert.ToString(tempRow["ms_spec"]);
                    cbx_colorpick.Color = Color.FromArgb(Convert.ToInt32(tempRow["sj_color"]));
                    txt_colorname.Text =  Convert.ToString(tempRow["color_name"]);

                    txt_loss.Value = Convert.ToDecimal(tempRow["loss_rate"]);
                    txt_optstock.Value = Convert.ToDecimal(tempRow["opt_stock"]);
                    txt_unit.Text =  Convert.ToString(tempRow["unit"]);
                    txt_unitprice.Value = Convert.ToDecimal(tempRow["unit_price"]);
                    txt_memo.Text =  Convert.ToString(tempRow["memo"]);

                    cbx_use.Text= Convert.ToString(tempRow["use_chk"]);


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

        }

        private void ctl_resinEdit_VisibleChanged(object sender, EventArgs e)
        {
            if ( this.Visible == true )
                this.ctl_resinEdit_Load(this, e);
            else
                resinCode.editCompleted();
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
                else if ( nRet == DialogResult.No )   //No을 누르면
                    is_ValueChanged = false;
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
                txt_name.ReadOnly = true;
                txt_maker.ReadOnly = true;
                txt_grade.ReadOnly = true;

                cbx_chk.ReadOnly = true;
                txt_spec.ReadOnly = true;
                cbx_colorpick.ReadOnly = true;
                txt_colorname.ReadOnly = true;

                txt_loss.ReadOnly = true;
                txt_optstock.ReadOnly = true;
                txt_unit.ReadOnly = true;
                txt_unitprice.ReadOnly = true;

                cbx_use.ReadOnly = true;
                txt_memo.ReadOnly = true;

            }
            else
            {
                is_read = false;

                if ( is_add == true )
                    txt_id.ReadOnly = false;
                else
                    txt_id.ReadOnly = true;

                txt_name.ReadOnly = false;
                txt_maker.ReadOnly = false;
                txt_grade.ReadOnly = false;

                cbx_chk.ReadOnly = false;
                txt_spec.ReadOnly = false;
                cbx_colorpick.ReadOnly = false;
                txt_colorname.ReadOnly = false;

                txt_loss.ReadOnly = false;
                txt_optstock.ReadOnly = false;
                txt_unit.ReadOnly = false;
                txt_unitprice.ReadOnly = false;

                cbx_use.ReadOnly = false;
                txt_memo.ReadOnly = false;


            }
        }


        public void setID(string parentID)
        {
            resinID = parentID;
        }


        public void clear()
        {
            txt_id.Text = "";
            txt_name.Text = "";
            txt_maker.Text = "";
            txt_grade.Text = "";

            cbx_chk.SelectedIndex = 0;
            txt_spec.Text = "";
            cbx_colorpick.EditValue = null;
            txt_colorname.Text = "";

            txt_loss.Value = 0;
            txt_optstock.Value = 0;
            txt_unit.Text = "Kg";
            txt_unitprice.Value = 0;

            cbx_use.SelectedIndex = 0;
            txt_memo.Text = "";

            is_ValueChanged = false;

            setModeFlag(false);
        } //모든 컨트롤 내용 초기화

        private bool chkDuplicate() //중복항목 체크함수
        {

            commonReturn Return = new commonReturn();
            Return = fx_resinCode.findByID(commonVar.DBconn, txt_id.Text);

            if ( Return.Dataset.Tables[0].Rows.Count > 0 )
                return false;
            else
                return true;
        }

        private bool save() //저장버튼 누를 때 호출되는 함수
        {

            if ( txt_id.Text.Length == 0 )
            {
                MessageBox.Show("수지코드를 입력하세요.", "주의");
                return false;
            }
            else if ( txt_name.Text.Length == 0 )
            {
                MessageBox.Show("수지이름을 입력하세요.", "주의");
                return false;
            }
            else
            {
                if ( (is_add == true) && (chkDuplicate() == false) )
                {
                    MessageBox.Show("수지코드가 중복되었습니다.", "주의");
                    return false;
                }

                cmd = new SqlCommand();
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@sj_id", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_id.Text.Trim());
                cmd.Parameters.Add("@sj_name", SqlDbType.NVarChar, 40).Value = Convert.ToString(txt_name.Text);
                cmd.Parameters.Add("@grade", SqlDbType.NVarChar, 40).Value = Convert.ToString(txt_grade.Text);
                cmd.Parameters.Add("@maker", SqlDbType.NVarChar, 50).Value = Convert.ToString(txt_maker.Text);

                cmd.Parameters.Add("@chk_gbn", SqlDbType.NVarChar, 10).Value = Convert.ToString(cbx_chk.Text);
                cmd.Parameters.Add("@ms_spec", SqlDbType.NVarChar, 50).Value = Convert.ToString(txt_spec.Text);
                cmd.Parameters.Add("@sj_color", SqlDbType.Int).Value = Convert.ToInt32(cbx_colorpick.Color.ToArgb());
                cmd.Parameters.Add("@color_name", SqlDbType.NVarChar, 20).Value = Convert.ToString(txt_colorname.Text);

                cmd.Parameters.Add("@opt_stock", SqlDbType.Money).Value = Convert.ToDecimal(txt_optstock.Value);
                cmd.Parameters.Add("@loss_rate", SqlDbType.Money).Value = Convert.ToDecimal(txt_loss.Value);

                cmd.Parameters.Add("@unit", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_unit.Text);
                cmd.Parameters.Add("@unit_price", SqlDbType.Money).Value = Convert.ToDecimal(txt_unitprice.Value);

                cmd.Parameters.Add("@memo", SqlDbType.NVarChar, 50).Value = Convert.ToString(txt_memo.Text);
                cmd.Parameters.Add("@use_chk", SqlDbType.Char, 1).Value = Convert.ToString(cbx_use.Text.Trim());
                

                commonReturn Return = new commonReturn();
                Return = fx_resinCode.writeResinRecord(commonVar.DBconn, is_add, cmd);

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

    }//class
}//namespace
