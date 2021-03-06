﻿using System;
using System.Linq;
using Vexease.Controllers.List;
using Vexease.Data;
using Vexease.Models.Enums;

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
            return !(regs is null) && regs.Any(reg => 
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
            var buffer = new ListCtrl(TaskType);
            var list = State ? buffer.DelItem(TaskName) : buffer.AddItem(TaskName);
            buffer.Apply(list);
            return base.SwapStatus();
        }
    }
}
