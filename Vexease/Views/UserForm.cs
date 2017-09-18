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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void BtnSwitchToAdmMode_Click(object sender, EventArgs e)
        {
            Hide();
            var loginform = new LoginForm();
            loginform.Show();
        }
    }
}
