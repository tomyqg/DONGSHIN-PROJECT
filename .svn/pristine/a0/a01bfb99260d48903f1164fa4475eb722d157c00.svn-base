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
    public partial class frm_resinRef : Form
    {
        public frm_resinRef()
        {
            InitializeComponent();
            commonFX.setThisLanguage(this);
        }

        private DataSet ds_resinRef = new DataSet();
        private DataRow targetRow;

        public class resinInformation
        {
            public string resinID {get;set;}
            public string resinName { get; set; }
            public string resinGrade { get; set; }
            public string resinColorName { get; set; }
            public string resinUnit { get; set; }
            public string resinMaker { get; set; }
        }

        public delegate void SendResinDataHandler(resinInformation resinInfo);
        public event SendResinDataHandler SendResinInfoEvent;

        private void frm_resinRef_Load(object sender, EventArgs e)
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
            resinInformation selectedInfo = selectedResinInfo(targetRow);
            this.SendResinInfoEvent(selectedInfo);
            this.Close();            
        }

        private resinInformation selectedResinInfo(DataRow row) 
        {
            resinInformation selectedInfo = new resinInformation();
            selectedInfo.resinID = Convert.ToString(targetRow["sj_id"]);
            selectedInfo.resinName = Convert.ToString(targetRow["sj_name"]);
            selectedInfo.resinGrade = Convert.ToString(targetRow["grade"]);
            selectedInfo.resinColorName = Convert.ToString(targetRow["color_name"]);
            selectedInfo.resinUnit = Convert.ToString(targetRow["unit"]);
            selectedInfo.resinMaker = Convert.ToString(targetRow["maker"]);

            return selectedInfo;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {           
            this.Close();
        }

        private void txt_modelName_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter )
                btn_search.PerformClick();
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






        #region 함수
        private void read()
        {

            commonReturn Return = new commonReturn();

            Return = fx_resinCode.readResinRecordsForRef(commonVar.DBconn);
            ds_resinRef.Clear();
            if ( Return.Message == "" )
            {
                ds_resinRef = Return.Dataset;
                gridControl1.DataSource = Return.Dataset.Tables[0].DefaultView;
            }
            else
                MessageBox.Show(Return.Message, "DB 에러!");
        }

        private void conditionalRead()
        {
            commonReturn Return = new commonReturn();

            Return = fx_resinCode.findByName(commonVar.DBconn, txt_name.Text, "Y");

            if ( Return.Message == "" )
            {
                ds_resinRef = Return.Dataset;
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
            if ( ds_resinRef.Tables.Count > 0 )
            {
                if ( ds_resinRef.Tables[0].Rows.Count > 0 )
                {
                    FormGridFilter FormFilter = new FormGridFilter();

                    FormFilter.Grid넘기기(ref ds_resinRef, ref gridView1);
                    FormFilter.ShowDialog(this);
                }
            }
        }
        #endregion

    }//class
}//namespace
