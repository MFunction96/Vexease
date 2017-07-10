using System;
using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace CommunalComputerManager.Common
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESS_INFORMATION
    {
        public UIntPtr hProcess;
        public UIntPtr hThread;
        public int ProcessId;
        public int ThreadId;
    }
}
