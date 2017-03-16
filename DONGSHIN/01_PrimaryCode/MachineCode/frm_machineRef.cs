﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DONGSHIN
{
    public partial class frm_machineRef : Form
    {
        public frm_machineRef()
        {
            InitializeComponent();
            commonFX.setThisLanguage(this);
        }

        private DataSet ds_machineRef = new DataSet();
        private DataRow targetRow;


        public class machineInformation
        {
            public string machineID { get; set; }
            public string machineName { get; set; }
            public string machineNum { get; set; }
            public string machineType { get; set; }
        }

        public delegate void SendMachineDataHandler(machineInformation machineInfo);
        public event SendMachineDataHandler SendMachineInfoEvent;

        //설비참조 폼이 닫힐때
        public delegate void MachineRefClosingHandler();
        public event MachineRefClosingHandler MachineRefClosingEvent;

        private void frm_machineRef_Load(object sender, EventArgs e)
        {
            btn_search.PerformClick();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if ( txt_name.Text == "" )
                read();
            else
                conditionalRead();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            targetRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            machineInformation selectedInfo = selectedMachineInfo(targetRow);
            this.SendMachineInfoEvent(selectedInfo);
            this.Close();   
        }

        private machineInformation selectedMachineInfo(DataRow row)
        {
            machineInformation selectedInfo = new machineInformation();
            selectedInfo.machineID = Convert.ToString(targetRow["MACHINE_CODE"]);
            selectedInfo.machineName = Convert.ToString(targetRow["MACHINE_NAME"]);
            selectedInfo.machineNum = Convert.ToString(targetRow["MACHINE_NUMBER"]);
            selectedInfo.machineType = Convert.ToString(targetRow["MACHINE_TYPE"]);

            return selectedInfo;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            btn_search.PerformClick();
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter )
                btn_search.PerformClick();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            targetRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if ( targetRow == null )
            {
                MessageBox.Show("선택된 항목이 없습니다.");
                return;
            }
            else
            {
                btn_select.PerformClick();
            }
        }



        #region 함수
        private void read()
        {

            commonReturn Return = new commonReturn();

            Return = fx_machineCode.read_all(commonVar.DBconn, "Y");
            ds_machineRef.Clear();
            if ( Return.Message == "" )
            {
                ds_machineRef = Return.Dataset;
                gridControl1.DataSource = Return.Dataset.Tables[0].DefaultView;
            }
            else
                MessageBox.Show(Return.Message, "DB 에러!");
        }

        private void conditionalRead()
        {
            commonReturn Return = new commonReturn();

            Return = fx_machineCode.findByName(commonVar.DBconn, txt_name.Text, "Y");

            if ( Return.Message == "" )
            {
                ds_machineRef = Return.Dataset;
                gridControl1.DataSource = Return.Dataset.Tables[0].DefaultView;
            }
            else
                MessageBox.Show(Return.Message, "DB 에러!");
        }

        #endregion



        #region contextMenuStrip
        private void 현재값검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( gridView1.FocusedRowHandle < 0 )
                this.gridControl1.Focus();
            else
                commonFX.fGrid현재값검색(gridView1);
        }

        private void 검색취소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commonFX.fGrid검색취소(gridView1);
        }

        private void grid셋팅toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormGridSetting tmF = new FormGridSetting();

            tmF.R작업받기(this.gridView1, this.lbl_title.Text);
            tmF.ShowDialog();
            this.gridControl1.Focus();
        }

        private void grid다중검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( ds_machineRef.Tables.Count > 0 )
            {
                if ( ds_machineRef.Tables[0].Rows.Count > 0 )
                {
                    FormGridFilter FormFilter = new FormGridFilter();

                    FormFilter.Grid넘기기(ref ds_machineRef, ref gridView1);
                    FormFilter.ShowDialog(this);
                }
            }
        }
        #endregion

        private void frm_machineRef_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.MachineRefClosingEvent();
        }


    }//class
}//namespace
