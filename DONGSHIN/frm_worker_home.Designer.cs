namespace DONGSHIN
{
    partial class frm_worker_home
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::DONGSHIN.SplashScreen1), true, false);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_worker_home));
            this.pan_top = new DevExpress.XtraEditors.PanelControl();
            this.lbl_type = new DevExpress.XtraEditors.LabelControl();
            this.lbl_cycle = new DevExpress.XtraEditors.LabelControl();
            this.pan_background = new DevExpress.XtraEditors.PanelControl();
            this.lbl_user = new DevExpress.XtraEditors.LabelControl();
            this.lbl_mold = new DevExpress.XtraEditors.LabelControl();
            this.lbl_num = new DevExpress.XtraEditors.LabelControl();
            this.menu_info = new DevExpress.XtraEditors.TileControl();
            this.menu_mode = new DevExpress.XtraEditors.TileControl();
            this.menu_user = new DevExpress.XtraEditors.TileControl();
            this.menu_mold = new DevExpress.XtraEditors.TileControl();
            this.menu_num = new DevExpress.XtraEditors.TileControl();
            this.menu_machine = new DevExpress.XtraEditors.TileControl();
            this.pan_left = new DevExpress.XtraEditors.PanelControl();
            this.lbl_verdate = new DevExpress.XtraEditors.LabelControl();
            this.pan_rightmost = new DevExpress.XtraEditors.PanelControl();
            this.menu_rightmost = new DevExpress.XtraEditors.TileControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.pan_right = new DevExpress.XtraEditors.PanelControl();
            this.drop_condition = new DevExpress.XtraEditors.TileControl();
            this.drop_monitor = new DevExpress.XtraEditors.TileControl();
            this.drop_core = new DevExpress.XtraEditors.TileControl();
            this.drop_temp = new DevExpress.XtraEditors.TileControl();
            this.drop_inject = new DevExpress.XtraEditors.TileControl();
            this.drop_clamp = new DevExpress.XtraEditors.TileControl();
            this.tileCONPER = new DevExpress.XtraEditors.TileControl();
            this.menu_switch = new DevExpress.XtraEditors.TileControl();
            this.drop_home = new DevExpress.XtraEditors.TileControl();
            this.menu_heater = new DevExpress.XtraEditors.TileControl();
            this.menu_motor = new DevExpress.XtraEditors.TileControl();
            this.menu_alert = new DevExpress.XtraEditors.TileControl();
            this.menu_onoff = new DevExpress.XtraEditors.TileControl();
            ((System.ComponentModel.ISupportInitialize)(this.pan_top)).BeginInit();
            this.pan_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pan_background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pan_left)).BeginInit();
            this.pan_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pan_rightmost)).BeginInit();
            this.pan_rightmost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pan_right)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // pan_top
            // 
            this.pan_top.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.pan_top.Appearance.Options.UseBackColor = true;
            this.pan_top.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pan_top.Controls.Add(this.tileCONPER);
            this.pan_top.Controls.Add(this.menu_switch);
            this.pan_top.Controls.Add(this.drop_home);
            this.pan_top.Controls.Add(this.lbl_type);
            this.pan_top.Controls.Add(this.lbl_cycle);
            this.pan_top.Controls.Add(this.pan_background);
            this.pan_top.Controls.Add(this.lbl_user);
            this.pan_top.Controls.Add(this.lbl_mold);
            this.pan_top.Controls.Add(this.lbl_num);
            this.pan_top.Controls.Add(this.menu_info);
            this.pan_top.Controls.Add(this.menu_heater);
            this.pan_top.Controls.Add(this.menu_motor);
            this.pan_top.Controls.Add(this.menu_alert);
            this.pan_top.Controls.Add(this.menu_mode);
            this.pan_top.Controls.Add(this.menu_user);
            this.pan_top.Controls.Add(this.menu_mold);
            this.pan_top.Controls.Add(this.menu_num);
            this.pan_top.Controls.Add(this.menu_machine);
            this.pan_top.Controls.Add(this.menu_onoff);
            this.pan_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_top.Location = new System.Drawing.Point(0, 0);
            this.pan_top.Name = "pan_top";
            this.pan_top.Size = new System.Drawing.Size(1904, 109);
            this.pan_top.TabIndex = 1;
            // 
            // lbl_type
            // 
            this.lbl_type.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_type.Location = new System.Drawing.Point(183, 84);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(24, 15);
            this.lbl_type.TabIndex = 15;
            this.lbl_type.Text = "기종";
            // 
            // lbl_cycle
            // 
            this.lbl_cycle.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cycle.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_cycle.Location = new System.Drawing.Point(1128, 23);
            this.lbl_cycle.LookAndFeel.SkinMaskColor = System.Drawing.Color.Transparent;
            this.lbl_cycle.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Transparent;
            this.lbl_cycle.Name = "lbl_cycle";
            this.lbl_cycle.Size = new System.Drawing.Size(0, 15);
            this.lbl_cycle.TabIndex = 14;
            this.lbl_cycle.Visible = false;
            // 
            // pan_background
            // 
            this.pan_background.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pan_background.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.pan_background.Appearance.Options.UseBackColor = true;
            this.pan_background.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pan_background.Location = new System.Drawing.Point(109, 109);
            this.pan_background.Name = "pan_background";
            this.pan_background.Size = new System.Drawing.Size(1133, 944);
            this.pan_background.TabIndex = 5;
            // 
            // lbl_user
            // 
            this.lbl_user.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(189)))), ((int)(((byte)(234)))));
            this.lbl_user.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_user.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_user.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_user.Location = new System.Drawing.Point(557, 86);
            this.lbl_user.LookAndFeel.SkinMaskColor = System.Drawing.Color.Transparent;
            this.lbl_user.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Transparent;
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(200, 15);
            this.lbl_user.TabIndex = 13;
            this.lbl_user.Text = "사용자";
            // 
            // lbl_mold
            // 
            this.lbl_mold.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(145)))), ((int)(((byte)(192)))));
            this.lbl_mold.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mold.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_mold.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_mold.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_mold.Location = new System.Drawing.Point(439, 84);
            this.lbl_mold.LookAndFeel.SkinMaskColor = System.Drawing.Color.Transparent;
            this.lbl_mold.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Transparent;
            this.lbl_mold.Name = "lbl_mold";
            this.lbl_mold.Size = new System.Drawing.Size(100, 15);
            this.lbl_mold.TabIndex = 12;
            this.lbl_mold.Text = "금형이름";
            // 
            // lbl_num
            // 
            this.lbl_num.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.lbl_num.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_num.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_num.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_num.Location = new System.Drawing.Point(224, 84);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(95, 15);
            this.lbl_num.TabIndex = 10;
            this.lbl_num.Text = "호기";
            // 
            // menu_info
            // 
            this.menu_info.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_info.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menu_info.AppearanceText.Options.UseFont = true;
            this.menu_info.AppearanceText.Options.UseForeColor = true;
            this.menu_info.AppearanceText.Options.UseTextOptions = true;
            this.menu_info.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.menu_info.AppearanceText.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.menu_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.menu_info.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_info.DragSize = new System.Drawing.Size(0, 0);
            this.menu_info.ItemTextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always;
            this.menu_info.Location = new System.Drawing.Point(1092, 0);
            this.menu_info.MaxId = 1;
            this.menu_info.Name = "menu_info";
            this.menu_info.Padding = new System.Windows.Forms.Padding(10, 85, 18, 18);
            this.menu_info.ShowText = true;
            this.menu_info.Size = new System.Drawing.Size(148, 109);
            this.menu_info.TabIndex = 9;
            this.menu_info.Text = "현동작 상태";
            // 
            // menu_mode
            // 
            this.menu_mode.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_mode.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menu_mode.AppearanceText.Options.UseFont = true;
            this.menu_mode.AppearanceText.Options.UseForeColor = true;
            this.menu_mode.AppearanceText.Options.UseTextOptions = true;
            this.menu_mode.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.menu_mode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.menu_mode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_mode.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_mode.DragSize = new System.Drawing.Size(0, 0);
            this.menu_mode.ItemCheckMode = DevExpress.XtraEditors.TileItemCheckMode.Single;
            this.menu_mode.ItemImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            this.menu_mode.Location = new System.Drawing.Point(763, 0);
            this.menu_mode.Name = "menu_mode";
            this.menu_mode.Padding = new System.Windows.Forms.Padding(6, 70, 6, 18);
            this.menu_mode.ShowText = true;
            this.menu_mode.Size = new System.Drawing.Size(83, 109);
            this.menu_mode.TabIndex = 5;
            // 
            // menu_user
            // 
            this.menu_user.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_user.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menu_user.AppearanceText.Options.UseFont = true;
            this.menu_user.AppearanceText.Options.UseForeColor = true;
            this.menu_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(189)))), ((int)(((byte)(234)))));
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
            // menu_mold
            // 
            this.menu_mold.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_mold.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menu_mold.AppearanceText.Options.UseFont = true;
            this.menu_mold.AppearanceText.Options.UseForeColor = true;
            this.menu_mold.AppearanceText.Options.UseTextOptions = true;
            this.menu_mold.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.menu_mold.AppearanceText.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.menu_mold.AppearanceText.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.menu_mold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(145)))), ((int)(((byte)(192)))));
            this.menu_mold.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_mold.DragSize = new System.Drawing.Size(0, 0);
            this.menu_mold.Location = new System.Drawing.Point(327, 0);
            this.menu_mold.Name = "menu_mold";
            this.menu_mold.Padding = new System.Windows.Forms.Padding(15, 22, 15, 15);
            this.menu_mold.ShowText = true;
            this.menu_mold.Size = new System.Drawing.Size(218, 109);
            this.menu_mold.TabIndex = 3;
            this.menu_mold.Text = "DONGSHIN_160912_CELLPHONE_CASE";
            // 
            // menu_num
            // 
            this.menu_num.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_num.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menu_num.AppearanceText.Options.UseFont = true;
            this.menu_num.AppearanceText.Options.UseForeColor = true;
            this.menu_num.AppearanceText.Options.UseTextOptions = true;
            this.menu_num.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.menu_num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(101)))), ((int)(((byte)(131)))));
            this.menu_num.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_num.DragSize = new System.Drawing.Size(0, 0);
            this.menu_num.Location = new System.Drawing.Point(218, 0);
            this.menu_num.Name = "menu_num";
            this.menu_num.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.menu_num.ShowText = true;
            this.menu_num.Size = new System.Drawing.Size(109, 109);
            this.menu_num.TabIndex = 2;
            this.menu_num.Text = "1";
            // 
            // menu_machine
            // 
            this.menu_machine.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menu_machine.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menu_machine.AppearanceText.Options.UseFont = true;
            this.menu_machine.AppearanceText.Options.UseForeColor = true;
            this.menu_machine.AppearanceText.Options.UseTextOptions = true;
            this.menu_machine.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.menu_machine.AppearanceText.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.menu_machine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.menu_machine.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_machine.DragSize = new System.Drawing.Size(0, 0);
            this.menu_machine.Location = new System.Drawing.Point(109, 0);
            this.menu_machine.Name = "menu_machine";
            this.menu_machine.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.menu_machine.ShowText = true;
            this.menu_machine.Size = new System.Drawing.Size(109, 109);
            this.menu_machine.TabIndex = 1;
            this.menu_machine.Text = "MC";
            // 
            // pan_left
            // 
            this.pan_left.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.pan_left.Appearance.Options.UseBackColor = true;
            this.pan_left.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pan_left.Controls.Add(this.drop_condition);
            this.pan_left.Controls.Add(this.drop_monitor);
            this.pan_left.Controls.Add(this.drop_core);
            this.pan_left.Controls.Add(this.drop_temp);
            this.pan_left.Controls.Add(this.drop_inject);
            this.pan_left.Controls.Add(this.drop_clamp);
            this.pan_left.Controls.Add(this.lbl_verdate);
            this.pan_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan_left.Location = new System.Drawing.Point(0, 109);
            this.pan_left.Name = "pan_left";
            this.pan_left.Size = new System.Drawing.Size(109, 932);
            this.pan_left.TabIndex = 2;
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
            this.lbl_verdate.TabIndex = 0;
            // 
            // pan_rightmost
            // 
            this.pan_rightmost.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.pan_rightmost.Appearance.Options.UseBackColor = true;
            this.pan_rightmost.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pan_rightmost.Controls.Add(this.menu_rightmost);
            this.pan_rightmost.Dock = System.Windows.Forms.DockStyle.Right;
            this.pan_rightmost.Location = new System.Drawing.Point(1866, 109);
            this.pan_rightmost.Name = "pan_rightmost";
            this.pan_rightmost.Size = new System.Drawing.Size(38, 932);
            this.pan_rightmost.TabIndex = 4;
            this.pan_rightmost.Visible = false;
            // 
            // menu_rightmost
            // 
            this.menu_rightmost.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_rightmost.DragSize = new System.Drawing.Size(0, 0);
            this.menu_rightmost.Location = new System.Drawing.Point(0, 0);
            this.menu_rightmost.Name = "menu_rightmost";
            this.menu_rightmost.Size = new System.Drawing.Size(38, 80);
            this.menu_rightmost.TabIndex = 0;
            this.menu_rightmost.Text = "tileControl1";
            this.menu_rightmost.Click += new System.EventHandler(this.menu_rightmost_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(109, 109);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 932);
            this.panel1.TabIndex = 5;
            // 
            // dataUpdateTimer
            // 
            this.dataUpdateTimer.Enabled = true;
            this.dataUpdateTimer.Interval = 2000;
            this.dataUpdateTimer.Tick += new System.EventHandler(this.dataUpdateTimer_Tick);
            // 
            // pan_right
            // 
            this.pan_right.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.pan_right.Appearance.Options.UseBackColor = true;
            this.pan_right.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pan_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pan_right.Location = new System.Drawing.Point(1188, 109);
            this.pan_right.Name = "pan_right";
            this.pan_right.Size = new System.Drawing.Size(678, 932);
            this.pan_right.TabIndex = 3;
            // 
            // drop_condition
            // 
            this.drop_condition.AllowItemHover = true;
            this.drop_condition.AllowSelectedItem = true;
            this.drop_condition.AppearanceItem.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(200)))), ((int)(((byte)(235)))));
            this.drop_condition.AppearanceItem.Hovered.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_condition.AppearanceItem.Hovered.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drop_condition.AppearanceItem.Hovered.Image = global::DONGSHIN.Properties.Resources.ConditionKeyHover;
            this.drop_condition.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.drop_condition.AppearanceItem.Hovered.Options.UseFont = true;
            this.drop_condition.AppearanceItem.Hovered.Options.UseForeColor = true;
            this.drop_condition.AppearanceItem.Hovered.Options.UseImage = true;
            this.drop_condition.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.drop_condition.AppearanceItem.Normal.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_condition.AppearanceItem.Normal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drop_condition.AppearanceItem.Normal.Image = global::DONGSHIN.Properties.Resources.ConditionKeyOff;
            this.drop_condition.AppearanceItem.Normal.Options.UseBackColor = true;
            this.drop_condition.AppearanceItem.Normal.Options.UseFont = true;
            this.drop_condition.AppearanceItem.Normal.Options.UseForeColor = true;
            this.drop_condition.AppearanceItem.Normal.Options.UseImage = true;
            this.drop_condition.AppearanceItem.Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(237)))));
            this.drop_condition.AppearanceItem.Selected.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_condition.AppearanceItem.Selected.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drop_condition.AppearanceItem.Selected.Image = global::DONGSHIN.Properties.Resources.ConditionKeyOn;
            this.drop_condition.AppearanceItem.Selected.Options.UseBackColor = true;
            this.drop_condition.AppearanceItem.Selected.Options.UseFont = true;
            this.drop_condition.AppearanceItem.Selected.Options.UseForeColor = true;
            this.drop_condition.AppearanceItem.Selected.Options.UseImage = true;
            this.drop_condition.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.drop_condition.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drop_condition.AppearanceText.Options.UseFont = true;
            this.drop_condition.AppearanceText.Options.UseForeColor = true;
            this.drop_condition.AppearanceText.Options.UseTextOptions = true;
            this.drop_condition.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.drop_condition.AppearanceText.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.drop_condition.AppearanceText.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.drop_condition.BackgroundImage = global::DONGSHIN.Properties.Resources.ConditionKeyOff;
            this.drop_condition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.drop_condition.Dock = System.Windows.Forms.DockStyle.Top;
            this.drop_condition.DragSize = new System.Drawing.Size(0, 0);
            this.drop_condition.ItemCheckMode = DevExpress.XtraEditors.TileItemCheckMode.Single;
            this.drop_condition.Location = new System.Drawing.Point(0, 545);
            this.drop_condition.Name = "drop_condition";
            this.drop_condition.Padding = new System.Windows.Forms.Padding(10, 70, 10, 10);
            this.drop_condition.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(237)))));
            this.drop_condition.ShowText = true;
            this.drop_condition.Size = new System.Drawing.Size(109, 109);
            this.drop_condition.TabIndex = 8;
            this.drop_condition.Text = "사출성형조건표";
            // 
            // drop_monitor
            // 
            this.drop_monitor.AllowItemHover = true;
            this.drop_monitor.AllowSelectedItem = true;
            this.drop_monitor.AppearanceItem.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(200)))), ((int)(((byte)(235)))));
            this.drop_monitor.AppearanceItem.Hovered.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_monitor.AppearanceItem.Hovered.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drop_monitor.AppearanceItem.Hovered.Image = global::DONGSHIN.Properties.Resources.MonitoringkeyHover;
            this.drop_monitor.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.drop_monitor.AppearanceItem.Hovered.Options.UseFont = true;
            this.drop_monitor.AppearanceItem.Hovered.Options.UseForeColor = true;
            this.drop_monitor.AppearanceItem.Hovered.Options.UseImage = true;
            this.drop_monitor.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.drop_monitor.AppearanceItem.Normal.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_monitor.AppearanceItem.Normal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drop_monitor.AppearanceItem.Normal.Image = global::DONGSHIN.Properties.Resources.MonitoringkeyOff;
            this.drop_monitor.AppearanceItem.Normal.Options.UseBackColor = true;
            this.drop_monitor.AppearanceItem.Normal.Options.UseFont = true;
            this.drop_monitor.AppearanceItem.Normal.Options.UseForeColor = true;
            this.drop_monitor.AppearanceItem.Normal.Options.UseImage = true;
            this.drop_monitor.AppearanceItem.Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(237)))));
            this.drop_monitor.AppearanceItem.Selected.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_monitor.AppearanceItem.Selected.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drop_monitor.AppearanceItem.Selected.Image = global::DONGSHIN.Properties.Resources.MonitoringkeyOn;
            this.drop_monitor.AppearanceItem.Selected.Options.UseBackColor = true;
            this.drop_monitor.AppearanceItem.Selected.Options.UseFont = true;
            this.drop_monitor.AppearanceItem.Selected.Options.UseForeColor = true;
            this.drop_monitor.AppearanceItem.Selected.Options.UseImage = true;
            this.drop_monitor.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.drop_monitor.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drop_monitor.AppearanceText.Options.UseFont = true;
            this.drop_monitor.AppearanceText.Options.UseForeColor = true;
            this.drop_monitor.AppearanceText.Options.UseTextOptions = true;
            this.drop_monitor.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.drop_monitor.AppearanceText.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.drop_monitor.AppearanceText.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.drop_monitor.BackgroundImage = global::DONGSHIN.Properties.Resources.MonitoringkeyOff;
            this.drop_monitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.drop_monitor.Dock = System.Windows.Forms.DockStyle.Top;
            this.drop_monitor.DragSize = new System.Drawing.Size(0, 0);
            this.drop_monitor.ItemCheckMode = DevExpress.XtraEditors.TileItemCheckMode.Single;
            this.drop_monitor.Location = new System.Drawing.Point(0, 436);
            this.drop_monitor.Name = "drop_monitor";
            this.drop_monitor.Padding = new System.Windows.Forms.Padding(10, 70, 10, 10);
            this.drop_monitor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(237)))));
            this.drop_monitor.ShowText = true;
            this.drop_monitor.Size = new System.Drawing.Size(109, 109);
            this.drop_monitor.TabIndex = 7;
            this.drop_monitor.Text = "기능&모니터링";
            // 
            // drop_core
            // 
            this.drop_core.AllowItemHover = true;
            this.drop_core.AllowSelectedItem = true;
            this.drop_core.AppearanceItem.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(200)))), ((int)(((byte)(235)))));
            this.drop_core.AppearanceItem.Hovered.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_core.AppearanceItem.Hovered.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drop_core.AppearanceItem.Hovered.Image = global::DONGSHIN.Properties.Resources.CorekeyHover;
            this.drop_core.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.drop_core.AppearanceItem.Hovered.Options.UseFont = true;
            this.drop_core.AppearanceItem.Hovered.Options.UseForeColor = true;
            this.drop_core.AppearanceItem.Hovered.Options.UseImage = true;
            this.drop_core.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.drop_core.AppearanceItem.Normal.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_core.AppearanceItem.Normal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drop_core.AppearanceItem.Normal.Image = global::DONGSHIN.Properties.Resources.CorekeyOff;
            this.drop_core.AppearanceItem.Normal.Options.UseBackColor = true;
            this.drop_core.AppearanceItem.Normal.Options.UseFont = true;
            this.drop_core.AppearanceItem.Normal.Options.UseForeColor = true;
            this.drop_core.AppearanceItem.Normal.Options.UseImage = true;
            this.drop_core.AppearanceItem.Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(237)))));
            this.drop_core.AppearanceItem.Selected.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_core.AppearanceItem.Selected.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drop_core.AppearanceItem.Selected.Image = global::DONGSHIN.Properties.Resources.CorekeyOn;
            this.drop_core.AppearanceItem.Selected.Options.UseBackColor = true;
            this.drop_core.AppearanceItem.Selected.Options.UseFont = true;
            this.drop_core.AppearanceItem.Selected.Options.UseForeColor = true;
            this.drop_core.AppearanceItem.Selected.Options.UseImage = true;
            this.drop_core.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.drop_core.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drop_core.AppearanceText.Options.UseFont = true;
            this.drop_core.AppearanceText.Options.UseForeColor = true;
            this.drop_core.AppearanceText.Options.UseTextOptions = true;
            this.drop_core.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.drop_core.AppearanceText.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.drop_core.AppearanceText.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.drop_core.BackgroundImage = global::DONGSHIN.Properties.Resources.CorekeyOff;
            this.drop_core.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.drop_core.Dock = System.Windows.Forms.DockStyle.Top;
            this.drop_core.DragSize = new System.Drawing.Size(0, 0);
            this.drop_core.ItemCheckMode = DevExpress.XtraEditors.TileItemCheckMode.Single;
            this.drop_core.Location = new System.Drawing.Point(0, 327);
            this.drop_core.Name = "drop_core";
            this.drop_core.Padding = new System.Windows.Forms.Padding(10, 70, 10, 10);
            this.drop_core.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(237)))));
            this.drop_core.ShowText = true;
            this.drop_core.Size = new System.Drawing.Size(109, 109);
            this.drop_core.TabIndex = 6;
            this.drop_core.Text = "코어";
            // 
            // drop_temp
            // 
            this.drop_temp.AllowItemHover = true;
            this.drop_temp.AllowSelectedItem = true;
            this.drop_temp.AppearanceItem.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(200)))), ((int)(((byte)(235)))));
            this.drop_temp.AppearanceItem.Hovered.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.drop_temp.AppearanceItem.Hovered.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drop_temp.AppearanceItem.Hovered.Image = global::DONGSHIN.Properties.Resources.TempkeyHover;
            this.drop_temp.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.drop_temp.AppearanceItem.Hovered.Options.UseFont = true;
            this.drop_temp.AppearanceItem.Hovered.Options.UseForeColor = true;
            this.drop_temp.AppearanceItem.Hovered.Options.UseImage = true;
            this.drop_temp.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.drop_temp.AppearanceItem.Normal.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_temp.AppearanceItem.Normal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drop_temp.AppearanceItem.Normal.Image = global::DONGSHIN.Properties.Resources.TempkeyOff;
            this.drop_temp.AppearanceItem.Normal.Options.UseBackColor = true;
            this.drop_temp.AppearanceItem.Normal.Options.UseFont = true;
            this.drop_temp.AppearanceItem.Normal.Options.UseForeColor = true;
            this.drop_temp.AppearanceItem.Normal.Options.UseImage = true;
            this.drop_temp.AppearanceItem.Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(237)))));
            this.drop_temp.AppearanceItem.Selected.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_temp.AppearanceItem.Selected.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drop_temp.AppearanceItem.Selected.Image = global::DONGSHIN.Properties.Resources.TempkeyOn;
            this.drop_temp.AppearanceItem.Selected.Options.UseBackColor = true;
            this.drop_temp.AppearanceItem.Selected.Options.UseFont = true;
            this.drop_temp.AppearanceItem.Selected.Options.UseForeColor = true;
            this.drop_temp.AppearanceItem.Selected.Options.UseImage = true;
            this.drop_temp.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.drop_temp.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drop_temp.AppearanceText.Options.UseFont = true;
            this.drop_temp.AppearanceText.Options.UseForeColor = true;
            this.drop_temp.AppearanceText.Options.UseTextOptions = true;
            this.drop_temp.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.drop_temp.AppearanceText.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.drop_temp.AppearanceText.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.drop_temp.BackgroundImage = global::DONGSHIN.Properties.Resources.TempkeyOff;
            this.drop_temp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.drop_temp.Dock = System.Windows.Forms.DockStyle.Top;
            this.drop_temp.DragSize = new System.Drawing.Size(0, 0);
            this.drop_temp.ItemCheckMode = DevExpress.XtraEditors.TileItemCheckMode.Single;
            this.drop_temp.Location = new System.Drawing.Point(0, 218);
            this.drop_temp.Name = "drop_temp";
            this.drop_temp.Padding = new System.Windows.Forms.Padding(10, 70, 10, 10);
            this.drop_temp.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(237)))));
            this.drop_temp.ShowText = true;
            this.drop_temp.Size = new System.Drawing.Size(109, 109);
            this.drop_temp.TabIndex = 5;
            this.drop_temp.Text = "온도";
            // 
            // drop_inject
            // 
            this.drop_inject.AllowItemHover = true;
            this.drop_inject.AllowSelectedItem = true;
            this.drop_inject.AppearanceItem.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(200)))), ((int)(((byte)(235)))));
            this.drop_inject.AppearanceItem.Hovered.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.drop_inject.AppearanceItem.Hovered.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drop_inject.AppearanceItem.Hovered.Image = global::DONGSHIN.Properties.Resources.InjectionkeyHover;
            this.drop_inject.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.drop_inject.AppearanceItem.Hovered.Options.UseFont = true;
            this.drop_inject.AppearanceItem.Hovered.Options.UseForeColor = true;
            this.drop_inject.AppearanceItem.Hovered.Options.UseImage = true;
            this.drop_inject.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.drop_inject.AppearanceItem.Normal.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_inject.AppearanceItem.Normal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drop_inject.AppearanceItem.Normal.Image = global::DONGSHIN.Properties.Resources.InjectionkeyOff;
            this.drop_inject.AppearanceItem.Normal.Options.UseBackColor = true;
            this.drop_inject.AppearanceItem.Normal.Options.UseFont = true;
            this.drop_inject.AppearanceItem.Normal.Options.UseForeColor = true;
            this.drop_inject.AppearanceItem.Normal.Options.UseImage = true;
            this.drop_inject.AppearanceItem.Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(237)))));
            this.drop_inject.AppearanceItem.Selected.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.drop_inject.AppearanceItem.Selected.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drop_inject.AppearanceItem.Selected.Image = global::DONGSHIN.Properties.Resources.InjectionkeyOn;
            this.drop_inject.AppearanceItem.Selected.Options.UseBackColor = true;
            this.drop_inject.AppearanceItem.Selected.Options.UseFont = true;
            this.drop_inject.AppearanceItem.Selected.Options.UseForeColor = true;
            this.drop_inject.AppearanceItem.Selected.Options.UseImage = true;
            this.drop_inject.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.drop_inject.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drop_inject.AppearanceText.Options.UseFont = true;
            this.drop_inject.AppearanceText.Options.UseForeColor = true;
            this.drop_inject.AppearanceText.Options.UseTextOptions = true;
            this.drop_inject.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.drop_inject.AppearanceText.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.drop_inject.AppearanceText.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.drop_inject.BackgroundImage = global::DONGSHIN.Properties.Resources.InjectionkeyOff;
            this.drop_inject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.drop_inject.Dock = System.Windows.Forms.DockStyle.Top;
            this.drop_inject.DragSize = new System.Drawing.Size(0, 0);
            this.drop_inject.ItemCheckMode = DevExpress.XtraEditors.TileItemCheckMode.Single;
            this.drop_inject.Location = new System.Drawing.Point(0, 109);
            this.drop_inject.Name = "drop_inject";
            this.drop_inject.Padding = new System.Windows.Forms.Padding(10, 70, 10, 10);
            this.drop_inject.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(237)))));
            this.drop_inject.ShowText = true;
            this.drop_inject.Size = new System.Drawing.Size(109, 109);
            this.drop_inject.TabIndex = 4;
            this.drop_inject.Text = "사출&계량";
            // 
            // drop_clamp
            // 
            this.drop_clamp.AllowItemHover = true;
            this.drop_clamp.AllowSelectedItem = true;
            this.drop_clamp.AppearanceItem.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(200)))), ((int)(((byte)(235)))));
            this.drop_clamp.AppearanceItem.Hovered.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.drop_clamp.AppearanceItem.Hovered.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drop_clamp.AppearanceItem.Hovered.Image = global::DONGSHIN.Properties.Resources.ClampkeyHover;
            this.drop_clamp.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.drop_clamp.AppearanceItem.Hovered.Options.UseFont = true;
            this.drop_clamp.AppearanceItem.Hovered.Options.UseForeColor = true;
            this.drop_clamp.AppearanceItem.Hovered.Options.UseImage = true;
            this.drop_clamp.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.drop_clamp.AppearanceItem.Normal.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_clamp.AppearanceItem.Normal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drop_clamp.AppearanceItem.Normal.Image = global::DONGSHIN.Properties.Resources.ClampkeyOff;
            this.drop_clamp.AppearanceItem.Normal.Options.UseBackColor = true;
            this.drop_clamp.AppearanceItem.Normal.Options.UseFont = true;
            this.drop_clamp.AppearanceItem.Normal.Options.UseForeColor = true;
            this.drop_clamp.AppearanceItem.Normal.Options.UseImage = true;
            this.drop_clamp.AppearanceItem.Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(237)))));
            this.drop_clamp.AppearanceItem.Selected.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_clamp.AppearanceItem.Selected.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drop_clamp.AppearanceItem.Selected.Image = global::DONGSHIN.Properties.Resources.ClampkeyOn;
            this.drop_clamp.AppearanceItem.Selected.Options.UseBackColor = true;
            this.drop_clamp.AppearanceItem.Selected.Options.UseFont = true;
            this.drop_clamp.AppearanceItem.Selected.Options.UseForeColor = true;
            this.drop_clamp.AppearanceItem.Selected.Options.UseImage = true;
            this.drop_clamp.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.drop_clamp.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drop_clamp.AppearanceText.Options.UseFont = true;
            this.drop_clamp.AppearanceText.Options.UseForeColor = true;
            this.drop_clamp.AppearanceText.Options.UseTextOptions = true;
            this.drop_clamp.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.drop_clamp.AppearanceText.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.drop_clamp.AppearanceText.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
            this.drop_clamp.AppearanceText.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.drop_clamp.AppearanceText.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.drop_clamp.BackgroundImage = global::DONGSHIN.Properties.Resources.ClampkeyOff;
            this.drop_clamp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.drop_clamp.Dock = System.Windows.Forms.DockStyle.Top;
            this.drop_clamp.DragSize = new System.Drawing.Size(0, 0);
            this.drop_clamp.ItemCheckMode = DevExpress.XtraEditors.TileItemCheckMode.Single;
            this.drop_clamp.ItemImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            this.drop_clamp.Location = new System.Drawing.Point(0, 0);
            this.drop_clamp.Name = "drop_clamp";
            this.drop_clamp.Padding = new System.Windows.Forms.Padding(10, 70, 10, 10);
            this.drop_clamp.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.drop_clamp.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(237)))));
            this.drop_clamp.ShowText = true;
            this.drop_clamp.Size = new System.Drawing.Size(109, 109);
            this.drop_clamp.TabIndex = 1;
            this.drop_clamp.Text = "형개폐&이젝터";
            // 
            // tileCONPER
            // 
            this.tileCONPER.BackgroundImage = global::DONGSHIN.Properties.Resources.CONPER_BI;
            this.tileCONPER.Dock = System.Windows.Forms.DockStyle.Right;
            this.tileCONPER.DragSize = new System.Drawing.Size(0, 0);
            this.tileCONPER.Location = new System.Drawing.Point(1795, 0);
            this.tileCONPER.Name = "tileCONPER";
            this.tileCONPER.Size = new System.Drawing.Size(109, 109);
            this.tileCONPER.TabIndex = 17;
            this.tileCONPER.Text = "tileControl1";
            // 
            // menu_switch
            // 
            this.menu_switch.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_switch.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menu_switch.AppearanceText.Options.UseFont = true;
            this.menu_switch.AppearanceText.Options.UseForeColor = true;
            this.menu_switch.AppearanceText.Options.UseTextOptions = true;
            this.menu_switch.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.menu_switch.AppearanceText.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.menu_switch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.menu_switch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu_switch.BackgroundImage")));
            this.menu_switch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_switch.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_switch.DragSize = new System.Drawing.Size(0, 0);
            this.menu_switch.ItemTextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always;
            this.menu_switch.Location = new System.Drawing.Point(1349, 0);
            this.menu_switch.MaxId = 1;
            this.menu_switch.Name = "menu_switch";
            this.menu_switch.Padding = new System.Windows.Forms.Padding(10, 85, 18, 18);
            this.menu_switch.ShowText = true;
            this.menu_switch.Size = new System.Drawing.Size(148, 109);
            this.menu_switch.TabIndex = 16;
            this.menu_switch.Text = "모드전환";
            this.menu_switch.Click += new System.EventHandler(this.menu_switch_Click);
            // 
            // drop_home
            // 
            this.drop_home.AllowItemHover = true;
            this.drop_home.AllowSelectedItem = true;
            this.drop_home.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.drop_home.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.drop_home.AppearanceText.Options.UseFont = true;
            this.drop_home.AppearanceText.Options.UseForeColor = true;
            this.drop_home.AppearanceText.Options.UseTextOptions = true;
            this.drop_home.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.drop_home.AppearanceText.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.drop_home.BackgroundImage = global::DONGSHIN.Properties.Resources.homeSelected;
            this.drop_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.drop_home.Dock = System.Windows.Forms.DockStyle.Left;
            this.drop_home.DragSize = new System.Drawing.Size(0, 0);
            this.drop_home.ItemCheckMode = DevExpress.XtraEditors.TileItemCheckMode.Single;
            this.drop_home.Location = new System.Drawing.Point(1240, 0);
            this.drop_home.Name = "drop_home";
            this.drop_home.Padding = new System.Windows.Forms.Padding(10, 70, 10, 10);
            this.drop_home.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(237)))));
            this.drop_home.ShowText = true;
            this.drop_home.Size = new System.Drawing.Size(109, 109);
            this.drop_home.TabIndex = 8;
            this.drop_home.Text = "Home";
            this.drop_home.Click += new System.EventHandler(this.drop_home_Click);
            // 
            // menu_heater
            // 
            this.menu_heater.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_heater.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menu_heater.AppearanceText.Options.UseFont = true;
            this.menu_heater.AppearanceText.Options.UseForeColor = true;
            this.menu_heater.AppearanceText.Options.UseTextOptions = true;
            this.menu_heater.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.menu_heater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.menu_heater.BackgroundImage = global::DONGSHIN.Properties.Resources.HeaterOff;
            this.menu_heater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_heater.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_heater.DragSize = new System.Drawing.Size(0, 0);
            this.menu_heater.Location = new System.Drawing.Point(1009, 0);
            this.menu_heater.Name = "menu_heater";
            this.menu_heater.Padding = new System.Windows.Forms.Padding(10, 70, 10, 18);
            this.menu_heater.ShowText = true;
            this.menu_heater.Size = new System.Drawing.Size(83, 109);
            this.menu_heater.TabIndex = 8;
            this.menu_heater.Text = "히터";
            // 
            // menu_motor
            // 
            this.menu_motor.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_motor.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menu_motor.AppearanceText.Options.UseFont = true;
            this.menu_motor.AppearanceText.Options.UseForeColor = true;
            this.menu_motor.AppearanceText.Options.UseTextOptions = true;
            this.menu_motor.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.menu_motor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.menu_motor.BackgroundImage = global::DONGSHIN.Properties.Resources.MotorOff;
            this.menu_motor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_motor.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_motor.DragSize = new System.Drawing.Size(0, 0);
            this.menu_motor.Location = new System.Drawing.Point(929, 0);
            this.menu_motor.Name = "menu_motor";
            this.menu_motor.Padding = new System.Windows.Forms.Padding(10, 70, 10, 18);
            this.menu_motor.ShowText = true;
            this.menu_motor.Size = new System.Drawing.Size(80, 109);
            this.menu_motor.TabIndex = 7;
            this.menu_motor.Text = "모터";
            // 
            // menu_alert
            // 
            this.menu_alert.AppearanceGroupText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menu_alert.AppearanceGroupText.ForeColor = System.Drawing.Color.White;
            this.menu_alert.AppearanceGroupText.Options.UseFont = true;
            this.menu_alert.AppearanceGroupText.Options.UseForeColor = true;
            this.menu_alert.AppearanceText.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_alert.AppearanceText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.menu_alert.AppearanceText.Options.UseFont = true;
            this.menu_alert.AppearanceText.Options.UseForeColor = true;
            this.menu_alert.AppearanceText.Options.UseTextOptions = true;
            this.menu_alert.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.menu_alert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.menu_alert.BackgroundImage = global::DONGSHIN.Properties.Resources.AlarmOff;
            this.menu_alert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_alert.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_alert.DragSize = new System.Drawing.Size(0, 0);
            this.menu_alert.Location = new System.Drawing.Point(846, 0);
            this.menu_alert.Name = "menu_alert";
            this.menu_alert.Padding = new System.Windows.Forms.Padding(10, 70, 10, 18);
            this.menu_alert.ShowText = true;
            this.menu_alert.Size = new System.Drawing.Size(83, 109);
            this.menu_alert.TabIndex = 6;
            this.menu_alert.Text = "경보";
            // 
            // menu_onoff
            // 
            this.menu_onoff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(217)))));
            this.menu_onoff.BackgroundImage = global::DONGSHIN.Properties.Resources.DongshinLogo2;
            this.menu_onoff.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_onoff.DragSize = new System.Drawing.Size(0, 0);
            this.menu_onoff.Location = new System.Drawing.Point(0, 0);
            this.menu_onoff.Name = "menu_onoff";
            this.menu_onoff.Size = new System.Drawing.Size(109, 109);
            this.menu_onoff.TabIndex = 0;
            this.menu_onoff.Text = "tileControl1";
            // 
            // frm_worker_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pan_right);
            this.Controls.Add(this.pan_rightmost);
            this.Controls.Add(this.pan_left);
            this.Controls.Add(this.pan_top);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "frm_worker_home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_worker_home_FormClosed);
            this.Load += new System.EventHandler(this.frm_home_Load);
            this.SizeChanged += new System.EventHandler(this.frm_home_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pan_top)).EndInit();
            this.pan_top.ResumeLayout(false);
            this.pan_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pan_background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pan_left)).EndInit();
            this.pan_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pan_rightmost)).EndInit();
            this.pan_rightmost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pan_right)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl menu_onoff;
        private DevExpress.XtraEditors.PanelControl pan_top;
        private DevExpress.XtraEditors.PanelControl pan_left;
        private DevExpress.XtraEditors.LabelControl lbl_verdate;
        private DevExpress.XtraEditors.TileControl menu_num;
        private DevExpress.XtraEditors.TileControl menu_machine;
        private DevExpress.XtraEditors.TileControl menu_user;
        private DevExpress.XtraEditors.TileControl menu_mold;
        private DevExpress.XtraEditors.TileControl menu_mode;
        private DevExpress.XtraEditors.TileControl menu_motor;
        private DevExpress.XtraEditors.TileControl menu_alert;
        private DevExpress.XtraEditors.TileControl menu_heater;
        private DevExpress.XtraEditors.TileControl drop_clamp;
        private DevExpress.XtraEditors.TileControl drop_inject;
        private DevExpress.XtraEditors.TileControl drop_monitor;
        private DevExpress.XtraEditors.TileControl drop_core;
        private DevExpress.XtraEditors.TileControl drop_temp;
        private DevExpress.XtraEditors.TileControl menu_info;
        private DevExpress.XtraEditors.PanelControl pan_rightmost;
        private DevExpress.XtraEditors.TileControl menu_rightmost;
        private DevExpress.XtraEditors.LabelControl lbl_num;
        private DevExpress.XtraEditors.LabelControl lbl_mold;
        private DevExpress.XtraEditors.LabelControl lbl_user;
        private DevExpress.XtraEditors.PanelControl pan_background;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lbl_type;
        private DevExpress.XtraEditors.TileControl menu_switch;
        private DevExpress.XtraEditors.TileControl drop_home;
        private System.Windows.Forms.Timer dataUpdateTimer;
        private DevExpress.XtraEditors.PanelControl pan_right;
        private DevExpress.XtraEditors.LabelControl lbl_cycle;
        private DevExpress.XtraEditors.TileControl drop_condition;
        private DevExpress.XtraEditors.TileControl tileCONPER;

    }
}

