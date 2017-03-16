using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DONGSHIN
{
    public partial class frm_empRef : Form
    {
        public frm_empRef()
        {
            InitializeComponent();
            commonFX.setThisLanguage(this);
        }

        private DataSet ds_empRef = new DataSet();
        private DataRow targetRow;


        public class empInformation
        {
            public string empID { get; set; }
            public string empName { get; set; }
        }

        public delegate void SendEmpDataHandler(empInformation empInfo);
        public event SendEmpDataHandler SendEmpInfoEvent;

        private void setDeptInfo(frm_deptRef.deptInformation selectedDeptInfo)
        {
            txt_dept.Text = selectedDeptInfo.deptName;
            txt_dept.Tag = selectedDeptInfo.deptID;
        }


        private void frm_empRef_Load(object sender, EventArgs e)
        {
            read();
        }


        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_dept.Text = "";
            txt_name.Text = "";
            btn_search.PerformClick();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if ( (txt_name.Text == "") || (txt_dept.Text=="") )
                read();
            else
                conditionalRead();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            targetRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            empInformation selectedInfo = selectedEmpInfo(targetRow);
            this.SendEmpInfoEvent(selectedInfo);
            this.Close();    
        }

        private empInformation selectedEmpInfo(DataRow row)
        {
            empInformation selectedInfo = new empInformation();
            selectedInfo.empID = Convert.ToString(targetRow["sw_id"]);
            selectedInfo.empName = Convert.ToString(targetRow["sw_name"]);

            return selectedInfo;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txt_dept_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter )
                txt_name.Focus();
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

            Return = fx_empCode.read_all(commonVar.DBconn,"Y");
            ds_empRef.Clear();
            if ( Return.Message == "" )
            {
                ds_empRef = Return.Dataset;
                gridControl1.DataSource = Return.Dataset.Tables[0].DefaultView;
            }
            else
                MessageBox.Show(Return.Message, "DB 에러!");
        }

        private void conditionalRead()
        {

            commonReturn Return = new commonReturn();

            Return = fx_empCode.findBy2Param(commonVar.DBconn, txt_name.Text, txt_dept.Text);

            if ( Return.Message == "" )
            {
                ds_empRef = Return.Dataset;
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
            if ( ds_empRef.Tables.Count > 0 )
            {
                if ( ds_empRef.Tables[0].Rows.Count > 0 )
                {
                    FormGridFilter FormFilter = new FormGridFilter();

                    FormFilter.Grid넘기기(ref ds_empRef, ref gridView1);
                    FormFilter.ShowDialog(this);
                }
            }
        }
        #endregion

        private void txt_dept_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Image img = Properties.Resources.black_opacity;
            bgimg.Appearance.Image = commonFX.change_opacity(img, 0.5f);
            bgimg.Dock = DockStyle.Fill;
            bgimg.Visible = true;

            frm_deptRef deptRef = new frm_deptRef();
            deptRef.SendDeptInfoEvent += new frm_deptRef.SendDeptDataHandler(setDeptInfo);
            deptRef.ShowDialog();

            bgimg.Visible = false;
        }

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
