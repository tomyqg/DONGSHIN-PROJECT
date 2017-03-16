using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DONGSHIN
{
    public partial class ctl_ErrorList : UserControl
    {
        public ctl_ErrorList()
        {
            InitializeComponent();
            commonFX.setThisLanguage(this);
        }
        
        private void ctl_ErrorList_Load(object sender, EventArgs e)
        {
            ReadErrorStates();
        }

        private void ctl_ErrorList_VisibleChanged(object sender, EventArgs e)
        {
             if ( this.Visible == true )
                 ctl_ErrorList_Load(this, e);
        }

        private void ReadErrorStates() 
        {
            try 
            {                
                string[] MachinCodes;
                DataTable ErrorMachinesTable = StatusInfoHelper.getErrorMachineCount();
                if ( ErrorMachinesTable.Rows.Count > 0 ) 
                {
                    int RowCount = ErrorMachinesTable.Rows.Count;
                    MachinCodes = new string[RowCount];
                    for ( int i = 0 ; i < RowCount ; i++ ) 
                    {
                        DataRow row = ErrorMachinesTable.Rows[i];
                        MachinCodes[i] = Convert.ToString(row["MACHINE_CODE"]);
                    }

                    string today = DateTime.Today.ToShortDateString();
                    DataTable ErrorStateTable = StatusInfoHelper.getErrorStateByMachine(MachinCodes, today);

                    if ( ErrorStateTable != null )
                        gridControl1.DataSource = ErrorStateTable;
                }
                else 
                { 
                    //발생된 에러가 없을 때 
                }
                
            }
            catch { }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
