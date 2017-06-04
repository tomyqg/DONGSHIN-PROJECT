namespace DONGSHIN.WorkerMain
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
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menu_swap = new DevExpress.XtraEditors.TileControl();
            this.menu_empty = new DevExpress.XtraEditors.TileControl();
            this.tileCONPER = new DevExpress.XtraEditors.TileControl();
            this.menu_logout = new DevExpress.XtraEditors.TileControl();
            this.menu_performance = new DevExpress.XtraEditors.TileControl();
            this.menu_status = new DevExpress.XtraEditors.TileControl();
            this.menu_monitor = new DevExpress.XtraEditors.TileControl();
            this.menu_home = new DevExpress.XtraEditors.TileControl();
            this.menu_onoff = new DevExpress.XtraEditors.TileControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_user = new DevExpress.XtraEditors.LabelControl();
            this.menu_user = new DevExpress.XtraEditors.TileControl();
            this.pan_center = new DevExpress.XtraEditors.PanelControl();
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.pan_left = new DevExpress.XtraEditors.PanelControl();
            this.lbl_verdate = new DevExpress.XtraEditors.LabelControl();
            this.menu_mapSetting = new DevExpress.XtraEditors.TileControl();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pan_center)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pan_left)).BeginInit();
            this.pan_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.tableLayoutPanel1.ColumnCount = 11;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.Controls.Add(this.menu_swap, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.menu_empty, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tileCONPER, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.menu_logout, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.menu_performance, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.menu_status, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.menu_monitor, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.menu_home, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.menu_onoff, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1904, 111);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // menu_swap
            // 
            this.menu_swap.AllowSelectedItem = true;
            this.menu_swap.AppearanceItem.Normal.Image = global::DONGSHIN.Properties.Resources.performanceNormal;
            this.menu_swap.AppearanceItem.Normal.Options.UseImage = true;
            this.menu_swap.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.menu_swap.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.menu_swap.AppearanceItem.Selected.Image = global::DONGSHIN.Properties.Resources.performanceSelected;
            this.menu_swap.AppearanceItem.Selected.Options.UseImage = true;
            this.menu_swap.AppearanceItem.Selected.Options.UseTextOptions = true;
            this.menu_swap.AppearanceItem.Selected.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.menu_swap.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_swap.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menu_swap.AppearanceText.Options.UseFont = true;
            this.menu_swap.AppearanceText.Options.UseForeColor = true;
            this.menu_swap.AppearanceText.Options.UseTextOptions = true;
            this.menu_swap.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.menu_swap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.menu_swap.BackgroundImage = global::DONGSHIN.Properties.Resources.ManualModeOn;
            this.menu_swap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_swap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_swap.DragSize = new System.Drawing.Size(0, 0);
            this.menu_swap.Location = new System.Drawing.Point(880, 0);
            this.menu_swap.Margin = new System.Windows.Forms.Padding(0);
            this.menu_swap.Name = "menu_swap";
            this.menu_swap.Padding = new System.Windows.Forms.Padding(12, 70, 12, 18);
            this.menu_swap.ShowText = true;
            this.menu_swap.Size = new System.Drawing.Size(110, 111);
            this.menu_swap.TabIndex = 24;
            this.menu_swap.Text = "Swap Mode";
            this.menu_swap.Click += new System.EventHandler(this.menu_swap_Click);
            // 
            // menu_empty
            // 
            this.menu_empty.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_empty.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menu_empty.AppearanceText.Options.UseFont = true;
            this.menu_empty.AppearanceText.Options.UseForeColor = true;
            this.menu_empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.menu_empty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_empty.DragSize = new System.Drawing.Size(0, 0);
            this.menu_empty.Location = new System.Drawing.Point(110, 0);
            this.menu_empty.Margin = new System.Windows.Forms.Padding(0);
            this.menu_empty.Name = "menu_empty";
            this.menu_empty.Padding = new System.Windows.Forms.Padding(15, 22, 15, 15);
            this.menu_empty.ShowText = true;
            this.menu_empty.Size = new System.Drawing.Size(110, 111);
            this.menu_empty.TabIndex = 23;
            // 
            // tileCONPER
            // 
            this.tileCONPER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(138)))), ((int)(((byte)(156)))));
            this.tileCONPER.BackgroundImage = global::DONGSHIN.Properties.Resources.CONPER_BI;
            this.tileCONPER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileCONPER.DragSize = new System.Drawing.Size(0, 0);
            this.tileCONPER.Location = new System.Drawing.Point(1785, 0);
            this.tileCONPER.Margin = new System.Windows.Forms.Padding(0);
            this.tileCONPER.Name = "tileCONPER";
            this.tileCONPER.Size = new System.Drawing.Size(119, 111);
            this.tileCONPER.TabIndex = 22;
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
            this.menu_logout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_logout.DragSize = new System.Drawing.Size(0, 0);
            this.menu_logout.Location = new System.Drawing.Point(990, 0);
            this.menu_logout.Margin = new System.Windows.Forms.Padding(0);
            this.menu_logout.Name = "menu_logout";
            this.menu_logout.Padding = new System.Windows.Forms.Padding(18, 70, 18, 18);
            this.menu_logout.ShowText = true;
            this.menu_logout.Size = new System.Drawing.Size(110, 111);
            this.menu_logout.TabIndex = 20;
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
            this.menu_performance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_performance.DragSize = new System.Drawing.Size(0, 0);
            this.menu_performance.Location = new System.Drawing.Point(770, 0);
            this.menu_performance.Margin = new System.Windows.Forms.Padding(0);
            this.menu_performance.Name = "menu_performance";
            this.menu_performance.Padding = new System.Windows.Forms.Padding(12, 70, 12, 18);
            this.menu_performance.ShowText = true;
            this.menu_performance.Size = new System.Drawing.Size(110, 111);
            this.menu_performance.TabIndex = 17;
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
            this.menu_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_status.DragSize = new System.Drawing.Size(0, 0);
            this.menu_status.Location = new System.Drawing.Point(660, 0);
            this.menu_status.Margin = new System.Windows.Forms.Padding(0);
            this.menu_status.Name = "menu_status";
            this.menu_status.Padding = new System.Windows.Forms.Padding(18, 70, 18, 18);
            this.menu_status.ShowText = true;
            this.menu_status.Size = new System.Drawing.Size(110, 111);
            this.menu_status.TabIndex = 16;
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
            this.menu_monitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_monitor.DragSize = new System.Drawing.Size(0, 0);
            this.menu_monitor.Location = new System.Drawing.Point(550, 0);
            this.menu_monitor.Margin = new System.Windows.Forms.Padding(0);
            this.menu_monitor.Name = "menu_monitor";
            this.menu_monitor.Padding = new System.Windows.Forms.Padding(15, 70, 15, 18);
            this.menu_monitor.ShowText = true;
            this.menu_monitor.Size = new System.Drawing.Size(110, 111);
            this.menu_monitor.TabIndex = 7;
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
            this.menu_home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_home.DragSize = new System.Drawing.Size(0, 0);
            this.menu_home.ItemCheckMode = DevExpress.XtraEditors.TileItemCheckMode.Single;
            this.menu_home.ItemImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            this.menu_home.Location = new System.Drawing.Point(440, 0);
            this.menu_home.Margin = new System.Windows.Forms.Padding(0);
            this.menu_home.Name = "menu_home";
            this.menu_home.Padding = new System.Windows.Forms.Padding(18, 70, 18, 18);
            this.menu_home.ShowText = true;
            this.menu_home.Size = new System.Drawing.Size(110, 111);
            this.menu_home.TabIndex = 6;
            this.menu_home.Text = "Home";
            // 
            // menu_onoff
            // 
            this.menu_onoff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(138)))), ((int)(((byte)(156)))));
            this.menu_onoff.BackgroundImage = global::DONGSHIN.Properties.Resources.DongShinLogo3;
            this.menu_onoff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_onoff.DragSize = new System.Drawing.Size(0, 0);
            this.menu_onoff.Location = new System.Drawing.Point(0, 0);
            this.menu_onoff.Margin = new System.Windows.Forms.Padding(0);
            this.menu_onoff.Name = "menu_onoff";
            this.menu_onoff.Size = new System.Drawing.Size(110, 111);
            this.menu_onoff.TabIndex = 1;
            this.menu_onoff.Text = "tileControl1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_user);
            this.panel1.Controls.Add(this.menu_user);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 111);
            this.panel1.TabIndex = 21;
            // 
            // lbl_user
            // 
            this.lbl_user.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(138)))), ((int)(((byte)(156)))));
            this.lbl_user.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_user.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_user.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_user.Location = new System.Drawing.Point(78, 84);
            this.lbl_user.LookAndFeel.SkinMaskColor = System.Drawing.Color.Transparent;
            this.lbl_user.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Transparent;
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(120, 15);
            this.lbl_user.TabIndex = 20;
            this.lbl_user.Text = "사용자";
            // 
            // menu_user
            // 
            this.menu_user.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_user.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menu_user.AppearanceText.Options.UseFont = true;
            this.menu_user.AppearanceText.Options.UseForeColor = true;
            this.menu_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(138)))), ((int)(((byte)(156)))));
            this.menu_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_user.DragSize = new System.Drawing.Size(0, 0);
            this.menu_user.Location = new System.Drawing.Point(0, 0);
            this.menu_user.Margin = new System.Windows.Forms.Padding(0);
            this.menu_user.Name = "menu_user";
            this.menu_user.Padding = new System.Windows.Forms.Padding(15, 22, 15, 15);
            this.menu_user.ShowText = true;
            this.menu_user.Size = new System.Drawing.Size(220, 111);
            this.menu_user.TabIndex = 19;
            this.menu_user.Text = "(주)동신유압";
            // 
            // pan_center
            // 
            this.pan_center.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_center.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.pan_center.Appearance.Options.UseBackColor = true;
            this.pan_center.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pan_center.Location = new System.Drawing.Point(117, 117);
            this.pan_center.Margin = new System.Windows.Forms.Padding(5);
            this.pan_center.Name = "pan_center";
            this.pan_center.Size = new System.Drawing.Size(1780, 882);
            this.pan_center.TabIndex = 4;
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
            // pan_left
            // 
            this.pan_left.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.pan_left.Appearance.Options.UseBackColor = true;
            this.pan_left.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pan_left.Controls.Add(this.lbl_verdate);
            this.pan_left.Controls.Add(this.menu_mapSetting);
            this.pan_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan_left.Location = new System.Drawing.Point(0, 111);
            this.pan_left.Name = "pan_left";
            this.pan_left.Size = new System.Drawing.Size(109, 930);
            this.pan_left.TabIndex = 6;
            // 
            // lbl_verdate
            // 
            this.lbl_verdate.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(142)))), ((int)(((byte)(160)))));
            this.lbl_verdate.Appearance.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_verdate.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_verdate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_verdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_verdate.Location = new System.Drawing.Point(0, 888);
            this.lbl_verdate.Name = "lbl_verdate";
            this.lbl_verdate.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_verdate.Size = new System.Drawing.Size(109, 42);
            this.lbl_verdate.TabIndex = 2;
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
            // 
            // frm_worker_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pan_left);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pan_center);
            this.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Name = "frm_worker_main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_worker_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pan_center)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pan_left)).EndInit();
            this.pan_left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pan_center;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.Utils.ImageCollection imageCollection2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.TileControl menu_empty;
        private DevExpress.XtraEditors.TileControl tileCONPER;
        private DevExpress.XtraEditors.TileControl menu_logout;
        private DevExpress.XtraEditors.TileControl menu_performance;
        private DevExpress.XtraEditors.TileControl menu_status;
        private DevExpress.XtraEditors.TileControl menu_monitor;
        private DevExpress.XtraEditors.TileControl menu_home;
        private DevExpress.XtraEditors.TileControl menu_onoff;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lbl_user;
        private DevExpress.XtraEditors.TileControl menu_user;
        private DevExpress.XtraEditors.TileControl menu_swap;
        private DevExpress.XtraEditors.PanelControl pan_left;
        private DevExpress.XtraEditors.LabelControl lbl_verdate;
        private DevExpress.XtraEditors.TileControl menu_mapSetting;
    }
}