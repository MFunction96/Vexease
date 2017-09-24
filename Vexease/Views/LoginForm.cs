using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vexease.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;//最大化不可用
            MinimizeBox = false;//最小化不可用
            //ControlBox = false;//上面三个按钮隐藏,以后用...
            ShowInTaskbar = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;//不可调整大小。可包括控件菜单栏、标题栏、“最大化”按钮和“最小化”按钮。只能使用“最大化”和“最小化”按钮改变大小。创建单线边框。
            TxtUserName.ForeColor = Color.FromArgb(255,128,128,128);
            TxtPwd.ForeColor = Color.FromArgb(255,128,128,128);
            TxtUserName.Text = "请输入用户名";
            TxtPwd.Text = "请输入密码";
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            var userForm = new UserForm()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            userForm.ShowIcon = true;
            userForm.Show();
            base.OnClosing(e);
        }
        private void BtnOk_Click(object sender, EventArgs e)
        {
            Close();
            var admform = new AdmForm
            {
                StartPosition = FormStartPosition.CenterScreen,
                ShowIcon = true
            };
            admform.Show();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
            var userForm = new UserForm()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            userForm.ShowIcon = true;
            userForm.Show();

        }

        private void TxtUserName_Enter(object sender, EventArgs e)
        {
            if (TxtUserName.Text == "请输入用户名"||TxtUserName.Text=="用户名不能为空！")
            {
                TxtUserName.Text = "";
                TxtUserName.ForeColor = Color.FromArgb(255, 0, 0, 0);
            }

        }

        private void TxtUserName_Leave(object sender, EventArgs e)
        {
            if (TxtUserName.Text == "")
            {
                TxtUserName.Text = "用户名不能为空！";
                TxtUserName.ForeColor = Color.FromArgb(255,240,128,128);
            }
        }

        private void TxtPwd_Enter(object sender, EventArgs e)
        {
            if (TxtPwd.Text == "请输入密码" || TxtPwd.Text == "密码不能为空！")
            {
               
                TxtPwd.Text = "";
                TxtPwd.ForeColor = Color.FromArgb(255, 0, 0, 0);
            }
        }

        private void TxtPwd_Leave(object sender, EventArgs e)
        {
            if (TxtPwd.Text == "")
            {
                TxtPwd.Text = "密码不能为空！";
                TxtPwd.ForeColor=Color.FromArgb(255,240,128,128);
            }
        }
    }
}
