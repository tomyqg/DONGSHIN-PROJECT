using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DONGSHIN
{
    public partial class ctl_deptCode : UserControl
    {
        public ctl_deptCode()
        {
            InitializeComponent();
            commonFX.setThisLanguage(this);           
        }
        ctl_deptedit edit;
        private DataSet ds_deptCode = new DataSet();
        private DataRow parentRow;
        private string deptID = "";

        

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            btn_search.PerformClick();
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
                        MessageBox.Show("수정할 자료를 선택하세요.");
                    else
                    {
                        deptID = parentRow["bs_id"].ToString();
                        edit.setID(deptID);
                        edit.setDataRow(ref parentRow);
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
                    deptID = parentRow["bs_id"].ToString();

                    if ( commonVar.DBconn.State == ConnectionState.Closed )
                        commonVar.DBconn.ConnectionString = commonVar.dbConnectionString;

                    commonReturn Return = new commonReturn();

                    Return = fx_deptCode.delete(commonVar.DBconn, deptID);

                    if ( Return.Message == "" )
                    {
                        parentRow.Delete();
                        parentRow.AcceptChanges();
                    }
                    else
                        MessageBox.Show(Return.Message, "DB 에러!");
                }

            }//else     
        }


        #region (클릭 제외)이벤트
        private void ctl_deptcode_Load(object sender, EventArgs e)
        {
            userProvisioning("120000");
            edit = new ctl_deptedit(this);
            setVisible(edit, false);
            read();
        }

        private void ctl_deptCode_VisibleChanged(object sender, EventArgs e)
        {
            if ( this.Visible == true )
                ctl_deptcode_Load(this, e);
        }


        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //선택한 행을 더블클릭했을때 : 부서정보 읽음         
            transitionManager.StartTransition(pan_container);

            try
            {
                edit.setAddFlag(false);
                edit.setModeFlag(true);

                parentRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                deptID = parentRow["bs_id"].ToString();

                edit.setID(deptID);
                edit.setDataRow(ref parentRow);

                setVisible(edit, true);
                setSelect(edit);

            }
            finally { transitionManager.EndTransition(); }

        }

        #endregion

        #region 함수

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

        private void read()
        {
            if ( commonVar.DBconn.State == ConnectionState.Closed )
            {
                commonVar.DBconn.ConnectionString = commonVar.dbConnectionString;
                commonVar.DBconn.Open();
            }
            
            string use = "";

            if ( chk_use.Checked == true )
                use = "Y";
            else
                use = "N";

            commonReturn Return = new commonReturn();

            Return = fx_deptCode.read_all(commonVar.DBconn,use);

            if ( Return.Message == "" )
            {
                ds_deptCode = Return.Dataset;
                gridControl1.DataSource = Return.Dataset.Tables[0].DefaultView;
            }
            else
                MessageBox.Show(Return.Message, "DB 에러!");

        }

        private void conditionalRead()
        {
            if ( commonVar.DBconn.State == ConnectionState.Closed )
                commonVar.DBconn.ConnectionString = commonVar.dbConnectionString;

            string use = "";

            if ( chk_use.Checked == true )
                use = "Y";
            else
                use = "N";

            commonReturn Return = new commonReturn();

            Return = fx_deptCode.findByName(commonVar.DBconn, txt_name.Text, use);

            if ( Return.Message == "" )
            {
                ds_deptCode = Return.Dataset;
                gridControl1.DataSource = Return.Dataset.Tables[0].DefaultView;
            }
            else
                MessageBox.Show(Return.Message, "DB 에러!");
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

        private void btn_dataconvert_Click(object sender, EventArgs e)
        {

            if ( btn_dataconvert.Enabled == true )
            {
                Form자료변환출력 tmF = new Form자료변환출력();

                tmF.Grid받기(lbl_title.Text, "부서코드", gridView1);
                setVisible(gridControl1, false);

                tmF.ShowDialog();

                setVisible(gridControl1, true);
                gridControl1.Focus();
            }

        }

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

        private void group패널ToolStripMenuItem_Click(object sender, EventArgs e)
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
            if ( ds_deptCode.Tables.Count > 0 )
            {
                if ( ds_deptCode.Tables[0].Rows.Count > 0 )
                {
                    FormGridFilter FormFilter = new FormGridFilter();

                    FormFilter.Grid넘기기(ref ds_deptCode, ref gridView1);
                    FormFilter.ShowDialog(this);
                }
            }
        }

        #endregion

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

            }
        }

        #endregion

    }
}
