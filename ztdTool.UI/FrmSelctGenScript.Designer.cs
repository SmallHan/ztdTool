namespace ztdTool.UI
{
    partial class FrmSelctGenScript
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_GEN_SCRIPT = new System.Windows.Forms.Button();
            this.btn_GEN_GRID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gc_PREVIEW = new DevExpress.XtraGrid.GridControl();
            this.gv_PREVIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.richSql = new DevExpress.XtraRichEdit.RichEditControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_PREVIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_PREVIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.richSql);
            this.panelControl1.Controls.Add(this.btn_GEN_SCRIPT);
            this.panelControl1.Controls.Add(this.btn_GEN_GRID);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1276, 441);
            this.panelControl1.TabIndex = 0;
            // 
            // btn_GEN_SCRIPT
            // 
            this.btn_GEN_SCRIPT.Enabled = false;
            this.btn_GEN_SCRIPT.Location = new System.Drawing.Point(1039, 153);
            this.btn_GEN_SCRIPT.Name = "btn_GEN_SCRIPT";
            this.btn_GEN_SCRIPT.Size = new System.Drawing.Size(156, 39);
            this.btn_GEN_SCRIPT.TabIndex = 14;
            this.btn_GEN_SCRIPT.Text = "生成脚本";
            this.btn_GEN_SCRIPT.UseVisualStyleBackColor = true;
            this.btn_GEN_SCRIPT.Click += new System.EventHandler(this.btn_GEN_SCRIPT_Click);
            // 
            // btn_GEN_GRID
            // 
            this.btn_GEN_GRID.Location = new System.Drawing.Point(1039, 87);
            this.btn_GEN_GRID.Name = "btn_GEN_GRID";
            this.btn_GEN_GRID.Size = new System.Drawing.Size(156, 39);
            this.btn_GEN_GRID.TabIndex = 12;
            this.btn_GEN_GRID.Text = "查询并生成GridView";
            this.btn_GEN_GRID.UseVisualStyleBackColor = true;
            this.btn_GEN_GRID.Click += new System.EventHandler(this.btn_GEN_GRID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "查询SQL:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gc_PREVIEW);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 441);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1276, 265);
            this.panelControl2.TabIndex = 1;
            // 
            // gc_PREVIEW
            // 
            this.gc_PREVIEW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_PREVIEW.Location = new System.Drawing.Point(2, 2);
            this.gc_PREVIEW.MainView = this.gv_PREVIEW;
            this.gc_PREVIEW.Name = "gc_PREVIEW";
            this.gc_PREVIEW.Size = new System.Drawing.Size(1272, 261);
            this.gc_PREVIEW.TabIndex = 1;
            this.gc_PREVIEW.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_PREVIEW});
            // 
            // gv_PREVIEW
            // 
            this.gv_PREVIEW.GridControl = this.gc_PREVIEW;
            this.gv_PREVIEW.Name = "gv_PREVIEW";
            this.gv_PREVIEW.OptionsView.ColumnAutoWidth = false;
            this.gv_PREVIEW.OptionsView.ShowGroupPanel = false;
            // 
            // richSql
            // 
            this.richSql.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.richSql.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.richSql.Location = new System.Drawing.Point(168, 42);
            this.richSql.Name = "richSql";
            this.richSql.Options.Fields.UseCurrentCultureDateTimeFormat = false;
            this.richSql.Options.MailMerge.KeepLastParagraph = false;
            this.richSql.Size = new System.Drawing.Size(851, 393);
            this.richSql.TabIndex = 15;
            // 
            // FrmSelctGenScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 706);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmSelctGenScript";
            this.Load += new System.EventHandler(this.FrmSelctGenScript_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_PREVIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_PREVIEW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gc_PREVIEW;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_PREVIEW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_GEN_GRID;
        private System.Windows.Forms.Button btn_GEN_SCRIPT;
        private DevExpress.XtraRichEdit.RichEditControl richSql;
    }
}