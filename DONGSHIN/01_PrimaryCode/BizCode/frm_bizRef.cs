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
    public partial class frm_bizRef : Form
    {
        public frm_bizRef()
        {
            InitializeComponent();
            commonFX.setThisLanguage(this);
        }


        private DataSet ds_bizRef = new DataSet();
        private DataRow targetRow;


        public class bizInformation
        {
            public string bizID { get; set; }
            public string bizName { get; set; }
        }

        public delegate void SendBizDataHandler(bizInformation bizInfo);
        public event SendBizDataHandler SendBizInfoEvent;

        private void frm_bizRef_Load(object sender, EventArgs e)
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
            bizInformation selectedInfo = selectedBizInfo(targetRow);
            this.SendBizInfoEvent(selectedInfo);
            this.Close();      
        }

        private bizInformation selectedBizInfo(DataRow row)
        {
            bizInformation selectedInfo = new bizInformation();
            selectedInfo.bizID = Convert.ToString(targetRow["ec_id"]);
            selectedInfo.bizName = Convert.ToString(targetRow["ec_name"]);

            return selectedInfo;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            cbx_gbn.SelectedIndex = -1;
            txt_name.Text = "";
            btn_search.PerformClick();
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

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter )
                btn_search.PerformClick();
        }


        #region 함수
        private void read()
        {
            commonReturn Return = new commonReturn();

            Return = fx_bizCode.read_all_ec(commonVar.DBconn, "Y");
            
            if ( Return.Message == "" )
            {
                ds_bizRef = Return.Dataset;
                gridControl1.DataSource = Return.Dataset.Tables[0].DefaultView;
            }
            else
                MessageBox.Show(Return.Message, "DB 에러!");
        }

        private void conditionalRead()
        {
            commonReturn Return = new commonReturn();

            Return = fx_bizCode.findByCondition(commonVar.DBconn, cbx_gbn.Text ,txt_name.Text);

            if ( Return.Message == "" )
            {
                ds_bizRef = Return.Dataset;
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
            if ( ds_bizRef.Tables.Count > 0 )
            {
                if ( ds_bizRef.Tables[0].Rows.Count > 0 )
                {
                    FormGridFilter FormFilter = new FormGridFilter();

                    FormFilter.Grid넘기기(ref ds_bizRef, ref gridView1);
                    FormFilter.ShowDialog(this);
                }
            }
        }
        #endregion



    }
}
