using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class AI : MotherPlayer
    { //member variables (HAS A)
       
        //constructor (SPAWNER)


        //member methods (CAN DO)
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

        public override string GetPlayerChoice()
        {
            int randomRoll;
            randomRoll = GetComputerRoll();
            string choice;
            switch (randomRoll)
            {
                case 1:
                    choice = "rock";
                    return choice;
                   
                case 2:
                    choice = "scissors";
                    return choice;
                  
                case 3:
                    choice = "spock";
                    return choice;
                case 4:
                    choice = "lizard";
                    return choice;
                case 5:
                    choice = "paper";
                    return choice;
                default:
                    Console.WriteLine("Invalid Computer Selection");
                    choice = "";
                    return choice;
           

            }
            
        }
    }
}
