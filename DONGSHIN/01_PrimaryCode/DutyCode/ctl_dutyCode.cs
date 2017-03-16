 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;

namespace DONGSHIN
{
    public partial class ctl_dutyCode : UserControl
    {
        public ctl_dutyCode()
        {
            InitializeComponent();
            commonFX.setThisLanguage(this);
        }

        ctl_dutyEdit edit;

        private DataSet ds_dutyCode = new DataSet();
        private DataRow parentRow;
        private string dutyID = "";

        private void ctl_dutyCode_Load(object sender, EventArgs e)
        {
            userProvisioning("125000");
            edit = new ctl_dutyEdit(this);
            setVisible(pan_sub, true);
            read();
        }

        private void ctl_dutyCode_VisibleChanged(object sender, EventArgs e)
        {
            if ( this.Visible == true )
                ctl_dutyCode_Load(this, e);
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
                        dutyID = parentRow["gm_id"].ToString();
                        edit.setID(dutyID);
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
                    dutyID = parentRow["gm_id"].ToString();


                    commonReturn Return = new commonReturn();

                    Return = fx_dutyCode.delete(commonVar.DBconn, dutyID);

                    if ( Return.Message == "" )
                    {
                        parentRow.Delete();
                    }
                    else
                        MessageBox.Show(Return.Message, "DB 에러!");
                }

            }//else 
        }

        private void btn_dataconvert_Click(object sender, EventArgs e)
        {
            if ( btn_dataconvert.Enabled == true )
            {
                Form자료변환출력 tmF = new Form자료변환출력();

                tmF.Grid받기(lbl_title.Text, "근무코드", gridView1);
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
            txt_name.Text = "";
            this.Hide();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            btn_search.PerformClick();
        }

        #region 클릭제외한 이벤트
        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter )
                btn_search.PerformClick();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //선택한 행을 더블클릭했을때 
            transitionManager.StartTransition(pan_container);

            try
            {
                edit.setAddFlag(false);
                edit.setModeFlag(true);

                parentRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                dutyID = parentRow["gm_id"].ToString();

                edit.setID(dutyID);

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

            commonReturn Return = new commonReturn();

            Return = fx_dutyCode.read_all(commonVar.DBconn);

            if ( Return.Message == "" )
            {
                ds_dutyCode = Return.Dataset;                
                DataTable dt = setTimeFormat(Return.Dataset.Tables[0]);                
                gridControl1.DataSource = dt;
                
            }
            else
                MessageBox.Show(Return.Message, "DB 에러!");
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
                    DateTime work_time = Convert.ToDateTime(row["gm_time"]);
                    row["start_time"] = string.Format("{0:tt HH:mm}", start_time);
                    row["end_time"] = string.Format("{0:tt HH:mm}", end_time);
                    row["gm_time"] = string.Format("{0:HH시간 mm분}", work_time);
                }
            }
            return table;
        }


        private void conditionalRead()
        {
            commonReturn Return = new commonReturn();

            Return = fx_dutyCode.findByName(commonVar.DBconn, txt_name.Text);

            if ( Return.Message == "" )
            {
                ds_dutyCode = Return.Dataset;
                DataTable dt = setTimeFormat(Return.Dataset.Tables[0]);
                gridControl1.DataSource = dt;
            }
            else
                MessageBox.Show(Return.Message, "DB 에러!");
        }

        public void editCompleted()
        {
            btn_search.PerformClick();
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
            if ( ds_dutyCode.Tables.Count > 0 )
            {
                if ( ds_dutyCode.Tables[0].Rows.Count > 0 )
                {
                    FormGridFilter FormFilter = new FormGridFilter();

                    FormFilter.Grid넘기기(ref ds_dutyCode, ref gridView1);
                    FormFilter.ShowDialog(this);
                }
            }
        }

        #endregion



    }//class
}//namespace
