using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vexease.Data;

namespace Vexease.Views
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            //BtnReg.Text = DataContext.Registry.CheckStatus() ? @"已禁用" : @"已启用";
            BtnReg.Text = DataContext.SysDriver.CheckStatus() ? @"已禁用" : @"已启用";
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            BtnReg.Text = DataContext.SysDriver.SwapStatus() ? @"已禁用" : @"已启用";
        }
    }
}
