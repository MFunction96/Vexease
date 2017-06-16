using System;
using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace CommunalComputerManager.Common
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SECURITY_ATTRIBUTES
    {
        private readonly uint nLength;
        private readonly UIntPtr lpSecurityDescriptor;
        private readonly int bInheritHandle;
    }
}
