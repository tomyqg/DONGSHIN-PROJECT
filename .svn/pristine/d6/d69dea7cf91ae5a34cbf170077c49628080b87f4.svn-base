using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ModbusTcp;
namespace DONGSHIN
{
    public partial class mcRight_6 : BaseControl 
    {
        public mcRight_6()
        {
            InitializeComponent(); AddTextEditor();
            pt1_10.TextChanged += new EventHandler(pt1_10_TextChanged);
        }




        protected override void AddTextEditor()
        {
            //기본 정보

            TextEditors["WorkDate"] = pt1_1; //작업일자
            TextEditors["MachineName"] = pt1_2; //설비명
            TextEditors["ProductID"] = pt1_3; //제품코드
            TextEditors["Car"] = pt1_4; //차종
            TextEditors["ProductName"] = pt1_5; //품명
            TextEditors["MOLDNAME"] = pt1_6; //금형
            TextEditors["Cavity"] = pt1_7; //캐비티수
            TextEditors["A00010"] = pt1_8; //목표수량
            //TextEditors[""] = pt1_9; //UPH
            TextEditors["A00011"] = pt1_10; //생산수량
            TextEditors["AchieveRate"] = pt1_11; //달성률
            //TextEditors[""] = pt1_12; //불량수량
            //TextEditors[""] = pt1_13; //불량률
            //TextEditors[""] = pt1_14; //양품수량


            TextEditors["Memo"] = pt1_15; //특이사항
        }


        private void pt1_10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal produced = Convert.ToDecimal(pt1_10);
                decimal planned = Convert.ToDecimal(pt1_8);

                decimal result = Math.Round(produced / planned * 100, 2);

                pt1_11.EditValue = result;
            }
            catch { pt1_11.EditValue = 0; }
        }


        //작업지시 데이터 불러옴
        public Dictionary<string, string> GetWorkOrderData(string MachineCode)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            string[] columns = new string[] { "MachineName", "ProductID", "Car", "ProductName", "Cavity", "Memo" };

            data.Add("WorkDate", DateTime.Today.ToShortDateString());
            DataTable WorkOrderTable = fx_workOrder.getWorkOrderInfo(MachineCode);
            if ( WorkOrderTable != null )
            {
                DataRow row = WorkOrderTable.Rows[0];
                for ( int i = 0 ; i < columns.Length ; i++ )
                {
                    string value = Convert.ToString(row[columns[i]]);
                    data.Add(columns[i], value);
                }
            }

            return data;
        }

        //가져온 코드와 값 매칭
        public Dictionary<string, string> MatchWorkOrderData(Dictionary<string, string> WorkOrderData, Dictionary<string, string> ServerData)
        {
            string[] keys = new string[] { "WorkDate", "MachineName", "ProductID", "Car", "ProductName", "Cavity", "Memo" };

            for ( int i = 0 ; i < keys.Length ; i++ )
            {
                ServerData[keys[i]] = WorkOrderData.GetValueOrDefault(keys[i]);
            }

            if ( ServerData.ContainsKey("A00011") && ServerData.ContainsKey("A00010") && ServerData.ContainsKey("AchieveRate") )
            {
                decimal produced = Convert.ToDecimal(ServerData["A00011"]);
                decimal planned = Convert.ToDecimal(ServerData["A00010"]);
                decimal result;

                if ( planned.Equals(0) || planned.Equals(null) )
                    result = 0;
                else
                    result = Math.Round(produced / planned * 100, 2);

                ServerData["AchieveRate"] = Convert.ToString(result);
            }

            return ServerData;
        }

    }
}
