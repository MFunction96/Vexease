using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using Vexease.Controllers.RegCtrl;
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
        /// <summary>
        /// 进程路径限制注册表信息。
        /// On为启动限制
        /// Off为关闭限制
        /// </summary>
        public static RegStatus LimitTaskPath { get; private set; }
        /// <summary>
        /// 进程名称白名单策略注册表信息
        /// On为启动白名单限制
        /// Off为关闭白名单限制
        /// </summary>
        public static RegStatus RestrictTask { get; private set; }
        /// <summary>
        /// 进程名称黑名单策略注册表信息
        /// On为启动黑名单限制
        /// Off为关闭黑名单限制
        /// </summary>
        public static RegStatus DisallowTask { get; private set; }
        /// <summary>
        /// C盘显示状态注册表信息
        /// On为显示所有盘符
        /// Off为隐藏C盘盘符
        /// </summary>
        public static RegStatus SysDriver { get; private set; }
        /// <summary>
        /// 控制台状态注册表信息
        /// On为启用控制台
        /// Off为禁用控制台
        /// </summary>
        public static RegStatus Mmc { get; private set; }
        /// <summary>
        /// 注册表状态注册表信息
        /// On为启用注册表
        /// Off为禁用注册表
        /// </summary>
        public static RegStatus Registry { get; private set; }
        /// <summary>
        /// 控制面板（设置）状态注册表信息
        /// On为启用控制面板（设置）
        /// Off为禁用控制面板（设置）
        /// </summary>
        public static RegStatus CtrlPal { get; private set; }
        /// <summary>
        /// 运行工具状态注册表信息
        /// On为启用运行工具
        /// Off为禁用运行工具
        /// </summary>
        public static RegStatus Launcher { get; private set; }
        /// <summary>
        /// 命令提示符状态注册表信息
        /// On为启用命令提示符
        /// Off为禁用命令提示符
        /// </summary>
        public static RegStatus Cmd { get; private set; }
        /// <summary>
        /// 任务管理器状态注册表信息
        /// On为启用任务管理器
        /// Off为禁用任务管理器
        /// </summary>
        public static RegStatus Taskmgr { get; private set; }
        /// <summary>
        /// Powershell状态注册表信息
        /// On为启用Powershell
        /// Off为禁用Powershell
        /// </summary>
        public static RegStatus PwrShell { get; private set; }
        /// <summary>
        /// 进程名称白名单
        /// </summary>
        private static LinkedList<RegKey> RestrictTaskNames { get; set; }
        /// <summary>
        /// 进程名称黑名单
        /// </summary>
        private static LinkedList<RegKey> DisallowTaskNames { get; set; }
        /// <summary>
        /// 进程路径白名单
        /// </summary>
        private static LinkedList<RegKey> RestrictTaskPaths { get; set; }
        /// <summary>
        /// 进程路径黑名单
        /// </summary>
        private static LinkedList<RegKey> DisallowTaskPaths { get; set; }
        /// <summary>
        /// 初始化全局数据
        /// </summary>
        static DataContext()
        {
            RefrushData();
        }
        /// <summary>
        /// 初始化进程路径限制状态
        /// </summary>
        /// <returns>
        /// 进程路径限制状态注册表信息
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
        /// 初始化进程名称白名单状态
        /// </summary>
        /// <returns>
        /// 进程名称白名单状态注册表信息
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
        /// 
        /// </summary>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <returns></returns>
        private static RegStatus InitMmc()
        {
            var regp = new RegPath(REG_ROOT_KEY.HKEY_CURRENT_USER, @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", @"DisallowRun");
            var onreg = new RegStore[2];
            var offreg = new RegStore[2];
            onreg[0] = new RegStore(regp, RegistryValueKind.DWord, 0x0, false);
            offreg[0] = new RegStore(regp, RegistryValueKind.DWord, 0x0);
            regp = new RegPath(REG_ROOT_KEY.HKEY_CURRENT_USER, @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun");
            const string str = @"mmc.exe";
            onreg[1] = new RegStore(regp, RegistryValueKind.String, str, false);
            offreg[1] = new RegStore(regp, RegistryValueKind.String, str);
            return new RegStatus(onreg, offreg);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static RegStatus InitPwrShell()
        {
            var regp = new RegPath(REG_ROOT_KEY.HKEY_CURRENT_USER, @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", @"DisallowRun");
            var onreg = new RegStore[3];
            var offreg = new RegStore[3];
            onreg[0] = new RegStore(regp, RegistryValueKind.DWord, 0x1, false);
            offreg[0] = new RegStore(regp, RegistryValueKind.DWord, 0x0);
            regp = new RegPath(REG_ROOT_KEY.HKEY_CURRENT_USER, @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun");
            const string str = @"powershell.exe";
            onreg[1] = new RegStore(regp, RegistryValueKind.String, str, false);
            offreg[1] = new RegStore(regp, RegistryValueKind.String, str);
            return new RegStatus(onreg, offreg);
        }
        /// <summary>
        /// 
        /// </summary>
        public static void RefrushData()
        {
            RestrictTaskNames = InitTask(TASK_TYPE_FLAGS.DISALLOW_TASK_NAME);
            DisallowTaskNames = InitTask(TASK_TYPE_FLAGS.RESTRICT_TASK_NAME);
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
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="taskType"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="taskType"></param>
        /// <returns></returns>
        private static LinkedList<RegKey> InitTask(TASK_TYPE_FLAGS taskType)
        {
            var tasks = new LinkedList<RegKey>();
            try
            {
                var path = GetRegPath(taskType);
                var regs = (int)taskType >> 1 > 0
                    ? RegCtrl.RegEnumKey(new RegPath(path.HKey, path.LpSubKey))
                    : RegCtrl.RegEnumValue(new RegPath(path.HKey, path.LpSubKey), new RegKeyComparer());
                foreach (var reg in regs)
                {
                    RegKey task;
                    if ((int)taskType >> 1 > 0)
                    {
                        task = RegCtrl.RegGetValue(new RegPath(reg.HKey, reg.LpSubKey, @"ItemData"));
                        task = RegCtrl.RegGetValue(new RegPath(task.LpValue.ToString(), true));
                    }
                    else
                    {
                        task = RegCtrl.RegGetValue(reg);
                    }
                    tasks.AddLast(task);
                }
            }
            catch (Exception e)
            {
                if (e.GetType() != typeof(NullReferenceException))
                {
                    throw;
                }
            }
            return tasks;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="taskType"></param>
        /// <returns></returns>
        public static LinkedList<RegKey> GetTaskList(TASK_TYPE_FLAGS taskType)
        {
            LinkedList<RegKey> list;
            if (taskType == TASK_TYPE_FLAGS.RESTRICT_TASK_NAME) list = RestrictTaskNames;
            else if (taskType == TASK_TYPE_FLAGS.DISALLOW_TASK_NAME) list = DisallowTaskNames;
            else if (taskType == TASK_TYPE_FLAGS.RESTRICT_TASK_PATH) list = RestrictTaskPaths;
            else list = DisallowTaskPaths;
            return list;
        }
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        private class RegKeyComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                var regx = x as RegKey;
                var regy = y as RegKey;
                if (regx is null || regy is null) throw new NullReferenceException();
                var valuex = regx.LpValue as string;
                var valuey = regy.LpValue as string;
                if (valuex is null || valuey is null) throw new NullReferenceException();
                return int.Parse(valuex) < int.Parse(valuey) ? 1 : -1;
            }
        }
    }
}
