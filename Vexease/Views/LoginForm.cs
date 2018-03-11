using System;
using System.Drawing;
using System.Windows.Forms;
using Vexease.Controllers.Account;
using Vexease.Controllers.ViewCtrl;
using Vexease.Properties;

namespace Vexease.Views
{
    /// <inheritdoc />
    /// <summary />
    public partial class LoginForm : Form
    {
        private readonly Form _form;
        private LoginFormCtrl Controller { get; }

        /// <inheritdoc />
        /// <summary />
        /// <param name="form"></param>
        public LoginForm(Form form)
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            _form = form;
            Controller = new LoginFormCtrl();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;//不可调整大小。可包括控件菜单栏、标题栏、“最大化”按钮和“最小化”按钮。只能使用“最大化”和“最小化”按钮改变大小。创建单线边框。
            TxtPwd.ForeColor = Color.Gray;
            TxtPwd.Text = Resources.LoginForm_TxtPwd_input_;

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (PwdCtrl.Verify(TxtPwd.Text))
            {

            }

            var admform = new AdmForm(this);
            admform.Show();
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            var userform = new UserForm();
            userform.Show();
            Close();
        }

        private void TxtPwd_Enter(object sender, EventArgs e)
        {
            Controller.PwdSet(TxtPwd, "NewEnter");
        }

        private void TxtPwd_Leave(object sender, EventArgs e)
        {
            Controller.PwdSet(TxtPwd, "NewLeave");
        }

        private void LblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
