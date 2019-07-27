using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_Word_Count_Matching_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountCorrectCharacters("dogf", "cag").ToString());
            Console.ReadKey();
        }
        static public int CountCorrectCharacters(string correctWord, string guess)
        {
            if(correctWord.Length != guess.Length)
                throw new InvalidOperationException();

            int result = 0;
            for (int i = 0; i < correctWord.Length; i++)
            {
                if (correctWord[i] == guess[i])
                    result++;
            }
            
            //return correctWord.Zip(guess, (x, y) => x == y).Count(x => x);
            return result;
        }
    }
}
