using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommunalComputerManager.Common;
using CommunalComputerManager.Gui;
using CommunalComputerManager.RegOperation;
using Microsoft.Win32;

namespace CommunalComputerManager.Gui
{
    public partial class Adm : Form
    {
        public Adm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var reg = RegOperation.RegOpt.RegGetValue(new RegPath((UIntPtr)Common.RegOpt.REG_ROOT_KEY.HKEY_CURRENT_USER,
                @"Software\Google\Chrome\BLBeacon", @"state"));
            MessageBox.Show(reg.LpKind.ToString() + '\n' + reg.LpValue);
            reg = RegOperation.RegOpt.RegGetValue(new RegPath((UIntPtr)Common.RegOpt.REG_ROOT_KEY.HKEY_CURRENT_USER,
                @"Software\Google\Chrome\BLBeacon", @"version"));
            MessageBox.Show(reg.LpKind.ToString() + '\n' + reg.LpValue);
        }

        private void Adm_Load(object sender, EventArgs e)
        {

        }

        private void Adm_btn_changedefaultfile_Click(object sender, EventArgs e)
        {
            RequestEdit requestedit = new RequestEdit();
            requestedit.Show();
        }

        private void Adm_btn_changeBandWlist_Click(object sender, EventArgs e)
        {
            BandWList bandwlist = new BandWList();
            bandwlist.Show();
        }

        private void Adm_btn_conctrlC_Click(object sender, EventArgs e)
        {

        }

        private void Adm_btn_mainpanel_Click(object sender, EventArgs e)
        {
            Adm_pnl_setIP.Hide();
            Adm_pnl_about.Hide();
            Adm_pnl_main.Show();
        }

        private void Adm_taskmanager_Click(object sender, EventArgs e)
        {

        }

        private void Adm_taskmanager_default_state_Click(object sender, EventArgs e)
        {

        }

        private void Adm_taskmanager_now_Click(object sender, EventArgs e)
        {

        }

        private void Adm_taskmanager_default_Click(object sender, EventArgs e)
        {

        }

        private void Adm_taskmanager_now_state_Click(object sender, EventArgs e)
        {

        }

        private void Adm_consolePnl_Paint(object sender, PaintEventArgs e) => BackColor = Color.FromArgb( 255, 255, 255);

        private void Adm_btn_setIP_Click(object sender, EventArgs e)
        {
            Adm_pnl_about.Hide();
            Adm_pnl_main.Hide();
            Adm_pnl_setIP.Show();
        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Adm_btn_about_Click(object sender, EventArgs e)
        {
            Adm_pnl_setIP.Hide();
            Adm_pnl_main.Hide();
            Adm_pnl_about.Show();
        }

        private void Adm_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}