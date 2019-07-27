using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Fun_182_Happy_g
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(HappyG("ggtg"));
            Console.ReadKey();
        }
        static public bool HappyG(string str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'g')
                    if ((i + 1 >= str.Length || str[i] != str[i + 1]))
                        if ((i - 1 < 0 || str[i] != str[i - 1]))
                            return false;    
            }

            //return Regex.IsMatch(str, "^(g{2,}|[^g])+$");
            return true;
        }
    }
}
