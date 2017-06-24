using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommunalComputerManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_btn_login_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Close();

        }

        private void Login_btn_cancal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
