// ReSharper disable InconsistentNaming

using System;

namespace CommunalComputerManager.Models.Enums
{
    [Flags]
    public enum KEY_ACCESS_TYPE : uint
    {
        KEY_ALL_ACCESS = 0x3Fu,
        KEY_READ = 0x20019u,
        KEY_WRITE = 0x20006u,
        KEY_SET_VALUE = 0x0002u,
        KEY_QUERY_VALUE = 0x0001u
    }
}
