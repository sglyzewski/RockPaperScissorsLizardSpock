using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Game
    {
        //member variables (HAS A)
        int pointsToWin;



        //constructor (SPAWNER)
        public Game()
        {
            pointsToWin = 3;
        }

        //member methods (CAN DO)

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



        public void SingleGame()
        {
            string player1Choice;
            string player2Choice;
            Player1 player1Class = new Player1();
            Player2 player2Class = new Player2();
            
            player1Class.name = player1Class.GetPlayerName();
            player2Class.name = player2Class.GetPlayerName();
            ArtificialIntelligencePlayer computer = new ArtificialIntelligencePlayer();
            if (player2Class.name == "computer")
            {
                player2Class.name = computer.name;
                computer.GetPlayerName();
                
            }

                while (player1Class.score < pointsToWin && player2Class.score < pointsToWin)
            {

                if (player2Class.name == computer.name)
                {
                 
                    player1Choice = player1Class.GetPlayerChoice();
                    player2Choice = computer.GetPlayerChoice();
                   
                }
                else
                {
                    player1Choice = player1Class.GetPlayerChoice();
                    player2Choice = player2Class.GetPlayerChoice();
                }



                if (player1Choice == player2Choice)
                {
                    GiveMessage("Tie. No points.");
                }
                else if (player1Choice == "rock" && player2Choice != "spock" && player2Choice != "paper")
                {
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

            if (player1Class.score > player2Class.score)
            {
                GiveMessage("\n\n" + player1Class.name + " is the winner!");
            }
            else
            {
                GiveMessage("\n\n" + player2Class.name + " is the winner!");
            }

        }

        public int ConvertChoiceStringToNum(string choice)
        {
            int convertedChoice;
            switch (choice)

            {
                case "rock":
                    convertedChoice = 0;
                    return convertedChoice;
                case "paper":
                    convertedChoice = 1;
                    return convertedChoice;
                case "scissors":
                    convertedChoice = 2;
                    return convertedChoice;
                case "spock":
                    convertedChoice = 3;
                    return convertedChoice;
                case "lizard":
                    convertedChoice = 4;
                    return convertedChoice;
                default:
                    return 10;
            }
        }

        public void ScoreLog(string playerName1, int player1Score, string playerName2, int player2Score)
        {
            GiveMessage("\nCurrent Score: \n" + playerName1 + ": " + player1Score + "\n" + playerName2 + ": " + player2Score + "\n");
        }
        public void FormulaicGame()
        {
            string player1ChoiceString;
            string player2ChoiceString;
            Player1 player1Class = new Player1();
            Player2 player2Class = new Player2();

            player1Class.name = player1Class.GetPlayerName();
            player2Class.name = player2Class.GetPlayerName();
            ArtificialIntelligencePlayer computer = new ArtificialIntelligencePlayer();
            if (player2Class.name == "computer")
            {
                player2Class.name = computer.name;
                computer.GetPlayerName();

            }


            while (player1Class.score < pointsToWin && player2Class.score < pointsToWin)
            {


                if (player2Class.name == computer.name)
                {


                    player1ChoiceString = player1Class.GetPlayerChoice();
                    player2ChoiceString = computer.GetPlayerChoice();
                }
                else
                {
                    player1ChoiceString = player1Class.GetPlayerChoice();
                    player2ChoiceString = player2Class.GetPlayerChoice();
                }
                int formula;
                int player1Choice = ConvertChoiceStringToNum(player1ChoiceString);
                int player2Choice = ConvertChoiceStringToNum(player2ChoiceString);

                formula = (5 + player1Choice - player2Choice) % 5;
                if (formula == 1 || formula == 3)
                {
                    player1Class.score += 1;
                    GiveMessage(player1Class.name + " gets a point.");
                }
                if (formula == 2 || formula == 4)
                {
                    player2Class.score += 1;
                    GiveMessage(player2Class.name + " gets a point.");
                }
                if (formula == 0)
                {
                    GiveMessage("Tie. No points");
                }
                ScoreLog(player1Class.name, player1Class.score, player2Class.name, player2Class.score);
            }
            if (player1Class.score > player2Class.score)
            {
                GiveMessage("\n\n" + player1Class.name + " is the winner!");
            }
            else
            {
                GiveMessage("\n\n" + player2Class.name + " is the winner!");
            }
        }


            public void LoopGame()
            {
                string input = "yes";
                while (input == "yes")
                {
                    FormulaicGame();
                    input = GetStringInput("Play again? Type yes to play again.");
                    if (input == "yes")
                    {
                        continue;
                    }
                }
            }


        }


    }
