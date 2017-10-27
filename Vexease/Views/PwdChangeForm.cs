using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vexease.Controllers.Windows;

namespace Vexease.Views
{
    public partial class PwdChangeForm : Form
    {
        public PwdChangeForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void PwdChangeForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;//最大化不可用
            MinimizeBox = false;//最小化不可用
                                //ControlBox = false;//上面三个按钮隐藏,以后用...

            FormBorderStyle = FormBorderStyle.FixedSingle;//不可调整大小。可包括控件菜单栏、标题栏、“最大化”按钮和“最小化”按钮。只能使用“最大化”和“最小化”按钮改变大小。创建单线边框。
            BtnOk.Focus();
            TxtNewPwd.ForeColor = Color.FromArgb(255, 128, 128, 128);
            TxtRe.ForeColor = Color.FromArgb(255, 128, 128, 128);
            TxtNewPwd.Text = "请输入密码！";
            TxtRe.Text = "请再次输入密码！";

        }

        private void TxtNewPwd_Enter(object sender, EventArgs e)
        {
            ViewMethod.PwdSet(TxtNewPwd, "NewEnter");
        }

        private void TxtRe_Enter(object sender, EventArgs e)
        {
            ViewMethod.PwdSet(TxtRe, "ReEnter");
        }

        private void TxtRe_Leave(object sender, EventArgs e)
        {
            ViewMethod.PwdSet(TxtRe, "ReLeave");
        }

        private void TxtNewPwd_Leave(object sender, EventArgs e)
        {
            ViewMethod.PwdSet(TxtNewPwd, "NewLeave");
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LblTitle_Click(object sender, EventArgs e)
        {

        }

        private void TxtRe_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
