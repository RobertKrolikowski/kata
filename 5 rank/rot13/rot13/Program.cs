using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rot13
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = Rot13("test");
            System.Console.WriteLine(result);
            System.Console.ReadLine();
        }

        public static string Rot13(string message)
        {
            string result = "";
            char a;
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] >= 97 && message[i] <= 122)
                    a = (message[i] + 13 > 122) ? (char)(message[i] - 13) : (char)(message[i] + 13);
                else if (message[i] >= 65 && message[i] <= 90)
                    a = (message[i] + 13 > 90) ? (char)(message[i] - 13) : (char)(message[i] + 13);
                else
                    a = message[i];
                result += a;
            }
            return result;
        }
    }
}
