using System;
using Vexease.Views;
using Vexease.Data;
namespace Vexease.Controllers.ViewCtrl
{
    /// <summary>
    /// BtnYorN的状态确认
    /// </summary>
    class BtnYorNCtrl
    {
        /// <summary>
        /// CheckButton的开关确认
        ///  </summary>
        /// <param name="btnYorN">
        /// 滑动开关
        /// </param>
        /// <param name="s">
        ///  CheckButtin的调用信息
        ///  </param>
        public static void CheckYorN(BtnYorN btnYorN, String s) 
        {
            if (s == "P_Load")
            {
                btnYorN.Checked = DataContext.LimitTaskPath.CheckStatus();
            }
            if (s == "P_Clicked")
            {
                DataContext.LimitTaskPath.SwapStatus();
            }
            if (s == "W_Load")
            {
                btnYorN.Checked = DataContext.RestrictTask.CheckStatus();
            }
            if (s == "W_Clicked")
            {
                DataContext.RestrictTask.SwapStatus();
            }
            if (s == "B_Load")
            {
                btnYorN.Checked = DataContext.DisallowTask.CheckStatus();
            }
            if (s == "B_Clicked")
            {
                DataContext.DisallowTask.SwapStatus();
              
            }
            if (s=="Sys_Load")
            {
                btnYorN.Checked = !DataContext.SysDriver.CheckStatus();
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
                btnYorN.Checked = !DataContext.Registry.CheckStatus();
            }
            if (s == "Registry_Clicked")
            {
                DataContext.Registry.SwapStatus();
            }
            if (s == "CtrlPnl_Load")
            {
                btnYorN.Checked = !DataContext.CtrlPal.CheckStatus();
            }
            if (s == "CtrlPnl_Clicked")
            {
                DataContext.CtrlPal.SwapStatus();
            }
            if (s == "RunTool_Load")
            {
                btnYorN.Checked = !DataContext.Launcher.CheckStatus();
            }
            if (s == "RunTool_Clicked")
            {
                DataContext.Launcher.SwapStatus();
            }
            if (s == "Cmd_Load")
            {
                btnYorN.Checked = !DataContext.Cmd.CheckStatus();
            }
            if (s == "Cmd_Clicked")
            {
                DataContext.Cmd.SwapStatus();
            }
            if (s == "Taskmgr_Load")
            {
                btnYorN.Checked = !DataContext.Taskmgr.CheckStatus();
            }
            if (s == "Taskmgr_Clicked")
            {
                DataContext.Taskmgr.SwapStatus();
            }
            if (s == "PwrShell_Load")
            {
                btnYorN.Checked = !DataContext.PwrShell.CheckStatus();
            }
            if (s == "PwrShell_Clicked")
            {
                DataContext.PwrShell.SwapStatus();
            }
           
        }
        
    }
}
