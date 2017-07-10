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
            IntPtr lpSecurityAttributes,
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

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode, EntryPoint = "RegEnumKeyExW")]
        public static extern uint RegEnumKeyEx(
            UIntPtr hKey,
            uint dwIndex,
            StringBuilder lpValueName,
            ref uint lpcValueName,
            IntPtr lpReserved,
            IntPtr lpType,
            IntPtr lpData,
            IntPtr lpcbData);

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode, EntryPoint = "RegEnumValueW")]
        public static extern uint RegEnumValue(
            UIntPtr hKey,
            uint dwIndex,
            StringBuilder lpValueName,
            ref uint lpcValueName,
            IntPtr lpReserved,
            IntPtr lpType,
            IntPtr lpData,
            IntPtr lpcbData);

        [DllImport("advapi32.dll", SetLastError = true)]
        public static extern uint RegCloseKey(UIntPtr hKey);

        [DllImport("kernel32.dll")]
        public static extern uint GetLastError();

        [DllImport("coredll.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "CreateProcessW")]
        public static extern bool CreateProcess(
            string lpApplicationName,
            string lpCommandLine,
            IntPtr lpProcessAttributes,
            IntPtr lpThreadAttributes,
            bool bInheritHandles,
            uint dwCreationFlags,
            IntPtr lpEnvironment,
            string lpCurrentDirectory,
            IntPtr lpStartupInfo,
            out IntPtr lpProcessInformation
        );

    }
}
