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
    public partial class ctl_workOrder : UserControl
    {
        public ctl_workOrder()
        {
            InitializeComponent();
            commonFX.setThisLanguage(this);
        }

        ctl_workOrderEdit edit;

        private DataSet ds_workOrder = new DataSet();
        private DataRow parentRow;
        private string workOrderID = "";
        private string productID = "";
        private bool isLoading = false;

        private void setProductInfo(frm_productRef.productInformation selectedProductInfo)
        {
            txt_prodid.Text = selectedProductInfo.productID;
            productID = selectedProductInfo.productID;
        }

        private void ctl_workOrder_Load(object sender, EventArgs e)
        {
            isLoading = true;

            txt_startdate.Text = commonVar.startOfMonth;
            txt_enddate.Text = commonVar.endOfMonth;

            userProvisioning("210000");
            edit = new ctl_workOrderEdit(this);
            setVisible(pan_sub, true);
            readWorkHistory();

            isLoading = false;
        }

        private void ctl_workOrder_VisibleChanged(object sender, EventArgs e)
        {
            if ( this.Visible == true )
                ctl_workOrder_Load(this, e); 
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            clear();
            btn_search.PerformClick();
        }

        private void txt_prodid_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            setVisible(gridControl1, false);

            frm_productRef productRef = new frm_productRef();
            productRef.SendProductInfoEvent += new frm_productRef.SendProductDataHandler(setProductInfo);
            productRef.ShowDialog();


            setVisible(gridControl1, true);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if ( gridControl1.Visible == false )
            {
                transitionManager.StartTransition(pan_container);

                try
                {
                    setSelect(gridControl1);
                }
                finally { transitionManager.EndTransition(); }
            }

            setVisible(pan_sub, true);

            readWorkHistory();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if ( transitionManager.IsTransition )
                transitionManager.EndTransition();


            transitionManager.StartTransition(pan_container);

            try
            {
                edit.setAddFlag(true);
                edit.readOnlyMode(false);
                setSelect(edit);
            }
            finally { transitionManager.EndTransition(); }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if ( btn_update.Enabled == true )
            {
                transitionManager.StartTransition(pan_container);

                try
                {
                    edit.setAddFlag(false);
                    edit.readOnlyMode(false);
                    parentRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                    if ( parentRow == null )
                    {
                        MessageBox.Show("수정할 자료를 선택하세요.");
                        return;
                    }
                    else
                    {
                        string state = Convert.ToString(parentRow["jisi_gbn"]);
                        if ( state == "종료" )
                        {
                            MessageBox.Show("이미 종료된 작업입니다.", "주의");
                            return;
                        }
                        workOrderID = parentRow["jisi_id"].ToString();
                        edit.setID(workOrderID);
                    }

                    setSelect(edit);

                }
                finally { transitionManager.EndTransition(); }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            parentRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if ( parentRow == null )
                MessageBox.Show("삭제할 자료를 선택하세요.");
            else
            {
                DialogResult question = MessageBox.Show("선택하신 자료를 삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if ( question == DialogResult.Yes )
                {
                    if ( edit.Visible == true )
                    {
                        MessageBox.Show("삭제 불가능 상태입니다. 뒤로가기 버튼을 누르세요.");
                        return;
                    }

                    workOrderID = parentRow["jisi_id"].ToString();


                    commonReturn Return = new commonReturn();

                    Return = fx_workOrder.deleteSingleOrder(commonVar.DBconn, workOrderID);

                    if ( Return.Message == "" )
                    {
                        parentRow.Delete();
                    }
                    else
                        MessageBox.Show(Return.Message, "DB 에러!");
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

                tmF.Grid받기(lbl_title.Text, "작업지시", gridView1);
                setVisible(gridControl1, false);

                tmF.ShowDialog();

                setVisible(gridControl1, true);
                gridControl1.Focus();
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

        #region 함수

        private void readWorkHistory()
        {

            commonReturn Return = new commonReturn();

            Return = fx_workOrder.readWorkHistory(commonVar.DBconn, txt_startdate.Text, txt_enddate.Text, txt_prodid.Text);

            if ( Return.Message == "" )
            {
                ds_workOrder = Return.Dataset;
                gridControl1.DataSource = Return.Dataset.Tables[0].DefaultView;
            }
            else
                MessageBox.Show(Return.Message, "DB 에러!");

        }



        private void setVisible(Control target, bool show)
        {
            //컨트롤의 visible속성을 결정
            if ( target == gridControl1 )
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

        private void grid다중검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( ds_workOrder.Tables.Count > 0 )
            {
                if ( ds_workOrder.Tables[0].Rows.Count > 0 )
                {
                    FormGridFilter FormFilter = new FormGridFilter();

                    FormFilter.Grid넘기기(ref ds_workOrder, ref gridView1);
                    FormFilter.ShowDialog(this);
                }
            }
        }

        #endregion

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //선택한 행을 더블클릭했을때 : 작업지시정보 읽음         
            transitionManager.StartTransition(pan_container);

            try
            {
                edit.setAddFlag(false); //추가x

                bool read = true;
                bool copy = false;
                edit.setModeFlag(read, copy); //단순조회 또는 복사

                parentRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                workOrderID = parentRow["jisi_id"].ToString();

                edit.setID(workOrderID);

                setSelect(edit);

            }
            finally { transitionManager.EndTransition(); }
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter )
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

                if ( Convert.ToBoolean(getPermissionInfo["menu_add"]) == false )
                {
                    btn_add.Enabled = false;
                    추가ToolStripMenuItem.Enabled = false;

                    btn_copy.Enabled = false;
                    복사ToolStripMenuItem.Enabled = false;
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

        private void btn_copy_Click(object sender, EventArgs e)
        {  
            transitionManager.StartTransition(pan_container);

            try
            {
                parentRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);

                if ( parentRow == null )
                {
                    MessageBox.Show("복사 가능한 작업지시가 없습니다.", "주의");
                }
                else
                {
                    bool read = false;
                    bool copy = true;

                    edit.setModeFlag(read, copy);
                    edit.setAddFlag(false); //추가x
                    edit.readOnlyMode(false);//단순조회x


                    workOrderID = parentRow["jisi_id"].ToString();

                    edit.setID(workOrderID);

                    setSelect(edit);
                }

            }
            finally { transitionManager.EndTransition(); }
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

    }//class
}//namespace
