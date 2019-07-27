using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Fun_16_Apple_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AppleBoxes(5));
            Console.ReadKey();
        }
        static public int AppleBoxes(int k)
        {
            int yellow = 0, red = 0;
            for (int i = 1; i <= k; i++)
            {
                if (i % 2 == 0)
                    red += i * i;
                else
                    yellow += i * i;
            }
            return red - yellow;
        }
    }
}
