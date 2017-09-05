// ReSharper disable InconsistentNaming

using System;

namespace Vexease.Models.Enums
{
    /// <summary>
    /// 页面文件控制选项。
    /// </summary>
    [Flags]
    public enum FILE_CACHE_FLAGS
    {
        FILE_CACHE_MAX_HARD_ENABLE = 0x1,
        FILE_CACHE_MAX_HARD_DISABLE = 0x2,
        FILE_CACHE_MIN_HARD_ENABLE = 0x4,
        FILE_CACHE_MIN_HARD_DISABLE = 0x8
    }
}
