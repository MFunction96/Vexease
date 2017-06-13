using System;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace CommunalComputerManager.Common
{
    internal static class NativeMethods
    {
        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode, EntryPoint = "RegSetValueExW")]
        public static extern int RegSetValueEx(
            UIntPtr hKey,
            [MarshalAs(UnmanagedType.LPWStr)] string lpValueName,
            uint lpReserved,
            RegistryValueKind dwType,
            [MarshalAs(UnmanagedType.LPWStr)] string lpData,
            uint cbData);

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode, EntryPoint = "RegSetValueExW")]
        public static extern int RegSetValueEx(
            UIntPtr hKey,
            [MarshalAs(UnmanagedType.LPWStr)] string lpValueName,
            uint lpReserved,
            RegistryValueKind dwType,
            UIntPtr lpData,
            uint cbData);

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode, EntryPoint = "RegQueryValueExW")]
        public static extern int RegQueryValueEx(
            UIntPtr hKey,
            [MarshalAs(UnmanagedType.LPWStr)] string lpValueName,
            UIntPtr lpReserved,
            out RegistryValueKind lpType,
            [MarshalAs(UnmanagedType.LPWStr)] string lpData,
            ref uint lpcbData);

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode, EntryPoint = "RegQueryValueExW")]
        public static extern int RegQueryValueEx(
            UIntPtr hKey,
            [MarshalAs(UnmanagedType.LPWStr)] string lpValueName,
            UIntPtr lpReserved,
            ref RegistryValueKind lpType,
            UIntPtr lpData,
            ref uint lpcbData);

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode, EntryPoint = "RegCreateKeyExW")]
        public static extern int RegCreateKeyEx(
            UIntPtr hKey,
            [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey,
            uint lpReserved,
            [MarshalAs(UnmanagedType.LPWStr)] string lpClass,
            uint dwOptions,
            uint samDesired,
            ref SECURITY_ATTRIBUTES lpSecurityAttributes,
            out UIntPtr phkResult,
            out uint lpdwDisposition);

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode, EntryPoint = "RegOpenKeyExW")]
        public static extern int RegOpenKeyEx(
            UIntPtr hKey,
            [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey,
            uint ulOptions,
            uint samDesired,
            out UIntPtr hkResult);

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode, EntryPoint = "RegDeleteKeyExW")]
        public static extern int RegDeleteKeyEx(
            UIntPtr hKey,
            [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey,
            uint samDesired,
            uint lpReserved);

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode, EntryPoint = "RegDeleteValueW")]
        public static extern int RegDeleteValueEx(
            UIntPtr hKey,
            [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey);

        [DllImport("advapi32.dll", SetLastError = true)]
        public static extern int RegCloseKey(UIntPtr hKey);

        [DllImport("kernel32.dll")]
        public static extern uint GetLastError();

    }
}
