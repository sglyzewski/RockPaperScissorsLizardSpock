using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public abstract class MotherPlayer
    {
       
        public string choice;
        public string name;
        public int score;
        public List<string> choices = new List<string>(){"rock","paper","scissors","lizard","spock"};
        public string whichPlayer;
       
        public MotherPlayer()
        {
        }
        
        public abstract void GiveMessage(string message);

        public abstract string GetPlayerChoice();

        public abstract string GetPlayerName();
       
    }
}
