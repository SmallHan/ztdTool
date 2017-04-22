namespace ztdTool.UI
{
    partial class FrmConvert2Dt
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
            this.panMain = new DevExpress.XtraEditors.PanelControl();
            this.panDt = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.me_Dt = new DevExpress.XtraEditors.MemoEdit();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TABLE_NAME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_GEN_DT = new System.Windows.Forms.TextBox();
            this.btn_GEN_DT = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gc_TABLE = new DevExpress.XtraGrid.GridControl();
            this.gv_TABLE = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.COMMENTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TABLE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SQE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btn_SERACH = new System.Windows.Forms.Button();
            this.txt_SERACH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panMain)).BeginInit();
            this.panMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panDt)).BeginInit();
            this.panDt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.me_Dt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_TABLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TABLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMain
            // 
            this.panMain.Controls.Add(this.panDt);
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(0, 0);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(1276, 589);
            this.panMain.TabIndex = 1;
            // 
            // panDt
            // 
            this.panDt.Controls.Add(this.panelControl2);
            this.panDt.Controls.Add(this.panelControl1);
            this.panDt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panDt.Location = new System.Drawing.Point(2, 2);
            this.panDt.Name = "panDt";
            this.panDt.Size = new System.Drawing.Size(1272, 585);
            this.panDt.TabIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.me_Dt);
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(505, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(765, 581);
            this.panelControl2.TabIndex = 1;
            // 
            // me_Dt
            // 
            this.me_Dt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.me_Dt.Location = new System.Drawing.Point(2, 126);
            this.me_Dt.Name = "me_Dt";
            this.me_Dt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.me_Dt.Properties.Appearance.Options.UseFont = true;
            this.me_Dt.Size = new System.Drawing.Size(761, 453);
            this.me_Dt.TabIndex = 2;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.label3);
            this.panelControl4.Controls.Add(this.txt_TABLE_NAME);
            this.panelControl4.Controls.Add(this.label2);
            this.panelControl4.Controls.Add(this.txt_GEN_DT);
            this.panelControl4.Controls.Add(this.btn_GEN_DT);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(2, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(761, 124);
            this.panelControl4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "dt名:";
            // 
            // txt_TABLE_NAME
            // 
            this.txt_TABLE_NAME.Location = new System.Drawing.Point(239, 37);
            this.txt_TABLE_NAME.Name = "txt_TABLE_NAME";
            this.txt_TABLE_NAME.ReadOnly = true;
            this.txt_TABLE_NAME.Size = new System.Drawing.Size(200, 26);
            this.txt_TABLE_NAME.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "表名:";
            // 
            // txt_GEN_DT
            // 
            this.txt_GEN_DT.Location = new System.Drawing.Point(239, 78);
            this.txt_GEN_DT.Name = "txt_GEN_DT";
            this.txt_GEN_DT.Size = new System.Drawing.Size(200, 26);
            this.txt_GEN_DT.TabIndex = 0;
            this.txt_GEN_DT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_GEN_DT_KeyDown);
            // 
            // btn_GEN_DT
            // 
            this.btn_GEN_DT.Location = new System.Drawing.Point(445, 79);
            this.btn_GEN_DT.Name = "btn_GEN_DT";
            this.btn_GEN_DT.Size = new System.Drawing.Size(147, 25);
            this.btn_GEN_DT.TabIndex = 3;
            this.btn_GEN_DT.Text = "生成DataTable";
            this.btn_GEN_DT.UseVisualStyleBackColor = true;
            this.btn_GEN_DT.Click += new System.EventHandler(this.btn_GEN_DT_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gc_TABLE);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(503, 581);
            this.panelControl1.TabIndex = 0;
            // 
            // gc_TABLE
            // 
            this.gc_TABLE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_TABLE.Location = new System.Drawing.Point(2, 126);
            this.gc_TABLE.MainView = this.gv_TABLE;
            this.gc_TABLE.Name = "gc_TABLE";
            this.gc_TABLE.Size = new System.Drawing.Size(499, 453);
            this.gc_TABLE.TabIndex = 1;
            this.gc_TABLE.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_TABLE});
            // 
            // gv_TABLE
            // 
            this.gv_TABLE.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.COMMENTS,
            this.TABLE_NAME,
            this.SQE});
            this.gv_TABLE.GridControl = this.gc_TABLE;
            this.gv_TABLE.Name = "gv_TABLE";
            this.gv_TABLE.OptionsBehavior.Editable = false;
            this.gv_TABLE.OptionsBehavior.ReadOnly = true;
            this.gv_TABLE.OptionsView.ShowFooter = true;
            this.gv_TABLE.OptionsView.ShowGroupPanel = false;
            this.gv_TABLE.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_TABLE_FocusedRowChanged);
            // 
            // COMMENTS
            // 
            this.COMMENTS.AppearanceHeader.Options.UseTextOptions = true;
            this.COMMENTS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.COMMENTS.Caption = "中文名";
            this.COMMENTS.FieldName = "COMMENTS";
            this.COMMENTS.Name = "COMMENTS";
            this.COMMENTS.Visible = true;
            this.COMMENTS.VisibleIndex = 1;
            // 
            // TABLE_NAME
            // 
            this.TABLE_NAME.AppearanceHeader.Options.UseTextOptions = true;
            this.TABLE_NAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TABLE_NAME.Caption = "表名";
            this.TABLE_NAME.FieldName = "TABLE_NAME";
            this.TABLE_NAME.Name = "TABLE_NAME";
            this.TABLE_NAME.Visible = true;
            this.TABLE_NAME.VisibleIndex = 0;
            // 
            // SQE
            // 
            this.SQE.AppearanceHeader.Options.UseTextOptions = true;
            this.SQE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SQE.Caption = "序列";
            this.SQE.FieldName = "SQE";
            this.SQE.Name = "SQE";
            this.SQE.Visible = true;
            this.SQE.VisibleIndex = 2;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btn_SERACH);
            this.panelControl3.Controls.Add(this.txt_SERACH);
            this.panelControl3.Controls.Add(this.label1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(499, 124);
            this.panelControl3.TabIndex = 0;
            // 
            // btn_SERACH
            // 
            this.btn_SERACH.Location = new System.Drawing.Point(310, 45);
            this.btn_SERACH.Name = "btn_SERACH";
            this.btn_SERACH.Size = new System.Drawing.Size(96, 25);
            this.btn_SERACH.TabIndex = 2;
            this.btn_SERACH.Text = "定位到表名";
            this.btn_SERACH.UseVisualStyleBackColor = true;
            this.btn_SERACH.Click += new System.EventHandler(this.btn_SERACH_Click);
            // 
            // txt_SERACH
            // 
            this.txt_SERACH.Location = new System.Drawing.Point(103, 44);
            this.txt_SERACH.Name = "txt_SERACH";
            this.txt_SERACH.Size = new System.Drawing.Size(200, 26);
            this.txt_SERACH.TabIndex = 0;
            this.txt_SERACH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SERACH_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "表名:";
            // 
            // FrmConvert2Dt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 589);
            this.Controls.Add(this.panMain);
            this.Name = "FrmConvert2Dt";
            this.Text = "字段转换为DataTable";
            this.Load += new System.EventHandler(this.FrmConvert2Dt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panMain)).EndInit();
            this.panMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panDt)).EndInit();
            this.panDt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.me_Dt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_TABLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TABLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panMain;
        private DevExpress.XtraEditors.PanelControl panDt;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gc_TABLE;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_TABLE;
        private DevExpress.XtraGrid.Columns.GridColumn COMMENTS;
        private DevExpress.XtraGrid.Columns.GridColumn TABLE_NAME;
        private System.Windows.Forms.Button btn_SERACH;
        private System.Windows.Forms.TextBox txt_SERACH;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn SQE;
        private System.Windows.Forms.Button btn_GEN_DT;
        private System.Windows.Forms.TextBox txt_GEN_DT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TABLE_NAME;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.MemoEdit me_Dt;

    }
}