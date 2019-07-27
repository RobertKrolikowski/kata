using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Nico_variation
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = Nico("crazy", "secretinformation");
            Console.WriteLine(result);
            Console.ReadKey();
        }
        public static string Nico(string key, string message)
        {
            string[] s= new string[key.Length];
            Dictionary<char, string> d = new Dictionary<char, string>();
            for (int i = 0, j = 0; i < message.Length; i++, j++)
            {
                if (j == key.Length)
                    j = 0;

                s[j] += message[i];
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[0].Length != s[i].Length)
                    s[i] += " ";
            }

            for (int i = 0; i < s.Length; i++)
            {
                d.Add(key[i], s[i]);
            }
            //var items = from pair in d
            //            orderby pair.Key ascending
            //            select pair;
            string result = "";
            foreach (KeyValuePair<char, string> sorted in d.OrderBy(i => i.Key))
            {
                result += sorted.Value;
            }
            return result;
            //2 3 1 5 4
            //-------- -
            //s e c r e
            //t i n f o
            //r m a t i
            //o n
            //After using the key:

            //1 2 3 4 5
            //-------- -
            //c s e e r
            //n t i o f
            //a r m i t
            //  o n

        }
    }
}
