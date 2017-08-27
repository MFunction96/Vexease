﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using Vexease.Controllers.RegCtrl;
using Vexease.Controllers.Status;
using Vexease.Models.Enums;
using Vexease.Models.Registrys;

namespace Vexease.Data
{
    public class DataContext
    {
        /// <summary>
        /// 
        /// </summary>
        public static RegStatus LimitProc { get; }
        /// <summary>
        /// 
        /// </summary>
        public static RegStatus LimitSys { get; }
        /// <summary>
        /// 
        /// </summary>
        public static RegStatus Mmc { get; }
        /// <summary>
        /// 
        /// </summary>
        public static RegStatus Registry { get; }
        /// <summary>
        /// 
        /// </summary>
        public static RegStatus CtrlPal { get; }
        /// <summary>
        /// 
        /// </summary>
        public static RegStatus Launcher { get; }
        /// <summary>
        /// 
        /// </summary>
        public static RegStatus Cmd { get; }
        /// <summary>
        /// 
        /// </summary>
        public static RegStatus Taskmgr { get; }
        /// <summary>
        /// 
        /// </summary>
        public static RegStatus PwrShell { get; }
        /// <summary>
        /// 
        /// </summary>
        public static LinkedList<RegKey> RestrictTaskNames { get; }
        /// <summary>
        /// 
        /// </summary>
        public static LinkedList<RegKey> DisallowTaskNames { get; }
        /// <summary>
        /// 
        /// </summary>
        public static LinkedList<RegKey> RestrictTaskPaths { get; }
        /// <summary>
        /// 
        /// </summary>
        public static LinkedList<RegKey> DisallowTaskPaths { get; }
        /// <summary>
        /// 
        /// </summary>
        static DataContext()
        {
            LimitProc = InitLimitProc();
            LimitSys = InitLimitSys();
            Registry = InitRegistry();
            Cmd = InitCmd();
            Taskmgr = InitTaskmgr();
            Launcher = InitLauncher();
            CtrlPal = InitCtrlPal();
            Mmc = InitMmc();
            PwrShell = InitPwrShell();
            RestrictTaskNames = InitTask(TASK_TYPE_FLAGS.DISALLOW_TASK_NAME);
            DisallowTaskNames = InitTask(TASK_TYPE_FLAGS.RESTRICT_TASK_NAME);
            RestrictTaskPaths = InitTask(TASK_TYPE_FLAGS.RESTRICT_TASK_PATH);
            DisallowTaskPaths = InitTask(TASK_TYPE_FLAGS.DISALLOW_TASK_PATH);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static RegStatus InitLimitProc()
        {
            var regp = new RegPath(REG_ROOT_KEY.HKEY_LOCAL_MACHINE, @"Software\Policies\Microsoft\Windows\safer\codeidentifiers", @"DefaultLevel");
            var onreg = new RegStore[1];
            var offreg = new RegStore[1];
            onreg[0] = new RegStore(regp, RegistryValueKind.DWord, 0x0, false);
            offreg[0] = new RegStore(regp, RegistryValueKind.DWord, 0x40000);
            return new RegStatus(onreg, offreg);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static RegStatus InitLimitSys()
        {
            var regp = new RegPath(REG_ROOT_KEY.HKEY_CURRENT_USER, @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", @"NoDrives");
            var onreg = new RegStore[1];
            var offreg = new RegStore[1];
            onreg[0] = new RegStore(regp, RegistryValueKind.DWord, 0x4, false);
            offreg[0] = new RegStore(regp, RegistryValueKind.DWord, 0x0);
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
            onreg[0] = new RegStore(regp, RegistryValueKind.DWord, 0x1, false);
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

        private static RegPath GetRegPath(TASK_TYPE_FLAGS taskType)
        {
            RegPath path;
            if (taskType == TASK_TYPE_FLAGS.DISALLOW_TASK_NAME)
            {
                path = new RegPath(REG_ROOT_KEY.HKEY_CURRENT_USER,
                    @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\RestrictRun");
            }
            else if (taskType == TASK_TYPE_FLAGS.RESTRICT_TASK_NAME)
            {
                path = new RegPath(REG_ROOT_KEY.HKEY_CURRENT_USER,
                    @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun");
            }
            else if (taskType == TASK_TYPE_FLAGS.DISALLOW_TASK_PATH)
            {
                path = new RegPath(REG_ROOT_KEY.HKEY_CURRENT_USER, @"SOFTWARE\Policies\Microsoft\Windows\safer\codeidentifiers\0");
            }
            else
            {
                path = new RegPath(REG_ROOT_KEY.HKEY_CURRENT_USER, @"SOFTWARE\Policies\Microsoft\Windows\safer\codeidentifiers\‭262144‬");
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
            var task = new LinkedList<RegKey>();
            try
            {
                var path = GetRegPath(taskType);
                var tmp = RegCtrl.RegEnumValue(new RegPath(path.HKey, path.LpSubKey));
                foreach (var reg in tmp)
                {
                    task.AddLast(RegCtrl.RegGetValue(reg));
                }
            }
            catch (Exception e)
            {
                if (e.GetType() != typeof(NullReferenceException))
                {
                    throw;
                }
            }
            return task;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="taskType"></param>
        /// <returns></returns>
        private static LinkedList<RegKey> GetTaskList(TASK_TYPE_FLAGS taskType)
        {
            LinkedList<RegKey> list;
            if (taskType == TASK_TYPE_FLAGS.DISALLOW_TASK_NAME)
            {
                list = RestrictTaskNames;
            }
            else if (taskType == TASK_TYPE_FLAGS.RESTRICT_TASK_NAME)
            {
                list = DisallowTaskNames;
            }
            else if (taskType == TASK_TYPE_FLAGS.DISALLOW_TASK_PATH)
            {
                list = RestrictTaskPaths;
            }
            else
            {
                list = DisallowTaskPaths;
            }
            return list;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="taskType"></param>
        /// <returns></returns>
        public static RegKey[] GetTaskArray(TASK_TYPE_FLAGS taskType)
        {
            var tasks = GetTaskList(taskType);
            var reg = new RegKey[tasks.Count];
            var i = 0;
            foreach (var tmp in tasks)
            {
                reg[i++] = tmp;
            }
            return reg;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="taskList"></param>
        /// <param name="taskType"></param>
        public static void AddTask((string, string)[] taskList, TASK_TYPE_FLAGS taskType)
        {
            var tasks = GetTaskList(taskType);
            var path = GetRegPath(taskType);
            foreach (var task in taskList)
            {
                var reg = new RegKey(path.HKey, path.LpSubKey, task.Item1, RegistryValueKind.String, task.Item2);
                RegCtrl.RegSetValue(reg);
                tasks.AddLast(reg);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="taskList"></param>
        /// <param name="taskType"></param>
        public static void DropTask(RegKey[] taskList, TASK_TYPE_FLAGS taskType)
        {
            var tasks = GetTaskList(taskType);
            foreach (var task in taskList)
            {
                tasks.Remove(task);
                RegCtrl.RegDelKey(task.GetRegPath());
            }
        }
    }
}
