using System;

namespace lesson4.Seasons
{
    [Flags]
    public enum Season
    {
        Winter    = 0b100000000011,
        Spring    = 0b000000011100,
        Summer    = 0b000011100000,
        Fall      = 0b011100000000,
    }
}
