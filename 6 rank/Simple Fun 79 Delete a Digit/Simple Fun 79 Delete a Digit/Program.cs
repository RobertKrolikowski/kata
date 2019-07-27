using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Fun_79_Delete_a_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = DeleteDigit(1001);
            System.Console.WriteLine(result);
            System.Console.ReadLine();
        }

        static public int DeleteDigit(int n)
        {
            string number = n.ToString();
            int max = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int buff = int.Parse(number.Remove(i,1));
                if (max < buff)
                    max = buff;
            }

            return max;
        }
    }
}
