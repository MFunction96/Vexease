using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Vexease.Controllers.Account;
using Vexease.Controllers.Windows;
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
            ControlBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;//不可调整大小。可包括控件菜单栏、标题栏、“最大化”按钮和“最小化”按钮。只能使用“最大化”和“最小化”按钮改变大小。创建单线边框。
          ;          
            TxtPwd.ForeColor = Color.FromArgb(255,128,128,128);        
            TxtPwd.Text = "请输入密码！";
            
        }
        

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (PwdCtrl.Verify(TxtPwd.Text))
            {

            }

            var admform = new AdmForm();
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
            ViewMethod.PwdSet(TxtPwd, "NewEnter");
        }

        private void TxtPwd_Leave(object sender, EventArgs e)
        {
            ViewMethod.PwdSet(TxtPwd, "NewLeave");
        }
        
        //“忘记密码？”点击事件
        private void LblForgetPwd_Click(object sender, EventArgs e)
        {

        }

       
        private void BtnPwdChange_Click(object sender, EventArgs e)
        {
           
        }

        private void TxtPwd_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
