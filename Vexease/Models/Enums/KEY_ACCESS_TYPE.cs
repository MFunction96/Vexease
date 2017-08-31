// ReSharper disable InconsistentNaming

using System;

namespace Vexease.Models.Enums
{
    /// <summary>
    /// 注册表访问权限
    /// </summary>
    [Flags]
    public enum KEY_ACCESS_TYPE
    {
        KEY_ALL_ACCESS = 0x3F,
        KEY_READ = 0x20019,
        KEY_WRITE = 0x20006,
        KEY_SET_VALUE = 0x0002,
        KEY_QUERY_VALUE = 0x0001
    }
}
