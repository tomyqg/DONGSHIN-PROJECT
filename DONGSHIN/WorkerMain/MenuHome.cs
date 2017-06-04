using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using ModbusTcp;

namespace DONGSHIN.WorkerMain
{
    public enum MachineStateImageIndex
    {
        Alert = 0, Slow = 1, Manual = 2, SemiAuto = 3, FullAuto = 4, Null = -1
    }

    public partial class MenuHome : UserControl
    {
        private long latestRowClickTime = 0;
        private int lastestRowHandle = -1;
        Dictionary<string, string> moldNames = new Dictionary<string, string>();
        private string[] machineCodes = new string[] { };
        Timer dataRefreshTimer;

        public IMenuOpener Opener { get; set; }

        private MachineInformation[] machineInformations;
        public MachineInformation[] MachineInformations
        {
            get { return machineInformations; }
            set
            {
                machineInformations = value;
                machineCodes = new string[machineInformations.Length];
                for (int i = 0; i < machineCodes.Length; i++)
                {
                    machineCodes[i] = machineInformations[i].MachineCode;
                }
            }
        }

        public MenuHome()
        {
            InitializeComponent();
            gridView1.RowClick += gridView1_RowClick;
            dataRefreshTimer = new Timer();
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            long currentClickTime = DateTime.Now.Ticks / 10000;
            if (currentClickTime - latestRowClickTime < 300 && e.RowHandle == lastestRowHandle)
            {
                string machineCode = gridView1.GetDataRow(e.RowHandle)["MACHINE_CODE"].ToString();
                MachineInformation[] informations = MachineInformations.AsEnumerable().Where(x => x.MachineCode == machineCode).ToArray();

                MachineInformation information = informations[0];
                frm_worker_home home = new frm_worker_home(information);

                if (Opener != null)
                    Opener.OpenNewForm(home);
            }

            latestRowClickTime = currentClickTime;
            lastestRowHandle = e.RowHandle;
        }

        private void MenuHome_Load(object sender, EventArgs e)
        {
            getMoldNames();
            getStateAndDisplay();
            dataRefreshTimer.Tick += (senders, es) =>
            {
                getMoldNames();
                getStateAndDisplay();
            };
            dataRefreshTimer.Interval = 2000;
            dataRefreshTimer.Enabled = true;
        }

        private delegate void setGridSource(DataTable source);
        private void setGridControlSource(DataTable source)
        {
            try
            {
                if (gridControl1.InvokeRequired)
                {
                    setGridSource callback = new setGridSource(setGridControlSource);
                    this.Invoke(callback, new object[] { source });
                }
                else
                {
                    int focusedRowHandle = gridView1.FocusedRowHandle;
                    gridControl1.DataSource = source;
                    gridView1.FocusedRowHandle = focusedRowHandle;
                }
            }
            catch
            {
            }

        }

        /// <summary>
        /// 타이머 가동시킬것
        /// </summary>
        private void getStateAndDisplay()
        {
            DataDisplayParameter parameter1 = new DataDisplayParameter();
            parameter1.MachineCodes = this.machineCodes;
            parameter1.FieldCodes = SpecialFieldCodes.stateCodes;
            DataDisplayCallback callback1 = new DataDisplayCallback(DisplayMachineState);
            parameter1.Callback = callback1;

            if (commonVar.IsThisServer)
            {
                MethodMain.showMachineDataFromServer(parameter1);
            }
            else
            {
                MethodMain.showMachineDataFromClient(parameter1);
            }
        }

        private void getMoldNames()
        {
            DataDisplayParameter parameter1 = new DataDisplayParameter();
            parameter1.MachineCodes = this.machineCodes;
            parameter1.FieldCodes = SpecialFieldCodes.moldNameCodes;
            DataDisplayCallback callback1 = new DataDisplayCallback(DisplayMoldName);
            parameter1.Callback = callback1;

            if (commonVar.IsThisServer)
            {
                MethodMain.showMachineDataFromServer(parameter1);
            }
            else
            {
                MethodMain.showMachineDataFromClient(parameter1);
            }
        }

        private void DisplayMoldName(TcpResponse tcpResponse)
        {
            MachineResponseData[] machineResponse = tcpResponse.MachineResponses;
            if (tcpResponse.Exception != null)
            {
                LogWriter.WriteLog_Error(tcpResponse.Exception);
            }
            else
            {
                //정상
                for (int i = 0; i < machineResponse.Length; i++)
                {
                    Dictionary<string, string> machineData = machineResponse[i].MachineData;
                    string[] fieldCodes = machineData.Keys.ToArray();
                    string moldName = string.Empty;
                    for (int j = 0; j < machineData.Count; j++)
                    {
                        string fieldCode = fieldCodes[j];
                        string valueString = machineData.GetValueOrDefault(fieldCode);
                        decimal valueDecimal;
                        if (decimal.TryParse(valueString, out valueDecimal))
                        {
                            char charA = (char)(valueDecimal / 256);
                            char charB = (char)(valueDecimal % 256);
                            moldName += charA;
                            moldName += charB;
                        }
                    }
                    moldNames[machineResponse[i].MachineCode] = moldName;
                }
            }

        }

        /// <summary>
        /// 통신 오류 발생시 서버 off인걸로 판단. 메시지 팝업 이후 타이머 동작 X
        /// </summary>
        /// <param name="tcpResponse"></param>
        private void DisplayMachineState(TcpResponse tcpResponse)
        {
            DataTable sourceTable = createGridSource();
            if (tcpResponse.Exception != null)
            {
                LogWriter.WriteLog_Error(tcpResponse.Exception);
            }
            else
            {
                string message = string.Empty;
                MachineResponseData[] machineResponse = tcpResponse.MachineResponses;

                //정상
                for (int i = 0; i < machineResponse.Length; i++)
                {
                    DataRow dataRow = sourceTable.NewRow();
                    MachineResponseData responseData = machineResponse[i];
                    if (responseData.Message.Length > 0)
                    {
                        //사출기 문제발생
                        message = responseData.Message;
                    }
                    else if (responseData.IsConnected == false)
                    {
                        message = "통신 연결 안됨";
                    }
                    else
                    {
                        Dictionary<string, string> machineState = responseData.MachineData;
                        if (machineState != null)
                        {
                            MachineStateImageIndex state = MachineStateImageIndex.Null;
                            if (machineState.GetValueOrDefault("A00007") == "1")
                                state = MachineStateImageIndex.Alert;
                            else if (machineState.GetValueOrDefault("A00001") == "1")
                                state = MachineStateImageIndex.Slow;
                            else if (machineState.GetValueOrDefault("A00002") == "1")
                                state = MachineStateImageIndex.Manual;
                            else if (machineState.GetValueOrDefault("A00003") == "1")
                                state = MachineStateImageIndex.SemiAuto;
                            else if (machineState.GetValueOrDefault("A00004") == "1")
                                state = MachineStateImageIndex.FullAuto;
                            else
                                state = MachineStateImageIndex.Null;
                            //state 1 저속개폐 2 수동 3 세미오토 4 풀오토
                            dataRow["STATE"] = (int)state;
                            dataRow["targetQty"] = machineState.GetValueOrDefault("S00002");
                            dataRow["productQty"] = machineState.GetValueOrDefault("A00011");
                            message = "통신 정상 작동 중";
                        }
                    }
                    dataRow["MESSAGE"] = message;
                    string machineCode = responseData.MachineCode;
                    MachineInformation machineInfo = machineInformations.First(x => x.MachineCode == machineCode);
                    dataRow["MACHINE_CODE"] = machineCode;
                    dataRow["MACHINE_NAME"] = machineInfo.MachineName;
                    dataRow["MACHINE_NUMBER"] = machineInfo.MachineNumber;
                    dataRow["MACHINE_TYPE"] = machineInfo.MachineType;
                    if (moldNames.ContainsKey(machineCode))
                        dataRow["moldName"] = moldNames[machineCode];
                    sourceTable.Rows.Add(dataRow);
                }
            }

            setGridControlSource(sourceTable);
        }

        DataTable createGridSource()
        {
            DataTable table = new DataTable();
            table.Columns.Add("MACHINE_CODE", typeof(string));
            table.Columns.Add("MACHINE_NAME", typeof(string));
            table.Columns.Add("MACHINE_NUMBER", typeof(int));
            table.Columns.Add("MACHINE_TYPE", typeof(string));
            table.Columns.Add("moldName", typeof(string));
            table.Columns.Add("STATE", typeof(int));
            table.Columns.Add("MESSAGE", typeof(string));
            table.Columns.Add("targetQty", typeof(string));
            table.Columns.Add("productQty", typeof(string));

            return table;
        }

        private void MenuHome_ParentChanged(object sender, EventArgs e)
        {
            if (this.Parent == null)
                dataRefreshTimer.Stop();
        }



    }
}
