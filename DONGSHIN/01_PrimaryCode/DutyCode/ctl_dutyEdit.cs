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

namespace DONGSHIN
{
    public partial class ctl_dutyEdit : UserControl
    {

        ctl_dutyCode dutyCode;

        public ctl_dutyEdit(ctl_dutyCode dutyCode)
        {
            InitializeComponent();

            this.dutyCode = dutyCode;
            commonFX.setThisLanguage(this);
        }

        private bool is_add;
        private bool is_read = false;
        private bool is_ValueChanged = false;
        private bool is_loading = false;

        private string dutyID = "";

        private SqlCommand cmd;



        private void ctl_dutyEdit_Load(object sender, EventArgs e)
        {
            is_loading = true;


            if ( (is_add == false) || (is_read == true) ) //수정 또는 단순조회
            {
                if ( is_read == true )
                    readOnlyMode(true);

                commonReturn Return = new commonReturn();
                Return = fx_dutyCode.findByID(commonVar.DBconn, dutyID);


                if ( Return.Message == "" )
                {
                    DataRow tempRow = Return.Dataset.Tables[0].Rows[0];
                    txt_id.Text = Convert.ToString(tempRow["gm_id"]);
                    txt_name.Text = Convert.ToString(tempRow["gm_name"]);
                    txt_startTime.EditValue = Convert.ToDateTime(tempRow["start_time"]);
                    txt_endTime.EditValue = Convert.ToDateTime(tempRow["end_time"]);
                    txt_timeSpan.EditValue = Convert.ToString(tempRow["gm_time"]);
                    txt_timeDecimal.Value = stringToDecimal(tempRow["gm_span"].ToString());
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

        private void ctl_dutyEdit_VisibleChanged(object sender, EventArgs e)
        {
            if ( this.Visible == true )
                this.ctl_dutyEdit_Load(this, e);
            else
                dutyCode.editCompleted();
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

        #region 시간계산에 필요한 함수

        private decimal stringToDecimal(string time)
        {
            try
            {
                string timeDecimal = Regex.Replace(time, @"\D", "");
                string hour = timeDecimal.Substring(0, 2);
                string min = timeDecimal.Substring(timeDecimal.Length - 2);
                int hh = Convert.ToInt32(hour);
                decimal mm = Math.Round((Convert.ToDecimal(min) / 60), 2);

                return (hh + mm);
            }
            catch
            {
                return 0;
            }
        }

        #endregion

        #region 근무코드 연결에 필요한 함수

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
                txt_startTime.ReadOnly = true;
                txt_endTime.ReadOnly = true;
                txt_timeSpan.ReadOnly = true;
            }
            else
            {
                is_read = false;

                if ( is_add )
                    txt_id.ReadOnly = false;
                else
                    txt_id.ReadOnly = true;

                txt_name.ReadOnly = false;
                txt_startTime.ReadOnly = false;
                txt_endTime.ReadOnly = false;
                txt_timeSpan.ReadOnly = false;
            }
        }



        public void setID(string parentID) //공통코드 받아옴
        {
            dutyID = parentID;
        }




        #endregion


        #region Edit내부에 필요한 함수

        public void clear()
        {
            txt_id.Text = "";
            txt_name.Text = "";
            txt_startTime.EditValue = DateTime.Today;
            txt_endTime.EditValue = DateTime.Today;
            txt_timeSpan.EditValue = 0;
            txt_timeDecimal.Value = 0;
        }

        private void chkValueChanged(object sender, EventArgs e) //컨트롤 내 값의 변화를 감지
       {
            if ( !is_loading )
                is_ValueChanged = true;

            btn_save.Enabled = true;
        }

        private bool chkDuplicate() //중복항목 체크함수
        {
            commonReturn Return = new commonReturn();
            Return = fx_dutyCode.findByID(commonVar.DBconn, txt_id.Text);

            if ( Return.Dataset.Tables[0].Rows.Count > 0 )
                return false;
            else
                return true;
        }

        private bool save() //저장버튼 누를 때 호출되는 함수
        {

            if ( txt_id.Text.Length == 0 )
            {
                MessageBox.Show("근무번호를 입력하세요.", "주의");
                return false;
            }
            else
            {
                if ( (is_add == true) && (chkDuplicate() == false) )
                {
                    MessageBox.Show("근무번호가 중복되었습니다.", "주의");
                    return false;
                }

                cmd = new SqlCommand();


                cmd.Parameters.Add("@gm_id", SqlDbType.Int).Value = Convert.ToInt32(txt_id.Text.Trim());
                cmd.Parameters.Add("@gm_name", SqlDbType.NVarChar, 20).Value = txt_name.Text.Trim();
                cmd.Parameters.Add("@start_time", SqlDbType.VarChar, 5).Value = string.Format("{0:HH:mm}", txt_startTime.EditValue);
                cmd.Parameters.Add("@end_time", SqlDbType.VarChar, 5).Value = string.Format("{0:HH:mm}", txt_endTime.EditValue);
                cmd.Parameters.Add("@gm_time", SqlDbType.VarChar, 10).Value = txt_timeSpan.Text.Trim();
                cmd.Parameters.Add("@gm_span", SqlDbType.VarChar, 10).Value = txt_timeDecimal.Value;

                commonReturn Return = new commonReturn();
                Return = fx_dutyCode.write(commonVar.DBconn, is_add, cmd);

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

        #endregion


        #endregion

        private void chk_overtime_CheckedChanged(object sender, EventArgs e)
        {
            if ( Convert.ToString(txt_timeSpan.EditValue) != "00:00:00" )
            {
                if ( chk_overtime.Checked )
                    txt_timeDecimal.Value = stringToDecimal(txt_timeSpan.Text) * Convert.ToDecimal(1.5);
                else
                    txt_timeDecimal.Value = stringToDecimal(txt_timeSpan.Text);
            }
        }

        private void txt_endTime_TextChanged(object sender, EventArgs e)
        {
            TimeSpan span;
            DateTime t1 = Convert.ToDateTime(txt_startTime.EditValue);
            DateTime t2 = Convert.ToDateTime(txt_endTime.EditValue);

            if ( t1 > t2 )
                span = t2.AddHours(24) - t1;
            else
                span = t2 - t1;

            txt_timeSpan.EditValue = span;

            if ( chk_overtime.Checked )
                txt_timeDecimal.Value = stringToDecimal(txt_timeSpan.Text) * Convert.ToDecimal(1.5);
            else
                txt_timeDecimal.Value = stringToDecimal(txt_timeSpan.Text);
        }



    }//class
}//namespace
