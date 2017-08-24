using System;
using System.Windows.Forms;
using Vexease.Controllers.RegCtrl;
using Vexease.Models.Enums;
using Vexease.Models.Structures;
using Vexease.Controllers.ProcCtrl;
using Vexease.Controllers.Status;
using Vexease.Data;
using Vexease.Models.Registrys;

namespace Vexease.Views
{
    public partial class TestForm : Form
    {
        private class Status : RegStatus
        {

            private readonly Label _tipLabel;

            private readonly Button _swapButton;

            public Status(RegStore[] onRegStores, RegStore[] offRegStores, Label tipLabel, Button swapButton) :
                base(onRegStores, offRegStores)
            {
                _tipLabel = tipLabel;
                _swapButton = swapButton;
            }

            public Status(RegStatus regStatus, Label tipLabel, Button swapButton) :
                base(regStatus.OnRegStores, regStatus.OffRegStores)
            {
                _tipLabel = tipLabel;
                _swapButton = swapButton;
            }

            public new void CheckStatus()
            {
                if (base.CheckStatus())
                {
                    _tipLabel.Text = @"启用";
                    _swapButton.Text = @"禁用";
                }
                else
                {
                    _tipLabel.Text = @"禁用";
                    _swapButton.Text = @"启用";
                }
            }

            public new void SwapStatus()
            {
                if (base.SwapStatus())
                {
                    _tipLabel.Text = @"启用";
                    _swapButton.Text = @"禁用";
                }
                else
                {
                    _tipLabel.Text = @"禁用";
                    _swapButton.Text = @"启用";
                }
            }

        }
        public DataContext RegCollections { get; set; }
        private Status Registry { get; set; }
        private Status Mmc { get; set; }

        public TestForm()
        {
            InitializeComponent();
            this.ControlBox = false;   // 设置不出现关闭按钮
        }

        private void Adm_conctrlpannelPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MyButtonCheck1_Load(object sender, EventArgs e)
        {

        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            Registry = new Status(RegCollections.Registry, adm_registry_now_state, button8);
            Registry.CheckStatus();
            Mmc = new Status(RegCollections.Mmc, adm_console_now_state, button6);
            Mmc.CheckStatus();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            //杀掉程序啊程序
            Environment.Exit(Environment.ExitCode);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Registry.SwapStatus();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
          
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Mmc.SwapStatus();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Button13_Click(object sender, EventArgs e)
        {
            //是在这里吧？button14是我才建的设重启时间的0.0错了的话你改回来吧
            var process = ProcCtrl.CreateProcessEx(null, @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe");
        }
    }


}
