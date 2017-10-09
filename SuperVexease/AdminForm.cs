using Microsoft.Win32;
using System;
using System.Windows.Forms;
using Vexease.Controllers.Crypt;
using Vexease.Controllers.Reg;
using Vexease.Models.Registrys;
using Vexease.Models.Enums;

namespace SuperVexease
{
    public partial class AdminForm : Form
    {

        private RegKey Password { get; set; }

        public AdminForm()
        {
            InitializeComponent();
            RefrushPwd();
        }

        private void BtnSetPwd_Click(object sender, EventArgs e)
        {
            if (TBSetPwd.Text != string.Empty && TBSetPwd.Text == TBConfirmPwd.Text)
            {
                RegCtrl.RegSetValue(new RegKey(Password.HKey, Password.LpSubKey, string.Empty, RegistryValueKind.String, @"Vexease"));
                RegCtrl.RegSetValue(new RegKey(Password.GetRegPath(), RegistryValueKind.String, AESCrypt.Encrypt(TBSetPwd.Text)));
                RefrushPwd();
                return;
            }
            MessageBox.Show("请输入密码！");
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RefrushPwd()
        {
            Password = RegCtrl.RegGetValue(new RegPath(REG_ROOT_KEY.HKEY_CLASSES_ROOT, @"CLSID\{1BB077CA-FEC5-479F-AA85-11CDFBFA4042}", AESCrypt.Encrypt(@"Password")));
            string pwd = Password.LpValue as string;
            if (pwd is null) LblCurrentPwd.Text = string.Empty;
            else
            {
                try
                {
                    LblCurrentPwd.Text = AESCrypt.Decrypt(pwd);
                }
                catch
                {
                    LblCurrentPwd.Text = @"密码无效！";
                }
            }
        }
    }
}
