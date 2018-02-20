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



        public string player1;
        public string player2;
        public int randomRoll;
        public string player1Choice;
        public string player2Choice;
        Player1 player1Class = new Player1();
        Player2 player2Class = new Player2();
        //constructor (SPAWNER)
        public Player()
        {
            if (player2Class.name == "computer")
            {
                AI player2Class = new AI();
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

        public string GetPlayerRoll()
        {
            string playerRoll;
            playerRoll = GetStringInput("What is your roll?");
            return playerRoll;
        }


        public void playerChoice()
        {
           while(player1Class.score < 3 && player2Class.score < 3)
            {
                player1Choice = player1Class.GetPlayerChoice();
                player2Choice = player2Class.GetPlayerChoice();
                
                if (player1Choice == player2Choice)
                {
                    Console.WriteLine("Tie. No points.");
                }
                else if(player1Choice == "rock" && player2Choice != "spock" && player2Choice!= "paper" ) {
                    Console.WriteLine(player1Class.name + " gets a point.");
                    player1Class.score += 1;
                }
                else if (player1Choice == "scissors" && player2Choice != "spock" && player2Choice != "rock")
                {
                    Console.WriteLine(player1Class.name + " gets a point.");
                    player1Class.score += 1;
                }
                else if (player1Choice == "spock" && player2Choice != "paper" && player2Choice != "lizard")
                {
                    Console.WriteLine(player1Class.name + " gets a point.");
                    player1Class.score += 1;
                }
                else if (player1Choice == "lizard" && player2Choice != "scissors" && player2Choice != "rock")
                {
                    Console.WriteLine(player1Class.name + " gets a point.");
                    player1Class.score += 1;
                }
                else if (player1Choice == "paper" && player2Choice != "scissors" && player2Choice != "spock")
                {
                    Console.WriteLine(player1Class.name + " gets a point.");
                    player1Class.score += 1;
                }
                else
                {
                    Console.WriteLine(player2Class.name + " gets a point.");
                    player2Class.score += 1;
                }

            } 

           if (player1Class.score> player2Class.score)
            {
                GiveMessage(player1Class.name + ", you win!");
            }
            else 
            {
                GiveMessage(player2Class.name + ", you win!");
            }

        }
  
        //member methods (CAN DO)
    }


}
