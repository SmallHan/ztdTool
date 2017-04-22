namespace ztdTool.UI
{
    partial class FrmDisgnCode
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
            this.gc_TABLE = new DevExpress.XtraGrid.GridControl();
            this.gv_TABLE = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.COMMENTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TABLE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SQE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.txt_GC_NAME = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_WRITE = new System.Windows.Forms.Button();
            this.txt_FRM_NAME = new System.Windows.Forms.TextBox();
            this.txt_PATH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_GRID_VIEW = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_SELECT_FILED = new System.Windows.Forms.Button();
            this.btn_SERACH = new System.Windows.Forms.Button();
            this.txt_SERACH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.me_TEXT = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_TABLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TABLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.me_TEXT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gc_TABLE);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(596, 589);
            this.panelControl1.TabIndex = 0;
            // 
            // gc_TABLE
            // 
            this.gc_TABLE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_TABLE.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_TABLE.Location = new System.Drawing.Point(2, 297);
            this.gc_TABLE.MainView = this.gv_TABLE;
            this.gc_TABLE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gc_TABLE.Name = "gc_TABLE";
            this.gc_TABLE.Size = new System.Drawing.Size(592, 290);
            this.gc_TABLE.TabIndex = 2;
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
            this.panelControl3.Controls.Add(this.txt_GC_NAME);
            this.panelControl3.Controls.Add(this.label5);
            this.panelControl3.Controls.Add(this.btn_WRITE);
            this.panelControl3.Controls.Add(this.txt_FRM_NAME);
            this.panelControl3.Controls.Add(this.txt_PATH);
            this.panelControl3.Controls.Add(this.label4);
            this.panelControl3.Controls.Add(this.label2);
            this.panelControl3.Controls.Add(this.txt_GRID_VIEW);
            this.panelControl3.Controls.Add(this.label3);
            this.panelControl3.Controls.Add(this.btn_SELECT_FILED);
            this.panelControl3.Controls.Add(this.btn_SERACH);
            this.panelControl3.Controls.Add(this.txt_SERACH);
            this.panelControl3.Controls.Add(this.label1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(592, 295);
            this.panelControl3.TabIndex = 1;
            // 
            // txt_GC_NAME
            // 
            this.txt_GC_NAME.Location = new System.Drawing.Point(136, 109);
            this.txt_GC_NAME.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_GC_NAME.Name = "txt_GC_NAME";
            this.txt_GC_NAME.Size = new System.Drawing.Size(200, 25);
            this.txt_GC_NAME.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "GridControl:";
            // 
            // btn_WRITE
            // 
            this.btn_WRITE.Enabled = false;
            this.btn_WRITE.Location = new System.Drawing.Point(139, 231);
            this.btn_WRITE.Margin = new System.Windows.Forms.Padding(4);
            this.btn_WRITE.Name = "btn_WRITE";
            this.btn_WRITE.Size = new System.Drawing.Size(448, 41);
            this.btn_WRITE.TabIndex = 10;
            this.btn_WRITE.Text = "一键写入到设计文件中(写入有风险,最好手动配置)";
            this.btn_WRITE.UseVisualStyleBackColor = true;
            this.btn_WRITE.Click += new System.EventHandler(this.btn_WRITE_Click);
            // 
            // txt_FRM_NAME
            // 
            this.txt_FRM_NAME.Location = new System.Drawing.Point(139, 197);
            this.txt_FRM_NAME.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_FRM_NAME.Name = "txt_FRM_NAME";
            this.txt_FRM_NAME.Size = new System.Drawing.Size(448, 25);
            this.txt_FRM_NAME.TabIndex = 9;
            // 
            // txt_PATH
            // 
            this.txt_PATH.Location = new System.Drawing.Point(139, 155);
            this.txt_PATH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_PATH.Name = "txt_PATH";
            this.txt_PATH.Size = new System.Drawing.Size(448, 25);
            this.txt_PATH.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "窗体名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "路径:";
            // 
            // txt_GRID_VIEW
            // 
            this.txt_GRID_VIEW.Location = new System.Drawing.Point(136, 65);
            this.txt_GRID_VIEW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_GRID_VIEW.Name = "txt_GRID_VIEW";
            this.txt_GRID_VIEW.Size = new System.Drawing.Size(200, 25);
            this.txt_GRID_VIEW.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "GridView:";
            // 
            // btn_SELECT_FILED
            // 
            this.btn_SELECT_FILED.Location = new System.Drawing.Point(343, 66);
            this.btn_SELECT_FILED.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SELECT_FILED.Name = "btn_SELECT_FILED";
            this.btn_SELECT_FILED.Size = new System.Drawing.Size(95, 25);
            this.btn_SELECT_FILED.TabIndex = 3;
            this.btn_SELECT_FILED.Text = "选择字段";
            this.btn_SELECT_FILED.UseVisualStyleBackColor = true;
            this.btn_SELECT_FILED.Click += new System.EventHandler(this.btn_SELECT_FILED_Click);
            // 
            // btn_SERACH
            // 
            this.btn_SERACH.Location = new System.Drawing.Point(343, 22);
            this.btn_SERACH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SERACH.Name = "btn_SERACH";
            this.btn_SERACH.Size = new System.Drawing.Size(95, 25);
            this.btn_SERACH.TabIndex = 2;
            this.btn_SERACH.Text = "定位到表名";
            this.btn_SERACH.UseVisualStyleBackColor = true;
            this.btn_SERACH.Click += new System.EventHandler(this.btn_SERACH_Click);
            // 
            // txt_SERACH
            // 
            this.txt_SERACH.Location = new System.Drawing.Point(136, 21);
            this.txt_SERACH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SERACH.Name = "txt_SERACH";
            this.txt_SERACH.Size = new System.Drawing.Size(200, 25);
            this.txt_SERACH.TabIndex = 0;
            this.txt_SERACH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SERACH_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "表名:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.me_TEXT);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(596, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(761, 589);
            this.panelControl2.TabIndex = 1;
            // 
            // me_TEXT
            // 
            this.me_TEXT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.me_TEXT.Location = new System.Drawing.Point(2, 2);
            this.me_TEXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.me_TEXT.Name = "me_TEXT";
            this.me_TEXT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.me_TEXT.Properties.Appearance.Options.UseFont = true;
            this.me_TEXT.Size = new System.Drawing.Size(757, 585);
            this.me_TEXT.TabIndex = 0;
            this.me_TEXT.UseOptimizedRendering = true;
            // 
            // FrmDisgnCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 589);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmDisgnCode";
            this.Text = "生成设计代码";
            this.Load += new System.EventHandler(this.FrmDisgnCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_TABLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TABLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.me_TEXT.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Button btn_SERACH;
        private System.Windows.Forms.TextBox txt_SERACH;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gc_TABLE;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_TABLE;
        private DevExpress.XtraGrid.Columns.GridColumn COMMENTS;
        private DevExpress.XtraGrid.Columns.GridColumn TABLE_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn SQE;
        private System.Windows.Forms.Button btn_SELECT_FILED;
        private DevExpress.XtraEditors.MemoEdit me_TEXT;
        private System.Windows.Forms.TextBox txt_GRID_VIEW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_FRM_NAME;
        private System.Windows.Forms.TextBox txt_PATH;
        private System.Windows.Forms.Button btn_WRITE;
        private System.Windows.Forms.TextBox txt_GC_NAME;
        private System.Windows.Forms.Label label5;
    }
}