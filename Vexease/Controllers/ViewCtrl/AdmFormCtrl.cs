﻿
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
        private ListCtrl Listctrl { get; }
        const TASK_TYPE_FLAGS TaskTypeW = TASK_TYPE_FLAGS.RESTRICT_TASK_NAME;
        private readonly string[] _wListN = DataContext.GetTaskList(TaskTypeW);
        /// <summary>
        /// 侧边栏Lbl与Lv相对应的字典（包括黑白表）
        /// </summary>
        public Dictionary<string, string> LblLvDictionary = new Dictionary<string, string>
        {
            {"LblConsole", "LvConsole"},
            {"LblRegustriy", "LvRegustry"},
            {"LblSys", "LvSys"},
            {"LblCtrlPnl", "LvCtrlPnl"},
            {"LblRunTool", "LvRunTool"},
            {"LblTaskMgr", "LvTaskMgr"},
            {"LblCmd", "LvCmd"},
            {"LblPS", "LvPS"},
            {"LblBListTitleN", "PnlBList"},
            {"LblWListTN", "PnlWList"}
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
        public AdmFormCtrl()
        {
            Listctrl = new ListCtrl(TaskTypeW);
        }
        /// <summary>
        /// 白名单（名称）列表加载
        /// </summary>
        /// <param name="listView"></param>
        public void WListCtrlLoad(ListView listView)
        {
            var i = 0;
            while (_wListN != null && i < _wListN.Length)
            {
                if (_wListN[i] != null)
                    listView.Items.Add(_wListN[i]);
                i++;
            }
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
        ///<summary>
        ///通过点击checkbutton控制名单(listView)收放
        /// </summary>       
        public  void ContracAndAmplifica(ListView listView, BtnYorN btnYorN, String yorN)
        {
            listView.Height = btnYorN.Checked ? 90 : 0;
        }

        /// <summary>
        /// 通过点击checkbutton控制名单(Panel)收放
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="btnYorN"></param>
        /// <param name="yorN"></param>
        public  void ContracAndAmplifica(Panel panel, BtnYorN btnYorN, String yorN)
        {
            panel.Height = btnYorN.Checked ? 90 : 0;
        }
        /// <summary>
        /// 通过点击标题控制名单（listView）收放
        /// </summary>
        /// <param name="s"></param>
        public  void ContracAndAmplifica( Control s)
        {
            s.Height = s.Height == 0 ? 90 : 0;
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
        /// 点击滑块检查状态
        /// </summary>
        /// <param name="s"></param>
        public void ClickYorN(string s)
        {

            if (s == "LimitTaskPath")
            {
                DataContext.LimitTaskPath.SwapStatus();
            }
            
            if (s == "RestrictTask")
            {
                DataContext.RestrictTask.SwapStatus();
            }
            if (s == "DisallowTask")
            {
                DataContext.DisallowTask.SwapStatus();

            }
            if (s == "SysDriver")
            {
                DataContext.SysDriver.SwapStatus();
            }
           
            if (s == "BtnConsoleYorN")
            {
               // btnYorN.Checked = false;
            }
            
            if (s == "Registry")
            {
                DataContext.Registry.SwapStatus();
            }
            
            if (s == "CtrlPal")
            {
                DataContext.CtrlPal.SwapStatus();
            }
           
            if (s == "Launcher")
            {
                DataContext.Launcher.SwapStatus();
            }
            
            if (s == "Cmd")
            {
                DataContext.Cmd.SwapStatus();
            }
            
            if (s == "Taskmgr")
            {
                DataContext.Taskmgr.SwapStatus();
            }
            
            if (s == "PwrShell")
            {
                DataContext.PwrShell.SwapStatus();
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
            if (s == "LimitTaskPath")
            {
                btnYorN.Checked = DataContext.LimitTaskPath.CheckStatus();
            }
            if (s == "RestrictTask")
            {
                btnYorN.Checked = DataContext.RestrictTask.CheckStatus();
            }
            if (s == "DisallowTask")
            {
                btnYorN.Checked = DataContext.DisallowTask.CheckStatus();
            }
            if (s == "SysDriver")
            {
                btnYorN.Checked = !DataContext.SysDriver.CheckStatus();
            }
            if (s == "BtnConsoleYorN")
            {
                btnYorN.Checked = false;
            }
            if (s == "Registry")
            {
                btnYorN.Checked = !DataContext.Registry.CheckStatus();
            }
            if (s == "CtrlPal")
            {
                btnYorN.Checked = !DataContext.CtrlPal.CheckStatus();
            }
            if (s == "Launcher")
            {
                btnYorN.Checked = !DataContext.Launcher.CheckStatus();
            }
            if (s == "Cmd")
            {
                btnYorN.Checked = !DataContext.Cmd.CheckStatus();
            }
            if (s == "Taskmgr")
            {
                btnYorN.Checked = !DataContext.Taskmgr.CheckStatus();
            }

            if (s == "PwrShell")
            {
                btnYorN.Checked = !DataContext.PwrShell.CheckStatus();
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
        /// <param name="listView"></param>
       














        /// <summary>
        /// 黑名单（名称）列表加载
        /// </summary>
        /// <param name="listView"></param>
        public void BListCtrlLoad(ListView listView)
        {
            const TASK_TYPE_FLAGS taskType = TASK_TYPE_FLAGS.DISALLOW_TASK_NAME;
            var bListN =DataContext.GetTaskList(taskType);
            var i = 0;
            while (bListN[i]!=null)
            {
                listView.Items.Add(bListN[i]);
                i++;
            }
        }
    }
}