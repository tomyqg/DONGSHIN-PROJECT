using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ModbusTcp;

namespace DONGSHIN.WorkerMain
{
    public partial class MenuMonitoring : UserControl
    {
        public IMenuOpener Opener { get; set; }
        MachineInformation[] machineInformations;
        public MachineInformation[] MachineInformations {
            get{ return machineInformations;}
            set
            {
                machineInformations = value;
                if (machineInformations != null)
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
            }
        }

        public MenuMonitoring()
        {
            InitializeComponent();
        }

        private void monitoringDoubleClick(ModbusTcp.MachineInformation information)
        {
            if (Opener != null)
                Opener.OpenNewForm(new frm_worker_home(information));
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
