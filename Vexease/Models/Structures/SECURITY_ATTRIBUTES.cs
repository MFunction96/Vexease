using System;
using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace Vexease.Models.Structures
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SECURITY_ATTRIBUTES
    {
        public int nLength;
        public IntPtr lpSecurityDescriptor;
        public bool bInheritHandle;
    }
}
