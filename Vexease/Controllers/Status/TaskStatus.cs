using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using Vexease.Controllers.List;
using Vexease.Controllers.Reg;
using Vexease.Data;
using Vexease.Models.Enums;
using Vexease.Models.Registrys;

namespace Vexease.Controllers.Status
{
    /// <inheritdoc />
    /// <summary>
    /// 进程限制状态。
    /// </summary>
    public class TaskStatus : Status
    {
        /// <summary>
        /// 进程名称。
        /// </summary>
        public string TaskName { get; }
        /// <summary>
        /// 进程限制策略。
        /// </summary>
        public TASK_TYPE_FLAGS TaskType { get; }
        /// <summary>
        /// 构造进程限制状态。
        /// </summary>
        /// <param name="taskName">
        /// 进程名称。
        /// </param>
        /// <param name="taskType">
        /// 进程限制策略。
        /// </param>
        public TaskStatus(string taskName, TASK_TYPE_FLAGS taskType)
        {
            TaskName = taskName;
            TaskType = taskType;
        }
        /// <summary>
        /// 应用进程列表变更。
        /// </summary>
        /// <param name="taskList">
        /// 将应用的进程列表。
        /// </param>
        private void ApplyTaskList(IEnumerable<string> taskList)
        {
            var path = DataContext.GetRegPath(TaskType);
            RegCtrl.RegDelKey(path);
            if ((int)TaskType >> 1 > 0)
            {
                foreach (var task in taskList)
                {
                    RegCtrl.RegSetValue(
                        new RegKey(path.HKey, $"{path.LpSubKey}\\{{{new Guid()}}}", @"ItemData",
                            RegistryValueKind.String, task));
                }
            }
            else
            {
                var i = 1;
                foreach (var task in taskList)
                {
                    RegCtrl.RegSetValue(
                        new RegKey(path.HKey, path.LpSubKey, i++.ToString(), RegistryValueKind.String, task));
                }
            }
            DataContext.RefrushData();
        }
        /// <inheritdoc />
        /// <summary>
        /// 检查进程状态。
        /// </summary>
        /// <returns>
        /// true为进程已在列表中。
        /// false为进程不在列表中。
        /// </returns>
        public override bool CheckStatus()
        {
            var regs = DataContext.GetTaskList(TaskType);
            return regs.Any(reg => 
                string.Equals(reg, TaskName, StringComparison.CurrentCultureIgnoreCase));
        }
        /// <inheritdoc />
        /// <summary>
        /// 切换进程状态。
        /// </summary>
        /// <returns>
        /// 切换后的进程状态。
        /// true为进程已在列表中。
        /// false为进程不在列表中。
        /// </returns>
        public override bool SwapStatus()
        {
            var buffer = new ListCtrl(DataContext.GetTaskList(TaskType));
            if (State)
            {
                var regs = DataContext.GetTaskList(TaskType);
                var regkey = regs.FirstOrDefault(reg =>
                    string.Equals(reg, TaskName, StringComparison.CurrentCultureIgnoreCase));
                if (regkey is null) throw new NullReferenceException(nameof(TaskStatus));
                buffer.DelTask(regkey, TaskType);
            }
            else buffer.AddTask(TaskName, TaskType);
            buffer.Apply();
            ApplyTaskList(buffer.OriginList);
            return base.SwapStatus();
        }
    }
}
