using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bingo_card
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = GetCard();
            Console.WriteLine();
            Console.ReadKey();
        }
        //https://www.codewars.com/kata/bingo-card
        public static string[] GetCard()
        {
            Random rand = new Random();
            string result = "";
            string bingo = "BINGO";
            for (int i = 0, j = -1; i < 25; i++)
            {
                if (i == 13)
                    continue;
                if (i % 5 == 0)
                    j++;
                result += bingo[j] +""+ rand.Next((j * 15) + 1, (j + 1) * 15)+" ";              
            }
            return result.Split(' ');
        }
    }
}
