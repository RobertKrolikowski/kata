using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_characters_in_your_string
{
    class Program
    {
        static void Main(string[] args)
        {
            var result  = Count("aagcbcda");
            foreach(var res in result)
                Console.WriteLine("{0} : {1}",res.Key, res.Value);
            Console.ReadLine();
        }
        public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (dictionary.Count == 0)
                    dictionary.Add(str[i], 1);
                else
                {
                    if (dictionary.ContainsKey(str[i]))
                    {
                        dictionary[str[i]] += 1;
                    }
                    else
                        dictionary.Add(str[i], 1);
                }
            }

            return dictionary;
            //return str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        }
    }
}
