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
            //ShowSomeNames();
            //ShowSumNumbers();
            //ShowSeason();
            ShowFibonachiNum();
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

        static void ShowFibonachiNum()
        {
            Console.Write("insert number of fibonachi's digit: ");
            Console.WriteLine($"fibonachi num is : {GetFibonachiNumBy(Convert.ToInt32(Console.ReadLine()))}");
        }
        static int GetFibonachiNumBy(int num)
        {
            if (num <= 1) return 0;
            if (num == 2) return 1;
            else
                return GetFibonachiNumBy(num - 2) + GetFibonachiNumBy(num - 1); // 3 -> (2 + 1) -> 0 + 1 = 1 
        }
    }
}
