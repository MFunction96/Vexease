using System;
using System.Runtime.InteropServices;
using CommunalComputerManager.Controllers.PInvoke;
using CommunalComputerManager.Models.Structures;

namespace CommunalComputerManager.Controllers.ProcCtrl
{
    public class ProcCtrl
    {
        public static PROCESS_INFORMATION CreateProcessEx(string appPath, string cmdLine = null)
        {
            NativeMethods.CreateProcess(appPath, cmdLine, IntPtr.Zero, IntPtr.Zero, true, 0, IntPtr.Zero, null, IntPtr.Zero, out var pi);
            return (PROCESS_INFORMATION)Marshal.PtrToStructure(pi, typeof(PROCESS_INFORMATION));

        }
    }
}
