using System;
using CCWin;
using Vexease.View;
namespace Vexease.Views
{
    public partial class User : CCSkinMain
    {

        public User()
        {
            InitializeComponent();
        }

        private void User_switchongmode_Click(object sender, EventArgs e)
        {
            Hide();
            var login = new Login();
            login.Show();


        }

        private void User_Text_Click(object sender, EventArgs e)
        {
            Hide();
            var testform = new TestForm();
            testform.Show();

        }
        private void User_Load(object sender, EventArgs e)
        {
            
        }

        private void User_close(object sender, EventArgs e)
        {
            //杀掉程序啊程序
            Environment.Exit(Environment.ExitCode);
        }

        private void User_taskmanagerPnl_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void BtnToNow_Click(object sender, EventArgs e)
        {
            Hide();
            var userform = new UserForm();
            userform.Show();
        }
    }
}
