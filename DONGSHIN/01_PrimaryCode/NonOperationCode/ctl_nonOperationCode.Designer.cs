namespace DONGSHIN
{
    partial class ctl_nonOperationCode
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
            DevExpress.Utils.Animation.Transition transition1 = new DevExpress.Utils.Animation.Transition();
            DevExpress.Utils.Animation.FadeTransition fadeTransition1 = new DevExpress.Utils.Animation.FadeTransition();
            this.colUse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pan_container = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.현재값검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.검색취소ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.자료변환ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.group패널ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grid셋팅ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grid다중검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pan_sub = new DevExpress.XtraEditors.PanelControl();
            this.btn_refresh = new DevExpress.XtraEditors.SimpleButton();
            this.txt_why = new DevExpress.XtraEditors.TextEdit();
            this.lbl_name = new DevExpress.XtraEditors.LabelControl();
            this.pan_top = new DevExpress.XtraEditors.PanelControl();
            this.btn_dataconvert = new DevExpress.XtraEditors.SimpleButton();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_title = new DevExpress.XtraEditors.LabelControl();
            this.transitionManager = new DevExpress.Utils.Animation.TransitionManager();
            ((System.ComponentModel.ISupportInitialize)(this.pan_container)).BeginInit();
            this.pan_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pan_sub)).BeginInit();
            this.pan_sub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_why.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pan_top)).BeginInit();
            this.pan_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // colUse
            // 
            this.colUse.AppearanceCell.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.colUse.AppearanceCell.Options.UseFont = true;
            this.colUse.AppearanceCell.Options.UseTextOptions = true;
            this.colUse.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUse.AppearanceHeader.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.colUse.AppearanceHeader.Options.UseFont = true;
            this.colUse.Caption = "사용";
            this.colUse.FieldName = "use_chk";
            this.colUse.Name = "colUse";
            this.colUse.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colUse.Visible = true;
            this.colUse.VisibleIndex = 4;
            this.colUse.Width = 200;
            // 
            // pan_container
            // 
            this.pan_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pan_container.Controls.Add(this.gridControl1);
            this.pan_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_container.Location = new System.Drawing.Point(0, 136);
            this.pan_container.Name = "pan_container";
            this.pan_container.Size = new System.Drawing.Size(1920, 835);
            this.pan_container.TabIndex = 12;
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1920, 835);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.현재값검색ToolStripMenuItem,
            this.검색취소ToolStripMenuItem,
            this.toolStripSeparator1,
            this.조회ToolStripMenuItem,
            this.toolStripSeparator3,
            this.추가ToolStripMenuItem,
            this.수정ToolStripMenuItem,
            this.삭제ToolStripMenuItem,
            this.toolStripSeparator4,
            this.자료변환ToolStripMenuItem,
            this.toolStripSeparator6,
            this.group패널ToolStripMenuItem,
            this.grid셋팅ToolStripMenuItem,
            this.grid다중검색ToolStripMenuItem,
            this.toolStripSeparator7,
            this.닫기ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 276);
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
            // 추가ToolStripMenuItem
            // 
            this.추가ToolStripMenuItem.Name = "추가ToolStripMenuItem";
            this.추가ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.추가ToolStripMenuItem.Text = "추가";
            this.추가ToolStripMenuItem.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // 수정ToolStripMenuItem
            // 
            this.수정ToolStripMenuItem.Name = "수정ToolStripMenuItem";
            this.수정ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.수정ToolStripMenuItem.Text = "수정";
            this.수정ToolStripMenuItem.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // 삭제ToolStripMenuItem
            // 
            this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.삭제ToolStripMenuItem.Text = "삭제";
            this.삭제ToolStripMenuItem.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(120, 6);
            // 
            // 자료변환ToolStripMenuItem
            // 
            this.자료변환ToolStripMenuItem.Name = "자료변환ToolStripMenuItem";
            this.자료변환ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.자료변환ToolStripMenuItem.Text = "자료변환";
            this.자료변환ToolStripMenuItem.Click += new System.EventHandler(this.btn_dataconvert_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(120, 6);
            // 
            // group패널ToolStripMenuItem
            // 
            this.group패널ToolStripMenuItem.Name = "group패널ToolStripMenuItem";
            this.group패널ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.group패널ToolStripMenuItem.Text = "그룹화";
            this.group패널ToolStripMenuItem.Click += new System.EventHandler(this.group패널ToolStripMenuItem_Click);
            // 
            // grid셋팅ToolStripMenuItem
            // 
            this.grid셋팅ToolStripMenuItem.Name = "grid셋팅ToolStripMenuItem";
            this.grid셋팅ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.grid셋팅ToolStripMenuItem.Text = "Grid 셋팅";
            this.grid셋팅ToolStripMenuItem.Click += new System.EventHandler(this.grid셋팅ToolStripMenuItem_Click);
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
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold);
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
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
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
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn5,
            this.colUse});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colUse;
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
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.BorderColor = System.Drawing.Color.Transparent;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.gridColumn1.AppearanceHeader.Options.UseBorderColor = true;
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "구분";
            this.gridColumn1.FieldName = "bgd_gbn";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 200;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.Caption = "코드";
            this.gridColumn2.FieldName = "bgd_id";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 200;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn4.Caption = "비가동사유";
            this.gridColumn4.FieldName = "bgd_why";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 800;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn5.Caption = "기본시간";
            this.gridColumn5.FieldName = "bgd_t";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 200;
            // 
            // pan_sub
            // 
            this.pan_sub.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(191)))), ((int)(((byte)(186)))));
            this.pan_sub.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.pan_sub.Appearance.Options.UseBackColor = true;
            this.pan_sub.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pan_sub.Controls.Add(this.btn_refresh);
            this.pan_sub.Controls.Add(this.txt_why);
            this.pan_sub.Controls.Add(this.lbl_name);
            this.pan_sub.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_sub.Location = new System.Drawing.Point(0, 85);
            this.pan_sub.Name = "pan_sub";
            this.pan_sub.Size = new System.Drawing.Size(1920, 51);
            this.pan_sub.TabIndex = 11;
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
            this.btn_refresh.Image = global::DONGSHIN.Properties.Resources.ico_refresh;
            this.btn_refresh.Location = new System.Drawing.Point(361, 5);
            this.btn_refresh.LookAndFeel.SkinName = "VS2010";
            this.btn_refresh.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(100, 40);
            this.btn_refresh.TabIndex = 6;
            this.btn_refresh.Text = "지우기";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // txt_why
            // 
            this.txt_why.Location = new System.Drawing.Point(152, 14);
            this.txt_why.Name = "txt_why";
            this.txt_why.Properties.Appearance.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_why.Properties.Appearance.Options.UseFont = true;
            this.txt_why.Size = new System.Drawing.Size(200, 26);
            this.txt_why.TabIndex = 1;
            this.txt_why.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_why_KeyDown);
            // 
            // lbl_name
            // 
            this.lbl_name.Appearance.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_name.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_name.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_name.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_name.Location = new System.Drawing.Point(13, 18);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(133, 19);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "비가동 사유";
            // 
            // pan_top
            // 
            this.pan_top.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(126)))), ((int)(((byte)(177)))));
            this.pan_top.Appearance.Options.UseBackColor = true;
            this.pan_top.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pan_top.Controls.Add(this.btn_dataconvert);
            this.pan_top.Controls.Add(this.btn_close);
            this.pan_top.Controls.Add(this.btn_delete);
            this.pan_top.Controls.Add(this.btn_update);
            this.pan_top.Controls.Add(this.btn_add);
            this.pan_top.Controls.Add(this.btn_search);
            this.pan_top.Controls.Add(this.lbl_title);
            this.pan_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_top.Location = new System.Drawing.Point(0, 0);
            this.pan_top.Name = "pan_top";
            this.pan_top.Size = new System.Drawing.Size(1920, 85);
            this.pan_top.TabIndex = 10;
            // 
            // btn_dataconvert
            // 
            this.btn_dataconvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dataconvert.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_dataconvert.Appearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_dataconvert.Appearance.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_dataconvert.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_dataconvert.Appearance.Options.UseBackColor = true;
            this.btn_dataconvert.Appearance.Options.UseBorderColor = true;
            this.btn_dataconvert.Appearance.Options.UseFont = true;
            this.btn_dataconvert.Appearance.Options.UseForeColor = true;
            this.btn_dataconvert.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_dataconvert.Image = global::DONGSHIN.Properties.Resources.ico_dataconvert;
            this.btn_dataconvert.Location = new System.Drawing.Point(1674, 23);
            this.btn_dataconvert.LookAndFeel.SkinName = "VS2010";
            this.btn_dataconvert.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_dataconvert.Name = "btn_dataconvert";
            this.btn_dataconvert.Size = new System.Drawing.Size(120, 42);
            this.btn_dataconvert.TabIndex = 9;
            this.btn_dataconvert.Text = "자료변환";
            this.btn_dataconvert.Click += new System.EventHandler(this.btn_dataconvert_Click);
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
            this.btn_close.Location = new System.Drawing.Point(1807, 23);
            this.btn_close.LookAndFeel.SkinName = "VS2010";
            this.btn_close.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(100, 42);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "닫기";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.Appearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_delete.Appearance.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_delete.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_delete.Appearance.Options.UseBackColor = true;
            this.btn_delete.Appearance.Options.UseBorderColor = true;
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.Appearance.Options.UseForeColor = true;
            this.btn_delete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_delete.Image = global::DONGSHIN.Properties.Resources.ico_delete;
            this.btn_delete.Location = new System.Drawing.Point(1571, 23);
            this.btn_delete.LookAndFeel.SkinName = "VS2010";
            this.btn_delete.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(90, 42);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "삭제";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.Appearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_update.Appearance.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_update.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_update.Appearance.Options.UseBackColor = true;
            this.btn_update.Appearance.Options.UseBorderColor = true;
            this.btn_update.Appearance.Options.UseFont = true;
            this.btn_update.Appearance.Options.UseForeColor = true;
            this.btn_update.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_update.Image = global::DONGSHIN.Properties.Resources.ico_update;
            this.btn_update.Location = new System.Drawing.Point(1468, 23);
            this.btn_update.LookAndFeel.SkinName = "VS2010";
            this.btn_update.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(90, 42);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "수정";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.Appearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_add.Appearance.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_add.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_add.Appearance.Options.UseBackColor = true;
            this.btn_add.Appearance.Options.UseBorderColor = true;
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.Appearance.Options.UseForeColor = true;
            this.btn_add.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_add.Image = global::DONGSHIN.Properties.Resources.ico_add;
            this.btn_add.Location = new System.Drawing.Point(1365, 23);
            this.btn_add.LookAndFeel.SkinName = "VS2010";
            this.btn_add.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(90, 42);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "추가";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.Appearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_search.Appearance.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_search.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_search.Appearance.Options.UseBackColor = true;
            this.btn_search.Appearance.Options.UseBorderColor = true;
            this.btn_search.Appearance.Options.UseFont = true;
            this.btn_search.Appearance.Options.UseForeColor = true;
            this.btn_search.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_search.Image = global::DONGSHIN.Properties.Resources.ico_search;
            this.btn_search.Location = new System.Drawing.Point(1262, 23);
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
            this.lbl_title.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_title.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lbl_title.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_title.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lbl_title.Location = new System.Drawing.Point(13, 25);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(300, 34);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "비가동코드";
            // 
            // transitionManager
            // 
            transition1.Control = this.pan_container;
            transition1.LineWaitingIndicatorProperties.AnimationElementCount = 5;
            transition1.LineWaitingIndicatorProperties.Caption = "";
            transition1.LineWaitingIndicatorProperties.Description = "";
            transition1.RingWaitingIndicatorProperties.AnimationElementCount = 5;
            transition1.RingWaitingIndicatorProperties.Caption = "";
            transition1.RingWaitingIndicatorProperties.Description = "";
            transition1.TransitionType = fadeTransition1;
            transition1.WaitingIndicatorProperties.Caption = "";
            transition1.WaitingIndicatorProperties.Description = "";
            this.transitionManager.Transitions.Add(transition1);
            // 
            // ctl_nonOperationCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.pan_container);
            this.Controls.Add(this.pan_sub);
            this.Controls.Add(this.pan_top);
            this.Name = "ctl_nonOperationCode";
            this.Size = new System.Drawing.Size(1920, 971);
            this.Load += new System.EventHandler(this.ctl_nonOperationCode_Load);
            this.VisibleChanged += new System.EventHandler(this.ctl_nonOperationCode_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pan_container)).EndInit();
            this.pan_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pan_sub)).EndInit();
            this.pan_sub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_why.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pan_top)).EndInit();
            this.pan_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pan_sub;
        private DevExpress.XtraEditors.SimpleButton btn_refresh;
        private DevExpress.XtraEditors.TextEdit txt_why;
        private DevExpress.XtraEditors.LabelControl lbl_name;
        private DevExpress.XtraEditors.PanelControl pan_top;
        private DevExpress.XtraEditors.SimpleButton btn_dataconvert;
        private DevExpress.XtraEditors.SimpleButton btn_close;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private DevExpress.XtraEditors.LabelControl lbl_title;
        private DevExpress.XtraEditors.PanelControl pan_container;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn colUse;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 현재값검색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 검색취소ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 자료변환ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem group패널ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grid셋팅ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grid다중검색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem 닫기ToolStripMenuItem;
        private DevExpress.Utils.Animation.TransitionManager transitionManager;
    }
}
