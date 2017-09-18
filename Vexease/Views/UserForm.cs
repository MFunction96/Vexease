using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Vexease.Views
{
    public partial class UserForm : Form
    {
       
        public UserForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
           
        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            
        }
        
        private void BtnSwitchToAdmMode_Click(object sender, EventArgs e)
        {
            Hide();
            var loginform = new LoginForm
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            loginform.ShowDialog();
        }

       
    }
}
