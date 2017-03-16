using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DONGSHIN
{
    public partial class frm_deptRef : Form
    {
        public frm_deptRef()
        {
            InitializeComponent();
            commonFX.setThisLanguage(this);
        }

        private DataSet ds_deptRef = new DataSet();
        private DataRow targetRow;

        public class deptInformation
        {
            public string deptID { get; set; }
            public string deptName { get; set; }
        }

        public delegate void SendDeptDataHandler(deptInformation deptInfo);
        public event SendDeptDataHandler SendDeptInfoEvent;


        private void frm_deptRef_Load(object sender, EventArgs e)
        {
            btn_search.PerformClick();
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            if ( txt_name.Text == "" )
                read();
            else
                conditionalRead();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            targetRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            deptInformation selectedInfo = selectedDeptInfo(targetRow);
            this.SendDeptInfoEvent(selectedInfo);
            this.Close();  
        }

        private deptInformation selectedDeptInfo(DataRow row)
        {
            deptInformation selectedInfo = new deptInformation();
            selectedInfo.deptID = Convert.ToString(targetRow["bs_id"]);
            selectedInfo.deptName = Convert.ToString(targetRow["bs_name"]);

            return selectedInfo;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            btn_search.PerformClick();

        }


        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            targetRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if ( targetRow == null )
            {
                MessageBox.Show("선택된 항목이 없습니다.");
                return;
            }
            else 
            {
                btn_select.PerformClick();
            }
            
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter )
                btn_search.PerformClick();
        }



        #region 함수
        private void read()
        {

            commonReturn Return = new commonReturn();

            Return = fx_deptCode.read_all(commonVar.DBconn,"Y");
            ds_deptRef.Clear();
            if ( Return.Message == "" )
            {
                ds_deptRef = Return.Dataset;
                gridControl1.DataSource = Return.Dataset.Tables[0].DefaultView;
            }
            else
                MessageBox.Show(Return.Message, "DB 에러!");
        }

        private void conditionalRead()
        {

            string use = "Y"; //부서코드 참조에서는 사용여부Y만 찾게끔

            commonReturn Return = new commonReturn();

            Return = fx_deptCode.findByName(commonVar.DBconn, txt_name.Text, use);

            if ( Return.Message == "" )
            {
                ds_deptRef = Return.Dataset;
                gridControl1.DataSource = Return.Dataset.Tables[0].DefaultView;
            }
            else
                MessageBox.Show(Return.Message, "DB 에러!");
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

        private void grid셋팅toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormGridSetting tmF = new FormGridSetting();

            tmF.R작업받기(this.gridView1, this.lbl_title.Text);
            tmF.ShowDialog();
            this.gridControl1.Focus();
        }

        private void grid다중검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( ds_deptRef.Tables.Count > 0 )
            {
                if ( ds_deptRef.Tables[0].Rows.Count > 0 )
                {
                    FormGridFilter FormFilter = new FormGridFilter();

                    FormFilter.Grid넘기기(ref ds_deptRef, ref gridView1);
                    FormFilter.ShowDialog(this);
                }
            }
        }
        #endregion

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            targetRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if ( targetRow == null )
            {
                MessageBox.Show("선택된 항목이 없습니다.");
                return;
            }
            else
            {
                btn_select.PerformClick();
            }
        }



    }//class
}//namespace
