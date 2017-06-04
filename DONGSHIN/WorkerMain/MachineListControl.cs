using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DONGSHIN.WorkerMain
{
    public partial class MachineListControl : UserControl
    {
        public Dictionary<string, Control> dataControls = new Dictionary<string, Control>();
        private Color colorRed = Color.FromArgb(232,56,40);
        private Color colorGray = Color.FromArgb(76, 93, 110);
        private Color colorYellow = Color.FromArgb(242,150,0);
        private Color colorBlue = Color.FromArgb(103, 169, 210);
        private Color colorShallowWhite = Color.FromArgb(248, 248, 248);

        private Color colorMc = Color.FromArgb(77, 126, 147);
        private Color colorGb = Color.FromArgb(85, 178, 212);
        private Color colorRb = Color.FromArgb(3, 110, 183);
        private Color colorKt = Color.FromArgb(77, 102, 142);
        private Color colorPL = Color.FromArgb(77, 125, 145);

        public delegate void MonitorDoubleClick(ModbusTcp.MachineInformation information);
        public event MonitorDoubleClick monitorDoubleClick;

        private void initializeControls()
        {

            stateAlarm.BackColor = colorBlue;
            stateDriveMode.BackColor = colorBlue;
            stateMotor.BackColor = colorBlue;
            stateHeater.BackColor = colorBlue;
            controlCoolingWaterIn.BackColor = colorShallowWhite;
            controlCoolingWaterOut.BackColor = colorShallowWhite;
            controlOil.BackColor = colorShallowWhite;
            controlMoldTemp1.BackColor = colorShallowWhite;
            controlMoldTemp2.BackColor = colorShallowWhite;
            controlNozzle.BackColor = colorShallowWhite;
            controlH1.BackColor = colorShallowWhite;
            controlH2.BackColor = colorShallowWhite;
            controlH3.BackColor = colorShallowWhite;
            controlH4.BackColor = colorShallowWhite;
            controlMakingTime.BackColor = colorShallowWhite;
            controlTargetCount.BackColor = colorShallowWhite;
            controlCurrentCount.BackColor = colorShallowWhite;

            dataControls["A00014"] = controlMakingTime;
            dataControls["S00002"] = controlTargetCount;
            dataControls["A00011"] = controlCurrentCount;

            dataControls["A00045"] = controlNozzle;
            dataControls["A00046"] = controlH1;
            dataControls["A00047"] = controlH2;
            dataControls["A00048"] = controlH3;
            dataControls["A00049"] = controlH4; 
      
            //다른 항목 추가필요

        }



        private string MACHINE_CODE;
        private string MACHINE_NUMBER;
        private ModbusTcp.MachineInformation machineInformation;
        public MachineListControl()
        {
            InitializeComponent();
            initializeCharts();
            initializeControls();
        }

        ~MachineListControl()
        {
            try
            {
                StopTimer();
            }
            catch
            {
            }
            
        }

        public MachineListControl(ModbusTcp.MachineInformation machineInfo)
        {
            InitializeComponent();
            initializeCharts();
            initializeControls();
            this.MACHINE_CODE = machineInfo.MachineCode;
            this.machineInformation = machineInfo;

            labelMachineType.Text = machineInfo.MachineType;
            labelMachineNumber.Text = machineInfo.MachineNumber.ToString();

            switch (machineInfo.MachineType.ToUpper())
            {
                case "GB":
                    panelMachineImage.BackgroundImage =(Image)(Properties.Resources.img_GB);
                    panelMachineType.BackColor = colorGb;
                    break;
                case "RB":
                    panelMachineImage.BackgroundImage =(Image)(Properties.Resources.img_RB);
                    panelMachineType.BackColor = colorRb;
                    break;
                case "PL":
                    panelMachineImage.BackgroundImage = (Image)(Properties.Resources.img_MC);
                    panelMachineType.BackColor = colorPL;
                    break;
                case "KT":
                    panelMachineImage.BackgroundImage = (Image)(Properties.Resources.img_MC);
                    panelMachineType.BackColor = colorKt;
                    break;
            }

            getMachineDataAndDisplay();
            getMoldNameAndDisplay();
            getMachineStateAndDisplay();
            
           

            StartTimer();

            
        }

        private void stateMonitor_Load(object sender, EventArgs e)
        {
            Console.WriteLine("stateMonitor_load");
            this.stateMonitor.itemDoubleClick += new MachineStateItemControl.StateItemDoubleClicked(stateItemDoubleClicked);


        }

        private void stateItemDoubleClicked(string name)
        {
            Console.WriteLine("name : " + name);
            if(name.Equals("stateMonitor"))
                monitorDoubleClick(this.machineInformation);
        }


        private void initializeCharts()
        {
            Series[] mySerieses = new Series[] { chart1.Series[0] };
            Color [] colors = new Color[] {Color.Red, Color.SkyBlue, Color.Gray};
            for (int i = 0; i < mySerieses.Length; i++)
            {
                Series series = mySerieses[i];
                series.ChartType = SeriesChartType.Doughnut;
                //chart에서 라벨 숨기기
                series["PieLabelStyle"] = "Disabled";
                //chart 포인트 시작점 12시부터
                series["PieStartAngle"] = "270";
                //두께지정
                series["DoughnutRadius"] = "30";

                int[] values = new int[] { 5, 30, 100 };
                for (int j = 0; j < 3; j++)
                {
                    series.Points.Add(values[j]);
                    series.Points[j].Color = colors[j];
                }
            }
            
        }

        public void setChartLeft(int badCount, int currentCount, int targetCount)
        {
            Series series = chart1.Series[0];
            int restCount = targetCount - currentCount;
            if (restCount < 0) restCount = 0;
            int[] values = new int[] { badCount, currentCount, restCount };
            Color[] colors = new Color[] { Color.Red, Color.SkyBlue, Color.Gray };
            double percentage = (double)((double)currentCount / (double)targetCount) * 100;
            percentage = Math.Round(percentage, 2);
            setControlText(labelPercent1,  percentage.ToString());

            //series.Points.Clear();
            for (int j = 0; j < 3; j++)
            {
                series.Points[j].SetValueY(values[j]);
            }
            
        }




        private void getMachineDataAndDisplay()
        {
            ModbusTcp.DataDisplayParameter parameter1 = new ModbusTcp.DataDisplayParameter();
            parameter1.MachineCodes = new string[] { MACHINE_CODE };
            parameter1.FieldCodes = dataControls.Keys.ToArray();
            ModbusTcp.DataDisplayCallback callback1 = new ModbusTcp.DataDisplayCallback(DisplayMachineData);
            parameter1.Callback = callback1;


            if (commonVar.IsThisServer)
            {
                ModbusTcp.MethodMain.showMachineDataFromServer(parameter1);
            }
            else
            {
                ModbusTcp.MethodMain.showMachineDataFromClient(parameter1);
            }
        }

        private void getMoldNameAndDisplay()
        {
            string[] fieldCodesForMoldname = ModbusTcp.SpecialFieldCodes.moldNameCodes;
            ModbusTcp.DataDisplayParameter parameter1 = new ModbusTcp.DataDisplayParameter();
            parameter1.MachineCodes = new string[] { MACHINE_CODE };
            parameter1.FieldCodes = fieldCodesForMoldname;
            ModbusTcp.DataDisplayCallback callback1 = new ModbusTcp.DataDisplayCallback(DisplayMoldName);
            parameter1.Callback = callback1;


            if (commonVar.IsThisServer)
            {
                ModbusTcp.MethodMain.showMachineDataFromServer(parameter1);
            }
            else
            {
                ModbusTcp.MethodMain.showMachineDataFromClient(parameter1);
            }
        }

        private void getMachineStateAndDisplay()
        {
            string[] stateFieldCodes = ModbusTcp.SpecialFieldCodes.stateCodes;
            ModbusTcp.DataDisplayParameter parameter1 = new ModbusTcp.DataDisplayParameter();
            parameter1.MachineCodes = new string[] { MACHINE_CODE };
            parameter1.FieldCodes = stateFieldCodes;
            ModbusTcp.DataDisplayCallback callback1 = new ModbusTcp.DataDisplayCallback(DisplayMachineState);
            parameter1.Callback = callback1;


            if (commonVar.IsThisServer)
            {
                ModbusTcp.MethodMain.showMachineDataFromServer(parameter1);
            }
            else
            {
                ModbusTcp.MethodMain.showMachineDataFromClient(parameter1);
            }
        }

        private void DisplayMachineData(ModbusTcp.TcpResponse tcpResponse)
        {
            if (tcpResponse.Exception == null)
            {
                ModbusTcp.MachineResponseData responseData = tcpResponse.MachineResponses[0];
                if (responseData.Message.Length > 0)
                {
                    //사출기 문제발생
                }
                else
                {
                    Dictionary<string, string> machineData = responseData.MachineData;
                    string[] fieldCodes = machineData.Keys.ToArray();
                    for (int i = 0; i < fieldCodes.Length; i++)
                    {
                        string fieldCode = fieldCodes[i];
                        if (dataControls.ContainsKey(fieldCode))
                        {
                            setControlText(dataControls[fieldCode], machineData[fieldCode]);
                        }
                    }

                    try
                    {
                        decimal tCount;
                        decimal cCount;
                        int targetCount;
                        int currentCount;
                        if (decimal.TryParse(machineData["S00002"], out tCount)
                            && decimal.TryParse(machineData["A00011"], out cCount))
                        {
                            targetCount = Convert.ToInt32(tCount);
                            currentCount = Convert.ToInt32(cCount);
                            setChartLeft(0, currentCount, targetCount);
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                    }
                }
            }
            else
            {
                ModbusTcp.LogWriter.WriteLog_Error(tcpResponse.Exception);
            }
        }



        private void DisplayMoldName(ModbusTcp.TcpResponse tcpResponse)
        {
            if (tcpResponse.Exception == null)
            {
                ModbusTcp.MachineResponseData responseData = tcpResponse.MachineResponses[0];
                if (responseData.Message.Length > 0)
                {
                    //사출기 문제발생
                }
                else
                {
                    Dictionary<string, string> machineData = responseData.MachineData;
                    string[] fieldCodes = machineData.Keys.ToArray();
                    string moldName = string.Empty;
                    for (int i = 0; i < machineData.Count; i++)
                    {
                        string fieldCode = fieldCodes[i];
                        string valueString = machineData.ContainsKey(fieldCode)
                            ? machineData[fieldCode] : "";
                        decimal valueDecimal;
                        if (decimal.TryParse(valueString, out valueDecimal))
                        {
                            char charA = (char)(valueDecimal / 256);
                            char charB = (char)(valueDecimal % 256);
                            moldName += charA;
                            moldName += charB;
                        }
                    }
                    //금형명 표기
                    setControlText(labelMoldName, moldName);
                }


            }
            else
            {
                ModbusTcp.LogWriter.WriteLog_Error(tcpResponse.Exception);
            }

        }


        private void DisplayMachineState(ModbusTcp.TcpResponse tcpResponse)
        {
            string mode = string.Empty;
            if (tcpResponse.Exception == null)
            {
                ModbusTcp.MachineResponseData responseData = tcpResponse.MachineResponses[0];
                if (responseData.Message.Length > 0)
                {
                    //사출기 문제발생
                }
                else if (responseData.IsConnected == false)
                {
                    if ( commonVar.whichLang == "English" )
                        mode = "No Response";
                    else
                        mode = "연결안됨";
                    setControlText(stateDriveMode, mode, (Image)(Properties.Resources.lostConnection_iconOnly));
                }
                else
                {
                    Dictionary<string, string> machineState = responseData.MachineData;                    

                    if (machineState["A00007"].Equals("1"))
                    {
                        //경보 on
                        setControlBackColor(stateAlarm, colorRed);
                    }
                    else
                    {
                        //경보 off
                        setControlBackColor(stateAlarm, colorBlue);
                    }

                    if (machineState["A00001"].Equals("1"))
                    {
                        //저속개폐
                        if (commonVar.whichLang == "English")
                            mode = "Mold setup";
                        else
                            mode = "저속개폐";
                        setControlText(stateDriveMode, mode, (Image)(Properties.Resources.slow_icononly));
                    }
                    else if (machineState["A00002"].Equals("1"))
                    {
                        //수동운전
                        if (commonVar.whichLang == "English")
                            mode = "Manual";
                        else
                            mode = "수동";
                        setControlText(stateDriveMode, mode, (Image)(Properties.Resources.manual_icononly));
                    }
                    else if (machineState["A00003"].Equals("1"))
                    {
                        //semi auto
                        if (commonVar.whichLang == "English")
                            mode = "Semi Auto";
                        else
                            mode = "반자동";
                        setControlText(stateDriveMode, mode, (Image)(Properties.Resources.semiauto_icononly));
                    }
                    else if (machineState["A00004"].Equals("1"))
                    {
                        //full auto
                        if (commonVar.whichLang == "English")
                            mode = "Full Auto";
                        else
                            mode = "자동";
                        setControlText(stateDriveMode, mode, (Image)(Properties.Resources.fullauto_icononly));
                    }
                    else//가끔 전부다 0인 경우가 있음
                    {
                        setControlText(stateDriveMode, mode);
                    }

                    if (machineState["A00005"].Equals("1"))
                    {
                        //1사이클 완료
                        //flash 혹은 다른 방법
                    }

                    if (machineState["A00008"].Equals("1"))
                    {
                        //히터 on
                        setControlBackColor(stateHeater, colorRed);
                    }
                    else
                    {
                        //히터 off
                        setControlBackColor(stateHeater, colorBlue);
                    }


                    if (machineState["A00009"].Equals("1"))
                    {
                        //모터 on
                        setControlBackColor(stateMotor, colorYellow);
                    }
                    else
                    {
                        //모터 off
                        setControlBackColor(stateMotor, colorBlue);
                    }
                }
            }
            else
            {
                if ( commonVar.whichLang == "English" )
                    mode = "No Response";
                else
                    mode = "연결안됨";
                setControlText(stateDriveMode, mode, (Image)(Properties.Resources.lostConnection_iconOnly));
                ModbusTcp.LogWriter.WriteLog_Error(tcpResponse.Exception);
            }
        }

        private delegate void controlBackColorSetter(Control control, Color color);
        private void setControlBackColor(Control control, Color color)
        {
            try
            {
                if (control.InvokeRequired)
                {
                    controlBackColorSetter callback = new controlBackColorSetter(setControlBackColor);
                    control.Invoke(callback, new object[] { control,color });
                }
                else
                {
                    control.BackColor = color;
                }
            }
            catch { }
        }
        
        private delegate void controlTextSetter(Control control, string text = "", Image image = null);
        private void setControlText(Control control, string text = "", Image image = null)
        {
            try
            {
                if (control.InvokeRequired)
                {
                    controlTextSetter callback = new controlTextSetter(setControlText);
                    control.Invoke(callback, new object[] { control, text, image });
                }
                else
                {
                    control.BackgroundImage = image;
                    control.Text = text;
                }
            }
            catch { }
        }

        public void StartTimer()
        {
            if(dataUpdateTimer.Enabled == false)
                dataUpdateTimer.Start();
        }
        public void StopTimer()
        {
            dataUpdateTimer.Stop();
        }

        private void dataUpdateTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                getMachineDataAndDisplay();
                getMoldNameAndDisplay();
                getMachineStateAndDisplay();
            }
            catch
            {
            }
     
        }


       

      

        
    }
}
