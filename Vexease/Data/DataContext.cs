using Microsoft.Win32;
using System;
using System.Collections;
using Vexease.Controllers.Crypt;
using Vexease.Controllers.Reg;
using Vexease.Controllers.Status;
using Vexease.Models.Enums;
using Vexease.Models.Registrys;

namespace Vexease.Data
{
    /// <summary>
    /// 全局数据信息
    /// </summary>
    public class DataContext
    {
        // {1BB077CA-FEC5-479F-AA85-11CDFBFA4042}
        public static Guid MyGuid => new Guid("1BB077CA-FEC5-479F-AA85-11CDFBFA4042");
        /// <summary>
        /// 程序密码信息
        /// </summary>
        public static RegKey Password { get; private set; }
        /// <summary>
        /// 进程路径限制注册表信息。
        /// On为启动限制。
        /// Off为关闭限制。
        /// </summary>
        public static RegStatus LimitTaskPath { get; private set; }
        /// <summary>
        /// 进程名称白名单策略注册表信息。
        /// On为启动白名单限制。
        /// Off为关闭白名单限制。
        /// </summary>
        public static RegStatus RestrictTask { get; private set; }
        /// <summary>
        /// 进程名称黑名单策略注册表信息。
        /// On为启动黑名单限制。
        /// Off为关闭黑名单限制。
        /// </summary>
        public static RegStatus DisallowTask { get; private set; }
        /// <summary>
        /// C盘显示状态注册表信息。
        /// On为显示所有盘符。
        /// Off为隐藏C盘盘符。
        /// </summary>
        public static RegStatus SysDriver { get; private set; }
        /// <summary>
        /// 控制台状态注册表信息。
        /// On为启用控制台。
        /// Off为禁用控制台。
        /// </summary>
        public static TaskStatus Mmc { get; private set; }
        /// <summary>
        /// 注册表状态注册表信息。
        /// On为启用注册表。
        /// Off为禁用注册表。
        /// </summary>
        public static RegStatus Registry { get; private set; }
        /// <summary>
        /// 控制面板（设置）状态注册表信息。
        /// On为启用控制面板（设置）。
        /// Off为禁用控制面板（设置）。
        /// </summary>
        public static RegStatus CtrlPal { get; private set; }
        /// <summary>
        /// 运行工具状态注册表信息。
        /// On为启用运行工具。
        /// Off为禁用运行工具。
        /// </summary>
        public static RegStatus Launcher { get; private set; }
        /// <summary>
        /// 命令提示符状态注册表信息。
        /// On为启用命令提示符。
        /// Off为禁用命令提示符。
        /// </summary>
        public static RegStatus Cmd { get; private set; }
        /// <summary>
        /// 任务管理器状态注册表信息。
        /// On为启用任务管理器。
        /// Off为禁用任务管理器。
        /// </summary>
        public static RegStatus Taskmgr { get; private set; }
        /// <summary>
        /// Powershell状态注册表信息。
        /// On为启用Powershell。
        /// Off为禁用Powershell。
        /// </summary>
        public static TaskStatus PwrShell { get; private set; }
        /// <summary>
        /// 进程名称白名单。
        /// </summary>
        private static string[] RestrictTaskNames { get; set; }
        /// <summary>
        /// 进程名称黑名单。
        /// </summary>
        private static string[] DisallowTaskNames { get; set; }
        /// <summary>
        /// 进程路径白名单。
        /// </summary>
        private static string[] RestrictTaskPaths { get; set; }
        /// <summary>
        /// 进程路径黑名单。
        /// </summary>
        private static string[] DisallowTaskPaths { get; set; }
        /// <summary>
        /// 初始化全局数据。
        /// </summary>
        static DataContext()
        {
            RefrushData();
        }
        /// <summary>
        /// 初始化进程路径限制状态。
        /// </summary>
        /// <returns>
        /// 进程路径限制状态注册表信息。
        /// </returns>
        private static RegStatus InitLimitTaskPath()
        {
            var regp = new RegPath(REG_ROOT_KEY.HKEY_LOCAL_MACHINE, @"Software\Policies\Microsoft\Windows\safer\codeidentifiers", @"DefaultLevel");
            var onreg = new RegStore[1];
            var offreg = new RegStore[1];
            onreg[0] = new RegStore(regp, RegistryValueKind.DWord, 0x0, false);
            offreg[0] = new RegStore(regp, RegistryValueKind.DWord, 0x40000);
            return new RegStatus(onreg, offreg);
        }
        /// <summary>
        /// 初始化进程名称白名单状态。
        /// </summary>
        /// <returns>
        /// 进程名称白名单状态注册表信息。
        /// </returns>
        private static RegStatus InitRestrictTask()
        {
            var regp = new RegPath(REG_ROOT_KEY.HKEY_CURRENT_USER, @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", @"RestrictRun");
            var onreg = new RegStore[1];
            var offreg = new RegStore[1];
            onreg[0] = new RegStore(regp, RegistryValueKind.DWord, 0x1, false);
            offreg[0] = new RegStore(regp, RegistryValueKind.DWord, 0x0);
            return new RegStatus(onreg, offreg);
        }
        /// <summary>
        /// 初始化进程名称黑名单状态。
        /// </summary>
        /// <returns>
        /// 进程名称黑名单状态注册表信息。
        /// </returns>
        private static RegStatus InitDisallowTask()
        {
            var regp = new RegPath(REG_ROOT_KEY.HKEY_CURRENT_USER, @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", @"DisallowRun");
            var onreg = new RegStore[1];
            var offreg = new RegStore[1];
            onreg[0] = new RegStore(regp, RegistryValueKind.DWord, 0x1, false);
            offreg[0] = new RegStore(regp, RegistryValueKind.DWord, 0x0);
            return new RegStatus(onreg, offreg);
        }
        /// <summary>
        /// 初始化C盘显示状态。
        /// </summary>
        /// <returns>
        /// C盘显示状态注册表信息。
        /// </returns>
        private static RegStatus InitSysDriver()
        {
            var regp = new RegPath(REG_ROOT_KEY.HKEY_CURRENT_USER, @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", @"NoDrives");
            var onreg = new RegStore[1];
            var offreg = new RegStore[1];
            onreg[0] = new RegStore(regp, RegistryValueKind.DWord, 0x0, false);
            offreg[0] = new RegStore(regp, RegistryValueKind.DWord, 0x4);
            return new RegStatus(onreg, offreg);
        }
        /// <summary>
        /// 初始化注册表状态。
        /// </summary>
        /// <returns>
        /// 注册表状态注册表信息。
        /// </returns>
        private static RegStatus InitRegistry()
        {
            var regp = new RegPath(REG_ROOT_KEY.HKEY_CURRENT_USER, @"Software\Microsoft\Windows\CurrentVersion\Policies\System", @"DisableRegistryTools");
            var onreg = new RegStore[1];
            var offreg = new RegStore[1];
            onreg[0] = new RegStore(regp, RegistryValueKind.DWord, 0x0);
            offreg[0] = new RegStore(regp, RegistryValueKind.DWord, 0x2, false);
            return new RegStatus(onreg, offreg);
        }
        /// <summary>
        /// 初始化命令提示符状态。
        /// </summary>
        /// <returns>
        /// 命令提示符状态注册表信息。
        /// </returns>
        private static RegStatus InitCmd()
        {
            var regp = new RegPath(REG_ROOT_KEY.HKEY_CURRENT_USER, @"Software\Microsoft\Windows\CurrentVersion\Policies\System", @"DisableCMD");
            var onreg = new RegStore[1];
            var offreg = new RegStore[1];
            onreg[0] = new RegStore(regp, RegistryValueKind.DWord, 0x0);
            offreg[0] = new RegStore(regp, RegistryValueKind.DWord, 0x2, false);
            return new RegStatus(onreg, offreg);
        }
        /// <summary>
        /// 初始化任务管理器状态。
        /// </summary>
        /// <returns>
        /// 任务管理器状态注册表信息。
        /// </returns>
        private static RegStatus InitTaskmgr()
        {
            var regp = new RegPath(REG_ROOT_KEY.HKEY_CURRENT_USER, @"Software\Microsoft\Windows\CurrentVersion\Policies\System", @"DisableTaskMgr");
            var onreg = new RegStore[1];
            var offreg = new RegStore[1];
            onreg[0] = new RegStore(regp, RegistryValueKind.DWord, 0x0);
            offreg[0] = new RegStore(regp, RegistryValueKind.DWord, 0x1, false);
            return new RegStatus(onreg, offreg);
        }
        /// <summary>
        /// 初始化运行工具状态。
        /// </summary>
        /// <returns>
        /// 运行工具状态注册表信息。
        /// </returns>
        private static RegStatus InitLauncher()
        {
            var regp = new RegPath(REG_ROOT_KEY.HKEY_CURRENT_USER, @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", @"NoRun");
            var onreg = new RegStore[1];
            var offreg = new RegStore[1];
            onreg[0] = new RegStore(regp, RegistryValueKind.DWord, 0x0);
            offreg[0] = new RegStore(regp, RegistryValueKind.DWord, 0x2, false);
            return new RegStatus(onreg, offreg);
        }
        /// <summary>
        /// 初始化控制面板（设置）状态。
        /// </summary>
        /// <returns>
        /// 控制面板（设置）状态注册表信息。
        /// </returns>
        private static RegStatus InitCtrlPal()
        {
            var regp = new RegPath(REG_ROOT_KEY.HKEY_CURRENT_USER, @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", @"NoControlPanel");
            var onreg = new RegStore[1];
            var offreg = new RegStore[1];
            onreg[0] = new RegStore(regp, RegistryValueKind.DWord, 0x0);
            offreg[0] = new RegStore(regp, RegistryValueKind.DWord, 0x2, false);
            return new RegStatus(onreg, offreg);
        }
        /// <summary>
        /// 初始化控制台状态。
        /// </summary>
        /// <returns>
        /// 控制台状态注册表信息。
        /// </returns>
        private static TaskStatus InitMmc()
        {
            return new TaskStatus(@"mmc.exe", TASK_TYPE_FLAGS.DISALLOW_TASK_NAME);
        }
        /// <summary>
        /// 初始化Powershell状态。
        /// </summary>
        /// <returns>
        /// Powershell状态注册表信息。
        /// </returns>
        private static TaskStatus InitPwrShell()
        {
            return new TaskStatus(@"powershell.exe", TASK_TYPE_FLAGS.DISALLOW_TASK_NAME);
        }
        private static RegKey InitPwd()
        {
            return RegCtrl.RegGetValue(new RegPath(REG_ROOT_KEY.HKEY_CLASSES_ROOT, $"CLSID\\{{{MyGuid}}}", AESCrypt.Encrypt(@"Password")));
        }
        /// <summary>
        /// 刷新当前注册表记录状态。
        /// </summary>
        public static void RefrushData()
        {
            RestrictTaskNames = InitTask(TASK_TYPE_FLAGS.RESTRICT_TASK_NAME);
            DisallowTaskNames = InitTask(TASK_TYPE_FLAGS.DISALLOW_TASK_NAME);
            RestrictTaskPaths = InitTask(TASK_TYPE_FLAGS.RESTRICT_TASK_PATH);
            DisallowTaskPaths = InitTask(TASK_TYPE_FLAGS.DISALLOW_TASK_PATH);
            LimitTaskPath = InitLimitTaskPath();
            RestrictTask = InitRestrictTask();
            DisallowTask = InitDisallowTask();
            SysDriver = InitSysDriver();
            Registry = InitRegistry();
            Cmd = InitCmd();
            Taskmgr = InitTaskmgr();
            Launcher = InitLauncher();
            CtrlPal = InitCtrlPal();
            Mmc = InitMmc();
            PwrShell = InitPwrShell();
            Password = InitPwd();
        }
        /// <summary>
        /// 获取进程信息注册表路径。
        /// </summary>
        /// <param name="taskType">
        /// 进程信息类型。
        /// </param>
        /// <returns>
        /// 相应类型的进程信息注册表路径。
        /// </returns>
        public static RegPath GetRegPath(TASK_TYPE_FLAGS taskType)
        {
            RegPath path;
            if (taskType == TASK_TYPE_FLAGS.RESTRICT_TASK_NAME)
            {
                path = new RegPath(REG_ROOT_KEY.HKEY_CURRENT_USER,
                    @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\RestrictRun");
            }
            else if (taskType == TASK_TYPE_FLAGS.DISALLOW_TASK_NAME)
            {
                path = new RegPath(REG_ROOT_KEY.HKEY_CURRENT_USER,
                    @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun");
            }
            else if (taskType == TASK_TYPE_FLAGS.RESTRICT_TASK_PATH)
            {
                path = new RegPath(REG_ROOT_KEY.HKEY_LOCAL_MACHINE, @"SOFTWARE\Policies\Microsoft\Windows\safer\codeidentifiers\262144\Paths");
            }
            else
            {
                path = new RegPath(REG_ROOT_KEY.HKEY_LOCAL_MACHINE, @"SOFTWARE\Policies\Microsoft\Windows\safer\codeidentifiers\‭0\Paths‬");
            }
            return path;
        }
        /// <summary>
        /// 初始化进程信息。
        /// </summary>
        /// <param name="taskType">
        /// 进程信息类型。
        /// </param>
        /// <returns>
        /// 进程信息注册表信息。
        /// </returns>
        private static string[] InitTask(TASK_TYPE_FLAGS taskType)
        {
            var path = GetRegPath(taskType);
            string[] regkeys;
            var list = new ArrayList();
            try
            {
                if ((int) taskType >> 1 > 0)
                {
                    var regs = RegCtrl.RegEnumKey(path);
                    foreach (var reg in regs)
                    {
                        var tmp = RegCtrl.RegGetValue(new RegPath(reg.HKey, reg.LpSubKey, @"ItemData"));
                        var str = tmp.LpValue.ToString();
                        if (tmp.LpKind == RegistryValueKind.ExpandString)
                            str = RegCtrl.RegGetValue(new RegPath(str, true)).LpValue.ToString();
                        list.Add(str);
                    }
                }
                else
                {
                    var regs = RegCtrl.RegEnumValue(path);
                    foreach (var reg in regs) list.Add(reg.LpValue.ToString());
                }
            }
            catch (Exception e)
            {
                if (e.GetType() != typeof(NullReferenceException)) throw new Exception(nameof(InitTask));
            }
            finally
            {
                list.Sort();
                regkeys = list.ToArray() as string[];
            }
            return regkeys;
        }
        /// <summary>
        /// 获取进程信息。
        /// </summary>
        /// <param name="taskType">
        /// 进程信息类型。
        /// </param>
        /// <returns>
        /// 相应类型的进程信息注册表信息。
        /// </returns>
        public static string[] GetTaskList(TASK_TYPE_FLAGS taskType)
        {
            if (taskType == TASK_TYPE_FLAGS.RESTRICT_TASK_NAME) return RestrictTaskNames;
            if (taskType == TASK_TYPE_FLAGS.DISALLOW_TASK_NAME) return DisallowTaskNames;
            return taskType == TASK_TYPE_FLAGS.RESTRICT_TASK_PATH ? RestrictTaskPaths : DisallowTaskPaths;
        }
    }
}
