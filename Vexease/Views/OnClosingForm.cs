using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Vexease.Views
{
    public partial class OnClosingForm : Form
    {
        public int t=2;
        public OnClosingForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
           
        }

        private void OnClosingForm_Load(object sender, EventArgs e)
        {
            // FormBorderStyle = FormBorderStyle.None;//隐藏边框
            MaximizeBox = false;//最大化不可用
            MinimizeBox = false;//最小化不可用
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
           
            if (RdoMin.Checked == true)
            {
                t = 0;
                Hide();
            }
            else if (RdoClose.Checked == true)
            {
                t = 1;
               
                Hide();
            }      
        }
    }
}
