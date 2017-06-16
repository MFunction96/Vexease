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
using CommunalComputerManager.RegOperation;
using Microsoft.Win32;

namespace CommunalComputerManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var reg = RegOpt.RegGetValue(new RegPath((UIntPtr)Common.RegOpt.REG_ROOT_KEY.HKEY_CURRENT_USER,
                @"Software\Google\Chrome\BLBeacon", @"state"));
            MessageBox.Show(reg.LpKind.ToString() + '\n' + reg.LpValue);
            reg = RegOpt.RegGetValue(new RegPath((UIntPtr)Common.RegOpt.REG_ROOT_KEY.HKEY_CURRENT_USER,
                @"Software\Google\Chrome\BLBeacon", @"version"));
            MessageBox.Show(reg.LpKind.ToString() + '\n' + reg.LpValue);
        }
    }
}