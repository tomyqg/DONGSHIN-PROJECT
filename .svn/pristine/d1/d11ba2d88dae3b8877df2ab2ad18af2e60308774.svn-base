using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;

namespace DONGSHIN
{
    public partial class ctl_InjectionCondition : UserControl
    {
        public ctl_InjectionCondition()
        {
            InitializeComponent();
            commonFX.setThisLanguage(this);
        }

        public delegate void controlClosed();
        public event controlClosed controlClose;

        private bool timerStop = false;
        private bool isLoading = false;

        private void ctl_InjectionCondition_Load(object sender, EventArgs e)
        {
            isLoading = true;

            //userProvisioning("420000");
            InitDate();
            InitFirstMachine();
            ReadInjectStates();
            injUpdateTimer.Start();
            isLoading = false;
        }

        private void ctl_InjectionCondition_VisibleChanged(object sender, EventArgs e)
        {
            if ( this.Visible == true )
                ctl_InjectionCondition_Load(this, e);
        }
        

        private void btn_search_Click(object sender, EventArgs e)
        {
            ReadInjectStates();
        }

        private void btn_dataconvert_Click(object sender, EventArgs e)
        {
            if ( btn_dataconvert.Enabled == true )
            {
                Form자료변환출력 tmF = new Form자료변환출력();

                tmF.Grid받기(lbl_title.Text, "사출조건현황", gridView1);
                gridControl1.Visible = false;

                tmF.ShowDialog();

                gridControl1.Visible = true;
                gridControl1.Focus();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            injUpdateTimer.Stop();
            injUpdateTimer.Dispose();
            ConditionClear();
            this.Hide();
            if (controlClose != null)
                controlClose();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ConditionClear();
            btn_search.PerformClick();
        }

        private void ConditionClear()
        {
            InitDate();
            InitFirstMachine();
            TimerSetting();
        }

        private void ReadInjectStates()
        {
            try
            {
                string MachineCode = Convert.ToString(txt_machine.Tag);
                string start = Convert.ToString(txt_startdate.Text);
                string end = Convert.ToString(txt_enddate.Text);
                DataTable StateTable = StatusInfoHelper.getMachineState(MachineCode, start, end);
                gridControl1.DataSource = StateTable;           
            }
            catch { }
        }

        private void InitFirstMachine() 
        {
            //초기 검색할 사출기 설정
            string[] MachineInfo = new string[2];
            MachineInfo = StatusInfoHelper.getInitMachine();
            txt_machine.Tag = MachineInfo[0]; // MACHINE_CODE
            txt_machine.Text = MachineInfo[1]; // MACHINE_NAME
        }

        private void InitDate() 
        {
            txt_startdate.Text = commonVar.today;
            txt_enddate.Text = commonVar.today;
        }

        private void setMachineInfo(frm_machineRef.machineInformation selectedMachineInfo)
        {
            txt_machine.Text = selectedMachineInfo.machineName;
            txt_machine.Tag = selectedMachineInfo.machineID;
        }

        private void txt_machine_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            gridControl1.Visible = false;
            frm_machineRef machineRef = new frm_machineRef();
            machineRef.SendMachineInfoEvent += new frm_machineRef.SendMachineDataHandler(setMachineInfo);
            machineRef.ShowDialog();
            gridControl1.Visible = true;
            btn_search.PerformClick();
        }



        #region 권한설정함수

        private void userProvisioning(string menuID)
        {
            DataRow getPermissionInfo = null;

            for ( int i = 0 ; i < commonVar.userPermissionInfo.Rows.Count ; i++ )
            {
                getPermissionInfo = commonVar.userPermissionInfo.Rows[i];

                if ( getPermissionInfo["child_id"].ToString() == menuID )
                {
                    getPermissionInfo = commonVar.userPermissionInfo.Rows[i];
                    break;
                }

            }

            if ( getPermissionInfo != null )
            {

                if ( Convert.ToBoolean(getPermissionInfo["menu_convert"]) == false )
                {
                    btn_dataconvert.Enabled = false;
                    자료변환ToolStripMenuItem.Enabled = false;
                }
            }
        }

        #endregion


        #region contextMenuStrip

        private void 현재값검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( gridView1.FocusedRowHandle < 0 )
                this.gridControl1.Focus();
            else
                commonFX.fGrid현재값검색(gridView1);
        }

        private void 검색취소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commonFX.fGrid검색취소(gridView1);
        }

        private void 현컬럼좌측고정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( gridView1.FocusedRowHandle < 0 )
                this.gridControl1.Focus();
            else
                gridView1.FocusedColumn.Fixed = FixedStyle.Left;
        }

        private void 현컬럼우측고정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( gridView1.FocusedRowHandle < 0 )
                this.gridControl1.Focus();
            else
                gridView1.FocusedColumn.Fixed = FixedStyle.Right;
        }

        private void 고정컬럼해제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( gridView1.FocusedRowHandle < 0 )
                this.gridControl1.Focus();
            else
                gridView1.FocusedColumn.Fixed = FixedStyle.None;
        }

        private void 그룹화ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( gridView1.OptionsView.ShowGroupPanel == false )
                gridView1.OptionsView.ShowGroupPanel = true;
            else
                gridView1.OptionsView.ShowGroupPanel = false;
        }

        private void grid셋팅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGridSetting tmF = new FormGridSetting();

            tmF.R작업받기(this.gridView1, this.lbl_title.Text);
            tmF.ShowDialog();
            this.gridControl1.Focus();
        }



        #endregion

        private void txt_enddate_DateTimeChanged(object sender, EventArgs e)
        {
            DateTime setDate = txt_enddate.DateTime;
            if ( setDate > commonVar.getDate )
                txt_enddate.Text = commonVar.today;

            if ( !isLoading )
            {
                btn_TimerStop.PerformClick();
                btn_search.PerformClick();
            }
        }

        private bool CheckConditionsForTimer() 
        {
            DateTime start = txt_startdate.DateTime;
            DateTime end = txt_enddate.DateTime;
            string MachineCode = Convert.ToString(txt_machine.Tag);

            if ( start.Equals(end) && MachineCode.Length > 0 )
                return true;
            else
                return false;
        }

        private void TimerSetting() 
        {
            if ( CheckConditionsForTimer() )
            {
                injUpdateTimer.Start();
            }
            else
            {
                injUpdateTimer.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           ReadInjectStates();
        }

        private void btn_TimerStop_Click(object sender, EventArgs e)
        {
            DateTime start = txt_startdate.DateTime;
            DateTime end = txt_enddate.DateTime;
            if ( start.Equals(end) )
            {

                if ( timerStop == true )
                    TimerOn();
                else if ( timerStop == false )
                    TimerOff();
            }
            else
                TimerOff();

                setBtnColor(timerStop);            
        }

        private void setBtnColor(bool flag) 
        {
            if ( timerStop )
                btn_TimerStop.Appearance.BackColor = Color.OrangeRed;
            else
                btn_TimerStop.Appearance.BackColor = Color.Transparent;
        }

        private void TimerOn() 
        {
            timerStop = false;
            TimerSetting();
        }
        private void TimerOff() 
        {
            timerStop = true;
            injUpdateTimer.Stop();
        }

        private void txt_startdate_DateTimeChanged(object sender, EventArgs e)
        {
            if ( !isLoading )
            {
                btn_TimerStop.PerformClick();
                btn_search.PerformClick();
            }
        }

        private void ctl_InjectionCondition_ParentChanged(object sender, EventArgs e)
        {
            if(this.Parent == null)
                injUpdateTimer.Stop();
        }



    }
}
