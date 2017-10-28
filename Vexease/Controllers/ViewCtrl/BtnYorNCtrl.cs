using System;
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
                if (DataContext.LimitTaskPath.CheckStatus()) btnYorN.Checked = true;
                else btnYorN.Checked = false;
            }
            if (s == "P_Clicked")
            {
                if (DataContext.LimitTaskPath.SwapStatus()) btnYorN.Checked = true;
                else btnYorN.Checked = false;
            }
            if (s == "W_Load")
            {
                if (DataContext.RestrictTask.CheckStatus()) btnYorN.Checked = true;
                else btnYorN.Checked = false;
            }
            if (s == "W_Clicked")
            {
                if (DataContext.RestrictTask.SwapStatus()) btnYorN.Checked = true;
                else btnYorN.Checked = false;
            }
            if (s == "B_Load")
            {
                if (DataContext.DisallowTask.CheckStatus()) btnYorN.Checked = true;
                else btnYorN.Checked = false;
            }
            if (s == "B_Clicked")
            {
                if (DataContext.DisallowTask.SwapStatus()) btnYorN.Checked = true;
                else btnYorN.Checked = false;
            }
            if (s=="Sys_Load")
            {
                if (DataContext.SysDriver.CheckStatus()) btnYorN.Checked = true;
                else btnYorN.Checked = false;
            }
            if (s == "Sys_Clicked")
            {
                if (DataContext.SysDriver.SwapStatus()) btnYorN.Checked = true;
                else btnYorN.Checked = false;
            }
            if (s== "Mmc_Load")
            {

            }
            if (s == "Mmc_Clicked")
            {

            }
            if (s == "Registry_Load")
            {
                if (DataContext.Registry.CheckStatus()) btnYorN.Checked = true;
                else btnYorN.Checked = false;
            }
            if (s == "Registry_Clicked")
            {
                if (DataContext.Registry.SwapStatus()) btnYorN.Checked = true;
                else btnYorN.Checked = false;
            }
            if (s == "CtrlPnl_Load")
            {
                if (DataContext.CtrlPal.CheckStatus()) btnYorN.Checked = true;
                else btnYorN.Checked = false;
            }
            if (s == "CtrlPnl_Clicked")
            {
                if (DataContext.CtrlPal.SwapStatus()) btnYorN.Checked = true;
                else btnYorN.Checked = false;
            }
            if (s == "RunTool_Load")
            {
                if (DataContext.Launcher.CheckStatus()) btnYorN.Checked = true;
                else btnYorN.Checked = false;
            }
            if (s == "RunTool_Clicked")
            {
                if (DataContext.Launcher.SwapStatus()) btnYorN.Checked = true;
                else btnYorN.Checked = false;
            }
            if (s == "Cmd_Load")
            {
                if (DataContext.Cmd.CheckStatus()) btnYorN.Checked = true;
                else btnYorN.Checked = false;
            }
            if (s == "Cmd_Clicked")
            {
                if (DataContext.Cmd.SwapStatus()) btnYorN.Checked = true;
                else btnYorN.Checked = false;
            }
            if (s == "Taskmgr_Load")
            {
                if (DataContext.Taskmgr.CheckStatus()) btnYorN.Checked = true;
                else btnYorN.Checked = false;
            }
            if (s == "Taskmgr_Clicked")
            {
                if (DataContext.Taskmgr.SwapStatus()) btnYorN.Checked = true;
                else btnYorN.Checked = false;
            }
            if (s == "PwrShell_Load")
            {
                if (DataContext.PwrShell.CheckStatus()) btnYorN.Checked = true;
                else btnYorN.Checked = false;
            }
            if (s == "PwrShell_Clicked")
            {
                if (DataContext.PwrShell.SwapStatus()) btnYorN.Checked = true;
                else btnYorN.Checked = false;
            }
           
        }
        
    }
}
