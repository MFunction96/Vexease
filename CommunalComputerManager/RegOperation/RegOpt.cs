using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CommunalComputerManager.Common;
using Microsoft.Win32;

namespace CommunalComputerManager.RegOperation
{
    /// <summary>
    /// 
    /// </summary>
    public static class RegOpt
    {
        /// <summary>
        /// 
        /// </summary>
        // ReSharper disable once InconsistentNaming
        private const uint REG_OPENED_EXISTING_KEY = 0x2;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="regPath"></param>
        /// <exception cref="Exception"></exception>
        /// <returns></returns>
        public static RegKey RegGetValue(RegPath regPath)
        {
            RegKey regkey;
            try
            {
                UIntPtr phkresult;
                uint reggetvaluetemp;
                if (Environment.Is64BitOperatingSystem)
                {
                    reggetvaluetemp = NativeMethods.RegOpenKeyEx(regPath.HKey, regPath.LpSubKey, 0,
                        (uint) Common.RegOpt.KEY_SAM_FLAG.KEY_WOW64_64KEY |
                        (uint) Common.RegOpt.KEY_ACCESS_TYPE.KEY_READ, out phkresult);
                }
                else
                {
                    reggetvaluetemp = NativeMethods.RegOpenKeyEx(regPath.HKey, regPath.LpSubKey, 0,
                        (uint) Common.RegOpt.KEY_ACCESS_TYPE.KEY_READ, out phkresult);
                }
                if (reggetvaluetemp != (uint) ERROR_CODE.ERROR_SUCCESS)
                {
                    throw new Exception(@"注册表打开失败");
                }
                uint lpcbdata = 0;
                NativeMethods.RegQueryValueEx(phkresult, regPath.LpValueName, UIntPtr.Zero, out RegistryValueKind lpkind, IntPtr.Zero, ref lpcbdata);
                if (lpcbdata == 0)
                {
                    NativeMethods.RegCloseKey(phkresult);
                    throw new Exception(@"无法获取缓冲区大小");
                }
                var lpdata = Marshal.AllocHGlobal((int)lpcbdata);
                reggetvaluetemp = NativeMethods.RegQueryValueEx(phkresult, regPath.LpValueName, UIntPtr.Zero, out lpkind, lpdata, ref lpcbdata);
                NativeMethods.RegCloseKey(phkresult);
                if (reggetvaluetemp != (uint) ERROR_CODE.ERROR_SUCCESS)
                {
                    throw new Exception(@"注册表读取异常");
                }
                if (lpkind == RegistryValueKind.DWord)
                {
                    var lpdataint = Marshal.ReadInt32(lpdata);
                    regkey = new RegKey(regPath, lpkind, lpdataint, lpcbdata);
                }
                else if (lpkind == RegistryValueKind.QWord)
                {
                    var lpdataint = Marshal.ReadInt64(lpdata);
                    regkey = new RegKey(regPath, lpkind, lpdataint, lpcbdata);
                }
                else if (lpkind == RegistryValueKind.String)
                {
                    var lpdatastr = Marshal.PtrToStringUni(lpdata);
                    lpdatastr = lpdatastr?.Trim();
                    regkey = new RegKey(regPath, lpkind, lpdatastr, lpcbdata);
                }
                else
                {
                    throw new Exception(@"注册表数据类型异常");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + '\n' + e.StackTrace);
                regkey = new RegKey(regPath);
            }
            return regkey;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="regKey"></param>
        public static void RegSetValue(RegKey regKey)
        {
            try
            {
                uint regsetvaluetmp, exists;
                var sa = new SECURITY_ATTRIBUTES();
                UIntPtr phkResult;
                if (Environment.Is64BitOperatingSystem)
                {
                    regsetvaluetmp = NativeMethods.RegCreateKeyEx(regKey.HKey, regKey.LpSubKey, 0u, null,
                        (uint)Common.RegOpt.OPERATE_OPTION.REG_OPTION_NON_VOLATILE,
                        (uint)Common.RegOpt.KEY_SAM_FLAG.KEY_WOW64_64KEY | (uint)Common.RegOpt.KEY_ACCESS_TYPE.KEY_READ |
                        (uint)Common.RegOpt.KEY_ACCESS_TYPE.KEY_WRITE, ref sa, out phkResult, out exists);
                }
                else
                {
                    regsetvaluetmp = NativeMethods.RegCreateKeyEx(regKey.HKey, regKey.LpSubKey, 0u, null,
                        (uint)Common.RegOpt.OPERATE_OPTION.REG_OPTION_NON_VOLATILE, 
                        (uint)Common.RegOpt.KEY_ACCESS_TYPE.KEY_READ |
                        (uint)Common.RegOpt.KEY_ACCESS_TYPE.KEY_WRITE, ref sa, out phkResult, out exists);
                }
                if (regsetvaluetmp != (uint)ERROR_CODE.ERROR_SUCCESS && exists != REG_OPENED_EXISTING_KEY)
                {
                    throw new Exception(@"注册表访问异常");
                }
                IntPtr lpdata;
                uint lpcbdata;
                if (regKey.LpKind == RegistryValueKind.String)
                {
                    lpcbdata = (uint)((string) regKey.LpValue).Length + 1 << 1;
                    lpdata = Marshal.StringToHGlobalUni((string)regKey.LpValue);
                }
                else if (regKey.LpKind == RegistryValueKind.DWord)
                {
                    lpcbdata = (uint)Marshal.SizeOf(typeof(int));
                    lpdata = Marshal.AllocHGlobal((int)lpcbdata);
                    Marshal.WriteInt32(lpdata, (int)regKey.LpValue);
                }
                else if (regKey.LpKind == RegistryValueKind.QWord)
                {
                    lpcbdata = (uint)Marshal.SizeOf(typeof(long));
                    lpdata = Marshal.AllocHGlobal((int)lpcbdata);
                    Marshal.WriteInt64(lpdata, (long)regKey.LpValue);
                }
                else
                {
                    throw new Exception(@"元数据类型异常");
                }
                regsetvaluetmp =
                    NativeMethods.RegSetValueEx(phkResult, regKey.LpValueName, 0u, regKey.LpKind, lpdata, lpcbdata);
                NativeMethods.RegCloseKey(phkResult);
                if (regsetvaluetmp == (uint)ERROR_CODE.ERROR_SUCCESS)
                {
                    throw new Exception(@"注册表写入异常");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + '\n' + e.StackTrace);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="regPath"></param>
        public static void RegDelKey(RegPath regPath)
        {
            uint regdelkeytmp;
            if (string.IsNullOrEmpty(regPath.LpValueName))
            {
                regdelkeytmp = NativeMethods.RegDeleteKeyEx(regPath.HKey, regPath.LpSubKey,
                    (uint)Common.RegOpt.KEY_SAM_FLAG.KEY_WOW64_64KEY | (uint)Common.RegOpt.KEY_ACCESS_TYPE.KEY_ALL_ACCESS, 0u);
                if (regdelkeytmp != (uint) ERROR_CODE.ERROR_SUCCESS)
                {
                    MessageBox.Show(@"注册表删除失败");
                }
            }
            else
            {
                regdelkeytmp = NativeMethods.RegOpenKeyEx(regPath.HKey, regPath.LpSubKey, 0u,
                    (uint)Common.RegOpt.KEY_SAM_FLAG.KEY_WOW64_64KEY |
                    (uint)Common.RegOpt.KEY_ACCESS_TYPE.KEY_ALL_ACCESS, out UIntPtr phkresult);
                if (regdelkeytmp != (uint)ERROR_CODE.ERROR_SUCCESS)
                {
                    MessageBox.Show(@"注册表删除失败");
                    return;
                }
                regdelkeytmp = NativeMethods.RegDeleteValueEx(phkresult, regPath.LpValueName);
                if (regdelkeytmp != (uint)ERROR_CODE.ERROR_SUCCESS)
                {
                    MessageBox.Show(@"注册表删除失败");
                }
                NativeMethods.RegCloseKey(phkresult);
            }
        }
    }
}
