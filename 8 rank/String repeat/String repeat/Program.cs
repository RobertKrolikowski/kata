using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_repeat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(repeatStr(5,"hello"));
            Console.ReadLine();
        }
        public static string repeatStr(int n, string s)
        {
            string result = "";
            for (int i = 0; i < n; i++)
                result += s;
            return result;
        }
    }
}
