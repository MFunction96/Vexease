using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CommunalComputerManager.Data;

namespace CommunalComputerManager.Views
{
    public partial class User : Form
    {

        public DataContext RegCol { get; }

        public User()
        {
            InitializeComponent();
            RegCol = new DataContext();
        }

        private void user_switchongmode_Click(object sender, EventArgs e)
        {
            Hide();
            var login = new Login();
            login.Show();


        }

        private void User_Text_Click(object sender, EventArgs e)
        {
            Hide();
            var testform = new TestForm { RegCollections = RegCol };
            testform.Show();

        }

        private void User_Load(object sender, EventArgs e)
        {

        }
    }
}
