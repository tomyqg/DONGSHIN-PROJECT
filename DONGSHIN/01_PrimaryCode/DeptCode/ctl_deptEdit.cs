﻿using System;
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
    public partial class ctl_deptedit : UserControl
    {
        ctl_deptCode deptCode;
        public ctl_deptedit(ctl_deptCode deptCode)
        {
            InitializeComponent();
            this.deptCode = deptCode;
            commonFX.setThisLanguage(this);
        }

        private DataRow targetRow; //수정할때 사용

        private bool is_add;
        private bool is_read = false;
        private bool is_ValueChanged = false;
        private bool is_loading = false;

        private string deptID = "";

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
                else if ( nRet == DialogResult.No ) //No을 누르면
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

        #region 이벤트(클릭 제외)

        private void ctl_deptEdit_VisibleChanged(object sender, EventArgs e)
        {
            if ( this.Visible == true )
                this.ctl_deptEdit_Load(this, e);
            else
                deptCode.editCompleted();
        }

        private void ctl_deptEdit_Load(object sender, EventArgs e)
        {
            is_loading = true;

            if ( (is_add == false) || (is_read == true) ) //수정 또는 단순조회
            {
                txt_id.ReadOnly = true;

                if ( is_read == true )
                    readOnlyMode(true);

                commonReturn Return = new commonReturn();
                Return = fx_deptCode.findByID(commonVar.DBconn, deptID);


                if ( Return.Message == "" )
                {
                    DataRow tempRow = Return.Dataset.Tables[0].Rows[0];
                    txt_id.Text = Convert.ToString(tempRow["bs_id"]);
                    txt_name.Text = Convert.ToString(tempRow["bs_name"]);

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
                txt_id.ReadOnly = false;
                txt_id.Focus();
            }

            btn_save.Enabled = false;
            is_ValueChanged = false;
            is_loading = false;
        }

        #endregion

        #region 함수

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
                txt_id.ReadOnly = true;
                txt_name.ReadOnly = true;
                cbx_use.ReadOnly = true;
            }
            else
            {
                is_read = false;
                if ( is_add == true )
                    txt_id.ReadOnly = false;
                else
                    txt_id.ReadOnly = true;

                txt_name.ReadOnly = false;
                cbx_use.ReadOnly = false;
            }
        }

        public void setID(string parentID) //부서코드 받아옴
        {
            deptID = parentID;
        }

        public void setDataRow(ref DataRow parentRow) //datarow받아옴
        {
            targetRow = parentRow;
        }

        public void clear() //모든 컨트롤 내용 초기화
        {
            txt_id.Text = "";
            txt_name.Text = "";
            cbx_use.SelectedIndex = 0;
            is_ValueChanged = false;
        }

        private bool chkDuplicate()
        {

            commonReturn Return = new commonReturn();
            Return = fx_deptCode.findByID(commonVar.DBconn, txt_id.Text);

            if ( Return.Dataset.Tables[0].Rows.Count > 0 )
                return false;
            else
                return true;
        }

        private bool save() //저장버튼 누를 때 호출되는 함수
        {
            

            if ( txt_id.Text.Length == 0 )
            {
                MessageBox.Show("부서코드를 입력하세요.", "주의");
                return false;
            }
            else if ( txt_name.Text.Length == 0 )
            {
                MessageBox.Show("부서이름을 입력하세요.", "주의");
                return false;
            }
            else
            {
                if ( (is_add == true) && (chkDuplicate() == false) )
                {
                    MessageBox.Show("부서코드가 중복되었습니다.", "주의");
                    return false;
                }

                cmd = new SqlCommand();

                cmd.Parameters.Clear();
                cmd.Parameters.Add("@bs_id", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_id.Text.Trim());
                cmd.Parameters.Add("@bs_name", SqlDbType.NVarChar, 20).Value = Convert.ToString(txt_name.Text.Trim());
                cmd.Parameters.Add("@use_chk", SqlDbType.Char, 1).Value = Convert.ToString(cbx_use.Text.Trim());

                commonReturn Return = new commonReturn();
                Return = fx_deptCode.write(commonVar.DBconn, is_add, cmd);

                if ( Return.Message == "" )
                    return true;
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


    }//class
}//namespace