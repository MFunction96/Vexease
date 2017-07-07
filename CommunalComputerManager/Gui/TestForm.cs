using System;
using System.Windows.Forms;

namespace CommunalComputerManager.Gui
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            this.ControlBox = false;   // 设置不出现关闭按钮
        }

        private void adm_conctrlpannelPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MyButtonCheck1_Load(object sender, EventArgs e)
        {

        }

        private void TestForm_Load(object sender, EventArgs e)
        {

           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //杀掉程序啊程序
            Environment.Exit(Environment.ExitCode);
        }
    }
   

}
