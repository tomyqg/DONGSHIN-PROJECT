using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace DONGSHIN
{
    public partial class ctl_bizEdit : UserControl
    {
        ctl_bizCode bizCode;
        public ctl_bizEdit(ctl_bizCode bizCode)
        {
            InitializeComponent();
            commonFX.setThisLanguage(this);
            this.bizCode = bizCode;
        }

        private DataRow targetRow; //수정할 때 사용

        private bool is_ValueChanged = false;
        private bool is_add;
        private bool is_read = false;
        private bool is_loading = false;

        private string bizID = "";

        private SqlCommand cmd;



        private void pic_back_Click(object sender, EventArgs e)
        {
            btn_close.PerformClick();
        }
        
        private void btn_close_Click(object sender, EventArgs e)
        {
            if ( is_ValueChanged == true )
            {
                DialogResult nRet;
                nRet = MessageBox.Show("변경된 자료가 있습니다. \n\r\n\r 저장할까요?", "주의", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if ( nRet == DialogResult.Yes )   //Yes을 누르면                
                    btn_save.PerformClick();
                else if ( nRet == DialogResult.No )
                {   //No을 누르면
                    is_ValueChanged = false;
                }
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



        private void ctl_bizEdit_Load(object sender, EventArgs e)
        {
            is_loading = true;

            commonFX.commonRef("국가구분", cbx_nation);
            commonFX.commonRef("통화", cbx_currency);

            if ( (is_add == false) || (is_read == true) ) //수정 또는 단순조회
            {
                txt_id.ReadOnly = true;

                if ( is_read == true )
                    readOnlyMode(true);

                commonReturn Return = new commonReturn();
                Return = fx_bizCode.findByID(commonVar.DBconn, bizID);


                if ( Return.Message == "" )
                {
                    DataRow tempRow = Return.Dataset.Tables[0].Rows[0];
                    cbx_gbn.Text = Convert.ToString(tempRow["ec_gbn"]);
                    cbx_grade.Text = Convert.ToString(tempRow["ec_grade"]);
                    cbx_nation.Text = Convert.ToString(tempRow["nation"]);
                    cbx_currency.Text = Convert.ToString(tempRow["currency"]);
                    txt_id.Text = Convert.ToString(tempRow["ec_id"]);
                    txt_ecName.Text = Convert.ToString(tempRow["ec_name"]);
                    cbx_taxApp.Text = Convert.ToString(tempRow["tax_app"]);
                    txt_taxName.Text = Convert.ToString(tempRow["tax_ec_name"]);
                    txt_ceo.Text = Convert.ToString(tempRow["ceo"]);
                    txt_serviceNum.Text = Convert.ToString(tempRow["service_num"]);
                    txt_type.Text = Convert.ToString(tempRow["ec_type"]);
                    txt_item.Text = Convert.ToString(tempRow["ec_item"]);
                    txt_tel.Text = Convert.ToString(tempRow["tel"]);
                    txt_fax.Text = Convert.ToString(tempRow["fax"]);
                    txt_etc.Text = Convert.ToString(tempRow["etc_tel"]);
                    txt_mail.Text = Convert.ToString(tempRow["mail"]);
                    txt_homepage.Text = Convert.ToString(tempRow["homepage"]);
                    txt_postNum.Text = Convert.ToString(tempRow["post_num"]);
                    txt_city.Text = Convert.ToString(tempRow["city"]);
                    txt_street.Text = Convert.ToString(tempRow["street"]);
                    cbx_tradeChk.Text = Convert.ToString(tempRow["trade_chk"]);
                    txt_tradeEnd.Text = Convert.ToString(tempRow["trade_end"]);
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
                txt_id.ReadOnly = false;
                cbx_gbn.Focus(); 
            }

           btn_save.Enabled = false;
           
            is_loading = false;
        }

        private void ctl_bizEdit_VisibleChanged(object sender, EventArgs e)
        {
            if ( this.Visible == true )
                this.ctl_bizEdit_Load(this, e);
            else
                bizCode.editCompleted();
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
                cbx_gbn.ReadOnly = true;
                cbx_grade.ReadOnly = true;
                cbx_nation.ReadOnly = true;
                cbx_currency.ReadOnly = true;
                cbx_taxApp.ReadOnly = true;
                txt_ecName.ReadOnly = true;
                txt_mail.ReadOnly = true;
                txt_taxName.ReadOnly = true;
                txt_ceo.ReadOnly = true;
                txt_serviceNum.ReadOnly = true;
                txt_memo.ReadOnly = true;
                txt_type.ReadOnly = true;
                txt_item.ReadOnly = true;
                txt_tel.ReadOnly = true;
                txt_fax.ReadOnly = true;
                txt_homepage.ReadOnly = true;
                txt_etc.ReadOnly = true;
                txt_postNum.ReadOnly = true;
                txt_city.ReadOnly = true;
                txt_street.ReadOnly = true;
                cbx_tradeChk.ReadOnly = true;
                txt_tradeEnd.ReadOnly = true;
            }
            else
            {
                is_read = false;

                if ( is_add == true )
                    txt_id.ReadOnly = false;
                else
                    txt_id.ReadOnly = true;

                cbx_gbn.ReadOnly = false;
                cbx_grade.ReadOnly = false;
                cbx_nation.ReadOnly = false;
                cbx_currency.ReadOnly = false;
                cbx_taxApp.ReadOnly = false;
                txt_ecName.ReadOnly = false;
                txt_mail.ReadOnly = false;
                txt_taxName.ReadOnly = false;
                txt_ceo.ReadOnly = false;
                txt_serviceNum.ReadOnly = false;
                txt_memo.ReadOnly = false;
                txt_type.ReadOnly = false;
                txt_item.ReadOnly=false;
                txt_tel.ReadOnly=false;
                txt_fax.ReadOnly = false;
                txt_homepage.ReadOnly = false;
                txt_etc.ReadOnly = false;
                txt_postNum.ReadOnly = false;
                txt_city.ReadOnly = false;
                txt_street.ReadOnly = false;
                cbx_tradeChk.ReadOnly = false;
                txt_tradeEnd.ReadOnly = false;

            }
        }



        public void setID(string parentID)
        {
            bizID = parentID;
        }

        public void setDataRow(ref DataRow parentRow)
        {
            targetRow = parentRow;
        }

        public void clear()
        {
            cbx_gbn.SelectedIndex = -1;
            cbx_grade.Text = "";
            cbx_nation.SelectedIndex = -1;
            cbx_currency.SelectedIndex = -1;
            cbx_taxApp.SelectedIndex = -1;

            txt_id.Text = "";
            txt_ecName.Text = "";
            txt_taxName.Text = "";
            txt_ceo.Text = "";
            txt_serviceNum.Text = "";
            txt_type.Text = "";
            txt_item.Text = "";
            txt_tel.Text = "";
            txt_mail.Text = "";
            txt_fax.Text = "";
            txt_homepage.Text = "";
            txt_etc.Text = "";
            txt_postNum.Text = "";
            txt_city.Text = "";
            txt_street.Text = "";

            cbx_tradeChk.SelectedIndex = 0;
            txt_tradeEnd.Text = "";
            txt_memo.Text = "";

            is_ValueChanged = false;

            setModeFlag(false);
        } //모든 컨트롤 내용 초기화

        private bool chkDuplicate() //중복항목 체크함수
        {
            commonReturn Return = new commonReturn();
            Return = fx_bizCode.findByID(commonVar.DBconn,txt_id.Text);

            if ( Return.Dataset.Tables[0].Rows.Count > 0 )
                return false;
            else
                return true;
        }

        private bool save() //저장버튼 누를 때 호출되는 함수
        {
            
            if ( txt_id.Text.Length == 0 )
            {
                MessageBox.Show("업체코드를 입력하세요.", "주의");
                return false;
            }
            else if ( txt_ecName.Text.Length == 0 )
            {
                MessageBox.Show("업체상호를 입력하세요.", "주의");
                return false;
            }
            else
            {
                if ( (is_add == true) && (chkDuplicate() == false) )
                {
                    MessageBox.Show("업체코드가 중복되었습니다.", "주의");
                    return false;
                }

                cmd = new SqlCommand();

                //업체구분 등급 국가 통화 업체코드 상호 세액적용 세금용상호 대표자 사업자번호 업태 종목 전번 팩스 기타 메일 홈피 우편번호 주소시군 주소번지 거래유무 거래중지사유 메모
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@ec_gbn", SqlDbType.NVarChar, 20).Value = Convert.ToString(cbx_gbn.Text.Trim());
                cmd.Parameters.Add("@ec_grade", SqlDbType.VarChar, 1).Value = Convert.ToString(cbx_grade.Text.Trim());
                cmd.Parameters.Add("@nation", SqlDbType.NVarChar, 20).Value = Convert.ToString(cbx_nation.Text.Trim());
                cmd.Parameters.Add("@currency", SqlDbType.NVarChar, 10).Value = Convert.ToString(cbx_currency.Text.Trim());
                cmd.Parameters.Add("@ec_id", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_id.Text.Trim());
                cmd.Parameters.Add("@ec_name", SqlDbType.NVarChar, 30).Value = Convert.ToString(txt_ecName.Text.Trim());
                cmd.Parameters.Add("@tax_app", SqlDbType.Char, 1).Value = Convert.ToString(cbx_taxApp.Text.Trim());
                cmd.Parameters.Add("@tax_ec_name", SqlDbType.NVarChar, 30).Value = Convert.ToString(txt_taxName.Text.Trim());
                cmd.Parameters.Add("@ceo", SqlDbType.NVarChar, 20).Value = Convert.ToString(txt_ceo.Text.Trim());
                cmd.Parameters.Add("@service_num", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_serviceNum.Text.Trim());
                cmd.Parameters.Add("@ec_type", SqlDbType.NVarChar, 30).Value = Convert.ToString(txt_type.Text.Trim());
                cmd.Parameters.Add("@ec_item", SqlDbType.NVarChar, 30).Value = Convert.ToString(txt_item.Text.Trim());
                cmd.Parameters.Add("@tel", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_tel.Text.Trim());
                cmd.Parameters.Add("@fax", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_fax.Text.Trim());
                cmd.Parameters.Add("@etc_tel", SqlDbType.VarChar, 20).Value = Convert.ToString(txt_etc.Text.Trim());
                cmd.Parameters.Add("@mail", SqlDbType.VarChar, 100).Value = Convert.ToString(txt_mail.Text.Trim());
                cmd.Parameters.Add("@homepage", SqlDbType.VarChar, 100).Value = Convert.ToString(txt_homepage.Text.Trim());
                cmd.Parameters.Add("@trade_chk", SqlDbType.Char, 1).Value = Convert.ToString(cbx_tradeChk.Text.Trim());
                cmd.Parameters.Add("@trade_end", SqlDbType.NVarChar, 100).Value = Convert.ToString(txt_tradeEnd.Text.Trim());
                cmd.Parameters.Add("@memo", SqlDbType.NVarChar, 500).Value = Convert.ToString(txt_memo.Text.Trim());
                cmd.Parameters.Add("@post_num", SqlDbType.VarChar, 7).Value = Convert.ToString(txt_postNum.Text.Trim());
                cmd.Parameters.Add("@city", SqlDbType.NVarChar, 100).Value = Convert.ToString(txt_city.Text.Trim());
                cmd.Parameters.Add("@street", SqlDbType.NVarChar, 100).Value = Convert.ToString(txt_street.Text.Trim());


                commonReturn Return = new commonReturn();
                Return = fx_bizCode.write_ec(commonVar.DBconn, is_add, cmd);

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







        #endregion

        private void txt_ecName_Leave(object sender, EventArgs e)
        {
            if ( txt_ecName.Text.Length > 0 && txt_taxName.Text.Length == 0 )
                txt_taxName.Text = txt_ecName.Text;
        }


    }//class
}//namespace
