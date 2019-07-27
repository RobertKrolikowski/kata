using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_First_and_Last_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Remove_char("helloaaa"));
            Console.ReadLine();
        }
        public static string Remove_char(string s)
        {          
            return s.Substring(1, s.Length - 2);
        }
    }
}
