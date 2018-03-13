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
    public partial class ModificationForm : Form
    {

        public ModificationForm(string[] add,string [] del)
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void ModificationForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;//最大化不可用
            MinimizeBox = false;//最小化不可用
            // ShowInTaskbar = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;//不可调整大小。可包括控件菜单栏、标题栏、“最大化”按钮和“最小化”按钮。只能使用“最大化”和“最小化”按钮改变大小。创建单线边框。
          
        }
    }
}
