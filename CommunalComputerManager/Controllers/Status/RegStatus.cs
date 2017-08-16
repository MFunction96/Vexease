using System;
using CommunalComputerManager.Models.Registrys;
using Microsoft.Win32;

namespace CommunalComputerManager.Controllers.Status
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
            /*foreach (var reg in OnRegStores)
            {
                if (reg.LpValueName == string.Empty)
                {
                    var flag = true;
                    var regp = RegCtrl.RegCtrl.RegEnumValue(reg.GetRegPath());
                    RegPath temp;
                    foreach (var regPath in regp)
                    {
                        var tmp = RegCtrl.RegCtrl.RegGetValue(regPath);
                        if (tmp.LpValue.ToString() == reg.LpValue.ToString())
                        {
                            flag = false;
                            temp = regPath;
                            break;
                        }
                    }
                    if (flag)
                    {
                        RegOn = false;
                        break;
                    }
                }
                else
                {
                    RegKey tmp;
                    try
                    {
                        tmp = RegCtrl.RegCtrl.RegGetValue(reg.GetRegPath());
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
                
            }*/
            for (var i = 0; i < OnRegStores.Length; i++)
            {
                var regstore = OnRegStores[i];
                if (regstore.LpValueName == string.Empty)
                {
                    var flag = true;
                    var regp = RegCtrl.RegCtrl.RegEnumValue(regstore.GetRegPath());
                    RegPath temp = null;
                    foreach (var regPath in regp)
                    {
                        var tmp = RegCtrl.RegCtrl.RegGetValue(regPath);
                        if (tmp.LpValue.ToString() == regstore.LpValue.ToString())
                        {
                            flag = false;
                            temp = regPath;
                            break;
                        }
                    }
                    if (flag)
                    {
                        RegOn = false;
                        break;
                    }
                    regstore = new RegStore(regstore.HKey, regstore.LpSubKey, temp.LpValueName, regstore.LpKind,
                        regstore.LpValue, regstore.IsNull);
                }
                else
                {
                    RegKey tmp;
                    try
                    {
                        tmp = RegCtrl.RegCtrl.RegGetValue(regstore.GetRegPath());
                    }
                    catch (Exception e)
                    {
                        if (e.GetType() == typeof(NullReferenceException))
                        {
                            tmp = new RegKey(regstore.GetRegPath());
                        }
                        else
                        {
                            throw;
                        }
                    }
                    if (!regstore.IsNull && (tmp.LpKind == RegistryValueKind.Unknown || regstore.LpValue != tmp.LpValue))
                    {
                        RegOn = false;
                        break;
                    }
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
                    RegCtrl.RegCtrl.RegDelKey(reg.GetRegPath());
                }
                else
                {
                    RegCtrl.RegCtrl.RegSetValue(reg.GetRegKey());
                }
            }
            return RegOn = !RegOn;
        }
    }
}
