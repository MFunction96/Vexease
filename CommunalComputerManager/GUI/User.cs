using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommunalComputerManager.Gui
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void user_switchongmode_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
            
            
        }

        private void User_Text_Click(object sender, EventArgs e)
        {
            this.Hide();
            TestForm testform=new TestForm();
            testform.Show();

        }

        private void User_Load(object sender, EventArgs e)
        {

        }
    }
}
