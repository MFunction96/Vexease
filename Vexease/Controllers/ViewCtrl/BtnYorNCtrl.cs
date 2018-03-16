using Vexease.Data;
using Vexease.Views;

namespace Vexease.Controllers.ViewCtrl
{
    class BtnYorNCtrl
    {
        public void ClickYorN(string s)
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
        /// CheckButton的开关确认
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

    }

}
