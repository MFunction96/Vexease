using System;
using System.Drawing;
using System.Windows.Forms;
using Vexease.Properties;
namespace Vexease.Controllers.ViewCtrl
{
    /// <summary>
    /// 登录界面控制器
    /// </summary>
    public class LoginFormCtrl
    {

        ///<summary>
        /// 密码输入框提示设置
        /// </summary>
        public void PwdSet(MaskedTextBox textBox, String status)
        {
            switch (status)
            {
                case "NewEnter":
                    textBox.PasswordChar = '*'; if (textBox.Text == Resources.LoginForm_TxtPwd_input_ || textBox.Text == Resources.LoginFormCtrl_PwdSet_BeNull)
                    {
                        textBox.Text = "";
                        textBox.ForeColor = Color.Black;
                    }

                    break;
                case "ReEnter":
                    textBox.PasswordChar = '*';
                    if (textBox.Text == Resources.LoginFormCtrl_PwdSet_NotSimible || textBox.Text == Resources.LoginFormCtrl_PwdSet_InputAgain)
                    {
                        textBox.Text = "";
                        textBox.ForeColor = Color.Black;
                    }

                    break;
                case "ReLeave":
                    textBox.PasswordChar = new char();
                    break;
                case "NewLeave":
                    textBox.PasswordChar = new char();
                    if (textBox.Text == "")
                    {
                        textBox.ForeColor = Color.Gray;
                        textBox.Text = Resources.LoginFormCtrl_PwdSet_BeNull;
                    }

                    break;
            }
        }

    }
}
