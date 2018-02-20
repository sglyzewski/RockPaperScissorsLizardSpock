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
        
      
       
        public int player1Score;
        public int player2Score;
        public int randomRoll;
        public string player1Choice;
        public string player2Choice;
        Player1 player1 = new Player1();
        Player2 player2 = new Player2();
        AI computer = new AI();
        //constructor (SPAWNER)
        public Player()
        {
            player1Score = 0;
            player2Score = 0;
            if (player2.name == "computer")
            {
                player2 = computer;
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
           while(player1.score < 3 && player2.score < 3)
            {
                player1Choice = player1.GetPlayerChoice();
                player2Choice = player2.GetPlayerChoice();
                
                if (player1Choice == player2Choice)
                {
                    Console.WriteLine("Tie. No points.");
                }
                else if(player1Choice == "rock" && player2Choice != "spock" && player2Choice!= "paper" ) {
                    Console.WriteLine(player1.name + " gets a point.");
                    player1.score += 1;
                }
                else if (player1Choice == "scissors" && player2Choice != "spock" && player2Choice != "rock")
                {
                    Console.WriteLine(player1.name + " gets a point.");
                    player1.score += 1;
                }
                else if (player1Choice == "spock" && player2Choice != "paper" && player2Choice != "lizard")
                {
                    Console.WriteLine(player1.name + " gets a point.");
                    player1.score += 1;
                }
                else if (player1Choice == "lizard" && player2Choice != "scissors" && player2Choice != "rock")
                {
                    Console.WriteLine(player1.name + " gets a point.");
                    player1.score += 1;
                }
                else if (player1Choice == "paper" && player2Choice != "scissors" && player2Choice != "spock")
                {
                    Console.WriteLine(player1.name + " gets a point.");
                    player1.score += 1;
                }
                else
                {
                    Console.WriteLine(player2.name + " gets a point.");
                    player2.score += 1;
                }

            } 

           if (player1.score> player2.score)
            {
                GiveMessage(player1.name + ", you win!");
            }
            else 
            {
                GiveMessage(player2.name + ", you win!");
            }

        }
  
        //member methods (CAN DO)
    }


}
