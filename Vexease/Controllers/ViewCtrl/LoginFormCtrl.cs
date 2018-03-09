using System;
using System.Drawing;
using System.Windows.Forms;
using Vexease.Data;
using Vexease.Properties;
using Vexease.Views;
namespace Vexease.Controllers.ViewCtrl
{
   /// <summary>
   /// 
   /// </summary>
   public class LoginFormCtrl
    {

        ///<summary>
        /// 密码输入框提示设置
        /// </summary>
        public void PwdSet(MaskedTextBox textBox, String status)
        {
            if (status == "NewEnter")
            {
                textBox.PasswordChar = '*'; if (textBox.Text == Resources.LoginForm_TxtPwd_input_ || textBox.Text == Resources.LoginFormCtrl_PwdSet_BeNull)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            }
            if (status == "ReEnter")
            {
                textBox.PasswordChar = '*';
                if (textBox.Text == Resources.LoginFormCtrl_PwdSet_NotSimible || textBox.Text == Resources.LoginFormCtrl_PwdSet_InputAgain)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            }
            if (status == "ReLeave")
            {
                textBox.PasswordChar = new char();
                if (textBox.Text != textBox.Text)
                {
                    textBox.ForeColor = Color.Gray;
                    textBox.Text = Resources.LoginFormCtrl_PwdSet_NotSimible;
                }
            }
            if (status == "NewLeave")
            {
                textBox.PasswordChar = new char();
                if (textBox.Text == "")
                {
                    textBox.ForeColor = Color.Gray;
                    textBox.Text = Resources.LoginFormCtrl_PwdSet_BeNull;
                }
            }
        }

    }
}
