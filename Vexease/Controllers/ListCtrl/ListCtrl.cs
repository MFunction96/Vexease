using System.Collections.Generic;
using System.Linq;
using Vexease.Data;
using Vexease.Models.Enums;

namespace Vexease.Controllers.ListCtrl
{
    /// <summary>
    /// 列表控制器
    /// </summary>
    public class ListCtrl
    {
        /// <summary>
        /// 增加的进程信息
        /// </summary>
        private static LinkedList<string> AddList { get; }
        /// <summary>
        /// 删除的进程信息
        /// </summary>
        private static LinkedList<string> DelList { get; }
        /// <summary>
        /// 初始化进程信息
        /// </summary>
        static ListCtrl()
        {
            AddList = new LinkedList<string>();
            DelList = new LinkedList<string>();
        }
        /// <summary>
        /// 增加进程信息
        /// </summary>
        /// <param name="task">
        /// 进程信息
        /// </param>
        /// <param name="taskType">
        /// 进程信息类型
        /// </param>
        /// <returns>
        /// True为添加成功
        /// False为添加失败
        /// </returns>
        public static bool AddTask(string task, TASK_TYPE_FLAGS taskType)
        {
            if (AddList.Any(tmp => tmp == task)) return false;
            if (DelList.Any(tmp => tmp == task))
            {
                DelList.Remove(task);
                return true;
            }
            if (DataContext.GetTaskList(taskType).Any(tmp => tmp.LpValue.ToString() == task)) return false;
            AddList.AddLast(task);
            return true;
        }
        /// <summary>
        /// 修改进程信息
        /// </summary>
        /// <param name="frmTask">
        /// 需修改的进程信息
        /// </param>
        /// <param name="nowTask">
        /// 修改为的进程信息
        /// </param>
        /// <param name="taskType">
        /// 进程信息类型
        /// </param>
        /// <returns>
        /// True为修改成功
        /// False为修改失败
        /// </returns>
        public static bool ModifyTask(string frmTask, string nowTask, TASK_TYPE_FLAGS taskType)
        {
            if (AddList.Any(tmp => tmp == nowTask)) return false;
            if (DelList.Any(tmp => tmp == nowTask))
            {
                DelList.AddLast(frmTask);
                DelList.Remove(nowTask);
                return true;
            }
            if (DataContext.GetTaskList(taskType).Any(tmp => tmp.LpValue.ToString() == nowTask)) return false;
            DelList.AddLast(frmTask);
            AddList.AddLast(nowTask);
            return true;
        }
        /// <summary>
        /// 删除进程信息
        /// </summary>
        /// <param name="task">
        /// 进程信息
        /// </param>
        /// <param name="taskType">
        /// 进程信息类型
        /// </param>
        public static void DelTask(string task, TASK_TYPE_FLAGS taskType)
        {
            if (AddList.Any(tmp => tmp == task)) AddList.Remove(task);
            DelList.AddLast(task);
        }
        /// <summary>
        /// 重置列表状态
        /// </summary>
        public static void Reset()
        {
            AddList.Clear();
            DelList.Clear();
        }
    }
}
