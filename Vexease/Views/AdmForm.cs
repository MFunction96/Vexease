using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace Vexease.Views
{
    public partial class AdmForm : Form
    {
        public AdmForm()
        {
            InitializeComponent();
            TabSet();

        }

        

        private void AdmForm_Load(object sender, EventArgs e)
        {

        }
        

        private void TlStrBtnBList_Click(object sender, EventArgs e)
        {
            int n = 0;//给个名单内名字的个数吧..

            if (PnlBList.Height == 0) { PnlBList.Height = 180; } else { PnlBList.Height = 0; }
        }

        private void TlStrBtnWList_Click(object sender, EventArgs e)
        {
            int n = 0;//给个名单内名字的个数吧..

            if (PnlWList.Height == 0) { PnlWList.Height = 180; } else { PnlWList.Height = 0; }
        }

        private void TlStrBtnBListSet_Click(object sender, EventArgs e)
        {
            Hide();
            var bListSetForm = new BandWListSetForm();
            bListSetForm.Show();
        }

        private void TlStrBtnWListSet_Click(object sender, EventArgs e)
        {
            Hide();
            var wListSetForm = new BandWListSetForm();
            wListSetForm.Show();
        }

        private void MenuSetIP_Click(object sender, EventArgs e)
        {
            Hide();
            var setIPForm = new SetIPForm();
            setIPForm.Show();
        }

        private void PnlAbout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuStripAdm_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (LvStatus.Height == 0)
            {
                LvStatus.Height = 180;
            }
            else
            {
                LvStatus.Height = 0;
            }
        }

        
    }
}
