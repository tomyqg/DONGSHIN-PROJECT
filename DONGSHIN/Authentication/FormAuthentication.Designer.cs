namespace DONGSHIN
{
    partial class FormAuthentication
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
            if (disposing && (components != null))
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
            this.buttonOK = new DevExpress.XtraEditors.SimpleButton();
            this.txtCompanyRegNum = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyRegNum.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Appearance.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Appearance.Options.UseFont = true;
            this.buttonOK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonOK.Location = new System.Drawing.Point(0, 51);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(327, 30);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "확인";
            this.buttonOK.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtCompanyRegNum
            // 
            this.txtCompanyRegNum.EditValue = "";
            this.txtCompanyRegNum.Location = new System.Drawing.Point(99, 13);
            this.txtCompanyRegNum.Name = "txtCompanyRegNum";
            this.txtCompanyRegNum.Properties.Appearance.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCompanyRegNum.Properties.Appearance.Options.UseFont = true;
            this.txtCompanyRegNum.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCompanyRegNum.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCompanyRegNum.Properties.Mask.EditMask = "\\d\\d\\d-\\d\\d-\\d\\d\\d\\d\\d";
            this.txtCompanyRegNum.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCompanyRegNum.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtCompanyRegNum.Size = new System.Drawing.Size(215, 28);
            this.txtCompanyRegNum.TabIndex = 4;
            this.txtCompanyRegNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCompanyRegNum_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(3, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 21);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "사업자번호";
            // 
            // FormAuthentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 81);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.txtCompanyRegNum);
            this.Controls.Add(this.labelControl1);
            this.Name = "FormAuthentication";
            this.Text = "업체 인증";
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyRegNum.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton buttonOK;
        private DevExpress.XtraEditors.TextEdit txtCompanyRegNum;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}