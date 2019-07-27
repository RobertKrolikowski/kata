using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missing_Alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = InsertMissingLetters("holly");
            System.Console.WriteLine(result);
            System.Console.ReadLine();
        }
        public static string InsertMissingLetters(string str)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (alphabet[j].Equals(str[i]))
                    {
                        result += str[i] + alphabet.Remove(0,j+1).ToUpper(); 
                    }
                }
            }
            return result;
        }
    }
}
