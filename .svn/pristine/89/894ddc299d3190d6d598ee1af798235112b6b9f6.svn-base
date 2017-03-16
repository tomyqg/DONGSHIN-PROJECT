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
    public partial class ctl_commonEdit : UserControl
    {
        ctl_commonCode commonCode;

        public ctl_commonEdit(ctl_commonCode commonCode)
        {
            InitializeComponent();
            this.commonCode = commonCode;
            commonFX.setThisLanguage(this);
        }

        private DataRow targetRow; //수정할때 사용

        private bool is_add;
        private bool is_read = false;
        private bool is_ValueChanged = false;
        private bool is_loading = false;

        private string commonID = "";
        private string newlyAddedID = ""; //새롭게 추가된 공통코드

        private SqlCommand cmd;





        private void ctl_commonEdit_VisibleChanged(object sender, EventArgs e)
        {
            if ( this.Visible == true )
                this.ctl_commonEdit_Load(this, e);
            else
                commonCode.editCompleted();
        }

        private void ctl_commonEdit_Load(object sender, EventArgs e)
        {
            is_loading = true;

            if ( (is_add == false) || (is_read == true) ) //수정 또는 단순조회
            {
                if ( is_read == true )
                    readOnlyMode(true);

                commonReturn Return = new commonReturn();
                Return = fx_commonCode.findByID(commonVar.DBconn, commonID);


                if ( Return.Message == "" )
                {
                    DataRow tempRow = Return.Dataset.Tables[0].Rows[0];
                    txt_grp.Text = Convert.ToString(tempRow["gt_grp"]);
                    txt_gtName.Text = Convert.ToString(tempRow["gt_name"]);

                    if ( Convert.ToString(tempRow["use_chk"]) == "Y" )
                        cbx_use.SelectedIndex = 0;
                    else
                        cbx_use.SelectedIndex = 1;
                }
                else
                {
                    MessageBox.Show(Return.Message);
                }
            }//if
            if ( is_add == true ) //추가
            {
                clear();
                txt_grp.ReadOnly = false;
                txt_grp.Focus();
            }

            btn_save.Enabled = false;
            is_ValueChanged = false;
            is_loading = false;
        }



        private void pic_back_Click(object sender, EventArgs e)
        {
            btn_close.PerformClick();
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






        #region 함수

        #region commonCode와의 연결에 필요한 함수

        public void setAddFlag(bool parentFlag) //추가-수정 구분할 때 사용하는 함수 (추가: is_add=true , 수정: is_add=false)
        {
            is_add = parentFlag;
        }

        public void setModeFlag(bool parentFlag2) //단순조회메뉴 활성화
        {
            is_read = parentFlag2;
        }

        public void readOnlyMode(bool flag) //더블클릭->단순조회시 사용
        {
            if ( flag == true )
            {
                is_read = true;
                txt_grp.ReadOnly = true;
                txt_gtName.ReadOnly = true;
                cbx_use.ReadOnly = true;
            }
            else
            {
                is_read = false;
                txt_grp.ReadOnly = false;
                txt_gtName.ReadOnly = false;
                cbx_use.ReadOnly = false;
            }
        }



        public void setID(string parentID) //공통코드 받아옴
        {
            commonID = parentID;
        }

        public void setDataRow(ref DataRow parentRow) //datarow받아옴
        {
            targetRow = parentRow;
        }



        #endregion


            #region commonEdit내부에 필요한 함수

            public void clear()
            {
                txt_grp.Text = "";
                txt_gtName.Text = "";
                cbx_use.SelectedIndex = 0;
            }

            private void chkValueChanged(object sender, EventArgs e) //컨트롤 내 값의 변화를 감지
            {
                if ( !is_loading )
                    is_ValueChanged = true;

                btn_save.Enabled = true;
            }

            private bool save() //저장버튼 누를 때 호출되는 함수
            {

                if ( txt_grp.Text.Length == 0 )
                {
                    MessageBox.Show("공통그룹을 입력하세요.", "주의");
                    return false;
                }
                else if ( txt_gtName.Text.Length == 0 )
                {
                    MessageBox.Show("공통이름을 입력하세요.", "주의");
                    return false;
                }
                else
                {
                    cmd = new SqlCommand();

                    if ( is_add == true )
                    {
                        cmd.Parameters.Add("@gt_id", SqlDbType.BigInt).Value = Convert.ToInt64(0);
                        cmd.Parameters["@gt_id"].Direction = ParameterDirection.InputOutput;
                    }
                    else
                        cmd.Parameters.Add("@gt_id", SqlDbType.VarChar, 20).Value = Convert.ToString(targetRow["gt_id"]);

                    cmd.Parameters.Add("@gt_grp", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_grp.Text.Trim());
                    cmd.Parameters.Add("@gt_name", SqlDbType.NVarChar, 20).Value = Convert.ToString(txt_gtName.Text.Trim());
                    cmd.Parameters.Add("@use_chk", SqlDbType.Char, 1).Value = Convert.ToString(cbx_use.Text.Trim());

                    commonReturn Return = new commonReturn();
                    Return = fx_commonCode.write(commonVar.DBconn, is_add, cmd);

                    if ( Return.Message == "" )
                    {
                        newlyAddedID = Convert.ToString(cmd.Parameters["@gt_id"].Value); //새롭게 추가된 공통코드에 대한 일련번호 저장
                        return true;
                    }                        
                    else
                    {
                        MessageBox.Show(Return.Message);
                        return false;
                    }
                }
            }

            #endregion


        #endregion





    }//class
}//namespace
