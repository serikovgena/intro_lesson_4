using System;

namespace lesson4.Seasons
{
    public class OutOfMonthRangeException : Exception
    {
        public OutOfMonthRangeException()
            : base("Ошибка: введите число от 1 до 12") { }
    }
}
