namespace ztdTool.UI
{
    partial class FrmColumn
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.COLUMN_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DATA_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DATA_LENGTH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NULLABLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COMMENTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.INDEX_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.INDEX_COLUMN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TRIGGER_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(576, 452);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(570, 423);
            this.xtraTabPage1.Text = "列";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(570, 423);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.COLUMN_NAME,
            this.DATA_TYPE,
            this.DATA_LENGTH,
            this.NULLABLE,
            this.COMMENTS});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.CopyToClipboardWithColumnHeaders = false;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // COLUMN_NAME
            // 
            this.COLUMN_NAME.Caption = "列名";
            this.COLUMN_NAME.FieldName = "COLUMN_NAME";
            this.COLUMN_NAME.Name = "COLUMN_NAME";
            this.COLUMN_NAME.Visible = true;
            this.COLUMN_NAME.VisibleIndex = 0;
            this.COLUMN_NAME.Width = 139;
            // 
            // DATA_TYPE
            // 
            this.DATA_TYPE.Caption = "数据类型";
            this.DATA_TYPE.FieldName = "DATA_TYPE";
            this.DATA_TYPE.Name = "DATA_TYPE";
            this.DATA_TYPE.Visible = true;
            this.DATA_TYPE.VisibleIndex = 1;
            this.DATA_TYPE.Width = 80;
            // 
            // DATA_LENGTH
            // 
            this.DATA_LENGTH.Caption = "字符长度";
            this.DATA_LENGTH.FieldName = "DATA_LENGTH";
            this.DATA_LENGTH.Name = "DATA_LENGTH";
            this.DATA_LENGTH.Visible = true;
            this.DATA_LENGTH.VisibleIndex = 2;
            this.DATA_LENGTH.Width = 66;
            // 
            // NULLABLE
            // 
            this.NULLABLE.Caption = "是否为空";
            this.NULLABLE.FieldName = "NULLABLE";
            this.NULLABLE.Name = "NULLABLE";
            this.NULLABLE.Visible = true;
            this.NULLABLE.VisibleIndex = 3;
            this.NULLABLE.Width = 84;
            // 
            // COMMENTS
            // 
            this.COMMENTS.Caption = "描述";
            this.COMMENTS.FieldName = "COMMENTS";
            this.COMMENTS.Name = "COMMENTS";
            this.COMMENTS.Visible = true;
            this.COMMENTS.VisibleIndex = 4;
            this.COMMENTS.Width = 255;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridControl2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(570, 423);
            this.xtraTabPage2.Text = "索引";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView3;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(570, 423);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView3.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.INDEX_NAME,
            this.INDEX_COLUMN});
            this.gridView3.GridControl = this.gridControl2;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.CopyToClipboardWithColumnHeaders = false;
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsSelection.MultiSelect = true;
            this.gridView3.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // INDEX_NAME
            // 
            this.INDEX_NAME.Caption = "名称";
            this.INDEX_NAME.FieldName = "INDEX_NAME";
            this.INDEX_NAME.Name = "INDEX_NAME";
            this.INDEX_NAME.Visible = true;
            this.INDEX_NAME.VisibleIndex = 0;
            this.INDEX_NAME.Width = 168;
            // 
            // INDEX_COLUMN
            // 
            this.INDEX_COLUMN.Caption = "列名";
            this.INDEX_COLUMN.FieldName = "INDEX_COLUMN";
            this.INDEX_COLUMN.Name = "INDEX_COLUMN";
            this.INDEX_COLUMN.Visible = true;
            this.INDEX_COLUMN.VisibleIndex = 1;
            this.INDEX_COLUMN.Width = 384;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.gridControl3);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(570, 423);
            this.xtraTabPage3.Text = "触发器";
            // 
            // gridControl3
            // 
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.Location = new System.Drawing.Point(0, 0);
            this.gridControl3.MainView = this.gridView2;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(570, 423);
            this.gridControl3.TabIndex = 1;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TRIGGER_NAME});
            this.gridView2.GridControl = this.gridControl3;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.CopyToClipboardWithColumnHeaders = false;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView2_RowClick);
            // 
            // TRIGGER_NAME
            // 
            this.TRIGGER_NAME.Caption = "名称";
            this.TRIGGER_NAME.FieldName = "TRIGGER_NAME";
            this.TRIGGER_NAME.Name = "TRIGGER_NAME";
            this.TRIGGER_NAME.Visible = true;
            this.TRIGGER_NAME.VisibleIndex = 0;
            this.TRIGGER_NAME.Width = 342;
            // 
            // FrmColumn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 452);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmColumn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查看";
            this.Load += new System.EventHandler(this.FrmColumn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.Columns.GridColumn COLUMN_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn DATA_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn DATA_LENGTH;
        private DevExpress.XtraGrid.Columns.GridColumn NULLABLE;
        private DevExpress.XtraGrid.Columns.GridColumn COMMENTS;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn INDEX_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn INDEX_COLUMN;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn TRIGGER_NAME;
    }
}