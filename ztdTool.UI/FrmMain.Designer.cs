namespace ztdTool.UI
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.bar_GENDT = new DevExpress.XtraBars.BarButtonItem();
            this.bar_GENCODE = new DevExpress.XtraBars.BarButtonItem();
            this.bar_GENINTER = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem7 = new DevExpress.XtraBars.BarSubItem();
            this.bar_SYS_CONFIG = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar_TOOL = new DevExpress.XtraBars.BarButtonItem();
            this.bar_CONFIG = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.xtMain = new DevExpress.XtraEditors.XtraScrollableControl();
            this.barSelect = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bar_TOOL,
            this.bar_CONFIG,
            this.barStaticItem1,
            this.barSubItem1,
            this.barSubItem2,
            this.barSubItem3,
            this.barSubItem4,
            this.bar_GENDT,
            this.bar_GENCODE,
            this.bar_GENINTER,
            this.barSubItem7,
            this.bar_SYS_CONFIG,
            this.barSelect});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 13;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            this.bar1.Visible = false;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem7)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "工具";
            this.barSubItem1.Id = 3;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_GENDT),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_GENCODE),
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_GENINTER),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSelect)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // bar_GENDT
            // 
            this.bar_GENDT.Caption = "生成DataTable";
            this.bar_GENDT.Id = 7;
            this.bar_GENDT.Name = "bar_GENDT";
            this.bar_GENDT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_GENDT_ItemClick);
            // 
            // bar_GENCODE
            // 
            this.bar_GENCODE.Caption = "生成设计代码";
            this.bar_GENCODE.Id = 8;
            this.bar_GENCODE.Name = "bar_GENCODE";
            this.bar_GENCODE.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_GENCODE_ItemClick);
            // 
            // bar_GENINTER
            // 
            this.bar_GENINTER.Caption = "生成接口";
            this.bar_GENINTER.Id = 9;
            this.bar_GENINTER.Name = "bar_GENINTER";
            this.bar_GENINTER.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_GENINTER_ItemClick);
            // 
            // barSubItem7
            // 
            this.barSubItem7.Caption = "配置";
            this.barSubItem7.Id = 10;
            this.barSubItem7.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bar_SYS_CONFIG)});
            this.barSubItem7.Name = "barSubItem7";
            // 
            // bar_SYS_CONFIG
            // 
            this.bar_SYS_CONFIG.Caption = "配置链接";
            this.bar_SYS_CONFIG.Id = 11;
            this.bar_SYS_CONFIG.Name = "bar_SYS_CONFIG";
            this.bar_SYS_CONFIG.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_SYS_CONFIG_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1572, 60);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 784);
            this.barDockControlBottom.Size = new System.Drawing.Size(1572, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 60);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 724);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1572, 60);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 724);
            // 
            // bar_TOOL
            // 
            this.bar_TOOL.Caption = "工具";
            this.bar_TOOL.Id = 0;
            this.bar_TOOL.Name = "bar_TOOL";
            // 
            // bar_CONFIG
            // 
            this.bar_CONFIG.Caption = "配置";
            this.bar_CONFIG.Id = 1;
            this.bar_CONFIG.Name = "bar_CONFIG";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 2;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "生成DataTable";
            this.barSubItem2.Id = 4;
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "生成设计代码";
            this.barSubItem3.Id = 5;
            this.barSubItem3.Name = "barSubItem3";
            // 
            // barSubItem4
            // 
            this.barSubItem4.Caption = "生成接口";
            this.barSubItem4.Id = 6;
            this.barSubItem4.Name = "barSubItem4";
            // 
            // xtMain
            // 
            this.xtMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtMain.Location = new System.Drawing.Point(0, 60);
            this.xtMain.Name = "xtMain";
            this.xtMain.Size = new System.Drawing.Size(1572, 724);
            this.xtMain.TabIndex = 6;
            // 
            // barSelect
            // 
            this.barSelect.Caption = "脚本生成设计代码";
            this.barSelect.Id = 12;
            this.barSelect.Name = "barSelect";
            this.barSelect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSelect_ItemClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 809);
            this.Controls.Add(this.xtMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "小工具(小瀚)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem bar_TOOL;
        private DevExpress.XtraBars.BarButtonItem bar_CONFIG;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem bar_GENDT;
        private DevExpress.XtraBars.BarButtonItem bar_GENCODE;
        private DevExpress.XtraBars.BarButtonItem bar_GENINTER;
        private DevExpress.XtraBars.BarSubItem barSubItem7;
        private DevExpress.XtraBars.BarButtonItem bar_SYS_CONFIG;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarSubItem barSubItem4;
        private DevExpress.XtraEditors.XtraScrollableControl xtMain;
        private DevExpress.XtraBars.BarButtonItem barSelect;

    }
}

