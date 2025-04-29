using System;

namespace ROCKPAPERSCISSORS
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;

            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    Console.Write("Choose between ROCK, PAPER and SCISSORS: ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    if (inputPlayer != "ROCK" && inputPlayer != "PAPER" && inputPlayer != "SCISSORS")
                    {
                        Console.WriteLine("Invalid choice! Please choose ROCK, PAPER, or SCISSORS.\n");
                        continue;
                    }

                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 4); // 1, 2, or 3

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer chose ROCK");
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            break;
                        default:
                            inputCPU = "ROCK";
                            break;
                    }

                    // Game logic
                    if (inputPlayer == inputCPU)
                    {
                        Console.WriteLine("DRAW!!\n");
                    }
                    else if ((inputPlayer == "ROCK" && inputCPU == "SCISSORS") ||
                             (inputPlayer == "PAPER" && inputCPU == "ROCK") ||
                             (inputPlayer == "SCISSORS" && inputCPU == "PAPER"))
                    {
                        Console.WriteLine("PLAYER WINS!!\n");
                        scorePlayer++;
                    }
                    else
                    {
                        Console.WriteLine("CPU WINS!!\n");
                        scoreCPU++;
                    }

                    Console.WriteLine("SCORES:\tPLAYER: {0}\tCPU: {1}\n", scorePlayer, scoreCPU);
                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("🏆 Player WON the game!");
                }
                else if(scoreCPU ==3)
                {
                    Console.WriteLine("💻 CPU WON the game!");
                }

                Console.WriteLine("\nDo you want to play again? (y/n)");
                string loop = Console.ReadLine().ToLower();
                if (loop == "y")
                {
                    Console.Clear();
                }
                else
                {
                    playAgain = false;
                }
            }
        }
    }
}
