﻿namespace DONGSHIN
{
    partial class ctl_workOrder
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
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pan_container = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.현재값검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.검색취소ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.현컬럼좌측고정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.현컬럼우측고정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.고정컬럼해제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.복사ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.인쇄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.자료변환ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.그룹화ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grid셋팅ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grid다중검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pan_sub = new DevExpress.XtraEditors.PanelControl();
            this.btn_refresh = new DevExpress.XtraEditors.SimpleButton();
            this.txt_prodid = new DevExpress.XtraEditors.ButtonEdit();
            this.lbl_prodid = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_date = new DevExpress.XtraEditors.LabelControl();
            this.txt_startdate = new DevExpress.XtraEditors.DateEdit();
            this.txt_enddate = new DevExpress.XtraEditors.DateEdit();
            this.pan_top = new DevExpress.XtraEditors.PanelControl();
            this.btn_copy = new DevExpress.XtraEditors.SimpleButton();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.btn_dataconvert = new DevExpress.XtraEditors.SimpleButton();
            this.btn_print = new DevExpress.XtraEditors.SimpleButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.txt_prodid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_startdate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_startdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_enddate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_enddate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pan_top)).BeginInit();
            this.pan_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridColumn21
            // 
            this.gridColumn21.AppearanceCell.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.gridColumn21.AppearanceCell.Options.UseFont = true;
            this.gridColumn21.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn21.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn21.Caption = "품명";
            this.gridColumn21.FieldName = "jp_name";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 10;
            this.gridColumn21.Width = 159;
            // 
            // pan_container
            // 
            this.pan_container.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pan_container.Controls.Add(this.gridControl1);
            this.pan_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_container.Location = new System.Drawing.Point(0, 136);
            this.pan_container.Name = "pan_container";
            this.pan_container.Size = new System.Drawing.Size(1920, 835);
            this.pan_container.TabIndex = 5;
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
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.현재값검색ToolStripMenuItem,
            this.검색취소ToolStripMenuItem,
            this.toolStripSeparator1,
            this.현컬럼좌측고정ToolStripMenuItem,
            this.현컬럼우측고정ToolStripMenuItem,
            this.고정컬럼해제ToolStripMenuItem,
            this.toolStripSeparator2,
            this.조회ToolStripMenuItem,
            this.toolStripSeparator3,
            this.추가ToolStripMenuItem,
            this.복사ToolStripMenuItem,
            this.수정ToolStripMenuItem,
            this.삭제ToolStripMenuItem,
            this.toolStripSeparator4,
            this.인쇄ToolStripMenuItem,
            this.toolStripSeparator5,
            this.자료변환ToolStripMenuItem,
            this.toolStripSeparator6,
            this.그룹화ToolStripMenuItem,
            this.grid셋팅ToolStripMenuItem,
            this.grid다중검색ToolStripMenuItem,
            this.toolStripSeparator7,
            this.닫기ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 398);
            // 
            // 현재값검색ToolStripMenuItem
            // 
            this.현재값검색ToolStripMenuItem.Name = "현재값검색ToolStripMenuItem";
            this.현재값검색ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.현재값검색ToolStripMenuItem.Text = "현재값 검색";
            this.현재값검색ToolStripMenuItem.Click += new System.EventHandler(this.현재값검색ToolStripMenuItem_Click);
            // 
            // 검색취소ToolStripMenuItem
            // 
            this.검색취소ToolStripMenuItem.Name = "검색취소ToolStripMenuItem";
            this.검색취소ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.검색취소ToolStripMenuItem.Text = "검색 취소";
            this.검색취소ToolStripMenuItem.Click += new System.EventHandler(this.검색취소ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // 현컬럼좌측고정ToolStripMenuItem
            // 
            this.현컬럼좌측고정ToolStripMenuItem.Name = "현컬럼좌측고정ToolStripMenuItem";
            this.현컬럼좌측고정ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.현컬럼좌측고정ToolStripMenuItem.Text = "현컬럼 좌측 고정";
            this.현컬럼좌측고정ToolStripMenuItem.Click += new System.EventHandler(this.현컬럼좌측고정ToolStripMenuItem_Click);
            // 
            // 현컬럼우측고정ToolStripMenuItem
            // 
            this.현컬럼우측고정ToolStripMenuItem.Name = "현컬럼우측고정ToolStripMenuItem";
            this.현컬럼우측고정ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.현컬럼우측고정ToolStripMenuItem.Text = "현컬럼 우측 고정";
            this.현컬럼우측고정ToolStripMenuItem.Click += new System.EventHandler(this.현컬럼우측고정ToolStripMenuItem_Click);
            // 
            // 고정컬럼해제ToolStripMenuItem
            // 
            this.고정컬럼해제ToolStripMenuItem.Name = "고정컬럼해제ToolStripMenuItem";
            this.고정컬럼해제ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.고정컬럼해제ToolStripMenuItem.Text = "고정컬럼 해제";
            this.고정컬럼해제ToolStripMenuItem.Click += new System.EventHandler(this.고정컬럼해제ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(138, 6);
            // 
            // 조회ToolStripMenuItem
            // 
            this.조회ToolStripMenuItem.Name = "조회ToolStripMenuItem";
            this.조회ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.조회ToolStripMenuItem.Text = "조회";
            this.조회ToolStripMenuItem.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(138, 6);
            // 
            // 추가ToolStripMenuItem
            // 
            this.추가ToolStripMenuItem.Name = "추가ToolStripMenuItem";
            this.추가ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.추가ToolStripMenuItem.Text = "추가";
            this.추가ToolStripMenuItem.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // 복사ToolStripMenuItem
            // 
            this.복사ToolStripMenuItem.Name = "복사ToolStripMenuItem";
            this.복사ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.복사ToolStripMenuItem.Text = "복사";
            // 
            // 수정ToolStripMenuItem
            // 
            this.수정ToolStripMenuItem.Name = "수정ToolStripMenuItem";
            this.수정ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.수정ToolStripMenuItem.Text = "수정";
            this.수정ToolStripMenuItem.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // 삭제ToolStripMenuItem
            // 
            this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.삭제ToolStripMenuItem.Text = "삭제";
            this.삭제ToolStripMenuItem.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(138, 6);
            // 
            // 인쇄ToolStripMenuItem
            // 
            this.인쇄ToolStripMenuItem.Name = "인쇄ToolStripMenuItem";
            this.인쇄ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.인쇄ToolStripMenuItem.Text = "인쇄";
            this.인쇄ToolStripMenuItem.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(138, 6);
            // 
            // 자료변환ToolStripMenuItem
            // 
            this.자료변환ToolStripMenuItem.Name = "자료변환ToolStripMenuItem";
            this.자료변환ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.자료변환ToolStripMenuItem.Text = "자료변환";
            this.자료변환ToolStripMenuItem.Click += new System.EventHandler(this.btn_dataconvert_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(138, 6);
            // 
            // 그룹화ToolStripMenuItem
            // 
            this.그룹화ToolStripMenuItem.Name = "그룹화ToolStripMenuItem";
            this.그룹화ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.그룹화ToolStripMenuItem.Text = "그룹화";
            this.그룹화ToolStripMenuItem.Click += new System.EventHandler(this.그룹화ToolStripMenuItem_Click);
            // 
            // grid셋팅ToolStripMenuItem
            // 
            this.grid셋팅ToolStripMenuItem.Name = "grid셋팅ToolStripMenuItem";
            this.grid셋팅ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.grid셋팅ToolStripMenuItem.Text = "Grid 셋팅";
            this.grid셋팅ToolStripMenuItem.Click += new System.EventHandler(this.grid셋팅ToolStripMenuItem_Click);
            // 
            // grid다중검색ToolStripMenuItem
            // 
            this.grid다중검색ToolStripMenuItem.Name = "grid다중검색ToolStripMenuItem";
            this.grid다중검색ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.grid다중검색ToolStripMenuItem.Text = "Grid 다중검색";
            this.grid다중검색ToolStripMenuItem.Click += new System.EventHandler(this.grid다중검색ToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(138, 6);
            // 
            // 닫기ToolStripMenuItem
            // 
            this.닫기ToolStripMenuItem.Name = "닫기ToolStripMenuItem";
            this.닫기ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
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
            this.gridColumn4,
            this.gridColumn9,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn12,
            this.gridColumn8,
            this.gridColumn11,
            this.gridColumn10,
            this.gridColumn21,
            this.gridColumn15,
            this.gridColumn14,
            this.gridColumn13,
            this.gridColumn1});
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
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "등록일자";
            this.gridColumn2.FieldName = "jisi_date";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 127;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "생산업체";
            this.gridColumn3.FieldName = "ec_name";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 170;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "시작/종료";
            this.gridColumn4.FieldName = "jisi_gbn";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 92;
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.Caption = "작업시작여부";
            this.gridColumn9.FieldName = "is_work_started";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 3;
            this.gridColumn9.Width = 113;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.gridColumn5.AppearanceCell.Options.UseFont = true;
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "작성자";
            this.gridColumn5.FieldName = "sw_name";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 103;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.gridColumn6.AppearanceCell.Options.UseFont = true;
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "부서";
            this.gridColumn6.FieldName = "bs_name";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 110;
            // 
            // gridColumn12
            // 
            this.gridColumn12.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn12.Caption = "계획시간";
            this.gridColumn12.FieldName = "plan_t";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 6;
            this.gridColumn12.Width = 127;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceCell.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.gridColumn8.AppearanceCell.Options.UseFont = true;
            this.gridColumn8.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.Caption = "공정구분";
            this.gridColumn8.FieldName = "gj_gbn";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 110;
            // 
            // gridColumn11
            // 
            this.gridColumn11.AppearanceCell.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.gridColumn11.AppearanceCell.Options.UseFont = true;
            this.gridColumn11.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn11.Caption = "설비이름";
            this.gridColumn11.FieldName = "MACHINE_NAME";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 8;
            this.gridColumn11.Width = 184;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.Caption = "금형번호";
            this.gridColumn10.FieldName = "gh_id";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 9;
            this.gridColumn10.Width = 129;
            // 
            // gridColumn15
            // 
            this.gridColumn15.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn15.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn15.Caption = "수지코드";
            this.gridColumn15.FieldName = "sj_id";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 11;
            this.gridColumn15.Width = 126;
            // 
            // gridColumn14
            // 
            this.gridColumn14.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn14.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn14.Caption = "수지이름";
            this.gridColumn14.FieldName = "sj_name";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 12;
            this.gridColumn14.Width = 119;
            // 
            // gridColumn13
            // 
            this.gridColumn13.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn13.Caption = "목표수량";
            this.gridColumn13.DisplayFormat.FormatString = "#,##0 EA";
            this.gridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn13.FieldName = "qt_plan";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 13;
            this.gridColumn13.Width = 108;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "작업지시id";
            this.gridColumn1.FieldName = "jisi_id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // pan_sub
            // 
            this.pan_sub.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(191)))), ((int)(((byte)(186)))));
            this.pan_sub.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.pan_sub.Appearance.Options.UseBackColor = true;
            this.pan_sub.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pan_sub.Controls.Add(this.btn_refresh);
            this.pan_sub.Controls.Add(this.txt_prodid);
            this.pan_sub.Controls.Add(this.lbl_prodid);
            this.pan_sub.Controls.Add(this.labelControl1);
            this.pan_sub.Controls.Add(this.lbl_date);
            this.pan_sub.Controls.Add(this.txt_startdate);
            this.pan_sub.Controls.Add(this.txt_enddate);
            this.pan_sub.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_sub.Location = new System.Drawing.Point(0, 85);
            this.pan_sub.Name = "pan_sub";
            this.pan_sub.Size = new System.Drawing.Size(1920, 51);
            this.pan_sub.TabIndex = 4;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.Appearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_refresh.Appearance.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_refresh.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Appearance.Options.UseBackColor = true;
            this.btn_refresh.Appearance.Options.UseBorderColor = true;
            this.btn_refresh.Appearance.Options.UseFont = true;
            this.btn_refresh.Appearance.Options.UseForeColor = true;
            this.btn_refresh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_refresh.Image = global::DONGSHIN.Properties.Resources.ico_refresh;
            this.btn_refresh.Location = new System.Drawing.Point(846, 6);
            this.btn_refresh.LookAndFeel.SkinName = "VS2010";
            this.btn_refresh.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(100, 40);
            this.btn_refresh.TabIndex = 6;
            this.btn_refresh.Text = "지우기";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // txt_prodid
            // 
            this.txt_prodid.Location = new System.Drawing.Point(616, 16);
            this.txt_prodid.Name = "txt_prodid";
            this.txt_prodid.Properties.Appearance.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prodid.Properties.Appearance.Options.UseFont = true;
            this.txt_prodid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.txt_prodid.Size = new System.Drawing.Size(170, 24);
            this.txt_prodid.TabIndex = 5;
            this.txt_prodid.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txt_prodid_ButtonClick);
            this.txt_prodid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_name_KeyDown);
            // 
            // lbl_prodid
            // 
            this.lbl_prodid.Appearance.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prodid.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbl_prodid.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_prodid.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_prodid.Location = new System.Drawing.Point(460, 19);
            this.lbl_prodid.Name = "lbl_prodid";
            this.lbl_prodid.Size = new System.Drawing.Size(150, 17);
            this.lbl_prodid.TabIndex = 4;
            this.lbl_prodid.Text = "제품코드";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(279, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(10, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "~";
            // 
            // lbl_date
            // 
            this.lbl_date.Appearance.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbl_date.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_date.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_date.Location = new System.Drawing.Point(16, 19);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(120, 17);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "의뢰일자";
            // 
            // txt_startdate
            // 
            this.txt_startdate.EditValue = null;
            this.txt_startdate.Location = new System.Drawing.Point(142, 16);
            this.txt_startdate.Name = "txt_startdate";
            this.txt_startdate.Properties.Appearance.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_startdate.Properties.Appearance.Options.UseFont = true;
            this.txt_startdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_startdate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_startdate.Size = new System.Drawing.Size(130, 24);
            this.txt_startdate.TabIndex = 1;
            this.txt_startdate.DateTimeChanged += new System.EventHandler(this.DateTimeChanged);
            // 
            // txt_enddate
            // 
            this.txt_enddate.EditValue = null;
            this.txt_enddate.Location = new System.Drawing.Point(295, 16);
            this.txt_enddate.Name = "txt_enddate";
            this.txt_enddate.Properties.Appearance.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_enddate.Properties.Appearance.Options.UseFont = true;
            this.txt_enddate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_enddate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_enddate.Properties.DisplayFormat.FormatString = "";
            this.txt_enddate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_enddate.Properties.EditFormat.FormatString = "";
            this.txt_enddate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_enddate.Properties.Mask.EditMask = "";
            this.txt_enddate.Size = new System.Drawing.Size(130, 24);
            this.txt_enddate.TabIndex = 3;
            this.txt_enddate.DateTimeChanged += new System.EventHandler(this.DateTimeChanged);
            // 
            // pan_top
            // 
            this.pan_top.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(126)))), ((int)(((byte)(177)))));
            this.pan_top.Appearance.Options.UseBackColor = true;
            this.pan_top.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pan_top.Controls.Add(this.btn_copy);
            this.pan_top.Controls.Add(this.btn_close);
            this.pan_top.Controls.Add(this.btn_dataconvert);
            this.pan_top.Controls.Add(this.btn_print);
            this.pan_top.Controls.Add(this.btn_delete);
            this.pan_top.Controls.Add(this.btn_update);
            this.pan_top.Controls.Add(this.btn_add);
            this.pan_top.Controls.Add(this.btn_search);
            this.pan_top.Controls.Add(this.lbl_title);
            this.pan_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_top.Location = new System.Drawing.Point(0, 0);
            this.pan_top.Name = "pan_top";
            this.pan_top.Size = new System.Drawing.Size(1920, 85);
            this.pan_top.TabIndex = 3;
            // 
            // btn_copy
            // 
            this.btn_copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_copy.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_copy.Appearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_copy.Appearance.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_copy.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_copy.Appearance.Options.UseBackColor = true;
            this.btn_copy.Appearance.Options.UseBorderColor = true;
            this.btn_copy.Appearance.Options.UseFont = true;
            this.btn_copy.Appearance.Options.UseForeColor = true;
            this.btn_copy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_copy.Image = global::DONGSHIN.Properties.Resources.ico_add;
            this.btn_copy.Location = new System.Drawing.Point(1351, 22);
            this.btn_copy.LookAndFeel.SkinName = "VS2010";
            this.btn_copy.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(90, 42);
            this.btn_copy.TabIndex = 8;
            this.btn_copy.Text = "복사";
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Appearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_close.Appearance.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_close.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_close.Appearance.Options.UseBackColor = true;
            this.btn_close.Appearance.Options.UseBorderColor = true;
            this.btn_close.Appearance.Options.UseFont = true;
            this.btn_close.Appearance.Options.UseForeColor = true;
            this.btn_close.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_close.Image = global::DONGSHIN.Properties.Resources.ico_close;
            this.btn_close.Location = new System.Drawing.Point(1801, 22);
            this.btn_close.LookAndFeel.SkinName = "VS2010";
            this.btn_close.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(100, 42);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "닫기";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_dataconvert
            // 
            this.btn_dataconvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dataconvert.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_dataconvert.Appearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_dataconvert.Appearance.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_dataconvert.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_dataconvert.Appearance.Options.UseBackColor = true;
            this.btn_dataconvert.Appearance.Options.UseBorderColor = true;
            this.btn_dataconvert.Appearance.Options.UseFont = true;
            this.btn_dataconvert.Appearance.Options.UseForeColor = true;
            this.btn_dataconvert.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_dataconvert.Image = global::DONGSHIN.Properties.Resources.ico_dataconvert;
            this.btn_dataconvert.Location = new System.Drawing.Point(1666, 22);
            this.btn_dataconvert.LookAndFeel.SkinName = "VS2010";
            this.btn_dataconvert.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_dataconvert.Name = "btn_dataconvert";
            this.btn_dataconvert.Size = new System.Drawing.Size(120, 42);
            this.btn_dataconvert.TabIndex = 6;
            this.btn_dataconvert.Text = "자료변환";
            this.btn_dataconvert.Click += new System.EventHandler(this.btn_dataconvert_Click);
            // 
            // btn_print
            // 
            this.btn_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_print.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_print.Appearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_print.Appearance.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_print.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_print.Appearance.Options.UseBackColor = true;
            this.btn_print.Appearance.Options.UseBorderColor = true;
            this.btn_print.Appearance.Options.UseFont = true;
            this.btn_print.Appearance.Options.UseForeColor = true;
            this.btn_print.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_print.Image = global::DONGSHIN.Properties.Resources.ico_print;
            this.btn_print.Location = new System.Drawing.Point(1036, 22);
            this.btn_print.LookAndFeel.SkinName = "VS2010";
            this.btn_print.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(90, 42);
            this.btn_print.TabIndex = 5;
            this.btn_print.Text = "인쇄";
            this.btn_print.Visible = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.Appearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_delete.Appearance.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_delete.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Appearance.Options.UseBackColor = true;
            this.btn_delete.Appearance.Options.UseBorderColor = true;
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.Appearance.Options.UseForeColor = true;
            this.btn_delete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_delete.Image = global::DONGSHIN.Properties.Resources.ico_delete;
            this.btn_delete.Location = new System.Drawing.Point(1561, 22);
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
            this.btn_update.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_update.Appearance.Options.UseBackColor = true;
            this.btn_update.Appearance.Options.UseBorderColor = true;
            this.btn_update.Appearance.Options.UseFont = true;
            this.btn_update.Appearance.Options.UseForeColor = true;
            this.btn_update.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_update.Image = global::DONGSHIN.Properties.Resources.ico_update;
            this.btn_update.Location = new System.Drawing.Point(1456, 22);
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
            this.btn_add.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_add.Appearance.Options.UseBackColor = true;
            this.btn_add.Appearance.Options.UseBorderColor = true;
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.Appearance.Options.UseForeColor = true;
            this.btn_add.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_add.Image = global::DONGSHIN.Properties.Resources.ico_add;
            this.btn_add.Location = new System.Drawing.Point(1246, 22);
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
            this.btn_search.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_search.Appearance.Options.UseBackColor = true;
            this.btn_search.Appearance.Options.UseBorderColor = true;
            this.btn_search.Appearance.Options.UseFont = true;
            this.btn_search.Appearance.Options.UseForeColor = true;
            this.btn_search.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_search.Image = global::DONGSHIN.Properties.Resources.ico_search;
            this.btn_search.Location = new System.Drawing.Point(1141, 22);
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
            this.lbl_title.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_title.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lbl_title.Location = new System.Drawing.Point(13, 24);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(300, 34);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "작업지시";
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
            // ctl_workOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.pan_container);
            this.Controls.Add(this.pan_sub);
            this.Controls.Add(this.pan_top);
            this.Name = "ctl_workOrder";
            this.Size = new System.Drawing.Size(1920, 971);
            this.Load += new System.EventHandler(this.ctl_workOrder_Load);
            this.VisibleChanged += new System.EventHandler(this.ctl_workOrder_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pan_container)).EndInit();
            this.pan_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pan_sub)).EndInit();
            this.pan_sub.ResumeLayout(false);
            this.pan_sub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_prodid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_startdate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_startdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_enddate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_enddate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pan_top)).EndInit();
            this.pan_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pan_sub;
        private DevExpress.XtraEditors.SimpleButton btn_refresh;
        private DevExpress.XtraEditors.ButtonEdit txt_prodid;
        private DevExpress.XtraEditors.LabelControl lbl_prodid;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lbl_date;
        private DevExpress.XtraEditors.DateEdit txt_startdate;
        private DevExpress.XtraEditors.DateEdit txt_enddate;
        private DevExpress.XtraEditors.PanelControl pan_top;
        private DevExpress.XtraEditors.SimpleButton btn_close;
        private DevExpress.XtraEditors.SimpleButton btn_dataconvert;
        private DevExpress.XtraEditors.SimpleButton btn_print;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private DevExpress.XtraEditors.LabelControl lbl_title;
        private DevExpress.XtraEditors.PanelControl pan_container;
        private DevExpress.Utils.Animation.TransitionManager transitionManager;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 현재값검색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 검색취소ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 현컬럼좌측고정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 현컬럼우측고정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 고정컬럼해제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 인쇄ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 자료변환ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem 그룹화ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grid셋팅ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grid다중검색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem 닫기ToolStripMenuItem;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraEditors.SimpleButton btn_copy;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private System.Windows.Forms.ToolStripMenuItem 복사ToolStripMenuItem;
    }
}
