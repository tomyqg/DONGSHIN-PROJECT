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
    public partial class frm_defectiveProductsRef : Form
    {
        public frm_defectiveProductsRef()
        {
            InitializeComponent();
        }

        //불량갯수 summaryvalue 전송 이벤트
        public delegate void SendErrorCountDataHandler(int ErrorCount);
        public event SendErrorCountDataHandler SendErrorCountInfoEvent;

        //불량참조 폼이 닫힐때
        public delegate void ErrorRefClosingHandler();
        public event ErrorRefClosingHandler ErrorRefClosingEvent;


        private void frm_defectiveProductsRef_Load(object sender, EventArgs e)
        {
            ReadErrorCore();
        }


        private void ReadErrorCore() 
        {
            commonReturn Return = new commonReturn();

            Return = fx_workPerf.ReadErrorDetails(commonVar.DBconn, true, "");

            if ( Return.Message == "" )
                gridControl1.DataSource = Return.Dataset.Tables[0];
            else
                MessageBox.Show(Return.Message, "DB 에러!");
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            try
            {
                int ErrorCount = Convert.ToInt32(gridView1.Columns["qt_br"].SummaryItem.SummaryValue);
                this.SendErrorCountInfoEvent(ErrorCount);
                this.Close();
            }
            catch { }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            ClearErrorData();
            this.Close();
        }

        private void ClearErrorData() 
        {
            for ( int i = 0 ; i < gridView1.RowCount ; i++ )
            {
                DataRow row = gridView1.GetDataRow(i);
                row["qt_br"] = 0;
            }
        }

        private void frm_defectiveProductsRef_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ErrorRefClosingEvent();
        }

    }
}
