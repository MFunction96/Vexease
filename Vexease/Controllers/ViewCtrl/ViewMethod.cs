using System;
using Vexease.Views;
using System.Windows.Forms;
using Vexease.Controllers.ViewCtrl;
using Vexease.Data;
namespace Vexease.Controllers.ViewCtrl
{

    /// <summary>
    /// 界面所用方法综合类
    /// </summary>
    public class ViewMethod
    {

        /// <summary>
        /// 名单.Height
        /// </summary>
        /// <param name="listView">
        /// 名单信息
        /// </param>
        public static void ListHeight(ListView listView)
        {//获取信息长度
        }
        ///<summary>
        ///通过点击checkbutton控制名单(listView)收放
        /// </summary>       
        public static void ContracAndAmplifica(ListView listView, BtnYorN btnYorN, String yorN)
        {

            if (btnYorN.Checked == true)
                listView.Height = 90;
            else
                listView.Height = 0;
        }
        /// <summary>
        /// 通过点击checkbutton控制名单(Panel)收放
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="btnYorN"></param>
        public static void ContracAndAmplifica(Panel panel, BtnYorN btnYorN, String yorN)
        {
            if (btnYorN.Checked == true)
                panel.Height = 90;
            else
                panel.Height = 0;
        }
        /// <summary>
        /// 通过点击标题控制名单（listView）收放
        /// </summary>
        /// <param name="listView"></param>
        public static void ContracAndAmplifica(ListView listView)
        {
            if (listView.Height == 0) listView.Height = 90;//ListHeight
            else listView.Height = 0;
        }
        /// <summary>
        /// 通过点击标题控制名单（panel）收放
        /// </summary>
        /// <param name="panel"></param>
        public static void ContracAndAmplifica(Panel panel)
        {
            if (panel.Height == 0) panel.Height = 90;//ListHeight
            else panel.Height = 0;
        }
        ///<summary>
        ///双击大标题
        /// </summary>
        public static void DoubleCliclLbl(Button BtnConsole, Button BtnRegustry, Button BtnPlanningTask, Button BtnCtrlPnl, Button BtnRunTool, Button BtnTaskMgr, Button BtnCmd, Button BtnPS, Button BtnProcCtrl)
        {
            if (BtnConsole.Height == 0)
            {
                BtnConsole.Height = BtnRegustry.Height =
                    BtnPlanningTask.Height = BtnCtrlPnl.Height =
                    BtnRunTool.Height = BtnTaskMgr.Height =
                    BtnCmd.Height = BtnPS.Height = BtnProcCtrl.Height = 30;
            }
            else
            {
                BtnConsole.Height = BtnRegustry.Height =
                    BtnPlanningTask.Height = BtnCtrlPnl.Height =
                    BtnRunTool.Height = BtnTaskMgr.Height =
                    BtnCmd.Height = BtnPS.Height = BtnProcCtrl.Height = 0;
            }
        }
        /// <summary>
        /// 两列列表宽度的计算
        /// </summary>
        public static void Colwidth2(ListView listview)
        {
            foreach (ColumnHeader item in listview.Columns)
            {
                switch (item.Text)
                {
                    case "默认状态":
                        item.Width = listview.Width / 2 - 5;
                        break;

                    case "当前状态":
                        item.Width = listview.Width / 2 - 5;
                        break;

                    default:
                        item.Width = -2;
                        break;
                }
            }
        }
        /// <summary>
        /// 三列列表宽度结算
        /// </summary>
        /// <param name="listview"></param>
        public static void Colwidth3(ListView listview)
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

        ///<summary>
        ///checkbutton控制的状态列表的收缩
        /// </summary>
        public static void Contraction(BtnYorN btnYorN, Panel panel, String yorN)
        {
            BtnYorNCtrl.CheckYorN(btnYorN, yorN);
            if (btnYorN.Checked == false)
                panel.Height = 0;
        }
        ///<summary>
        ///状态显示更新
        /// </summary>
        public static void StatusChange(BtnYorN btnYorN, ListView listView, String yorN)
        {

            BtnYorNCtrl.CheckYorN(btnYorN, yorN);
            if (yorN == "Mmc_Load" || yorN == "Mmc_Clicked")
            {
                listView.Items[1].SubItems[1].Text = "暂不可用";
            }
            else if (btnYorN.Checked == false)
            {
                listView.Items[1].SubItems[1].Text = "已禁用";
            }
            else
            {
                listView.Items[1].SubItems[1].Text = "启用中";
            }
        }
        public static void StatusChange(ListView listView)
        {
            if (DataContext.SysDriver.CheckStatus())
                listView.Items[0].SubItems[2].Text = "已禁用";
            else listView.Items[0].SubItems[2].Text = "启用中";

            /*Mmc
            if (DataContext.Registry.CheckStatus())
                listView.Items[1].SubItems[2].Text = "已禁用";
            else listView.Items[1].SubItems[2].Text = "启用中";*/

            if (DataContext.Registry.CheckStatus())
                listView.Items[2].SubItems[2].Text = "已禁用";
            else listView.Items[2].SubItems[2].Text = "启用中";

            
            if (DataContext.CtrlPal.CheckStatus())
                listView.Items[3].SubItems[2].Text = "已禁用";
            else listView.Items[3].SubItems[2].Text = "启用中";
            
            if (DataContext.Launcher.CheckStatus())
                listView.Items[4].SubItems[2].Text = "已禁用";
            else listView.Items[4].SubItems[2].Text = "启用中";

            if (DataContext.Taskmgr.CheckStatus())
                listView.Items[5].SubItems[2].Text = "已禁用";
            else listView.Items[5].SubItems[2].Text = "启用中";

            if (DataContext.Cmd.CheckStatus())
                listView.Items[6].SubItems[2].Text = "已禁用";
            else listView.Items[6].SubItems[2].Text = "启用中";
                    
            if (DataContext.PwrShell.CheckStatus())
                listView.Items[7].SubItems[2].Text = "已禁用";
            else listView.Items[7].SubItems[2].Text = "启用中";

        }
        ///<summary>
        ///左侧标题栏颜色响应
        /// </summary>
        public static void ColorChange(Button button, String color)
        {
            if (color == "E") button.BackColor = System.Drawing.Color.LightSkyBlue;
            if (color == "L") button.BackColor = System.Drawing.Color.White;
            if (color == "D") button.BackColor = System.Drawing.Color.DeepSkyBlue;
        }
        public static void ColorChange(Label lbl, String color)
        {
            if (color == "E") lbl.BackColor = System.Drawing.Color.LightSkyBlue;
            if (color == "D") lbl.BackColor = System.Drawing.Color.DeepSkyBlue;
            if (color == "L") lbl.BackColor = System.Drawing.Color.DodgerBlue;
        }
        ///<summary>
        ///关闭提示处理
        /// </summary>
        public static void CloseTips(Form Form)
        {
            var onclosingForm = new OnClosingForm();
            onclosingForm.ShowDialog();
            Application.DoEvents();
            if (onclosingForm.RdoMin.Checked == true)
            {
                Form.Hide();
                onclosingForm.Close();
            }
            else if (onclosingForm.RdoClose.Checked == true)
            {
                Environment.Exit(0);//彻底关掉！
            }
        }


        ///<summary>
        ///密码输入框设置
        /// </summary>
        public static void PwdSet(MaskedTextBox textBox, String status)
        {
            if (status == "NewEnter")
            {
                textBox.PasswordChar = '*'; if (textBox.Text == "请输入密码！" || textBox.Text == "密码不能为空！")
                {
                    textBox.Text = "";
                    textBox.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
                }
            }
            if (status == "ReEnter")
            {
                textBox.PasswordChar = '*';
                if (textBox.Text == "两次输入不一致！" || textBox.Text == "请再次输入密码！")
                {
                    textBox.Text = "";
                    textBox.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
                }
            }
            if (status == "ReLeave")
            {
                textBox.PasswordChar = new char();
                if (textBox.Text != textBox.Text)
                {
                    textBox.ForeColor = System.Drawing.Color.FromArgb(255, 128, 128, 128);
                    textBox.Text = "两次输入不一致！";
                }
            }
            if (status == "NewLeave")
            {
                textBox.PasswordChar = new char();
                if (textBox.Text == "")
                {
                    textBox.ForeColor = System.Drawing.Color.FromArgb(255, 128, 128, 128);
                    textBox.Text = "密码不能为空！";
                }
            }
        }

    }
   
}
