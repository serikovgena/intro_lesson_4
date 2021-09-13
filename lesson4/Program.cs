using System;
using lesson4.Name;

namespace lesson4
{
    class Program
    {
        static void Main()
        {
            ShowSomeNames();
        }

        private static void ShowSomeNames()
        {
            Console.WriteLine(new FullName("Иван", "Иванов", "Иванович").GetName());
            Console.WriteLine(new FullName("AAA", "CCC", "BBB").GetName());
            Console.WriteLine(new FullName("Александр", "Путин", "Сергевич").GetName());
        }
    }
}
