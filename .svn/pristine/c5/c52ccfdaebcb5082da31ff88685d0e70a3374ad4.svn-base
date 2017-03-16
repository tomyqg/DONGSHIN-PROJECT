using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace DONGSHIN
{
    public partial class ctl_workperformance : UserControl
    {
        public ctl_workperformance()
        {
            InitializeComponent();
            commonFX.setThisLanguage(this);
        }

        ctl_workPerformanceEdit edit;

        private DataSet ds_workPerformance = new DataSet();
        private DataRow parentRow;
        private string workOrderID = "";
        private string workPerfID = "";
        private string productID = "";
        private bool isLoading = false;

        private void setProductInfo(frm_productRef.productInformation selectedProductInfo)
        {
            txt_prodid.Tag = selectedProductInfo.productID;
            txt_prodid.Text = selectedProductInfo.productName;
        }


        private void ctl_workperformance_Load(object sender, EventArgs e)
        {
            isLoading = true;

            txt_startdate.Text = commonVar.startOfMonth;
            txt_enddate.Text = commonVar.endOfMonth;

            userProvisioning("220000");
            edit = new ctl_workPerformanceEdit(this);
            setVisible(pan_sub, true);
            readWorkOrders();
            readWorkPerf();

            isLoading = false;
        }

        private void ctl_workperformance_VisibleChanged(object sender, EventArgs e)
        {
            if ( this.Visible == true )
                ctl_workperformance_Load(this, e); 
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            clear();
            btn_search.PerformClick();
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            if ( splitContainerControl1.Visible == false )
            {
                transitionManager.StartTransition(pan_container);

                try
                {
                    setSelect(splitContainerControl1);
                }
                finally { transitionManager.EndTransition(); }
            }

            setVisible(pan_sub, true);

            readWorkOrders();
            readWorkPerf();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if ( gridView1.RowCount > 0 )
            {
                parentRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if ( parentRow == null )
                {
                    MessageBox.Show("등록할 자료를 선택하세요.");
                    return;
                }
                else
                {
                    string state = parentRow["jisi_gbn"].ToString();
                    if ( state.Equals("종료") )
                    {
                        MessageBox.Show("이미 종료된 작업지시입니다.\n\r실적을 추가할 수 없습니다.");
                    }
                    else
                    {
                        workOrderID = parentRow["jisi_id"].ToString();

                        if ( transitionManager.IsTransition )
                            transitionManager.EndTransition();


                        transitionManager.StartTransition(pan_container);

                        try
                        {
                            edit.setAddFlag(true);
                            edit.readOnlyMode(false);
                            edit.setOrderID(workOrderID);
                            setSelect(edit);
                        }
                        finally { transitionManager.EndTransition(); }
                    }
                }
            }
            else 
            {
                MessageBox.Show("현재 실적을 등록할 작업지시가 없습니다.");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if ( btn_update.Enabled == true )
            {
                if ( gridView2.RowCount > 0 )
                {
                    transitionManager.StartTransition(pan_container);

                    try
                    {
                        edit.setAddFlag(false);
                        edit.readOnlyMode(false);
                        parentRow = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                        if ( parentRow == null )
                        {
                            MessageBox.Show("수정할 자료를 선택하세요.");
                            return;
                        }
                        else
                        {
                            workPerfID = parentRow["siljeok_id"].ToString();
                            edit.setPerformanceID(workPerfID);
                            
                        }

                        setSelect(edit);

                    }
                    finally { transitionManager.EndTransition(); }
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            parentRow = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if ( parentRow == null )
                MessageBox.Show("삭제할 자료를 선택하세요.");
            else
            {
                DialogResult question = MessageBox.Show("작업 실적이 삭제됩니다.\n\r선택하신 자료를 삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if ( question == DialogResult.Yes )
                {
                    if ( edit.Visible == true )
                    {
                        MessageBox.Show("삭제 불가능 상태입니다. 뒤로가기 버튼을 누르세요.");
                        return;
                    }

                    workPerfID = parentRow["siljeok_id"].ToString();

                    string ErrorDeleteDone = fx_workPerf.DeleteErrorDetails(commonVar.DBconn, workPerfID);
                    string NonOpDeleteDone = fx_workPerf.DeleteBreakTimeDetails(commonVar.DBconn, workPerfID);

                    if ( ErrorDeleteDone.Length == 0 && NonOpDeleteDone.Length == 0 )
                    {
                        commonReturn Return = new commonReturn();
                        Return = fx_workPerf.deletePerformance(commonVar.DBconn, workPerfID);

                        if ( Return.Message == "" )
                            parentRow.Delete();
                        else
                            MessageBox.Show(Return.Message, "DB 에러!");
                    }
                    else
                        MessageBox.Show("삭제 실패");
                }

            }//else   


        }

        private void btn_print_Click(object sender, EventArgs e)
        {

        }

        private void btn_dataconvert_Click(object sender, EventArgs e)
        {
            if ( btn_dataconvert.Enabled == true )
            {
                Form자료변환출력 tmF = new Form자료변환출력();

                tmF.Grid받기(lbl_title.Text, "작업실적", gridView2);
                setVisible(gridControl2, false);

                tmF.ShowDialog();

                setVisible(gridControl2, true);
                gridControl2.Focus();
            }
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            if ( edit.Visible == true )
            {
                MessageBox.Show("추가/수정 모드입니다.\n\r편집창을 먼저 닫아 주세요.");
                return;
                //setVisible(edit, false);
                //return;
            }
            clear();
            this.Hide();
        }




        private void txt_prodid_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            splitContainerControl1.Visible = false;

            frm_productRef productRef = new frm_productRef();
            productRef.SendProductInfoEvent += new frm_productRef.SendProductDataHandler(setProductInfo);
            productRef.ShowDialog();

            splitContainerControl1.Visible = true;
        }

        #region contextMenuStrip

        private void 현재값검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( gridView2.FocusedRowHandle < 0 )
                this.gridControl2.Focus();
            else
                commonFX.fGrid현재값검색(gridView2);
        }

        private void 검색취소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commonFX.fGrid검색취소(gridView2);
        }

        private void 현컬럼좌측고정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( gridView2.FocusedRowHandle < 0 )
                this.gridControl2.Focus();
            else
                gridView2.FocusedColumn.Fixed = FixedStyle.Left;
        }

        private void 현컬럼우측고정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( gridView2.FocusedRowHandle < 0 )
                this.gridControl2.Focus();
            else
                gridView2.FocusedColumn.Fixed = FixedStyle.Right;
        }

        private void 고정컬럼해제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( gridView2.FocusedRowHandle < 0 )
                this.gridControl2.Focus();
            else
                gridView2.FocusedColumn.Fixed = FixedStyle.None;
        }

        private void 그룹화ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( gridView2.OptionsView.ShowGroupPanel == false )
                gridView2.OptionsView.ShowGroupPanel = true;
            else
                gridView2.OptionsView.ShowGroupPanel = false;
        }

        private void grid셋팅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGridSetting tmF = new FormGridSetting();

            tmF.R작업받기(this.gridView2, this.lbl_title.Text);
            tmF.ShowDialog();
            this.gridControl2.Focus();
        }

        private void grid다중검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( ds_workPerformance.Tables.Count > 0 )
            {
                if ( ds_workPerformance.Tables[0].Rows.Count > 0 )
                {
                    FormGridFilter FormFilter = new FormGridFilter();

                    FormFilter.Grid넘기기(ref ds_workPerformance, ref gridView2);
                    FormFilter.ShowDialog(this);
                }
            }
        }

        #endregion

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

                if ( Convert.ToBoolean(getPermissionInfo["menu_add"]) == false )
                {
                    btn_add.Enabled = false;
                    추가ToolStripMenuItem.Enabled = false;
                }
                if ( Convert.ToBoolean(getPermissionInfo["menu_upd"]) == false )
                {
                    btn_update.Enabled = false;
                    수정ToolStripMenuItem.Enabled = false;
                }
                if ( Convert.ToBoolean(getPermissionInfo["menu_del"]) == false )
                {
                    btn_delete.Enabled = false;
                    삭제ToolStripMenuItem.Enabled = false;
                }
                if ( Convert.ToBoolean(getPermissionInfo["menu_convert"]) == false )
                {
                    btn_dataconvert.Enabled = false;
                    자료변환ToolStripMenuItem.Enabled = false;
                }
                if ( Convert.ToBoolean(getPermissionInfo["menu_print"]) == false )
                {
                    btn_print.Enabled = false;
                    인쇄ToolStripMenuItem.Enabled = false;
                }
            }
        }



        #endregion

        #region 함수

        private void readWorkOrders()
        {

            commonReturn Return = new commonReturn();

            Return = fx_workOrder.readWorkHistory(commonVar.DBconn, txt_startdate.Text, txt_enddate.Text, txt_prodid.Text);

            if ( Return.Message == "" )
            {
                gridControl1.DataSource = Return.Dataset.Tables[0];
            }
            else
                MessageBox.Show(Return.Message, "DB 에러!");

        }


        private void readWorkPerf()
        {
            if ( gridView1.RowCount > 0 )
            {
                DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                workOrderID = row["jisi_id"].ToString();


                commonReturn Return = new commonReturn();

                Return = fx_workPerf.findByWorkOrderID(commonVar.DBconn, workOrderID);

                if ( Return.Message == "" )
                {
                    ds_workPerformance = Return.Dataset;
                    DataTable dt = setTimeFormat(Return.Dataset.Tables[0]);
                    gridControl2.DataSource = dt;
                }
                else
                    MessageBox.Show(Return.Message, "DB 에러!");
            }
        }

        private void setVisible(Control target, bool show)
        {
            //컨트롤의 visible속성을 결정
            if ( target == splitContainerControl1 )
                target.Visible = show;
            else
            {
                Control[] details = { pan_sub, edit };

                for ( int i = 0 ; i < details.Length ; i++ )
                {
                    if ( target == details[i] )
                        target.Visible = show;
                    else
                        details[i].Visible = !show;
                }
            }
        }

        private void setSelect(Control ctl)
        {
            ctl.Parent = pan_container;
            ctl.Dock = DockStyle.Fill;
            setVisible(ctl, true);
            ctl.BringToFront();
        }

        private void clear()
        {
            txt_startdate.Text = commonVar.startOfMonth;
            txt_enddate.Text = commonVar.endOfMonth;
            txt_prodid.Text = "";
            txt_prodid.Tag = "";
        }


        public void editCompleted()
        {
            btn_search.PerformClick();
        }

        #endregion

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            readWorkPerf();                
        }



        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);

            GridHitInfo info = view.CalcHitInfo(pt);
            if ( info.InRow || info.InRowCell )
            {
                //선택한 행을 더블클릭했을때 : 작업지시정보 읽음         
                transitionManager.StartTransition(pan_container);

                try
                {
                    edit.setAddFlag(false);

                    bool read = true;
                    edit.setModeFlag(read); //단순조회

                    parentRow = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                    workPerfID = parentRow["siljeok_id"].ToString();

                    edit.setPerformanceID(workPerfID);

                    setSelect(edit);

                }
                finally { transitionManager.EndTransition(); }
            } 
            
        }


        private DataTable setTimeFormat(DataTable table)
        {
            if ( table.Rows.Count > 0 )
            {
                for ( int i = 0 ; i < table.Rows.Count ; i++ )
                {
                    DataRow row = table.Rows[i];
                    DateTime start_time = Convert.ToDateTime(row["start_time"]);
                    DateTime end_time = Convert.ToDateTime(row["end_time"]);
                    DateTime work_time = Convert.ToDateTime(row["work_time"]);
                    DateTime nonOperation_time = Convert.ToDateTime(row["bgd_time"]);

                    row["start_time"] = string.Format("{0:tt HH:mm}", start_time);
                    row["end_time"] = string.Format("{0:tt HH:mm}", end_time);
                    row["work_time"] = string.Format("{0:HH시간 mm분}", work_time);
                    row["bgd_time"] = string.Format("{0:HH시간 mm분}", nonOperation_time);
                }
            }
            return table;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);

            GridHitInfo info = view.CalcHitInfo(pt);
            if ( info.InRow || info.InRowCell )
            {
                btn_add.PerformClick();
            }
        }


        private void DateTimeChanged(object sender, EventArgs e)
        {
            if ( !isLoading )
            {
                DateTime startDate = txt_startdate.DateTime;
                DateTime endDate = txt_enddate.DateTime;
                if ( startDate > endDate )
                {
                    txt_startdate.Text = commonVar.startOfMonth;
                    txt_enddate.Text = commonVar.endOfMonth;
                }
            }
        }



    }
}
