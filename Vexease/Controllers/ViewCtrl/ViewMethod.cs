using System;
using System.Linq;
using Vexease.Views;
using System.Windows.Forms;
// ┏┓　　　┏┓
// ┏┛┻━━━┛┻┓
// ┃　　　　　　　┃ 　
// ┃　　　━　　　┃
// ┃　┳┛　┗┳　┃
// ┃　　　　　　　┃
// ┃　　　┻　　　┃
// ┃　　　　　　　┃
// ┗━┓　　　┏━┛
//     ┃　　　┃ 神兽保佑　　　　　　　　
//     ┃　　　┃ 永无BUG！
//     ┃　　　┗━━━┓
//     ┃　　　　　　　┣┓
//     ┃　　　　　　　┏┛
//     ┗┓┓┏━┳┓┏┛
//       ┃┫┫　┃┫┫
//       ┗┻┛　┗┻┛
namespace Vexease.Controllers.ViewCtrl
{

    /// <summary>
    /// 界面所用方法综合类
    /// </summary>
    public class ViewMethod
    {
        public T Foo<T>(T value)
        {
            return value;
        }
        /// <summary>
        /// 名单.Height
        /// </summary>
        /// <param name="listView">
        /// 名单信息
        /// </param>
        public static void ListHeight(ListView listView) {//获取信息长度
        }
        ///<summary>
        ///名单收放
        /// </summary>
        /// <param name="listView">
        /// 名单信息
        /// </param>
        /// <param name="btnYorN">
        /// 对应的滑动条
        /// </param>
        public static void ContracAndAmplifica(ListView listView,BtnYorN btnYorN) {
            switch (listView.Height)
            {
                case 0 when btnYorN.Checked == true:
                    listView.Height =90;//ListHeight
                    break;
                default:
                    listView.Height = 0;
                    break;
            }
        }
        public static void ContracAndAmplifica(Panel listView,BtnYorN btnYorN)
        {
            switch (listView.Height)
            {
                case 0 when btnYorN.Checked == true:
                    listView.Height = 90;//ListHeight
                    break;
                default:
                    listView.Height = 0;
                    break;
            }
        }
        public static void ContracAndAmplifica(ListView listView)
        {
            if (listView.Height == 0) listView.Height = 90;//ListHeight
            else listView.Height = 0;
        }
        public static void ContracAndAmplifica(Panel panel)
        {
            if (panel.Height == 0) panel.Height = 90;//ListHeight
            else panel.Height = 0;
        }
        ///<summary>
        ///双击大标题
        /// </summary>
        public static void DoubleCliclLbl(Button BtnConsole, Button BtnRegustry,Button BtnPlanningTask, Button BtnCtrlPnl, Button BtnRunTool, Button BtnTaskMgr, Button BtnCmd, Button BtnPS,Button BtnProcCtrl)
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
        /// 列表宽度的计算
        /// </summary>
        /// <param name="listview">
        /// 求宽度的两列的列表
        /// </param>
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
        public static void Contraction(BtnYorN btnYorN,Panel panel)
        {
            if (btnYorN.Checked == false)
                panel.Height = 0;
        }
        ///<summary>
        ///状态显示更新
        /// </summary>
        public static void StatusChange(BtnYorN btnYorN,ListView listView)
        {
            if (btnYorN.Checked == false)
            {
                listView.Items[1].SubItems[1].Text = "已禁用";
            }
            else
            {
                listView.Items[1].SubItems[1].Text = "启用中";
            }
        }
        ///<summary>
        ///左侧标题栏颜色响应
        /// </summary>
        public static void ColorChange(Button button,String color)
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
            else if (onclosingForm.RdoClose.Checked== true)
            {                               
                Environment.Exit(0);//彻底关掉！
            }
        }
        
        
        ///<summary>
        ///密码输入框设置
        /// </summary>
        public static void PwdSet(MaskedTextBox textBox,String status)
        {
            if (status == "NewEnter")
            {
                textBox.PasswordChar = '*'; if (textBox.Text == "请输入密码！" || textBox.Text == "密码不能为空！")
                {
                    textBox.Text = "";
                    textBox.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
                }
            }
            if(status=="ReEnter")
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
    public abstract class ViewStatus
    {
       
    }
}
