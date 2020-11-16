using System;
using System.Collections;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerScore = 0;
            int computerScore = 0;
            RPSPrimer(playerScore, computerScore);
        }

        static void RPSPrimer(int playerScore, int computerScore)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine($"| Player: {playerScore} | Computer: {computerScore} |");
            Console.WriteLine("---------------------------");
            Console.WriteLine("What would you like to throw?");
            Console.WriteLine("1) Rock");
            Console.WriteLine("2) Paper");
            Console.WriteLine("3) Scissors");
            string myThrowString = Console.ReadLine();
            int myThrow = Int32.Parse(myThrowString);
            string myWeapon = "hand";

            if (myThrow == 1)
            {
                myWeapon = "Rock";
            }
            else if (myThrow == 2)
            {
                myWeapon = "Paper";
            }
            else if (myThrow == 3)
            {
                myWeapon = "Scissors";
            }
            RPS(myWeapon, playerScore, computerScore);
        }

        static void RPS(string userWeapon, int playerScore, int computerScore)
        {
            ArrayList weaponsList = new ArrayList();
            weaponsList.Add("Rock");
            weaponsList.Add("Paper");
            weaponsList.Add("Scissors");
            Random r = new Random();
            int token = r.Next(0, 3);
            object compWeaponObject = weaponsList[token];
            string compWeapon = compWeaponObject.ToString();
            Console.WriteLine($"You threw {userWeapon}");
            Console.WriteLine($"Computer threw {compWeapon}");
            if (userWeapon == "Rock")
            {
                if (compWeapon == "Rock")
                {
                    Console.WriteLine("Tie!");
                }
                if (compWeapon == "Paper")
                {
                    Console.WriteLine("You lose!");
                    computerScore++;
                }
                if (compWeapon == "Scissors")
                {
                    Console.WriteLine("Congrats, you win!");
                    playerScore++;
                }
            }
            else if (userWeapon == "Paper")
            {
                if (compWeapon == "Rock")
                {
                    Console.WriteLine("Congrats, you win!");
                    playerScore++;
                }
                if (compWeapon == "Paper")
                {
                    Console.WriteLine("Tie!");
                }
                if (compWeapon == "Scissors")
                {
                    Console.WriteLine("You lose!");
                    computerScore++;
                }
            }
            else if (userWeapon == "Scissors")
            {
                if (compWeapon == "Rock")
                {
                    Console.WriteLine("You lose!");
                    computerScore++;
                }
                if (compWeapon == "Paper")
                {
                    Console.WriteLine("Congrats, you win!");
                    playerScore++;
                }
                if (compWeapon == "Scissors")
                {
                    Console.WriteLine("Tie!");
                }
            }
            RPSPrimer(playerScore, computerScore);
        }
    }
}
