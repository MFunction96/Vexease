using System;
using System.Windows.Forms;
using Vexease.Data;
using Vexease.Properties;
using Vexease.Views;

namespace Vexease.Controllers.ViewCtrl
{
   /// <summary>
   /// 
   /// </summary>
   public  class UserFormCtrl
    {
        
      ///<summary>
      ///关闭页面
      /// </summary>
      public void CloseForm(Form form)
        {
            var onclosingForm = new OnClosingForm();
            onclosingForm.ShowDialog();
            Application.DoEvents();
            if (onclosingForm.RdoMin.Checked)
            {
                form.Hide();
                onclosingForm.Close();
            }
            else if (onclosingForm.RdoClose.Checked)
            {
                Environment.Exit(0);//彻底关掉！
            }
        }
        /// <summary>
        /// 有三列的列表计算
        /// </summary>
        /// <param name="listview"></param>
        public  void Colwidth3(ListView listview)
        {
            foreach (ColumnHeader item in listview.Columns)
            {
                switch (item.Text)
                {
                    case "名称":
                        item.Width = listview.Width / 3 - 2;
                        break;
                    case "默认状态":
                        item.Width = listview.Width / 3 - 2;
                        break;

                    case "当前状态":
                        item.Width = listview.Width / 3 - 2;
                        break;

                    default:
                        item.Width = -2;
                        break;
                }
            }
        }
        /// <summary>
        /// 状态显示
        /// </summary>
        /// <param name="listView"></param>
        public  void StatusChange(ListView listView)
        {
            if (DataContext.SysDriver.CheckStatus())
                listView.Items[0].SubItems[2].Text = Resources.UserFormCtrl_StatusChange_已禁用;
            else listView.Items[0].SubItems[2].Text = Resources.UserFormCtrl_StatusChange_启用中;

            /*Mmc
            if (DataContext.Registry.CheckStatus())
                listView.Items[1].SubItems[2].Text = "已禁用";
            else listView.Items[1].SubItems[2].Text = "启用中";*/

            if (DataContext.Registry.CheckStatus())
                listView.Items[2].SubItems[2].Text = Resources.UserFormCtrl_StatusChange_已禁用;
            else listView.Items[2].SubItems[2].Text = Resources.UserFormCtrl_StatusChange_启用中;


            if (DataContext.CtrlPal.CheckStatus())
                listView.Items[3].SubItems[2].Text = Resources.UserFormCtrl_StatusChange_已禁用;
            else listView.Items[3].SubItems[2].Text = Resources.UserFormCtrl_StatusChange_启用中;

            if (DataContext.Launcher.CheckStatus())
                listView.Items[4].SubItems[2].Text = Resources.UserFormCtrl_StatusChange_已禁用;
            else listView.Items[4].SubItems[2].Text = Resources.UserFormCtrl_StatusChange_启用中;

            if (DataContext.Taskmgr.CheckStatus())
                listView.Items[5].SubItems[2].Text = Resources.UserFormCtrl_StatusChange_已禁用;
            else listView.Items[5].SubItems[2].Text = Resources.UserFormCtrl_StatusChange_启用中;

            if (DataContext.Cmd.CheckStatus())
                listView.Items[6].SubItems[2].Text = Resources.UserFormCtrl_StatusChange_已禁用;
            else listView.Items[6].SubItems[2].Text = Resources.UserFormCtrl_StatusChange_启用中;

            if (DataContext.PwrShell.CheckStatus())
                listView.Items[7].SubItems[2].Text = Resources.UserFormCtrl_StatusChange_已禁用;
            else listView.Items[7].SubItems[2].Text = Resources.UserFormCtrl_StatusChange_启用中;

        }
    }
}
