using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;

namespace DONGSHIN
{
    public partial class ctl_ErrorStates : UserControl
    {
        public ctl_ErrorStates()
        {
            InitializeComponent();
            commonFX.setThisLanguage(this);
        }

        private void ctl_ErrorStates_Load(object sender, EventArgs e)
        {
            initDate();
            ReadErrorStates();
            userProvisioning("430000");
            txt_startdate.DateTimeChanged += new EventHandler(btn_search_Click);
            txt_enddate.DateTimeChanged += new EventHandler(btn_search_Click);
        }

        private void ctl_ErrorStates_VisibleChanged(object sender, EventArgs e)
        {
            if ( this.Visible == true )
                ctl_ErrorStates_Load(this, e);
        }


        private void initDate() 
        {
            txt_startdate.EditValue = commonVar.startDate;
            txt_enddate.EditValue = commonVar.today;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            initDate();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            ReadErrorStates();
        }

        private void ReadErrorStates()
        {
            try
            {
                string start = txt_startdate.Text;
                string end = Convert.ToDateTime(txt_enddate.Text).AddDays(1).ToShortDateString();

                    DataTable ErrorStateTable = StatusInfoHelper.getErrorStateByMachine(start,end);

                    if ( ErrorStateTable != null ) 
                    {
                        for ( int i = 0 ; i < ErrorStateTable.Rows.Count ; i++ ) 
                        {
                            DataRow row = ErrorStateTable.Rows[i];
                            ErrorStateTable.Rows[i].BeginEdit();

                            if ( row["ERROR_STATE"].ToString() == "1" )
                                ErrorStateTable.Rows[i]["ERROR_STATE"] = "N";
                            else
                                ErrorStateTable.Rows[i]["ERROR_STATE"] = "Y";

                            ErrorStateTable.Rows[i].EndEdit();
                        }
                        gridControl1.DataSource = ErrorStateTable;   
                    }
                                     

            }
            catch { }
        }


        private void btn_dataconvert_Click(object sender, EventArgs e)
        {
            if ( btn_dataconvert.Enabled == true )
            {
                Form자료변환출력 tmF = new Form자료변환출력();

                tmF.Grid받기(lbl_title.Text, "에러발생현황", gridView1);
                gridControl1.Visible = false;

                tmF.ShowDialog();

                gridControl1.Visible = true;
                gridControl1.Focus();
            }
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
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



    }
}
