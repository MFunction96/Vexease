// ReSharper disable InconsistentNaming

using System;

namespace CommunalComputerManager.Models.Enums
{
    [Flags]
    public enum KEY_SAM_FLAG : uint
    {
        KEY_WOW64_64KEY = 0x100u,
        KEY_WOW64_32KEY = 0x200u
    }
}
