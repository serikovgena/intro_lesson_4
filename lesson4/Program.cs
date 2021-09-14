using System;
using System.Linq;
using lesson4.ArrayFromString;
using lesson4.Name;
using lesson4.Seasons;

namespace lesson4
{
    class Program
    {
        static void Main()
        {
            ShowSomeNames();
            ShowSumNumbers();
            ShowSeason();
        }

        static void ShowSomeNames()
        {
            Console.WriteLine(new FullName("Иван", "Иванов", "Иванович").GetName());
            Console.WriteLine(new FullName("AAA", "CCC", "BBB").GetName());
            Console.WriteLine(new FullName("Александр", "Путин", "Сергевич").GetName());
        }

        static double SumNumbers(params double[] array) => array.Aggregate((x,y) => x + y);

        static void ShowSumNumbers()
        {
            Console.Write("Insert set of numbers splitted by spaces: ");
            var numbers = Parser.GetNumbersFrom(Console.ReadLine());
            Console.WriteLine($"the sum of that set: {SumNumbers(numbers)}");
        }

        static void ShowSeason()
        {
            Console.Write("Insert month number: ");
            int monthNum = Convert.ToInt32(Console.ReadLine());
            Season season = YearSeason.RevealSeasonBy(monthNum);
            Console.WriteLine($"You inserted {season}'s month!");
        }
    }
}
