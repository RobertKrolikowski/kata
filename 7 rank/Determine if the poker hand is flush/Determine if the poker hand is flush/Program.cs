using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Determine_if_the_poker_hand_is_flush
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static bool CheckIfFlush(string[] cards)
        {
            int counter = 0;
            for (int i = 0; i < cards.Length - 1; i++)
            {
                if (cards[i][cards[i].Length - 1] == cards[i + 1][cards[i+1].Length - 1])
                    counter++;
            }
            if (counter == 4)
                return true;
            else
                return false;


        }
    }
}
