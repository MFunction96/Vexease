using Microsoft.Win32;
using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;
using Vexease.Controllers.PInvoke;
using Vexease.Models.Enums;
using Vexease.Models.Registrys;

namespace Vexease.Controllers.Reg
{
    /// <summary>
    /// 注册表控制器。
    /// </summary>
    public static class RegCtrl
    {
        /// <summary>
        /// 获取注册表键信息。
        /// </summary>
        /// <param name="regPath">
        /// 注册表路径信息。
        /// </param>
        /// <exception cref="Exception">
        /// 非托管代码获取注册表时产生的异常，详情请参阅MSDN。
        /// </exception>
        /// <returns>
        /// 注册表键信息。
        /// </returns>
        public static RegKey RegGetValue(RegPath regPath)
        {
            RegKey regkey;
            try
            {
                var phkresult = RegOpenKey(regPath);
                var lpcbData = 0;
                NativeMethods.RegQueryValueEx(phkresult, regPath.LpValueName, IntPtr.Zero, out var lpkind, IntPtr.Zero, ref lpcbData);
                if (lpcbData == 0)
                {
                    NativeMethods.RegCloseKey(phkresult);
                    throw new Exception(@"注册表访问失败" + '\n' + @"无法获取缓冲区大小" + '\n' + nameof(RegGetValue));
                }
                var lpdata = Marshal.AllocHGlobal(lpcbData);
                var reggetvaluetemp = NativeMethods.RegQueryValueEx(phkresult, regPath.LpValueName, IntPtr.Zero, out lpkind, lpdata, ref lpcbData);
                if (reggetvaluetemp != (int)ERROR_CODE.ERROR_SUCCESS)
                {
                    throw new Exception(@"注册表访问失败" + '\n' + reggetvaluetemp + '\n' + nameof(RegGetValue));
                }
                NativeMethods.RegCloseKey(phkresult);
                if (reggetvaluetemp != (int)ERROR_CODE.ERROR_SUCCESS)
                {
                    throw new Exception(@"注册表访问失败" + '\n' + reggetvaluetemp + '\n' + nameof(RegGetValue));
                }
                regkey = ConvertData(regPath, lpkind, lpdata, lpcbData);
            }
            catch (Exception)
            {
                regkey = new RegKey(regPath);
            }
            return regkey;
        }
        /// <summary>
        /// 设置注册表键。
        /// </summary>
        /// <param name="regKey">
        /// 待设置注册表键信息。
        /// </param>
        public static void RegSetValue(RegKey regKey)
        {
            int regsetvaluetmp, exists;
            IntPtr phkResult;
            if (Environment.Is64BitOperatingSystem)
            {
                regsetvaluetmp = NativeMethods.RegCreateKeyEx(new IntPtr((int)regKey.HKey), regKey.LpSubKey, 0, null,
                    (int)OPERATE_OPTION.REG_OPTION_NON_VOLATILE,
                    (int)KEY_SAM_FLAGS.KEY_WOW64_64KEY | (int)KEY_ACCESS_TYPE.KEY_READ |
                    (int)KEY_ACCESS_TYPE.KEY_WRITE, IntPtr.Zero, out phkResult, out exists);
            }
            else
            {
                regsetvaluetmp = NativeMethods.RegCreateKeyEx(new IntPtr((int)regKey.HKey), regKey.LpSubKey, 0, null,
                    (int)OPERATE_OPTION.REG_OPTION_NON_VOLATILE,
                    (int)KEY_ACCESS_TYPE.KEY_READ |
                    (int)KEY_ACCESS_TYPE.KEY_WRITE, IntPtr.Zero, out phkResult, out exists);
            }
            if (regsetvaluetmp != (int)ERROR_CODE.ERROR_SUCCESS && exists != (int)REG_CREATE_DISPOSITION.REG_OPENED_EXISTING_KEY)
            {
                throw new Exception(@"注册表访问失败" + '\n' + regsetvaluetmp + '\n' + nameof(RegSetValue));
            }
            IntPtr lpdata;
            int lpcbData;
            if (regKey.LpKind == RegistryValueKind.String ||
                regKey.LpKind == RegistryValueKind.MultiString ||
                regKey.LpKind == RegistryValueKind.ExpandString)
            {
                var lpdatastr = regKey.LpValue as string;
                if (lpdatastr is null) throw new NullReferenceException();
                lpcbData = lpdatastr.Length + 1 << 1;
                lpdata = Marshal.StringToHGlobalUni(lpdatastr);
            }
            else if (regKey.LpKind == RegistryValueKind.DWord)
            {
                lpcbData = Marshal.SizeOf(typeof(int));
                lpdata = Marshal.AllocHGlobal(lpcbData);
                Marshal.WriteInt32(lpdata, (int)regKey.LpValue);
            }
            else if (regKey.LpKind == RegistryValueKind.QWord)
            {
                lpcbData = Marshal.SizeOf(typeof(long));
                lpdata = Marshal.AllocHGlobal(lpcbData);
                Marshal.WriteInt64(lpdata, (long)regKey.LpValue);
            }
            else if (regKey.LpKind == RegistryValueKind.Binary)
            {
                var lpdatabin = regKey.LpValue as byte[];
                if (lpdatabin is null) throw new NullReferenceException();
                lpcbData = lpdatabin.Length;
                lpdata = Marshal.AllocHGlobal(lpcbData);
                Marshal.Copy(lpdatabin, 0, lpdata, lpcbData);
            }
            else
            {
                throw new Exception(@"注册表访问失败" + '\n' + regsetvaluetmp + '\n' + nameof(RegSetValue));
            }
            regsetvaluetmp =
                NativeMethods.RegSetValueEx(phkResult, regKey.LpValueName, 0, regKey.LpKind, lpdata, lpcbData);
            NativeMethods.RegCloseKey(phkResult);
            if (regsetvaluetmp != (int)ERROR_CODE.ERROR_SUCCESS)
            {
                throw new Exception(@"注册表访问失败" + '\n' + regsetvaluetmp + '\n' + nameof(RegSetValue));
            }
        }
        /// <summary>
        /// 删除指定注册表键。
        /// </summary>
        /// <param name="regPath">
        /// 注册表键信息。当注册表键名信息为空时，删除注册表子键及其包含键。
        /// </param>
        public static void RegDelKey(RegPath regPath)
        {
            int regdelkeytmp;
            if (string.IsNullOrEmpty(regPath.LpValueName))
            {
                regdelkeytmp = NativeMethods.RegDeleteKeyEx(new IntPtr((int)regPath.HKey), regPath.LpSubKey,
                    (int)KEY_SAM_FLAGS.KEY_WOW64_64KEY | (int)KEY_ACCESS_TYPE.KEY_SET_VALUE, 0);
                if (regdelkeytmp != (int)ERROR_CODE.ERROR_SUCCESS)
                {
                    throw new Exception(@"注册表访问失败" + '\n' + regdelkeytmp + '\n' + nameof(RegDelKey));
                }
            }
            else
            {
                regdelkeytmp = NativeMethods.RegOpenKeyEx(new IntPtr((int)regPath.HKey), regPath.LpSubKey, 0,
                    (int)KEY_SAM_FLAGS.KEY_WOW64_64KEY |
                    (int)KEY_ACCESS_TYPE.KEY_SET_VALUE, out var phkresult);
                if (regdelkeytmp != (int)ERROR_CODE.ERROR_SUCCESS)
                {
                    throw new Exception(@"注册表访问失败" + '\n' + regdelkeytmp + '\n' + nameof(RegDelKey));
                }
                regdelkeytmp = NativeMethods.RegDeleteValue(phkresult, regPath.LpValueName);
                if (regdelkeytmp != (int)ERROR_CODE.ERROR_SUCCESS)
                {
                    throw new Exception(@"注册表访问失败" + '\n' + regdelkeytmp + '\n' + nameof(RegDelKey));
                }
                NativeMethods.RegCloseKey(phkresult);
            }
        }

        /// <summary>
        /// 枚举当前子键下所有键名信息
        /// </summary>
        /// <param name="regPath">
        /// 待枚举注册表键信息
        /// </param>
        /// <param name="comparer"></param>
        /// <returns>
        /// 枚举得到的注册表键名信息
        /// </returns>
        public static RegKey[] RegEnumValue(RegPath regPath, IComparer comparer = null)
        {
            var phkresult = RegOpenKey(regPath);
            var list = new ArrayList();
            for (var index = 0; ; index++)
            {
                var sb = new StringBuilder(0x7FFF);
                var size = 0x7FFF;
                var lpcbdata = 0;
                var renenumvaluetmp = NativeMethods.RegEnumValue(phkresult, index, sb, ref size, IntPtr.Zero, out var lpkind,
                              IntPtr.Zero, ref lpcbdata);
                if (renenumvaluetmp == (int)ERROR_CODE.ERROR_NO_MORE_ITEMS) break;
                if (renenumvaluetmp != (int)ERROR_CODE.ERROR_SUCCESS)
                {
                    throw new Exception(@"注册表键值枚举失败" + '\n' + renenumvaluetmp + '\n' + nameof(RegEnumValue));
                }
                var lpdata = Marshal.AllocHGlobal(lpcbdata);
                renenumvaluetmp = NativeMethods.RegEnumValue(phkresult, index, sb, ref size, IntPtr.Zero, out lpkind,
                    lpdata, ref lpcbdata);
                if (renenumvaluetmp == (int)ERROR_CODE.ERROR_NO_MORE_ITEMS) break;
                if (renenumvaluetmp != (int)ERROR_CODE.ERROR_SUCCESS)
                {
                    throw new Exception(@"注册表键值枚举失败" + '\n' + renenumvaluetmp + '\n' + nameof(RegEnumValue));
                }
                list.Add(ConvertData(new RegPath(regPath.HKey, regPath.LpSubKey, sb.ToString().Trim()), lpkind, lpdata,
                    lpcbdata));
            }
            NativeMethods.RegCloseKey(phkresult);
            var regkeys = list.ToArray(typeof(RegKey)) as RegKey[];
            if (regkeys is null) throw new NullReferenceException();
            if (comparer is null) Array.Sort(regkeys);
            else Array.Sort(regkeys, comparer);
            return regkeys;
        }

        /// <summary>
        /// 枚举当前子键下所有子键信息
        /// </summary>
        /// <param name="regPath">
        /// 待枚举注册表键信息
        /// </param>
        /// <param name="comparer"></param>
        /// <returns>
        /// 枚举得到的注册表键名信息
        /// </returns>
        public static RegPath[] RegEnumKey(RegPath regPath, IComparer comparer = null)
        {
            var phkresult = RegOpenKey(regPath);
            var list = new ArrayList();
            for (var index = 0;;index++)
            {
                var sb = new StringBuilder(0x7FFF);
                var size = 0x7FFF;
                var regenumkeytmp = NativeMethods.RegEnumKeyEx(phkresult, index, sb, ref size, IntPtr.Zero, IntPtr.Zero,
                    IntPtr.Zero, out _);
                if (regenumkeytmp == (int)ERROR_CODE.ERROR_NO_MORE_ITEMS)
                {
                    break;
                }
                if (regenumkeytmp != (int)ERROR_CODE.ERROR_SUCCESS)
                {
                    throw new Exception(@"注册表键值枚举失败" + '\n' + regenumkeytmp + '\n' + nameof(RegEnumKey));
                }
                list.Add(new RegPath(regPath.HKey,regPath.LpSubKey + @"\" + sb));
            }
            NativeMethods.RegCloseKey(phkresult);
            var regpaths = list.ToArray(typeof(RegPath)) as RegPath[];
            if (regpaths is null) throw new NullReferenceException();
            if (comparer is null) Array.Sort(regpaths);
            else Array.Sort(regpaths, comparer);
            return regpaths;
        }
        /// <summary>
        /// 打开注册表子键句柄
        /// </summary>
        /// <param name="regPath">
        /// 待打开的注册表键信息
        /// </param>
        /// <returns>
        /// 注册表子键句柄
        /// </returns>
        private static IntPtr RegOpenKey(RegPath regPath)
        {
            int regopenkeytmp;
            IntPtr phkresult;
            if (Environment.Is64BitOperatingSystem)
            {
                regopenkeytmp = NativeMethods.RegOpenKeyEx(new IntPtr((int)regPath.HKey), regPath.LpSubKey, 0,
                    (int)KEY_SAM_FLAGS.KEY_WOW64_64KEY |
                    (int)KEY_ACCESS_TYPE.KEY_READ, out phkresult);
            }
            else
            {
                regopenkeytmp = NativeMethods.RegOpenKeyEx(new IntPtr((int)regPath.HKey), regPath.LpSubKey, 0,
                    (int)KEY_ACCESS_TYPE.KEY_READ, out phkresult);
            }
            if (regopenkeytmp == (int)ERROR_CODE.ERROR_FILE_NOT_FOUND)
            {
                throw new NullReferenceException(@"注册表访问失败" + '\n' + regopenkeytmp + '\n' + nameof(RegOpenKey));
            }
            if (regopenkeytmp != (int)ERROR_CODE.ERROR_SUCCESS)
            {
                throw new Exception(@"注册表访问失败" + '\n' + regopenkeytmp + '\n' + nameof(RegOpenKey));
            }
            return phkresult;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="regPath"></param>
        /// <param name="lpKind"></param>
        /// <param name="lpData"></param>
        /// <param name="lpcbData"></param>
        /// <returns></returns>
        private static RegKey ConvertData(RegPath regPath, RegistryValueKind lpKind, IntPtr lpData, int lpcbData)
        {
            RegKey regkey;
            if (lpKind == RegistryValueKind.DWord)
            {
                var lpdataint = Marshal.ReadInt32(lpData);
                regkey = new RegKey(regPath, lpKind, lpdataint);
            }
            else if (lpKind == RegistryValueKind.QWord)
            {
                var lpdataint = Marshal.ReadInt64(lpData);
                regkey = new RegKey(regPath, lpKind, lpdataint);
            }
            else if (lpKind == RegistryValueKind.String ||
                     lpKind == RegistryValueKind.ExpandString ||
                     lpKind == RegistryValueKind.MultiString)
            {
                var lpdatastr = Marshal.PtrToStringUni(lpData);
                lpdatastr = lpdatastr?.Trim();
                regkey = new RegKey(regPath, lpKind, lpdatastr);
            }
            else if (lpKind == RegistryValueKind.Binary)
            {
                var lpdatabin = new byte[lpcbData];
                Marshal.Copy(lpData, lpdatabin, 0, lpcbData);
                regkey = new RegKey(regPath, lpKind, lpdatabin);
            }
            else
            {
                throw new Exception(@"注册表访问失败" + '\n' + @"注册表数据类型异常" + '\n' + nameof(ConvertData));
            }
            return regkey;
        }
    }
}
