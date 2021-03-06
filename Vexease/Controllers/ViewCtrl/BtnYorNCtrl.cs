﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vexease.Views;
using Vexease.Data;
namespace Vexease.Controllers.ViewCtrl
{
    /// <summary>
    /// BtnYorN的状态确认
    /// </summary>
    class BtnYorNCtrl
    {
        ///<summary>
        ///CheckButton的开关确认
        /// </summary>
        /// <param name="s">
        /// CheckButtin的调用信息
        /// </param>
        public static void CheckYorN(BtnYorN btnYorN, String s)
        {
            if (s == "P_Load")
            {
                if (DataContext.LimitTaskPath.CheckStatus())
                    btnYorN.Checked = true;
                else btnYorN.Checked = false;
            }
            if (s == "P_Clicked")
            {
                DataContext.LimitTaskPath.SwapStatus();
            }
            if (s == "W_Load")
            {
                if (DataContext.RestrictTask.CheckStatus()) btnYorN.Checked = true;
                else btnYorN.Checked = false;
            }
            if (s == "W_Clicked")
            {
                DataContext.RestrictTask.SwapStatus();
            }
            if (s == "B_Load")
            {
                if (DataContext.DisallowTask.CheckStatus()) btnYorN.Checked = true;
                else btnYorN.Checked = false;
            }
            if (s == "B_Clicked")
            {
                DataContext.DisallowTask.SwapStatus();
              
            }
            if (s=="Sys_Load")
            {
                if (DataContext.SysDriver.CheckStatus()) btnYorN.Checked = false;
                else btnYorN.Checked = true;
            }
            if (s == "Sys_Clicked")
            {
                DataContext.SysDriver.SwapStatus();
            }
            if (s== "Mmc_Load")
            {
                btnYorN.Checked = false;
            }
            if (s == "Mmc_Clicked")
            {
                btnYorN.Checked = false;
            }
            if (s == "Registry_Load")
            {
                if (DataContext.Registry.CheckStatus())
                    btnYorN.Checked = false;
                else btnYorN.Checked = true;
            }
            if (s == "Registry_Clicked")
            {
                DataContext.Registry.SwapStatus();
            }
            if (s == "CtrlPnl_Load")
            {
                if (DataContext.CtrlPal.CheckStatus()) btnYorN.Checked = false;
                else btnYorN.Checked = true;
            }
            if (s == "CtrlPnl_Clicked")
            {
                DataContext.CtrlPal.SwapStatus();
            }
            if (s == "RunTool_Load")
            {
                if (DataContext.Launcher.CheckStatus()) btnYorN.Checked = false;
                else btnYorN.Checked = true;
            }
            if (s == "RunTool_Clicked")
            {
                DataContext.Launcher.SwapStatus();
            }
            if (s == "Cmd_Load")
            {
                if (DataContext.Cmd.CheckStatus()) btnYorN.Checked = false;
                else btnYorN.Checked = true;
            }
            if (s == "Cmd_Clicked")
            {
                DataContext.Cmd.SwapStatus();
            }
            if (s == "Taskmgr_Load")
            {
                if (DataContext.Taskmgr.CheckStatus()) btnYorN.Checked = false;
                else btnYorN.Checked = true;
            }
            if (s == "Taskmgr_Clicked")
            {
                DataContext.Taskmgr.SwapStatus();
            }
            if (s == "PwrShell_Load")
            {
                if (DataContext.PwrShell.CheckStatus()) btnYorN.Checked = false;
                else btnYorN.Checked = true;
            }
            if (s == "PwrShell_Clicked")
            {
                DataContext.PwrShell.SwapStatus();
            }
           
        }
        
    }
}
