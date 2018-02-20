using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Player2 : MotherPlayer
    {
        //member variables (HAS A)
        //constructor (SPAWNER)
        public Player2()
        {
            score = 0;
            whichPlayer = "Player 2";
            name = GetPlayerName();
         
        }

        //member methods (CAN DO)

        public override string GetPlayerName()
        {
            string playerName;
            playerName = GetStringInput(whichPlayer + "What is your name? Or type 'computer' to play against the computer.");
            return playerName;
        }
    }
}
