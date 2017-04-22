namespace ztdTool.UI
{
    partial class FrmConfigure
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
            this.lbl_HOST = new System.Windows.Forms.Label();
            this.lbl_PORT = new System.Windows.Forms.Label();
            this.lbl_SERVER = new System.Windows.Forms.Label();
            this.lbl_USER = new System.Windows.Forms.Label();
            this.lbl_PWD = new System.Windows.Forms.Label();
            this.txt_SERVICE = new DevExpress.XtraEditors.TextEdit();
            this.txt_USERNAME = new DevExpress.XtraEditors.TextEdit();
            this.txt_HOST = new DevExpress.XtraEditors.TextEdit();
            this.txt_PORT = new DevExpress.XtraEditors.TextEdit();
            this.txt_PWD = new DevExpress.XtraEditors.TextEdit();
            this.btn_SAVE = new System.Windows.Forms.Button();
            this.cbo_LIBRARY = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_LIBRARY = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ADD = new System.Windows.Forms.Button();
            this.pan_ADD = new DevExpress.XtraEditors.PanelControl();
            this.btn_DELETE = new System.Windows.Forms.Button();
            this.btn_CANCEL = new System.Windows.Forms.Button();
            this.btn_LINK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SERVICE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_USERNAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HOST.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PORT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PWD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_LIBRARY.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LIBRARY.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pan_ADD)).BeginInit();
            this.pan_ADD.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_HOST
            // 
            this.lbl_HOST.AutoSize = true;
            this.lbl_HOST.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_HOST.Location = new System.Drawing.Point(52, 118);
            this.lbl_HOST.Name = "lbl_HOST";
            this.lbl_HOST.Size = new System.Drawing.Size(59, 19);
            this.lbl_HOST.TabIndex = 0;
            this.lbl_HOST.Text = "HOST:";
            // 
            // lbl_PORT
            // 
            this.lbl_PORT.AutoSize = true;
            this.lbl_PORT.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_PORT.Location = new System.Drawing.Point(52, 174);
            this.lbl_PORT.Name = "lbl_PORT";
            this.lbl_PORT.Size = new System.Drawing.Size(59, 19);
            this.lbl_PORT.TabIndex = 1;
            this.lbl_PORT.Text = "PORT:";
            // 
            // lbl_SERVER
            // 
            this.lbl_SERVER.AutoSize = true;
            this.lbl_SERVER.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_SERVER.Location = new System.Drawing.Point(22, 71);
            this.lbl_SERVER.Name = "lbl_SERVER";
            this.lbl_SERVER.Size = new System.Drawing.Size(89, 19);
            this.lbl_SERVER.TabIndex = 2;
            this.lbl_SERVER.Text = "SERVICE:";
            // 
            // lbl_USER
            // 
            this.lbl_USER.AutoSize = true;
            this.lbl_USER.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_USER.Location = new System.Drawing.Point(12, 225);
            this.lbl_USER.Name = "lbl_USER";
            this.lbl_USER.Size = new System.Drawing.Size(99, 19);
            this.lbl_USER.TabIndex = 3;
            this.lbl_USER.Text = "USERNAME:";
            // 
            // lbl_PWD
            // 
            this.lbl_PWD.AutoSize = true;
            this.lbl_PWD.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_PWD.Location = new System.Drawing.Point(62, 278);
            this.lbl_PWD.Name = "lbl_PWD";
            this.lbl_PWD.Size = new System.Drawing.Size(49, 19);
            this.lbl_PWD.TabIndex = 4;
            this.lbl_PWD.Text = "PWD:";
            // 
            // txt_SERVICE
            // 
            this.txt_SERVICE.EditValue = "";
            this.txt_SERVICE.Location = new System.Drawing.Point(118, 69);
            this.txt_SERVICE.Name = "txt_SERVICE";
            this.txt_SERVICE.Size = new System.Drawing.Size(223, 24);
            this.txt_SERVICE.TabIndex = 1;
            this.txt_SERVICE.Tag = "SERVICE";
            // 
            // txt_USERNAME
            // 
            this.txt_USERNAME.EditValue = "";
            this.txt_USERNAME.Location = new System.Drawing.Point(118, 223);
            this.txt_USERNAME.Name = "txt_USERNAME";
            this.txt_USERNAME.Size = new System.Drawing.Size(223, 24);
            this.txt_USERNAME.TabIndex = 4;
            this.txt_USERNAME.Tag = "USERNAME";
            // 
            // txt_HOST
            // 
            this.txt_HOST.EditValue = "";
            this.txt_HOST.Location = new System.Drawing.Point(118, 115);
            this.txt_HOST.Name = "txt_HOST";
            this.txt_HOST.Size = new System.Drawing.Size(223, 24);
            this.txt_HOST.TabIndex = 2;
            this.txt_HOST.Tag = "HOST";
            // 
            // txt_PORT
            // 
            this.txt_PORT.EditValue = "";
            this.txt_PORT.Location = new System.Drawing.Point(118, 171);
            this.txt_PORT.Name = "txt_PORT";
            this.txt_PORT.Size = new System.Drawing.Size(223, 24);
            this.txt_PORT.TabIndex = 3;
            this.txt_PORT.Tag = "PORT";
            // 
            // txt_PWD
            // 
            this.txt_PWD.EditValue = "";
            this.txt_PWD.Location = new System.Drawing.Point(118, 275);
            this.txt_PWD.Name = "txt_PWD";
            this.txt_PWD.Size = new System.Drawing.Size(223, 24);
            this.txt_PWD.TabIndex = 5;
            this.txt_PWD.Tag = "PWD";
            // 
            // btn_SAVE
            // 
            this.btn_SAVE.Enabled = false;
            this.btn_SAVE.Location = new System.Drawing.Point(68, 400);
            this.btn_SAVE.Name = "btn_SAVE";
            this.btn_SAVE.Size = new System.Drawing.Size(109, 35);
            this.btn_SAVE.TabIndex = 8;
            this.btn_SAVE.Text = "保存到DB";
            this.btn_SAVE.UseVisualStyleBackColor = true;
            this.btn_SAVE.Click += new System.EventHandler(this.btn_SAVE_Click);
            // 
            // cbo_LIBRARY
            // 
            this.cbo_LIBRARY.Location = new System.Drawing.Point(589, 72);
            this.cbo_LIBRARY.Name = "cbo_LIBRARY";
            this.cbo_LIBRARY.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_LIBRARY.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbo_LIBRARY.Size = new System.Drawing.Size(168, 24);
            this.cbo_LIBRARY.TabIndex = 0;
            this.cbo_LIBRARY.SelectedIndexChanged += new System.EventHandler(this.cbo_LIBRARY_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(450, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "选择对应的库:";
            // 
            // txt_LIBRARY
            // 
            this.txt_LIBRARY.EditValue = "";
            this.txt_LIBRARY.Location = new System.Drawing.Point(118, 14);
            this.txt_LIBRARY.Name = "txt_LIBRARY";
            this.txt_LIBRARY.Size = new System.Drawing.Size(223, 24);
            this.txt_LIBRARY.TabIndex = 0;
            this.txt_LIBRARY.Tag = "LIBRARY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(52, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "库名:";
            // 
            // btn_ADD
            // 
            this.btn_ADD.Location = new System.Drawing.Point(68, 347);
            this.btn_ADD.Name = "btn_ADD";
            this.btn_ADD.Size = new System.Drawing.Size(109, 35);
            this.btn_ADD.TabIndex = 6;
            this.btn_ADD.Text = "新增配置";
            this.btn_ADD.UseVisualStyleBackColor = true;
            this.btn_ADD.Click += new System.EventHandler(this.btn_ADD_Click);
            // 
            // pan_ADD
            // 
            this.pan_ADD.Controls.Add(this.btn_DELETE);
            this.pan_ADD.Controls.Add(this.btn_CANCEL);
            this.pan_ADD.Controls.Add(this.txt_PWD);
            this.pan_ADD.Controls.Add(this.lbl_HOST);
            this.pan_ADD.Controls.Add(this.btn_ADD);
            this.pan_ADD.Controls.Add(this.txt_LIBRARY);
            this.pan_ADD.Controls.Add(this.lbl_PORT);
            this.pan_ADD.Controls.Add(this.label2);
            this.pan_ADD.Controls.Add(this.btn_SAVE);
            this.pan_ADD.Controls.Add(this.lbl_SERVER);
            this.pan_ADD.Controls.Add(this.lbl_USER);
            this.pan_ADD.Controls.Add(this.lbl_PWD);
            this.pan_ADD.Controls.Add(this.txt_USERNAME);
            this.pan_ADD.Controls.Add(this.txt_SERVICE);
            this.pan_ADD.Controls.Add(this.txt_PORT);
            this.pan_ADD.Controls.Add(this.txt_HOST);
            this.pan_ADD.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan_ADD.Location = new System.Drawing.Point(0, 0);
            this.pan_ADD.Name = "pan_ADD";
            this.pan_ADD.Size = new System.Drawing.Size(386, 677);
            this.pan_ADD.TabIndex = 16;
            // 
            // btn_DELETE
            // 
            this.btn_DELETE.Location = new System.Drawing.Point(200, 400);
            this.btn_DELETE.Name = "btn_DELETE";
            this.btn_DELETE.Size = new System.Drawing.Size(109, 35);
            this.btn_DELETE.TabIndex = 14;
            this.btn_DELETE.Text = "删除";
            this.btn_DELETE.UseVisualStyleBackColor = true;
            this.btn_DELETE.Click += new System.EventHandler(this.btn_DELETE_Click);
            // 
            // btn_CANCEL
            // 
            this.btn_CANCEL.Enabled = false;
            this.btn_CANCEL.Location = new System.Drawing.Point(200, 347);
            this.btn_CANCEL.Name = "btn_CANCEL";
            this.btn_CANCEL.Size = new System.Drawing.Size(109, 35);
            this.btn_CANCEL.TabIndex = 7;
            this.btn_CANCEL.Text = "取消";
            this.btn_CANCEL.UseVisualStyleBackColor = true;
            this.btn_CANCEL.Click += new System.EventHandler(this.btn_CANCEL_Click);
            // 
            // btn_LINK
            // 
            this.btn_LINK.Location = new System.Drawing.Point(763, 72);
            this.btn_LINK.Name = "btn_LINK";
            this.btn_LINK.Size = new System.Drawing.Size(109, 24);
            this.btn_LINK.TabIndex = 17;
            this.btn_LINK.Text = "链接";
            this.btn_LINK.UseVisualStyleBackColor = true;
            this.btn_LINK.Click += new System.EventHandler(this.btn_LINK_Click);
            // 
            // FrmConfigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1554, 677);
            this.Controls.Add(this.btn_LINK);
            this.Controls.Add(this.pan_ADD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_LIBRARY);
            this.Name = "FrmConfigure";
            this.Text = "数据库配置";
            this.Load += new System.EventHandler(this.FrmConfigure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_SERVICE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_USERNAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HOST.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PORT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PWD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_LIBRARY.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LIBRARY.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pan_ADD)).EndInit();
            this.pan_ADD.ResumeLayout(false);
            this.pan_ADD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_HOST;
        private System.Windows.Forms.Label lbl_PORT;
        private System.Windows.Forms.Label lbl_SERVER;
        private System.Windows.Forms.Label lbl_USER;
        private System.Windows.Forms.Label lbl_PWD;
        private DevExpress.XtraEditors.TextEdit txt_SERVICE;
        private DevExpress.XtraEditors.TextEdit txt_USERNAME;
        private DevExpress.XtraEditors.TextEdit txt_HOST;
        private DevExpress.XtraEditors.TextEdit txt_PORT;
        private DevExpress.XtraEditors.TextEdit txt_PWD;
        private System.Windows.Forms.Button btn_SAVE;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_LIBRARY;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txt_LIBRARY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ADD;
        private DevExpress.XtraEditors.PanelControl pan_ADD;
        private System.Windows.Forms.Button btn_LINK;
        private System.Windows.Forms.Button btn_CANCEL;
        private System.Windows.Forms.Button btn_DELETE;
    }
}