using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

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
            ShowInTaskbar = false;//不在任务栏上显示
            FormBorderStyle = FormBorderStyle.FixedSingle;//不可调整大小。可包括控件菜单栏、标题栏、“最大化”按钮和“最小化”按钮。只能使用“最大化”和“最小化”按钮改变大小。创建单线边框。

        }

        /*用户界面可以关闭
          protected override void OnClosing(CancelEventArgs e)
         {

            // DialogResult result = MessageBox.Show("当前为用户状态，不能自主终止程序，是否隐藏窗口，最小化到系统托盘？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.None);

             if(MessageBox.Show("当前为用户状态，不能自主终止程序，是否隐藏窗口，最小化到系统托盘？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.None) ==DialogResult.Yes)
             {
                 e.Cancel = true;
                 WindowState = FormWindowState.Minimized;
                 NotifyIcon.Visible = true;//托盘图标可见
             }
             else 
             {
                 e.Cancel = true;
             }
             base.OnClosing(e);
         }

              */

        private void BtnSwitchToAdmMode_Click(object sender, EventArgs e)
        {
            Hide();
            var loginform = new LoginForm
            {
                ShowIcon = true
            };
            loginform.Show();
            
        }

       
    }
}
