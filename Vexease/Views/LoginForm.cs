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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Close();
            var admform = new AdmForm
            {
                StartPosition = FormStartPosition.CenterScreen,
                ShowIcon = true
            };
            admform.Show();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
            var userForm = new UserForm()
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            userForm.ShowIcon = true;
            userForm.Show();

        }
    }
}
