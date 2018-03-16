using System;
using System.Windows.Forms;
using Vexease.Controllers.ViewCtrl;
using Vexease.Models.Enums;

#pragma warning disable 1591

namespace Vexease.Views
{
    public partial class BandWListSetForm : Form
    {
        private readonly Form _form;
        private  ListViewSetByName Controller { get; }
        public BandWListSetForm(Form form)
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            _form = form;
            Controller = new ListViewSetByName(TASK_TYPE_FLAGS.DISALLOW_TASK_NAME, "进程名称：");
        }

        private void BandWListSetForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;//最大化不可用
            MinimizeBox = false;//最小化不可用
            FormBorderStyle = FormBorderStyle.FixedSingle;//不可调整大小。可包括控件菜单栏、标题栏、“最大化”按钮和“最小化”按钮。只能使用“最大化”和“最小化”按钮改变大小。创建单线边框。
            LvBListByName.MultiSelect = false;
            Controller.ListLoad(LvBListByName,TASK_TYPE_FLAGS.DISALLOW_TASK_NAME);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Controller.SetCompare(LvBListByName);
            if (Controller.Flag) Close(); 
        }

        private void BtnNewBItem_Click(object sender, EventArgs e)
        {
            Controller.NewItem(LvBListByName);
        }

        private void BtnEditBitem_Click(object sender, EventArgs e)
        {
            Controller.EditItem(LvBListByName);
        }

        private void BtnDeleteBItem_Click(object sender, EventArgs e)
        {
            Controller.DelItem(LvBListByName);
        }
    }
}
