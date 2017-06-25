using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADBTool
{
    public partial class FrmHelp : Form
    {
        public FrmHelp()
        {
            InitializeComponent();
        }

        private void FrmHelp_Load(object sender, EventArgs e)
        {
            this.webBrowser1.Url =new Uri(SynCommon.SynCommon.GetFilePath("HelpFile\\adb.html"));
        }
    }
}
