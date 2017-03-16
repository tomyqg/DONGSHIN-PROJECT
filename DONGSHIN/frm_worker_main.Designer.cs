namespace DONGSHIN
{
    partial class frm_worker_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if ( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::DONGSHIN.SplashScreen1), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_worker_main));
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.machineTypeImageCombo = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.pan_top = new DevExpress.XtraEditors.PanelControl();
            this.tileCONPER = new DevExpress.XtraEditors.TileControl();
            this.menu_logout = new DevExpress.XtraEditors.TileControl();
            this.menu_performance = new DevExpress.XtraEditors.TileControl();
            this.menu_status = new DevExpress.XtraEditors.TileControl();
            this.menu_monitor = new DevExpress.XtraEditors.TileControl();
            this.menu_home = new DevExpress.XtraEditors.TileControl();
            this.lbl_user = new DevExpress.XtraEditors.LabelControl();
            this.menu_user = new DevExpress.XtraEditors.TileControl();
            this.menu_empty = new DevExpress.XtraEditors.TileControl();
            this.menu_onoff = new DevExpress.XtraEditors.TileControl();
            this.menu_mapSetting = new DevExpress.XtraEditors.TileControl();
            this.pan_left = new DevExpress.XtraEditors.PanelControl();
            this.lbl_verdate = new DevExpress.XtraEditors.LabelControl();
            this.pan_center = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statePic = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stateUpdateTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.machineTypeImageCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pan_top)).BeginInit();
            this.pan_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pan_left)).BeginInit();
            this.pan_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pan_center)).BeginInit();
            this.pan_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(138)))), ((int)(((byte)(156)))));
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceCell.Options.UseForeColor = true;
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "기종";
            this.gridColumn3.ColumnEdit = this.machineTypeImageCombo;
            this.gridColumn3.FieldName = "MACHINE_TYPE";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 120;
            // 
            // machineTypeImageCombo
            // 
            this.machineTypeImageCombo.AutoHeight = false;
            this.machineTypeImageCombo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.machineTypeImageCombo.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.machineTypeImageCombo.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "GB", 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "MC", 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "RB", 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "KT", 3),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "PL", 4)});
            this.machineTypeImageCombo.LargeImages = this.imageCollection1;
            this.machineTypeImageCombo.Name = "machineTypeImageCombo";
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(45, 45);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.IsDpiAware = DevExpress.Utils.DefaultBoolean.True;
            this.imageCollection1.InsertImage(global::DONGSHIN.Properties.Resources.typeGB, "typeGB", typeof(global::DONGSHIN.Properties.Resources), 0);
            this.imageCollection1.Images.SetKeyName(0, "typeGB");
            this.imageCollection1.InsertImage(global::DONGSHIN.Properties.Resources.typeMC2, "typeMC2", typeof(global::DONGSHIN.Properties.Resources), 1);
            this.imageCollection1.Images.SetKeyName(1, "typeMC2");
            this.imageCollection1.InsertImage(global::DONGSHIN.Properties.Resources.typeRB, "typeRB", typeof(global::DONGSHIN.Properties.Resources), 2);
            this.imageCollection1.Images.SetKeyName(2, "typeRB");
            this.imageCollection1.InsertImage(global::DONGSHIN.Properties.Resources.typeKT, "typeKT", typeof(global::DONGSHIN.Properties.Resources), 3);
            this.imageCollection1.Images.SetKeyName(3, "typeKT");
            this.imageCollection1.InsertImage(global::DONGSHIN.Properties.Resources.typePL, "typePL", typeof(global::DONGSHIN.Properties.Resources), 4);
            this.imageCollection1.Images.SetKeyName(4, "typePL");
            // 
            // pan_top
            // 
            this.pan_top.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.pan_top.Appearance.Options.UseBackColor = true;
            this.pan_top.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pan_top.Controls.Add(this.tileCONPER);
            this.pan_top.Controls.Add(this.menu_logout);
            this.pan_top.Controls.Add(this.menu_performance);
            this.pan_top.Controls.Add(this.menu_status);
            this.pan_top.Controls.Add(this.menu_monitor);
            this.pan_top.Controls.Add(this.menu_home);
            this.pan_top.Controls.Add(this.lbl_user);
            this.pan_top.Controls.Add(this.menu_user);
            this.pan_top.Controls.Add(this.menu_empty);
            this.pan_top.Controls.Add(this.menu_onoff);
            this.pan_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_top.Location = new System.Drawing.Point(0, 0);
            this.pan_top.Name = "pan_top";
            this.pan_top.Size = new System.Drawing.Size(1904, 109);
            this.pan_top.TabIndex = 2;
            // 
            // tileCONPER
            // 
            this.tileCONPER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(138)))), ((int)(((byte)(156)))));
            this.tileCONPER.BackgroundImage = global::DONGSHIN.Properties.Resources.CONPER_BI;
            this.tileCONPER.Dock = System.Windows.Forms.DockStyle.Right;
            this.tileCONPER.DragSize = new System.Drawing.Size(0, 0);
            this.tileCONPER.Location = new System.Drawing.Point(1795, 0);
            this.tileCONPER.Name = "tileCONPER";
            this.tileCONPER.Size = new System.Drawing.Size(109, 109);
            this.tileCONPER.TabIndex = 17;
            this.tileCONPER.Text = "tileControl1";
            // 
            // menu_logout
            // 
            this.menu_logout.AllowSelectedItem = true;
            this.menu_logout.AppearanceItem.Normal.Image = global::DONGSHIN.Properties.Resources.logoutNormal;
            this.menu_logout.AppearanceItem.Normal.Options.UseImage = true;
            this.menu_logout.AppearanceItem.Selected.Image = global::DONGSHIN.Properties.Resources.logoutSelected;
            this.menu_logout.AppearanceItem.Selected.Options.UseImage = true;
            this.menu_logout.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_logout.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menu_logout.AppearanceText.Options.UseFont = true;
            this.menu_logout.AppearanceText.Options.UseForeColor = true;
            this.menu_logout.AppearanceText.Options.UseTextOptions = true;
            this.menu_logout.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.menu_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.menu_logout.BackgroundImage = global::DONGSHIN.Properties.Resources.logoutNormal;
            this.menu_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_logout.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_logout.DragSize = new System.Drawing.Size(0, 0);
            this.menu_logout.Location = new System.Drawing.Point(1199, 0);
            this.menu_logout.Name = "menu_logout";
            this.menu_logout.Padding = new System.Windows.Forms.Padding(18, 70, 18, 18);
            this.menu_logout.ShowText = true;
            this.menu_logout.Size = new System.Drawing.Size(109, 109);
            this.menu_logout.TabIndex = 8;
            this.menu_logout.Text = "Logout";
            // 
            // menu_performance
            // 
            this.menu_performance.AllowSelectedItem = true;
            this.menu_performance.AppearanceItem.Normal.Image = global::DONGSHIN.Properties.Resources.performanceNormal;
            this.menu_performance.AppearanceItem.Normal.Options.UseImage = true;
            this.menu_performance.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.menu_performance.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.menu_performance.AppearanceItem.Selected.Image = global::DONGSHIN.Properties.Resources.performanceSelected;
            this.menu_performance.AppearanceItem.Selected.Options.UseImage = true;
            this.menu_performance.AppearanceItem.Selected.Options.UseTextOptions = true;
            this.menu_performance.AppearanceItem.Selected.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.menu_performance.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_performance.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menu_performance.AppearanceText.Options.UseFont = true;
            this.menu_performance.AppearanceText.Options.UseForeColor = true;
            this.menu_performance.AppearanceText.Options.UseTextOptions = true;
            this.menu_performance.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.menu_performance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.menu_performance.BackgroundImage = global::DONGSHIN.Properties.Resources.performanceNormal;
            this.menu_performance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_performance.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_performance.DragSize = new System.Drawing.Size(0, 0);
            this.menu_performance.Location = new System.Drawing.Point(1090, 0);
            this.menu_performance.Name = "menu_performance";
            this.menu_performance.Padding = new System.Windows.Forms.Padding(12, 70, 12, 18);
            this.menu_performance.ShowText = true;
            this.menu_performance.Size = new System.Drawing.Size(109, 109);
            this.menu_performance.TabIndex = 16;
            this.menu_performance.Text = "Performance";
            this.menu_performance.Visible = false;
            // 
            // menu_status
            // 
            this.menu_status.AllowSelectedItem = true;
            this.menu_status.AppearanceItem.Normal.Image = ((System.Drawing.Image)(resources.GetObject("menu_status.AppearanceItem.Normal.Image")));
            this.menu_status.AppearanceItem.Normal.Options.UseImage = true;
            this.menu_status.AppearanceItem.Selected.Image = ((System.Drawing.Image)(resources.GetObject("menu_status.AppearanceItem.Selected.Image")));
            this.menu_status.AppearanceItem.Selected.Options.UseImage = true;
            this.menu_status.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_status.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menu_status.AppearanceText.Options.UseFont = true;
            this.menu_status.AppearanceText.Options.UseForeColor = true;
            this.menu_status.AppearanceText.Options.UseTextOptions = true;
            this.menu_status.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.menu_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.menu_status.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu_status.BackgroundImage")));
            this.menu_status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_status.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_status.DragSize = new System.Drawing.Size(0, 0);
            this.menu_status.Location = new System.Drawing.Point(981, 0);
            this.menu_status.Name = "menu_status";
            this.menu_status.Padding = new System.Windows.Forms.Padding(18, 70, 18, 18);
            this.menu_status.ShowText = true;
            this.menu_status.Size = new System.Drawing.Size(109, 109);
            this.menu_status.TabIndex = 15;
            this.menu_status.Text = "Status";
            // 
            // menu_monitor
            // 
            this.menu_monitor.AllowSelectedItem = true;
            this.menu_monitor.AppearanceGroupText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menu_monitor.AppearanceGroupText.ForeColor = System.Drawing.Color.White;
            this.menu_monitor.AppearanceGroupText.Options.UseFont = true;
            this.menu_monitor.AppearanceGroupText.Options.UseForeColor = true;
            this.menu_monitor.AppearanceItem.Normal.Image = global::DONGSHIN.Properties.Resources.monitorNormal;
            this.menu_monitor.AppearanceItem.Normal.Options.UseImage = true;
            this.menu_monitor.AppearanceItem.Selected.Image = global::DONGSHIN.Properties.Resources.monitorSelected;
            this.menu_monitor.AppearanceItem.Selected.Options.UseImage = true;
            this.menu_monitor.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_monitor.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menu_monitor.AppearanceText.Options.UseFont = true;
            this.menu_monitor.AppearanceText.Options.UseForeColor = true;
            this.menu_monitor.AppearanceText.Options.UseTextOptions = true;
            this.menu_monitor.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.menu_monitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.menu_monitor.BackgroundImage = global::DONGSHIN.Properties.Resources.monitorNormal;
            this.menu_monitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_monitor.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_monitor.DragSize = new System.Drawing.Size(0, 0);
            this.menu_monitor.Location = new System.Drawing.Point(872, 0);
            this.menu_monitor.Name = "menu_monitor";
            this.menu_monitor.Padding = new System.Windows.Forms.Padding(15, 70, 15, 18);
            this.menu_monitor.ShowText = true;
            this.menu_monitor.Size = new System.Drawing.Size(109, 109);
            this.menu_monitor.TabIndex = 6;
            this.menu_monitor.Text = "Monitor";
            // 
            // menu_home
            // 
            this.menu_home.AllowSelectedItem = true;
            this.menu_home.AppearanceItem.Normal.Image = global::DONGSHIN.Properties.Resources.homeNormal;
            this.menu_home.AppearanceItem.Normal.Options.UseImage = true;
            this.menu_home.AppearanceItem.Selected.Image = global::DONGSHIN.Properties.Resources.homeSelected;
            this.menu_home.AppearanceItem.Selected.Options.UseImage = true;
            this.menu_home.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_home.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menu_home.AppearanceText.Options.UseFont = true;
            this.menu_home.AppearanceText.Options.UseForeColor = true;
            this.menu_home.AppearanceText.Options.UseTextOptions = true;
            this.menu_home.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.menu_home.BackgroundImage = global::DONGSHIN.Properties.Resources.homeNormal;
            this.menu_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_home.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_home.DragSize = new System.Drawing.Size(0, 0);
            this.menu_home.ItemCheckMode = DevExpress.XtraEditors.TileItemCheckMode.Single;
            this.menu_home.ItemImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            this.menu_home.Location = new System.Drawing.Point(763, 0);
            this.menu_home.Name = "menu_home";
            this.menu_home.Padding = new System.Windows.Forms.Padding(18, 70, 18, 18);
            this.menu_home.ShowText = true;
            this.menu_home.Size = new System.Drawing.Size(109, 109);
            this.menu_home.TabIndex = 5;
            this.menu_home.Text = "Home";
            // 
            // lbl_user
            // 
            this.lbl_user.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(138)))), ((int)(((byte)(156)))));
            this.lbl_user.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_user.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_user.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_user.Location = new System.Drawing.Point(555, 84);
            this.lbl_user.LookAndFeel.SkinMaskColor = System.Drawing.Color.Transparent;
            this.lbl_user.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Transparent;
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(200, 15);
            this.lbl_user.TabIndex = 13;
            this.lbl_user.Text = "사용자";
            // 
            // menu_user
            // 
            this.menu_user.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_user.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menu_user.AppearanceText.Options.UseFont = true;
            this.menu_user.AppearanceText.Options.UseForeColor = true;
            this.menu_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(138)))), ((int)(((byte)(156)))));
            this.menu_user.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_user.DragSize = new System.Drawing.Size(0, 0);
            this.menu_user.Location = new System.Drawing.Point(545, 0);
            this.menu_user.Name = "menu_user";
            this.menu_user.Padding = new System.Windows.Forms.Padding(15, 22, 15, 15);
            this.menu_user.ShowText = true;
            this.menu_user.Size = new System.Drawing.Size(218, 109);
            this.menu_user.TabIndex = 4;
            this.menu_user.Text = "(주)동신유압";
            // 
            // menu_empty
            // 
            this.menu_empty.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_empty.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menu_empty.AppearanceText.Options.UseFont = true;
            this.menu_empty.AppearanceText.Options.UseForeColor = true;
            this.menu_empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.menu_empty.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_empty.DragSize = new System.Drawing.Size(0, 0);
            this.menu_empty.Location = new System.Drawing.Point(109, 0);
            this.menu_empty.Name = "menu_empty";
            this.menu_empty.Padding = new System.Windows.Forms.Padding(15, 22, 15, 15);
            this.menu_empty.ShowText = true;
            this.menu_empty.Size = new System.Drawing.Size(436, 109);
            this.menu_empty.TabIndex = 14;
            // 
            // menu_onoff
            // 
            this.menu_onoff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(138)))), ((int)(((byte)(156)))));
            this.menu_onoff.BackgroundImage = global::DONGSHIN.Properties.Resources.DongShinLogo3;
            this.menu_onoff.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_onoff.DragSize = new System.Drawing.Size(0, 0);
            this.menu_onoff.Location = new System.Drawing.Point(0, 0);
            this.menu_onoff.Name = "menu_onoff";
            this.menu_onoff.Size = new System.Drawing.Size(109, 109);
            this.menu_onoff.TabIndex = 0;
            this.menu_onoff.Text = "tileControl1";
            // 
            // menu_mapSetting
            // 
            this.menu_mapSetting.AllowSelectedItem = true;
            this.menu_mapSetting.AppearanceItem.Normal.Image = global::DONGSHIN.Properties.Resources.memorymapSettingNormal;
            this.menu_mapSetting.AppearanceItem.Normal.Options.UseImage = true;
            this.menu_mapSetting.AppearanceItem.Selected.Image = global::DONGSHIN.Properties.Resources.memorymapSettingClick;
            this.menu_mapSetting.AppearanceItem.Selected.Options.UseImage = true;
            this.menu_mapSetting.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_mapSetting.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menu_mapSetting.AppearanceText.Options.UseFont = true;
            this.menu_mapSetting.AppearanceText.Options.UseForeColor = true;
            this.menu_mapSetting.AppearanceText.Options.UseTextOptions = true;
            this.menu_mapSetting.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.menu_mapSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.menu_mapSetting.BackgroundImage = global::DONGSHIN.Properties.Resources.memorymapSettingNormal;
            this.menu_mapSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_mapSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_mapSetting.DragSize = new System.Drawing.Size(0, 0);
            this.menu_mapSetting.Location = new System.Drawing.Point(0, 0);
            this.menu_mapSetting.Name = "menu_mapSetting";
            this.menu_mapSetting.Padding = new System.Windows.Forms.Padding(18, 70, 18, 18);
            this.menu_mapSetting.ShowText = true;
            this.menu_mapSetting.Size = new System.Drawing.Size(109, 109);
            this.menu_mapSetting.TabIndex = 15;
            this.menu_mapSetting.Text = "Setting";
            this.menu_mapSetting.Click += new System.EventHandler(this.mouse_click);
            // 
            // pan_left
            // 
            this.pan_left.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.pan_left.Appearance.Options.UseBackColor = true;
            this.pan_left.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pan_left.Controls.Add(this.lbl_verdate);
            this.pan_left.Controls.Add(this.menu_mapSetting);
            this.pan_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan_left.Location = new System.Drawing.Point(0, 109);
            this.pan_left.Name = "pan_left";
            this.pan_left.Size = new System.Drawing.Size(109, 932);
            this.pan_left.TabIndex = 3;
            // 
            // lbl_verdate
            // 
            this.lbl_verdate.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(142)))), ((int)(((byte)(160)))));
            this.lbl_verdate.Appearance.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_verdate.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_verdate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_verdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_verdate.Location = new System.Drawing.Point(0, 890);
            this.lbl_verdate.Name = "lbl_verdate";
            this.lbl_verdate.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_verdate.Size = new System.Drawing.Size(109, 42);
            this.lbl_verdate.TabIndex = 2;
            // 
            // pan_center
            // 
            this.pan_center.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_center.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.pan_center.Appearance.Options.UseBackColor = true;
            this.pan_center.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pan_center.Controls.Add(this.gridControl1);
            this.pan_center.Location = new System.Drawing.Point(117, 117);
            this.pan_center.Margin = new System.Windows.Forms.Padding(5);
            this.pan_center.Name = "pan_center";
            this.pan_center.Size = new System.Drawing.Size(1780, 882);
            this.pan_center.TabIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.statePic,
            this.machineTypeImageCombo});
            this.gridControl1.Size = new System.Drawing.Size(1780, 882);
            this.gridControl1.TabIndex = 2;
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
            this.gridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterPanel.Options.UseForeColor = true;
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
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(138)))), ((int)(((byte)(155)))));
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.LightGray;
            this.gridView1.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.gridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView1.Appearance.Preview.BackColor = System.Drawing.Color.Gainsboro;
            this.gridView1.Appearance.Preview.ForeColor = System.Drawing.Color.DimGray;
            this.gridView1.Appearance.Preview.Options.UseBackColor = true;
            this.gridView1.Appearance.Preview.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.DimGray;
            this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(185)))), ((int)(((byte)(230)))));
            this.gridView1.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(185)))), ((int)(((byte)(230)))));
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.PaintStyleName = "Web";
            this.gridView1.RowHeight = 50;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(138)))), ((int)(((byte)(156)))));
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceCell.Options.UseForeColor = true;
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.BorderColor = System.Drawing.Color.Transparent;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseBorderColor = true;
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "이름";
            this.gridColumn1.FieldName = "MACHINE_NAME";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 123;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(148)))), ((int)(((byte)(200)))));
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceCell.Options.UseForeColor = true;
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "호기";
            this.gridColumn2.DisplayFormat.FormatString = "00";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn2.FieldName = "MACHINE_NUMBER";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 120;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(138)))), ((int)(((byte)(156)))));
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceCell.Options.UseForeColor = true;
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "IP Address";
            this.gridColumn4.FieldName = "MACHINE_IP";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 155;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(138)))), ((int)(((byte)(156)))));
            this.gridColumn5.AppearanceCell.Options.UseFont = true;
            this.gridColumn5.AppearanceCell.Options.UseForeColor = true;
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "상태";
            this.gridColumn5.ColumnEdit = this.statePic;
            this.gridColumn5.FieldName = "STATE";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 146;
            // 
            // statePic
            // 
            this.statePic.AutoHeight = false;
            this.statePic.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.statePic.ContextButtonOptions.ShowToolTips = false;
            this.statePic.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.statePic.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 0, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 4, 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 3, 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 1, 3),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 2, 4)});
            this.statePic.LargeImages = this.imageCollection2;
            this.statePic.Name = "statePic";
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageSize = new System.Drawing.Size(94, 45);
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            this.imageCollection2.InsertImage(global::DONGSHIN.Properties.Resources.modeAlarm2, "modeAlarm2", typeof(global::DONGSHIN.Properties.Resources), 0);
            this.imageCollection2.Images.SetKeyName(0, "modeAlarm2");
            this.imageCollection2.InsertImage(global::DONGSHIN.Properties.Resources.modeAuto2, "modeAuto2", typeof(global::DONGSHIN.Properties.Resources), 1);
            this.imageCollection2.Images.SetKeyName(1, "modeAuto2");
            this.imageCollection2.InsertImage(global::DONGSHIN.Properties.Resources.modeHalfAuto2, "modeHalfAuto2", typeof(global::DONGSHIN.Properties.Resources), 2);
            this.imageCollection2.Images.SetKeyName(2, "modeHalfAuto2");
            this.imageCollection2.InsertImage(global::DONGSHIN.Properties.Resources.modeLow2, "modeLow2", typeof(global::DONGSHIN.Properties.Resources), 3);
            this.imageCollection2.Images.SetKeyName(3, "modeLow2");
            this.imageCollection2.InsertImage(global::DONGSHIN.Properties.Resources.modeManual2, "modeManual2", typeof(global::DONGSHIN.Properties.Resources), 4);
            this.imageCollection2.Images.SetKeyName(4, "modeManual2");
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn6.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(138)))), ((int)(((byte)(156)))));
            this.gridColumn6.AppearanceCell.Options.UseFont = true;
            this.gridColumn6.AppearanceCell.Options.UseForeColor = true;
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "메세지";
            this.gridColumn6.FieldName = "MESSAGE";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 300;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.Caption = "코드";
            this.gridColumn7.FieldName = "MACHINE_CODE";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.Caption = "메모리맵";
            this.gridColumn8.FieldName = "MEMORYMAP";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(138)))), ((int)(((byte)(156)))));
            this.gridColumn9.AppearanceCell.Options.UseForeColor = true;
            this.gridColumn9.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.Caption = "품명";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Width = 150;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(138)))), ((int)(((byte)(156)))));
            this.gridColumn10.AppearanceCell.Options.UseForeColor = true;
            this.gridColumn10.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn10.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.Caption = "목표수량";
            this.gridColumn10.DisplayFormat.FormatString = "n";
            this.gridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn10.FieldName = "qt_plan";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 6;
            this.gridColumn10.Width = 130;
            // 
            // gridColumn11
            // 
            this.gridColumn11.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(138)))), ((int)(((byte)(156)))));
            this.gridColumn11.AppearanceCell.Options.UseForeColor = true;
            this.gridColumn11.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn11.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn11.Caption = "생산수량";
            this.gridColumn11.DisplayFormat.FormatString = "n";
            this.gridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn11.FieldName = "productQty";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 7;
            this.gridColumn11.Width = 130;
            // 
            // gridColumn12
            // 
            this.gridColumn12.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(138)))), ((int)(((byte)(156)))));
            this.gridColumn12.AppearanceCell.Options.UseForeColor = true;
            this.gridColumn12.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn12.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn12.Caption = "불량수량";
            this.gridColumn12.DisplayFormat.FormatString = "n";
            this.gridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Width = 130;
            // 
            // gridColumn13
            // 
            this.gridColumn13.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(138)))), ((int)(((byte)(156)))));
            this.gridColumn13.AppearanceCell.Options.UseForeColor = true;
            this.gridColumn13.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn13.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn13.Caption = "달성률";
            this.gridColumn13.FieldName = "gridColumn13";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn13.Width = 130;
            // 
            // gridColumn14
            // 
            this.gridColumn14.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(138)))), ((int)(((byte)(156)))));
            this.gridColumn14.AppearanceCell.Options.UseForeColor = true;
            this.gridColumn14.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn14.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn14.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn14.Caption = "불량률";
            this.gridColumn14.FieldName = "gridColumn14";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn14.Width = 133;
            // 
            // stateUpdateTimer
            // 
            this.stateUpdateTimer.Enabled = true;
            this.stateUpdateTimer.Interval = 2000;
            this.stateUpdateTimer.Tick += new System.EventHandler(this.stateUpdateTimer_Tick);
            // 
            // frm_worker_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pan_center);
            this.Controls.Add(this.pan_left);
            this.Controls.Add(this.pan_top);
            this.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Name = "frm_worker_main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_worker_main_FormClosed);
            this.Load += new System.EventHandler(this.frm_worker_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.machineTypeImageCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pan_top)).EndInit();
            this.pan_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pan_left)).EndInit();
            this.pan_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pan_center)).EndInit();
            this.pan_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pan_top;
        private DevExpress.XtraEditors.LabelControl lbl_user;
        private DevExpress.XtraEditors.TileControl menu_logout;
        private DevExpress.XtraEditors.TileControl menu_monitor;
        private DevExpress.XtraEditors.TileControl menu_home;
        private DevExpress.XtraEditors.TileControl menu_user;
        private DevExpress.XtraEditors.PanelControl pan_left;
        private DevExpress.XtraEditors.PanelControl pan_center;
        private DevExpress.XtraEditors.LabelControl lbl_verdate;
        private DevExpress.XtraEditors.TileControl menu_empty;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox statePic;
        private DevExpress.Utils.ImageCollection imageCollection2;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox machineTypeImageCombo;
        private DevExpress.XtraEditors.TileControl menu_mapSetting;
        private System.Windows.Forms.Timer stateUpdateTimer;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraEditors.TileControl menu_status;
        private DevExpress.XtraEditors.TileControl menu_performance;
        private DevExpress.XtraEditors.TileControl tileCONPER;
        private DevExpress.XtraEditors.TileControl menu_onoff;
    }
}