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
    public partial class frm_productRef : Form
    {
        public frm_productRef()
        {
            InitializeComponent();
            commonFX.setThisLanguage(this);
        }

        private DataSet ds_productRef = new DataSet();
        private string MoldID = string.Empty;

        public class productInformation
        {
            public string productID { get; set; }
            public string productName { get; set; }
            public string productNum { get; set; }
            public string carName { get; set; }
            public string modelName { get; set; }
            public string mtrlNum { get; set; }
            public string cavity { get; set; }
            public decimal cycleTime { get; set; }
            public string resinID { get; set; }
            public string resinName { get; set; }
            public string standardPaperURL { get; set; }
        }

        public class productsInformation
        {
            public string[] productIDs { get; set; }
            public string standardPaperURL { get; set; }
            public int selectedRows { get; set; }
        }

        //제품 1개 선택
        public delegate void SendProductDataHandler(productInformation productInfo);
        public event SendProductDataHandler SendProductInfoEvent;

        //제품 여러개 선택
        public delegate void SendProductsDataHandler(productsInformation productInfo);
        public event SendProductsDataHandler SendProductsInfoEvent;

        //제품참조 폼이 닫힐때
        public delegate void ProductRefClosingHandler();
        public event ProductRefClosingHandler ProductRefClosingEvent;

        public void setMoldID(string MoldID)
        {
            this.MoldID = MoldID;
        }


        private void frm_productRef_Load(object sender, EventArgs e)
        {
            btn_search.PerformClick();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if ( this.MoldID.Length > 0 )
            {
                findByMoldID(MoldID);
            }
            else
            {
                if ( txt_modelName.Text == "" )
                    read();
                else
                    conditionalRead();
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.SelectedRowsCount.Equals(1))
                {
                    DataRow targetRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                    productInformation selectedInfo = selectedProductInfo(targetRow);
                    this.SendProductInfoEvent(selectedInfo);
                }
                else
                {
                    int[] indexes = gridView1.GetSelectedRows();
                    int length = indexes.Length;
                    DataRow[] rows = new DataRow[length];

                    for (int i = 0; i < length; i++)
                        rows[i] = gridView1.GetDataRow(indexes[i]);

                    productsInformation selectedInfo = selectedProductsInfo(rows);

                    this.SendProductsInfoEvent(selectedInfo);
                }
                this.Close();    
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.StackTrace);
            }
           
        }

        private productInformation selectedProductInfo(DataRow targetRow)
        {
            productInformation selectedInfo = new productInformation();
            selectedInfo.productID = Convert.ToString(targetRow["jp_id"]);
            selectedInfo.productName = Convert.ToString(targetRow["jp_name"]);
            selectedInfo.productNum = Convert.ToString(targetRow["jp_num"]);
            selectedInfo.carName = Convert.ToString(targetRow["car"]);
            selectedInfo.modelName = Convert.ToString(targetRow["model"]);
            selectedInfo.mtrlNum = Convert.ToString(targetRow["mtrl_num"]);
            selectedInfo.cavity = Convert.ToString(targetRow["cavity"]);
            selectedInfo.cycleTime = Convert.ToDecimal(targetRow["cycle_t"]);
            selectedInfo.resinID = Convert.ToString(targetRow["sj_id"]);
            selectedInfo.resinName = Convert.ToString(targetRow["sj_name"]);
            selectedInfo.standardPaperURL = Convert.ToString(targetRow["jp_stdpaper"]);

            return selectedInfo;
        }

        private productsInformation selectedProductsInfo(DataRow[] rows)
        {
            productsInformation selectedInfo = new productsInformation();
            selectedInfo.selectedRows = rows.Length;
            selectedInfo.standardPaperURL = Convert.ToString(rows[0]["jp_stdpaper"]);
            selectedInfo.productIDs = new string[rows.Length];

            for ( int i = 0 ; i < rows.Length ; i++ )
            {
                selectedInfo.productIDs[i] = Convert.ToString(rows[i]["jp_id"]);
            }

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

        private void Clear() 
        {
            txt_modelName.Text = "";
            this.MoldID = string.Empty;
        }

        private void txt_modelName_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter )
                btn_search.PerformClick();
        }


        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            DataRow targetRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);

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

            Return = fx_productCode.read_all(commonVar.DBconn, "Y");
            ds_productRef.Clear();
            if ( Return.Message == "" )
            {
                ds_productRef = Return.Dataset;
                gridControl1.DataSource = Return.Dataset.Tables[0].DefaultView;
            }
            else
                MessageBox.Show(Return.Message, "DB 에러!");
        }

        private void conditionalRead()
        {
            commonReturn Return = new commonReturn();

            Return = fx_productCode.findByName(commonVar.DBconn, txt_modelName.Text, "Y");

            if ( Return.Message == "" )
            {
                ds_productRef = Return.Dataset;
                gridControl1.DataSource = Return.Dataset.Tables[0].DefaultView;
            }
            else
                MessageBox.Show(Return.Message, "DB 에러!");
        }

        private void findByMoldID(string MoldID)
        {
            commonReturn Return = new commonReturn();

            Return = fx_productCode.findByMoldID(commonVar.DBconn, MoldID);

            if ( Return.Message == "" )
            {
                ds_productRef = Return.Dataset;
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
            if ( ds_productRef.Tables.Count > 0 )
            {
                if ( ds_productRef.Tables[0].Rows.Count > 0 )
                {
                    FormGridFilter FormFilter = new FormGridFilter();

                    FormFilter.Grid넘기기(ref ds_productRef, ref gridView1);
                    FormFilter.ShowDialog(this);
                }
            }
        }
        #endregion

        private void frm_productRef_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ProductRefClosingEvent();
        }


    }//class
}//namespace
