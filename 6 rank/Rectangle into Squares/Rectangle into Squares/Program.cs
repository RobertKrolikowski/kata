using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_into_Squares
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> result = sqInRect(5,3);
            for (int i = 0; i < result.Count;i++)
            {
                Console.Write("{0} ",result[i]);
            }           
            Console.ReadKey();
        }
        https://www.codewars.com/kata/rectangle-into-squares
        public static List<int> sqInRect(int lng, int wdth)
        {
            List<int> result = new List<int>();
            if (lng == wdth)
                return null;
            do
            {
                if (lng > wdth)
                {
                    lng -= wdth;
                    result.Add(wdth);
                }
                else
                {
                    wdth -= lng;
                    result.Add(lng);
                }
            }
            while (lng != 0 && wdth != 0);

            return result;
        }
    }
}
