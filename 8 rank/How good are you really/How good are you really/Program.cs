using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace How_good_are_you_really
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BetterThanAverage(new int[] { 100, 40, 34, 57, 29, 72, 57, 88 }, 5));
            Console.ReadKey();
        }
        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            return (ClassPoints.Average() < YourPoints) ? true : false;
        }
    }
}
