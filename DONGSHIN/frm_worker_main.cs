using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Collections;
using ModbusTcp;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using System.Threading;
using System.Net;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;

namespace DONGSHIN
{
    public partial class frm_worker_main : Form
    {

        public enum MachineStateImageIndex
        {
            Alert = 0, Slow = 1, Manual = 2, SemiAuto = 3, FullAuto = 4 , Null = -1
        }

        memorymapMain mapSettingMain = new memorymapMain();
        private MachineInformation[] machineInformations;
        private DataTable machineInfoTable;
        private System.Timers.Timer dataRefreshTimer = new System.Timers.Timer();

        private DevExpress.XtraEditors.TileControl[] tileMenus;
        private DevExpress.XtraEditors.TileControl selectedMenu = new DevExpress.XtraEditors.TileControl();
        private DevExpress.XtraEditors.TileControl previousSelectedMenu = new DevExpress.XtraEditors.TileControl();

        private string[] machineCodes = new string[] { };
        private bool IsServerOn;

        private long latestRowClickTime = 0;
        private int lastestRowHandle = -1;
        public frm_worker_main()
        {
            InitializeComponent();
            initializeTileMenus();
            commonFX.setThisLanguage(this);

            DbHelper.setSqlConnectionString(commonVar.dbConnectionString);
            if ( commonVar.DBconn.State == ConnectionState.Closed )
                commonVar.DBconn.Open();
            try
            {
                machineInfoTable = DbHelper.LoadMachineList();
                //그리드 컨트롤에 맞게 테이블 컬럼 추가
                if (machineInfoTable != null)
                {
                    machineInfoTable.Columns.Add("STATE", typeof(int));
                    machineInfoTable.Columns.Add("MESSAGE", typeof(string));
                    machineInfoTable.Columns.Add("productQty", typeof(string));
                    machineInfoTable.Columns.Add("qt_plan", typeof(string));
                    machineInformations = MethodMain.getMachineInformations(machineInfoTable);
                }
                else
                    throw new Exception("설비 정보가 등록되지 않았습니다.");

                machineCodes = new string[machineInformations.Length];

                for (int i = 0; i < machineCodes.Length; i++)
                {
                    machineCodes[i] = machineInformations[i].MachineCode;
                }

            }
            catch(Exception ex)
            {
                LogWriter.WriteLog_Error(ex);
                //MessageBox.Show(ex.Message);
            }
        }


     

        private void frm_worker_main_Load(object sender, EventArgs e)
        {            
            try
            {
                if (commonVar.IsThisServer)
                {
                    if (commonVar.IsServerRunning == false)
                    {
                        MethodMain.StartServerMode(machineInformations, commonVar.ServerPrivatePort);
                        commonVar.IsServerRunning = true;
                    }
                }
                else
                {
                    string serverIp = commonVar.ServerPublicIpAddress;
                    int serverPort = commonVar.ServerPublicPort;
                    MethodMain.StartClientMode(serverIp, serverPort);
                }


                string date = string.Format("{0:yyyy.MM.dd}", DateTime.Today);
                lbl_verdate.Text = date + "\r\nv" + commonVar.version;
                lbl_user.Text = commonVar.login_name;

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                LogWriter.WriteLog_Error(ex);
            }

            mouse_click(menu_home, e);
        }


        private void initializeTileMenus()
        {
            tileMenus = new DevExpress.XtraEditors.TileControl[] { menu_mapSetting, menu_home, menu_monitor, menu_status, menu_performance, menu_logout };

            for ( int i = 0 ; i < tileMenus.Length ; i++ )
            {              
                tileMenus[i].MouseClick += new MouseEventHandler(mouse_click);
            }

        }


        private void mouse_click(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.TileControl menu = sender as DevExpress.XtraEditors.TileControl;

            if(menu != selectedMenu)
            {
                previousSelectedMenu = selectedMenu;
            }

            selectedMenu = menu;
            for (int index = 0; index < tileMenus.Length; index++)
            {
                DevExpress.XtraEditors.TileControl tileMenu = tileMenus[index];
                if (selectedMenu == tileMenu)
                {
                    tileMenu.BackgroundImage = tileMenu.AppearanceItem.Selected.Image;
                }
                else
                {
                    tileMenu.BackgroundImage = tileMenu.AppearanceItem.Normal.Image;
                }
            }

         string name = ((TileControl)sender).Name;
            switch ( name )
            {
                case "menu_home":
                    pan_center.Controls.Clear();
                    pan_center.Controls.Add(gridControl1);
                    getStateAndDisplay();
                    break;

                case "menu_monitor":
                     pan_center.Controls.Clear();
                    this.Cursor = Cursors.WaitCursor;
                    MachineMonitoringControl monitoring = new MachineMonitoringControl();
                    monitoring.controlClose += new MachineMonitoringControl.ControlClosed(this.Close); 
                    monitoring.Dock = DockStyle.Fill;
                    pan_center.Controls.Add(monitoring);
                    monitoring.addMachineContorls(machineInformations);
                    this.Cursor = Cursors.Default;
                    break;

                case "menu_logout":
                    frm_login login = new frm_login();
                    Program.ac.MainForm = login;
                    login.Show();
                    this.Close();
                    break;
                case "menu_mapSetting":
                    pan_center.Controls.Clear();
                    mapSettingMain.Parent = pan_center;
                    mapSettingMain.Dock = DockStyle.Fill;
                    mapSettingMain.BringToFront();
                    break;

                case "menu_status":
                    pan_center.Controls.Clear();
                    ctl_InjectionCondition injCondition = new ctl_InjectionCondition();
                    injCondition.controlClose += new ctl_InjectionCondition.controlClosed(moveToPreviousControl);
                    injCondition.Parent = pan_center;
                    injCondition.Dock = DockStyle.Fill;
                    injCondition.BringToFront();
                    break;

                case "menu_performance":
                    pan_center.Controls.Clear();
                    WorkPerformanceMain performance = new WorkPerformanceMain();
                    performance.Parent = pan_center;
                    performance.Dock = DockStyle.Fill;
                    performance.BringToFront();
                    break;
            }

        }

        private void moveToPreviousControl()
        {
            mouse_click(previousSelectedMenu, null);
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            long currentClickTime = DateTime.Now.Ticks / 10000;
            if (currentClickTime - latestRowClickTime < 300 && e.RowHandle == lastestRowHandle)
            {
                string machineCode = gridView1.GetDataRow(e.RowHandle)["MACHINE_CODE"].ToString();
                MachineInformation [] informations = machineInformations.AsEnumerable().Where(x => x.MachineCode == machineCode).ToArray();
          
                MachineInformation information = informations[0];
                frm_worker_home home = new frm_worker_home(information);
                Program.ac.MainForm = home;
                home.Show();
                this.Close();
            }

            latestRowClickTime = currentClickTime;
            lastestRowHandle = e.RowHandle;
        }

        private void stateUpdateTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                getStateAndDisplay();
            }
            catch(Exception ex)
            {
                LogWriter.WriteLog_Error(ex);
            }
            
        }

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

        /// <summary>
        /// 통신 오류 발생시 서버 off인걸로 판단. 메시지 팝업 이후 타이머 동작 X
        /// </summary>
        /// <param name="tcpResponse"></param>
        private void DisplayMachineState(TcpResponse tcpResponse)
        {
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
                    DataRow gridSourceTableRow = machineInfoTable.Rows[i];
                    MachineResponseData responseData = machineResponse[i];
                    if (responseData.Message.Length > 0)
                    {
                        //사출기 문제발생
                        message = responseData.Message;
                    }
                    else if(responseData.IsConnected == false){
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
                            gridSourceTableRow["STATE"] = (int)state;
                            gridSourceTableRow["qt_plan"] = machineState.GetValueOrDefault("S00002");
                            gridSourceTableRow["productQty"] = machineState.GetValueOrDefault("A00011");
                            message = "통신 정상 작동 중";
                        }
                    }
                    gridSourceTableRow["MESSAGE"] = message;
                }

                IsServerOn = true;
            }

            DataTable source = machineInfoTable.Copy();
            setGridControlSource(source);
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

        private void frm_worker_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            stateUpdateTimer.Dispose();
            pan_center.Controls.Clear();
        }

      

        
    }//class
}//namespace
