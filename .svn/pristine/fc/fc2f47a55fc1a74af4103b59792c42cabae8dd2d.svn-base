using DevExpress.XtraGrid.Columns;
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
    public partial class frm_workOrderRef : Form
    {
        public frm_workOrderRef()
        {
            InitializeComponent();
            commonFX.setThisLanguage(this);
        }

        private DataSet ds_workOrderRef = new DataSet();
        private DataRow targetRow;

        private string ProductID = string.Empty;
        private string MachineID = string.Empty;
        private string MoldID = string.Empty;

        public class workOrderInformation
        {
            public string ProductID { get; set; }
            public string ProductCar { get; set; }
            public string ProductName { get; set; }
            public string ProductNum { get; set; }

            public string MoldID { get; set; }
            public string MoldModel { get; set; }
            public string MoldName { get; set; }
            public string MoldNum { get; set; }
            public int MoldShot { get; set; }
            public string MoldCavity { get; set; }

            public int MachineNum { get; set; }
            public string MachineID { get; set; }
            public string MachineName { get; set; }
            public string MachineType { get; set; }

            public int PlannedQty { get; set; }
        }

        workOrderInformation selectedInfo = new workOrderInformation();

        public delegate void SendWorkOrderDataHandler(workOrderInformation workOdrderInfo);
        public event SendWorkOrderDataHandler SendWorkOrderInfoEvent;

        //작업지시참조 폼이 닫힐때
        public delegate void WorkOrderRefClosingHandler();
        public event WorkOrderRefClosingHandler WorkOrderRefClosingEvent;

        private void frm_workOrderRef_Load(object sender, EventArgs e)
        {
            txt_startdate.Text = commonVar.startOfMonth;
            txt_enddate.Text = commonVar.endOfMonth;

            btn_search.PerformClick();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            readWorkHistory();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            targetRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            workOrderInformation selectedInfo = selectedWorkOrderInfo(targetRow);
            this.SendWorkOrderInfoEvent(selectedInfo);
            
            this.Close();   
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            clear();
            btn_search.PerformClick();
        }

        private void txt_prodid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_search.PerformClick();
        }

        private void clear()
        {
            txt_startdate.Text = commonVar.startOfMonth;
            txt_enddate.Text = commonVar.endOfMonth;
            txt_prodid.Text = "";
            txt_prodid.Tag = "";
        }



        private workOrderInformation selectedWorkOrderInfo(DataRow row)
        {    
            selectedInfo.ProductID = Convert.ToString(targetRow["jp_id"]);
            selectedInfo.MoldID = Convert.ToString(targetRow["gh_id"]);
            selectedInfo.MachineID = Convert.ToString(targetRow["MACHINE_CODE"]);
            selectedInfo.PlannedQty = Convert.ToInt32(targetRow["qt_plan"]);

            readMoldInfo(selectedInfo.MoldID);
            readMachineInfo(selectedInfo.MachineID);
            readProductInfo(selectedInfo.ProductID);

            return selectedInfo;
        }


        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            targetRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (targetRow == null)
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

        private void readWorkHistory()
        {

            commonReturn Return = new commonReturn();

            Return = fx_workOrder.readWorkHistory(commonVar.DBconn, txt_startdate.Text, txt_enddate.Text, txt_prodid.Text);

            if (Return.Message == "")
            {
                ds_workOrderRef = Return.Dataset;
                gridControl1.DataSource = Return.Dataset.Tables[0].DefaultView;
            }
            else
                MessageBox.Show(Return.Message, "DB 에러!");

        }

        private DataRow readMoldInfo(string MoldID) 
        {
            DataRow row = null;
            commonReturn MoldInfo = new commonReturn();

            MoldInfo = fx_moldCode.findByID(commonVar.DBconn, MoldID);
            if (MoldInfo.Message == "" && MoldInfo.Dataset.Tables[0].Rows.Count > 0 )
            {
                row = MoldInfo.Dataset.Tables[0].Rows[0];

                selectedInfo.MoldModel = Convert.ToString(row["model"]);
                selectedInfo.MoldName = Convert.ToString(row["gh_name"]);
                selectedInfo.MoldNum = Convert.ToString(row["gh_num"]);
                selectedInfo.MoldShot = Convert.ToInt32(row["accumulated"]);
                selectedInfo.MoldCavity = Convert.ToString(row["cavity"]);
            }
            else 
            {
                selectedInfo.MoldModel = string.Empty;
                selectedInfo.MoldName = string.Empty;
                selectedInfo.MoldNum = string.Empty;
                selectedInfo.MoldShot = 0;
                selectedInfo.MoldCavity = string.Empty;
            }

            return row;
        }

        private DataRow readMachineInfo(string MachineID) 
        {
            DataRow row = null;
            commonReturn MachineInfo = new commonReturn();

            MachineInfo = fx_machineCode.findByID(commonVar.DBconn, MachineID);

            if (MachineInfo.Message == "" && MachineInfo.Dataset.Tables[0].Rows.Count > 0)
            {
                row = MachineInfo.Dataset.Tables[0].Rows[0];

                selectedInfo.MachineNum = Convert.ToInt32(row["MACHINE_NUMBER"]);
                selectedInfo.MachineName = Convert.ToString(row["MACHINE_NAME"]);
                selectedInfo.MachineType = Convert.ToString(row["MACHINE_TYPE"]);
            }
            else
            {
                selectedInfo.MachineNum = 0;
                selectedInfo.MachineName = string.Empty;
                selectedInfo.MachineType = string.Empty;
            }


            return row;        
        }

        private DataRow readProductInfo(string ProductID) 
        {
            DataRow row = null;
            commonReturn ProductInfo = new commonReturn();

            ProductInfo = fx_productCode.findByID(commonVar.DBconn, ProductID);

            if (ProductInfo.Message == "" && ProductInfo.Dataset.Tables[0].Rows.Count > 0)
            {
                row = ProductInfo.Dataset.Tables[0].Rows[0];

                selectedInfo.ProductCar = Convert.ToString(row["car"]);
                selectedInfo.ProductName = Convert.ToString(row["jp_name"]);
                selectedInfo.ProductNum = Convert.ToString(row["jp_num"]);
            }
            else
            {
                selectedInfo.ProductCar = string.Empty;
                selectedInfo.ProductName = string.Empty;
                selectedInfo.ProductNum = string.Empty;
            }

            return row;
        }

        #endregion



        #region contextMenuStrip
        private void 현재값검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle < 0)
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
            if (ds_workOrderRef.Tables.Count > 0)
            {
                if (ds_workOrderRef.Tables[0].Rows.Count > 0)
                {
                    FormGridFilter FormFilter = new FormGridFilter();

                    FormFilter.Grid넘기기(ref ds_workOrderRef, ref gridView1);
                    FormFilter.ShowDialog(this);
                }
            }
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
            if (gridView1.FocusedRowHandle < 0)
                this.gridControl1.Focus();
            else
                gridView1.FocusedColumn.Fixed = FixedStyle.Right;
        }

        private void 고정컬럼해제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle < 0)
                this.gridControl1.Focus();
            else
                gridView1.FocusedColumn.Fixed = FixedStyle.None;
        }

        #endregion

        private void frm_workOrderRef_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.WorkOrderRefClosingEvent();
        }


    }
}
