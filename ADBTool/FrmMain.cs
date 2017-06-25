using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ADBTool;
using System.IO;
using ADBTool.AdbHelp;
using System.Threading;

namespace ADBTool
{
    public partial class FrmMain : Form
    {
       
        //ADB命令窗口
        CmdHelp cmdHelp = new CmdHelp();

        //帮助文档
        FrmHelp frmHelp =new FrmHelp();

        delegate void SetTextCallback(string data);

        SynchronizationContext m_SyncContext = null;

        public FrmMain()
        {
            InitializeComponent();
            m_SyncContext = SynchronizationContext.Current;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //注册事件
            CmdHelp.EventReceiveData += new CmdHelp.DelegateReceiveData(cmdHelp_EventReceiveData);
            CmdHelp.EventReceiveThreadData += new CmdHelp.DelegateReceiveThreadData(CmdHelp_EventReceiveThreadData);
            CmdHelp.EventReceiveThreadErrorData += new CmdHelp.DelegateReceiveThreadErrorData(CmdHelp_EventReceiveThreadErrorData);

            //加载所有的ADB指令
            LoadAllADBCmd();
        }

        //接收到数据
        private void cmdHelp_EventReceiveData(string data)
        {
            m_SyncContext.Post(setListData, data);

        }

        //接收错误数据
        private void CmdHelp_EventReceiveThreadErrorData(string data)
        {
            m_SyncContext.Post(setListData, data);
        }

       
        void CmdHelp_EventReceiveThreadData(string data)
        {
            m_SyncContext.Post(setListData, data);
        }

        //显示数据
        private void setListData(object data)
        {
            if (data!=null)
            {
                txtListInfo.AppendText(">>:" + data + "\r\n");
            }
        }

        //加载所有的ADB指令
        private void LoadAllADBCmd()
        {
            cboAllADBCmd.Items.Clear();
            List<string> listAllADBInfo=CmdAdbInfo.GetAllADBCmdList();
            for (int i = 0; i < listAllADBInfo.Count; i++)
            {
                cboAllADBCmd.Items.Add(listAllADBInfo[i]);
            }
            if (cboAllADBCmd.Items.Count > 0)
            {
                cboAllADBCmd.SelectedIndex = 0;
            }
        }

        //选择指令
        private void cboAllADBCmd_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCustomCmd.Text = cboAllADBCmd.SelectedItem.ToString();
        }

        //启动adb服务
        private void btnStartADB_Click(object sender, EventArgs e)
        {
            string cmdStr =CmdAdbInfo.adb_start_server;
            ShowSendCmdInfo(cmdStr);
            cmdHelp.SendAdbCmd(cmdStr);
        }

        //停止adb服务
        private void btnStopADB_Click(object sender, EventArgs e)
        {
            string cmdStr = CmdAdbInfo.adb_kill_server;
            ShowSendCmdInfo(cmdStr);
            cmdHelp.SendAdbCmd(cmdStr);
        }

        //获取ADB版本
        private void btnADBVersion_Click(object sender, EventArgs e)
        {
            string cmdStr = CmdAdbInfo.adb_version;
            ShowSendCmdInfo(cmdStr);
            cmdHelp.SendAdbCmd(cmdStr);
        }

        //获取设备列表
        private void btnGetDevice_Click(object sender, EventArgs e)
        {
            string cmdStr = CmdAdbInfo.adb_devices;
            ShowSendCmdInfo(cmdStr);
            string[] deviceInfo=cmdHelp.GetDevices(cmdStr);
            cboDevice.Items.Clear();
            for (int i = 0; i < deviceInfo.Length; i++)
            {
                cboDevice.Items.Add(deviceInfo[i]); ;
            }
            if (cboDevice.Items.Count > 0)
            {
                cboDevice.SelectedIndex = 0;
            }
        }

        //获取设备信息
        private void cboDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            var deviceNo = Convert.ToString(cboDevice.SelectedItem);
            txtDeviceName.Text =string.Format("{0} {1}"
                            , cmdHelp.GetDeviceBrand(deviceNo)
                            , cmdHelp.GetDeviceModel(deviceNo));

            txtOS.Text = string.Format("Android {0} SDK:{1}"
                            , cmdHelp.GetDeviceVersionRelease(deviceNo)
                            , cmdHelp.GetDeviceVersionSdk(deviceNo));
        }

        //获取设备软件
        private void btnGEAPP_Click(object sender, EventArgs e)
        {
            if (cboDevice.SelectedItem == null)
            {
                MessageBox.Show("请获取连接的设备并选择设备序号!");
                return;
            }

            var deviceNo = Convert.ToString(cboDevice.SelectedItem);
            string[] backStr = null;

            if (rboAll.Checked)
            {
                backStr = cmdHelp.GetAPP("-s " + deviceNo + " shell pm list packages");
            }
            if (rboSystem.Checked)
            {
                backStr = cmdHelp.GetAPP("-s " + deviceNo + " shell pm list packages -s");

            }
            if (rboThird.Checked)
            {
                backStr = cmdHelp.GetAPP("-s " + deviceNo + " shell pm list packages -3");
            }

            cboSystemAPP.Items.Clear();
            for (int i = 0; i < backStr.Length; i++)
            {
                cboSystemAPP.Items.Add(backStr[i].Split(':')[1]); ;
            }
            if (cboSystemAPP.Items.Count > 0)
            {
                cboSystemAPP.SelectedIndex = 0;
            }
        }

        private void rboAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rboAll.Checked)
            {
                txtAPPCmd.Text = "shell pm list packages";
            }
        }

        private void rboSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (rboSystem.Checked)
            {
                txtAPPCmd.Text = "shell pm list packages -s";
            }
        }

        private void rboThird_CheckedChanged(object sender, EventArgs e)
        {
            if (rboThird.Checked)
            {
                txtAPPCmd.Text = "shell pm list packages -3";
            }
        }

        //卸载软件
        private void btnUninstall_Click(object sender, EventArgs e)
        {
            if (cboSystemAPP.SelectedItem == null)
            {
                MessageBox.Show("请选择需要删除的软件包名!");
                return;
            }

            if (cboSaveData.Checked)
            {
                string cmdStr = CmdAdbInfo.adb_uninstall + " -k " + cboSystemAPP.SelectedItem.ToString();
                ShowSendCmdInfo(cmdStr);
                cmdHelp.SendAdbCmd(cmdStr);
            }
            else
            {
                string cmdStr = CmdAdbInfo.adb_uninstall + " " + cboSystemAPP.SelectedItem.ToString();
                ShowSendCmdInfo(cmdStr);
                cmdHelp.SendAdbCmd(cmdStr);
            }
        }

        //安装软件
        private void btnInstallAPP_Click(object sender, EventArgs e)
        {
            if (txtFilePathName.Text.Trim().Length<=0)
            {
                MessageBox.Show("请选择需要删除的软件包名!");
                return;
            }

            if (!txtFilePathName.Text.Trim().EndsWith(".apk"))
            {
                MessageBox.Show("请选择.apk文件");
                return;
            }

            string cmdStr = CmdAdbInfo.adb_install + " " + txtFilePathName.Text.Trim();
            ShowSendCmdInfo(cmdStr);
            cmdHelp.SendAdbCmd(cmdStr);
        }

        private void btnClearCmd_Click(object sender, EventArgs e)
        {
            txtListInfo.Clear();
        }

        //发送自定义指令
        private void btnSendCmd_Click(object sender, EventArgs e)
        {
            string cmdStr = txtCustomCmd.Text.Trim();
            ShowSendCmdInfo(cmdStr);
            cmdHelp.SendAdbCmd(cmdStr);
        }

        //显示发送的指令
        private void ShowSendCmdInfo(string cmdStr)
        {
            txtListInfo.AppendText("-->:"+cmdStr+"\r\n");
        }

        private void ShowInfo(string info)
        {
            txtListInfo.AppendText(">>:" + info + "\r\n");
        }

        private void ShowInfo(string[] info)
        {
            for (int i = 0; i < info.Length; i++)
            {
                txtListInfo.AppendText(">>:" + info[i] + "\r\n");
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            ofdSelctAPK.ShowDialog();
            txtFilePathName.Text=ofdSelctAPK.FileName;
        }


        //显示帮助文档
        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (frmHelp.IsDisposed)
            {
                frmHelp = new FrmHelp();
            }
            frmHelp.Show();
            frmHelp.Focus();
            frmHelp.TopMost = true;
        }
    }
}
