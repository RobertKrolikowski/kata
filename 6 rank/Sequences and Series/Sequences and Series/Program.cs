using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequences_and_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetScore(4));
            Console.ReadKey();
        }
        //https://www.codewars.com/kata/sequences-and-series
        public static long GetScore(long n)
        {
            long result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += 50 * i; 
            }
            return result;
        }
    }
}
