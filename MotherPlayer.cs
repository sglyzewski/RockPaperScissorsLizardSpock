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

        //constructor
        public MotherPlayer()
        {
            score = 0;
        }
        //member functions
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
            string playerChoice;
            playerChoice = GetStringInput("What is your roll?");
            GiveMessage(name + " chose " + playerChoice + ".");
            return playerChoice;
        }

        public virtual string GetPlayerName()
        {
            string playerName;
            playerName = GetStringInput(whichPlayer + "What is your name?");
            return playerName;
        }



    }
}
