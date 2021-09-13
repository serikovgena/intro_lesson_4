using System;

namespace lesson4.Name
{
    public class NamePartNullException : Exception
    {
        public NamePartNullException(string message)
            : base(message) { }
    }
}
