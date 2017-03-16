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
    public partial class FormAddBaseMemorymap : Form
    {
        public FormAddBaseMemorymap()
        {
            InitializeComponent();

            commonFX.setThisLanguage(this);
        }

        private DataTable excelTable;
        public string ExceptionMessage = string.Empty;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();

            string path = openFileDialog1.FileName;
            try
            {
                if ( path.Length > 0 )
                    excelTable = memorymapSettingHelper.GetDataTableFromExcel(path);
                gridControl1.DataSource = excelTable;
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)gridControl1.DataSource;
            if ( dt == null || dt.Rows.Count < 1 )
                MessageBox.Show("자료가없습니다");
            else
            {
                string exceptionString = string.Empty;

                DataTable source = (DataTable)gridControl1.DataSource;
                if ( source != null )
                    exceptionString = memorymapSettingHelper.insertBaseMemoryMap(source);
                if ( exceptionString.Length > 0 )
                    ExceptionMessage = exceptionString;

                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
