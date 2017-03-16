using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace DONGSHIN
{
    public partial class FormGridSetting : Form
    {
        DevExpress.XtraGrid.Views.Grid.GridView gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();

        String n제목 = "";

        //-------------------------------------------------------------------------------------------------------------
        public FormGridSetting()
        {
            InitializeComponent();
        }

        /// 
        /// 작업값받기
        //-------------------------------------------------------------------------------------------------------------
        public void R작업받기(DevExpress.XtraGrid.Views.Grid.GridView r_gridView, String r_제목)
        {
            n제목 = r_제목.Replace(" ", "");
            gridView1 = r_gridView;
        }

        //-------------------------------------------------------------------------------------------------------------
        private void FormGridSetting_Load(object sender, EventArgs e)
        {
            //CtrlInfo_설정();

            this.spinEdit1.Value = gridView1.ColumnPanelRowHeight;
            this.spinEdit2.Value = gridView1.RowHeight;

            InitOptions(gridView1.OptionsView, checkedListBoxControl1);
        }

        //-------------------------------------------------------------------------------------------------------------
        private void InitOptions(object options, DevExpress.XtraEditors.CheckedListBoxControl checkedListBox)
        {
            ArrayList arr = DevExpress.Utils.SetOptions.GetOptionNames(options);
            for (int i = 0; i < arr.Count; i++)
                checkedListBox.Items.Add(new DevExpress.XtraEditors.Controls.CheckedListBoxItem
                    (arr[i], DevExpress.Utils.SetOptions.OptionValueByString(arr[i].ToString(), options)));
        }

        //<checkedListBoxControl1>
        //-------------------------------------------------------------------------------------------------------------
        private void checkedListBoxControl1_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            bool optionSet = e.State == CheckState.Checked ? true : false;
            string option = checkedListBoxControl1.GetDisplayItemValue(e.Index).ToString();
            DevExpress.Utils.SetOptions.SetOptionValueByString(option, gridView1.OptionsView, optionSet);
        }

        //-------------------------------------------------------------------------------------------------------------
        private void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {
            gridView1.ColumnPanelRowHeight = Convert.ToInt16(this.spinEdit1.Value);
        }

        //-------------------------------------------------------------------------------------------------------------
        private void spinEdit2_EditValueChanged(object sender, EventArgs e)
        {
            gridView1.RowHeight = Convert.ToInt16(this.spinEdit2.Value);
        }

        //-------------------------------------------------------------------------------------------------------------
        private void sbutton_저장_Click(object sender, EventArgs e)
        {
            Cursor hCursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;
            commonFX.Layout_Save(this.gridView1, n제목);
            this.Cursor = hCursor;
            this.Close();
        }


        //-------------------------------------------------------------------------------------------------------------
        private void sbutton_삭제_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult nRet;
                nRet = MessageBox.Show("Layout을 초기화 할까요?", "초기화", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (nRet == DialogResult.Yes)
                {
                    Cursor hCursor = this.Cursor;
                    this.Cursor = Cursors.WaitCursor;
                    commonFX.Layout_Dele(n제목);
                    this.Cursor = hCursor;
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("초기화 도중에 에러가 발생하였습니다.\n\r\n\r나중에 다시 하세요.", "에러");
            }
        }
        //</checkedListBoxControl1>
    }
}