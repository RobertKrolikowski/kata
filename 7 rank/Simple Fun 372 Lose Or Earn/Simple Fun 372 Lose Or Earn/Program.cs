using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Fun_372_Lose_Or_Earn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LoseOrEarn(40, 70, 0, 30));
            Console.ReadKey();
        }
        //https://www.codewars.com/kata/simple-fun-number-372-lose-or-earn
        public static string LoseOrEarn(int costPrice, int sellPrice, int fakeMoney, int paidBack)
        {
            string result = (sellPrice - costPrice - fakeMoney > 0) ? "Earned $" + (sellPrice - costPrice - fakeMoney) :
            "Lost $" + ((sellPrice - costPrice - fakeMoney) * -1);
            return result;
        }
    }
}
