using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("");
            Console.ReadLine();
        }
        public static int[] ReverseSeq(int n)
        {
            return Enumerable.Range(1, n).Reverse().ToArray();
        }
        public static int[] MonkeyCount(int n)
        {
            return Enumerable.Range(1, n).ToArray();
        }
    }
}
