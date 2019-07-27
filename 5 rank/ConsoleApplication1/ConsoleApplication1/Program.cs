using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] sudoku1 =
            {
                new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
                new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
                new int[] {1, 9, 8, 3, 4, 2, 5, 6, 7},
                new int[] {8, 5, 9, 7, 6, 1, 4, 2, 3},
                new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
                new int[] {7, 1, 3, 9, 2, 4, 8, 5, 6},
                new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
                new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
                new int[] {3, 4, 5, 2, 8, 6, 1, 7, 9},
            };
            int[][] sudoku2 =
            {
              new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
              new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
              new int[] {1, 9, 8, 3, 0, 2, 5, 6, 7},
              new int[] {8, 5, 0, 7, 6, 1, 4, 2, 3},
              new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
              new int[] {7, 0, 3, 9, 2, 4, 8, 5, 6},
              new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
              new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
              new int[] {3, 0, 0, 2, 8, 6, 1, 7, 9},
            };



            Console.WriteLine(DoneOrNot(sudoku1));
            Console.ReadKey();
        }
        //https://www.codewars.com/kata/53db96041f1a7d32dc0004d2
        public static string DoneOrNot(int[][] board)
        {
            //check rows
            for (int i = 0; i < 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 0; k < 9; k++)
                    {
                        if (board[i][k] == j)
                        {
                            break;
                        }
                        else if(k == 8 && board[i][k] != j)
                            return "Try again!";
                    }
                }
            }

            //check columns
            for (int i = 0; i < 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 0; k < 9; k++)
                    {
                        if (board[k][i] == j)
                        {
                            break;
                        }
                        else if (k == 8 && board[k][i] != j)
                            return "Try again!";
                    }
                }
            }
            //squares
            bool isInNumber;
            for (int a = 0; a < 9; a++)
            {
                for (int i = 1; i <= 9; i++)
                {
                    isInNumber = false;
                    for (int j = (a / 3 * 3); j < (a / 3 * 3) + 3; j++)
                    {
                        for (int k = (a % 3) * 3; k < (a % 3) * 3 + 3; k++)
                        {
                            if (board[j][k] == i)
                            {
                                isInNumber = true;
                                break;
                            }
                        }                       
                    }                   
                    if (isInNumber == true)
                    {
                        isInNumber = false;
                        break;
                    }
                    else
                        return "Try again!";
                }
            }
                return "Finished!";
        }
    }
}
