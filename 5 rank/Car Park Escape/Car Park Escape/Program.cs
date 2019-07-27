using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Park_Escape
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] carpark = new int[,] { { 1, 0, 0, 0, 0 },
                                          { 0, 0, 0, 0, 1 },
                                          { 1, 0, 2, 0, 0 },
                                          { 0, 0, 0, 0, 0 } };
            string[] result = escape(carpark);
            foreach(string element in result )
                Console.WriteLine(element);
            Console.ReadLine();
        }
        static public string[] escape(int[,] carpark)
        {
            string result = "";
            int start = 0;
            int staircases = -1;
            int down = 0;
            //for (int i = 0; i < carpark.GetLength(0); i++)
            //{
            //    if (carpark.GetLength(0) - 1 == i)
            //        staircases = carpark.GetLength(1) - 1;
            //    for (int j = 0; j < carpark.GetLength(1); j++)
            //    {
            //        if (carpark[i, j] == 1)
            //            staircases = j;
            //        else if(carpark[i, j] == 2)
            //        {
            //            start = j;
            //        }                                  
            //    }
            //    if(start - staircases !=0)
            //        result += (staircases != -1 && start - staircases > 0) ? "L" + (start - staircases) + " " :
            //            "R" + Math.Abs(start - staircases) + " ";
            //    for (int k = i; k < carpark.GetLength(0); k++)
            //    {
            //        if (carpark[k, staircases] == 1)
            //            down++;
            //        else
            //        {
            //            carpark[k, staircases] = 2;
            //            break;
            //        }
            //    }
            //    if (carpark.GetLength(0) - 1 != i)
            //        result += "D" + down+ " ";
            //    i += (down > 0)? down - 1 : 0;
            //    down = 0;
            //    staircases = -1;
            //}
            for (int i = 0; i < carpark.GetLength(0); i++)
            {
                for (int j = 0; j < carpark.GetLength(1); j++)
                {
                    if (carpark[i, j] == 2)
                    {
                        down = i;
                        start = j;
                    }
                }
            }

            for (int i = down; i < carpark.GetLength(0);)
            {
                down = 0;
                for (int j = 0; j < carpark.GetLength(1); j++)
                {
                    if (carpark[i, j] == 1)
                        staircases = j;
                }

                if (staircases == -1)
                {
                    staircases = carpark.GetLength(1) - 1;
                    if (start != staircases)
                    {
                        result += ((start - staircases) > 0) ? "L" : "R";
                        result += Math.Abs(start - staircases) + " ";
                    }
                    break;
                }
                else
                { 
                    result += ((start - staircases) > 0) ? "L" : "R";
                    result += Math.Abs(start - staircases) + " ";
                    start = staircases;
                }
                for (int j = i; j < carpark.GetLength(0); j++)
                {
                    if (carpark[j, start] == 1)
                        down++;
                    else
                        break;
                }
                result += (down > 0) ? "D" + down + " ": "";
                i += down;
                down = 0;
                staircases = -1;
            }
            return result.Split( new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
