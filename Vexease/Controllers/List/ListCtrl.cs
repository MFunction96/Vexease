using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Vexease.Models.Enums;

namespace Vexease.Controllers.List
{
    /// <summary>
    /// 列表控制器。
    /// </summary>
    public class ListCtrl
    {
        /// <summary>
        /// 增加的进程信息。
        /// </summary>
        private LinkedList<string> AddList { get; }
        /// <summary>
        /// 删除的进程信息。
        /// </summary>
        private LinkedList<string> DelList { get; }
        /// <summary>
        /// 原始进程信息。
        /// </summary>
        private string[] OriginList { get; set; }
        /// <summary>
        /// 初始化进程信息。
        /// </summary>
        public ListCtrl(string[] originList)
        {
            AddList = new LinkedList<string>();
            DelList = new LinkedList<string>();
            OriginList = originList;
        }
        /// <summary>
        /// 增加进程信息。
        /// </summary>
        /// <param name="task">
        /// 进程信息。
        /// </param>
        /// <param name="taskType">
        /// 进程信息类型。
        /// </param>
        /// <returns>
        /// True为添加成功。
        /// False为添加失败。
        /// </returns>
        public bool AddTask(string task, TASK_TYPE_FLAGS taskType)
        {
            if (AddList.Any(tmp => string.Equals(tmp, task, StringComparison.CurrentCultureIgnoreCase))) return false;
            if (DelList.Any(tmp => string.Equals(tmp, task, StringComparison.CurrentCultureIgnoreCase)))
            {
                DelList.Remove(task);
                return true;
            }
            if (OriginList.Any(tmp =>
                string.Equals(tmp, task, StringComparison.CurrentCultureIgnoreCase)))
                return false;
            AddList.AddLast(task);
            return true;
        }
        /// <summary>
        /// 修改进程信息。
        /// </summary>
        /// <param name="frmTask">
        /// 需修改的进程信息。
        /// </param>
        /// <param name="nowTask">
        /// 修改为的进程信息。
        /// </param>
        /// <param name="taskType">
        /// 进程信息类型。
        /// </param>
        /// <returns>
        /// True为修改成功。
        /// False为修改失败。
        /// </returns>
        public bool ModifyTask(string frmTask, string nowTask, TASK_TYPE_FLAGS taskType)
        {
            if (AddList.Any(tmp => string.Equals(tmp, nowTask, StringComparison.CurrentCultureIgnoreCase))) return false;
            if (DelList.Any(tmp => string.Equals(tmp, nowTask, StringComparison.CurrentCultureIgnoreCase)))
            {
                DelList.AddLast(frmTask);
                DelList.Remove(nowTask);
                return true;
            }
            if (OriginList.Any(tmp =>
                string.Equals(tmp, nowTask, StringComparison.CurrentCultureIgnoreCase)))
                return false;
            DelList.AddLast(frmTask);
            AddList.AddLast(nowTask);
            return true;
        }
        /// <summary>
        /// 删除进程信息。
        /// </summary>
        /// <param name="task">
        /// 进程信息。
        /// </param>
        /// <param name="taskType">
        /// 进程信息类型。
        /// </param>
        public void DelTask(string task, TASK_TYPE_FLAGS taskType)
        {
            if (AddList.Any(tmp => string.Equals(tmp, task, StringComparison.CurrentCultureIgnoreCase)))
                AddList.Remove(task);
            DelList.AddLast(task);
        }
        /// <summary>
        /// 重置列表状态。
        /// </summary>
        public void Reset()
        {
            AddList.Clear();
            DelList.Clear();
        }
        /// <summary>
        /// 
        /// </summary>
        public void Apply()
        {
            var list = new ArrayList();
            foreach (var s in OriginList)
            {
                if (DelList.Any(tmp => tmp == s)) continue;
                list.Add(s);
            }
            foreach (var s in AddList) list.Add(s);
            OriginList = list.ToArray() as string[];
        }
    }
}
