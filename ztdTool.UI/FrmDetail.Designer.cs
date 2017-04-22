namespace ztdTool.UI
{
    partial class FrmDetail
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_GEN_GRID = new System.Windows.Forms.Button();
            this.btn_LEFT_ALL = new System.Windows.Forms.Button();
            this.btn_LEFT_SINGLE = new System.Windows.Forms.Button();
            this.btn_RIGHT_ALL = new System.Windows.Forms.Button();
            this.btn_RIGHT_SINGLE = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gc_PREVIEW = new DevExpress.XtraGrid.GridControl();
            this.gv_PREVIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.panelControl1.Controls.Add(this.btn_GEN_SCRIPT);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.btn_GEN_GRID);
            this.panelControl1.Controls.Add(this.btn_LEFT_ALL);
            this.panelControl1.Controls.Add(this.btn_LEFT_SINGLE);
            this.panelControl1.Controls.Add(this.btn_RIGHT_ALL);
            this.panelControl1.Controls.Add(this.btn_RIGHT_SINGLE);
            this.panelControl1.Controls.Add(this.listBox2);
            this.panelControl1.Controls.Add(this.listBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1141, 243);
            this.panelControl1.TabIndex = 0;
            // 
            // btn_GEN_SCRIPT
            // 
            this.btn_GEN_SCRIPT.Enabled = false;
            this.btn_GEN_SCRIPT.Location = new System.Drawing.Point(1000, 125);
            this.btn_GEN_SCRIPT.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GEN_SCRIPT.Name = "btn_GEN_SCRIPT";
            this.btn_GEN_SCRIPT.Size = new System.Drawing.Size(92, 26);
            this.btn_GEN_SCRIPT.TabIndex = 13;
            this.btn_GEN_SCRIPT.Text = "生成脚本";
            this.btn_GEN_SCRIPT.UseVisualStyleBackColor = true;
            this.btn_GEN_SCRIPT.Click += new System.EventHandler(this.btn_GEN_SCRIPT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(997, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "可拉动列配置位置";
            // 
            // btn_GEN_GRID
            // 
            this.btn_GEN_GRID.Location = new System.Drawing.Point(998, 63);
            this.btn_GEN_GRID.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GEN_GRID.Name = "btn_GEN_GRID";
            this.btn_GEN_GRID.Size = new System.Drawing.Size(92, 26);
            this.btn_GEN_GRID.TabIndex = 11;
            this.btn_GEN_GRID.Text = "生成GridView";
            this.btn_GEN_GRID.UseVisualStyleBackColor = true;
            this.btn_GEN_GRID.Click += new System.EventHandler(this.btn_GEN_GRID_Click);
            // 
            // btn_LEFT_ALL
            // 
            this.btn_LEFT_ALL.Location = new System.Drawing.Point(496, 192);
            this.btn_LEFT_ALL.Margin = new System.Windows.Forms.Padding(2);
            this.btn_LEFT_ALL.Name = "btn_LEFT_ALL";
            this.btn_LEFT_ALL.Size = new System.Drawing.Size(56, 18);
            this.btn_LEFT_ALL.TabIndex = 9;
            this.btn_LEFT_ALL.Text = "<<";
            this.btn_LEFT_ALL.UseVisualStyleBackColor = true;
            this.btn_LEFT_ALL.Click += new System.EventHandler(this.btn_LEFT_ALL_Click);
            // 
            // btn_LEFT_SINGLE
            // 
            this.btn_LEFT_SINGLE.Location = new System.Drawing.Point(496, 148);
            this.btn_LEFT_SINGLE.Margin = new System.Windows.Forms.Padding(2);
            this.btn_LEFT_SINGLE.Name = "btn_LEFT_SINGLE";
            this.btn_LEFT_SINGLE.Size = new System.Drawing.Size(56, 18);
            this.btn_LEFT_SINGLE.TabIndex = 8;
            this.btn_LEFT_SINGLE.Text = "<";
            this.btn_LEFT_SINGLE.UseVisualStyleBackColor = true;
            this.btn_LEFT_SINGLE.Click += new System.EventHandler(this.btn_LEFT_SINGLE_Click);
            // 
            // btn_RIGHT_ALL
            // 
            this.btn_RIGHT_ALL.Location = new System.Drawing.Point(496, 106);
            this.btn_RIGHT_ALL.Margin = new System.Windows.Forms.Padding(2);
            this.btn_RIGHT_ALL.Name = "btn_RIGHT_ALL";
            this.btn_RIGHT_ALL.Size = new System.Drawing.Size(56, 18);
            this.btn_RIGHT_ALL.TabIndex = 7;
            this.btn_RIGHT_ALL.Text = ">>";
            this.btn_RIGHT_ALL.UseVisualStyleBackColor = true;
            this.btn_RIGHT_ALL.Click += new System.EventHandler(this.btn_RIGHT_ALL_Click);
            // 
            // btn_RIGHT_SINGLE
            // 
            this.btn_RIGHT_SINGLE.Location = new System.Drawing.Point(496, 55);
            this.btn_RIGHT_SINGLE.Margin = new System.Windows.Forms.Padding(2);
            this.btn_RIGHT_SINGLE.Name = "btn_RIGHT_SINGLE";
            this.btn_RIGHT_SINGLE.Size = new System.Drawing.Size(56, 18);
            this.btn_RIGHT_SINGLE.TabIndex = 6;
            this.btn_RIGHT_SINGLE.Text = ">";
            this.btn_RIGHT_SINGLE.UseVisualStyleBackColor = true;
            this.btn_RIGHT_SINGLE.Click += new System.EventHandler(this.btn_RIGHT_SINGLE_Click);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 19;
            this.listBox2.Location = new System.Drawing.Point(594, 11);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(387, 232);
            this.listBox2.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(48, 11);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(380, 232);
            this.listBox1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gc_PREVIEW);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 243);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1141, 246);
            this.panelControl2.TabIndex = 1;
            // 
            // gc_PREVIEW
            // 
            this.gc_PREVIEW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_PREVIEW.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_PREVIEW.Location = new System.Drawing.Point(2, 2);
            this.gc_PREVIEW.MainView = this.gv_PREVIEW;
            this.gc_PREVIEW.Margin = new System.Windows.Forms.Padding(2);
            this.gc_PREVIEW.Name = "gc_PREVIEW";
            this.gc_PREVIEW.Size = new System.Drawing.Size(1137, 242);
            this.gc_PREVIEW.TabIndex = 0;
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
            // FrmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 489);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmDetail";
            this.Text = "FrmDetail";
            this.Load += new System.EventHandler(this.FrmDetail_Load);
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
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Button btn_LEFT_ALL;
        private System.Windows.Forms.Button btn_LEFT_SINGLE;
        private System.Windows.Forms.Button btn_RIGHT_ALL;
        private System.Windows.Forms.Button btn_RIGHT_SINGLE;
        private System.Windows.Forms.Button btn_GEN_GRID;
        private DevExpress.XtraGrid.GridControl gc_PREVIEW;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_PREVIEW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_GEN_SCRIPT;
    }
}