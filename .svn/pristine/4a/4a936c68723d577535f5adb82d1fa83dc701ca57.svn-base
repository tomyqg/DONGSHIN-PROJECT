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
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

namespace DONGSHIN
{
    public partial class ctl_bizCode : UserControl
    {
        public ctl_bizCode()
        {
            InitializeComponent();
            commonFX.setThisLanguage(this);
        }

        ctl_bizEdit edit;

        DataSet ds_bizCode = new DataSet(); //업체코드
        DataSet ds_bizDD = new DataSet(); //업체담당

        private DataRow parentRow;
        private string bizID = "";
        
        private bool dd_isAdd = false; //업체담당 추가/수정 플래그변수
        private bool biz_isAdd = false; //업체코드 추가/수정 플래그변수
 
        private SqlCommand cmd;





        #region 컨트롤 전체 공용

        private void ctl_bizCode_Load(object sender, EventArgs e)
        {
            edit = new ctl_bizEdit(this);
            setVisible(pan_sub, true);
            read_grid1();
            string link = getBizid();
            read_grid2(link);
        }

        private void ctl_bizCode_VisibleChanged(object sender, EventArgs e)
        {
            if ( this.Visible == true )
                ctl_bizCode_Load(this, e);
        }

        private void setSelect(Control ctl)
        {
            ctl.Parent = pan_container;
            ctl.Dock = DockStyle.Fill;
            setVisible(ctl, true);
            ctl.BringToFront();
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

        #endregion

        #region 업체코드(grid1)

        #region 함수


                private void clear()
                {
                    cbx_gbn.Text = "";
                    chk_use.Checked = true;
                }

                private string getBizid() //grid1에서 업체코드 받아오는 함수
                {
                    string id = string.Empty;

                    DataRow target = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                    if ( target != null )
                        id = Convert.ToString(target["ec_id"]);
                    else
                        id = "";

                    return id;
                }


                private void read_grid1() //업체코드 그리드
                {

                    string use = "";

                    if ( chk_use.Checked == true )
                        use = "Y";
                    else
                        use = "N";

                    commonReturn Return = new commonReturn();

                    Return = fx_bizCode.read_all_ec(commonVar.DBconn,use);

                    if ( Return.Message == "" )
                    {
                        ds_bizCode = Return.Dataset;
                        gridControl1.DataSource = Return.Dataset.Tables[0].DefaultView;
                    }
                    else
                        MessageBox.Show(Return.Message, "DB 에러!");
                }


                private void conditionalRead_grid1() 
                {
                    string use = "";

                    if ( chk_use.Checked == true )
                        use = "Y";
                    else
                        use = "N";


                    commonReturn Return = new commonReturn();

                    Return = fx_bizCode.findByGbn(commonVar.DBconn, cbx_gbn.Text, use);
                    
                    if ( Return.Message == "" )
                    {
                        ds_bizCode = Return.Dataset;
                        gridControl1.DataSource = Return.Dataset.Tables[0].DefaultView;
                    }
                    else
                        MessageBox.Show(Return.Message, "DB 에러!");
                }

                public void editCompleted()
                {
                    btn_search.PerformClick();
                }
                #endregion

        private void btn_refresh_Click(object sender, EventArgs e)
        {
             cbx_gbn.Text = "";
             btn_search.PerformClick();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if ( gridControl1.Visible == false )
            {
                transitionManager.StartTransition(pan_container);

                try
                {
                    setSelect(splitContainerControl1); 
                }
                finally { transitionManager.EndTransition(); }
            }

            setVisible(pan_sub, true);

            string link = "";
            if ( cbx_gbn.Text == "" )
            {
                read_grid1();
                link = getBizid();
                read_grid2(link);
            }
            else
            {
                conditionalRead_grid1();
                link = getBizid();
                read_grid2(link);
            }
            
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
            if ( transitionManager.IsTransition )
                transitionManager.EndTransition();


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
                        bizID = parentRow["ec_id"].ToString();
                        edit.setID(bizID);
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
                    if ( edit.Visible == true )
                    {
                        MessageBox.Show("삭제 불가능 상태입니다. 뒤로가기 버튼을 누르세요.");
                        return;
                    }
                    bizID = parentRow["ec_id"].ToString();


                    commonReturn Return = new commonReturn();

                    Return = fx_bizCode.delete_ec(commonVar.DBconn, bizID);

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

                tmF.Grid받기(lbl_title.Text, "업체코드", gridView1);
                setVisible(splitContainerControl1, false);

                tmF.ShowDialog();

                setVisible(splitContainerControl1, true);
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


        private void cbx_gbn_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter )
                btn_search.PerformClick();
        }


        #endregion


        #region 업체담당(grid2)

                #region 함수
        
        
                private string getDDid()
                {
                    string id = string.Empty;

                    DataRow target = gridView2.GetDataRow(gridView2.FocusedRowHandle);
                    if ( target != null )
                        id = Convert.ToString(target["dd_id"]);
                    else
                        id = "";

                    return id;
                }


                private void read_grid2(string id) //업체담당 그리드
                {
                    commonReturn Return = new commonReturn();

                    Return = fx_bizCode.read_dd(commonVar.DBconn, id);
                    ds_bizDD.Clear();
                    if ( Return.Message == "" )
                    {
                        ds_bizDD = Return.Dataset;
                        gridControl2.DataSource = Return.Dataset.Tables[0].DefaultView;
                    }
                    else
                        MessageBox.Show(Return.Message, "DB 에러!");

                }

                private void save_grid2()
                {
                    cmd = new SqlCommand();
                    DataRow targetRow = gridView2.GetDataRow(gridView2.FocusedRowHandle);

                    //업체코드, 담당코드, 담당이름, 부서이름, 직위직책, 전화번호, 팩스번호, 휴대전화, 메일, 메모, 사용
                    cmd.Parameters.Clear();

                    if ( dd_isAdd == true )
                    {
                        DataRow targetBizid = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                        string biz_id = Convert.ToString(targetBizid["ec_id"]);
                        cmd.Parameters.Add("@ec_id", SqlDbType.VarChar, 20).Value = biz_id;

                        cmd.Parameters.Add("@dd_id", SqlDbType.BigInt).Value = Convert.ToInt64(0);
                        cmd.Parameters["@dd_id"].Direction = ParameterDirection.InputOutput;
                    }
                    else
                    {
                        cmd.Parameters.Add("@ec_id", SqlDbType.VarChar, 20).Value = Convert.ToString(targetRow["ec_id"]);
                        cmd.Parameters.Add("@dd_id", SqlDbType.BigInt).Value = Convert.ToInt64(targetRow["dd_id"]);
                    }

                    cmd.Parameters.Add("@dd_name", SqlDbType.NVarChar, 20).Value = Convert.ToString(targetRow["dd_name"]);
                    cmd.Parameters.Add("@bs_name", SqlDbType.NVarChar, 20).Value = Convert.ToString(targetRow["bs_name"]);
                    cmd.Parameters.Add("@pos", SqlDbType.NVarChar, 20).Value = Convert.ToString(targetRow["pos"]);
                    cmd.Parameters.Add("@tel", SqlDbType.VarChar, 20).Value = Convert.ToString(targetRow["tel"]);
                    cmd.Parameters.Add("@fax", SqlDbType.VarChar, 20).Value = Convert.ToString(targetRow["fax"]);
                    cmd.Parameters.Add("@mobi", SqlDbType.VarChar, 20).Value = Convert.ToString(targetRow["mobi"]);
                    cmd.Parameters.Add("@mail", SqlDbType.NVarChar, 100).Value = Convert.ToString(targetRow["mail"]);
                    cmd.Parameters.Add("@memo", SqlDbType.NVarChar, 500).Value = Convert.ToString(targetRow["memo"]);
                    cmd.Parameters.Add("@use_chk", SqlDbType.Char, 1).Value = Convert.ToString(targetRow["use_chk"]);


                    commonReturn Return = new commonReturn();

                    Return = fx_bizCode.write_dd(commonVar.DBconn, dd_isAdd, cmd);

                    if ( Return.Message == "" )
                    {
                        if ( dd_isAdd == true )
                            targetRow["dd_id"] = Convert.ToString(cmd.Parameters["@dd_id"].Value);

                        // dd_isAdd = false;
                        MessageBox.Show("저장 완료", "업체담당 등록");
                    }
                    else
                        MessageBox.Show(Return.Message, "DB 에러!");

                }

                private bool delete_dd(string id)
                {
                    commonReturn Return = new commonReturn();

                    Return = fx_bizCode.delete_dd(commonVar.DBconn, id);

                    if ( Return.Message == "" )
                        return true;
                    else
                        return false;
                }

                #endregion


        private void btn_dataconvert2_Click(object sender, EventArgs e)
        {
            if ( btn_dataconvert2.Enabled == true )
            {
                Form자료변환출력 tmF = new Form자료변환출력();

                tmF.Grid받기(lbl_title.Text, "업체담당", gridView2);
                setVisible(splitContainerControl1, false);

                tmF.ShowDialog();

                setVisible(splitContainerControl1, true);
                gridControl2.Focus();
            }

        }

        private void btn_add2_Click(object sender, EventArgs e)
        {
            try
            {
                dd_isAdd = true;
                gridView2.AddNewRow();
                gridView2.ShowPopupEditForm();

            }
            catch ( Exception ex ) { MessageBox.Show(ex.Message); }
        }


        private void btn_apply_Click(object sender, EventArgs e)
        {
            save_grid2();
        }


        private void btn_update2_Click(object sender, EventArgs e)
        {
            try
            {
                dd_isAdd = false;
                gridView2.ShowInplaceEditForm();
            }
            catch { }
        }

        private void btn_delete2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult question;
                question = MessageBox.Show("업체 담당직원을 삭제 하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if ( question == DialogResult.Yes )
                {
                    string dd_id = getDDid();

                    if ( dd_id == "" ) //그리드상에서만 추가된경우 (적용버튼을 누르지 않음)
                        gridView2.DeleteRow(gridView2.FocusedRowHandle);
                    else
                    { //적용버튼 눌러서 DB에 저장된경우
                        if ( delete_dd(dd_id) )
                        {
                            gridView2.DeleteRow(gridView2.FocusedRowHandle);
                            MessageBox.Show("삭제완료");
                        }
                        else
                            MessageBox.Show("삭제실패");
                    }
                }
                else
                {
                    MessageBox.Show("삭제를 취소 하였습니다.", "삭제 취소");
                }
            }
            catch { }
        }



        #endregion 

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //선택한 행을 더블클릭했을때 : 업체정보 읽음         
            transitionManager.StartTransition(pan_container);

            try
            {
                edit.setAddFlag(false); //추가x
                edit.setModeFlag(true); //단순조회o

                parentRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                bizID = parentRow["ec_id"].ToString();

                edit.setID(bizID);
                edit.setDataRow(ref parentRow);

                setVisible(edit, true);
                setSelect(edit);

            }
            finally { transitionManager.EndTransition(); }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            string link = getBizid();
            read_grid2(link);
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

        private void grid셋팅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGridSetting tmF = new FormGridSetting();

            tmF.R작업받기(this.gridView1, this.lbl_title.Text);
            tmF.ShowDialog();
            this.gridControl1.Focus();
        }

        private void grid다중검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( ds_bizCode.Tables.Count > 0 )
            {
                if ( ds_bizCode.Tables[0].Rows.Count > 0 )
                {
                    FormGridFilter FormFilter = new FormGridFilter();

                    FormFilter.Grid넘기기(ref ds_bizCode, ref gridView1);
                    FormFilter.ShowDialog(this);
                }
            }
        }

        private void group패널ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( gridView1.OptionsView.ShowGroupPanel == false )
                gridView1.OptionsView.ShowGroupPanel = true;
            else
                gridView1.OptionsView.ShowGroupPanel = false;
        }

        private void 그룹화ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( gridView2.OptionsView.ShowGroupPanel == false )
                gridView2.OptionsView.ShowGroupPanel = true;
            else
                gridView2.OptionsView.ShowGroupPanel = false;
        }


        private void 현재값검색ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ( gridView2.FocusedRowHandle < 0 )
                this.gridControl2.Focus();
            else
                commonFX.fGrid현재값검색(gridView2);
        }

        private void 검색취소ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            commonFX.fGrid검색취소(gridView2);
        }

        private void 현컬럼좌측고정ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ( gridView2.FocusedRowHandle < 0 )
                this.gridControl2.Focus();
            else
                gridView2.FocusedColumn.Fixed = FixedStyle.Left;
        }

        private void 현컬럼우측고정ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ( gridView2.FocusedRowHandle < 0 )
                this.gridControl2.Focus();
            else
                gridView2.FocusedColumn.Fixed = FixedStyle.Right;
        }

        private void 고정컬럼해제ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ( gridView2.FocusedRowHandle < 0 )
                this.gridControl2.Focus();
            else
                gridView2.FocusedColumn.Fixed = FixedStyle.None;
        }

        private void grid셋팅ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormGridSetting tmF = new FormGridSetting();

            tmF.R작업받기(this.gridView2, this.lbl_title.Text);
            tmF.ShowDialog();
            this.gridControl2.Focus();
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
                    btn_add2.Enabled = false;
                    추가ToolStripMenuItem.Enabled = false;
                    담당자추가ToolStripMenuItem.Enabled = false;
                    btn_apply.Enabled = false;
                }
                if ( Convert.ToBoolean(getPermissionInfo["menu_upd"]) == false )
                {
                    btn_update.Enabled = false;
                    btn_update2.Enabled = false;
                    수정ToolStripMenuItem.Enabled = false;
                    담당자수정ToolStripMenuItem.Enabled = false;
                    btn_apply.Enabled = false;
                }
                if ( Convert.ToBoolean(getPermissionInfo["menu_del"]) == false )
                {
                    btn_delete.Enabled = false;
                    btn_delete2.Enabled = false;
                    삭제ToolStripMenuItem.Enabled = false;
                    담당자삭제ToolStripMenuItem.Enabled = false;
                }
                if ( Convert.ToBoolean(getPermissionInfo["menu_convert"]) == false )
                {
                    btn_dataconvert.Enabled = false;
                    btn_dataconvert2.Enabled = false;
                    자료변환ToolStripMenuItem.Enabled = false;
                    자료변환ToolStripMenuItem1.Enabled = false;
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
