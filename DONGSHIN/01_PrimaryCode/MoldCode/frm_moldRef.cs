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
    public partial class frm_moldRef : Form
    {
        public frm_moldRef()
        {
            InitializeComponent();
            commonFX.setThisLanguage(this);
        }
        private DataSet ds_moldRef = new DataSet();
        private DataRow targetRow;
        private string MachineID = string.Empty;

        public class moldInformation
        {
            public string moldID { get; set; }
            public string moldName { get; set; }
            public string moldNum { get; set; }
            public string moldModel { get; set; }
            public string moldCavity { get; set; }
            public int moldShot { get; set; }
        }

        public delegate void SendMoldDataHandler(moldInformation moldInfo);
        public event SendMoldDataHandler SendMoldInfoEvent;

        //금형참조 폼이 닫힐때
        public delegate void MoldRefClosingHandler();
        public event MoldRefClosingHandler MoldRefClosingEvent;

        public void setMachineID(string MachineID)
        {
            this.MachineID = MachineID;
        }

        private void frm_moldRef_Load(object sender, EventArgs e)
        {
            btn_search.PerformClick();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if ( this.MachineID.Length > 0 )
            {
                findByMachineID(this.MachineID);
            }
            else
            {
                read();
            }
        }

        private void read()
        {

            commonReturn Return = new commonReturn();

            Return = fx_moldCode.readMoldRecordsForRef(commonVar.DBconn, txt_baljuBiz.Text, cbx_jejakGbn.Text);
            ds_moldRef.Clear();
            if ( Return.Message == "" )
            {
                ds_moldRef = Return.Dataset;
                gridControl1.DataSource = Return.Dataset.Tables[0].DefaultView;
            }
            else
                MessageBox.Show(Return.Message, "DB 에러!");
        }

        private void findByMachineID(string MachineID)
        {
            commonReturn Return = new commonReturn();

            Return = fx_moldCode.findByMachineID(commonVar.DBconn, MachineID);
            ds_moldRef.Clear();
            if ( Return.Message == "" )
            {
                ds_moldRef = Return.Dataset;
                gridControl1.DataSource = Return.Dataset.Tables[0].DefaultView;
            }
            else
                MessageBox.Show(Return.Message, "DB 에러!");
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            targetRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            moldInformation selectedInfo = selectedMoldInfo(targetRow);
            this.SendMoldInfoEvent(selectedInfo);
            this.Close(); 
        }

        private moldInformation selectedMoldInfo(DataRow row)
        {
            moldInformation selectedInfo = new moldInformation();
            selectedInfo.moldID = Convert.ToString(targetRow["gh_id"]);
            selectedInfo.moldName = Convert.ToString(targetRow["gh_name"]);
            selectedInfo.moldNum = Convert.ToString(targetRow["gh_num"]);
            selectedInfo.moldModel = Convert.ToString(targetRow["model"]);
            selectedInfo.moldCavity = Convert.ToString(targetRow["cavity"]);
            selectedInfo.moldShot = Convert.ToInt32(targetRow["accumulated"]);

            return selectedInfo;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Clear();
            this.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Clear();
            btn_search.PerformClick();
        }

        public void Clear() 
        {
            txt_baljuBiz.Text = "";
            txt_baljuBiz.Tag = "";
            cbx_jejakGbn.Text = "";
            this.MachineID = string.Empty;
        }

        private void cbx_jejakGbn_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter )
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
            if ( ds_moldRef.Tables.Count > 0 )
            {
                if ( ds_moldRef.Tables[0].Rows.Count > 0 )
                {
                    FormGridFilter FormFilter = new FormGridFilter();

                    FormFilter.Grid넘기기(ref ds_moldRef, ref gridView1);
                    FormFilter.ShowDialog(this);
                }
            }
        }
        #endregion

        private void frm_moldRef_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.MoldRefClosingEvent();
        }
    }//class
}//namespace
