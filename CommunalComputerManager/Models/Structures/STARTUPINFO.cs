using System;
using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace CommunalComputerManager.Models.Structures
{
    [StructLayout(LayoutKind.Sequential)]
    public struct STARTUPINFO
    {
        public uint cb;
        public string lpReserved;
        public string lpDesktop;
        public string lpTitle;
        public uint dwX;
        public uint dwY;
        public uint dwXSize;
        public uint dwYSize;
        public uint dwXCountChars;
        public uint dwYCountChars;
        public uint dwFillAttribute;
        public uint dwFlags;
        public short wShowWindow;
        public short cbReserved2;
        public UIntPtr lpReserved2;
        public UIntPtr hStdInput;
        public UIntPtr hStdOutput;
        public UIntPtr hStdError;
    }
}
