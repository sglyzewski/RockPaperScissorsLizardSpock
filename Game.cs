using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Game
    {
        int pointsToWin;
        MotherPlayer player1;
        MotherPlayer player2;        

        public Game()
        {
            pointsToWin = 3;
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

        public bool CheckForComputerPlayer2()
        {
            string input;
            input = GetStringInput("Will you be playing against the computer?").ToLower();
            if (input == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void GetPlayers()
        {
            player1 = new Human();
            player1.whichPlayer = "Player 1";
            if (CheckForComputerPlayer2()== true)
            {
                
                player2 = new ArtificialIntelligencePlayer();
            }
            else
            {
                
                player2 = new Human();
                player2.whichPlayer = "Player 2";
            }
        }

        public void GetPlayerNames()
        {            
            player1.name = player1.GetPlayerName();
            player2.name = player2.GetPlayerName();
        }

        public void GetPlayerChoices()
        {
            player1.choice = player1.GetPlayerChoice();
            player2.choice = player2.GetPlayerChoice();
        }

        public void DetermineRoundScore()
        {
            if (player1.choice == player2.choice)
            {
                GiveMessage("Tie. No points.");
            }
            else if (player1.choice == "rock" && player2.choice != "spock" && player2.choice != "paper")
            {
                GiveMessage(player1.name + " gets a point.");
                player1.score += 1;
            }
            else if (player1.choice == "scissors" && player2.choice != "spock" && player2.choice != "rock")
            {
                GiveMessage(player1.name + " gets a point.");
                player1.score += 1;
            }
            else if (player1.choice == "spock" && player2.choice != "paper" && player2.choice != "lizard")
            {
                GiveMessage(player1.name + " gets a point.");
                player1.score += 1;
            }
            else if (player1.choice == "lizard" && player2.choice != "scissors" && player2.choice != "rock")
            {
                GiveMessage(player1.name + " gets a point.");
                player1.score += 1;
            }
            else if (player1.choice == "paper" && player2.choice != "scissors" && player2.choice != "spock")
            {
                GiveMessage(player1.name + " gets a point.");
                player1.score += 1;
            }
            else
            {
                GiveMessage(player2.name + " gets a point.");
                player2.score += 1;
            }
        }

        public void ScoreLog(string playerName1, int player1Score, string playerName2, int player2Score)
        {
            GiveMessage("\nCurrent Score: \n" + playerName1 + ": " + player1Score + "\n" + playerName2 + ": " + player2Score + "\n");
        }

        public void DetermineGameWinner()
        {

            if (player1.score > player2.score)
            {
                GiveMessage("\n\n" + player1.name + " is the winner!");
            }
            else
            {
                GiveMessage("\n\n" + player2.name + " is the winner!");
            }

        }

        public void SingleGame()
        {
            GetPlayers();
            GetPlayerNames();

            while (player1.score < pointsToWin && player2.score < pointsToWin)
            {

                GetPlayerChoices();
                DetermineRoundScore();
                ScoreLog(player1.name, player1.score, player2.name, player2.score);
            }
            DetermineGameWinner();

        }

        public void LoopGame()
        {
            string input = "yes";
            while (input == "yes")
            {
                SingleGame();
                input = GetStringInput("Play again? Type yes to play again.");
                input = input.ToLower();
                if (input == "yes")
                {
                    continue;
                }
            }
            
        }
    }
 }
