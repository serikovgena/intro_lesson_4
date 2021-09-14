using System;
namespace lesson4.Seasons
{
    [Flags]
    public enum Month
    {
        January   = 0b000000000001,
        February  = 0b000000000010,
        March     = 0b000000000100,
        April     = 0b000000001000,
        May       = 0b000000010000,
        June      = 0b000000100000,
        July      = 0b000001000000,
        August    = 0b000010000000,
        September = 0b000100000000,
        October   = 0b001000000000,
        November  = 0b010000000000,
        December  = 0b100000000000
    }
}
