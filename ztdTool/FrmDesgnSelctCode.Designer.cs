namespace ztdTool
{
    partial class FrmDesgnSelctCode
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
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btn_WRITE = new System.Windows.Forms.Button();
            this.txt_FRM_NAME = new System.Windows.Forms.TextBox();
            this.txt_PATH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_GRID_CONTROL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CONFIG = new System.Windows.Forms.Button();
            this.txt_GRID_VIEW = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.me_TEXT = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.me_TEXT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.txt_GRID_CONTROL);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.btn_CONFIG);
            this.panelControl1.Controls.Add(this.txt_GRID_VIEW);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(535, 589);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btn_WRITE);
            this.panelControl3.Controls.Add(this.txt_FRM_NAME);
            this.panelControl3.Controls.Add(this.txt_PATH);
            this.panelControl3.Controls.Add(this.label4);
            this.panelControl3.Controls.Add(this.label2);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Enabled = false;
            this.panelControl3.Location = new System.Drawing.Point(2, 302);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(531, 285);
            this.panelControl3.TabIndex = 11;
            // 
            // btn_WRITE
            // 
            this.btn_WRITE.Location = new System.Drawing.Point(106, 216);
            this.btn_WRITE.Margin = new System.Windows.Forms.Padding(4);
            this.btn_WRITE.Name = "btn_WRITE";
            this.btn_WRITE.Size = new System.Drawing.Size(401, 41);
            this.btn_WRITE.TabIndex = 2;
            this.btn_WRITE.Text = "一键写入到设计文件中(写入有风险,最好手动配置)";
            this.btn_WRITE.UseVisualStyleBackColor = true;
            this.btn_WRITE.Click += new System.EventHandler(this.btn_WRITE_Click);
            // 
            // txt_FRM_NAME
            // 
            this.txt_FRM_NAME.Location = new System.Drawing.Point(106, 74);
            this.txt_FRM_NAME.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_FRM_NAME.Name = "txt_FRM_NAME";
            this.txt_FRM_NAME.Size = new System.Drawing.Size(401, 25);
            this.txt_FRM_NAME.TabIndex = 1;
            // 
            // txt_PATH
            // 
            this.txt_PATH.Location = new System.Drawing.Point(106, 32);
            this.txt_PATH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_PATH.Name = "txt_PATH";
            this.txt_PATH.Size = new System.Drawing.Size(401, 25);
            this.txt_PATH.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "窗体名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "路径:";
            // 
            // txt_GRID_CONTROL
            // 
            this.txt_GRID_CONTROL.Location = new System.Drawing.Point(154, 97);
            this.txt_GRID_CONTROL.Name = "txt_GRID_CONTROL";
            this.txt_GRID_CONTROL.Size = new System.Drawing.Size(200, 25);
            this.txt_GRID_CONTROL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "GridControl:";
            // 
            // btn_CONFIG
            // 
            this.btn_CONFIG.Location = new System.Drawing.Point(154, 151);
            this.btn_CONFIG.Name = "btn_CONFIG";
            this.btn_CONFIG.Size = new System.Drawing.Size(200, 25);
            this.btn_CONFIG.TabIndex = 2;
            this.btn_CONFIG.Text = "配置";
            this.btn_CONFIG.UseVisualStyleBackColor = true;
            this.btn_CONFIG.Click += new System.EventHandler(this.btn_CONFIG_Click);
            // 
            // txt_GRID_VIEW
            // 
            this.txt_GRID_VIEW.Location = new System.Drawing.Point(154, 41);
            this.txt_GRID_VIEW.Name = "txt_GRID_VIEW";
            this.txt_GRID_VIEW.Size = new System.Drawing.Size(200, 25);
            this.txt_GRID_VIEW.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "GridView:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.me_TEXT);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(535, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(741, 589);
            this.panelControl2.TabIndex = 1;
            // 
            // me_TEXT
            // 
            this.me_TEXT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.me_TEXT.Location = new System.Drawing.Point(2, 2);
            this.me_TEXT.Name = "me_TEXT";
            this.me_TEXT.Size = new System.Drawing.Size(737, 585);
            this.me_TEXT.TabIndex = 1;
            this.me_TEXT.UseOptimizedRendering = true;
            // 
            // FrmDesgnSelctCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 589);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmDesgnSelctCode";
            this.Text = "FrmDesgnSelctCode";
            this.Load += new System.EventHandler(this.FrmDesgnSelctCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
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
        private System.Windows.Forms.TextBox txt_GRID_VIEW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_CONFIG;
        private DevExpress.XtraEditors.MemoEdit me_TEXT;
        private System.Windows.Forms.TextBox txt_GRID_CONTROL;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Button btn_WRITE;
        private System.Windows.Forms.TextBox txt_FRM_NAME;
        private System.Windows.Forms.TextBox txt_PATH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}