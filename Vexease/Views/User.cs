using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vexease.Data;
using CCWin;

namespace Vexease.Views
{
    public partial class User : CCSkinMain
    {

        public DataContext RegCol { get; }

        public User()
        {
            InitializeComponent();
            RegCol = new DataContext();
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
            var testform = new TestForm { RegCollections = RegCol };
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
    }
}
