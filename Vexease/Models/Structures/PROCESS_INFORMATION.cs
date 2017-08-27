using System;
using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace Vexease.Models.Structures
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESS_INFORMATION
    {
        public IntPtr hProcess;
        public IntPtr hThread;
        public int ProcessId;
        public int ThreadId;
    }
}
