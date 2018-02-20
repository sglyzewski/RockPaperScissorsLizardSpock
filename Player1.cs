using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Player1 : MotherPlayer
    {   //member variables (HAS A)
        //constructor (SPAWNER)
        public Player1()
        {
            score = 0;
            whichPlayer = "Player 1";
            name = GetPlayerName();
        }
        //member methods (CAN DO)
    }
}
