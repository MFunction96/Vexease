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
        private IEnumerable<string> OriginList { get; }
        private TASK_TYPE_FLAGS TaskType { get; }
        /// <summary>
        /// 初始化进程信息。
        /// </summary>
        public ListCtrl(IEnumerable<string> originList, TASK_TYPE_FLAGS taskType)
        {
            OriginList = originList;
            TaskType = taskType;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentList"></param>
        /// <returns></returns>
        public (IEnumerable<string>, IEnumerable<string>) Compare(IEnumerable<string> currentList)
        {
            var add = currentList.Except(OriginList);
            var del = OriginList.Except(currentList);
            return (add, del);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentList"></param>
        public void Apply(IEnumerable<string> currentList)
        {
            var regpath = DataContext.GetRegPath(TaskType);
            if ((int)TaskType >> 1 > 0)
            {
                var regs = RegCtrl.RegEnumKey(regpath);
                foreach (var reg in regs)
                {
                    RegCtrl.RegDelKey(reg);
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
                var regs = RegCtrl.RegEnumValue(regpath);
                foreach (var reg in regs)
                {
                    RegCtrl.RegDelKey(reg);
                }
                var index = 1;
                foreach (var task in currentList)
                {
                    var tmp = new RegKey(regpath.HKey, regpath.LpSubKey, index++.ToString(), RegistryValueKind.String, task);
                    RegCtrl.RegSetValue(tmp);
                }
            }
        }
    }
}
