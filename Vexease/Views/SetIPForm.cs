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
    public partial class SetIPForm : Form
    {
        public SetIPForm()
        {
            StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            //下面还有一个BtnOk
            Visible = false;
        }

        private void SetIPForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
