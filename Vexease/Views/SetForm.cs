using System;
using System.Windows.Forms;

namespace Vexease.Views
{
    /// <inheritdoc />
    /// <summary>
    /// </summary>
    public partial class SetForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public string Title,Lbl,NewText;
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        public SetForm(string title,string lbl)
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Title = title;
            Lbl = lbl;
        }

        private void Set_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;//最大化不可用
            MinimizeBox = false;//最小化不可用
            FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = Title;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            NewText = TxtBoxProc.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
