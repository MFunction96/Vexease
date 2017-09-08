using System;
using System.Linq;
using Vexease.Data;
using Vexease.Models.Enums;
using Vexease.Models.Registrys;

namespace Vexease.Controllers.Status
{
    /// <inheritdoc />
    /// <summary>
    /// 注册表状态查询类。
    /// </summary>
    public class RegStatus : ICloneable
    {
        /// <summary>
        /// 注册表状态开关。
        /// </summary>
        public bool RegOn { get; protected set; }
        /// <summary>
        /// 注册表开启状态注册表存储。
        /// </summary>
        public RegStore[] OnRegStores { get; protected set; }
        /// <summary>
        /// 注册表关闭状态注册表存储。
        /// </summary>
        public RegStore[] OffRegStores { get; protected set; }
        /// <summary>
        /// 注册表查询类构造函数。
        /// </summary>
        /// <param name="onRegStores">
        /// 注册表开启状态注册表存储。
        /// </param>
        /// <param name="offRegStores">
        /// 注册表关闭状态注册表存储。
        /// </param>
        public RegStatus(RegStore[] onRegStores, RegStore[] offRegStores)
        {
            OnRegStores = onRegStores;
            OffRegStores = offRegStores;
        }
        /// <summary>
        /// 查询当前注册表状态。
        /// </summary>
        /// <returns>
        /// true表示注册表状态处于开启状态，
        /// false表示注册表状态处于关闭状态。
        /// </returns>
        public bool CheckStatus()
        {
            foreach (var regStore in OnRegStores)
            {
                if (!regStore.IsNecessary) continue;
                try
                {
                    if (regStore.LpValueName is null)
                    {
                        if (regStore.HKey == REG_ROOT_KEY.HKEY_CURRENT_USER)
                        {
                            if (regStore.LpSubKey ==
                                @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\RestrictRun")
                            {
                                var list = DataContext.GetTaskList(TASK_TYPE_FLAGS.RESTRICT_TASK_NAME);
                                if (list.All(tmp => tmp.LpValue != regStore.LpValue)) return RegOn = false;
                            }
                            else if (regStore.LpSubKey == 
                                @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun")
                            {
                                var list = DataContext.GetTaskList(TASK_TYPE_FLAGS.DISALLOW_TASK_NAME);
                                if (list.All(tmp => tmp.LpValue != regStore.LpValue)) return RegOn = false;
                            }
                        }
                        else
                        {
                            var regs = RegCtrl.RegCtrl.RegEnumValue(regStore.GetRegPath());
                            if (regs.All(reg => reg.LpValue != regStore.LpValue)) return RegOn = false;
                        }
                    }
                    else
                    {
                        var reg = RegCtrl.RegCtrl.RegGetValue(regStore.GetRegPath());
                        if (reg.LpValue != regStore.LpValue) return RegOn = false;
                    }
                }
                catch (Exception e)
                {
                    if (!regStore.IsNull || e.GetType() != typeof(NullReferenceException)) throw;
                }
            }
            return RegOn = true;
        }
        /// <summary>
        /// 切换注册表状态。
        /// </summary>
        /// <returns>
        /// true表示切换后注册表处于开启状态。
        /// false表示切换后注册表处于关闭状态。
        /// </returns>
        public bool SwapStatus()
        {
            var regStores = RegOn ? OffRegStores : OnRegStores;
            foreach (var reg in regStores)
            {
                if (!reg.IsNecessary) continue;
                if (reg.IsNull)
                {
                    RegCtrl.RegCtrl.RegDelKey(reg.GetRegPath());
                }
                else
                {
                    RegCtrl.RegCtrl.RegSetValue(reg.GetRegKey());
                }
            }
            return RegOn = !RegOn;
        }
        /// <inheritdoc />
        /// <summary>
        /// 获取当前对象的深表副本。
        /// </summary>
        /// <returns>
        /// 当前对象的深表副本。
        /// </returns>
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
