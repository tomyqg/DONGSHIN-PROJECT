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
    public partial class MachineMonitoringControl : UserControl
    {
        public MachineMonitoringControl()
        {
            InitializeComponent();
            
        }

        public delegate void ControlClosed();
        public event ControlClosed controlClose;


        public void addMachineContorls(ModbusTcp.MachineInformation[] machineInformations)
        {
            
            this.Visible = false;
            for (int i = 0; i < machineInformations.Length; i++)
            {
                MachineListControl listControl = new MachineListControl(machineInformations[i]);
                listControl.monitorDoubleClick += monitoringDoubleClick;
                tableLayoutPanel1.Controls.Add(listControl);
                commonFX.setThisLanguage(listControl);
            }
            this.Visible = true;
            
        }

        private void monitoringDoubleClick(ModbusTcp.MachineInformation information)
        {
            frm_worker_home home = new frm_worker_home(information);
            Program.ac.MainForm = home;
            home.Show();

            if (controlClose != null)
                controlClose();
        }

        private void MachineMonitoringControl_ParentChanged(object sender, EventArgs e)
        {
            Console.WriteLine("parent : "+this.Parent);
            if (this.Parent == null)
            {
                foreach (Control s in tableLayoutPanel1.Controls)
                {
                    MachineListControl control = s as MachineListControl;
                    if (control != null)
                        control.StopTimer();
                }

            }
        }

        //설비 4대에 대한 정보 요청


    }
}
