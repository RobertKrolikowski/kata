using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_in_the_Amazon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountArara(3));
            Console.ReadKey();
        }

        public static string CountArara(int n)
        {
            //adak anane
            string result = "";
            for(int i = 1; i < n; i+=2)
            {
                result += (i + 2 < n || n % 2 != 0) ? "adak " : "adak";
            }

            if (n % 2 != 0)
                result += "anane";
            

            return result;
        }
    }
}
