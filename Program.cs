using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            RunProgram();
        }
        public static void RunProgram()
        {
            int MyScore = 0;
            int OpponentScore = 0;

            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Enter Your Name...");
                string NameInput = Console.ReadLine();
                Console.WriteLine($"Hi {NameInput}, Please select your opponent!!!\n[1]AI or [2]Rock");
                int OpponentSelect = (Validator.OpponentInput(Console.ReadLine()));

                string OpponentChoice;
                string MyChoice;

                if (OpponentSelect == 1)
                {
                    AIPlayer A1 = new AIPlayer("A1");
                    OpponentChoice = A1.GenerateRoshambo();
                }
                else
                {
                    RockPlayer R1 = new RockPlayer("R1");
                    OpponentChoice = R1.GenerateRoshambo();
                }

                HumanPlayer H1 = new HumanPlayer(NameInput);
                MyChoice = H1.GenerateRoshambo();
                Console.WriteLine($"Your choice is: {MyChoice}");
                Console.WriteLine($"Your opponent's choice is: {OpponentChoice}");

                if (MyChoice == OpponentChoice)
                {
                    Console.WriteLine("Its a TIE!");
                }
                else if (MyChoice == "Rock" && OpponentChoice == "Paper")
                {
                    Console.WriteLine("Opponent Wins!!");
                    OpponentScore++;
                }
                else if (MyChoice == "Rock" && OpponentChoice == "Scissors")
                {
                    Console.WriteLine("You win!!!");
                    MyScore++;
                }
                else if (MyChoice == "Scissors" && OpponentChoice == "Paper")
                {
                    Console.WriteLine("You win!!!");
                    MyScore++;
                }
                else if (MyChoice == "Scissors" && OpponentChoice == "Rock")
                {
                    Console.WriteLine("Opponent Wins!!");
                    OpponentScore++;
                }
                else if (MyChoice == "Paper" && OpponentChoice == "Scissors")
                {
                    Console.WriteLine("Opponent Wins!!");
                    OpponentScore++;
                }
                else if (MyChoice == "Paper" && OpponentChoice == "Rock")
                {
                    Console.WriteLine("You win!!!");
                    MyScore++;
                }

                Console.WriteLine("Want to continue playing? Y/N");
                string Continue = Console.ReadLine();
                Console.Clear();

                if (!Regex.Match(Continue, @"^[Y|y]$").Success)
                {
                    repeat = false;
                    Console.WriteLine($"Your score is: {MyScore}\nOpponent Score is: {OpponentScore}");
                    Console.WriteLine("Sorry to see you go...\nGoodBye!\n\nPress enter to close...");
                    Console.ReadLine();
                }
            }
        }
    }
}