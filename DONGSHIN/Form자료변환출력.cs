using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using DevExpress.XtraEditors;
using DevExpress.XtraExport;
using DevExpress.XtraGrid.Export;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraPrinting;
using System.Threading;

namespace DONGSHIN
{
    public partial class Form자료변환출력 : Form
    {
        DevExpress.XtraGrid.Views.Grid.GridView gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();

        String n작업 = "";

        //-------------------------------------------------------------------------------------------------------------
        public Form자료변환출력()
        {
            InitializeComponent();
            commonFX.setThisLanguage(this);
        }

        //
        // 기본값받기
        //
        //-------------------------------------------------------------------------------------------------------------
        public void Grid받기(String r제목, String r작업, DevExpress.XtraGrid.Views.Grid.GridView gridView2)
        {
            this.label_제목.Text = r제목;
            n작업 = r작업;
            gridView1 = gridView2;
        }

        //
        // XLS 화일변환
        //
        //-------------------------------------------------------------------------------------------------------------
        private void simpleXLS_Click(object sender, EventArgs e)
        {
            String fileName = ShowSaveFileDialog("Microsoft Excel Document", "Microsoft Excel|*.xls");
            if (fileName != "")
            {
               // gridView1.BestFitColumns();
                //XlsExportOptions xo = new XlsExportOptions();
                //xo.TextExportMode = TextExportMode.Text;
                //xo.ShowGridLines = true;
                //xo.SheetName = "test";
                gridView1.OptionsPrint.AutoWidth = false;
                //gridView1.ExportToXls(fileName, xo);
                gridView1.ExportToXls(fileName);
                OpenFile(fileName);
            }
        }


        //
        // TXT 화일변환
        //
        //-------------------------------------------------------------------------------------------------------------
        private void simpleTXT_Click(object sender, EventArgs e)
        {
            String fileName = ShowSaveFileDialog("Text Document", "Text Files|*.txt");
            if (fileName != "")
            {
                gridView1.ExportToText(fileName);
                OpenFile(fileName);
            }
        }

        //
        // XML 화일변환
        //
        //-------------------------------------------------------------------------------------------------------------
        private void simpleXML_Click(object sender, EventArgs e)
        {
            String fileName = ShowSaveFileDialog("XML Document", "XML Documents|*.xml");
            if (fileName != "")
            {
                gridView1.ExportToMht(fileName);
                OpenFile(fileName);
            }
        }

        //
        // HTML 화일변환
        //
        //-------------------------------------------------------------------------------------------------------------
        private void simpleHML_Click(object sender, EventArgs e)
        {
            String fileName = ShowSaveFileDialog("HTML Document", "HTML Documents|*.html");
            if (fileName != "")
            {
                gridView1.ExportToHtml(fileName); 
                OpenFile(fileName);
            }
        }

        //
        // HTML 화일변환
        //
        //-------------------------------------------------------------------------------------------------------------
        private void simplePDF_Click(object sender, EventArgs e)
        {
            String fileName = ShowSaveFileDialog("PDF Document", "PDF Documents|*.pdf");
            if ( fileName != "" )
            {

                gridView1.ExportToPdf(fileName);
                OpenFile(fileName);
            }
        }



        //-------------------------------------------------------------------------------------------------------------
        private void OpenFile(String fileName)
        {
            if (MessageBox.Show("Do you want to open this file?", "Export To...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.FileName = fileName;
                    process.StartInfo.Verb = "Open";
                    process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                    process.Start();
                }
                catch
                {
                    MessageBox.Show(this, "Cannot find an application on your system suitable for openning the file with exported data.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            BarExport.Position = 0;
        }


        //-------------------------------------------------------------------------------------------------------------
        private string ShowSaveFileDialog(String title, String filter)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            String name = n작업 + Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day);

            int n = name.LastIndexOf(".") + 1;
            if (n > 0) name = name.Substring(n, name.Length - n);
            dlg.Title = "Export To " + title;
            dlg.FileName = name;
            dlg.Filter = filter;
            if (dlg.ShowDialog() == DialogResult.OK) return dlg.FileName;
            return "";
        }

        //-------------------------------------------------------------------------------------------------------------
        private void Export_Progress(object sender, DevExpress.XtraGrid.Export.ProgressEventArgs e)
        {
            if (e.Phase == DevExpress.XtraGrid.Export.ExportPhase.Link)
            {
                BarExport.Position = e.Position;
                this.Update();
            }
        }

        //-------------------------------------------------------------------------------------------------------------
        private void sbutton_닫기_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}