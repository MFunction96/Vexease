using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32;

namespace CommunalComputerManager.Common
{
    internal static class NativeMethods
    {
        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode, EntryPoint = "RegSetValueExW")]
        public static extern uint RegSetValueEx(
            UIntPtr hKey,
            [MarshalAs(UnmanagedType.LPWStr)] string lpValueName,
            uint lpReserved,
            RegistryValueKind dwType,
            [MarshalAs(UnmanagedType.LPWStr)] string lpData,
            uint cbData);

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode, EntryPoint = "RegSetValueExW")]
        public static extern uint RegSetValueEx(
            UIntPtr hKey,
            [MarshalAs(UnmanagedType.LPWStr)] string lpValueName,
            uint lpReserved,
            RegistryValueKind dwType,
            IntPtr lpData,
            uint cbData);

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode, EntryPoint = "RegSetValueExW")]
        public static extern uint RegSetValueEx(
            UIntPtr hKey,
            [MarshalAs(UnmanagedType.LPWStr)] string lpValueName,
            uint lpReserved,
            RegistryValueKind dwType,
            byte[] lpData,
            uint cbData);

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode, EntryPoint = "RegQueryValueExW")]
        public static extern uint RegQueryValueEx(
            UIntPtr hKey,
            [MarshalAs(UnmanagedType.LPWStr)] string lpValueName,
            UIntPtr lpReserved,
            out RegistryValueKind lpType,
            IntPtr lpData,
            ref uint lpcbData);

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode, EntryPoint = "RegQueryValueExW")]
        public static extern uint RegQueryValueEx(
            UIntPtr hKey,
            [MarshalAs(UnmanagedType.LPWStr)] string lpValueName,
            UIntPtr lpReserved,
            out RegistryValueKind lpType,
            StringBuilder lpData,
            ref uint lpcbData);

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode, EntryPoint = "RegCreateKeyExW")]
        public static extern uint RegCreateKeyEx(
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
        public static extern uint RegOpenKeyEx(
            UIntPtr hKey,
            [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey,
            uint ulOptions,
            uint samDesired,
            out UIntPtr hkResult);

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode, EntryPoint = "RegDeleteKeyExW")]
        public static extern uint RegDeleteKeyEx(
            UIntPtr hKey,
            [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey,
            uint samDesired,
            uint lpReserved);

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode, EntryPoint = "RegDeleteValueW")]
        public static extern uint RegDeleteValueEx(
            UIntPtr hKey,
            [MarshalAs(UnmanagedType.LPWStr)] string lpSubKey);

        [DllImport("advapi32.dll", SetLastError = true)]
        public static extern uint RegCloseKey(UIntPtr hKey);

        [DllImport("kernel32.dll")]
        public static extern uint GetLastError();

    }
}
