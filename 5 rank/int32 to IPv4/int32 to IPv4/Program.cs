using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace int32_to_IPv4
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = UInt32ToIP(0);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public static string UInt32ToIP(uint ip)
        {
            string result = "";
            string binary = Convert.ToString(ip, 2);

            for (int i = 3; i >= 0; i--)
            {
                if (binary.Length > i * 8)
                {
                    result += Convert.ToUInt32(binary.Substring(0, binary.Length - i * 8), 2);
                    binary = binary.Substring(binary.Length - i * 8);
                }
                else
                    result += "0";
                result += (i == 0) ? "" : ".";
            }

            return result;
        }
    }
}
