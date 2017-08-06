using System;
using System.Windows.Forms;
using CommunalComputerManager.Controllers.ProcCtrl;
using CommunalComputerManager.Controllers.RegCtrl;
using CommunalComputerManager.Controllers.Status;
using CommunalComputerManager.Data;
using CommunalComputerManager.Models.Enums;
using CommunalComputerManager.Models.Registrys;
using CommunalComputerManager.Models.Structures;

namespace CommunalComputerManager.Views
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


        public TestForm()
        {
            InitializeComponent();
            this.ControlBox = false;   // 设置不出现关闭按钮
        }

        private void adm_conctrlpannelPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MyButtonCheck1_Load(object sender, EventArgs e)
        {

        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            Registry = new Status(RegCollections.Registry, adm_registry_now_state, button8);
            Registry.CheckStatus();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //杀掉程序啊程序
            Environment.Exit(Environment.ExitCode);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Registry.SwapStatus();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var process = ProcCtrl.CreateProcessEx(null , @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe");
        }
    }


}
