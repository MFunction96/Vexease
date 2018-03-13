namespace Vexease.Models.Config
{
    /// <summary>
    /// 配置文件模板。
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// 程序密码信息。
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 进程路径限制注册表信息。
        /// </summary>
        public bool LimitTaskPath { get; set; }
        /// <summary>
        /// 进程名称白名单策略注册表信息。
        /// </summary>
        public bool RestrictTask { get; set; }
        /// <summary>
        /// 进程名称黑名单策略注册表信息。
        /// </summary>
        public bool DisallowTask { get; set; }
        /// <summary>
        /// C盘显示状态注册表信息。
        /// </summary>
        public bool SysDriver { get; set; }
        /// <summary>
        /// 控制台状态注册表信息。
        /// </summary>
        public bool Mmc { get; set; }
        /// <summary>
        /// 注册表状态注册表信息。
        /// </summary>
        public bool Registry { get; set; }
        /// <summary>
        /// 控制面板（设置）状态注册表信息。
        /// </summary>
        public bool CtrlPal { get; set; }
        /// <summary>
        /// 运行工具状态注册表信息。
        /// </summary>
        public bool Launcher { get; set; }
        /// <summary>
        /// 命令提示符状态注册表信息。
        /// </summary>
        public bool Cmd { get; set; }
        /// <summary>
        /// 任务管理器状态注册表信息。
        /// </summary>
        public bool Taskmgr { get; set; }
        /// <summary>
        /// Powershell状态注册表信息。
        /// </summary>
        public bool PwrShell { get; set; }
        /// <summary>
        /// 进程名称白名单。
        /// </summary>
        public string[] RestrictTaskNames { get; set; }
        /// <summary>
        /// 进程名称黑名单。
        /// </summary>
        public string[] DisallowTaskNames { get; set; }
        /// <summary>
        /// 进程路径白名单。
        /// </summary>
        public string[] RestrictTaskPaths { get; set; }
        /// <summary>
        /// 进程路径黑名单。
        /// </summary>
        public string[] DisallowTaskPaths { get; set; }
    }
}
