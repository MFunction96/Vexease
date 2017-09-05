// ReSharper disable InconsistentNaming

using System;

namespace Vexease.Models.Enums
{
    /// <summary>
    /// 进程信息类型。
    /// </summary>
    [Flags]
    public enum TASK_TYPE_FLAGS
    {
        RESTRICT_TASK_NAME = 0,
        DISALLOW_TASK_NAME = 1,
        RESTRICT_TASK_PATH = 2,
        DISALLOW_TASK_PATH = 3
    }
}
