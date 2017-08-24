using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vexease.Views;
using CCWin;

namespace Vexease.Views
{
    //不同方式一个是拖进去，一个是看路径
    //0.0不对的话，欢迎返工
    public partial class BandWList : CCSkinMain
    {
        public BandWList()
        {
            InitializeComponent();
        }

        private void BandWList_btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
            Modifying_bandwist modifying = new Modifying_bandwist();
            modifying.Show();
        }

        private void BandWList_btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BandWList_Load(object sender, EventArgs e)
        {

        }

        private void BandWList_lbl_whitelist_Click(object sender, EventArgs e)
        {

        }
    }
}
