using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Mvvm;
using System.Threading;
using DevExpress.XtraBars.Navigation;

namespace DONGSHIN
{
    public partial class frm_manager_home : Form
    {
        public frm_manager_home()
        {
            InitializeComponent();
            Thread.Sleep(500); 
            commonFX.setThisLanguage(this);
        }

        #region  메뉴에 해당하는 컨트롤 생성
        ctl_empcode emp = new ctl_empcode();
        ctl_deptCode dept = new ctl_deptCode();
        ctl_dutyCode duty = new ctl_dutyCode();
        ctl_bizCode biz = new ctl_bizCode();
        ctl_commonCode common = new ctl_commonCode();
        ctl_machineCode machine = new ctl_machineCode();
        ctl_moldCode mold = new ctl_moldCode();
        ctl_productCode product = new ctl_productCode();
        ctl_resinCode resin = new ctl_resinCode();
        ctl_errorCode error = new ctl_errorCode();
        ctl_defectiveProductsCode defective = new ctl_defectiveProductsCode();
        ctl_nonOperationCode nonOP = new ctl_nonOperationCode();

        ctl_DBPermission permission = new ctl_DBPermission();

        ctl_workOrder order = new ctl_workOrder();
        ctl_workperformance perform = new ctl_workperformance();

        ctl_InjectionCondition injection = new ctl_InjectionCondition();

        ctl_ErrorStates errorState = new ctl_ErrorStates();
        #endregion

        public enum moduleType 
        { 
            unknown,

            //기초코드
            empCode,
            deptCode,
            dutyCode,
            bizCode,
            commonCode,
            machineCode,
            moldCode,
            productCode,
            resinCode,
            errorCode,
            defectiveProductsCode,
            nonOperationCode,

            //생산관리
            workOrder,
            workPerformance,

            //현황정보
            injectCondition,
            errorState,

            //시스템
            permission

        }

        private void frm_manager_home_Load(object sender, EventArgs e)
        {
            menuSettingByUserID();

            lbl_user.Text = commonVar.login_name;

            //메뉴 불러온 후 화면 전환을 위해 tag 다시 셋팅 
            //menu_~ : 상위메뉴, sub_~ : 드롭다운 메뉴
            menu_primarycode.Tag = moduleType.empCode; 
            sub_empCode.Tag = moduleType.empCode;
            sub_deptCode.Tag = moduleType.deptCode;
            sub_bizCode.Tag = moduleType.bizCode;
            sub_duty.Tag = moduleType.dutyCode;
            sub_common.Tag = moduleType.commonCode;
            sub_machine.Tag = moduleType.machineCode;
            sub_mold.Tag = moduleType.moldCode;
            sub_product.Tag = moduleType.productCode;
            sub_resinCode.Tag = moduleType.resinCode;
            sub_errorCode.Tag = moduleType.errorCode;
            sub_defectiveProducts.Tag = moduleType.defectiveProductsCode;
            sub_nonOperation.Tag = moduleType.nonOperationCode;

            menu_system.Tag = moduleType.permission;
            sub_permission.Tag = moduleType.permission;

            menu_manufacture.Tag = moduleType.workOrder;
            sub_workorder.Tag = moduleType.workOrder;
            sub_workperformance.Tag = moduleType.workPerformance;

            menu_conditionmanage.Tag = moduleType.injectCondition;
            sub_inejctCondition.Tag = moduleType.injectCondition;
            sub_errorBreak.Tag = moduleType.errorState;

            menu_monitoring.Tag = moduleType.unknown;


            //상위메뉴 이벤트
            menu_bar.SelectedItemChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(menu_click);
            menu_bar.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(menu_click);

            //드롭다운메뉴 이벤트
            sub_bar_primarycode.SelectedItemChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(sub_click);
            sub_bar_primarycode.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(sub_click);
            sub_bar_manufacture.SelectedItemChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(sub_click);
            sub_bar_manufacture.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(sub_click);
            sub_bar_system.SelectedItemChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(sub_click);
            sub_bar_system.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(sub_click);
            sub_bar_state.SelectedItemChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(sub_click);
            sub_bar_state.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(sub_click);

        }



        
        #region 함수

        private void menuSettingByUserID()
        {
            //권한에 따라 메뉴 출력 설정

            List<TileBarItem> menuItems = new List<TileBarItem>();

            //상위메뉴
            foreach ( TileBarItem upperMenuItem in ((TileBarGroup)tileBarGroup1).Items )
                menuItems.Add(upperMenuItem);

            //기초코드의 하위메뉴
            foreach ( TileBarItem dropdownMenuItem1 in ((TileBarGroup)tileBarGroup2).Items )
                menuItems.Add(dropdownMenuItem1);

            //생산관리의 하위메뉴
            foreach ( TileBarItem dropdownMenuItem2 in ((TileBarGroup)tileBarGroup3).Items )
                menuItems.Add(dropdownMenuItem2);

            //현황정보의 하위메뉴
            foreach ( TileBarItem dropdownMenuItem3 in ((TileBarGroup)tileBarGroup4).Items )
                menuItems.Add(dropdownMenuItem3);

            //시스템의 하위메뉴
            foreach ( TileBarItem dropdownMenuItem4 in ((TileBarGroup)tileBarGroup5).Items )
                menuItems.Add(dropdownMenuItem4);

            commonReturn Return2 = new commonReturn();
            Return2 = fx_DBPermission.findByID(commonVar.DBconn, commonVar.login_id);
            if ( Return2.Message == "" )
            {
                commonVar.userPermissionInfo = Return2.Dataset.Tables[0];

                foreach ( TileBarItem items in menuItems )
                {
                    string menuID = "";

                    if ( items.Tag != null )
                        menuID = items.Tag.ToString();

                    if ( searchMenuTag(menuID) )
                        items.Visible = true;
                    else
                        items.Visible = false;
                }

                menu_switch.Visible = true;
            }
            else
            {
                foreach ( TileBarItem items in menuItems )
                {
                    items.Visible = false;
                }
                MessageBox.Show("권한 설정 읽어오기 실패", "에러");
            }

        }

        private bool searchMenuTag(string menuID)
        {
            for ( int i = 0 ; i < commonVar.userPermissionInfo.Rows.Count ; i++ )
            {
                DataRow target = commonVar.userPermissionInfo.Rows[i];
                if ( (target["child_id"].ToString() == menuID) || (target["parent_id"].ToString() == menuID) )
                    return true;
            }

            return false;
        }

        void setSelect(Control ctl)
        {
            if ( ctl.Visible == false )
                ctl.Visible = true;
            ctl.Parent = pan_container;
            ctl.Dock = DockStyle.Fill;
            ctl.BringToFront();
        }

        #endregion


        #region 메뉴 클릭 이벤트 관련 함수

        private void sub_click(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
                if ( transitionManager.IsTransition )
                    transitionManager.EndTransition();

                transitionManager.StartTransition(pan_container);

                try
                {
                    if ( e.Item.Tag is moduleType )
                    {
                        string menu = Convert.ToString((moduleType)e.Item.Tag);

                        switch ( menu )
                        {
                            case "empCode":                                
                                setSelect(emp); 
                                break;

                            case "deptCode":
                                setSelect(dept);
                                break;

                            case "dutyCode":
                                setSelect(duty);
                                break;

                            case "bizCode":
                                setSelect(biz);
                                break;

                            case "commonCode":
                                setSelect(common);
                                break;

                            case "machineCode":
                                setSelect(machine);
                                break;

                            case "moldCode":
                                setSelect(mold);
                                break;

                            case "productCode":
                                setSelect(product);
                                break;

                            case "resinCode":
                                setSelect(resin);
                                break;

                            case "errorCode":
                                setSelect(error);
                                break;

                            case "defectiveProductsCode":
                                setSelect(defective);
                                break;

                            case "nonOperationCode":
                                setSelect(nonOP);
                                break;

                            case "permission":
                                setSelect(permission);
                                break;

                            case "workOrder":
                                setSelect(order);
                                break;

                            case "workPerformance":
                                setSelect(perform);
                                break;

                            case "injectCondition":
                                setSelect(injection);
                                break;

                            case "errorState":
                                setSelect(errorState);
                                break;

                            default:
                                break;
                        }
                    }
                }
                finally { transitionManager.EndTransition(); }

                menu_bar.HideDropDownWindow();

        }

        private void menu_click(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if ( transitionManager.IsTransition )
                transitionManager.EndTransition();

            if ( e.Item.Name.ToString() == "menu_monitoring" ) 
            {
                e.Item.AppearanceItem.Assign(menu_bar.AppearanceItem.Normal);
            }
            else
            {
                transitionManager.StartTransition(pan_container);
                
                try
                {
                    if ( e.Item.Tag is moduleType )
                    {
                        string menu = Convert.ToString((moduleType)e.Item.Tag);

                        switch ( menu )
                        {
                            case "empCode":
                                if ( sub_empCode.Visible )
                                    setSelect(emp);
                                break;

                            case "workOrder":
                                if ( sub_workorder.Visible )
                                    setSelect(order);
                                break;

                            case "permission":
                                if ( sub_permission.Visible )
                                    setSelect(permission);
                                break;

                            case "injectCondition":
                                if ( sub_inejctCondition.Visible )
                                    setSelect(injection);
                                break;

                            default:
                                break;
                        }
                    }
                }
                finally { transitionManager.EndTransition(); }

            }
            menu_bar.HideDropDownWindow();
        }

        #endregion

        private void menu_switch_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frm_worker_main worker = new frm_worker_main();
            Program.ac.MainForm = worker;
            worker.Show();
            this.Close();
        }





    }//클래스
}//네임스페이스
