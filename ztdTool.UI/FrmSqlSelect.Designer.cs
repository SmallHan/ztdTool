﻿namespace ztdTool.UI
{
    partial class FrmSqlSelect
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
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.list_TABLE = new DevExpress.XtraEditors.ListBoxControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.txt_SERACH_TABLE = new System.Windows.Forms.TextBox();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tool_SQL = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_EXEC = new System.Windows.Forms.ToolStripMenuItem();
            this.xtra_SQL = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_TABLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtra_SQL)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl5);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 28);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(256, 758);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.list_TABLE);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl5.Location = new System.Drawing.Point(2, 36);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(252, 720);
            this.panelControl5.TabIndex = 2;
            // 
            // list_TABLE
            // 
            this.list_TABLE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_TABLE.Location = new System.Drawing.Point(2, 2);
            this.list_TABLE.Name = "list_TABLE";
            this.list_TABLE.Size = new System.Drawing.Size(248, 716);
            this.list_TABLE.TabIndex = 0;
            this.list_TABLE.DoubleClick += new System.EventHandler(this.list_TABLE_DoubleClick);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.txt_SERACH_TABLE);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(252, 34);
            this.panelControl3.TabIndex = 0;
            // 
            // txt_SERACH_TABLE
            // 
            this.txt_SERACH_TABLE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_SERACH_TABLE.Location = new System.Drawing.Point(2, 2);
            this.txt_SERACH_TABLE.Name = "txt_SERACH_TABLE";
            this.txt_SERACH_TABLE.Size = new System.Drawing.Size(248, 25);
            this.txt_SERACH_TABLE.TabIndex = 1;
            this.txt_SERACH_TABLE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SERACH_TABLE_KeyDown);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(256, 28);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 758);
            this.splitterControl1.TabIndex = 1;
            this.splitterControl1.TabStop = false;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1040, 517);
            // 
            // panelControl4
            // 
            this.panelControl4.Location = new System.Drawing.Point(483, 444);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(200, 100);
            this.panelControl4.TabIndex = 5;
            // 
            // panelControl6
            // 
            this.panelControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl6.Location = new System.Drawing.Point(261, 351);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(1046, 435);
            this.panelControl6.TabIndex = 6;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.DockCol = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.Text = "Status bar";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_SQL,
            this.tool_EXEC});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1307, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tool_SQL
            // 
            this.tool_SQL.Name = "tool_SQL";
            this.tool_SQL.Size = new System.Drawing.Size(72, 24);
            this.tool_SQL.Text = "SQL(Q)";
            this.tool_SQL.Click += new System.EventHandler(this.tool_SQL_Click);
            // 
            // tool_EXEC
            // 
            this.tool_EXEC.Name = "tool_EXEC";
            this.tool_EXEC.Size = new System.Drawing.Size(78, 24);
            this.tool_EXEC.Text = "执行(F8)";
            this.tool_EXEC.Click += new System.EventHandler(this.tool_EXEC_Click);
            // 
            // xtra_SQL
            // 
            this.xtra_SQL.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtra_SQL.Location = new System.Drawing.Point(261, 28);
            this.xtra_SQL.Name = "xtra_SQL";
            this.xtra_SQL.Size = new System.Drawing.Size(1046, 323);
            this.xtra_SQL.TabIndex = 4;
            // 
            // FrmSqlSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 786);
            this.Controls.Add(this.panelControl6);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.xtra_SQL);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmSqlSelect";
            this.Text = "FrmSqlSelect";
            this.Load += new System.EventHandler(this.FrmSqlSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.list_TABLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtra_SQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.ListBoxControl list_TABLE;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.TextBox txt_SERACH_TABLE;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tool_SQL;
        private System.Windows.Forms.ToolStripMenuItem tool_EXEC;
        private DevExpress.XtraTab.XtraTabControl xtra_SQL;
    }
}