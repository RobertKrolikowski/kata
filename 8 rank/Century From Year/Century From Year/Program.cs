using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Century_From_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(СenturyFromYear(2000));
            Console.ReadKey();
        }
        //https://www.codewars.com/kata/century-from-year
        public static int СenturyFromYear(int year)
        {
            return (year % 100 >= 1) ? year / 100 + 1 : year / 100;
        }
    }
}
