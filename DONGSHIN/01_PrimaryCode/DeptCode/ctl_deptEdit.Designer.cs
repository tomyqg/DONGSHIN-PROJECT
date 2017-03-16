namespace DONGSHIN
{
    partial class ctl_deptedit
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.pan_btngrp = new DevExpress.XtraEditors.PanelControl();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.txt_name = new DevExpress.XtraEditors.TextEdit();
            this.cbx_use = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_id = new DevExpress.XtraEditors.TextEdit();
            this.lbl_title = new DevExpress.XtraEditors.LabelControl();
            this.pic_back = new System.Windows.Forms.PictureBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_title = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_bsName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_id = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_use = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lci_back = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_btngrp = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pan_btngrp)).BeginInit();
            this.pan_btngrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_use.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_bsName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_use)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_btngrp)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.Controls.Add(this.pan_btngrp);
            this.layoutControl1.Controls.Add(this.txt_name);
            this.layoutControl1.Controls.Add(this.cbx_use);
            this.layoutControl1.Controls.Add(this.txt_id);
            this.layoutControl1.Controls.Add(this.lbl_title);
            this.layoutControl1.Controls.Add(this.pic_back);
            this.layoutControl1.Location = new System.Drawing.Point(510, 45);
            this.layoutControl1.LookAndFeel.SkinName = "Office 2013";
            this.layoutControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(-944, 336, 822, 350);
            this.layoutControl1.OptionsView.EnableIndentsInGroupsWithoutBorders = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(804, 450);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // pan_btngrp
            // 
            this.pan_btngrp.Appearance.BackColor = System.Drawing.Color.White;
            this.pan_btngrp.Appearance.Options.UseBackColor = true;
            this.pan_btngrp.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pan_btngrp.Controls.Add(this.btn_close);
            this.pan_btngrp.Controls.Add(this.btn_save);
            this.pan_btngrp.Location = new System.Drawing.Point(12, 215);
            this.pan_btngrp.MaximumSize = new System.Drawing.Size(776, 80);
            this.pan_btngrp.Name = "pan_btngrp";
            this.pan_btngrp.Size = new System.Drawing.Size(776, 80);
            this.pan_btngrp.TabIndex = 21;
            // 
            // btn_close
            // 
            this.btn_close.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.btn_close.Appearance.Font = new System.Drawing.Font("나눔고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_close.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_close.Appearance.Options.UseBackColor = true;
            this.btn_close.Appearance.Options.UseFont = true;
            this.btn_close.Appearance.Options.UseForeColor = true;
            this.btn_close.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_close.Location = new System.Drawing.Point(652, 18);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(121, 45);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "닫기";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_save
            // 
            this.btn_save.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.btn_save.Appearance.Font = new System.Drawing.Font("나눔고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_save.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_save.Appearance.Options.UseBackColor = true;
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.Appearance.Options.UseForeColor = true;
            this.btn_save.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_save.Location = new System.Drawing.Point(525, 18);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(121, 45);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "저장";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_name
            // 
            this.txt_name.EnterMoveNextControl = true;
            this.txt_name.Location = new System.Drawing.Point(204, 113);
            this.txt_name.Name = "txt_name";
            this.txt_name.Properties.Appearance.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Properties.Appearance.Options.UseFont = true;
            this.txt_name.Properties.AutoHeight = false;
            this.txt_name.Size = new System.Drawing.Size(586, 41);
            this.txt_name.StyleController = this.layoutControl1;
            this.txt_name.TabIndex = 20;
            this.txt_name.TextChanged += new System.EventHandler(this.chkValueChanged);
            // 
            // cbx_use
            // 
            this.cbx_use.EditValue = "Y";
            this.cbx_use.EnterMoveNextControl = true;
            this.cbx_use.Location = new System.Drawing.Point(204, 168);
            this.cbx_use.Name = "cbx_use";
            this.cbx_use.Properties.Appearance.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_use.Properties.Appearance.Options.UseFont = true;
            this.cbx_use.Properties.AppearanceDropDown.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_use.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbx_use.Properties.AutoHeight = false;
            this.cbx_use.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_use.Properties.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cbx_use.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbx_use.Size = new System.Drawing.Size(586, 41);
            this.cbx_use.StyleController = this.layoutControl1;
            this.cbx_use.TabIndex = 19;
            this.cbx_use.TextChanged += new System.EventHandler(this.chkValueChanged);
            // 
            // txt_id
            // 
            this.txt_id.EnterMoveNextControl = true;
            this.txt_id.Location = new System.Drawing.Point(204, 68);
            this.txt_id.Name = "txt_id";
            this.txt_id.Properties.Appearance.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Properties.Appearance.Options.UseFont = true;
            this.txt_id.Properties.AutoHeight = false;
            this.txt_id.Size = new System.Drawing.Size(586, 41);
            this.txt_id.StyleController = this.layoutControl1;
            this.txt_id.TabIndex = 9;
            this.txt_id.TextChanged += new System.EventHandler(this.chkValueChanged);
            // 
            // lbl_title
            // 
            this.lbl_title.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_title.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbl_title.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_title.Location = new System.Drawing.Point(95, 20);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(694, 34);
            this.lbl_title.StyleController = this.layoutControl1;
            this.lbl_title.TabIndex = 5;
            this.lbl_title.Text = "부서코드";
            // 
            // pic_back
            // 
            this.pic_back.BackColor = System.Drawing.Color.White;
            this.pic_back.Image = global::DONGSHIN.Properties.Resources.ico_back;
            this.pic_back.Location = new System.Drawing.Point(20, 20);
            this.pic_back.Name = "pic_back";
            this.pic_back.Size = new System.Drawing.Size(60, 60);
            this.pic_back.TabIndex = 4;
            this.pic_back.TabStop = false;
            this.pic_back.Click += new System.EventHandler(this.pic_back_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceGroup.BackColor = System.Drawing.Color.White;
            this.layoutControlGroup1.AppearanceGroup.Options.UseBackColor = true;
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_title,
            this.layoutControlGroup2,
            this.lci_back,
            this.lci_btngrp});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 50;
            this.layoutControlGroup1.Size = new System.Drawing.Size(804, 450);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lci_title
            // 
            this.lci_title.Control = this.lbl_title;
            this.lci_title.Location = new System.Drawing.Point(80, 0);
            this.lci_title.Name = "lci_title";
            this.lci_title.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 10, 10);
            this.lci_title.Size = new System.Drawing.Size(704, 54);
            this.lci_title.TextSize = new System.Drawing.Size(0, 0);
            this.lci_title.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AppearanceGroup.BackColor = System.Drawing.Color.White;
            this.layoutControlGroup2.AppearanceGroup.Options.UseBackColor = true;
            this.layoutControlGroup2.AppearanceItemCaption.BackColor = System.Drawing.Color.White;
            this.layoutControlGroup2.AppearanceItemCaption.Options.UseBackColor = true;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_bsName,
            this.lci_id,
            this.lci_use,
            this.emptySpaceItem4});
            this.layoutControlGroup2.Location = new System.Drawing.Point(80, 54);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Size = new System.Drawing.Size(704, 149);
            this.layoutControlGroup2.TextLocation = DevExpress.Utils.Locations.Default;
            this.layoutControlGroup2.TextVisible = false;
            // 
            // lci_bsName
            // 
            this.lci_bsName.AppearanceItemCaption.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lci_bsName.AppearanceItemCaption.Options.UseFont = true;
            this.lci_bsName.Control = this.txt_name;
            this.lci_bsName.Location = new System.Drawing.Point(0, 45);
            this.lci_bsName.MaxSize = new System.Drawing.Size(700, 45);
            this.lci_bsName.MinSize = new System.Drawing.Size(700, 45);
            this.lci_bsName.Name = "lci_bsName";
            this.lci_bsName.Size = new System.Drawing.Size(700, 45);
            this.lci_bsName.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lci_bsName.Text = "부서이름";
            this.lci_bsName.TextSize = new System.Drawing.Size(60, 19);
            // 
            // lci_id
            // 
            this.lci_id.AppearanceItemCaption.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lci_id.AppearanceItemCaption.Options.UseFont = true;
            this.lci_id.Control = this.txt_id;
            this.lci_id.Location = new System.Drawing.Point(0, 0);
            this.lci_id.MaxSize = new System.Drawing.Size(700, 45);
            this.lci_id.MinSize = new System.Drawing.Size(700, 45);
            this.lci_id.Name = "lci_id";
            this.lci_id.Size = new System.Drawing.Size(700, 45);
            this.lci_id.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lci_id.Text = "부서코드";
            this.lci_id.TextSize = new System.Drawing.Size(60, 19);
            // 
            // lci_use
            // 
            this.lci_use.AppearanceItemCaption.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lci_use.AppearanceItemCaption.Options.UseFont = true;
            this.lci_use.Control = this.cbx_use;
            this.lci_use.Location = new System.Drawing.Point(0, 100);
            this.lci_use.MaxSize = new System.Drawing.Size(700, 45);
            this.lci_use.MinSize = new System.Drawing.Size(700, 45);
            this.lci_use.Name = "lci_use";
            this.lci_use.Size = new System.Drawing.Size(700, 45);
            this.lci_use.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lci_use.Text = "사용여부";
            this.lci_use.TextSize = new System.Drawing.Size(60, 19);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 90);
            this.emptySpaceItem4.MaxSize = new System.Drawing.Size(382, 10);
            this.emptySpaceItem4.MinSize = new System.Drawing.Size(382, 10);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(700, 10);
            this.emptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lci_back
            // 
            this.lci_back.Control = this.pic_back;
            this.lci_back.Location = new System.Drawing.Point(0, 0);
            this.lci_back.MaxSize = new System.Drawing.Size(80, 80);
            this.lci_back.MinSize = new System.Drawing.Size(80, 80);
            this.lci_back.Name = "lci_back";
            this.lci_back.OptionsPrint.AllowPrint = false;
            this.lci_back.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.lci_back.Size = new System.Drawing.Size(80, 203);
            this.lci_back.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lci_back.TextSize = new System.Drawing.Size(0, 0);
            this.lci_back.TextVisible = false;
            // 
            // lci_btngrp
            // 
            this.lci_btngrp.Control = this.pan_btngrp;
            this.lci_btngrp.Location = new System.Drawing.Point(0, 203);
            this.lci_btngrp.MaxSize = new System.Drawing.Size(784, 90);
            this.lci_btngrp.MinSize = new System.Drawing.Size(784, 90);
            this.lci_btngrp.Name = "lci_btngrp";
            this.lci_btngrp.Size = new System.Drawing.Size(784, 227);
            this.lci_btngrp.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lci_btngrp.TextSize = new System.Drawing.Size(0, 0);
            this.lci_btngrp.TextVisible = false;
            // 
            // ctl_deptedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.layoutControl1);
            this.MinimumSize = new System.Drawing.Size(776, 80);
            this.Name = "ctl_deptedit";
            this.Size = new System.Drawing.Size(1795, 932);
            this.Load += new System.EventHandler(this.ctl_deptEdit_Load);
            this.VisibleChanged += new System.EventHandler(this.ctl_deptEdit_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pan_btngrp)).EndInit();
            this.pan_btngrp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_use.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_bsName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_use)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_btngrp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.PanelControl pan_btngrp;
        private DevExpress.XtraEditors.SimpleButton btn_close;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.TextEdit txt_name;
        private DevExpress.XtraEditors.ComboBoxEdit cbx_use;
        private DevExpress.XtraEditors.TextEdit txt_id;
        private DevExpress.XtraEditors.LabelControl lbl_title;
        private System.Windows.Forms.PictureBox pic_back;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lci_title;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem lci_bsName;
        private DevExpress.XtraLayout.LayoutControlItem lci_id;
        private DevExpress.XtraLayout.LayoutControlItem lci_use;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.LayoutControlItem lci_back;
        private DevExpress.XtraLayout.LayoutControlItem lci_btngrp;
    }
}
