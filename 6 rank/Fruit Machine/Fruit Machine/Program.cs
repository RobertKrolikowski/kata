using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Machine
{
    class Program
    {
        static void Main(string[] args)
        {            
            string[] reel1 = new string[] { "King", "Jack", "Wild", "Bell", "Star", "Seven", "Queen", "Star", "Shell", "Bar" };
            string[] reel2 = new string[] { "Star", "Star", "Jack", "Seven", "Queen", "Wild", "King", "Bell", "Cherry", "Shell" };
            string[] reel3 = new string[] { "King", "Bell", "Jack", "Shell", "Star", "Cherry", "Queen", "Bell", "Wild", "Seven" };

            List<string[]> reels = new List<string[]> { reel1, reel2, reel3 };
            int[] spins = new int[] {7, 1, 7 };
            int result = fruit(reels, spins);
            Console.WriteLine(result);
            Console.ReadKey();

        }
        //https://www.codewars.com/kata/fruit-machine/
        static public int fruit(List<string[]> reels, int[] spins)
        {
            Dictionary<string, int> images = new Dictionary<string, int>()
            {
                { "Wild", 10},
                { "Star", 9},
                { "Bell", 8 },
                { "Shell", 7 },
                { "Seven", 6 },
                { "Cherry", 5 },
                { "Bar", 4 },
                { "King", 3 },
                { "Queen", 2 },
                { "Jack", 1 }
            };

            string[] reel1 = reels[0];
            string[] reel2 = reels[1];
            string[] reel3 = reels[2];
            var mappedPoints = spins.Select((m, n) => reels[n][m]);
            var mappedPoints1 = spins.Select(m => reels[m][m]);
            if (reel1[spins[0]] == reel2[spins[1]] && reel1[spins[0]] == reel3[spins[2]])
                return images[reel1[spins[0]]] * 10;
            else if (reel1[spins[0]] == reel2[spins[1]])
            {
                if (reel3[spins[2]] == "Wild")
                    return images[reel1[spins[0]]] * 2;
                else
                    return images[reel1[spins[0]]];
            }
            else if (reel1[spins[0]] == reel3[spins[2]])
            {
                if (reel2[spins[1]] == "Wild")
                    return images[reel1[spins[0]]] * 2;
                else
                    return images[reel1[spins[0]]];
            }
            else if (reel2[spins[1]] == reel3[spins[2]])
            {
                if (reel1[spins[0]] == "Wild")
                    return images[reel2[spins[1]]] * 2;
                else
                    return images[reel2[spins[1]]];
            }

            return 0;
        }

    }
}
