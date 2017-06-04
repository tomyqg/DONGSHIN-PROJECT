namespace DONGSHIN.WorkerMain
{
    partial class MachineListControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelMainRight = new System.Windows.Forms.TableLayoutPanel();
            this.controlCoolingWaterOut = new MachineValueItemControl();
            this.controlCoolingWaterIn = new MachineValueItemControl();
            this.controlMoldTemp2 = new MachineValueItemControl();
            this.controlMoldTemp1 = new MachineValueItemControl();
            this.controlH4 = new MachineValueItemControl();
            this.controlH3 = new MachineValueItemControl();
            this.controlH2 = new MachineValueItemControl();
            this.controlH1 = new MachineValueItemControl();
            this.controlNozzle = new MachineValueItemControl();
            this.controlCurrentCount = new MachineValueItemControl();
            this.controlTargetCount = new MachineValueItemControl();
            this.stateMonitor = new MachineStateItemControl();
            this.stateHeater = new MachineStateItemControl();
            this.stateMotor = new MachineStateItemControl();
            this.stateAlarm = new MachineStateItemControl();
            this.stateDriveMode = new MachineStateItemControl();
            this.controlMakingTime = new MachineValueItemControl();
            this.controlOil = new MachineValueItemControl();
            this.panelMainLeft = new System.Windows.Forms.TableLayoutPanel();
            this.panelChart = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPercent1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelMoldName = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMoldName = new System.Windows.Forms.Label();
            this.panelMachineNumber = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMachineNumber = new System.Windows.Forms.Label();
            this.panelMachineType = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMachineType = new System.Windows.Forms.Label();
            this.panelMachineImage = new System.Windows.Forms.Panel();
            this.dataUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.panelMainRight.SuspendLayout();
            this.panelMainLeft.SuspendLayout();
            this.panelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panelMoldName.SuspendLayout();
            this.panelMachineNumber.SuspendLayout();
            this.panelMachineType.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainRight
            // 
            this.panelMainRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panelMainRight.ColumnCount = 5;
            this.panelMainRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelMainRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelMainRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelMainRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelMainRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelMainRight.Controls.Add(this.controlCoolingWaterOut, 3, 3);
            this.panelMainRight.Controls.Add(this.controlCoolingWaterIn, 2, 3);
            this.panelMainRight.Controls.Add(this.controlMoldTemp2, 1, 3);
            this.panelMainRight.Controls.Add(this.controlMoldTemp1, 0, 3);
            this.panelMainRight.Controls.Add(this.controlH4, 4, 2);
            this.panelMainRight.Controls.Add(this.controlH3, 3, 2);
            this.panelMainRight.Controls.Add(this.controlH2, 2, 2);
            this.panelMainRight.Controls.Add(this.controlH1, 1, 2);
            this.panelMainRight.Controls.Add(this.controlNozzle, 0, 2);
            this.panelMainRight.Controls.Add(this.controlCurrentCount, 3, 1);
            this.panelMainRight.Controls.Add(this.controlTargetCount, 1, 1);
            this.panelMainRight.Controls.Add(this.stateMonitor, 4, 0);
            this.panelMainRight.Controls.Add(this.stateHeater, 3, 0);
            this.panelMainRight.Controls.Add(this.stateMotor, 2, 0);
            this.panelMainRight.Controls.Add(this.stateAlarm, 1, 0);
            this.panelMainRight.Controls.Add(this.stateDriveMode, 0, 0);
            this.panelMainRight.Controls.Add(this.controlMakingTime, 0, 1);
            this.panelMainRight.Controls.Add(this.controlOil, 4, 3);
            this.panelMainRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMainRight.Location = new System.Drawing.Point(470, 0);
            this.panelMainRight.Name = "panelMainRight";
            this.panelMainRight.RowCount = 4;
            this.panelMainRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelMainRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelMainRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelMainRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelMainRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelMainRight.Size = new System.Drawing.Size(400, 400);
            this.panelMainRight.TabIndex = 0;
            // 
            // controlCoolingWaterOut
            // 
            this.controlCoolingWaterOut.BorderBottom = true;
            this.controlCoolingWaterOut.BorderColor = System.Drawing.Color.Gray;
            this.controlCoolingWaterOut.BorderLeft = true;
            this.controlCoolingWaterOut.BorderRight = false;
            this.controlCoolingWaterOut.BorderTop = false;
            this.controlCoolingWaterOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlCoolingWaterOut.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.controlCoolingWaterOut.Location = new System.Drawing.Point(240, 300);
            this.controlCoolingWaterOut.Margin = new System.Windows.Forms.Padding(0);
            this.controlCoolingWaterOut.Name = "controlCoolingWaterOut";
            this.controlCoolingWaterOut.Padding = new System.Windows.Forms.Padding(1);
            this.controlCoolingWaterOut.Size = new System.Drawing.Size(80, 100);
            this.controlCoolingWaterOut.TabIndex = 17;
            this.controlCoolingWaterOut.TextTitle = "(℃)";
            this.controlCoolingWaterOut.TextTitleSize = 8;
            this.controlCoolingWaterOut.TextUnit = "냉각수OUT";
            this.controlCoolingWaterOut.TextUnitSize = 8;
            this.controlCoolingWaterOut.TextValue = "";
            this.controlCoolingWaterOut.TextValueSize = 15;
            // 
            // controlCoolingWaterIn
            // 
            this.controlCoolingWaterIn.BorderBottom = true;
            this.controlCoolingWaterIn.BorderColor = System.Drawing.Color.Gray;
            this.controlCoolingWaterIn.BorderLeft = true;
            this.controlCoolingWaterIn.BorderRight = false;
            this.controlCoolingWaterIn.BorderTop = false;
            this.controlCoolingWaterIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlCoolingWaterIn.Location = new System.Drawing.Point(160, 300);
            this.controlCoolingWaterIn.Margin = new System.Windows.Forms.Padding(0);
            this.controlCoolingWaterIn.Name = "controlCoolingWaterIn";
            this.controlCoolingWaterIn.Padding = new System.Windows.Forms.Padding(1);
            this.controlCoolingWaterIn.Size = new System.Drawing.Size(80, 100);
            this.controlCoolingWaterIn.TabIndex = 16;
            this.controlCoolingWaterIn.TextTitle = "(℃)";
            this.controlCoolingWaterIn.TextTitleSize = 8;
            this.controlCoolingWaterIn.TextUnit = "냉각수IN";
            this.controlCoolingWaterIn.TextUnitSize = 8;
            this.controlCoolingWaterIn.TextValue = "";
            this.controlCoolingWaterIn.TextValueSize = 15;
            // 
            // controlMoldTemp2
            // 
            this.controlMoldTemp2.BorderBottom = true;
            this.controlMoldTemp2.BorderColor = System.Drawing.Color.Gray;
            this.controlMoldTemp2.BorderLeft = true;
            this.controlMoldTemp2.BorderRight = false;
            this.controlMoldTemp2.BorderTop = false;
            this.controlMoldTemp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlMoldTemp2.Location = new System.Drawing.Point(80, 300);
            this.controlMoldTemp2.Margin = new System.Windows.Forms.Padding(0);
            this.controlMoldTemp2.Name = "controlMoldTemp2";
            this.controlMoldTemp2.Padding = new System.Windows.Forms.Padding(1);
            this.controlMoldTemp2.Size = new System.Drawing.Size(80, 100);
            this.controlMoldTemp2.TabIndex = 15;
            this.controlMoldTemp2.TextTitle = "(℃)";
            this.controlMoldTemp2.TextTitleSize = 8;
            this.controlMoldTemp2.TextUnit = "금형온도고정";
            this.controlMoldTemp2.TextUnitSize = 8;
            this.controlMoldTemp2.TextValue = "";
            this.controlMoldTemp2.TextValueSize = 15;
            // 
            // controlMoldTemp1
            // 
            this.controlMoldTemp1.BorderBottom = true;
            this.controlMoldTemp1.BorderColor = System.Drawing.Color.Gray;
            this.controlMoldTemp1.BorderLeft = true;
            this.controlMoldTemp1.BorderRight = false;
            this.controlMoldTemp1.BorderTop = false;
            this.controlMoldTemp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlMoldTemp1.Location = new System.Drawing.Point(0, 300);
            this.controlMoldTemp1.Margin = new System.Windows.Forms.Padding(0);
            this.controlMoldTemp1.Name = "controlMoldTemp1";
            this.controlMoldTemp1.Padding = new System.Windows.Forms.Padding(1);
            this.controlMoldTemp1.Size = new System.Drawing.Size(80, 100);
            this.controlMoldTemp1.TabIndex = 14;
            this.controlMoldTemp1.TextTitle = "(℃)";
            this.controlMoldTemp1.TextTitleSize = 8;
            this.controlMoldTemp1.TextUnit = "금형온도이동";
            this.controlMoldTemp1.TextUnitSize = 8;
            this.controlMoldTemp1.TextValue = "";
            this.controlMoldTemp1.TextValueSize = 15;
            // 
            // controlH4
            // 
            this.controlH4.BorderBottom = true;
            this.controlH4.BorderColor = System.Drawing.Color.Gray;
            this.controlH4.BorderLeft = true;
            this.controlH4.BorderRight = true;
            this.controlH4.BorderTop = false;
            this.controlH4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlH4.Location = new System.Drawing.Point(320, 200);
            this.controlH4.Margin = new System.Windows.Forms.Padding(0);
            this.controlH4.Name = "controlH4";
            this.controlH4.Padding = new System.Windows.Forms.Padding(1);
            this.controlH4.Size = new System.Drawing.Size(80, 100);
            this.controlH4.TabIndex = 13;
            this.controlH4.TextTitle = "(℃)";
            this.controlH4.TextTitleSize = 8;
            this.controlH4.TextUnit = "히터4";
            this.controlH4.TextUnitSize = 8;
            this.controlH4.TextValue = "";
            this.controlH4.TextValueSize = 15;
            // 
            // controlH3
            // 
            this.controlH3.BorderBottom = true;
            this.controlH3.BorderColor = System.Drawing.Color.Gray;
            this.controlH3.BorderLeft = true;
            this.controlH3.BorderRight = false;
            this.controlH3.BorderTop = false;
            this.controlH3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlH3.Location = new System.Drawing.Point(240, 200);
            this.controlH3.Margin = new System.Windows.Forms.Padding(0);
            this.controlH3.Name = "controlH3";
            this.controlH3.Padding = new System.Windows.Forms.Padding(1);
            this.controlH3.Size = new System.Drawing.Size(80, 100);
            this.controlH3.TabIndex = 12;
            this.controlH3.TextTitle = "(℃)";
            this.controlH3.TextTitleSize = 8;
            this.controlH3.TextUnit = "히터3";
            this.controlH3.TextUnitSize = 8;
            this.controlH3.TextValue = "";
            this.controlH3.TextValueSize = 15;
            // 
            // controlH2
            // 
            this.controlH2.BorderBottom = true;
            this.controlH2.BorderColor = System.Drawing.Color.Gray;
            this.controlH2.BorderLeft = true;
            this.controlH2.BorderRight = false;
            this.controlH2.BorderTop = false;
            this.controlH2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlH2.Location = new System.Drawing.Point(160, 200);
            this.controlH2.Margin = new System.Windows.Forms.Padding(0);
            this.controlH2.Name = "controlH2";
            this.controlH2.Padding = new System.Windows.Forms.Padding(1);
            this.controlH2.Size = new System.Drawing.Size(80, 100);
            this.controlH2.TabIndex = 11;
            this.controlH2.TextTitle = "(℃)";
            this.controlH2.TextTitleSize = 8;
            this.controlH2.TextUnit = "히터2";
            this.controlH2.TextUnitSize = 8;
            this.controlH2.TextValue = "";
            this.controlH2.TextValueSize = 15;
            // 
            // controlH1
            // 
            this.controlH1.BorderBottom = true;
            this.controlH1.BorderColor = System.Drawing.Color.Gray;
            this.controlH1.BorderLeft = true;
            this.controlH1.BorderRight = false;
            this.controlH1.BorderTop = true;
            this.controlH1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlH1.Location = new System.Drawing.Point(80, 200);
            this.controlH1.Margin = new System.Windows.Forms.Padding(0);
            this.controlH1.Name = "controlH1";
            this.controlH1.Padding = new System.Windows.Forms.Padding(1);
            this.controlH1.Size = new System.Drawing.Size(80, 100);
            this.controlH1.TabIndex = 10;
            this.controlH1.TextTitle = "(℃)";
            this.controlH1.TextTitleSize = 8;
            this.controlH1.TextUnit = "히터1";
            this.controlH1.TextUnitSize = 8;
            this.controlH1.TextValue = "";
            this.controlH1.TextValueSize = 15;
            // 
            // controlNozzle
            // 
            this.controlNozzle.BorderBottom = true;
            this.controlNozzle.BorderColor = System.Drawing.Color.Gray;
            this.controlNozzle.BorderLeft = true;
            this.controlNozzle.BorderRight = false;
            this.controlNozzle.BorderTop = true;
            this.controlNozzle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlNozzle.Location = new System.Drawing.Point(0, 200);
            this.controlNozzle.Margin = new System.Windows.Forms.Padding(0);
            this.controlNozzle.Name = "controlNozzle";
            this.controlNozzle.Padding = new System.Windows.Forms.Padding(1);
            this.controlNozzle.Size = new System.Drawing.Size(80, 100);
            this.controlNozzle.TabIndex = 8;
            this.controlNozzle.TextTitle = "(℃)";
            this.controlNozzle.TextTitleSize = 8;
            this.controlNozzle.TextUnit = "노즐";
            this.controlNozzle.TextUnitSize = 8;
            this.controlNozzle.TextValue = "";
            this.controlNozzle.TextValueSize = 15;
            // 
            // controlCurrentCount
            // 
            this.controlCurrentCount.BorderBottom = true;
            this.controlCurrentCount.BorderColor = System.Drawing.Color.Gray;
            this.controlCurrentCount.BorderLeft = true;
            this.controlCurrentCount.BorderRight = true;
            this.controlCurrentCount.BorderTop = true;
            this.panelMainRight.SetColumnSpan(this.controlCurrentCount, 2);
            this.controlCurrentCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlCurrentCount.Location = new System.Drawing.Point(240, 100);
            this.controlCurrentCount.Margin = new System.Windows.Forms.Padding(0);
            this.controlCurrentCount.Name = "controlCurrentCount";
            this.controlCurrentCount.Padding = new System.Windows.Forms.Padding(1);
            this.controlCurrentCount.Size = new System.Drawing.Size(160, 100);
            this.controlCurrentCount.TabIndex = 7;
            this.controlCurrentCount.TextTitle = "";
            this.controlCurrentCount.TextTitleSize = 8;
            this.controlCurrentCount.TextUnit = "생산수량";
            this.controlCurrentCount.TextUnitSize = 8;
            this.controlCurrentCount.TextValue = "";
            this.controlCurrentCount.TextValueSize = 15;
            // 
            // controlTargetCount
            // 
            this.controlTargetCount.BorderBottom = true;
            this.controlTargetCount.BorderColor = System.Drawing.Color.Gray;
            this.controlTargetCount.BorderLeft = true;
            this.controlTargetCount.BorderRight = false;
            this.controlTargetCount.BorderTop = true;
            this.panelMainRight.SetColumnSpan(this.controlTargetCount, 2);
            this.controlTargetCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlTargetCount.Location = new System.Drawing.Point(80, 100);
            this.controlTargetCount.Margin = new System.Windows.Forms.Padding(0);
            this.controlTargetCount.Name = "controlTargetCount";
            this.controlTargetCount.Padding = new System.Windows.Forms.Padding(1);
            this.controlTargetCount.Size = new System.Drawing.Size(160, 100);
            this.controlTargetCount.TabIndex = 6;
            this.controlTargetCount.TextTitle = "";
            this.controlTargetCount.TextTitleSize = 8;
            this.controlTargetCount.TextUnit = "목표수량";
            this.controlTargetCount.TextUnitSize = 8;
            this.controlTargetCount.TextValue = "";
            this.controlTargetCount.TextValueSize = 15;
            // 
            // stateMonitor
            // 
            this.stateMonitor.BackgroundImage = global::DONGSHIN.Properties.Resources.monitor_icononly;
            this.stateMonitor.BorderBottom = true;
            this.stateMonitor.BorderColor = System.Drawing.Color.White;
            this.stateMonitor.BorderLeft = false;
            this.stateMonitor.BorderRight = true;
            this.stateMonitor.BorderTop = true;
            this.stateMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stateMonitor.Location = new System.Drawing.Point(320, 0);
            this.stateMonitor.Margin = new System.Windows.Forms.Padding(0);
            this.stateMonitor.Name = "stateMonitor";
            this.stateMonitor.Padding = new System.Windows.Forms.Padding(1);
            this.stateMonitor.Size = new System.Drawing.Size(80, 100);
            this.stateMonitor.TabIndex = 4;
            this.stateMonitor.TextSize = 10;
            this.stateMonitor.TextTitle = "모니터링";
            this.stateMonitor.Load += new System.EventHandler(this.stateMonitor_Load);
            // 
            // stateHeater
            // 
            this.stateHeater.BackgroundImage = global::DONGSHIN.Properties.Resources.heater_icononly;
            this.stateHeater.BorderBottom = true;
            this.stateHeater.BorderColor = System.Drawing.Color.White;
            this.stateHeater.BorderLeft = false;
            this.stateHeater.BorderRight = true;
            this.stateHeater.BorderTop = true;
            this.stateHeater.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stateHeater.Location = new System.Drawing.Point(240, 0);
            this.stateHeater.Margin = new System.Windows.Forms.Padding(0);
            this.stateHeater.Name = "stateHeater";
            this.stateHeater.Padding = new System.Windows.Forms.Padding(1);
            this.stateHeater.Size = new System.Drawing.Size(80, 100);
            this.stateHeater.TabIndex = 3;
            this.stateHeater.TextSize = 10;
            this.stateHeater.TextTitle = "히터";
            // 
            // stateMotor
            // 
            this.stateMotor.BackgroundImage = global::DONGSHIN.Properties.Resources.motor_icononly;
            this.stateMotor.BorderBottom = true;
            this.stateMotor.BorderColor = System.Drawing.Color.White;
            this.stateMotor.BorderLeft = false;
            this.stateMotor.BorderRight = true;
            this.stateMotor.BorderTop = true;
            this.stateMotor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stateMotor.Location = new System.Drawing.Point(160, 0);
            this.stateMotor.Margin = new System.Windows.Forms.Padding(0);
            this.stateMotor.Name = "stateMotor";
            this.stateMotor.Padding = new System.Windows.Forms.Padding(1);
            this.stateMotor.Size = new System.Drawing.Size(80, 100);
            this.stateMotor.TabIndex = 2;
            this.stateMotor.TextSize = 10;
            this.stateMotor.TextTitle = "모터";
            // 
            // stateAlarm
            // 
            this.stateAlarm.BackgroundImage = global::DONGSHIN.Properties.Resources.alarm_icononly;
            this.stateAlarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stateAlarm.BorderBottom = true;
            this.stateAlarm.BorderColor = System.Drawing.Color.White;
            this.stateAlarm.BorderLeft = false;
            this.stateAlarm.BorderRight = true;
            this.stateAlarm.BorderTop = true;
            this.stateAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stateAlarm.Location = new System.Drawing.Point(80, 0);
            this.stateAlarm.Margin = new System.Windows.Forms.Padding(0);
            this.stateAlarm.Name = "stateAlarm";
            this.stateAlarm.Padding = new System.Windows.Forms.Padding(1);
            this.stateAlarm.Size = new System.Drawing.Size(80, 100);
            this.stateAlarm.TabIndex = 1;
            this.stateAlarm.TextSize = 10;
            this.stateAlarm.TextTitle = "경보";
            // 
            // stateDriveMode
            // 
            this.stateDriveMode.BackgroundImage = global::DONGSHIN.Properties.Resources.lostConnection_iconOnly;
            this.stateDriveMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stateDriveMode.BorderBottom = true;
            this.stateDriveMode.BorderColor = System.Drawing.Color.White;
            this.stateDriveMode.BorderLeft = true;
            this.stateDriveMode.BorderRight = true;
            this.stateDriveMode.BorderTop = true;
            this.stateDriveMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stateDriveMode.Location = new System.Drawing.Point(0, 0);
            this.stateDriveMode.Margin = new System.Windows.Forms.Padding(0);
            this.stateDriveMode.Name = "stateDriveMode";
            this.stateDriveMode.Padding = new System.Windows.Forms.Padding(1);
            this.stateDriveMode.Size = new System.Drawing.Size(80, 100);
            this.stateDriveMode.TabIndex = 0;
            this.stateDriveMode.TextSize = 10;
            this.stateDriveMode.TextTitle = "연결안됨";
            // 
            // controlMakingTime
            // 
            this.controlMakingTime.BorderBottom = true;
            this.controlMakingTime.BorderColor = System.Drawing.Color.Gray;
            this.controlMakingTime.BorderLeft = true;
            this.controlMakingTime.BorderRight = false;
            this.controlMakingTime.BorderTop = true;
            this.controlMakingTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlMakingTime.Location = new System.Drawing.Point(0, 100);
            this.controlMakingTime.Margin = new System.Windows.Forms.Padding(0);
            this.controlMakingTime.Name = "controlMakingTime";
            this.controlMakingTime.Padding = new System.Windows.Forms.Padding(1);
            this.controlMakingTime.Size = new System.Drawing.Size(80, 100);
            this.controlMakingTime.TabIndex = 5;
            this.controlMakingTime.TextTitle = "(sec)";
            this.controlMakingTime.TextTitleSize = 8;
            this.controlMakingTime.TextUnit = "공정시간";
            this.controlMakingTime.TextUnitSize = 8;
            this.controlMakingTime.TextValue = "";
            this.controlMakingTime.TextValueSize = 15;
            // 
            // controlOil
            // 
            this.controlOil.BorderBottom = true;
            this.controlOil.BorderColor = System.Drawing.Color.Gray;
            this.controlOil.BorderLeft = true;
            this.controlOil.BorderRight = true;
            this.controlOil.BorderTop = false;
            this.controlOil.Font = new System.Drawing.Font("나눔고딕", 9F);
            this.controlOil.Location = new System.Drawing.Point(320, 300);
            this.controlOil.Margin = new System.Windows.Forms.Padding(0);
            this.controlOil.Name = "controlOil";
            this.controlOil.Padding = new System.Windows.Forms.Padding(1);
            this.controlOil.Size = new System.Drawing.Size(80, 100);
            this.controlOil.TabIndex = 18;
            this.controlOil.TextTitle = "(℃)";
            this.controlOil.TextTitleSize = 8;
            this.controlOil.TextUnit = "작동유";
            this.controlOil.TextUnitSize = 8;
            this.controlOil.TextValue = "";
            this.controlOil.TextValueSize = 15;
            // 
            // panelMainLeft
            // 
            this.panelMainLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(234)))), ((int)(((byte)(239)))));
            this.panelMainLeft.ColumnCount = 3;
            this.panelMainLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelMainLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelMainLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelMainLeft.Controls.Add(this.panelChart, 0, 2);
            this.panelMainLeft.Controls.Add(this.panelMoldName, 2, 0);
            this.panelMainLeft.Controls.Add(this.panelMachineNumber, 1, 0);
            this.panelMainLeft.Controls.Add(this.panelMachineType, 0, 0);
            this.panelMainLeft.Controls.Add(this.panelMachineImage, 0, 1);
            this.panelMainLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainLeft.Location = new System.Drawing.Point(0, 0);
            this.panelMainLeft.Name = "panelMainLeft";
            this.panelMainLeft.RowCount = 3;
            this.panelMainLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelMainLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.panelMainLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.panelMainLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelMainLeft.Size = new System.Drawing.Size(470, 400);
            this.panelMainLeft.TabIndex = 1;
            // 
            // panelChart
            // 
            this.panelChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(234)))), ((int)(((byte)(239)))));
            this.panelMainLeft.SetColumnSpan(this.panelChart, 3);
            this.panelChart.Controls.Add(this.label4);
            this.panelChart.Controls.Add(this.labelPercent1);
            this.panelChart.Controls.Add(this.label1);
            this.panelChart.Controls.Add(this.chart1);
            this.panelChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart.Location = new System.Drawing.Point(0, 220);
            this.panelChart.Margin = new System.Windows.Forms.Padding(0);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(470, 180);
            this.panelChart.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(407, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "%";
            // 
            // labelPercent1
            // 
            this.labelPercent1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(234)))), ((int)(((byte)(239)))));
            this.labelPercent1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelPercent1.Location = new System.Drawing.Point(359, 80);
            this.labelPercent1.Name = "labelPercent1";
            this.labelPercent1.Size = new System.Drawing.Size(52, 19);
            this.labelPercent1.TabIndex = 6;
            this.labelPercent1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(317, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "달성률";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(317, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(0);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.CustomProperties = "DoughnutRadius=40";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(150, 180);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chartLeft";
            // 
            // panelMoldName
            // 
            this.panelMoldName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(189)))), ((int)(((byte)(234)))));
            this.panelMoldName.ColumnCount = 1;
            this.panelMoldName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMoldName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelMoldName.Controls.Add(this.label5, 0, 1);
            this.panelMoldName.Controls.Add(this.labelMoldName, 0, 0);
            this.panelMoldName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMoldName.Location = new System.Drawing.Point(234, 0);
            this.panelMoldName.Margin = new System.Windows.Forms.Padding(0);
            this.panelMoldName.Name = "panelMoldName";
            this.panelMoldName.RowCount = 2;
            this.panelMoldName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.panelMoldName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelMoldName.Size = new System.Drawing.Size(236, 100);
            this.panelMoldName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "금형이름";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMoldName
            // 
            this.labelMoldName.AutoSize = true;
            this.labelMoldName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMoldName.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelMoldName.ForeColor = System.Drawing.Color.White;
            this.labelMoldName.Location = new System.Drawing.Point(3, 0);
            this.labelMoldName.Name = "labelMoldName";
            this.labelMoldName.Size = new System.Drawing.Size(230, 80);
            this.labelMoldName.TabIndex = 0;
            this.labelMoldName.Text = "DONGSHIN_160912_CELLPHONE";
            this.labelMoldName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMachineNumber
            // 
            this.panelMachineNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(101)))), ((int)(((byte)(131)))));
            this.panelMachineNumber.ColumnCount = 1;
            this.panelMachineNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMachineNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelMachineNumber.Controls.Add(this.label3, 0, 1);
            this.panelMachineNumber.Controls.Add(this.labelMachineNumber, 0, 0);
            this.panelMachineNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMachineNumber.Location = new System.Drawing.Point(117, 0);
            this.panelMachineNumber.Margin = new System.Windows.Forms.Padding(0);
            this.panelMachineNumber.Name = "panelMachineNumber";
            this.panelMachineNumber.RowCount = 2;
            this.panelMachineNumber.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.panelMachineNumber.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelMachineNumber.Size = new System.Drawing.Size(117, 100);
            this.panelMachineNumber.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "호기";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMachineNumber
            // 
            this.labelMachineNumber.AutoSize = true;
            this.labelMachineNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMachineNumber.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelMachineNumber.ForeColor = System.Drawing.Color.White;
            this.labelMachineNumber.Location = new System.Drawing.Point(3, 0);
            this.labelMachineNumber.Name = "labelMachineNumber";
            this.labelMachineNumber.Size = new System.Drawing.Size(111, 80);
            this.labelMachineNumber.TabIndex = 0;
            this.labelMachineNumber.Text = "1";
            this.labelMachineNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMachineType
            // 
            this.panelMachineType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(145)))), ((int)(((byte)(192)))));
            this.panelMachineType.ColumnCount = 1;
            this.panelMachineType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMachineType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelMachineType.Controls.Add(this.label2, 0, 1);
            this.panelMachineType.Controls.Add(this.labelMachineType, 0, 0);
            this.panelMachineType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMachineType.Location = new System.Drawing.Point(0, 0);
            this.panelMachineType.Margin = new System.Windows.Forms.Padding(0);
            this.panelMachineType.Name = "panelMachineType";
            this.panelMachineType.RowCount = 2;
            this.panelMachineType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.panelMachineType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelMachineType.Size = new System.Drawing.Size(117, 100);
            this.panelMachineType.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "기종";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMachineType
            // 
            this.labelMachineType.AutoSize = true;
            this.labelMachineType.BackColor = System.Drawing.Color.Transparent;
            this.labelMachineType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMachineType.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelMachineType.ForeColor = System.Drawing.Color.White;
            this.labelMachineType.Location = new System.Drawing.Point(0, 0);
            this.labelMachineType.Margin = new System.Windows.Forms.Padding(0);
            this.labelMachineType.Name = "labelMachineType";
            this.labelMachineType.Size = new System.Drawing.Size(117, 80);
            this.labelMachineType.TabIndex = 0;
            this.labelMachineType.Text = "MC";
            this.labelMachineType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMachineImage
            // 
            this.panelMachineImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(234)))), ((int)(((byte)(239)))));
            this.panelMachineImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMainLeft.SetColumnSpan(this.panelMachineImage, 3);
            this.panelMachineImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMachineImage.Location = new System.Drawing.Point(0, 100);
            this.panelMachineImage.Margin = new System.Windows.Forms.Padding(0);
            this.panelMachineImage.Name = "panelMachineImage";
            this.panelMachineImage.Size = new System.Drawing.Size(470, 120);
            this.panelMachineImage.TabIndex = 3;
            // 
            // dataUpdateTimer
            // 
            this.dataUpdateTimer.Interval = 3000;
            this.dataUpdateTimer.Tick += new System.EventHandler(this.dataUpdateTimer_Tick);
            // 
            // MachineListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMainLeft);
            this.Controls.Add(this.panelMainRight);
            this.Name = "MachineListControl";
            this.Size = new System.Drawing.Size(870, 400);
            this.panelMainRight.ResumeLayout(false);
            this.panelMainLeft.ResumeLayout(false);
            this.panelChart.ResumeLayout(false);
            this.panelChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panelMoldName.ResumeLayout(false);
            this.panelMoldName.PerformLayout();
            this.panelMachineNumber.ResumeLayout(false);
            this.panelMachineNumber.PerformLayout();
            this.panelMachineType.ResumeLayout(false);
            this.panelMachineType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelMainRight;
        private MachineStateItemControl stateDriveMode;
        private MachineStateItemControl stateMonitor;
        private MachineStateItemControl stateHeater;
        private MachineStateItemControl stateMotor;
        private MachineStateItemControl stateAlarm;
        private MachineValueItemControl controlCoolingWaterOut;
        private MachineValueItemControl controlCoolingWaterIn;
        private MachineValueItemControl controlMoldTemp2;
        private MachineValueItemControl controlMoldTemp1;
        private MachineValueItemControl controlH4;
        private MachineValueItemControl controlH3;
        private MachineValueItemControl controlH2;
        private MachineValueItemControl controlNozzle;
        private MachineValueItemControl controlCurrentCount;
        private MachineValueItemControl controlTargetCount;
        private MachineValueItemControl controlMakingTime;
        private System.Windows.Forms.TableLayoutPanel panelMainLeft;
        private System.Windows.Forms.TableLayoutPanel panelMoldName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMoldName;
        private System.Windows.Forms.TableLayoutPanel panelMachineNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMachineNumber;
        private System.Windows.Forms.TableLayoutPanel panelMachineType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMachineType;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panelMachineImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPercent1;
        private System.Windows.Forms.Label label4;
        private MachineValueItemControl controlH1;
        private MachineValueItemControl controlOil;
        private System.Windows.Forms.Timer dataUpdateTimer;
    }
}
