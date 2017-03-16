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
    public partial class ctl_workPerformanceEdit : UserControl
    {
        ctl_workperformance workPerf;
        public ctl_workPerformanceEdit(ctl_workperformance workPerf)
        {
            InitializeComponent();
            this.workPerf = workPerf;
            commonFX.setThisLanguage(this);
        }

        private bool is_ValueChanged = false;
        private bool is_add;
        private bool is_read = false;
        private bool is_loading = false;
        private bool is_copy = false;

        private string workPerfID = "";
        private string workOrderID = "";
        private SqlCommand cmd;





        private void ctl_workPerformanceEdit_Load(object sender, EventArgs e)
        {
            is_loading = true;

            txt_startTime.EditValueChanged += new EventHandler(CalculateWorktime);
            txt_endTime.EditValueChanged += new EventHandler(CalculateWorktime);
            txt_nonopTime.EditValueChanged += new EventHandler(CalculateWorktime);

            txt_perf.EditValueChanged += new EventHandler(CalculatePerformance);
            txt_manuf.EditValueChanged += new EventHandler(CalculatePerformance);
            txt_init.EditValueChanged += new EventHandler(CalculatePerformance);
            txt_error.EditValueChanged += new EventHandler(CalculatePerformance);

            AddDutyType();
            ReadErrorCode();
            ReadNonOpCode();

            commonReturn Return = new commonReturn();

            if ( (is_add == false) || (is_read == true) ) //수정 또는 단순조회
            {

                if ( is_read == true )
                {
                    readOnlyMode(true);
                }
                
                Return = fx_workPerf.findByPerformanceID(commonVar.DBconn, workPerfID);

                if ( Return.Message == "" )
                {
                    DataRow tempRow = Return.Dataset.Tables[0].Rows[0];

                    //기본정보
                    txt_workdate.Text = Convert.ToString(tempRow["work_date"]);
                    txt_lot.Text = Convert.ToString(tempRow["lot_number"]);
                    txt_dept.Text = Convert.ToString(tempRow["bs_name"]);
                    txt_dept.Tag = Convert.ToString(tempRow["bs_id"]);
                    txt_emp.Text = Convert.ToString(tempRow["sw_name"]);
                    txt_emp.Tag = Convert.ToString(tempRow["sw_id"]);
                    cbx_duty.Text = Convert.ToString(tempRow["gm_name"]);
                    cbx_duty.Tag = Convert.ToString(tempRow["gm_id"]);
                    txt_gj.Text = Convert.ToString(tempRow["gj_gbn"]);

                    //제품정보
                    txt_jpID.Text = Convert.ToString(tempRow["jp_id"]);
                    txt_jpName.Text = Convert.ToString(tempRow["jp_name"]);
                    txt_jpNum.Text = Convert.ToString(tempRow["jp_num"]);
                    txt_jpCar.Text = Convert.ToString(tempRow["car"]);
                    txt_jpModel.Text = Convert.ToString(tempRow["model"]);
                    txt_jpMtrl.Text = Convert.ToString(tempRow["mtrl_num"]);
                    txt_resin.Text = Convert.ToString(tempRow["sj_name"]);


                    //생산내역
                    txt_machine.Text = Convert.ToString(tempRow["MACHINE_NAME"]);
                    txt_mold.Text = Convert.ToString(tempRow["gh_id"]);
                    txt_cavityValid.EditValue = Convert.ToString(tempRow["cavity"]);
                    txt_cycleValid.EditValue = Convert.ToDecimal(tempRow["cycle_t"]);
                    txt_planQT.EditValue = Convert.ToDecimal(tempRow["qt_plan"]);
                    txt_planTime.EditValue = Convert.ToString(tempRow["plan_t"]);
                    txt_perf.EditValue = Convert.ToInt32(tempRow["qt_total"]);
                    txt_manuf.EditValue = Convert.ToInt32(tempRow["qt_manuf"]);
                    txt_init.EditValue = Convert.ToInt32(tempRow["qt_init"]);
                    txt_error.EditValue = Convert.ToInt32(tempRow["qt_error"]);

                    txt_startTime.EditValue = Convert.ToDateTime(tempRow["start_time"]);
                    txt_endTime.EditValue = Convert.ToDateTime(tempRow["end_time"]);
                    txt_nonopTime.EditValue = Convert.ToDateTime(tempRow["bgd_time"]);
                    txt_worktime.EditValue = Convert.ToDateTime(tempRow["work_time"]);

                }
                else
                {
                    MessageBox.Show(Return.Message);
                }
            }
            if ( is_add == true ) //추가
            {
                clear();
                txt_workdate.Text = commonVar.getDate.ToShortDateString();
                Return = fx_workPerf.ReadWorkOrder(commonVar.DBconn, workOrderID);

                 if ( Return.Message == "" )
                 {
                     DataRow tempRow = Return.Dataset.Tables[0].Rows[0];

                     //기본정보
                     txt_gj.Text = Convert.ToString(tempRow["gj_gbn"]);

                     //제품정보
                     txt_jpID.Text = Convert.ToString(tempRow["jp_id"]);
                     txt_jpName.Text = Convert.ToString(tempRow["jp_name"]);
                     txt_jpNum.Text = Convert.ToString(tempRow["jp_num"]);
                     txt_jpCar.Text = Convert.ToString(tempRow["car"]);
                     txt_jpModel.Text = Convert.ToString(tempRow["model"]);
                     txt_jpMtrl.Text = Convert.ToString(tempRow["mtrl_num"]);
                     txt_resin.Text = Convert.ToString(tempRow["sj_name"]);


                     //생산내역
                     txt_machine.Text = Convert.ToString(tempRow["MACHINE_NAME"]);
                     txt_mold.Text = Convert.ToString(tempRow["gh_id"]);
                     txt_cavityValid.EditValue = Convert.ToString(tempRow["cavity"]);
                     txt_cycleValid.EditValue = Convert.ToDecimal(tempRow["cycle_t"]);
                     txt_planQT.EditValue = Convert.ToDecimal(tempRow["qt_plan"]);
                     txt_planTime.EditValue = Convert.ToString(tempRow["plan_t"]);

                 }
            }

            if ( is_add == true )
                btn_save.Enabled = true;
            else
                btn_save.Enabled = false;

            is_loading = false;
        }

        private void ctl_workPerformanceEdit_VisibleChanged(object sender, EventArgs e)
        {
            if ( this.Visible == true )
                this.ctl_workPerformanceEdit_Load(this, e);
            else
                workPerf.editCompleted();
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            if ( save() == true )
            {
                MessageBox.Show("등록에 성공했습니다.", "확인");
                is_ValueChanged = false;

                clear();
                this.Hide();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("등록에 실패했습니다.");
                return;
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

        public void setModeFlag(bool readFlag) //단순조회
        {
            is_read = readFlag;
        }

        public void readOnlyMode(bool flag) //단순조회시 컨트롤 속성 설정
        {
            if ( flag == true )
            {
                is_read = true;

                //기본정보
                txt_workdate.ReadOnly = true;
                txt_lot.ReadOnly = true;
                txt_dept.ReadOnly = true;
                txt_emp.ReadOnly = true;
                cbx_duty.ReadOnly = true;


                //생산내역
                txt_perf.ReadOnly = true;
                txt_manuf.ReadOnly = true;
                txt_init.ReadOnly = true;

                txt_startTime.ReadOnly = true;
                txt_endTime.ReadOnly = true;


                gridView1.OptionsBehavior.ReadOnly = true;
                gridView2.OptionsBehavior.ReadOnly = true;
            }
            else
            {
                is_read = false;

                if ( is_add == true )
                {
                    txt_workdate.ReadOnly = false;
                }
                else
                {
                    txt_workdate.ReadOnly = true;
                }

                //기본정보
                txt_lot.ReadOnly = false;
                txt_dept.ReadOnly = false;
                txt_emp.ReadOnly = false;
                cbx_duty.ReadOnly = false;


                //생산내역
                txt_perf.ReadOnly = false;
                txt_manuf.ReadOnly = false;
                txt_init.ReadOnly = false;

                txt_startTime.ReadOnly = false;
                txt_endTime.ReadOnly = false;


                gridView1.OptionsBehavior.ReadOnly = false;
                gridView2.OptionsBehavior.ReadOnly = false;
            }
        }


        public void setOrderID(string parentID)
        {
            workOrderID = parentID;
        }

        public void setPerformanceID(string parentID)
        {
            workPerfID = parentID;
        }





        public void clear()
        {
            //기본정보
            txt_workdate.Text = DateTime.Today.ToShortDateString();
            txt_lot.Text = "";
            txt_dept.Text = "";
            txt_dept.Tag = "";
            txt_emp.Text = "";
            txt_emp.Tag = "";
            cbx_duty.Text = "";
            cbx_duty.Tag = "";

            //제품정보
            txt_jpID.Text = "";
            txt_jpName.Text = "";
            txt_jpNum.Text = "";
            txt_jpCar.Text = "";
            txt_jpModel.Text = "";
            txt_jpMtrl.Text = "";
            txt_resin.Text = "";


            //생산내역
            txt_machine.Text = "";
            txt_mold.Text = "";
            txt_cavityValid.Text = "00/00";
            txt_cycleValid.EditValue = 0;
            txt_planQT.EditValue = 0;
            txt_planTime.Text = "00시간 00분";
            txt_perf.EditValue = 0;
            txt_manuf.EditValue = 0;
            txt_init.EditValue = 0;
            txt_error.EditValue = 0;

            txt_startTime.Text = "";
            txt_endTime.Text = "";
            txt_nonopTime.TimeSpan = TimeSpan.Zero;
            txt_worktime.TimeSpan = TimeSpan.Zero;
            txt_nonopTime.Text = "";
            txt_worktime.Text = "";

            is_ValueChanged = false;

            is_read = false;

            setModeFlag(is_read);
        } //모든 컨트롤 내용 초기화


        private bool save() //저장버튼 누를 때 호출되는 함수
        {
            try
            {                

                if ( is_add )
                    workPerfID = Regex.Replace(DateTime.Now.ToString() + DateTime.Now.Millisecond.ToString(), @"\D", "");

                DataTable ErrorDetailTable = (DataTable)gridControl1.DataSource;
                bool ErrorsCompleted = UpdateErrorValues(ErrorDetailTable, workPerfID);

                DataTable BreakTimeDetailTable = (DataTable)gridControl2.DataSource;
                bool NonOpCompleted = UpdateBreakTimes(BreakTimeDetailTable, workPerfID);

                if ( ErrorsCompleted && NonOpCompleted)
                {
                    cmd = new SqlCommand();
                    cmd.Parameters.Clear();

                    cmd.Parameters.Add("@siljeok_id", SqlDbType.VarChar, 25).Value = workPerfID;
                    cmd.Parameters.Add("@jisi_id", SqlDbType.VarChar, 25).Value = workOrderID;

                    cmd.Parameters.Add("@work_date", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_workdate.Text.Trim());
                    cmd.Parameters.Add("@bs_id", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_dept.Tag);
                    cmd.Parameters.Add("@sw_id", SqlDbType.VarChar, 10).Value = Convert.ToString(txt_emp.Tag);
                    cmd.Parameters.Add("@gm_id", SqlDbType.Int).Value = Convert.ToInt32(cbx_duty.Tag);
                    cmd.Parameters.Add("@lot_number", SqlDbType.VarChar, 30).Value = Convert.ToString(txt_lot.Text.Trim());

                    cmd.Parameters.Add("@start_time", SqlDbType.VarChar, 5).Value = string.Format("{0:HH:mm}", txt_startTime.EditValue);
                    cmd.Parameters.Add("@end_time", SqlDbType.VarChar, 5).Value = string.Format("{0:HH:mm}", txt_endTime.EditValue);
                    cmd.Parameters.Add("@work_time", SqlDbType.VarChar, 5).Value = txt_worktime.Text.Trim();
                    cmd.Parameters.Add("@bgd_time", SqlDbType.VarChar, 5).Value = txt_nonopTime.Text.Trim();

                    cmd.Parameters.Add("@qt_total", SqlDbType.Int).Value = Convert.ToInt32(txt_perf.EditValue);
                    cmd.Parameters.Add("@qt_manuf", SqlDbType.Int).Value = Convert.ToInt32(txt_manuf.EditValue);
                    cmd.Parameters.Add("@qt_init", SqlDbType.Int).Value = Convert.ToInt32(txt_init.EditValue);
                    cmd.Parameters.Add("@qt_error", SqlDbType.Int).Value = Convert.ToInt32(txt_error.EditValue);



                    if ( chk_workEnd.Checked )
                    {
                        cmd.Parameters.Add("@jisi_gbn", SqlDbType.NVarChar, 10).Value = "종료";
                        cmd.Parameters.Add("@is_work_started", SqlDbType.Char, 1).Value = "N";
                    }

                    commonReturn Return = new commonReturn();
                    Return = fx_workPerf.write(commonVar.DBconn, is_add, chk_workEnd.Checked, cmd);


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
                else 
                    return false;
            }
            catch ( Exception ex ) { MessageBox.Show(ex.Message); return false; }
        }


        #endregion

        #region 실적수량 / 근무별 작업시간 계산 



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


        private void CalculatePerformance(object sender, EventArgs e) //생산수량계산
        {
            if ( !is_loading )
            {
                int total = Convert.ToInt32(txt_perf.EditValue);
                int manuf = Convert.ToInt32(txt_manuf.EditValue);
                int init = Convert.ToInt32(txt_init.EditValue);
                int error = Convert.ToInt32(txt_error.EditValue);

                total = manuf - (init + error);

                txt_perf.EditValue = total;
            }
        }

        private void CalculateWorktime(object sender, EventArgs e) //작업시간계산
        {
            try
            {
                if ( !is_loading )
                {
                    TimeSpan worktime = TimeSpan.Zero;

                    DateTime start = Convert.ToDateTime(txt_startTime.EditValue);
                    DateTime end = Convert.ToDateTime(txt_endTime.EditValue);
                    TimeSpan nonOperation = (TimeSpan)txt_nonopTime.EditValue;

                    int nonOp_hour = nonOperation.Hours;
                    int nonOp_minute = nonOperation.Minutes;

                    DateTime breakTimes = start.AddHours(nonOp_hour);
                    breakTimes = breakTimes.AddMinutes(nonOp_minute);

                    if ( start > end )
                        worktime = end.AddHours(24) - (breakTimes);
                    else
                        worktime = end - (breakTimes);

                    txt_worktime.EditValue = worktime;
                }
            }
            catch { }
        }


        private DataTable readDutyCode() //근무코드 읽어옴
        {
            commonReturn Return = new commonReturn();

            Return = fx_dutyCode.read_all(commonVar.DBconn);

            if ( Return.Message == "" )
            {
                return Return.Dataset.Tables[0];
            }
            else
                return null;
        }

        private void AddDutyType() //근무이름을 콤보박스에 입력
        {
            DataTable DutyTable = readDutyCode();
            
            if ( DutyTable != null && cbx_duty.Properties.Items.Count == 0 )
            {
                for ( int i = 0 ; i < DutyTable.Rows.Count ; i++ )
                {
                    DataRow row = DutyTable.Rows[i];
                    cbx_duty.Properties.Items.Add(row["gm_name"].ToString());
                }
            }
        }

        private void cbx_duty_SelectedValueChanged(object sender, EventArgs e)
        {
            string value = cbx_duty.Text;

            DataTable DutyTable = readDutyCode();

            if ( DutyTable != null )
            {
                for ( int i = 0 ; i < DutyTable.Rows.Count ; i++ )
                {
                    DataRow row = DutyTable.Rows[i];
                    if ( value.Equals(row["gm_name"].ToString()) )
                    {
                        txt_startTime.EditValue = Convert.ToDateTime(row["start_time"]);
                        txt_endTime.EditValue = Convert.ToDateTime(row["end_time"]);
                        cbx_duty.Tag = Convert.ToString(row["gm_id"]);
                    }
                }
            }
        }
        #endregion


        private void chkValueChanged(object sender, EventArgs e) //컨트롤 내 값의 변화를 감지
        {
            if ( !is_loading )
                is_ValueChanged = true;

            btn_save.Enabled = true;
        }


        #region 버튼클릭 이벤트(참조)


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

        #endregion




        #region 불량내역

        private void ReadErrorCode()
        {
            commonReturn Return = new commonReturn();

            Return = fx_workPerf.ReadErrorDetails(commonVar.DBconn, is_add, workPerfID);

            if ( Return.Message == "" )
            {
                if ( Return.Dataset.Tables[0].Rows.Count == 0 )
                    Return = fx_workPerf.ReadErrorDetails(commonVar.DBconn, true, workPerfID);

                gridControl1.DataSource = Return.Dataset.Tables[0];
            }
            else
                MessageBox.Show(Return.Message, "DB 에러!");
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if ( e.Column.FieldName.Equals("qt_br") ) 
            {
                txt_error.Value += Convert.ToInt32(e.Value);
                is_ValueChanged = true;
            }
        }

        //private void AddErrorCount(SqlCommand cmd, DataTable table) 
        //{ 
        //    for(int i=0;i<table.Rows.Count;i++)
        //    {
        //        DataRow row = table.Rows[i];
        //        cmd.Parameters.Add("@br_id", SqlDbType.VarChar, 20).Value = Convert.ToString(row["br_id"]);
        //        cmd.Parameters.Add("@qt_br", SqlDbType.Int).Value = Convert.ToInt32(row["qt_br"]);                
        //    }
        //}

        private bool UpdateErrorValues(DataTable ErrorDetailTable, string WorkPerfID) 
        {
            string ErrorMesage = string.Empty;

            if ( !ErrorDetailTable.Columns.Contains("siljeok_id") )
            {
                DataColumn column = new DataColumn("siljeok_id", typeof(string));
                column.DefaultValue = workPerfID;
                ErrorDetailTable.Columns.Add(column);
            }

            ErrorMesage = fx_workPerf.SetErrorDetails(ErrorDetailTable, is_add, WorkPerfID);

            if ( ErrorMesage.Length > 0 )
                return false;
            else
                return true;
        }

        #endregion





        #region 비가동내역

        private void ReadNonOpCode()
        {
            commonReturn Return = new commonReturn();

            Return = fx_workPerf.ReadBreakTimeDetails(commonVar.DBconn, is_add, workPerfID);

            if ( Return.Message == "" )
            {
                if ( Return.Dataset.Tables[0].Rows.Count <= 0 )
                    Return = fx_workPerf.ReadBreakTimeDetails(commonVar.DBconn, true, workPerfID);

                gridControl2.DataSource = Return.Dataset.Tables[0];
            }
            else
                MessageBox.Show(Return.Message, "DB 에러!");
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            is_ValueChanged = true;

            if (e.Column.FieldName.Equals("end_time"))
            {
                try
                {
                    DataRow TimeRow = gridView2.GetDataRow(gridView2.FocusedRowHandle);

                    TimeSpan nonOperation = TimeSpan.Zero;

                    DateTime start = Convert.ToDateTime(TimeRow["start_time"]);
                    DateTime end = Convert.ToDateTime(TimeRow["end_time"]);

                    if ( start < end )
                        nonOperation = end - start;
                    else
                        nonOperation = end.AddHours(24) - start;

                    TimeRow["bgd_time"] = nonOperation;
                }
                catch { }
            }
        }

        private void gridView2_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            try
            {
                if ( e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start )
                    e.TotalValue = TimeSpan.Zero;
                if ( e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate )
                {
                    TimeSpan ts = TimeSpan.Parse(e.FieldValue.ToString());
                    e.TotalValue = ts + (TimeSpan)e.TotalValue;

                    txt_nonopTime.EditValue = e.TotalValue;
                }
            }
            catch { }
        }


        //private void AddBreakTimes(SqlCommand cmd, DataTable table)
        //{
        //    for ( int i = 0 ; i < table.Rows.Count ; i++ )
        //    {
        //        DataRow row = table.Rows[i];
        //        cmd.Parameters.Add("@bgd_id", SqlDbType.VarChar, 20).Value = Convert.ToString(row["bgd_id"]);
        //        cmd.Parameters.Add("@start_time", SqlDbType.VarChar, 5).Value = Convert.ToString(row["start_time"]);
        //        cmd.Parameters.Add("@end_time", SqlDbType.VarChar, 5).Value = Convert.ToString(row["end_time"]);
        //        cmd.Parameters.Add("@bgd_time", SqlDbType.VarChar, 5).Value = Convert.ToString(row["bgd_time"]);
        //    }
        //}

        private bool UpdateBreakTimes(DataTable BreakDetailTable, string WorkPerfID)
        {
            string ErrorMesage = string.Empty;

            if ( !BreakDetailTable.Columns.Contains("siljeok_id") )
            {
                DataColumn column = new DataColumn("siljeok_id", typeof(string));
                column.DefaultValue = workPerfID;
                BreakDetailTable.Columns.Add(column);
            }

            ErrorMesage = fx_workPerf.SetBreakTimeDetails(BreakDetailTable, is_add, WorkPerfID);

            if ( ErrorMesage.Length > 0 )
                return false;
            else
                return true;
        }

        #endregion





    }
}
