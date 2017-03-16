using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraEditors.Repository;

namespace DONGSHIN
{
    public partial class ctl_DBPermission : UserControl
    {
        public ctl_DBPermission()
        {
            InitializeComponent();
            commonFX.setThisLanguage(this);
        }

        private DataSet ds_emp = new DataSet();
        private DataSet ds_menu = new DataSet();

        private bool isValueChanged = false;
        private bool isloading = false;

        SqlCommand cmd;



        private void ctl_DBPermission_Load(object sender, EventArgs e)
        {
            isloading = true;
            read_sw();
            read_menu("everyMenu");
            isloading = false;
        }


        private void ctl_DBPermission_VisibleChanged(object sender, EventArgs e)
        {
            if ( this.Visible == true )
                ctl_DBPermission_Load(this, e);
        }

        #region 함수

        private void read_sw()
        {

            commonReturn Return = new commonReturn();

            Return = fx_empCode.read_all(commonVar.DBconn, "Y");
            ds_emp.Clear();
            if ( Return.Message == "" )
            {
                ds_emp = Return.Dataset;
                gridControl1.DataSource = Return.Dataset.Tables[0].DefaultView;
            }
            else
                MessageBox.Show(Return.Message, "DB 에러!");


            isValueChanged = false;

        }

        private void read_menu(string empID) 
        {
            commonReturn Return2 = new commonReturn();

            Return2 = fx_DBPermission.read_menu(commonVar.DBconn, empID);
            ds_menu.Clear();
            if ( Return2.Message == "" )
            {
                ds_menu = Return2.Dataset;
                gridControl2.DataSource = Return2.Dataset.Tables[0].DefaultView;
            }
            else
                MessageBox.Show(Return2.Message, "DB 에러!");


            isValueChanged = false;

        }

        private bool saveByDept() 
        {
            DataRow targetMenu = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            string deptID = targetMenu["bs_id"].ToString();
            List<string> empList = new List<string>();

            for ( int i = 0 ; i < gridView1.RowCount ; i++ )
            {
                DataRow targetEmp = gridView1.GetDataRow(i);
                if ( Convert.ToString(targetEmp["bs_id"]) == deptID )
                    empList.Add(Convert.ToString(targetEmp["sw_id"]));
            }

            DataView targetDV = (DataView)gridControl2.DataSource;
            DataTable targetDT = targetDV.Table;
            DataRow targetRow;

            for ( int j = 0 ; j < empList.Count ; j++ ) 
            { 
                if(initializingPermission(empList[j]))
                {

                    for ( int k = 0 ; k < targetDT.Rows.Count ; k++ )
                    {
                        cmd = new SqlCommand();

                        targetRow = targetDT.Rows[k];
                        if ( Convert.ToBoolean(targetRow["menu_access"]) == true )
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.Add("@sw_id", SqlDbType.VarChar, 10).Value = empList[j];
                            cmd.Parameters.Add("@parent_id", SqlDbType.Int).Value = Convert.ToInt32(targetRow["parent_id"]);
                            cmd.Parameters.Add("@child_id", SqlDbType.Int).Value = Convert.ToInt32(targetRow["child_id"]);
                            cmd.Parameters.Add("@menu_access", SqlDbType.Bit).Value = Convert.ToBoolean(targetRow["menu_access"]);
                            cmd.Parameters.Add("@menu_add", SqlDbType.Bit).Value = Convert.ToBoolean(targetRow["menu_add"]);
                            cmd.Parameters.Add("@menu_upd", SqlDbType.Bit).Value = Convert.ToBoolean(targetRow["menu_upd"]);
                            cmd.Parameters.Add("@menu_del", SqlDbType.Bit).Value = Convert.ToBoolean(targetRow["menu_del"]);
                            cmd.Parameters.Add("@menu_search", SqlDbType.Bit).Value = Convert.ToBoolean(targetRow["menu_search"]);
                            cmd.Parameters.Add("@menu_print", SqlDbType.Bit).Value = Convert.ToBoolean(targetRow["menu_print"]);
                            cmd.Parameters.Add("@menu_convert", SqlDbType.Bit).Value = Convert.ToBoolean(targetRow["menu_convert"]);

                            commonReturn Return = new commonReturn();
                            Return = fx_DBPermission.write(commonVar.DBconn, cmd);

                            if ( Return.Message != "" )
                            {
                                MessageBox.Show("저장 중 에러 발생");
                                return false;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("권한 초기화 실패");
                    return false;
                }
            }
            
            isValueChanged = false;
            return true;
        }

        private bool saveBySingleEmp()
        {
            DataRow targetMenu = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            string empID = targetMenu["sw_id"].ToString();            
            

            //기존 권한 내역 초기화
            if ( initializingPermission(empID) )
            {
                //전체 데이터를 가져와서 임시테이블 생성
                DataView targetDV = (DataView)gridControl2.DataSource;
                DataTable targetDT = targetDV.Table;
                DataRow targetRow;

                cmd = new SqlCommand();
                for ( int i = 0 ; i < targetDT.Rows.Count ; i++ )
                {
                    targetRow = targetDT.Rows[i];
                    if ( Convert.ToBoolean(targetRow["menu_access"]) == true )
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add("@sw_id", SqlDbType.VarChar, 10).Value = empID;
                        cmd.Parameters.Add("@parent_id", SqlDbType.Int).Value = Convert.ToInt32(targetRow["parent_id"]);
                        cmd.Parameters.Add("@child_id", SqlDbType.Int).Value = Convert.ToInt32(targetRow["child_id"]);
                        cmd.Parameters.Add("@menu_access", SqlDbType.Bit).Value = Convert.ToBoolean(targetRow["menu_access"]);
                        cmd.Parameters.Add("@menu_add", SqlDbType.Bit).Value = Convert.ToBoolean(targetRow["menu_add"]);
                        cmd.Parameters.Add("@menu_upd", SqlDbType.Bit).Value = Convert.ToBoolean(targetRow["menu_upd"]);
                        cmd.Parameters.Add("@menu_del", SqlDbType.Bit).Value = Convert.ToBoolean(targetRow["menu_del"]);
                        cmd.Parameters.Add("@menu_search", SqlDbType.Bit).Value = Convert.ToBoolean(targetRow["menu_search"]);
                        cmd.Parameters.Add("@menu_print", SqlDbType.Bit).Value = Convert.ToBoolean(targetRow["menu_print"]);
                        cmd.Parameters.Add("@menu_convert", SqlDbType.Bit).Value = Convert.ToBoolean(targetRow["menu_convert"]);

                        commonReturn Return = new commonReturn();
                        Return = fx_DBPermission.write(commonVar.DBconn, cmd);

                        if ( Return.Message != "" )
                        {
                            MessageBox.Show("저장 중 에러 발생");
                            return false;
                        }

                    }
                }
                isValueChanged = false;
                return true;
            }
            else
            {
                isValueChanged = false;
                MessageBox.Show("권한 초기화 실패");
                return false;
            }           

        }

        private bool initializingPermission(string id)
        {
            //기존등록된 내용 삭제
            commonReturn Return = new commonReturn();
            Return = fx_DBPermission.delete(commonVar.DBconn, id);

            if ( Return.Message == "" )
                return true;
            else
                return false;
        }
        #endregion



        #region 체크박스이벤트
        private void RepositoryChkAccess_CheckedChanged(object sender, EventArgs e)
        {
            DataRow target = gridView2.GetDataRow(gridView2.FocusedRowHandle);

            if ( target == null )
                return;
            else 
            {
                if ( Convert.ToBoolean(target["menu_access"]) == false )
                {
                    target.BeginEdit();
                    target["menu_access"] = true;
                    target["menu_add"] = true;
                    target["menu_upd"] = true;
                    target["menu_del"] = true;
                    target["menu_search"] = true;
                    target["menu_print"] = true;
                    target["menu_convert"] = true;
                    target.EndEdit();
                }
                else
                {
                    target.BeginEdit();
                    target["menu_access"] = false;
                    target["menu_add"] = false;
                    target["menu_upd"] = false;
                    target["menu_del"] = false;
                    target["menu_search"] = false;
                    target["menu_print"] = false;
                    target["menu_convert"] = false;
                    target.EndEdit();
                }

            }
            isValueChanged = true;
        }

        private void singleRepositoryChk_CheckedChanged(object sender, EventArgs e)
        {
            if ( ((CheckEdit)sender).Checked == true )
            {
                DataRow target = gridView2.GetDataRow(gridView2.FocusedRowHandle);

                if ( Convert.ToBoolean(target["menu_access"]) == false )
                {
                    MessageBox.Show("메뉴접근 권한부터 확인하세요", "권한 설정 에러");
                    ((CheckEdit)sender).Checked = false;
                    return;
                }
            }
            isValueChanged = true;
        }

        private void chkAccess_CheckedChanged(object sender, EventArgs e)
        {
            DataRow target;
            if ( chkAccess.Checked == true )
            {
                chkAdd.Checked = true;
                chkUpd.Checked = true;
                chkDel.Checked = true;
                chkSearch.Checked = true;
                chkPrint.Checked = true;
                chkConvert.Checked = true;

                for ( int i = 0 ; i < gridView2.RowCount ; i++ )
                {
                    target = gridView2.GetDataRow(i);

                    target.BeginEdit();
                    target["menu_access"] = true;
                    target["menu_add"] = true;
                    target["menu_upd"] = true;
                    target["menu_del"] = true;
                    target["menu_search"] = true;
                    target["menu_print"] = true;
                    target["menu_convert"] = true;
                    target.EndEdit();
                }
            }
            else
            {               
                    chkAdd.Checked = false;
                    chkUpd.Checked = false;
                    chkDel.Checked = false;
                    chkSearch.Checked = false;
                    chkPrint.Checked = false;
                    chkConvert.Checked = false;

                    for ( int i = 0 ; i < gridView2.RowCount ; i++ )
                    {
                        target = gridView2.GetDataRow(i);

                        target.BeginEdit();
                        target["menu_access"] = false;
                        target["menu_add"] = false;
                        target["menu_upd"] = false;
                        target["menu_del"] = false;
                        target["menu_search"] = false;
                        target["menu_print"] = false;
                        target["menu_convert"] = false;
                        target.EndEdit();
                    }                
            }

            isValueChanged = true;
        }

        private void checkedChanged(object sender, EventArgs e)
        {
            DataRow target;
            string ctlName = ((CheckEdit)sender).Name;
            string colName = "";

            switch ( ctlName )
            { 
                case "chkAdd":
                    colName = "menu_add";
                    break;
                case "chkUpd":
                    colName = "menu_upd";
                    break;
                case "chkDel":
                    colName = "menu_del";
                    break;
                case "chkSearch":
                    colName = "menu_search";
                    break;
                case "chkPrint":
                    colName = "menu_print";
                    break;
                case "chkConvert":
                    colName = "menu_convert";
                    break;
            }

            for ( int i = 0 ; i < gridView2.RowCount ; i++ ) 
            {
                target = gridView2.GetDataRow(i);
                target.BeginEdit();
                if ( ((CheckEdit)sender).Checked == true )
                    target[colName] = true;
                else
                    target[colName] = false;
                target.EndEdit();
            }

            isValueChanged = true;
        }

        private void singleColumnCheckedChange(object sender, EventArgs e) 
        {
            if ( ((CheckEdit)sender).Checked == true )
            {
                if ( chkAccess.Checked == false )
                {
                    MessageBox.Show("메뉴접근 권한부터 확인하세요","권한 설정 에러");
                    ((CheckEdit)sender).Checked = false;
                    return;
                }
                else
                {
                    checkedChanged(sender, e);
                }
            }

            isValueChanged = true;
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
            if ( ds_emp.Tables.Count > 0 )
            {
                if ( ds_emp.Tables[0].Rows.Count > 0 )
                {
                    FormGridFilter FormFilter = new FormGridFilter();

                    FormFilter.Grid넘기기(ref ds_emp, ref gridView1);
                    FormFilter.ShowDialog(this);
                }
            }
        }

        #endregion



        private void gridView1_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            if ( !isloading )
            {
                if ( isValueChanged )
                {
                    DialogResult question;
                    question = MessageBox.Show("변경된 자료를 저장하지 않았습니다. \n\r저장할까요?", "주의", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if ( question == DialogResult.Yes )
                        btn_apply.PerformClick();                    
                }

                isValueChanged = false;

                DataRow target = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                string emp = Convert.ToString(target["sw_id"]);
                string dept = Convert.ToString(target["bs_id"]);

                if ( gridView1.FocusedColumn.FieldName == "bs_name" )
                {
                    lbl_subtitle2.Text = target["bs_name"].ToString() + " 권한설정";
                    read_menu(dept);
                }
                else
                {
                    lbl_subtitle2.Text = target["sw_name"].ToString() + " 권한설정";
                    read_menu(emp);
                }
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if ( !isloading )
            {
                if ( isValueChanged ) 
                {
                    DialogResult question;
                    question = MessageBox.Show("변경된 자료를 저장하지 않았습니다. \n\r저장할까요?", "주의", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if ( question == DialogResult.Yes ) 
                        btn_apply.PerformClick();
                }

                isValueChanged = false;

                DataRow target = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                string emp = Convert.ToString(target["sw_id"]);
                string dept = Convert.ToString(target["bs_id"]);

                if ( gridView1.FocusedColumn.FieldName == "bs_name" )
                {
                    lbl_subtitle2.Text = target["bs_name"].ToString() + " 권한설정";
                    read_menu(dept);
                }
                else
                {
                    lbl_subtitle2.Text = target["sw_name"].ToString() + " 권한설정";
                    read_menu(emp);
                }
            }
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            splitContainerControl1.Enabled = false;
            splashScreenManager1.ShowWaitForm();

            if ( gridView1.FocusedColumn.FieldName == "bs_name" )                
                saveByDept();
            else
                saveBySingleEmp();

            if ( saveBySingleEmp() || saveByDept() )
            {
                splashScreenManager1.CloseWaitForm();
                splitContainerControl1.Enabled = true;
                MessageBox.Show("권한 설정 저장 완료");
            }
            else
            {
                splashScreenManager1.CloseWaitForm();
                splitContainerControl1.Enabled = true;
                MessageBox.Show("권한 설정 저장 실패");
            }
        }



        private void btn_close_Click(object sender, EventArgs e)
        {
            if ( isValueChanged )
            {
                DialogResult question;
                question = MessageBox.Show("변경된 자료를 저장하지 않았습니다. \n\r저장할까요?", "주의", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if ( question == DialogResult.Yes )
                    btn_apply.PerformClick();
            }
            isValueChanged = false;
            this.Hide();
        }


        




    }//class
}//namespace
