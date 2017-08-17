using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vexease.Views;

namespace Vexease.Views
{
    public partial class BandWList : Form
    {
        public BandWList()
        {
            InitializeComponent();
        }

        private void BandWList_btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BandWList_btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
