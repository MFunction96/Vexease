
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Vexease.Controllers.List;
using Vexease.Data;
using Vexease.Models.Enums;
using Vexease.Properties;
using Vexease.Views;

namespace Vexease.Controllers.ViewCtrl
{
    /// <summary>
    /// 管理员界面控制器
    /// </summary>
 

    public class AdmFormCtrl
    {
        private  ListViewSetByName ListViewSetW { get; }
        private ListViewSetByName ListViewSetB { get; }
        /// <summary>
        /// 侧边栏Lbl与Lv相对应的字典（包括黑白表）
        /// </summary>
        public Dictionary<string, string> LblLvDictionary = new Dictionary<string, string>
        {
            {"BtnConsoleYorN", "LvConsole"},
            {"BtnRegustriyYorN", "LvRegustry"},
            {"BtnSysYorN", "LvSys"},
            {"BtnCtrlPnlYorN", "LvCtrlPnl"},
            {"BtnRunToolYorN", "LvRunTool"},
            {"BtnTaskMgrYorN", "LvTaskMgr"},
            {"BtnCmdYorN", "LvCmd"},
            {"BtnPSYorN", "LvPS"},
            {"LblConsole", "LvConsole"},
            {"LblRegustriy", "LvRegustry"},
            {"LblSys", "LvSys"},
            {"LblCtrlPnl", "LvCtrlPnl"},
            {"LblRunTool", "LvRunTool"},
            {"LblTaskMgr", "LvTaskMgr"},
            {"LblCmd", "LvCmd"},
            {"LblPS", "LvPS"},
            {"LblBListTitleN", "PnlBList"},
            {"LblWListTN", "PnlWList"},
            {"BtnBListYorN", "PnlBList"},
         {"BtnWListYorN", "PnlWList"}
        };
        /// <summary>
        /// 侧边栏Lbl与Lv相对应的字典（不包括黑白表）
        /// </summary>
        public Dictionary<string, string> LvDictionary = new Dictionary<string, string>
        {
            {"LblConsole", "LvConsole"},
            {"LblRegustriy", "LvRegustry"},
            {"LblSys", "LvSys"},
            {"LblCtrlPnl", "LvCtrlPnl"},
            {"LblRunTool", "LvRunTool"},
            {"LblTaskMgr", "LvTaskMgr"},
            {"LblCmd", "LvCmd"},
            {"LblPS", "LvPS"}


        };
        /// <summary>
        /// 滑块与DataContext方法相对应的字典
        /// </summary>
        public Dictionary<string, string> YorNLimitDictionary = new Dictionary<string, string>
        {
            {"BtnBListYorN", "DisallowTask"},
            {"BtnWListYorN", "RestrictTask"},
            {"BtnListPathYorN", "LimitTaskPath"},
            {"BtnRegustriyYorN", "Registry"},
            {"BtnConsoleYorN", "BtnConsoleYorN"},
            {"BtnSysYorN", "SysDriver"},
            {"BtnCtrlPnlYorN", "CtrlPal"},
            {"BtnRunToolYorN", "Launcher"},
            {"BtnTaskMgrYorN", "Taskmgr"},
            {"BtnCmdYorN", "Cmd"},
            {"BtnPSYorN", "PwrShell"}
        };
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, string> YorNDictionary = new Dictionary<string, string>
        {
           
            {"BtnRegustriyYorN", "Registry"},
            {"BtnConsoleYorN", "BtnConsoleYorN"},
            {"BtnSysYorN", "SysDriver"},
            {"BtnCtrlPnlYorN", "CtrlPal"},
            {"BtnRunToolYorN", "Launcher"},
            {"BtnTaskMgrYorN", "Taskmgr"},
            {"BtnCmdYorN", "Cmd"},
            {"BtnPSYorN", "PwrShell"}
        };

        /// <summary>
        /// 
        /// </summary>
        public AdmFormCtrl( )
        {
            ListViewSetB = new ListViewSetByName(TASK_TYPE_FLAGS.DISALLOW_TASK_NAME,"进程名称：");
            ListViewSetW =new ListViewSetByName(TASK_TYPE_FLAGS.RESTRICT_TASK_NAME,"进程名称：");         
        }
        /// <summary>
        /// 计算两列的列表的列宽
        /// </summary>
        /// <param name="listview"></param>
        public void Colwidth2(ListView listview)
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
        /// 状态显示
        /// </summary>
        /// <param name="btnYorN">滑块按钮</param>
        /// <param name="listView">状态显示的列表</param>
        /// <param name="yorN">调用的方法名</param>
        public  void StatusChange(BtnYorN btnYorN, ListView listView, string yorN)
        {
            
            listView.Items[1].SubItems[1].Text = btnYorN.Checked == false ? Resources.UserFormCtrl_StatusChange_已禁用 : Resources.UserFormCtrl_StatusChange_启用中;
        }
        /// <summary>
        /// 通过点击标题控制名单（listView）收放
        /// </summary>
        /// <param name="s"></param>
        public void ContracAndAmplifica( Control s)
        {
            s.Height = s.Height == 0 ? 90 : 0;
        }
        /// <summary>
        /// 通过btnYorN控制名单（Panel）收放
        /// </summary>
        /// <param name="btnYorN"></param>
        /// <param name="s"></param>
        public void ContracAndAmplifica(BtnYorN btnYorN,Panel s,string n)
        {
            s.Height = btnYorN.Checked==false ? 0 : 90;
        }

        ///<summary>
        /// Tab转换
        /// </summary>
        public void TabChange(TabControl tabControl, object sender)
        {
            if (sender is Label s1 && (s1.Text == Resources.AdmFormCtrl_LblStatus ||
                               s1.Text == Resources.AdmFormCtrl_LblOptimization))
                tabControl.SelectedIndex = 0;
            var s2 = sender as Button;
            if (s2 != null && s2.Text == Resources.AdmFormCtrl_BtnConsole)
                tabControl.SelectedIndex = 1;
            if (s2 != null && s2.Text == Resources.AdmFormCtrl_BtnRegustry)
                tabControl.SelectedIndex = 2;
            if (s2 != null && s2.Text == Resources.AdmFormCtrl_BtnSys)
                tabControl.SelectedIndex = 3;
            if (s2 != null && s2.Text == Resources.AdmFormCtrl_BtnCtrlPnl)
                tabControl.SelectedIndex = 4;
            if (s2 != null && s2.Text == Resources.AdmFormCtrl_BtnRunTool)
                tabControl.SelectedIndex = 5;
            if (s2 != null && s2.Text == Resources.AdmFormCtrl_BtnTaskMgr)
                tabControl.SelectedIndex = 6;
            if (s2 != null && s2.Text == Resources.AdmFormCtrl_BtnCmd)
                tabControl.SelectedIndex = 7;
            if (s2 != null && s2.Text == Resources.AdmFormCtrl_BtnPS)
                tabControl.SelectedIndex = 8;
            if (s2 != null && s2.Text == Resources.AdmFormCtrl_BtnProcCtrl)
                tabControl.SelectedIndex = 9;
        }

        /// <summary>
        /// 点击滑块
        /// </summary>
        /// <param name="s"></param>
        public void ClickYorN( string s)
        {

            switch (s)
            {
                case "LimitTaskPath":
                    DataContext.LimitTaskPath.SwapStatus();
                    break;
                case "RestrictTask":
                    DataContext.RestrictTask.SwapStatus();
                    break;
                case "DisallowTask":
                    DataContext.DisallowTask.SwapStatus();
                    break;
                case "SysDriver":
                    DataContext.SysDriver.SwapStatus();
                    break;
                case "BtnConsoleYorN":
                    DataContext.Mmc.SwapStatus();
                    break;
                case "Registry":
                    DataContext.Registry.SwapStatus();
                    break;
                case "CtrlPal":
                    DataContext.CtrlPal.SwapStatus();
                    break;
                case "Launcher":
                    DataContext.Launcher.SwapStatus();
                    break;
                case "Cmd":
                    DataContext.Cmd.SwapStatus();
                    break;
                case "Taskmgr":
                    DataContext.Taskmgr.SwapStatus();
                    break;
                case "PwrShell":
                    DataContext.PwrShell.SwapStatus();
                    break;
            }
        }

        /// <summary>
        /// 滑块开关load检查
        ///  </summary>
        /// <param name="btnYorN">
        /// 滑动开关
        /// </param>
        /// <param name="s">
        ///  CheckButtin的调用信息
        ///  </param>
        public void LoadYorN(BtnYorN btnYorN, string s)
        {
            switch (s)
            {
                case "LimitTaskPath":
                    btnYorN.Checked = DataContext.LimitTaskPath.CheckStatus();
                    break;
                case "RestrictTask":
                    btnYorN.Checked = DataContext.RestrictTask.CheckStatus();
                    break;
                case "DisallowTask":
                    btnYorN.Checked = DataContext.DisallowTask.CheckStatus();
                    break;
                case "SysDriver":
                    btnYorN.Checked = !DataContext.SysDriver.CheckStatus();
                    break;
                case "BtnConsoleYorN":
                    btnYorN.Checked = !DataContext.Mmc.CheckStatus();
                    break;
                case "Registry":
                    btnYorN.Checked = !DataContext.Registry.CheckStatus();
                    break;
                case "CtrlPal":
                    btnYorN.Checked = !DataContext.CtrlPal.CheckStatus();
                    break;
                case "Launcher":
                    btnYorN.Checked = !DataContext.Launcher.CheckStatus();
                    break;
                case "Cmd":
                    btnYorN.Checked = !DataContext.Cmd.CheckStatus();
                    break;
                case "Taskmgr":
                    btnYorN.Checked = !DataContext.Taskmgr.CheckStatus();
                    break;
                case "PwrShell":
                    btnYorN.Checked = !DataContext.PwrShell.CheckStatus();
                    break;
            }
        }
        ///<summary>
        ///左侧标题栏颜色响应
        /// </summary>
        public  void ColorChange(Control button, String color)
        {
            if (color == "E") button.BackColor = Color.LightSkyBlue;
            if (color == "L") button.BackColor = Color.White;
            if (color == "D") button.BackColor = Color.DeepSkyBlue;
        }
        /// <summary>
        /// 左侧标题栏颜色响应
        /// </summary>
        /// <param name="lbl"></param>
        /// <param name="color"></param>
        public void ColorChange(Label lbl, String color)
        {
            lbl.BackColor = Color.DodgerBlue;
        }

        /// <summary>
        /// 双击大标题
        /// </summary>
        /// <param name="btnConsole"></param>
        /// <param name="btnRegustry"></param>
        /// <param name="btnPlanningTask"></param>
        /// <param name="btnCtrlPnl"></param>
        /// <param name="btnRunTool"></param>
        /// <param name="btnTaskMgr"></param>
        /// <param name="btnCmd"></param>
        /// <param name="btnPs"></param>
        /// <param name="btnProcCtrl"></param>
        public void DoubleCliclLbl(Button btnConsole, Button btnRegustry, Button btnPlanningTask, Button btnCtrlPnl, Button btnRunTool, Button btnTaskMgr, Button btnCmd, Button btnPs, Button btnProcCtrl)
        {
            if (btnConsole.Height == 0)
            {
                btnConsole.Height = btnRegustry.Height =
                    btnPlanningTask.Height = btnCtrlPnl.Height =
                        btnRunTool.Height = btnTaskMgr.Height =
                            btnCmd.Height = btnPs.Height = btnProcCtrl.Height = 30;
            }
            else
            {
                btnConsole.Height = btnRegustry.Height =
                    btnPlanningTask.Height = btnCtrlPnl.Height =
                        btnRunTool.Height = btnTaskMgr.Height =
                            btnCmd.Height = btnPs.Height = btnProcCtrl.Height = 0;
            }
        }
        ///<summary>
        ///关闭提示处理
        /// </summary>
        public void CloseTips(Form form)
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
        /// 白名单（名称）列表加载
        /// </summary>
        public void WListCtrlLoad(ListView listView)
        {
           ListViewSetW.ListLoad(listView,TASK_TYPE_FLAGS.RESTRICT_TASK_NAME);
            
        }
        /// <summary>
        /// 黑名单（名称）列表加载
        /// </summary>
        /// <param name="listView">
        /// </param>
        public void BListCtrlLoad(ListView listView)
        {
           ListViewSetB.ListLoad(listView,TASK_TYPE_FLAGS.DISALLOW_TASK_NAME);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="btnYorN"></param>
        public void Fresh(Button btnYorN)
        {
            DataContext.RefrushData();
        }
    }
}