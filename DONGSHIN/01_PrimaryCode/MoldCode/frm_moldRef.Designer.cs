namespace DONGSHIN
{
    partial class frm_moldRef
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_moldRef));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pan_top = new DevExpress.XtraEditors.PanelControl();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.btn_select = new DevExpress.XtraEditors.SimpleButton();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_title = new DevExpress.XtraEditors.LabelControl();
            this.pan_sub = new DevExpress.XtraEditors.PanelControl();
            this.cbx_jejakGbn = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbl_gbn = new DevExpress.XtraEditors.LabelControl();
            this.txt_baljuBiz = new DevExpress.XtraEditors.ButtonEdit();
            this.lbl_biz = new DevExpress.XtraEditors.LabelControl();
            this.btn_refresh = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.현재값검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.검색취소ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.grid셋팅toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grid다중검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pan_top)).BeginInit();
            this.pan_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pan_sub)).BeginInit();
            this.pan_sub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_jejakGbn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_baljuBiz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridColumn21
            // 
            this.gridColumn21.AppearanceCell.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.gridColumn21.AppearanceCell.Options.UseFont = true;
            this.gridColumn21.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn21.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn21.AppearanceHeader.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.gridColumn21.AppearanceHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gridColumn21.AppearanceHeader.Options.UseFont = true;
            this.gridColumn21.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn21.Caption = "사용";
            this.gridColumn21.FieldName = "use_chk";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 7;
            this.gridColumn21.Width = 73;
            // 
            // pan_top
            // 
            this.pan_top.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(126)))), ((int)(((byte)(177)))));
            this.pan_top.Appearance.Options.UseBackColor = true;
            this.pan_top.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pan_top.Controls.Add(this.btn_close);
            this.pan_top.Controls.Add(this.btn_select);
            this.pan_top.Controls.Add(this.btn_search);
            this.pan_top.Controls.Add(this.lbl_title);
            this.pan_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_top.Location = new System.Drawing.Point(0, 0);
            this.pan_top.Name = "pan_top";
            this.pan_top.Size = new System.Drawing.Size(830, 85);
            this.pan_top.TabIndex = 14;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Appearance.BorderColor = System.Drawing.Color.White;
            this.btn_close.Appearance.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_close.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_close.Appearance.Options.UseBackColor = true;
            this.btn_close.Appearance.Options.UseBorderColor = true;
            this.btn_close.Appearance.Options.UseFont = true;
            this.btn_close.Appearance.Options.UseForeColor = true;
            this.btn_close.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_close.Image = global::DONGSHIN.Properties.Resources.ico_close;
            this.btn_close.Location = new System.Drawing.Point(716, 24);
            this.btn_close.LookAndFeel.SkinName = "VS2010";
            this.btn_close.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(100, 42);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "닫기";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_select
            // 
            this.btn_select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_select.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_select.Appearance.BorderColor = System.Drawing.Color.White;
            this.btn_select.Appearance.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_select.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_select.Appearance.Options.UseBackColor = true;
            this.btn_select.Appearance.Options.UseBorderColor = true;
            this.btn_select.Appearance.Options.UseFont = true;
            this.btn_select.Appearance.Options.UseForeColor = true;
            this.btn_select.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_select.Image = global::DONGSHIN.Properties.Resources.ico_apply;
            this.btn_select.Location = new System.Drawing.Point(613, 24);
            this.btn_select.LookAndFeel.SkinName = "VS2010";
            this.btn_select.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(90, 42);
            this.btn_select.TabIndex = 4;
            this.btn_select.Text = "선택";
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.Appearance.BorderColor = System.Drawing.Color.White;
            this.btn_search.Appearance.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_search.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_search.Appearance.Options.UseBackColor = true;
            this.btn_search.Appearance.Options.UseBorderColor = true;
            this.btn_search.Appearance.Options.UseFont = true;
            this.btn_search.Appearance.Options.UseForeColor = true;
            this.btn_search.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_search.Image = global::DONGSHIN.Properties.Resources.ico_search;
            this.btn_search.Location = new System.Drawing.Point(510, 24);
            this.btn_search.LookAndFeel.SkinName = "VS2010";
            this.btn_search.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(90, 42);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "조회";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.Appearance.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbl_title.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_title.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lbl_title.Location = new System.Drawing.Point(13, 26);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(350, 34);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "금형코드 참조";
            // 
            // pan_sub
            // 
            this.pan_sub.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(191)))), ((int)(((byte)(186)))));
            this.pan_sub.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.pan_sub.Appearance.Options.UseBackColor = true;
            this.pan_sub.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pan_sub.Controls.Add(this.cbx_jejakGbn);
            this.pan_sub.Controls.Add(this.lbl_gbn);
            this.pan_sub.Controls.Add(this.txt_baljuBiz);
            this.pan_sub.Controls.Add(this.lbl_biz);
            this.pan_sub.Controls.Add(this.btn_refresh);
            this.pan_sub.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_sub.Location = new System.Drawing.Point(0, 85);
            this.pan_sub.Name = "pan_sub";
            this.pan_sub.Size = new System.Drawing.Size(830, 51);
            this.pan_sub.TabIndex = 15;
            // 
            // cbx_jejakGbn
            // 
            this.cbx_jejakGbn.EnterMoveNextControl = true;
            this.cbx_jejakGbn.Location = new System.Drawing.Point(464, 13);
            this.cbx_jejakGbn.Name = "cbx_jejakGbn";
            this.cbx_jejakGbn.Properties.Appearance.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_jejakGbn.Properties.Appearance.Options.UseFont = true;
            this.cbx_jejakGbn.Properties.AppearanceDropDown.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_jejakGbn.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbx_jejakGbn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_jejakGbn.Properties.Items.AddRange(new object[] {
            "자체제작",
            "외주"});
            this.cbx_jejakGbn.Size = new System.Drawing.Size(159, 26);
            this.cbx_jejakGbn.TabIndex = 13;
            this.cbx_jejakGbn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx_jejakGbn_KeyDown);
            // 
            // lbl_gbn
            // 
            this.lbl_gbn.Appearance.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_gbn.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_gbn.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_gbn.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_gbn.Location = new System.Drawing.Point(328, 17);
            this.lbl_gbn.Name = "lbl_gbn";
            this.lbl_gbn.Size = new System.Drawing.Size(130, 17);
            this.lbl_gbn.TabIndex = 12;
            this.lbl_gbn.Text = "제작구분";
            // 
            // txt_baljuBiz
            // 
            this.txt_baljuBiz.EnterMoveNextControl = true;
            this.txt_baljuBiz.Location = new System.Drawing.Point(149, 12);
            this.txt_baljuBiz.Name = "txt_baljuBiz";
            this.txt_baljuBiz.Properties.Appearance.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_baljuBiz.Properties.Appearance.Options.UseFont = true;
            this.txt_baljuBiz.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.txt_baljuBiz.Size = new System.Drawing.Size(163, 26);
            this.txt_baljuBiz.TabIndex = 11;
            // 
            // lbl_biz
            // 
            this.lbl_biz.Appearance.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_biz.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_biz.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_biz.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_biz.Location = new System.Drawing.Point(13, 17);
            this.lbl_biz.Name = "lbl_biz";
            this.lbl_biz.Size = new System.Drawing.Size(130, 17);
            this.lbl_biz.TabIndex = 10;
            this.lbl_biz.Text = "발주업체";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.Appearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_refresh.Appearance.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_refresh.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_refresh.Appearance.Options.UseBackColor = true;
            this.btn_refresh.Appearance.Options.UseBorderColor = true;
            this.btn_refresh.Appearance.Options.UseFont = true;
            this.btn_refresh.Appearance.Options.UseForeColor = true;
            this.btn_refresh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.Location = new System.Drawing.Point(648, 6);
            this.btn_refresh.LookAndFeel.SkinName = "VS2010";
            this.btn_refresh.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(100, 40);
            this.btn_refresh.TabIndex = 6;
            this.btn_refresh.Text = "지우기";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 136);
            this.gridControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(830, 414);
            this.gridControl1.TabIndex = 16;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.현재값검색ToolStripMenuItem,
            this.검색취소ToolStripMenuItem,
            this.toolStripSeparator1,
            this.조회ToolStripMenuItem,
            this.toolStripSeparator3,
            this.grid셋팅toolStripMenuItem1,
            this.grid다중검색ToolStripMenuItem,
            this.toolStripSeparator7,
            this.닫기ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 154);
            // 
            // 현재값검색ToolStripMenuItem
            // 
            this.현재값검색ToolStripMenuItem.Name = "현재값검색ToolStripMenuItem";
            this.현재값검색ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.현재값검색ToolStripMenuItem.Text = "현재값 검색";
            this.현재값검색ToolStripMenuItem.Click += new System.EventHandler(this.현재값검색ToolStripMenuItem_Click);
            // 
            // 검색취소ToolStripMenuItem
            // 
            this.검색취소ToolStripMenuItem.Name = "검색취소ToolStripMenuItem";
            this.검색취소ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.검색취소ToolStripMenuItem.Text = "검색 취소";
            this.검색취소ToolStripMenuItem.Click += new System.EventHandler(this.검색취소ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(120, 6);
            // 
            // 조회ToolStripMenuItem
            // 
            this.조회ToolStripMenuItem.Name = "조회ToolStripMenuItem";
            this.조회ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.조회ToolStripMenuItem.Text = "조회";
            this.조회ToolStripMenuItem.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(120, 6);
            // 
            // grid셋팅toolStripMenuItem1
            // 
            this.grid셋팅toolStripMenuItem1.Name = "grid셋팅toolStripMenuItem1";
            this.grid셋팅toolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.grid셋팅toolStripMenuItem1.Text = "Grid 셋팅";
            this.grid셋팅toolStripMenuItem1.Click += new System.EventHandler(this.grid셋팅toolStripMenuItem1_Click);
            // 
            // grid다중검색ToolStripMenuItem
            // 
            this.grid다중검색ToolStripMenuItem.Name = "grid다중검색ToolStripMenuItem";
            this.grid다중검색ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.grid다중검색ToolStripMenuItem.Text = "Grid 다중검색";
            this.grid다중검색ToolStripMenuItem.Click += new System.EventHandler(this.grid다중검색ToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(120, 6);
            // 
            // 닫기ToolStripMenuItem
            // 
            this.닫기ToolStripMenuItem.Name = "닫기ToolStripMenuItem";
            this.닫기ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.닫기ToolStripMenuItem.Text = "닫기";
            this.닫기ToolStripMenuItem.Click += new System.EventHandler(this.btn_close_Click);
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
            this.gridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
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
            this.gridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
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
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn8,
            this.gridColumn11,
            this.gridColumn7,
            this.gridColumn10,
            this.gridColumn21});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.gridColumn21;
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
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
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
            this.gridColumn3.Caption = "금형코드";
            this.gridColumn3.FieldName = "gh_id";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 100;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.gridColumn4.AppearanceHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn4.Caption = "모델명";
            this.gridColumn4.FieldName = "model";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 107;
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
            this.gridColumn5.FieldName = "gh_name";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 118;
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
            this.gridColumn6.FieldName = "gh_num";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 118;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceCell.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.gridColumn8.AppearanceCell.Options.UseFont = true;
            this.gridColumn8.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.AppearanceHeader.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.gridColumn8.AppearanceHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gridColumn8.AppearanceHeader.Options.UseFont = true;
            this.gridColumn8.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn8.Caption = "발주업체";
            this.gridColumn8.FieldName = "balju_name";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            this.gridColumn8.Width = 97;
            // 
            // gridColumn11
            // 
            this.gridColumn11.AppearanceCell.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.gridColumn11.AppearanceCell.Options.UseFont = true;
            this.gridColumn11.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn11.AppearanceHeader.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.gridColumn11.AppearanceHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gridColumn11.AppearanceHeader.Options.UseFont = true;
            this.gridColumn11.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn11.Caption = "제작구분";
            this.gridColumn11.FieldName = "jj_gbn";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 5;
            this.gridColumn11.Width = 86;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceCell.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.gridColumn7.AppearanceCell.Options.UseFont = true;
            this.gridColumn7.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.gridColumn7.AppearanceHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn7.Caption = "캐비티수";
            this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn7.FieldName = "cavity";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Width = 95;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceCell.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.gridColumn10.AppearanceCell.Options.UseFont = true;
            this.gridColumn10.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.AppearanceHeader.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.gridColumn10.AppearanceHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gridColumn10.AppearanceHeader.Options.UseFont = true;
            this.gridColumn10.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn10.Caption = "적재위치";
            this.gridColumn10.FieldName = "location";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 6;
            this.gridColumn10.Width = 118;
            // 
            // frm_moldRef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(830, 550);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.pan_sub);
            this.Controls.Add(this.pan_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_moldRef";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_moldRef";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_moldRef_FormClosing);
            this.Load += new System.EventHandler(this.frm_moldRef_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pan_top)).EndInit();
            this.pan_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pan_sub)).EndInit();
            this.pan_sub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbx_jejakGbn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_baljuBiz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pan_top;
        private DevExpress.XtraEditors.SimpleButton btn_close;
        private DevExpress.XtraEditors.SimpleButton btn_select;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private DevExpress.XtraEditors.LabelControl lbl_title;
        private DevExpress.XtraEditors.PanelControl pan_sub;
        private DevExpress.XtraEditors.ComboBoxEdit cbx_jejakGbn;
        private DevExpress.XtraEditors.LabelControl lbl_gbn;
        private DevExpress.XtraEditors.ButtonEdit txt_baljuBiz;
        private DevExpress.XtraEditors.LabelControl lbl_biz;
        private DevExpress.XtraEditors.SimpleButton btn_refresh;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 현재값검색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 검색취소ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem grid셋팅toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem grid다중검색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem 닫기ToolStripMenuItem;
    }
}