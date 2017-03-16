using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace DONGSHIN
{
    public partial class WorkPerformanceMain : UserControl
    {
        public WorkPerformanceMain()
        {
            InitializeComponent();
            TileMenuInitialize();
            ChartInitialize();
        }

        private class ProductInformation 
        {
            public string[] ProductIDs { get; set; }
            public string ProductStdPaper { get; set; }
        }

        ProductInformation ProductInfo = new ProductInformation();
        TileControl[] TileMenus;
       private void WorkPerformanceMain_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Today.ToShortDateString();
           
        }

       private void TileMenuInitialize() 
       {
           TileMenus = new TileControl[] { MenuWorkOrder, MenuMachine, MenuMold, MenuProduct, MenuResin, MenuStart, MenuStop, MenuSave,
                                                        MenuBreak, MenuError, MenuBarcode, MenuStdPaper};

           for ( int i = 0 ; i < TileMenus.Length ; i++ )
           {
               TileMenus[i].MouseClick += new MouseEventHandler(TileMenu_Click);               
           }

           MenuMachine.MouseClick += new MouseEventHandler(MenuMachine_Click);
           MenuWorkOrder.MouseClick += new MouseEventHandler(MenuWorkOrder_Click);
           MenuMold.MouseClick += new MouseEventHandler(MenuMold_Click);
           MenuProduct.MouseClick += new MouseEventHandler(MenuProduct_Click);
           MenuBreak.MouseClick += new MouseEventHandler(MenuBreak_Click);
           MenuError.MouseClick += new MouseEventHandler(MenuError_Click);
           MenuStdPaper.MouseClick += new MouseEventHandler(MenuStdPaper_Click);
           MenuStart.MouseClick += new MouseEventHandler(MenuStart_Click);
           MenuStop.MouseClick += new MouseEventHandler(MenuStop_Click);
           MenuSave.MouseClick += new MouseEventHandler(MenuSave_Click);
       }

       private void TileMenu_Click(object sender, EventArgs e) 
       {
           TileControl SelectedMenu = sender as TileControl;

           for ( int i = 0 ; i < TileMenus.Length ; i++ ) 
           {
               if ( SelectedMenu.Equals(TileMenus[i]) )
                   TileMenus[i].BackgroundImage = TileMenus[i].AppearanceItem.Selected.Image;
               else
                   TileMenus[i].BackgroundImage = TileMenus[i].AppearanceItem.Normal.Image;
           }
           
       }


       private void TileMenu_Leave()
       {
           foreach ( TileControl tile in TileMenus )
           {
               tile.BackgroundImage = tile.AppearanceItem.Normal.Image;
           }
       }



        private void WorkTimeTimer_Tick(object sender, EventArgs e)
        {            
            TimeSpan ts = (TimeSpan)WorkTimeSpan.EditValue;
            WorkTimeSpan.EditValue = ts.Add(TimeSpan.FromSeconds(1));
        }



        private void MenuMachine_Click(object sender, EventArgs e)
        {
            frm_machineRef machineRef = new frm_machineRef();
            machineRef.SendMachineInfoEvent += new frm_machineRef.SendMachineDataHandler(setMachineInfo);
            machineRef.MachineRefClosingEvent += new frm_machineRef.MachineRefClosingHandler(TileMenu_Leave);
            machineRef.ShowDialog();
        }

        private void setMachineInfo(frm_machineRef.machineInformation selectedMachineInfo)
        {
            labelMachineName.Text = selectedMachineInfo.machineName;
            labelMachineName.Tag = selectedMachineInfo.machineID;
            labelMachineNum.Text = selectedMachineInfo.machineNum;
            labelMachineType.Text = selectedMachineInfo.machineType;
        }

        private void MenuMold_Click(object sender, EventArgs e)
        {
            frm_moldRef moldRef = new frm_moldRef();

            if ( labelMachineName.Text.Length > 0 )
                moldRef.setMachineID(Convert.ToString(labelMachineName.Tag));

            moldRef.SendMoldInfoEvent += new frm_moldRef.SendMoldDataHandler(setMoldInfo);
            moldRef.MoldRefClosingEvent += new frm_moldRef.MoldRefClosingHandler(TileMenu_Leave);
            moldRef.ShowDialog();
        }

        private void setMoldInfo(frm_moldRef.moldInformation selectedMoldInfo)
        {
            textMoldCode.Text = selectedMoldInfo.moldID;
            textMoldProductNum.Text = selectedMoldInfo.moldNum;
            textMoldProduct.Text = selectedMoldInfo.moldName;
            textMoldModel.Text = selectedMoldInfo.moldModel;
            textMoldCavity.Text = selectedMoldInfo.moldCavity;
            textMoldShot.EditValue = selectedMoldInfo.moldShot;
            
        }

        private void MenuProduct_Click(object sender, EventArgs e)
        {
            frm_productRef productRef = new frm_productRef();

            if ( textMoldCode.Text.Length > 0 )
                productRef.setMoldID(textMoldCode.Text);

            productRef.SendProductsInfoEvent += new frm_productRef.SendProductsDataHandler(setProductsInfo);
            productRef.SendProductInfoEvent += new frm_productRef.SendProductDataHandler(setProductInfo);
            productRef.ProductRefClosingEvent += new frm_productRef.ProductRefClosingHandler(TileMenu_Leave);
            productRef.ShowDialog();
        }

        private void setProductsInfo(frm_productRef.productsInformation selectedProductInfo)
        {
            int count = selectedProductInfo.selectedRows;
            ProductInfo.ProductStdPaper = selectedProductInfo.standardPaperURL;
            ProductInfo.ProductIDs = new string[count];
            for ( int i = 0 ; i < count ; i++ )
            {
                ProductInfo.ProductIDs[i] = selectedProductInfo.productIDs[i];
            }

            DataTable table = PerformanceSettingHelper.getProductsInformation(ProductInfo.ProductIDs);
            if ( table != null )
                gridControl1.DataSource = table;

        }

        private void setProductInfo(frm_productRef.productInformation selectedProductInfo)
        {
            //단일제품선택
            ProductInfo.ProductStdPaper = selectedProductInfo.standardPaperURL;
            ProductInfo.ProductIDs = new string[1];
            ProductInfo.ProductIDs[0] = selectedProductInfo.productID;

            DataTable table = PerformanceSettingHelper.getProductsInformation(ProductInfo.ProductIDs);
            if ( table != null )
                gridControl1.DataSource = table;

        }

        private void MenuWorkOrder_Click(object sender, EventArgs e)
        {
            frm_workOrderRef workOrderRef = new frm_workOrderRef();
            workOrderRef.SendWorkOrderInfoEvent += new frm_workOrderRef.SendWorkOrderDataHandler(setWorkOrderInfo);
            workOrderRef.WorkOrderRefClosingEvent += new frm_workOrderRef.WorkOrderRefClosingHandler(TileMenu_Leave);
            workOrderRef.ShowDialog();
        }


        private void setWorkOrderInfo(frm_workOrderRef.workOrderInformation selectedWorkOrderInfo)
        {
            textMoldCavity.Text = selectedWorkOrderInfo.MoldCavity;
            textMoldCode.Text = selectedWorkOrderInfo.MoldID;
            textMoldModel.Text = selectedWorkOrderInfo.MoldModel;
            textMoldProduct.Text = selectedWorkOrderInfo.MoldName;
            textMoldProductNum.Text = selectedWorkOrderInfo.MoldNum;
            textMoldShot.EditValue = selectedWorkOrderInfo.MoldShot;

            commonReturn ProductInfo = fx_productCode.findByID(commonVar.DBconn, selectedWorkOrderInfo.ProductID);
            DataTable table = ProductInfo.Dataset.Tables[0];
            DataColumn col = new DataColumn("qt_plan", typeof(int));
            col.DefaultValue = selectedWorkOrderInfo.PlannedQty;
            table.Columns.Add(col);
            gridControl1.DataSource = table;

            labelMachineName.Text = selectedWorkOrderInfo.MachineName;
            labelMachineName.Tag = selectedWorkOrderInfo.MachineID;
            labelMachineNum.Text = Convert.ToString(selectedWorkOrderInfo.MachineNum);
            labelMachineType.Text = selectedWorkOrderInfo.MachineType;
        }



        private void MenuBreak_Click(object sender, EventArgs e)
        {
            frm_nonOperationRef nonOperation = new frm_nonOperationRef();
            nonOperation.SendNonOpInfoEvent += new frm_nonOperationRef.SendNonOpDataHandler(setNonOperationInfo);
            nonOperation.NonOpClosingEvent += new frm_nonOperationRef.NonOpRefClosingHandler(TileMenu_Leave);
            nonOperation.ShowDialog();
        }

        private void setNonOperationInfo(string NonOperationTimes)
        {
            BreakTimeSpan.EditValue = NonOperationTimes;
        }






        private void TimeCalculate(object sender, EventArgs e)
        {
            try
            {
                DateTime start = Convert.ToDateTime(StartTimeEdit.Text);
                DateTime end = Convert.ToDateTime(EndTimeEdit.Text);
                TimeSpan OperationTime = start - end;
                TimeSpan breakTime = (TimeSpan)BreakTimeSpan.EditValue;

                start = start.Add(breakTime);

                if ( start > end )
                    end = end.AddHours(24);

                TimeSpan worktime = end - start;
                WorkTimeSpan.EditValue = worktime;

                setChartData(chartControl2,worktime, breakTime);
            }
            catch ( Exception ex ) { MessageBox.Show(ex.Message); }
        }



        private void MenuError_Click(object sender, EventArgs e)
        {
            frm_defectiveProductsRef defectiveProducts = new frm_defectiveProductsRef();
            defectiveProducts.SendErrorCountInfoEvent += new frm_defectiveProductsRef.SendErrorCountDataHandler(setErrorCountInfo);
            defectiveProducts.ErrorRefClosingEvent += new frm_defectiveProductsRef.ErrorRefClosingHandler(TileMenu_Leave);
            defectiveProducts.ShowDialog();
        }

        private void setErrorCountInfo(int ErrorCount) 
        {
            int DefectiveProducts = ErrorCount;
        }


        private void MenuStdPaper_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow row = gridView1.GetDataRow(0);
                if ( row != null )
                {
                    string StdPaperURL = Convert.ToString(row["jp_stdpaper"]);
                    string ProductName = Convert.ToString(row["jp_name"]);

                    if ( StdPaperURL.Equals("no image") || StdPaperURL.Length.Equals(0) )
                    {
                        MessageBox.Show("해당 제품의 작업표준서가 존재하지 않습니다.");
                    }
                    else
                    {
                        frm_imageContainer imgContainer;
                        Screen sc = Screen.PrimaryScreen;
                        int width = sc.WorkingArea.Width;
                        int height = sc.WorkingArea.Height;
                        string title = ProductName + " 작업표준서";
                        imgContainer = new frm_imageContainer(width, height, StdPaperURL, title);

                        imgContainer.Show();
                    }
                }
                else { TileMenu_Leave(); }
            }
            catch { }
        }

        private void ChartInitialize() 
        {
            Series[] mySerieses = new Series[] { chartControl1.Series[0], chartControl2.Series[0], chartControl3.Series[0] };
            for ( int i = 0 ; i < mySerieses.Length ; i++ ) 
            {
                Series series = mySerieses[i];

                series.Points.Add(new SeriesPoint("Any Value1",10));
                series.Points.Add(new SeriesPoint("Any Value2", 20));
                series.Points.Add(new SeriesPoint("Any Value2", 30));
                series.Points.Add(new SeriesPoint("Any Value2", 40));
                series.Points.Add(new SeriesPoint("Any Value2", 50));
            }
        }



        private void setChartData(ChartControl chart, object data1, object data2) 
        {
            Series mySeries = chart.Series[0];

            double d1=0, d2=0;            

            switch ( chart.Name ) 
            { 
                case "chartControl1":
                case "chartControl3":
                    d1 = Convert.ToDouble(data1);
                    d2 = Convert.ToDouble(data2);
                    break;

                case "chartControl2":
                    d1 = TimespanToDouble((TimeSpan)data1);
                    d2 = TimespanToDouble((TimeSpan)data2);
                    break;                    
            }                       

            SeriesPoint Point1 = new SeriesPoint("Data1",d1);
            SeriesPoint Point2 = new SeriesPoint("Data2",d2);
            SeriesPoint[] Points = new SeriesPoint[] { Point1, Point2 };
            
            mySeries.Points.Clear();
            mySeries.Points.AddRange(Points);
        }


        private double TimespanToDouble(TimeSpan ts) 
        {
            double hour = ts.Hours;
            double minute = ts.Minutes;
            double second = ts.Seconds;

            double result = hour * 3600 + minute*60 + second;

            return result;
        }

        private void MenuStart_Click(object sender, EventArgs e)
        {
            if ( StartTimeEdit.Tag.ToString() == "Ready" )
            {
                StartTimeEdit.Tag = "Started";
                StartTimeEdit.EditValue = DateTime.Now;
            }
            labelStartedOrNot.Text = "가동중";
            WorkTimeTimer.Start();
            ovalShape1.FillColor = Color.FromArgb(46, 81, 154);
        }

        private void MenuStop_Click(object sender, EventArgs e)
        {
            labelStartedOrNot.Text = "비가동";
            WorkTimeTimer.Stop();
            ovalShape1.FillColor = Color.FromName("Crimson");
        }

        private void MenuSave_Click(object sender, EventArgs e)
        {
            WorkPerformanceDataSave();
        }

        private bool WorkPerformanceDataSave() 
        {
            try
            {
                string workPerfID = Regex.Replace(DateTime.Now.ToString() + DateTime.Now.Millisecond.ToString(), @"\D", "");
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Clear();
                cmd.Parameters.Add("@siljeok_id", SqlDbType.VarChar, 25).Value = workPerfID;

                cmd.Parameters.Add("@work_date", SqlDbType.VarChar, 10).Value = Convert.ToString(labelDate.Text);
                cmd.Parameters.Add("@start_time", SqlDbType.VarChar, 5).Value = string.Format("{0:HH:mm}", StartTimeEdit.EditValue);
                cmd.Parameters.Add("@end_time", SqlDbType.VarChar, 5).Value = string.Format("{0:HH:mm}", EndTimeEdit.EditValue);
                cmd.Parameters.Add("@work_time", SqlDbType.VarChar, 5).Value = string.Format("{0:HH:mm}", WorkTimeSpan.EditValue);
                cmd.Parameters.Add("@bgd_time", SqlDbType.VarChar, 5).Value = string.Format("{0:HH:mm}", BreakTimeSpan.EditValue);

                //cmd.Parameters.Add("@qt_total", SqlDbType.Int).Value = Convert.ToInt32(txt_perf.EditValue);
                //cmd.Parameters.Add("@qt_manuf", SqlDbType.Int).Value = Convert.ToInt32(txt_manuf.EditValue);
                //cmd.Parameters.Add("@qt_init", SqlDbType.Int).Value = Convert.ToInt32(txt_init.EditValue);
                //cmd.Parameters.Add("@qt_error", SqlDbType.Int).Value = Convert.ToInt32(txt_error.EditValue);          

                string result = fx_workPerf.WritePerformanceByUser(cmd);

                if ( result.Length.Equals(0) )
                    return true;
                else
                {
                    MessageBox.Show(result,"작업실적 저장 실패");
                    return false;
                }
            }
            catch { return false; }
        }

        

        private void ClearToDefaultValue() 
        { 
            
        }


    }
}