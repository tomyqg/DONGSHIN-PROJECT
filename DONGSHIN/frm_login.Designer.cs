﻿namespace DONGSHIN
{
    partial class frm_login
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, false);
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.login_user = new DevExpress.XtraEditors.LabelControl();
            this.login_manager = new DevExpress.XtraEditors.LabelControl();
            this.cbx_lang = new DevExpress.XtraEditors.ComboBoxEdit();
            this.flyoutPanel1 = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl1 = new DevExpress.Utils.FlyoutPanelControl();
            this.chk_idSave = new DevExpress.XtraEditors.CheckEdit();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ok = new DevExpress.XtraEditors.SimpleButton();
            this.txt_pw = new DevExpress.XtraEditors.TextEdit();
            this.txt_empid = new DevExpress.XtraEditors.TextEdit();
            this.lbl_pw = new DevExpress.XtraEditors.LabelControl();
            this.lbl_empid = new DevExpress.XtraEditors.LabelControl();
            this.bgimg = new DevExpress.XtraEditors.LabelControl();
            this.lbl_exit = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_lang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).BeginInit();
            this.flyoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).BeginInit();
            this.flyoutPanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_idSave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pw.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_empid.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // login_user
            // 
            this.login_user.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_user.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.login_user.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.login_user.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.login_user.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.login_user.Location = new System.Drawing.Point(544, 261);
            this.login_user.Name = "login_user";
            this.login_user.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.login_user.Size = new System.Drawing.Size(390, 395);
            this.login_user.TabIndex = 3;
            this.login_user.Text = "사용자";
            this.login_user.Click += new System.EventHandler(this.login_user_Click);
            // 
            // login_manager
            // 
            this.login_manager.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_manager.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.login_manager.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.login_manager.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.login_manager.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.login_manager.Location = new System.Drawing.Point(986, 261);
            this.login_manager.Name = "login_manager";
            this.login_manager.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.login_manager.Size = new System.Drawing.Size(403, 395);
            this.login_manager.TabIndex = 4;
            this.login_manager.Text = "관리자";
            this.login_manager.Click += new System.EventHandler(this.login_manager_Click);
            // 
            // cbx_lang
            // 
            this.cbx_lang.EditValue = "한국어";
            this.cbx_lang.Location = new System.Drawing.Point(889, 736);
            this.cbx_lang.Name = "cbx_lang";
            this.cbx_lang.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cbx_lang.Properties.Appearance.BorderColor = System.Drawing.Color.White;
            this.cbx_lang.Properties.Appearance.Font = new System.Drawing.Font("나눔고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbx_lang.Properties.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbx_lang.Properties.Appearance.Options.UseBackColor = true;
            this.cbx_lang.Properties.Appearance.Options.UseBorderColor = true;
            this.cbx_lang.Properties.Appearance.Options.UseFont = true;
            this.cbx_lang.Properties.Appearance.Options.UseForeColor = true;
            this.cbx_lang.Properties.Appearance.Options.UseTextOptions = true;
            this.cbx_lang.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbx_lang.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cbx_lang.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(169)))), ((int)(((byte)(192)))));
            this.cbx_lang.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_lang.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.White;
            this.cbx_lang.Properties.AppearanceDropDown.Options.UseBackColor = true;
            this.cbx_lang.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbx_lang.Properties.AppearanceDropDown.Options.UseForeColor = true;
            this.cbx_lang.Properties.AppearanceDropDown.Options.UseTextOptions = true;
            this.cbx_lang.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbx_lang.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cbx_lang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cbx_lang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.cbx_lang.Properties.DropDownRows = 5;
            this.cbx_lang.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Standard;
            this.cbx_lang.Properties.Items.AddRange(new object[] {
            "한국어",
            "English"});
            this.cbx_lang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbx_lang.Size = new System.Drawing.Size(217, 38);
            this.cbx_lang.TabIndex = 6;
            this.cbx_lang.SelectedIndexChanged += new System.EventHandler(this.cbx_lang_SelectedIndexChanged);
            // 
            // flyoutPanel1
            // 
            this.flyoutPanel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.flyoutPanel1.Appearance.Options.UseBackColor = true;
            this.flyoutPanel1.Controls.Add(this.flyoutPanelControl1);
            this.flyoutPanel1.Location = new System.Drawing.Point(0, 150);
            this.flyoutPanel1.Name = "flyoutPanel1";
            this.flyoutPanel1.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Center;
            this.flyoutPanel1.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade;
            this.flyoutPanel1.OptionsBeakPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(139)))), ((int)(((byte)(212)))));
            this.flyoutPanel1.OwnerControl = this;
            this.flyoutPanel1.Size = new System.Drawing.Size(1920, 566);
            this.flyoutPanel1.TabIndex = 7;
            this.flyoutPanel1.Showing += new DevExpress.Utils.FlyoutPanelEventHandler(this.flyoutPanel1_Showing);
            this.flyoutPanel1.Shown += new DevExpress.Utils.FlyoutPanelEventHandler(this.flyoutPanel1_Shown);
            this.flyoutPanel1.Hiding += new DevExpress.Utils.FlyoutPanelEventHandler(this.flyoutPanel1_Hiding);
            // 
            // flyoutPanelControl1
            // 
            this.flyoutPanelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(169)))), ((int)(((byte)(192)))));
            this.flyoutPanelControl1.Appearance.BorderColor = System.Drawing.Color.White;
            this.flyoutPanelControl1.Appearance.Options.UseBackColor = true;
            this.flyoutPanelControl1.Appearance.Options.UseBorderColor = true;
            this.flyoutPanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.flyoutPanelControl1.Controls.Add(this.chk_idSave);
            this.flyoutPanelControl1.Controls.Add(this.btn_close);
            this.flyoutPanelControl1.Controls.Add(this.btn_ok);
            this.flyoutPanelControl1.Controls.Add(this.txt_pw);
            this.flyoutPanelControl1.Controls.Add(this.txt_empid);
            this.flyoutPanelControl1.Controls.Add(this.lbl_pw);
            this.flyoutPanelControl1.Controls.Add(this.lbl_empid);
            this.flyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl1.FlyoutPanel = this.flyoutPanel1;
            this.flyoutPanelControl1.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl1.Name = "flyoutPanelControl1";
            this.flyoutPanelControl1.Size = new System.Drawing.Size(1920, 566);
            this.flyoutPanelControl1.TabIndex = 0;
            // 
            // chk_idSave
            // 
            this.chk_idSave.Location = new System.Drawing.Point(1200, 157);
            this.chk_idSave.Name = "chk_idSave";
            this.chk_idSave.Properties.Appearance.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk_idSave.Properties.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chk_idSave.Properties.Appearance.Options.UseFont = true;
            this.chk_idSave.Properties.Appearance.Options.UseForeColor = true;
            this.chk_idSave.Properties.Appearance.Options.UseTextOptions = true;
            this.chk_idSave.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.chk_idSave.Properties.AutoHeight = false;
            this.chk_idSave.Properties.Caption = "저장";
            this.chk_idSave.Size = new System.Drawing.Size(191, 38);
            this.chk_idSave.TabIndex = 8;
            // 
            // btn_close
            // 
            this.btn_close.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(169)))), ((int)(((byte)(192)))));
            this.btn_close.Appearance.BorderColor = System.Drawing.Color.White;
            this.btn_close.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_close.Appearance.Options.UseBackColor = true;
            this.btn_close.Appearance.Options.UseBorderColor = true;
            this.btn_close.Appearance.Options.UseFont = true;
            this.btn_close.Appearance.Options.UseForeColor = true;
            this.btn_close.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_close.Location = new System.Drawing.Point(992, 371);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(184, 43);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "닫기";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(169)))), ((int)(((byte)(192)))));
            this.btn_ok.Appearance.BorderColor = System.Drawing.Color.White;
            this.btn_ok.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ok.Appearance.Options.UseBackColor = true;
            this.btn_ok.Appearance.Options.UseBorderColor = true;
            this.btn_ok.Appearance.Options.UseFont = true;
            this.btn_ok.Appearance.Options.UseForeColor = true;
            this.btn_ok.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_ok.Location = new System.Drawing.Point(777, 371);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(184, 43);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "확인";
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // txt_pw
            // 
            this.txt_pw.Location = new System.Drawing.Point(941, 243);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.Properties.Appearance.Font = new System.Drawing.Font("나눔고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pw.Properties.Appearance.Options.UseFont = true;
            this.txt_pw.Properties.PasswordChar = '*';
            this.txt_pw.Size = new System.Drawing.Size(234, 40);
            this.txt_pw.TabIndex = 1;
            this.txt_pw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pw_KeyDown);
            // 
            // txt_empid
            // 
            this.txt_empid.Location = new System.Drawing.Point(941, 156);
            this.txt_empid.Name = "txt_empid";
            this.txt_empid.Properties.Appearance.Font = new System.Drawing.Font("나눔고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empid.Properties.Appearance.Options.UseFont = true;
            this.txt_empid.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_empid.Size = new System.Drawing.Size(234, 40);
            this.txt_empid.TabIndex = 0;
            this.txt_empid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_empid_KeyDown);
            // 
            // lbl_pw
            // 
            this.lbl_pw.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pw.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_pw.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_pw.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_pw.Location = new System.Drawing.Point(598, 246);
            this.lbl_pw.Name = "lbl_pw";
            this.lbl_pw.Size = new System.Drawing.Size(287, 34);
            this.lbl_pw.TabIndex = 7;
            this.lbl_pw.Text = "비밀번호";
            // 
            // lbl_empid
            // 
            this.lbl_empid.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empid.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_empid.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_empid.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_empid.Location = new System.Drawing.Point(598, 160);
            this.lbl_empid.Name = "lbl_empid";
            this.lbl_empid.Size = new System.Drawing.Size(287, 34);
            this.lbl_empid.TabIndex = 6;
            this.lbl_empid.Text = "사원번호";
            // 
            // bgimg
            // 
            this.bgimg.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("bgimg.Appearance.Image")));
            this.bgimg.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.bgimg.Location = new System.Drawing.Point(12, 12);
            this.bgimg.Name = "bgimg";
            this.bgimg.Size = new System.Drawing.Size(100, 100);
            this.bgimg.TabIndex = 9;
            this.bgimg.Visible = false;
            // 
            // lbl_exit
            // 
            this.lbl_exit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_exit.Image = ((System.Drawing.Image)(resources.GetObject("lbl_exit.Image")));
            this.lbl_exit.Location = new System.Drawing.Point(1814, 34);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(47, 47);
            this.lbl_exit.TabIndex = 10;
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1920, 1041);
            this.shapeContainer1.TabIndex = 11;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 886;
            this.lineShape1.X2 = 1105;
            this.lineShape1.Y1 = 777;
            this.lineShape1.Y2 = 777;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackgroundImage = global::DONGSHIN.Properties.Resources.CONPER_BG_LOGIN;
            this.ClientSize = new System.Drawing.Size(1904, 1058);
            this.Controls.Add(this.cbx_lang);
            this.Controls.Add(this.flyoutPanel1);
            this.Controls.Add(this.login_manager);
            this.Controls.Add(this.login_user);
            this.Controls.Add(this.bgimg);
            this.Controls.Add(this.lbl_exit);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DONGSHIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbx_lang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).EndInit();
            this.flyoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).EndInit();
            this.flyoutPanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chk_idSave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pw.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_empid.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl login_user;
        private DevExpress.XtraEditors.LabelControl login_manager;
        private DevExpress.XtraEditors.ComboBoxEdit cbx_lang;
        private DevExpress.Utils.FlyoutPanel flyoutPanel1;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl1;
        private DevExpress.XtraEditors.TextEdit txt_pw;
        private DevExpress.XtraEditors.TextEdit txt_empid;
        private DevExpress.XtraEditors.LabelControl lbl_pw;
        private DevExpress.XtraEditors.LabelControl lbl_empid;
        private DevExpress.XtraEditors.SimpleButton btn_ok;
        private DevExpress.XtraEditors.SimpleButton btn_close;
        private DevExpress.XtraEditors.LabelControl bgimg;
        private System.Windows.Forms.Label lbl_exit;
        private DevExpress.XtraEditors.CheckEdit chk_idSave;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}