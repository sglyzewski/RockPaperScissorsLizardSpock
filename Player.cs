using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Player
    {
        //member variables (HAS A)
        public string name;
        public string choice;
        public string currentPlayer;
        public string otherPlayer;
        public int currentPlayerScore;
        public int otherPlayerScore;
        public int randomRoll;
        //constructor (SPAWNER)
        public Player()
        {
            currentPlayerScore = 0;
            otherPlayerScore = 0;
        }

        public static readonly Random getRandom = new Random();
        public static int GetRandomNumber(int min, int max)
        {
            lock (getRandom) // synchronize
            {
                return getRandom.Next(min, max);
            }
        }

        public int GetComputerRoll()
        {
            int roll;
            roll = GetRandomNumber(1, 5);
            return roll;
        }
        public void GiveMessage(string message)
        {
            Console.WriteLine(message);
        }

        public string GetStringInput(string message)
        {
            string input;
            Console.WriteLine(message);
            input = Console.ReadLine();
            return input;
        }

        public string GetPlayerRoll()
        {
            string playerRoll;
            playerRoll = GetStringInput("What is your roll?");
            return playerRoll;
        }


        public void playerChoice()
        {
           while(currentPlayerScore < 3 && otherPlayerScore < 3)
            {
                currentPlayer = GetPlayerRoll();
                randomRoll = GetComputerRoll();
                switch (randomRoll)
                {
                    case 1:
                        otherPlayer = "rock";
                        break;
                    case 2:
                        otherPlayer = "scissors";
                        break;
                    case 3:
                        otherPlayer = "spock";
                        break;
                    case 4:
                        otherPlayer = "lizard";
                        break;
                    case 5:
                        otherPlayer = "paper";
                        break;
                    default:
                        Console.WriteLine("Invalid Computer Selection");
                        break;
                }
                if (currentPlayer == otherPlayer)
                {
                    Console.WriteLine("Tie. No points.");
                }
                else if(currentPlayer == "rock" && otherPlayer != "spock" && otherPlayer!= "paper" ) {
                    Console.WriteLine("Player 1 gets a point.");
                    currentPlayerScore += 1;
                }
                else if (currentPlayer == "scissors" && otherPlayer != "spock" && otherPlayer != "rock")
                {
                    Console.WriteLine("Player 1 gets a point.");
                    currentPlayerScore += 1;
                }
                else if (currentPlayer == "spock" && otherPlayer != "paper" && otherPlayer != "lizard")
                {
                    Console.WriteLine("Player 1 gets a point.");
                    currentPlayerScore += 1;
                }
                else if (currentPlayer == "lizard" && otherPlayer != "scissors" && otherPlayer != "rock")
                {
                    Console.WriteLine("Player 1 gets a point.");
                    currentPlayerScore += 1;
                }
                else if (currentPlayer == "paper" && otherPlayer != "scissors" && otherPlayer != "spock")
                {
                    Console.WriteLine("Player 1 gets a point.");
                    currentPlayerScore += 1;
                }
                else
                {
                    Console.WriteLine("Player 2 gets a point");
                    otherPlayerScore += 1;
                }

            } 

           if (currentPlayerScore > otherPlayerScore)
            {
                GiveMessage("You win!");
            }
            else 
            {
                GiveMessage("Computer wins!");
            }

        }
  
        //member methods (CAN DO)
    }


}
