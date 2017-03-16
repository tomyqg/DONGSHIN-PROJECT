using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Columns;

namespace DONGSHIN
{
    public partial class ctl_productCode : UserControl
    {
        public ctl_productCode()
        {
            InitializeComponent();
            commonFX.setThisLanguage(this);
        }

        ctl_productEdit edit;

        private DataSet ds_productCode = new DataSet();
        private DataRow parentRow;
        private string productID = ""; //일련번호를 id로 사용함.



        private void ctl_productCode_Load(object sender, EventArgs e)
        {
            userProvisioning("160000");
            edit = new ctl_productEdit(this);
            setVisible(pan_sub, true);
            read();
        }

        private void ctl_productCode_VisibleChanged(object sender, EventArgs e)
        {
            if ( this.Visible == true )
                ctl_productCode_Load(this, e); 
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

            if ( txt_name.Text == "" )
                read();
            else
                conditionalRead();
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
                        productID = parentRow["jp_id"].ToString();
                        edit.setID(productID);
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

                    //이미지삭제(FTP)
                    productID = parentRow["jp_id"].ToString();

                    if ( deleteDirectory(productID) )
                    {
                        //데이터 삭제
                        commonReturn Return = new commonReturn();

                        Return = fx_productCode.delete(commonVar.DBconn, productID);

                        if ( Return.Message == "" )
                        {
                            parentRow.Delete();
                        }
                        else
                            MessageBox.Show(Return.Message, "DB 에러!");
                    }
                    else 
                    {
                        MessageBox.Show("삭제 실패");
                    }
                    
                }

            }//else   
        }

        private bool deleteDirectory(string productID)
        {
            imgUploadHelper ftpClient = new imgUploadHelper(commonVar.userFTPServerIP, commonVar.userFTPID, commonVar.userFTPPassword);
            string ftpDirPath = "JEPUM/" + productID;
            if ( ftpClient.DeleteDirectory(ftpDirPath) )
                return true;
            else
                return false;
        }

        private void btn_print_Click(object sender, EventArgs e)
        {

        }

        private void btn_dataconvert_Click(object sender, EventArgs e)
        {

            if ( btn_dataconvert.Enabled == true )
            {
                Form자료변환출력 tmF = new Form자료변환출력();

                tmF.Grid받기(lbl_title.Text, "제품코드", gridView1);
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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            btn_search.PerformClick();
        }


        #region 함수

        private void read()
        {
            string use = "";

            if ( chk_use.Checked == true )
                use = "Y";
            else
                use = "N";

            commonReturn Return = new commonReturn();

            Return = fx_productCode.read_all(commonVar.DBconn, use);
           
            if ( Return.Message == "" )
            {
                ds_productCode = Return.Dataset;
                gridControl1.DataSource = Return.Dataset.Tables[0].DefaultView;
            }
            else
                MessageBox.Show(Return.Message, "DB 에러!");

        }

        private void conditionalRead()
        {

            string use = "";

            if ( chk_use.Checked == true )
                use = "Y";
            else
                use = "N";

            commonReturn Return = new commonReturn();

            Return = fx_productCode.findByName(commonVar.DBconn, txt_name.Text, use);

            if ( Return.Message == "" )
            {
                ds_productCode = Return.Dataset;
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
            txt_name.Text = "";
            chk_use.Checked = true;
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
            if ( ds_productCode.Tables.Count > 0 )
            {
                if ( ds_productCode.Tables[0].Rows.Count > 0 )
                {
                    FormGridFilter FormFilter = new FormGridFilter();

                    FormFilter.Grid넘기기(ref ds_productCode, ref gridView1);
                    FormFilter.ShowDialog(this);
                }
            }
        }

        #endregion

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //선택한 행을 더블클릭했을때 : 제품정보 읽음         
            transitionManager.StartTransition(pan_container);

            try
            {
                edit.setAddFlag(false); //추가x
                edit.setModeFlag(true); //단순조회o

                parentRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                productID = parentRow["jp_id"].ToString();

                edit.setID(productID);

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


    }//class
}//namespace
