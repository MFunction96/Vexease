using System;
using System.Runtime.InteropServices;
using Vexease.Controllers.PInvoke;
using Vexease.Models.Structures;

namespace Vexease.Controllers.TaskCtrl
{
    public class TaskCtrl
    {
        public static PROCESS_INFORMATION CreateProcessEx(string appName = null, string cmdLine = null, STARTUPINFO si = new STARTUPINFO())
        {
            var sap = new SECURITY_ATTRIBUTES
            {
                lpSecurityDescriptor = IntPtr.Zero,
                bInheritHandle = true
            };
            sap.nLength = Marshal.SizeOf(sap);
            var ptrsap = Marshal.AllocHGlobal(sap.nLength);
            Marshal.StructureToPtr(sap, ptrsap, false);
            var sat = new SECURITY_ATTRIBUTES
            {
                lpSecurityDescriptor = IntPtr.Zero,
                bInheritHandle = true
            };
            sat.nLength = Marshal.SizeOf(sat);
            var ptrsat = Marshal.AllocHGlobal(sat.nLength);
            Marshal.StructureToPtr(sat, ptrsat, false);
            var cmd = cmdLine != null ? string.Copy(cmdLine) : "";
            if (NativeMethods.CreateProcess(appName, cmd, ptrsap, ptrsat, true, 0, IntPtr.Zero, null,
                    ref si, out var pi))
            {
                return pi;
            }
            throw new Exception(@"进程创建失败" + "\n" + NativeMethods.GetLastError());
        }
    }
}
