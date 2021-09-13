using System;
using System.Linq;
using lesson4.ArrayFromString;
using lesson4.Name;

namespace lesson4
{
    class Program
    {
        static void Main()
        {
            ShowSomeNames();
            var numbers = Parser.GetNumbersFrom(Console.ReadLine());
            Console.WriteLine(SumNumbers(numbers));
        }

        private static void ShowSomeNames()
        {
            Console.WriteLine(new FullName("Иван", "Иванов", "Иванович").GetName());
            Console.WriteLine(new FullName("AAA", "CCC", "BBB").GetName());
            Console.WriteLine(new FullName("Александр", "Путин", "Сергевич").GetName());
        }

        public static double SumNumbers(params double[] array) => array.Aggregate((x,y) => x + y);
    }
}
