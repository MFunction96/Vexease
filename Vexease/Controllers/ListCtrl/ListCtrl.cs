using System.Collections.Generic;
using System.Linq;
using Vexease.Data;
using Vexease.Models.Enums;

namespace Vexease.Controllers.ListCtrl
{
    public class ListCtrl
    {
        /// <summary>
        /// 
        /// </summary>
        private static LinkedList<string> AddList { get; }
        /// <summary>
        /// 
        /// </summary>
        private static LinkedList<string> DelList { get; }
        /// <summary>
        /// 
        /// </summary>
        static ListCtrl()
        {
            AddList = new LinkedList<string>();
            DelList = new LinkedList<string>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        /// <param name="taskType"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="frmTask"></param>
        /// <param name="nowTask"></param>
        /// <param name="taskType"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="task"></param>
        /// <param name="taskType"></param>
        /// <returns></returns>
        public static void DelTask(string task, TASK_TYPE_FLAGS taskType)
        {
            if (AddList.Any(tmp => tmp == task)) AddList.Remove(task);
            DelList.AddLast(task);
        }
        /// <summary>
        /// 
        /// </summary>
        public static void Reset()
        {
            AddList.Clear();
            DelList.Clear();
        }
    }
}
