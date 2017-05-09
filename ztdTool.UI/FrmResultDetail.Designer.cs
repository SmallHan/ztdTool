namespace ztdTool.UI
{
    partial class FrmResultDetail
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
            this.gc_PREVIEW = new DevExpress.XtraGrid.GridControl();
            this.gv_PREVIEW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lbl_SERACH = new System.Windows.Forms.Label();
            this.txt_NUMBER = new DevExpress.XtraEditors.TextEdit();
            this.ck_MORE_NUMBER = new System.Windows.Forms.CheckBox();
            this.lbl_TIME = new System.Windows.Forms.Label();
            this.lbl_ROW = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gc_PREVIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_PREVIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NUMBER.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_PREVIEW
            // 
            this.gc_PREVIEW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_PREVIEW.Location = new System.Drawing.Point(0, 0);
            this.gc_PREVIEW.MainView = this.gv_PREVIEW;
            this.gc_PREVIEW.Name = "gc_PREVIEW";
            this.gc_PREVIEW.Size = new System.Drawing.Size(1058, 449);
            this.gc_PREVIEW.TabIndex = 4;
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
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.lbl_SERACH);
            this.panelControl2.Controls.Add(this.txt_NUMBER);
            this.panelControl2.Controls.Add(this.ck_MORE_NUMBER);
            this.panelControl2.Controls.Add(this.lbl_TIME);
            this.panelControl2.Controls.Add(this.lbl_ROW);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 449);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1058, 29);
            this.panelControl2.TabIndex = 5;
            // 
            // lbl_SERACH
            // 
            this.lbl_SERACH.AutoSize = true;
            this.lbl_SERACH.Location = new System.Drawing.Point(906, 6);
            this.lbl_SERACH.Name = "lbl_SERACH";
            this.lbl_SERACH.Size = new System.Drawing.Size(0, 15);
            this.lbl_SERACH.TabIndex = 6;
            // 
            // txt_NUMBER
            // 
            this.txt_NUMBER.EditValue = "1000";
            this.txt_NUMBER.Location = new System.Drawing.Point(716, 2);
            this.txt_NUMBER.Name = "txt_NUMBER";
            this.txt_NUMBER.Properties.Mask.EditMask = "[1-9]{1}[0-9]{1,6}";
            this.txt_NUMBER.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txt_NUMBER.Size = new System.Drawing.Size(86, 24);
            this.txt_NUMBER.TabIndex = 5;
            // 
            // ck_MORE_NUMBER
            // 
            this.ck_MORE_NUMBER.AutoSize = true;
            this.ck_MORE_NUMBER.Location = new System.Drawing.Point(563, 6);
            this.ck_MORE_NUMBER.Name = "ck_MORE_NUMBER";
            this.ck_MORE_NUMBER.Size = new System.Drawing.Size(149, 19);
            this.ck_MORE_NUMBER.TabIndex = 4;
            this.ck_MORE_NUMBER.Text = "限制查询最多条数";
            this.ck_MORE_NUMBER.UseVisualStyleBackColor = true;
            // 
            // lbl_TIME
            // 
            this.lbl_TIME.AutoSize = true;
            this.lbl_TIME.Location = new System.Drawing.Point(265, 6);
            this.lbl_TIME.Name = "lbl_TIME";
            this.lbl_TIME.Size = new System.Drawing.Size(0, 15);
            this.lbl_TIME.TabIndex = 3;
            // 
            // lbl_ROW
            // 
            this.lbl_ROW.AutoSize = true;
            this.lbl_ROW.Location = new System.Drawing.Point(89, 6);
            this.lbl_ROW.Name = "lbl_ROW";
            this.lbl_ROW.Size = new System.Drawing.Size(0, 15);
            this.lbl_ROW.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "查询用时:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据行数:";
            // 
            // FrmResultDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 478);
            this.Controls.Add(this.gc_PREVIEW);
            this.Controls.Add(this.panelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmResultDetail";
            this.Text = "FrmResultDetail";
            this.Load += new System.EventHandler(this.FrmResultDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_PREVIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_PREVIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NUMBER.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_PREVIEW;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_PREVIEW;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label lbl_SERACH;
        private DevExpress.XtraEditors.TextEdit txt_NUMBER;
        private System.Windows.Forms.CheckBox ck_MORE_NUMBER;
        private System.Windows.Forms.Label lbl_TIME;
        private System.Windows.Forms.Label lbl_ROW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}