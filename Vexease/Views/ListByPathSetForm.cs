using System;
using System.Windows.Forms;
using Vexease.Controllers.ViewCtrl;
using Vexease.Models.Enums;

namespace Vexease.Views
{
    /// <inheritdoc />
    public partial class ListByPathSetForm : Form
    {
        private  ListViewSetByPath Controller { get; }
        
        /// <inheritdoc />
        public ListByPathSetForm()
        {
            Controller =new ListViewSetByPath("进程路径：");
            //屏幕中间显示
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void WListSetForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;//最大化不可用
            MinimizeBox = false;//最小化不可用
            FormBorderStyle = FormBorderStyle.FixedSingle;
            LvBListByPath.MultiSelect = false;
            LvWListByPath.MultiSelect = false;
            Controller.ListLoadB(LvBListByPath);
            Controller.ListLoadW(LvWListByPath);
        }
      
       

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Controller.SetCompare(LvBListByPath,LvWListByPath);
           if(Controller.Flag) Close();
        }

        private void BtnNewBItem_Click(object sender, EventArgs e)
        {
            Controller.NewItem(LvBListByPath);
        }

        private void BtnEditBItem_Click(object sender, EventArgs e)
        {
            Controller.EditItem(LvBListByPath);
        }

        private void BtnDeleteBItem_Click(object sender, EventArgs e)
        {
            Controller.DelItem(LvBListByPath);
        }

        private void BtnNewWItem_Click(object sender, EventArgs e)
        {
            Controller.NewItem(LvWListByPath);
        }

        private void BtnEditWItem_Click(object sender, EventArgs e)
        {
            Controller.EditItem(LvWListByPath);
        }

        private void BtnDeleteWItem_Click(object sender, EventArgs e)
        {
            Controller.DelItem(LvWListByPath);
        }
    }
}
