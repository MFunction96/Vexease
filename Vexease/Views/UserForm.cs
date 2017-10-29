using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Vexease.Controllers.ViewCtrl;
namespace Vexease.Views
{
    public partial class UserForm : Form
    {
       
        public UserForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
           
        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;//最大化不可用
            MinimizeBox = false;//最小化不可用
            //ControlBox = false;//上面三个按钮隐藏,以后用...
            //ShowInTaskbar = false;//不在任务栏上显示
            FormBorderStyle = FormBorderStyle.FixedSingle;//不可调整大小。可包括控件菜单栏、标题栏、“最大化”按钮和“最小化”按钮。只能使用“最大化”和“最小化”按钮改变大小。创建单线边框。
            ViewMethod.Colwidth3(LvUser);
            ViewMethod.StatusChange(LvUser);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            // DialogResult result = MessageBox.Show("当前为用户状态，不能自主终止程序，是否隐藏窗口，最小化到系统托盘？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.None);

            Application.DoEvents();
            ViewMethod.CloseTips(this);
            base.OnClosing(e);
        }

        private void BtnSwitchToAdmMode_Click(object sender, EventArgs e)
        {

            var loginform = new LoginForm();            
            loginform.Show();
            Hide();
           
        }

        private void LblTest_Click(object sender, EventArgs e)
        {
            var form = new TestForm();
            form.Show();
            Close();
        }
    }
}
