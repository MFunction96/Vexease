using System;
using CommunalComputerManager.RegOperation;
using Microsoft.Win32;

namespace CommunalComputerManager.StatusMonitor
{
    /// <summary>
    /// 
    /// </summary>
    public class RegStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public bool RegOn { get; protected set; }
        /// <summary>
        /// 
        /// </summary>
        public RegStore[] OnRegStores { get; protected set; }
        /// <summary>
        /// 
        /// </summary>
        public RegStore[] OffRegStores { get; protected set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="onRegStores"></param>
        /// <param name="offRegStores"></param>
        public RegStatus(RegStore[] onRegStores, RegStore[] offRegStores)
        {
            OnRegStores = onRegStores;
            OffRegStores = offRegStores;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool CheckStatus()
        {
            RegOn = true;
            foreach (var reg in OnRegStores)
            {
                RegKey tmp;
                try
                {
                    tmp = RegOpt.RegGetValue(reg.GetRegPath());
                }
                catch (Exception e)
                {
                    if (e.GetType() == typeof(NullReferenceException))
                    {
                        tmp = new RegKey(reg.GetRegPath());
                    }
                    else
                    {
                        throw;
                    }
                }
                if (!reg.IsNull && (tmp.LpKind == RegistryValueKind.Unknown ||
                    reg.LpValue != tmp.LpValue))
                {
                    RegOn = false;
                    break;
                }
            }
            return RegOn;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool SwapStatus()
        {
            var regStores = RegOn ? OffRegStores : OnRegStores;
            foreach (var reg in regStores)
            {
                if (reg.IsNull)
                {
                    RegOpt.RegDelKey(reg.GetRegPath());
                }
                else
                {
                    RegOpt.RegSetValue(reg.GetRegKey());
                }
            }
            return RegOn = !RegOn;
        }
    }
}
