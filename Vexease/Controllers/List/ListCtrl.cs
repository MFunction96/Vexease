using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Win32;
using Vexease.Controllers.Reg;
using Vexease.Data;
using Vexease.Models.Enums;
using Vexease.Models.Registrys;

namespace Vexease.Controllers.List
{
    /// <summary>
    /// 列表控制器。
    /// </summary>
    public class ListCtrl
    {
        /// <summary>
        /// 原始进程信息。
        /// </summary>
        public IEnumerable<string> OriginList { get; }
        private TASK_TYPE_FLAGS TaskType { get; }
        /// <summary>
        /// 初始化进程信息。
        /// </summary>
        public ListCtrl(TASK_TYPE_FLAGS taskType)
        {
            OriginList = DataContext.GetTaskList(taskType);
            TaskType = taskType;
        }
        /// <summary>
        /// 列表内添加新条目。
        /// </summary>
        /// <param name="item">
        /// 条目名称。
        /// </param>
        /// <returns>
        /// 添加合并后的新列表。
        /// </returns>
        public IEnumerable<string> AddItem(string item)
        {
            var list = new List<string>(OriginList) {item};
            list.Sort();
            return list;
        }
        /// <summary>
        /// 列表内删除条目。
        /// </summary>
        /// <param name="item">
        /// 条目名称。
        /// </param>
        /// <returns>
        /// 删除后的新列表。
        /// </returns>
        public IEnumerable<string> DelItem(string item)
        {
            var list = new List<string>(OriginList);
            list.Remove(item);
            return list;
        }
        /// <summary>
        /// 与原列表比较并显示差异。
        /// </summary>
        /// <param name="currentList">
        /// 当前列表。
        /// </param>
        /// <returns>
        /// 两个返回值，前者为增加条目列表，后者为删除条目列表。
        /// </returns>
        public (IEnumerable<string>, IEnumerable<string>) Compare(IEnumerable<string> currentList)
        {
            if (OriginList is null) return (currentList, null);
            var add = currentList.Except(OriginList);
            var del = OriginList.Except(currentList);
            return (add, del);
        }
        /// <summary>
        /// 应用当前进程列表。
        /// </summary>
        /// <param name="currentList">
        /// 当前列表。
        /// </param>
        public void Apply(IEnumerable<string> currentList)
        {
            var regpath = DataContext.GetRegPath(TaskType);
            if ((int)TaskType >> 1 > 0)
            {
                try
                {
                    var regs = RegCtrl.RegEnumKey(regpath);
                    foreach (var reg in regs)
                    {
                        RegCtrl.RegDelKey(reg);
                    }
                }
                catch (Exception e)
                {
                    if (e.GetType() != typeof(NullReferenceException)) throw;
                }

                if (currentList is null)
                {
                    DataContext.RefrushData();
                    return;
                }
                foreach (var task in currentList)
                {
                    var guid = Guid.NewGuid();
                    var tmp = new RegKey(regpath.HKey, $"{regpath.LpSubKey}\\{{{guid}}}", @"ItemData", RegistryValueKind.String, task);
                    RegCtrl.RegSetValue(tmp);
                    tmp = new RegKey(regpath.HKey, $"{regpath.LpSubKey}\\{{{guid}}}", @"SaferFlags", RegistryValueKind.DWord, 0x0);
                    RegCtrl.RegSetValue(tmp);
                    tmp = new RegKey(regpath.HKey, $"{regpath.LpSubKey}\\{{{guid}}}", @"Description", RegistryValueKind.DWord, 0x0);
                    RegCtrl.RegSetValue(tmp);
                    tmp = new RegKey(regpath.HKey, $"{regpath.LpSubKey}\\{{{guid}}}", @"LastModified", RegistryValueKind.DWord, 0x0);
                    RegCtrl.RegSetValue(tmp);
                }
            }
            else
            {
                try
                {
                    var regs = RegCtrl.RegEnumValue(regpath);
                    foreach (var reg in regs)
                    {
                        RegCtrl.RegDelKey(reg);
                    }
                }
                catch (Exception e)
                {
                    if (e.GetType() != typeof(NullReferenceException)) throw;
                }

                if (currentList is null)
                {
                    DataContext.RefrushData();
                    return;
                }
                var index = 1;
                foreach (var task in currentList)
                {
                    var tmp = new RegKey(regpath.HKey, regpath.LpSubKey, index++.ToString(), RegistryValueKind.String, task);
                    RegCtrl.RegSetValue(tmp);
                }
            }
            DataContext.RefrushData();
        }
    }
}
