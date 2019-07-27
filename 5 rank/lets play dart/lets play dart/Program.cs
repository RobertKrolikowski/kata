using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lets_play_dart
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = GetScore(55.53, -87.95);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        //https://www.codewars.com/kata/lets-play-darts/train/csharp
        static public string GetScore(double x, double y)
        {
            //Outside of the board: "X"
            //Bull's eye: "DB"
            //Bull: "SB"
            //A single number, example: "10"
            //A triple number: "T10"
            //A double number: "D10"
            //Bull's eye: 12.70 mm
            //Bull: 31.8 mm
            //Triple ring inner circle: 198 mm
            //Triple ring outer circle: 214 mm
            //Double ring inner circle: 324 mm
            //Double ring outer circle: 340 mm
            string result = "";
            double distance = (x * x) + (y * y);
            distance = Math.Sqrt(distance);
            if (distance <= 6.35)
                return "DB";
            else if (distance <= 15.9)
                return "SB";
            else if (distance > 170)
                return "X";
            else if (distance > 99 && distance < 107)
                result = "T";
            else if (distance > 162 && distance < 170)
                result = "D";
           
            double angel = -1;
            if (x >= 0 && y >= 0)
            {
                angel = (Math.Atan2(x, y) * (180 / Math.PI));
            }
            else if (x >= 0 && y < 0)
            {
                angel = (Math.Atan2(x, y) * (180 / Math.PI));
            }
            else if (x < 0 && y < 0)
            {
                angel = 360 +(Math.Atan2(x, y) * (180 / Math.PI));
            }
            else if (x < 0 && y > 0)
            {
                angel = 360 +(Math.Atan2(x, y) * (180 / Math.PI));// + 90;
            }
            int[] points = { 20, 1, 18, 4, 13, 6, 10, 15, 2, 17, 3, 19, 7, 16, 8, 11, 14, 9, 12, 5, 20 };
            for (int i = 0; i <= 20; i++)
            {
                if (angel < 9 + (18 * i))
                {
                    result += points[i].ToString();
                    break;
                }
            }

            return result;
            
         }
    }

}
