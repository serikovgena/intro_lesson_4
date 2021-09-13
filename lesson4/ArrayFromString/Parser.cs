using System;
using System.Globalization;
using System.Linq;

namespace lesson4.ArrayFromString
{
    static class Parser
    {
        static public double[] GetNumbersFrom(string strNumbers)
        {
            if (string.IsNullOrEmpty(strNumbers))
            {
                throw new ArgumentNullException("strNumbers is NULL");
            }

            try
            {
                var temp = strNumbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var temp2 = temp.Select(x => { return double.Parse(x.Replace(',', '.'), CultureInfo.InvariantCulture); });
                return temp2.ToArray();
            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch (InvalidCastException)
            {
                //Console.WriteLine("Введенная строка на является набором, состоящим только из чисел");
                throw;
            }
        }
    }
}