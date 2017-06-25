namespace ADBTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.panelRight = new System.Windows.Forms.Panel();
            this.cboSaveData = new System.Windows.Forms.CheckBox();
            this.btnStopADB = new System.Windows.Forms.Button();
            this.cboAllADBCmd = new System.Windows.Forms.ComboBox();
            this.btnInstallAPP = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtFilePathName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSendCmd = new System.Windows.Forms.Button();
            this.txtCustomCmd = new System.Windows.Forms.TextBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnClearCmd = new System.Windows.Forms.Button();
            this.btnUninstall = new System.Windows.Forms.Button();
            this.gbSoftware = new System.Windows.Forms.GroupBox();
            this.rboThird = new System.Windows.Forms.RadioButton();
            this.rboSystem = new System.Windows.Forms.RadioButton();
            this.rboAll = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSystemAPP = new System.Windows.Forms.ComboBox();
            this.txtAPPCmd = new System.Windows.Forms.TextBox();
            this.btnGEAPP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.btnGetDevice = new System.Windows.Forms.Button();
            this.btnStartADB = new System.Windows.Forms.Button();
            this.btnADBVersion = new System.Windows.Forms.Button();
            this.txtListInfo = new System.Windows.Forms.TextBox();
            this.ofdSelctAPK = new System.Windows.Forms.OpenFileDialog();
            this.statusBar.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.gbSoftware.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusBar.Location = new System.Drawing.Point(0, 544);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(792, 22);
            this.statusBar.TabIndex = 6;
            this.statusBar.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(143, 17);
            this.toolStripStatusLabel1.Text = "Email:zhong7556@163.com";
            // 
            // toolBar
            // 
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(792, 25);
            this.toolBar.TabIndex = 7;
            this.toolBar.Text = "toolStrip1";
            // 
            // panelRight
            // 
            this.panelRight.AutoScroll = true;
            this.panelRight.Controls.Add(this.cboSaveData);
            this.panelRight.Controls.Add(this.btnStopADB);
            this.panelRight.Controls.Add(this.cboAllADBCmd);
            this.panelRight.Controls.Add(this.btnInstallAPP);
            this.panelRight.Controls.Add(this.btnSelectFile);
            this.panelRight.Controls.Add(this.txtFilePathName);
            this.panelRight.Controls.Add(this.label5);
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Controls.Add(this.txtOS);
            this.panelRight.Controls.Add(this.panel1);
            this.panelRight.Controls.Add(this.btnSendCmd);
            this.panelRight.Controls.Add(this.txtCustomCmd);
            this.panelRight.Controls.Add(this.btnAbout);
            this.panelRight.Controls.Add(this.btnClearCmd);
            this.panelRight.Controls.Add(this.btnUninstall);
            this.panelRight.Controls.Add(this.gbSoftware);
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Controls.Add(this.cboSystemAPP);
            this.panelRight.Controls.Add(this.txtAPPCmd);
            this.panelRight.Controls.Add(this.btnGEAPP);
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Controls.Add(this.label1);
            this.panelRight.Controls.Add(this.txtDeviceName);
            this.panelRight.Controls.Add(this.cboDevice);
            this.panelRight.Controls.Add(this.btnGetDevice);
            this.panelRight.Controls.Add(this.btnStartADB);
            this.panelRight.Controls.Add(this.btnADBVersion);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(541, 25);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(251, 519);
            this.panelRight.TabIndex = 9;
            // 
            // cboSaveData
            // 
            this.cboSaveData.AutoSize = true;
            this.cboSaveData.Checked = true;
            this.cboSaveData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboSaveData.Location = new System.Drawing.Point(7, 348);
            this.cboSaveData.Name = "cboSaveData";
            this.cboSaveData.Size = new System.Drawing.Size(108, 16);
            this.cboSaveData.TabIndex = 31;
            this.cboSaveData.Text = "保留数据和缓存";
            this.cboSaveData.UseVisualStyleBackColor = true;
            // 
            // btnStopADB
            // 
            this.btnStopADB.Location = new System.Drawing.Point(4, 105);
            this.btnStopADB.Name = "btnStopADB";
            this.btnStopADB.Size = new System.Drawing.Size(120, 23);
            this.btnStopADB.TabIndex = 30;
            this.btnStopADB.Text = "停止ADB服务";
            this.btnStopADB.UseVisualStyleBackColor = true;
            this.btnStopADB.Click += new System.EventHandler(this.btnStopADB_Click);
            // 
            // cboAllADBCmd
            // 
            this.cboAllADBCmd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAllADBCmd.FormattingEnabled = true;
            this.cboAllADBCmd.Location = new System.Drawing.Point(7, 35);
            this.cboAllADBCmd.Name = "cboAllADBCmd";
            this.cboAllADBCmd.Size = new System.Drawing.Size(238, 20);
            this.cboAllADBCmd.TabIndex = 29;
            this.cboAllADBCmd.SelectedIndexChanged += new System.EventHandler(this.cboAllADBCmd_SelectedIndexChanged);
            // 
            // btnInstallAPP
            // 
            this.btnInstallAPP.Location = new System.Drawing.Point(117, 425);
            this.btnInstallAPP.Name = "btnInstallAPP";
            this.btnInstallAPP.Size = new System.Drawing.Size(131, 23);
            this.btnInstallAPP.TabIndex = 28;
            this.btnInstallAPP.Text = "安装选择的软件";
            this.btnInstallAPP.UseVisualStyleBackColor = true;
            this.btnInstallAPP.Click += new System.EventHandler(this.btnInstallAPP_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(204, 381);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(44, 41);
            this.btnSelectFile.TabIndex = 27;
            this.btnSelectFile.Text = "选择";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtFilePathName
            // 
            this.txtFilePathName.Location = new System.Drawing.Point(6, 383);
            this.txtFilePathName.Multiline = true;
            this.txtFilePathName.Name = "txtFilePathName";
            this.txtFilePathName.Size = new System.Drawing.Size(192, 39);
            this.txtFilePathName.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "文件名:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "操作系统:";
            // 
            // txtOS
            // 
            this.txtOS.Location = new System.Drawing.Point(67, 213);
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(181, 21);
            this.txtOS.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(6, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 1);
            this.panel1.TabIndex = 22;
            // 
            // btnSendCmd
            // 
            this.btnSendCmd.Location = new System.Drawing.Point(171, 61);
            this.btnSendCmd.Name = "btnSendCmd";
            this.btnSendCmd.Size = new System.Drawing.Size(74, 38);
            this.btnSendCmd.TabIndex = 21;
            this.btnSendCmd.Text = "发送指令";
            this.btnSendCmd.UseVisualStyleBackColor = true;
            this.btnSendCmd.Click += new System.EventHandler(this.btnSendCmd_Click);
            // 
            // txtCustomCmd
            // 
            this.txtCustomCmd.Location = new System.Drawing.Point(6, 61);
            this.txtCustomCmd.Multiline = true;
            this.txtCustomCmd.Name = "txtCustomCmd";
            this.txtCustomCmd.Size = new System.Drawing.Size(162, 38);
            this.txtCustomCmd.TabIndex = 20;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(171, 4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 19;
            this.btnAbout.Text = "帮助";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnClearCmd
            // 
            this.btnClearCmd.Location = new System.Drawing.Point(7, 4);
            this.btnClearCmd.Name = "btnClearCmd";
            this.btnClearCmd.Size = new System.Drawing.Size(162, 23);
            this.btnClearCmd.TabIndex = 18;
            this.btnClearCmd.Text = "清空列表信息";
            this.btnClearCmd.UseVisualStyleBackColor = true;
            this.btnClearCmd.Click += new System.EventHandler(this.btnClearCmd_Click);
            // 
            // btnUninstall
            // 
            this.btnUninstall.Location = new System.Drawing.Point(117, 345);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(131, 23);
            this.btnUninstall.TabIndex = 16;
            this.btnUninstall.Text = "卸载选择的软件";
            this.btnUninstall.UseVisualStyleBackColor = true;
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            // 
            // gbSoftware
            // 
            this.gbSoftware.Controls.Add(this.rboThird);
            this.gbSoftware.Controls.Add(this.rboSystem);
            this.gbSoftware.Controls.Add(this.rboAll);
            this.gbSoftware.Location = new System.Drawing.Point(6, 237);
            this.gbSoftware.Name = "gbSoftware";
            this.gbSoftware.Size = new System.Drawing.Size(242, 36);
            this.gbSoftware.TabIndex = 15;
            this.gbSoftware.TabStop = false;
            // 
            // rboThird
            // 
            this.rboThird.AutoSize = true;
            this.rboThird.Checked = true;
            this.rboThird.Location = new System.Drawing.Point(172, 14);
            this.rboThird.Name = "rboThird";
            this.rboThird.Size = new System.Drawing.Size(59, 16);
            this.rboThird.TabIndex = 2;
            this.rboThird.TabStop = true;
            this.rboThird.Text = "第三方";
            this.rboThird.UseVisualStyleBackColor = true;
            this.rboThird.CheckedChanged += new System.EventHandler(this.rboThird_CheckedChanged);
            // 
            // rboSystem
            // 
            this.rboSystem.AutoSize = true;
            this.rboSystem.Location = new System.Drawing.Point(80, 14);
            this.rboSystem.Name = "rboSystem";
            this.rboSystem.Size = new System.Drawing.Size(71, 16);
            this.rboSystem.TabIndex = 1;
            this.rboSystem.Text = "系统预装";
            this.rboSystem.UseVisualStyleBackColor = true;
            this.rboSystem.CheckedChanged += new System.EventHandler(this.rboSystem_CheckedChanged);
            // 
            // rboAll
            // 
            this.rboAll.AutoSize = true;
            this.rboAll.Location = new System.Drawing.Point(13, 14);
            this.rboAll.Name = "rboAll";
            this.rboAll.Size = new System.Drawing.Size(47, 16);
            this.rboAll.TabIndex = 0;
            this.rboAll.Text = "所有";
            this.rboAll.UseVisualStyleBackColor = true;
            this.rboAll.CheckedChanged += new System.EventHandler(this.rboAll_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "软件包名:";
            // 
            // cboSystemAPP
            // 
            this.cboSystemAPP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSystemAPP.FormattingEnabled = true;
            this.cboSystemAPP.Location = new System.Drawing.Point(6, 321);
            this.cboSystemAPP.Name = "cboSystemAPP";
            this.cboSystemAPP.Size = new System.Drawing.Size(242, 20);
            this.cboSystemAPP.TabIndex = 13;
            // 
            // txtAPPCmd
            // 
            this.txtAPPCmd.Location = new System.Drawing.Point(6, 279);
            this.txtAPPCmd.Name = "txtAPPCmd";
            this.txtAPPCmd.Size = new System.Drawing.Size(166, 21);
            this.txtAPPCmd.TabIndex = 12;
            this.txtAPPCmd.Text = "shell pm list packages -3";
            // 
            // btnGEAPP
            // 
            this.btnGEAPP.Location = new System.Drawing.Point(178, 278);
            this.btnGEAPP.Name = "btnGEAPP";
            this.btnGEAPP.Size = new System.Drawing.Size(70, 23);
            this.btnGEAPP.TabIndex = 11;
            this.btnGEAPP.Text = "获取软件";
            this.btnGEAPP.UseVisualStyleBackColor = true;
            this.btnGEAPP.Click += new System.EventHandler(this.btnGEAPP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "设备名称:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "设备序号:";
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(67, 186);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(181, 21);
            this.txtDeviceName.TabIndex = 8;
            // 
            // cboDevice
            // 
            this.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(67, 160);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(181, 20);
            this.cboDevice.TabIndex = 7;
            this.cboDevice.SelectedIndexChanged += new System.EventHandler(this.cboDevice_SelectedIndexChanged);
            // 
            // btnGetDevice
            // 
            this.btnGetDevice.Location = new System.Drawing.Point(128, 132);
            this.btnGetDevice.Name = "btnGetDevice";
            this.btnGetDevice.Size = new System.Drawing.Size(120, 23);
            this.btnGetDevice.TabIndex = 4;
            this.btnGetDevice.Text = "获取连接设备";
            this.btnGetDevice.UseVisualStyleBackColor = true;
            this.btnGetDevice.Click += new System.EventHandler(this.btnGetDevice_Click);
            // 
            // btnStartADB
            // 
            this.btnStartADB.Location = new System.Drawing.Point(128, 105);
            this.btnStartADB.Name = "btnStartADB";
            this.btnStartADB.Size = new System.Drawing.Size(120, 23);
            this.btnStartADB.TabIndex = 2;
            this.btnStartADB.Text = "启动ADB服务";
            this.btnStartADB.UseVisualStyleBackColor = true;
            this.btnStartADB.Click += new System.EventHandler(this.btnStartADB_Click);
            // 
            // btnADBVersion
            // 
            this.btnADBVersion.Location = new System.Drawing.Point(4, 132);
            this.btnADBVersion.Name = "btnADBVersion";
            this.btnADBVersion.Size = new System.Drawing.Size(120, 23);
            this.btnADBVersion.TabIndex = 1;
            this.btnADBVersion.Text = "ADB版本";
            this.btnADBVersion.UseVisualStyleBackColor = true;
            this.btnADBVersion.Click += new System.EventHandler(this.btnADBVersion_Click);
            // 
            // txtListInfo
            // 
            this.txtListInfo.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtListInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtListInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtListInfo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtListInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.txtListInfo.Location = new System.Drawing.Point(0, 25);
            this.txtListInfo.Multiline = true;
            this.txtListInfo.Name = "txtListInfo";
            this.txtListInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtListInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtListInfo.Size = new System.Drawing.Size(541, 519);
            this.txtListInfo.TabIndex = 10;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.txtListInfo);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.statusBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "ADBTool";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.gbSoftware.ResumeLayout(false);
            this.gbSoftware.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnClearCmd;
        private System.Windows.Forms.Button btnUninstall;
        private System.Windows.Forms.GroupBox gbSoftware;
        private System.Windows.Forms.RadioButton rboThird;
        private System.Windows.Forms.RadioButton rboSystem;
        private System.Windows.Forms.RadioButton rboAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSystemAPP;
        private System.Windows.Forms.TextBox txtAPPCmd;
        private System.Windows.Forms.Button btnGEAPP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.ComboBox cboDevice;
        private System.Windows.Forms.Button btnGetDevice;
        private System.Windows.Forms.Button btnStartADB;
        private System.Windows.Forms.Button btnADBVersion;
        private System.Windows.Forms.TextBox txtListInfo;
        private System.Windows.Forms.TextBox txtCustomCmd;
        private System.Windows.Forms.Button btnSendCmd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFilePathName;
        private System.Windows.Forms.Button btnInstallAPP;
        private System.Windows.Forms.OpenFileDialog ofdSelctAPK;
        private System.Windows.Forms.ComboBox cboAllADBCmd;
        private System.Windows.Forms.Button btnStopADB;
        private System.Windows.Forms.CheckBox cboSaveData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

