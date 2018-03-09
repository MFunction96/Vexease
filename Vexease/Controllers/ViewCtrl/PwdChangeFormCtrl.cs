
using System;
using System.Drawing;
using System.Windows.Forms;
using Vexease.Properties;

namespace Vexease.Controllers.ViewCtrl
{
    /// <summary>
    /// 
    /// </summary>
    public class PwdChangeFormCtrl
    {
        ///<summary>
        /// 密码输入框提示设置
        /// </summary>
        public void PwdSet(MaskedTextBox txtnewBox,MaskedTextBox txtRe, String status)
        {
            if (status == "NewEnter")
            {
                txtnewBox.PasswordChar = '*';
                if (txtnewBox.Text == Resources.LoginForm_TxtPwd_input_ || txtnewBox.Text == Resources.LoginFormCtrl_PwdSet_BeNull)
                {
                    txtnewBox.Text = "";
                    txtnewBox.ForeColor = Color.Black;
                }
            }
            if (status == "ReEnter")
            {
                txtRe.PasswordChar = '*';
                if (txtnewBox.Text == Resources.LoginFormCtrl_PwdSet_NotSimible || txtnewBox.Text == Resources.LoginFormCtrl_PwdSet_InputAgain)
                {
                    txtRe.Text = "";
                    txtRe.ForeColor = Color.Black;
                }
            }
            if (status == "ReLeave")
            {
                txtRe.PasswordChar = new char();
                if (txtnewBox.Text != txtRe.Text)
                {
                    txtRe.ForeColor = Color.Gray;
                    txtRe.Text = Resources.LoginFormCtrl_PwdSet_NotSimible;
                }
            }
            if (status == "NewLeave")
            {
                txtnewBox.PasswordChar = new char();
                if (txtnewBox.Text == "")
                {
                    txtnewBox.ForeColor = Color.Gray;
                    txtnewBox.Text = Resources.LoginFormCtrl_PwdSet_BeNull;
                }
            }
        }
    }
}