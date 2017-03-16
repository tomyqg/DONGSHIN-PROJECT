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
    public partial class frm_nonOperationRef : Form
    {
        public frm_nonOperationRef()
        {
            InitializeComponent();
        }

        //비가동시간 summaryvalue 전송 이벤트
        public delegate void SendNonOpDataHandler(string NonOpInfo);
        public event SendNonOpDataHandler SendNonOpInfoEvent;

        //비가동참조 폼이 닫힐때
        public delegate void NonOpRefClosingHandler();
        public event NonOpRefClosingHandler NonOpClosingEvent;


        private void frm_nonOperationRef_Load(object sender, EventArgs e)
        {
            ReadNonOpCode();
        }


        private void ReadNonOpCode()
        {
            commonReturn Return = new commonReturn();

            Return = fx_workPerf.ReadBreakTimeDetails(commonVar.DBconn, true, "");

            if ( Return.Message == "" )
                gridControl1.DataSource = Return.Dataset.Tables[0];
            else
                MessageBox.Show(Return.Message, "DB 에러!");
        }


        private void btn_apply_Click(object sender, EventArgs e)
        {
            try
            {
                string NonOperationTimes = Convert.ToString(gridView1.Columns["bgd_time"].SummaryItem.SummaryValue);
                this.SendNonOpInfoEvent(NonOperationTimes);
                this.Close();
            }
            catch { }
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            ClearTimeData();
            this.Close();
        }


        private void frm_nonOperationRef_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.NonOpClosingEvent();
        }



        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if ( e.Column.FieldName.Equals("end_time") )
            {
                try
                {
                    DataRow TimeRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);

                    TimeSpan nonOperation = TimeSpan.Zero;

                    DateTime start = Convert.ToDateTime(TimeRow["start_time"]);
                    DateTime end = Convert.ToDateTime(TimeRow["end_time"]);

                    if ( start < end )
                        nonOperation = end - start;
                    else
                        nonOperation = end.AddHours(24) - start;

                    TimeRow["bgd_time"] = nonOperation;
                }
                catch { }
            }
        }

        //비가동시간 summary
        private void gridView1_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            try
            {
                if ( e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start )
                    e.TotalValue = TimeSpan.Zero;
                if ( e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Calculate )
                {
                    TimeSpan ts = TimeSpan.Parse(e.FieldValue.ToString());
                    e.TotalValue = ts + (TimeSpan)e.TotalValue;
                }
            }
            catch { }
        }



        private void ClearTimeData() 
        {
            for ( int i = 0 ; i < gridView1.RowCount ; i++ ) 
            {
                DataRow row = gridView1.GetDataRow(i);
                row["start_time"] = "00:00";
                row["end_time"] = "00:00";
                row["bgd_time"] = "00:00";
            }
        }


    }
}
