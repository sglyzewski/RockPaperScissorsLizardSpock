using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    
    public class Human : MotherPlayer
    {
        
        public Human()
        {
            score = 0;
        }

        public bool EvaluateChoice(string input)
        {
            input = input.ToLower();
            if (choices.Contains(input))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void GiveMessage(string message)
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

        public override string GetPlayerChoice()
        {
            string playerChoice = "";
            while (EvaluateChoice(playerChoice) != true)
            {
                playerChoice = GetStringInput(name + ", what is your choice? Rock, paper, scissors, lizard, or spock?");
                if (EvaluateChoice(playerChoice) == false)
                {
                    GiveMessage("Invalid input.");
                }
                else {
                    GiveMessage(name + " chose " + playerChoice.ToLower() + ".");
                }
            }
            return playerChoice;
        }

        public override string GetPlayerName()
        {
            string playerName;
            playerName = GetStringInput(whichPlayer + ", what is your name?");
            return playerName;
        }
    }
}
