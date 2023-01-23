using System;

namespace RockPaperScissors
{
    class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            Console.Write("Choose [r]ock, [p]aper, [s]cissors: ");
            string playersMove = Console.ReadLine();

            if (playersMove == "r" || playersMove == "rock")
            {
                playersMove = "Rock";
            }
            else if (playersMove == "p" || playersMove == "paper")
            {
                playersMove = "Paper";
            }
            else if (playersMove == "s" || playersMove == "scissors")
            {
                playersMove = "scissors";
            }
            else
            {
                Console.WriteLine("Invalid Input.Try again...");
                return;
            }

            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);
            string computersMove = "";
            switch (computerRandomNumber)
            {
                case 1:
                    computersMove = Rock;
                    break;
                case 2:
                    computersMove = Paper;
                    break;
                case 3:
                    computersMove = Scissors;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"The computer chooses: {computersMove}");
            if (playersMove == Rock && computersMove == Scissors)
            {
                Console.WriteLine("You win");
            }
            else if (playersMove == Rock && computersMove == Paper)
            {
                Console.WriteLine("You Lose");
            }
            else if (playersMove == Rock && computersMove == Rock)
            {
                Console.WriteLine("Draw");
            }
            else if (playersMove == Paper && computersMove == Rock)
            {
                Console.WriteLine("You Win");
            }
            else if (playersMove == Paper && computersMove == Scissors)
            {
                Console.WriteLine("You Lose");
            }
            else if (playersMove == Paper && computersMove == Paper)
            {
                Console.WriteLine("Draw");
            }
            else if (playersMove == Scissors && computersMove == Paper)
            {
                Console.WriteLine("You Win");
            }
            else if (playersMove == Scissors && computersMove == Rock)
            {
                Console.WriteLine("You Lose");
            }
            else if (playersMove == Scissors && computersMove == Scissors)
            {
                Console.WriteLine("Draw");
            }


        }
    }
}
