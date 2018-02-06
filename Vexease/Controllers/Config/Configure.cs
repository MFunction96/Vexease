using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using Vexease.Data;
using Vexease.Models.Config;

namespace Vexease.Controllers.Config
{
    /// <summary>
    /// 
    /// </summary>
    public class Configure
    {
        /// <summary>
        /// 
        /// </summary>
        public string DefaultPath => Environment.CurrentDirectory + "config.json";
        /// <summary>
        /// 
        /// </summary>
        public Configuration AppConfig { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Configure()
        {
            ReadConfig(string.Empty);
        }
        /// <summary>
        /// 读取配置文件。
        /// </summary>
        /// <param name="filepath">
        /// 文件路径。
        /// </param>
        public void ReadConfig(string filepath)
        {
            filepath = filepath ?? DefaultPath;
            var json = File.ReadAllText(filepath, Encoding.UTF8);
            AppConfig = JsonConvert.DeserializeObject<Configuration>(json);
        }
        /// <summary>
        /// 更新配置文件。
        /// </summary>
        /// <param name="filepath">
        /// 文件路径。
        /// </param>
        public void UpdateConfig(string filepath)
        {
            filepath = filepath ?? DefaultPath;
            var json = JsonConvert.SerializeObject(AppConfig);
            File.WriteAllText(filepath, json, Encoding.UTF8);
        }
        /// <summary>
        /// 应用配置。
        /// </summary>
        public void ApplyConfig()
        {
            if (DataContext.Cmd.State != AppConfig.Cmd) DataContext.Cmd.SwapStatus();
            if (DataContext.Registry.State != AppConfig.Registry) DataContext.Registry.SwapStatus();
            if (DataContext.RestrictTask.State != AppConfig.RestrictTask) DataContext.RestrictTask.SwapStatus();
            if (DataContext.Mmc.State != AppConfig.Mmc) DataContext.Mmc.SwapStatus();
            if (DataContext.CtrlPal.State != AppConfig.CtrlPal) DataContext.CtrlPal.SwapStatus();
            if (DataContext.DisallowTask.State != AppConfig.DisallowTask) DataContext.DisallowTask.SwapStatus();
            if (DataContext.Launcher.State != AppConfig.Launcher) DataContext.Launcher.SwapStatus();
            if (DataContext.LimitTaskPath.State != AppConfig.LimitTaskPath) DataContext.LimitTaskPath.SwapStatus();
            if (DataContext.SysDriver.State != AppConfig.SysDriver) DataContext.SysDriver.SwapStatus();
            if (DataContext.Taskmgr.State != AppConfig.Taskmgr) DataContext.Taskmgr.SwapStatus();
            if (DataContext.PwrShell.State != AppConfig.PwrShell) DataContext.PwrShell.SwapStatus();
        }
    }
}
