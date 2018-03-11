using System;
using System.Windows.Forms;

namespace Vexease.Views
{
    /// <inheritdoc />
    public partial class ExportForm : Form
    {
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        public ExportForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExportForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;//最大化不可用
            MinimizeBox = false;//最小化不可用
            FormBorderStyle = FormBorderStyle.FixedSingle;//不可调整大小。可包括控件菜单栏、标题栏、“最大化”按钮和“最小化”按钮。只能使用“最大化”和“最小化”按钮改变大小。创建单线边框。
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
