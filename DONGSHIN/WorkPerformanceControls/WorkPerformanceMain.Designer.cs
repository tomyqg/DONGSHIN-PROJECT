namespace DONGSHIN
{
    partial class WorkPerformanceMain
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
            if ( disposing && (components != null) )
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraCharts.Series series13 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.DoughnutSeriesLabel doughnutSeriesLabel13 = new DevExpress.XtraCharts.DoughnutSeriesLabel();
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView13 = new DevExpress.XtraCharts.DoughnutSeriesView();
            DevExpress.XtraCharts.SeriesTitle seriesTitle13 = new DevExpress.XtraCharts.SeriesTitle();
            DevExpress.XtraCharts.Series series14 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.DoughnutSeriesLabel doughnutSeriesLabel14 = new DevExpress.XtraCharts.DoughnutSeriesLabel();
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView14 = new DevExpress.XtraCharts.DoughnutSeriesView();
            DevExpress.XtraCharts.SeriesTitle seriesTitle14 = new DevExpress.XtraCharts.SeriesTitle();
            DevExpress.XtraCharts.Series series15 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.DoughnutSeriesLabel doughnutSeriesLabel15 = new DevExpress.XtraCharts.DoughnutSeriesLabel();
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView15 = new DevExpress.XtraCharts.DoughnutSeriesView();
            DevExpress.XtraCharts.SeriesTitle seriesTitle15 = new DevExpress.XtraCharts.SeriesTitle();
            this.panelBottom = new DevExpress.XtraEditors.PanelControl();
            this.MenuStdPaper = new DevExpress.XtraEditors.TileControl();
            this.MenuBarcode = new DevExpress.XtraEditors.TileControl();
            this.MenuError = new DevExpress.XtraEditors.TileControl();
            this.MenuBreak = new DevExpress.XtraEditors.TileControl();
            this.tileControl8 = new DevExpress.XtraEditors.TileControl();
            this.MenuSave = new DevExpress.XtraEditors.TileControl();
            this.MenuStop = new DevExpress.XtraEditors.TileControl();
            this.MenuStart = new DevExpress.XtraEditors.TileControl();
            this.MenuResin = new DevExpress.XtraEditors.TileControl();
            this.MenuProduct = new DevExpress.XtraEditors.TileControl();
            this.MenuMold = new DevExpress.XtraEditors.TileControl();
            this.MenuMachine = new DevExpress.XtraEditors.TileControl();
            this.MenuWorkOrder = new DevExpress.XtraEditors.TileControl();
            this.panelTitle = new DevExpress.XtraEditors.PanelControl();
            this.labelStartedOrNot = new DevExpress.XtraEditors.LabelControl();
            this.labelMachineName = new DevExpress.XtraEditors.LabelControl();
            this.labelMachineNum = new DevExpress.XtraEditors.LabelControl();
            this.labelMachineType = new DevExpress.XtraEditors.LabelControl();
            this.lbl_title = new DevExpress.XtraEditors.LabelControl();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.panelDateTimeInfo = new DevExpress.XtraEditors.PanelControl();
            this.EndTimeEdit = new DevExpress.XtraEditors.TimeEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.StartTimeEdit = new DevExpress.XtraEditors.TimeEdit();
            this.WorkTimeSpan = new DevExpress.XtraEditors.TimeSpanEdit();
            this.BreakTimeSpan = new DevExpress.XtraEditors.TimeSpanEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelDate = new DevExpress.XtraEditors.LabelControl();
            this.WorkTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.panelWorkInfo = new DevExpress.XtraEditors.PanelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textMoldCavity = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.textMoldProductNum = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.textMoldProduct = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textMoldModel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textMoldCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textMoldShot = new DevExpress.XtraEditors.SpinEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelCharts = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.chartControl3 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelBottom)).BeginInit();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelTitle)).BeginInit();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDateTimeInfo)).BeginInit();
            this.panelDateTimeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndTimeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartTimeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkTimeSpan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BreakTimeSpan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelWorkInfo)).BeginInit();
            this.panelWorkInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMoldCavity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMoldProductNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMoldProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMoldModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMoldCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMoldShot.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCharts)).BeginInit();
            this.panelCharts.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView15)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.panelBottom.Appearance.Options.UseBackColor = true;
            this.panelBottom.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelBottom.Controls.Add(this.MenuStdPaper);
            this.panelBottom.Controls.Add(this.MenuBarcode);
            this.panelBottom.Controls.Add(this.MenuError);
            this.panelBottom.Controls.Add(this.MenuBreak);
            this.panelBottom.Controls.Add(this.tileControl8);
            this.panelBottom.Controls.Add(this.MenuSave);
            this.panelBottom.Controls.Add(this.MenuStop);
            this.panelBottom.Controls.Add(this.MenuStart);
            this.panelBottom.Controls.Add(this.MenuResin);
            this.panelBottom.Controls.Add(this.MenuProduct);
            this.panelBottom.Controls.Add(this.MenuMold);
            this.panelBottom.Controls.Add(this.MenuMachine);
            this.panelBottom.Controls.Add(this.MenuWorkOrder);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 773);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1780, 109);
            this.panelBottom.TabIndex = 0;
            // 
            // MenuStdPaper
            // 
            this.MenuStdPaper.AllowSelectedItem = true;
            this.MenuStdPaper.AppearanceItem.Normal.Image = global::DONGSHIN.Properties.Resources.PaperNormal;
            this.MenuStdPaper.AppearanceItem.Normal.Options.UseImage = true;
            this.MenuStdPaper.AppearanceItem.Selected.Image = global::DONGSHIN.Properties.Resources.PaperSelected;
            this.MenuStdPaper.AppearanceItem.Selected.Options.UseImage = true;
            this.MenuStdPaper.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStdPaper.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MenuStdPaper.AppearanceText.Options.UseFont = true;
            this.MenuStdPaper.AppearanceText.Options.UseForeColor = true;
            this.MenuStdPaper.AppearanceText.Options.UseTextOptions = true;
            this.MenuStdPaper.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MenuStdPaper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.MenuStdPaper.BackgroundImage = global::DONGSHIN.Properties.Resources.PaperNormal;
            this.MenuStdPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuStdPaper.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuStdPaper.DragSize = new System.Drawing.Size(0, 0);
            this.MenuStdPaper.Location = new System.Drawing.Point(1533, 0);
            this.MenuStdPaper.Name = "MenuStdPaper";
            this.MenuStdPaper.Padding = new System.Windows.Forms.Padding(12, 70, 12, 18);
            this.MenuStdPaper.ShowText = true;
            this.MenuStdPaper.Size = new System.Drawing.Size(109, 109);
            this.MenuStdPaper.TabIndex = 28;
            this.MenuStdPaper.Text = "작업표준서";
            // 
            // MenuBarcode
            // 
            this.MenuBarcode.AllowSelectedItem = true;
            this.MenuBarcode.AppearanceItem.Normal.Image = global::DONGSHIN.Properties.Resources.LabelNormal;
            this.MenuBarcode.AppearanceItem.Normal.Options.UseImage = true;
            this.MenuBarcode.AppearanceItem.Selected.Image = global::DONGSHIN.Properties.Resources.LabelSelected;
            this.MenuBarcode.AppearanceItem.Selected.Options.UseImage = true;
            this.MenuBarcode.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBarcode.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MenuBarcode.AppearanceText.Options.UseFont = true;
            this.MenuBarcode.AppearanceText.Options.UseForeColor = true;
            this.MenuBarcode.AppearanceText.Options.UseTextOptions = true;
            this.MenuBarcode.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MenuBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.MenuBarcode.BackgroundImage = global::DONGSHIN.Properties.Resources.LabelNormal;
            this.MenuBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuBarcode.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuBarcode.DragSize = new System.Drawing.Size(0, 0);
            this.MenuBarcode.Location = new System.Drawing.Point(1424, 0);
            this.MenuBarcode.Name = "MenuBarcode";
            this.MenuBarcode.Padding = new System.Windows.Forms.Padding(12, 70, 12, 18);
            this.MenuBarcode.ShowText = true;
            this.MenuBarcode.Size = new System.Drawing.Size(109, 109);
            this.MenuBarcode.TabIndex = 25;
            this.MenuBarcode.Text = "라벨";
            // 
            // MenuError
            // 
            this.MenuError.AllowSelectedItem = true;
            this.MenuError.AppearanceItem.Normal.Image = global::DONGSHIN.Properties.Resources.BullyangNormal;
            this.MenuError.AppearanceItem.Normal.Options.UseImage = true;
            this.MenuError.AppearanceItem.Selected.Image = global::DONGSHIN.Properties.Resources.BullyangSelected;
            this.MenuError.AppearanceItem.Selected.Options.UseImage = true;
            this.MenuError.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuError.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MenuError.AppearanceText.Options.UseFont = true;
            this.MenuError.AppearanceText.Options.UseForeColor = true;
            this.MenuError.AppearanceText.Options.UseTextOptions = true;
            this.MenuError.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MenuError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.MenuError.BackgroundImage = global::DONGSHIN.Properties.Resources.BullyangNormal;
            this.MenuError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuError.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuError.DragSize = new System.Drawing.Size(0, 0);
            this.MenuError.Location = new System.Drawing.Point(1315, 0);
            this.MenuError.Name = "MenuError";
            this.MenuError.Padding = new System.Windows.Forms.Padding(12, 70, 12, 18);
            this.MenuError.ShowText = true;
            this.MenuError.Size = new System.Drawing.Size(109, 109);
            this.MenuError.TabIndex = 24;
            this.MenuError.Text = "불량";
            // 
            // MenuBreak
            // 
            this.MenuBreak.AllowSelectedItem = true;
            this.MenuBreak.AppearanceItem.Normal.Image = global::DONGSHIN.Properties.Resources.BigadongNormal;
            this.MenuBreak.AppearanceItem.Normal.Options.UseImage = true;
            this.MenuBreak.AppearanceItem.Selected.Image = global::DONGSHIN.Properties.Resources.BigadongSelected;
            this.MenuBreak.AppearanceItem.Selected.Options.UseImage = true;
            this.MenuBreak.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBreak.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MenuBreak.AppearanceText.Options.UseFont = true;
            this.MenuBreak.AppearanceText.Options.UseForeColor = true;
            this.MenuBreak.AppearanceText.Options.UseTextOptions = true;
            this.MenuBreak.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MenuBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.MenuBreak.BackgroundImage = global::DONGSHIN.Properties.Resources.BigadongNormal;
            this.MenuBreak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuBreak.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuBreak.DragSize = new System.Drawing.Size(0, 0);
            this.MenuBreak.Location = new System.Drawing.Point(1206, 0);
            this.MenuBreak.Name = "MenuBreak";
            this.MenuBreak.Padding = new System.Windows.Forms.Padding(12, 70, 12, 18);
            this.MenuBreak.ShowText = true;
            this.MenuBreak.Size = new System.Drawing.Size(109, 109);
            this.MenuBreak.TabIndex = 23;
            this.MenuBreak.Text = "비가동";
            // 
            // tileControl8
            // 
            this.tileControl8.AllowSelectedItem = true;
            this.tileControl8.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileControl8.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tileControl8.AppearanceText.Options.UseFont = true;
            this.tileControl8.AppearanceText.Options.UseForeColor = true;
            this.tileControl8.AppearanceText.Options.UseTextOptions = true;
            this.tileControl8.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tileControl8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.tileControl8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tileControl8.Dock = System.Windows.Forms.DockStyle.Left;
            this.tileControl8.DragSize = new System.Drawing.Size(0, 0);
            this.tileControl8.Location = new System.Drawing.Point(872, 0);
            this.tileControl8.Name = "tileControl8";
            this.tileControl8.Padding = new System.Windows.Forms.Padding(12, 70, 12, 18);
            this.tileControl8.ShowText = true;
            this.tileControl8.Size = new System.Drawing.Size(334, 109);
            this.tileControl8.TabIndex = 26;
            // 
            // MenuSave
            // 
            this.MenuSave.AllowSelectedItem = true;
            this.MenuSave.AppearanceItem.Normal.Image = global::DONGSHIN.Properties.Resources.SaveNormal;
            this.MenuSave.AppearanceItem.Normal.Options.UseImage = true;
            this.MenuSave.AppearanceItem.Selected.Image = global::DONGSHIN.Properties.Resources.SaveSelected;
            this.MenuSave.AppearanceItem.Selected.Options.UseImage = true;
            this.MenuSave.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuSave.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MenuSave.AppearanceText.Options.UseFont = true;
            this.MenuSave.AppearanceText.Options.UseForeColor = true;
            this.MenuSave.AppearanceText.Options.UseTextOptions = true;
            this.MenuSave.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MenuSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.MenuSave.BackgroundImage = global::DONGSHIN.Properties.Resources.SaveNormal;
            this.MenuSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuSave.DragSize = new System.Drawing.Size(0, 0);
            this.MenuSave.Location = new System.Drawing.Point(763, 0);
            this.MenuSave.Name = "MenuSave";
            this.MenuSave.Padding = new System.Windows.Forms.Padding(12, 70, 12, 18);
            this.MenuSave.ShowText = true;
            this.MenuSave.Size = new System.Drawing.Size(109, 109);
            this.MenuSave.TabIndex = 30;
            this.MenuSave.Text = "저장";
            // 
            // MenuStop
            // 
            this.MenuStop.AllowSelectedItem = true;
            this.MenuStop.AppearanceItem.Normal.Image = global::DONGSHIN.Properties.Resources.StopNormal;
            this.MenuStop.AppearanceItem.Normal.Options.UseImage = true;
            this.MenuStop.AppearanceItem.Selected.Image = global::DONGSHIN.Properties.Resources.StopSelected;
            this.MenuStop.AppearanceItem.Selected.Options.UseImage = true;
            this.MenuStop.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStop.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MenuStop.AppearanceText.Options.UseFont = true;
            this.MenuStop.AppearanceText.Options.UseForeColor = true;
            this.MenuStop.AppearanceText.Options.UseTextOptions = true;
            this.MenuStop.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MenuStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.MenuStop.BackgroundImage = global::DONGSHIN.Properties.Resources.StopNormal;
            this.MenuStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuStop.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuStop.DragSize = new System.Drawing.Size(0, 0);
            this.MenuStop.Location = new System.Drawing.Point(654, 0);
            this.MenuStop.Name = "MenuStop";
            this.MenuStop.Padding = new System.Windows.Forms.Padding(12, 70, 12, 18);
            this.MenuStop.ShowText = true;
            this.MenuStop.Size = new System.Drawing.Size(109, 109);
            this.MenuStop.TabIndex = 29;
            this.MenuStop.Text = "정지";
            // 
            // MenuStart
            // 
            this.MenuStart.AllowSelectedItem = true;
            this.MenuStart.AppearanceItem.Normal.Image = global::DONGSHIN.Properties.Resources.StartNormal;
            this.MenuStart.AppearanceItem.Normal.Options.UseImage = true;
            this.MenuStart.AppearanceItem.Selected.Image = global::DONGSHIN.Properties.Resources.SijakSelected;
            this.MenuStart.AppearanceItem.Selected.Options.UseImage = true;
            this.MenuStart.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStart.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MenuStart.AppearanceText.Options.UseFont = true;
            this.MenuStart.AppearanceText.Options.UseForeColor = true;
            this.MenuStart.AppearanceText.Options.UseTextOptions = true;
            this.MenuStart.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MenuStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.MenuStart.BackgroundImage = global::DONGSHIN.Properties.Resources.StartNormal;
            this.MenuStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuStart.DragSize = new System.Drawing.Size(0, 0);
            this.MenuStart.Location = new System.Drawing.Point(545, 0);
            this.MenuStart.Name = "MenuStart";
            this.MenuStart.Padding = new System.Windows.Forms.Padding(12, 70, 12, 18);
            this.MenuStart.ShowText = true;
            this.MenuStart.Size = new System.Drawing.Size(109, 109);
            this.MenuStart.TabIndex = 31;
            this.MenuStart.Text = "시작";
            // 
            // MenuResin
            // 
            this.MenuResin.AllowSelectedItem = true;
            this.MenuResin.AppearanceItem.Normal.Image = global::DONGSHIN.Properties.Resources.SujiNormal;
            this.MenuResin.AppearanceItem.Normal.Options.UseImage = true;
            this.MenuResin.AppearanceItem.Selected.Image = global::DONGSHIN.Properties.Resources.SujiSelected;
            this.MenuResin.AppearanceItem.Selected.Options.UseImage = true;
            this.MenuResin.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuResin.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MenuResin.AppearanceText.Options.UseFont = true;
            this.MenuResin.AppearanceText.Options.UseForeColor = true;
            this.MenuResin.AppearanceText.Options.UseTextOptions = true;
            this.MenuResin.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MenuResin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.MenuResin.BackgroundImage = global::DONGSHIN.Properties.Resources.SujiNormal;
            this.MenuResin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuResin.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuResin.DragSize = new System.Drawing.Size(0, 0);
            this.MenuResin.Location = new System.Drawing.Point(436, 0);
            this.MenuResin.Name = "MenuResin";
            this.MenuResin.Padding = new System.Windows.Forms.Padding(12, 70, 12, 18);
            this.MenuResin.ShowText = true;
            this.MenuResin.Size = new System.Drawing.Size(109, 109);
            this.MenuResin.TabIndex = 21;
            this.MenuResin.Text = "수지";
            // 
            // MenuProduct
            // 
            this.MenuProduct.AllowSelectedItem = true;
            this.MenuProduct.AppearanceItem.Normal.Image = global::DONGSHIN.Properties.Resources.JepumNormal;
            this.MenuProduct.AppearanceItem.Normal.Options.UseImage = true;
            this.MenuProduct.AppearanceItem.Selected.Image = global::DONGSHIN.Properties.Resources.JepumSelected;
            this.MenuProduct.AppearanceItem.Selected.Options.UseImage = true;
            this.MenuProduct.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuProduct.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MenuProduct.AppearanceText.Options.UseFont = true;
            this.MenuProduct.AppearanceText.Options.UseForeColor = true;
            this.MenuProduct.AppearanceText.Options.UseTextOptions = true;
            this.MenuProduct.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MenuProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.MenuProduct.BackgroundImage = global::DONGSHIN.Properties.Resources.JepumNormal;
            this.MenuProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuProduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuProduct.DragSize = new System.Drawing.Size(0, 0);
            this.MenuProduct.Location = new System.Drawing.Point(327, 0);
            this.MenuProduct.Name = "MenuProduct";
            this.MenuProduct.Padding = new System.Windows.Forms.Padding(12, 70, 12, 18);
            this.MenuProduct.ShowText = true;
            this.MenuProduct.Size = new System.Drawing.Size(109, 109);
            this.MenuProduct.TabIndex = 20;
            this.MenuProduct.Text = "제품";
            // 
            // MenuMold
            // 
            this.MenuMold.AllowSelectedItem = true;
            this.MenuMold.AppearanceItem.Normal.Image = global::DONGSHIN.Properties.Resources.GeumhyeongNormal;
            this.MenuMold.AppearanceItem.Normal.Options.UseImage = true;
            this.MenuMold.AppearanceItem.Selected.Image = global::DONGSHIN.Properties.Resources.GeumhyeongSelected;
            this.MenuMold.AppearanceItem.Selected.Options.UseImage = true;
            this.MenuMold.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuMold.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MenuMold.AppearanceText.Options.UseFont = true;
            this.MenuMold.AppearanceText.Options.UseForeColor = true;
            this.MenuMold.AppearanceText.Options.UseTextOptions = true;
            this.MenuMold.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MenuMold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.MenuMold.BackgroundImage = global::DONGSHIN.Properties.Resources.GeumhyeongNormal;
            this.MenuMold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuMold.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuMold.DragSize = new System.Drawing.Size(0, 0);
            this.MenuMold.Location = new System.Drawing.Point(218, 0);
            this.MenuMold.Name = "MenuMold";
            this.MenuMold.Padding = new System.Windows.Forms.Padding(12, 70, 12, 18);
            this.MenuMold.ShowText = true;
            this.MenuMold.Size = new System.Drawing.Size(109, 109);
            this.MenuMold.TabIndex = 19;
            this.MenuMold.Text = "금형";
            // 
            // MenuMachine
            // 
            this.MenuMachine.AllowSelectedItem = true;
            this.MenuMachine.AppearanceItem.Normal.Image = global::DONGSHIN.Properties.Resources.SeolbiNormal;
            this.MenuMachine.AppearanceItem.Normal.Options.UseImage = true;
            this.MenuMachine.AppearanceItem.Selected.Image = global::DONGSHIN.Properties.Resources.SeolbiSelected;
            this.MenuMachine.AppearanceItem.Selected.Options.UseImage = true;
            this.MenuMachine.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuMachine.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MenuMachine.AppearanceText.Options.UseFont = true;
            this.MenuMachine.AppearanceText.Options.UseForeColor = true;
            this.MenuMachine.AppearanceText.Options.UseTextOptions = true;
            this.MenuMachine.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MenuMachine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.MenuMachine.BackgroundImage = global::DONGSHIN.Properties.Resources.SeolbiNormal;
            this.MenuMachine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuMachine.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuMachine.DragSize = new System.Drawing.Size(0, 0);
            this.MenuMachine.Location = new System.Drawing.Point(109, 0);
            this.MenuMachine.Name = "MenuMachine";
            this.MenuMachine.Padding = new System.Windows.Forms.Padding(12, 70, 12, 18);
            this.MenuMachine.ShowText = true;
            this.MenuMachine.Size = new System.Drawing.Size(109, 109);
            this.MenuMachine.TabIndex = 18;
            this.MenuMachine.Text = "설비";
            // 
            // MenuWorkOrder
            // 
            this.MenuWorkOrder.AllowSelectedItem = true;
            this.MenuWorkOrder.AppearanceItem.Normal.Image = global::DONGSHIN.Properties.Resources.JisiNormal;
            this.MenuWorkOrder.AppearanceItem.Normal.Options.UseImage = true;
            this.MenuWorkOrder.AppearanceItem.Selected.Image = global::DONGSHIN.Properties.Resources.JisiSelected;
            this.MenuWorkOrder.AppearanceItem.Selected.Options.UseImage = true;
            this.MenuWorkOrder.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuWorkOrder.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MenuWorkOrder.AppearanceText.Options.UseFont = true;
            this.MenuWorkOrder.AppearanceText.Options.UseForeColor = true;
            this.MenuWorkOrder.AppearanceText.Options.UseTextOptions = true;
            this.MenuWorkOrder.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MenuWorkOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.MenuWorkOrder.BackgroundImage = global::DONGSHIN.Properties.Resources.JisiNormal;
            this.MenuWorkOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuWorkOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuWorkOrder.DragSize = new System.Drawing.Size(0, 0);
            this.MenuWorkOrder.Location = new System.Drawing.Point(0, 0);
            this.MenuWorkOrder.Name = "MenuWorkOrder";
            this.MenuWorkOrder.Padding = new System.Windows.Forms.Padding(12, 70, 12, 18);
            this.MenuWorkOrder.ShowText = true;
            this.MenuWorkOrder.Size = new System.Drawing.Size(109, 109);
            this.MenuWorkOrder.TabIndex = 17;
            this.MenuWorkOrder.Text = "작업지시";
            // 
            // panelTitle
            // 
            this.panelTitle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.panelTitle.Appearance.Options.UseBackColor = true;
            this.panelTitle.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelTitle.Controls.Add(this.labelStartedOrNot);
            this.panelTitle.Controls.Add(this.labelMachineName);
            this.panelTitle.Controls.Add(this.labelMachineNum);
            this.panelTitle.Controls.Add(this.labelMachineType);
            this.panelTitle.Controls.Add(this.lbl_title);
            this.panelTitle.Controls.Add(this.shapeContainer1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1780, 75);
            this.panelTitle.TabIndex = 1;
            // 
            // labelStartedOrNot
            // 
            this.labelStartedOrNot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStartedOrNot.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartedOrNot.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelStartedOrNot.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelStartedOrNot.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelStartedOrNot.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelStartedOrNot.Location = new System.Drawing.Point(1393, 0);
            this.labelStartedOrNot.Name = "labelStartedOrNot";
            this.labelStartedOrNot.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.labelStartedOrNot.Size = new System.Drawing.Size(306, 75);
            this.labelStartedOrNot.TabIndex = 6;
            this.labelStartedOrNot.Text = "Ready";
            // 
            // labelMachineName
            // 
            this.labelMachineName.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(145)))), ((int)(((byte)(192)))));
            this.labelMachineName.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelMachineName.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelMachineName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelMachineName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelMachineName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMachineName.Location = new System.Drawing.Point(534, 0);
            this.labelMachineName.Name = "labelMachineName";
            this.labelMachineName.Size = new System.Drawing.Size(333, 75);
            this.labelMachineName.TabIndex = 4;
            this.labelMachineName.Text = "Machine Name";
            // 
            // labelMachineNum
            // 
            this.labelMachineNum.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(101)))), ((int)(((byte)(131)))));
            this.labelMachineNum.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelMachineNum.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelMachineNum.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelMachineNum.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelMachineNum.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMachineNum.Location = new System.Drawing.Point(459, 0);
            this.labelMachineNum.Name = "labelMachineNum";
            this.labelMachineNum.Size = new System.Drawing.Size(75, 75);
            this.labelMachineNum.TabIndex = 3;
            this.labelMachineNum.Text = "0";
            // 
            // labelMachineType
            // 
            this.labelMachineType.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.labelMachineType.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelMachineType.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelMachineType.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelMachineType.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelMachineType.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMachineType.Location = new System.Drawing.Point(384, 0);
            this.labelMachineType.Name = "labelMachineType";
            this.labelMachineType.Size = new System.Drawing.Size(75, 75);
            this.labelMachineType.TabIndex = 2;
            this.labelMachineType.Text = "MC";
            // 
            // lbl_title
            // 
            this.lbl_title.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_title.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_title.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_title.Size = new System.Drawing.Size(384, 75);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "작업실적 등록";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1780, 75);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // ovalShape1
            // 
            this.ovalShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ovalShape1.BorderColor = System.Drawing.Color.Transparent;
            this.ovalShape1.FillColor = System.Drawing.Color.Green;
            this.ovalShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ovalShape1.Location = new System.Drawing.Point(1705, 6);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.Size = new System.Drawing.Size(63, 63);
            // 
            // panelDateTimeInfo
            // 
            this.panelDateTimeInfo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(221)))), ((int)(((byte)(228)))));
            this.panelDateTimeInfo.Appearance.Options.UseBackColor = true;
            this.panelDateTimeInfo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelDateTimeInfo.Controls.Add(this.EndTimeEdit);
            this.panelDateTimeInfo.Controls.Add(this.labelControl10);
            this.panelDateTimeInfo.Controls.Add(this.StartTimeEdit);
            this.panelDateTimeInfo.Controls.Add(this.WorkTimeSpan);
            this.panelDateTimeInfo.Controls.Add(this.BreakTimeSpan);
            this.panelDateTimeInfo.Controls.Add(this.labelControl3);
            this.panelDateTimeInfo.Controls.Add(this.labelControl2);
            this.panelDateTimeInfo.Controls.Add(this.labelControl1);
            this.panelDateTimeInfo.Controls.Add(this.labelDate);
            this.panelDateTimeInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDateTimeInfo.Location = new System.Drawing.Point(0, 75);
            this.panelDateTimeInfo.Name = "panelDateTimeInfo";
            this.panelDateTimeInfo.Size = new System.Drawing.Size(1780, 58);
            this.panelDateTimeInfo.TabIndex = 2;
            // 
            // EndTimeEdit
            // 
            this.EndTimeEdit.EditValue = new System.DateTime(2017, 2, 28, 0, 0, 0, 0);
            this.EndTimeEdit.Location = new System.Drawing.Point(919, 18);
            this.EndTimeEdit.Name = "EndTimeEdit";
            this.EndTimeEdit.Properties.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EndTimeEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.EndTimeEdit.Properties.Appearance.Options.UseFont = true;
            this.EndTimeEdit.Properties.Appearance.Options.UseForeColor = true;
            this.EndTimeEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.EndTimeEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.EndTimeEdit.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.EndTimeEdit.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.EndTimeEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.EndTimeEdit.Properties.Mask.EditMask = "tt HH:mm";
            this.EndTimeEdit.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick;
            this.EndTimeEdit.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.EndTimeEdit.Size = new System.Drawing.Size(146, 30);
            this.EndTimeEdit.TabIndex = 8;
            this.EndTimeEdit.Tag = "Ready";
            this.EndTimeEdit.EditValueChanged += new System.EventHandler(this.TimeCalculate);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl10.Location = new System.Drawing.Point(793, 21);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(120, 24);
            this.labelControl10.TabIndex = 7;
            this.labelControl10.Text = "작업종료시간";
            // 
            // StartTimeEdit
            // 
            this.StartTimeEdit.EditValue = new System.DateTime(2017, 2, 28, 0, 0, 0, 0);
            this.StartTimeEdit.Location = new System.Drawing.Point(510, 18);
            this.StartTimeEdit.Name = "StartTimeEdit";
            this.StartTimeEdit.Properties.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StartTimeEdit.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.StartTimeEdit.Properties.Appearance.Options.UseFont = true;
            this.StartTimeEdit.Properties.Appearance.Options.UseForeColor = true;
            this.StartTimeEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.StartTimeEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.StartTimeEdit.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.StartTimeEdit.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.StartTimeEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.StartTimeEdit.Properties.Mask.EditMask = "tt HH:mm";
            this.StartTimeEdit.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick;
            this.StartTimeEdit.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.StartTimeEdit.Size = new System.Drawing.Size(146, 30);
            this.StartTimeEdit.TabIndex = 6;
            this.StartTimeEdit.Tag = "Ready";
            this.StartTimeEdit.EditValueChanged += new System.EventHandler(this.TimeCalculate);
            // 
            // WorkTimeSpan
            // 
            this.WorkTimeSpan.EditValue = System.TimeSpan.Parse("00:00:00");
            this.WorkTimeSpan.Enabled = false;
            this.WorkTimeSpan.Location = new System.Drawing.Point(1263, 18);
            this.WorkTimeSpan.Name = "WorkTimeSpan";
            this.WorkTimeSpan.Properties.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WorkTimeSpan.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.WorkTimeSpan.Properties.Appearance.Options.UseFont = true;
            this.WorkTimeSpan.Properties.Appearance.Options.UseForeColor = true;
            this.WorkTimeSpan.Properties.Appearance.Options.UseTextOptions = true;
            this.WorkTimeSpan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.WorkTimeSpan.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.WorkTimeSpan.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.WorkTimeSpan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.WorkTimeSpan.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.WorkTimeSpan.Properties.Mask.EditMask = "HH:mm:ss";
            this.WorkTimeSpan.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.WorkTimeSpan.Properties.MaxDays = 0;
            this.WorkTimeSpan.Properties.MaxSeconds = 0;
            this.WorkTimeSpan.Properties.ReadOnly = true;
            this.WorkTimeSpan.Size = new System.Drawing.Size(132, 30);
            this.WorkTimeSpan.TabIndex = 5;
            // 
            // BreakTimeSpan
            // 
            this.BreakTimeSpan.EditValue = System.TimeSpan.Parse("00:00:00");
            this.BreakTimeSpan.Enabled = false;
            this.BreakTimeSpan.Location = new System.Drawing.Point(1635, 18);
            this.BreakTimeSpan.Name = "BreakTimeSpan";
            this.BreakTimeSpan.Properties.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BreakTimeSpan.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.BreakTimeSpan.Properties.Appearance.Options.UseFont = true;
            this.BreakTimeSpan.Properties.Appearance.Options.UseForeColor = true;
            this.BreakTimeSpan.Properties.Appearance.Options.UseTextOptions = true;
            this.BreakTimeSpan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BreakTimeSpan.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.BreakTimeSpan.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.BreakTimeSpan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.BreakTimeSpan.Properties.Mask.EditMask = "HH:mm:ss";
            this.BreakTimeSpan.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.BreakTimeSpan.Properties.ReadOnly = true;
            this.BreakTimeSpan.Size = new System.Drawing.Size(133, 30);
            this.BreakTimeSpan.TabIndex = 4;
            this.BreakTimeSpan.EditValueChanged += new System.EventHandler(this.TimeCalculate);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl3.Location = new System.Drawing.Point(1529, 21);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(100, 24);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "비가동시간";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl2.Location = new System.Drawing.Point(1177, 21);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 24);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "가동시간";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl1.Location = new System.Drawing.Point(384, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(120, 24);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "작업시작시간";
            // 
            // labelDate
            // 
            this.labelDate.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelDate.Location = new System.Drawing.Point(22, 21);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(99, 24);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "WorkDate";
            // 
            // WorkTimeTimer
            // 
            this.WorkTimeTimer.Interval = 1000;
            this.WorkTimeTimer.Tick += new System.EventHandler(this.WorkTimeTimer_Tick);
            // 
            // panelWorkInfo
            // 
            this.panelWorkInfo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelWorkInfo.Controls.Add(this.splitContainerControl1);
            this.panelWorkInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWorkInfo.Location = new System.Drawing.Point(0, 133);
            this.panelWorkInfo.Name = "panelWorkInfo";
            this.panelWorkInfo.Size = new System.Drawing.Size(1780, 271);
            this.panelWorkInfo.TabIndex = 3;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainerControl1.Panel1.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainerControl1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1780, 271);
            this.splitContainerControl1.SplitterPosition = 800;
            this.splitContainerControl1.TabIndex = 9;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textMoldCavity);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Controls.Add(this.textMoldProductNum);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.textMoldProduct);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.textMoldModel);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.textMoldCode);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.textMoldShot);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 261);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "금형정보";
            // 
            // textMoldCavity
            // 
            this.textMoldCavity.Enabled = false;
            this.textMoldCavity.Location = new System.Drawing.Point(541, 182);
            this.textMoldCavity.Name = "textMoldCavity";
            this.textMoldCavity.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.textMoldCavity.Properties.Appearance.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textMoldCavity.Properties.Appearance.Options.UseBackColor = true;
            this.textMoldCavity.Properties.Appearance.Options.UseFont = true;
            this.textMoldCavity.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textMoldCavity.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.textMoldCavity.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textMoldCavity.Size = new System.Drawing.Size(227, 28);
            this.textMoldCavity.TabIndex = 11;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.Location = new System.Drawing.Point(404, 185);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(122, 21);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "Cavity";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.Location = new System.Drawing.Point(21, 185);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(122, 21);
            this.labelControl9.TabIndex = 8;
            this.labelControl9.Text = "숏트수";
            // 
            // textMoldProductNum
            // 
            this.textMoldProductNum.Enabled = false;
            this.textMoldProductNum.Location = new System.Drawing.Point(541, 114);
            this.textMoldProductNum.Name = "textMoldProductNum";
            this.textMoldProductNum.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.textMoldProductNum.Properties.Appearance.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textMoldProductNum.Properties.Appearance.Options.UseBackColor = true;
            this.textMoldProductNum.Properties.Appearance.Options.UseFont = true;
            this.textMoldProductNum.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textMoldProductNum.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.textMoldProductNum.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textMoldProductNum.Size = new System.Drawing.Size(227, 28);
            this.textMoldProductNum.TabIndex = 7;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Location = new System.Drawing.Point(404, 117);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(122, 21);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "품번";
            // 
            // textMoldProduct
            // 
            this.textMoldProduct.Enabled = false;
            this.textMoldProduct.Location = new System.Drawing.Point(158, 114);
            this.textMoldProduct.Name = "textMoldProduct";
            this.textMoldProduct.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.textMoldProduct.Properties.Appearance.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textMoldProduct.Properties.Appearance.Options.UseBackColor = true;
            this.textMoldProduct.Properties.Appearance.Options.UseFont = true;
            this.textMoldProduct.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textMoldProduct.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.textMoldProduct.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textMoldProduct.Size = new System.Drawing.Size(227, 28);
            this.textMoldProduct.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(21, 117);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(122, 21);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "품명";
            // 
            // textMoldModel
            // 
            this.textMoldModel.Enabled = false;
            this.textMoldModel.Location = new System.Drawing.Point(541, 49);
            this.textMoldModel.Name = "textMoldModel";
            this.textMoldModel.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.textMoldModel.Properties.Appearance.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textMoldModel.Properties.Appearance.Options.UseBackColor = true;
            this.textMoldModel.Properties.Appearance.Options.UseFont = true;
            this.textMoldModel.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textMoldModel.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.textMoldModel.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textMoldModel.Size = new System.Drawing.Size(227, 28);
            this.textMoldModel.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(404, 52);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(122, 21);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "모델";
            // 
            // textMoldCode
            // 
            this.textMoldCode.Enabled = false;
            this.textMoldCode.Location = new System.Drawing.Point(158, 49);
            this.textMoldCode.Name = "textMoldCode";
            this.textMoldCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.textMoldCode.Properties.Appearance.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textMoldCode.Properties.Appearance.Options.UseBackColor = true;
            this.textMoldCode.Properties.Appearance.Options.UseFont = true;
            this.textMoldCode.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textMoldCode.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.textMoldCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textMoldCode.Size = new System.Drawing.Size(227, 28);
            this.textMoldCode.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(21, 52);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(122, 21);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "금형코드";
            // 
            // textMoldShot
            // 
            this.textMoldShot.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textMoldShot.Enabled = false;
            this.textMoldShot.Location = new System.Drawing.Point(158, 182);
            this.textMoldShot.Name = "textMoldShot";
            this.textMoldShot.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.textMoldShot.Properties.Appearance.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textMoldShot.Properties.Appearance.Options.UseBackColor = true;
            this.textMoldShot.Properties.Appearance.Options.UseFont = true;
            this.textMoldShot.Properties.Appearance.Options.UseTextOptions = true;
            this.textMoldShot.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.textMoldShot.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textMoldShot.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.textMoldShot.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textMoldShot.Properties.DisplayFormat.FormatString = "#,##0";
            this.textMoldShot.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textMoldShot.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.textMoldShot.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.textMoldShot.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.textMoldShot.Size = new System.Drawing.Size(227, 28);
            this.textMoldShot.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridControl1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(965, 261);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "제품정보";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 28);
            this.gridControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(959, 230);
            this.gridControl1.TabIndex = 15;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.DarkGray;
            this.gridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.DarkGray;
            this.gridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Gainsboro;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.gridView1.Appearance.Empty.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridView1.Appearance.Empty.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.gridView1.Appearance.EvenRow.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.gridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseFont = true;
            this.gridView1.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(160)))), ((int)(((byte)(221)))));
            this.gridView1.Appearance.FocusedCell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(160)))), ((int)(((byte)(221)))));
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.Options.UseBorderColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(185)))), ((int)(((byte)(230)))));
            this.gridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(185)))), ((int)(((byte)(230)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.DarkGray;
            this.gridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.DarkGray;
            this.gridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.DimGray;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.gridView1.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.LightGray;
            this.gridView1.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.gridView1.Appearance.OddRow.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.gridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.Options.UseFont = true;
            this.gridView1.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView1.Appearance.Preview.BackColor = System.Drawing.Color.Gainsboro;
            this.gridView1.Appearance.Preview.ForeColor = System.Drawing.Color.DimGray;
            this.gridView1.Appearance.Preview.Options.UseBackColor = true;
            this.gridView1.Appearance.Preview.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.DimGray;
            this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(185)))), ((int)(((byte)(230)))));
            this.gridView1.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(185)))), ((int)(((byte)(230)))));
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.VertLine.BackColor = System.Drawing.Color.LightGray;
            this.gridView1.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.ColumnPanelRowHeight = 50;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn11,
            this.gridColumn1});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "YesOrNo";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.Salmon;
            formatConditionRuleExpression1.Appearance.BackColor2 = System.Drawing.Color.SeaShell;
            formatConditionRuleExpression1.Appearance.Font = new System.Drawing.Font("나눔고딕", 12F);
            formatConditionRuleExpression1.Appearance.ForeColor = System.Drawing.Color.Red;
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Appearance.Options.UseFont = true;
            formatConditionRuleExpression1.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression1.Expression = "[use_chk] = \'N\'";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupRowHeight = 50;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.PaintStyleName = "Web";
            this.gridView1.RowHeight = 50;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn2.Caption = "제품코드";
            this.gridColumn2.FieldName = "jp_id";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 114;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.gridColumn3.AppearanceHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn3.Caption = "차종명";
            this.gridColumn3.FieldName = "car";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 91;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.gridColumn5.AppearanceCell.Options.UseFont = true;
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.gridColumn5.AppearanceHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn5.Caption = "품명";
            this.gridColumn5.FieldName = "jp_name";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 127;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.gridColumn6.AppearanceCell.Options.UseFont = true;
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.gridColumn6.AppearanceHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn6.Caption = "품번";
            this.gridColumn6.FieldName = "jp_num";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 121;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "작업표준서";
            this.gridColumn11.FieldName = "jp_stdpaper";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "목표수량";
            this.gridColumn1.DisplayFormat.FormatString = "#,##0 EA";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.FieldName = "qt_plan";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // panelCharts
            // 
            this.panelCharts.Appearance.BackColor = System.Drawing.Color.White;
            this.panelCharts.Appearance.Options.UseBackColor = true;
            this.panelCharts.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelCharts.Controls.Add(this.tableLayoutPanel1);
            this.panelCharts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCharts.Location = new System.Drawing.Point(0, 404);
            this.panelCharts.Name = "panelCharts";
            this.panelCharts.Size = new System.Drawing.Size(1780, 369);
            this.panelCharts.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.chartControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartControl2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartControl3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1780, 369);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(3, 3);
            this.chartControl1.Name = "chartControl1";
            doughnutSeriesLabel13.BackColor = System.Drawing.Color.Transparent;
            doughnutSeriesLabel13.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            doughnutSeriesLabel13.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            doughnutSeriesLabel13.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Inside;
            doughnutSeriesLabel13.TextColor = System.Drawing.Color.White;
            series13.Label = doughnutSeriesLabel13;
            series13.Name = "Series 1";
            doughnutSeriesView13.HoleRadiusPercent = 50;
            seriesTitle13.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            seriesTitle13.Text = "달성률";
            doughnutSeriesView13.Titles.AddRange(new DevExpress.XtraCharts.SeriesTitle[] {
            seriesTitle13});
            series13.View = doughnutSeriesView13;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series13};
            this.chartControl1.Size = new System.Drawing.Size(587, 363);
            this.chartControl1.TabIndex = 0;
            // 
            // chartControl2
            // 
            this.chartControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl2.Location = new System.Drawing.Point(596, 3);
            this.chartControl2.Name = "chartControl2";
            doughnutSeriesLabel14.BackColor = System.Drawing.Color.Transparent;
            doughnutSeriesLabel14.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            doughnutSeriesLabel14.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doughnutSeriesLabel14.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Inside;
            doughnutSeriesLabel14.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            series14.Label = doughnutSeriesLabel14;
            series14.Name = "Series 1";
            doughnutSeriesView14.HoleRadiusPercent = 50;
            seriesTitle14.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            seriesTitle14.Text = "가동률";
            doughnutSeriesView14.Titles.AddRange(new DevExpress.XtraCharts.SeriesTitle[] {
            seriesTitle14});
            series14.View = doughnutSeriesView14;
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series14};
            this.chartControl2.Size = new System.Drawing.Size(587, 363);
            this.chartControl2.TabIndex = 1;
            // 
            // chartControl3
            // 
            this.chartControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl3.Location = new System.Drawing.Point(1189, 3);
            this.chartControl3.Name = "chartControl3";
            doughnutSeriesLabel15.BackColor = System.Drawing.Color.Transparent;
            doughnutSeriesLabel15.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            doughnutSeriesLabel15.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doughnutSeriesLabel15.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Inside;
            doughnutSeriesLabel15.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            series15.Label = doughnutSeriesLabel15;
            series15.Name = "Series 1";
            doughnutSeriesView15.HoleRadiusPercent = 50;
            seriesTitle15.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            seriesTitle15.Text = "불량률";
            doughnutSeriesView15.Titles.AddRange(new DevExpress.XtraCharts.SeriesTitle[] {
            seriesTitle15});
            series15.View = doughnutSeriesView15;
            this.chartControl3.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series15};
            this.chartControl3.Size = new System.Drawing.Size(588, 363);
            this.chartControl3.TabIndex = 2;
            // 
            // WorkPerformanceMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Controls.Add(this.panelWorkInfo);
            this.Controls.Add(this.panelCharts);
            this.Controls.Add(this.panelDateTimeInfo);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelBottom);
            this.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Name = "WorkPerformanceMain";
            this.Size = new System.Drawing.Size(1780, 882);
            this.Load += new System.EventHandler(this.WorkPerformanceMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelBottom)).EndInit();
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelTitle)).EndInit();
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelDateTimeInfo)).EndInit();
            this.panelDateTimeInfo.ResumeLayout(false);
            this.panelDateTimeInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndTimeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartTimeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkTimeSpan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BreakTimeSpan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelWorkInfo)).EndInit();
            this.panelWorkInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textMoldCavity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMoldProductNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMoldProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMoldModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMoldCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMoldShot.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCharts)).EndInit();
            this.panelCharts.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelBottom;
        private DevExpress.XtraEditors.TileControl MenuWorkOrder;
        private DevExpress.XtraEditors.TileControl MenuMold;
        private DevExpress.XtraEditors.TileControl MenuMachine;
        private DevExpress.XtraEditors.TileControl MenuResin;
        private DevExpress.XtraEditors.TileControl MenuProduct;
        private DevExpress.XtraEditors.TileControl tileControl8;
        private DevExpress.XtraEditors.TileControl MenuBarcode;
        private DevExpress.XtraEditors.TileControl MenuError;
        private DevExpress.XtraEditors.TileControl MenuBreak;
        private DevExpress.XtraEditors.PanelControl panelTitle;
        private DevExpress.XtraEditors.LabelControl lbl_title;
        private DevExpress.XtraEditors.PanelControl panelDateTimeInfo;
        private DevExpress.XtraEditors.TimeSpanEdit BreakTimeSpan;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelDate;
        private System.Windows.Forms.Timer WorkTimeTimer;
        private DevExpress.XtraEditors.TimeEdit StartTimeEdit;
        private DevExpress.XtraEditors.TimeSpanEdit WorkTimeSpan;
        private DevExpress.XtraEditors.PanelControl panelWorkInfo;
        private DevExpress.XtraEditors.PanelControl panelCharts;
        private DevExpress.XtraEditors.TileControl MenuStdPaper;
        private DevExpress.XtraEditors.TileControl MenuStop;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit textMoldProductNum;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit textMoldProduct;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textMoldModel;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textMoldCode;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.LabelControl labelMachineNum;
        private DevExpress.XtraEditors.LabelControl labelMachineType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.LabelControl labelMachineName;
        private DevExpress.XtraEditors.LabelControl labelStartedOrNot;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
        private DevExpress.XtraEditors.TextEdit textMoldCavity;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SpinEdit textMoldShot;
        private DevExpress.XtraEditors.TimeEdit EndTimeEdit;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TileControl MenuSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.TileControl MenuStart;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private DevExpress.XtraCharts.ChartControl chartControl3;
    }
}
