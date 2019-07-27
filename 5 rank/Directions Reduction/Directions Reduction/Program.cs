using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directions_Reduction
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
            string[] result = dirReduc(a);
            foreach (string s in result)
                Console.WriteLine(s);
            Console.ReadLine();

        }
        public static string[] dirReduc(String[] arr)
        {
            string[] result = new string[1];
            int x = 0, y = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == "NORTH")
                    y--;
                else if (arr[i] == "SOUTH")
                    y++;
                else if (arr[i] == "EAST")
                    x++;
                else
                    x--;
            }

            return result;
        }
    }
}
