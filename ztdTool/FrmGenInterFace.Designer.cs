namespace ztdTool
{
    partial class FrmGenInterFace
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
            this.me_REMARK = new DevExpress.XtraEditors.MemoEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TABLE_NAME = new DevExpress.XtraEditors.TextEdit();
            this.btn_GEN = new System.Windows.Forms.Button();
            this.ck_SAVE = new DevExpress.XtraEditors.CheckEdit();
            this.ck_SERACH = new DevExpress.XtraEditors.CheckEdit();
            this.me_SHOW = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.me_REMARK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TABLE_NAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ck_SAVE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ck_SERACH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.me_SHOW.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.me_REMARK);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.txt_TABLE_NAME);
            this.panelControl1.Controls.Add(this.btn_GEN);
            this.panelControl1.Controls.Add(this.ck_SAVE);
            this.panelControl1.Controls.Add(this.ck_SERACH);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1055, 196);
            this.panelControl1.TabIndex = 0;
            // 
            // me_REMARK
            // 
            this.me_REMARK.Location = new System.Drawing.Point(358, 77);
            this.me_REMARK.Name = "me_REMARK";
            this.me_REMARK.Size = new System.Drawing.Size(570, 75);
            this.me_REMARK.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "接口备注:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "表名:";
            // 
            // txt_TABLE_NAME
            // 
            this.txt_TABLE_NAME.Location = new System.Drawing.Point(358, 29);
            this.txt_TABLE_NAME.Name = "txt_TABLE_NAME";
            this.txt_TABLE_NAME.Size = new System.Drawing.Size(131, 24);
            this.txt_TABLE_NAME.TabIndex = 0;
            // 
            // btn_GEN
            // 
            this.btn_GEN.Location = new System.Drawing.Point(827, 24);
            this.btn_GEN.Name = "btn_GEN";
            this.btn_GEN.Size = new System.Drawing.Size(101, 35);
            this.btn_GEN.TabIndex = 2;
            this.btn_GEN.Text = "生成接口";
            this.btn_GEN.UseVisualStyleBackColor = true;
            this.btn_GEN.Click += new System.EventHandler(this.btn_GEN_Click);
            // 
            // ck_SAVE
            // 
            this.ck_SAVE.Location = new System.Drawing.Point(124, 77);
            this.ck_SAVE.Name = "ck_SAVE";
            this.ck_SAVE.Properties.Caption = "保存";
            this.ck_SAVE.Size = new System.Drawing.Size(103, 22);
            this.ck_SAVE.TabIndex = 5;
            this.ck_SAVE.CheckedChanged += new System.EventHandler(this.ck_SAVE_CheckedChanged);
            // 
            // ck_SERACH
            // 
            this.ck_SERACH.EditValue = true;
            this.ck_SERACH.Location = new System.Drawing.Point(124, 33);
            this.ck_SERACH.Name = "ck_SERACH";
            this.ck_SERACH.Properties.Caption = "查询";
            this.ck_SERACH.Size = new System.Drawing.Size(103, 22);
            this.ck_SERACH.TabIndex = 4;
            this.ck_SERACH.CheckedChanged += new System.EventHandler(this.ck_SERACH_CheckedChanged);
            // 
            // me_SHOW
            // 
            this.me_SHOW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.me_SHOW.Location = new System.Drawing.Point(0, 196);
            this.me_SHOW.Name = "me_SHOW";
            this.me_SHOW.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.me_SHOW.Properties.Appearance.Options.UseFont = true;
            this.me_SHOW.Size = new System.Drawing.Size(1055, 381);
            this.me_SHOW.TabIndex = 1;
            // 
            // FrmGenInterFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 577);
            this.Controls.Add(this.me_SHOW);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmGenInterFace";
            this.Text = "FrmGenInterFace";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.me_REMARK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TABLE_NAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ck_SAVE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ck_SERACH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.me_SHOW.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btn_GEN;
        private DevExpress.XtraEditors.CheckEdit ck_SAVE;
        private DevExpress.XtraEditors.CheckEdit ck_SERACH;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txt_TABLE_NAME;
        private DevExpress.XtraEditors.MemoEdit me_REMARK;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.MemoEdit me_SHOW;
    }
}