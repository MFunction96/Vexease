using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Vexease.Controllers.ViewCtrl;
using System.Diagnostics;
using Vexease.Controllers.PInvoke;
using System.Threading;

namespace Vexease.Views
{
    public partial class UserForm : Form
    {
        /*
       正版授权部分（试用期30天）
           */
        // 公钥
        private const string kLibraryKey = "8454D0D6DE98051E290E1B6F372E6E5D0379A184C417D8C632DE3FBF024FBD15A8690F2059B7";
        public UserForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.CenterToScreen();

            //在系统启动后，呈现授权验证UI界面
            Thread thread = new Thread(InitTrial);
            thread.Start();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;//最大化不可用
            MinimizeBox = false;//最小化不可用
            //ControlBox = false;//上面三个按钮隐藏,以后用...
            //ShowInTaskbar = false;//不在任务栏上显示
            FormBorderStyle = FormBorderStyle.FixedSingle;//不可调整大小。可包括控件菜单栏、标题栏、“最大化”按钮和“最小化”按钮。只能使用“最大化”和“最小化”按钮改变大小。创建单线边框。
            ViewMethod.Colwidth3(LvUser);
            ViewMethod.StatusChange(LvUser);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            // DialogResult result = MessageBox.Show("当前为用户状态，不能自主终止程序，是否隐藏窗口，最小化到系统托盘？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.None);

            Application.DoEvents();
            ViewMethod.CloseTips(this);
            base.OnClosing(e);
        }

        private void BtnSwitchToAdmMode_Click(object sender, EventArgs e)
        {

            var loginform = new LoginForm();            
            loginform.Show();
            Hide();
           
        }


        private static void InitTrial()
        {
            try
            {
                // 系统主界面启动后等待2秒启动验证授权程序
                Thread.Sleep(2000);

                Debug.WriteLine("Debug Information-Product Starting ");

                Process process = Process.GetCurrentProcess();
                NativeMethods.InitTrial(kLibraryKey, process.MainWindowHandle);

                // To prevent your application be killed when unlicensed and trial expired
                // ReadSettingsRetStr must be called which will return 4 or grater instead of killing the app
                //
                //         uint ret = InitTrialReturn(kLibraryKey, process.MainWindowHandle);
                //
                //         if (ret >= 4)
                //         {
                //           MessageBox.Show("Invalid mode to run");
                //           // disable the application
                //           // Process.GetCurrentProcess().Kill();
                //         }

                // Let's read some licensing configuration property
                StringBuilder trialName = new StringBuilder();
                UInt32 len = (UInt32)trialName.Capacity;
                if (NativeMethods.GetPropertyValue("TrialName", trialName, ref len) == 234)
                {
                    trialName.EnsureCapacity((Int32)len);
                    NativeMethods.GetPropertyValue("TrialName", trialName, ref len);
                }

                Debug.WriteLine("TrialName=" + trialName);
            }
            catch (DllNotFoundException ex)
            {
                // 验证配置文件丢失，立刻关闭程序
                MessageBox.Show(ex.ToString());
                Process.GetCurrentProcess().Kill();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.ToString());
            }
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process process = Process.GetCurrentProcess();
                NativeMethods.DisplayRegistration(kLibraryKey, process.MainWindowHandle);
            }
            catch (DllNotFoundException ex)
            {

                MessageBox.Show(ex.ToString());
                this.Close();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.ToString());
            }
        }

    }
}
