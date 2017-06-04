﻿namespace DONGSHIN
{
    partial class ctl_Settings
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
            this.pan_top = new DevExpress.XtraEditors.PanelControl();
            this.btn_apply = new DevExpress.XtraEditors.SimpleButton();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_title = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveLocation = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pan_top)).BeginInit();
            this.pan_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSaveLocation.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_top
            // 
            this.pan_top.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(126)))), ((int)(((byte)(177)))));
            this.pan_top.Appearance.Options.UseBackColor = true;
            this.pan_top.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pan_top.Controls.Add(this.btn_apply);
            this.pan_top.Controls.Add(this.btn_close);
            this.pan_top.Controls.Add(this.lbl_title);
            this.pan_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_top.Location = new System.Drawing.Point(0, 0);
            this.pan_top.Name = "pan_top";
            this.pan_top.Size = new System.Drawing.Size(1164, 85);
            this.pan_top.TabIndex = 12;
            // 
            // btn_apply
            // 
            this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_apply.Appearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_apply.Appearance.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_apply.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_apply.Appearance.Options.UseBackColor = true;
            this.btn_apply.Appearance.Options.UseBorderColor = true;
            this.btn_apply.Appearance.Options.UseFont = true;
            this.btn_apply.Appearance.Options.UseForeColor = true;
            this.btn_apply.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_apply.Image = global::DONGSHIN.Properties.Resources.ico_apply;
            this.btn_apply.Location = new System.Drawing.Point(943, 23);
            this.btn_apply.LookAndFeel.SkinName = "VS2010";
            this.btn_apply.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(100, 42);
            this.btn_apply.TabIndex = 8;
            this.btn_apply.Text = "적용";
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Appearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_close.Appearance.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_close.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_close.Appearance.Options.UseBackColor = true;
            this.btn_close.Appearance.Options.UseBorderColor = true;
            this.btn_close.Appearance.Options.UseFont = true;
            this.btn_close.Appearance.Options.UseForeColor = true;
            this.btn_close.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_close.Image = global::DONGSHIN.Properties.Resources.ico_close;
            this.btn_close.Location = new System.Drawing.Point(1049, 23);
            this.btn_close.LookAndFeel.SkinName = "VS2010";
            this.btn_close.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(100, 42);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "닫기";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_title.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_title.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lbl_title.Location = new System.Drawing.Point(13, 25);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(646, 34);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "환경 설정";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(25, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "데이터 저장위치";
            // 
            // buttonSaveLocation
            // 
            this.buttonSaveLocation.Location = new System.Drawing.Point(200, 119);
            this.buttonSaveLocation.Name = "buttonSaveLocation";
            this.buttonSaveLocation.Properties.Appearance.Font = new System.Drawing.Font("나눔고딕", 15F);
            this.buttonSaveLocation.Properties.Appearance.Options.UseFont = true;
            this.buttonSaveLocation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonSaveLocation.Size = new System.Drawing.Size(949, 30);
            this.buttonSaveLocation.TabIndex = 14;
            // 
            // ctl_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSaveLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pan_top);
            this.Name = "ctl_Settings";
            this.Size = new System.Drawing.Size(1164, 689);
            ((System.ComponentModel.ISupportInitialize)(this.pan_top)).EndInit();
            this.pan_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonSaveLocation.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pan_top;
        private DevExpress.XtraEditors.SimpleButton btn_apply;
        private DevExpress.XtraEditors.SimpleButton btn_close;
        private DevExpress.XtraEditors.LabelControl lbl_title;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ButtonEdit buttonSaveLocation;

    }
}