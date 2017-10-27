using System;
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



            }
            else
            {
                
            }
            return base.SwapStatus();
        }

        /// <summary>
        /// 插入进程至指定列表。
        /// </summary>
        /// <param name="delTask"></param>
        /// <param name="taskType">
        /// 
        /// </param>
        /// <param name="addTask"></param>
        public void ModifyTask(string addTask, string delTask, TASK_TYPE_FLAGS taskType)
        {
            
        }
    }
}
