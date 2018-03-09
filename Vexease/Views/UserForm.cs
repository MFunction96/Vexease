using System;
using System.ComponentModel;
using System.Windows.Forms;
using Vexease.Controllers.ViewCtrl;

namespace Vexease.Views
{
    /// <inheritdoc />
    /// <summary />
    public partial class UserForm : Form
    {
    
        private UserFormCtrl Controller { get; }

        /// <inheritdoc />
        /// <summary />
        public UserForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
         
            Controller = new UserFormCtrl();
           
        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;//最大化不可用
            MinimizeBox = false;//最小化不可用
            FormBorderStyle = FormBorderStyle.FixedSingle;//不可调整大小。可包括控件菜单栏、标题栏、“最大化”按钮和“最小化”按钮。只能使用“最大化”和“最小化”按钮改变大小。创建单线边框。
            Controller.Colwidth3(LvUser);
            Controller.StatusChange(LvUser);
        }

        /// <summary />
        /// <param name="e"></param>
        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            // DialogResult result = MessageBox.Show("当前为用户状态，不能自主终止程序，是否隐藏窗口，最小化到系统托盘？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.None);

            Application.DoEvents();
            Controller.CloseForm(this);
            base.OnClosing(e);
        }

        private void BtnSwitchToAdmMode_Click(object sender, EventArgs e)
        {

            var loginform = new LoginForm(this);            
            loginform.Show();
            Hide();
           
        }

        
    }
}
