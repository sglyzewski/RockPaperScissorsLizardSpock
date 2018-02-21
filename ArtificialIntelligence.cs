using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class ArtificialIntelligencePlayer : Player2
    { //member variables (HAS A)

        //constructor (SPAWNER)
        public ArtificialIntelligencePlayer() {
            
            score = 0;
            name = "Computer";
        
        }

        //member methods (CAN DO)
        public static readonly Random getRandom = new Random();
        public static int GetRandomNumber(int min, int max)
        {
            lock (getRandom) 
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

        public override string GetPlayerChoice()
        {
            int randomRoll;
            randomRoll = GetComputerRoll();
            string choice;
            switch (randomRoll)
            {
                case 1:
                    choice = "rock";
                    GiveMessage(name + " chose " + choice + ".");
                    return choice;

                case 2:
                    choice = "scissors";
                    GiveMessage(name + " chose " + choice + ".");
                    return choice;

                case 3:
                    choice = "spock";
                    GiveMessage(name + " chose " + choice + ".");
                    return choice;
                case 4:
                    choice = "lizard";
                    GiveMessage(name + " chose " + choice + ".");
                    return choice;
                case 5:
                    choice = "paper";
                    GiveMessage(name + " chose " + choice + ".");
                    return choice;
                default:
                    Console.WriteLine("Invalid Computer Selection");
                    choice = "";
                    return choice;


            }
        }
            public override string GetPlayerName()
            {
            string playerName;
            GiveMessage("You are playing against the computer.");
            playerName = "Computer";
            return playerName;
            }

    }
    }


