using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pong
{
    class Program
    {
        class Pong
        {
            private int maxScore;
            int player1Score = 0;
            int player2Score = 0;
            bool isPlayer1Turn = true;
            bool isGameOver = false;
            public Pong(int maxScore)
            {
                this.maxScore = maxScore;
            }

            public string play(int ballPos, int playerPos)
            {
                string result = "";
                int playerTurn = (isPlayer1Turn) ? 1 : 2;
                if (isGameOver)
                    return "Game Over!";
                if (ballPos <= playerPos + 3 && ballPos >= playerPos - 3)
                {
                    result = "Player " + playerTurn + " has hit the ball!";
                }
                else
                {
                    result = "Player " + playerTurn + " has missed the ball!";
                    if (isPlayer1Turn)
                        player2Score++;
                    else
                        player1Score++;
                }
                if (player1Score == maxScore)
                {
                    result = "Player 1 has won the game!";
                    isGameOver = true;
                }
                else if (player2Score == maxScore)
                {
                    result = "Player 2 has won the game!";
                    isGameOver = true;
                }

                isPlayer1Turn = !isPlayer1Turn;

                return result;
            }
        }


        static void Main(string[] args)
        {
            Pong game = new Pong(2);
            Console.WriteLine(game.play(50, 53));
            Console.WriteLine(game.play(100, 97));
            Console.WriteLine(game.play(0, 4));
            Console.WriteLine(game.play(25, 25));
            Console.WriteLine(game.play(75, 25));
            Console.WriteLine(game.play(50, 50));
            Console.ReadLine();
        }
    }
}
