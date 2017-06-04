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

namespace DONGSHIN.WorkerMain
{
    public partial class frm_worker_main : Form ,IMenuOpener
    {

       

        memorymapMain mapSettingMain = new memorymapMain();
        private MachineInformation[] machineInformations;
        private DataTable machineInfoTable;
       
        private DevExpress.XtraEditors.TileControl selectedMenu = new DevExpress.XtraEditors.TileControl();
        private DevExpress.XtraEditors.TileControl previousSelectedMenu = new DevExpress.XtraEditors.TileControl();
        private DevExpress.XtraEditors.TileControl[] tileMenus;
        Dictionary<TileControl, UserControl> menuContents = new Dictionary<TileControl, UserControl>();
       
 
        public frm_worker_main()
        {
            InitializeComponent();
            commonFX.setThisLanguage(this);
            try
            {
                DbHelper.setSqlConnectionString(commonVar.dbConnectionString);
                machineInfoTable = DbHelper.LoadMachineList();
                //그리드 컨트롤에 맞게 테이블 컬럼 추가
                if (machineInfoTable != null)
                {
                    machineInformations = MethodMain.getMachineInformations(machineInfoTable);
                }
                else
                    throw new Exception("설비 정보가 등록되지 않았습니다.");

                initializeTileMenus();
            }
            catch (Exception ex)
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
                menu_user.Text = commonVar.CompanyName;

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                LogWriter.WriteLog_Error(ex);
            }

            menu_Click(menu_home, e);
        }


        private void initializeTileMenus()
        {
            tileMenus = new DevExpress.XtraEditors.TileControl[] { menu_mapSetting, menu_home, menu_monitor, menu_status, menu_performance, menu_logout };

            for (int i = 0; i < tileMenus.Length; i++)
            {
                tileMenus[i].MouseClick += new MouseEventHandler(menu_Click);
            }
        }


        private void menu_Click(object sender, EventArgs e)
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
                    SelectMenu(new MenuHome() 
                    { 
                        Opener = this,
                        MachineInformations = this.machineInformations 
                    });
                    break;

                case "menu_monitor":
                    Cursor = Cursors.WaitCursor;
                    SelectMenu(new MenuMonitoring()
                    {
                        Opener = this,
                        MachineInformations = machineInformations
                    });
                    Cursor = Cursors.Default;
                    break;

                case "menu_mapSetting":
                    SelectMenu(new memorymapMain());
                    break;

                case "menu_status":
                    SelectMenu(new ctl_InjectionCondition()
                    {
                        Opener=this
                    });
                    break;

                case "menu_performance":
                    SelectMenu(new WorkPerformanceMain());
                    break;

                case "menu_logout":
                    frm_login login = new frm_login();
                    OpenNewForm(login);
                    break;
               
            }

        }

        private void moveToPreviousControl()
        {
            menu_Click(previousSelectedMenu, null);
        }

        private void menu_swap_Click(object sender, EventArgs e)
        {
            if (commonVar.user_gbn == "M")
            {
                menu_swap.BackgroundImage = menu_swap.AppearanceItem.Selected.Image;
                selectedMenu.BackgroundImage = selectedMenu.AppearanceItem.Normal.Image;
               
                this.Cursor = Cursors.WaitCursor;
                
                frm_manager_home manager = new frm_manager_home();
                Program.ac.MainForm = manager;
                manager.Show();
                this.Close();
                this.Cursor = Cursors.Default;
            }
            else
            {
                MessageBox.Show("접근 권한이 없습니다. \n\r관리자모드로 접속하세요.", "사용자모드 주의");
            }
        }


        void SelectMenu(UserControl menu)
        {
            pan_center.Controls.Clear();
            menu.Dock = DockStyle.Fill;
            pan_center.Controls.Add(menu);
        }

        public void OpenNewForm(Form form)
        {
            Program.ac.MainForm = form;
            form.Show();
            this.Close();
        }

        public void OpenDefaultContent()
        {
            SelectMenu(new MenuHome()
            {
                Opener = this,
                MachineInformations = this.machineInformations
            });
        }
    }//class
}//namespace
