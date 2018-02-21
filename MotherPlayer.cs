using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class MotherPlayer
    {
        //member variables
        public string choice;
        public string name;
        public string whichPlayer;
        public int score;
        public List<string> choices = new List<string>(){"rock","paper","scissors","lizard","spock"};

        //constructor
        public MotherPlayer()
        {
            score = 0;
        }
        //member functions

        public bool EvaluateChoice(string input)
        {
            input = input.ToLower();
            if (choices.Contains(input))
            { return true; }
            else
            {
                return false;
            }
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



        public virtual string GetPlayerChoice()
        {
            string playerChoice = "";
            while (EvaluateChoice(playerChoice) != true) {
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



        public virtual string GetPlayerName()
        {
            string playerName;
            playerName = GetStringInput(whichPlayer + ", what is your name?");
            return playerName;
        }



    }
}
