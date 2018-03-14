using System;
using System.Text;
using System.Windows.Forms;
using Vexease.Controllers.ViewCtrl;
namespace Vexease.Views
{
    /// <inheritdoc />
    public partial class WListSetForm : Form
    {
        private readonly Form _form;
        private  WListSetFormCtrl Controller { get; }
        /// <inheritdoc />
        public WListSetForm(Form form)
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            _form = form;
            Controller =new WListSetFormCtrl();
        }

        private void WListSetForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;//最大化不可用
            MinimizeBox = false;//最小化不可用
           // ShowInTaskbar = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;//不可调整大小。可包括控件菜单栏、标题栏、“最大化”按钮和“最小化”按钮。只能使用“最大化”和“最小化”按钮改变大小。创建单线边框。
            LvWListByName.MultiSelect = false;
            Controller.WListCtrlLoad(LvWListByName);
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Controller.SetCompare(LvWListByName);
            if(Controller.Flag)Close();;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNewWItem_Click(object sender, EventArgs e)
        {
            Controller.NewInsertForm(LvWListByName);
          //  Controller.WListCtrlLoad(LvWListByName);
        }

        private void BtnEditWItem_Click(object sender, EventArgs e)
        {
            Controller.EditInsertForm(LvWListByName);
        }

        private void BtnDeleteWItem_Click(object sender, EventArgs e)
        {
            Controller.Del(LvWListByName);
        }
    }
}
