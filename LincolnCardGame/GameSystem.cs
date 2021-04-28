﻿using System;
using System.Collections.Generic;

namespace LincolnCardGame
{
    public class GameSystem : Rules
    {
        // Initialise the classes for storing scores
        protected Player playerOneID = new Player();
        protected Player playerTwoID = new Player();
        protected Random random = new Random();
        
        protected void EvaluateWinner(int playerOne, int playerTwo, string playerOneName, string playerTwoName)
        {
            int highestScore = Math.Max(playerOne, playerTwo);
            if (drawnRound == true)
            {
                if (playerOne == playerTwo)
                {
                    Console.WriteLine("DRAW");
                    DrawnRound();
                    Console.WriteLine($"{playerOneName.ToUpper()}:");
                    Console.WriteLine(playerOneID.playerWins);
                    Console.WriteLine($"{playerTwoName.ToUpper()}:");
                    Console.WriteLine(playerTwoID.playerWins);
                    Console.WriteLine();
                }
                else if (highestScore == playerOne)
                {
                    Console.WriteLine($"{playerOneName.ToUpper()} WINS!");
                    playerOneID.PlayerWinsDraw();
                    playerTwoID.PlayerLose();
                    drawnRound = false;
                    Console.WriteLine();
                    Console.WriteLine($"{playerOneName.ToUpper()}:");
                    Console.WriteLine(playerOneID.playerWins);
                    Console.WriteLine($"{playerTwoName.ToUpper()}:");
                    Console.WriteLine(playerTwoID.playerWins);
                    Console.WriteLine();
                }
                else if (highestScore == playerTwo)
                {
                    Console.WriteLine($"{playerTwoName.ToUpper()} WINS!");
                    playerTwoID.PlayerWinsDraw();
                    playerOneID.PlayerLose();
                    drawnRound = false;
                    Console.WriteLine();
                    Console.WriteLine($"{playerOneName.ToUpper()}:");
                    Console.WriteLine(playerOneID.playerWins);
                    Console.WriteLine($"{playerTwoName.ToUpper()}:");
                    Console.WriteLine(playerTwoID.playerWins);
                    Console.WriteLine();
                }
            }
            else if (drawnRound == false)
            {
                if (playerOne == playerTwo)
                {
                    Console.WriteLine("DRAW");
                    DrawnRound();
                    Console.WriteLine($"{playerOneName.ToUpper()}:");
                    Console.WriteLine(playerOneID.playerWins);
                    Console.WriteLine($"{playerTwoName.ToUpper()}:");
                    Console.WriteLine(playerTwoID.playerWins);
                    Console.WriteLine();
                }
                else if (highestScore == playerOne)
                {
                    Console.WriteLine($"{playerOneName.ToUpper()} WINS!");
                    playerOneID.PlayerWin();
                    playerTwoID.PlayerLose();
                    Console.WriteLine();
                    Console.WriteLine($"{playerOneName.ToUpper()}:");
                    Console.WriteLine(playerOneID.playerWins);
                    Console.WriteLine($"{playerTwoName.ToUpper()}:");
                    Console.WriteLine(playerTwoID.playerWins);
                    Console.WriteLine();
                }
                else if (highestScore == playerTwo)
                {
                    Console.WriteLine($"{playerTwoName.ToUpper()} WINS!");
                    playerTwoID.PlayerWin();
                    playerOneID.PlayerLose();
                    Console.WriteLine();
                    Console.WriteLine($"{playerOneName.ToUpper()}:");
                    Console.WriteLine(playerOneID.playerWins);
                    Console.WriteLine($"{playerTwoName.ToUpper()}:");
                    Console.WriteLine(playerTwoID.playerWins);
                    Console.WriteLine();
                }
            }
        }
    

        public void CheckGameWinner(string playerOne, string playerTwo)
        {
            if (playerOneID.playerWins == 3)
            {
                Console.WriteLine($"{playerOne.ToUpper()} has won");
                Console.WriteLine();
                Console.WriteLine("\nDo you want me to restart or do you want to exit?\nPress ENTER to restart\nInput 'E' then ENTER to exit");
                switch (Console.ReadLine().ToLower())
                {
                    case "":
                        Program.Main();
                        break;
                    case "e":
                        Console.WriteLine("Thank you for using Abraham. Goodbye.");
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Your input was not recognised. Returning to menu.");
                        Program.Main();
                        break;


                }
            }
            else if (playerTwoID.playerWins == 3)
            {
                Console.WriteLine($"{playerTwo.ToUpper()} has won");
                Console.WriteLine();
                Console.WriteLine("\nDo you want me to restart or do you want to exit?\nPress ENTER to restart\nInput 'E' then ENTER to exit");
                switch (Console.ReadLine().ToLower())
                {
                    case "":
                        Program.Main();
                        break;
                    case "e":
                        Console.WriteLine("Thank you for using Abraham. Goodbye.");
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Your input was not recognised. Returning to menu.");
                        Program.Main();
                        break;


                }
            }
        }

        public static string CardRequest(List<string> playerHand, string playerName)
        {
            // Show the user their cards
            Console.WriteLine($"\n{playerName}, here are your cards:");
            foreach (string p in playerHand)
            {
                Console.Write(p);
                Console.WriteLine();
            }

            // Ask the user to input a card they would like to use
            Console.Write("Please enter your chosen card: ");
            string card = Console.ReadLine();
            bool valid = false;

            // Begin verification
            while (valid == false)
            {
                // Verify the input isn't empty or null
                while (string.IsNullOrEmpty(card))
                {
                    Console.WriteLine();
                    Console.WriteLine("You must enter a card name. Try again:");
                    card = Console.ReadLine();
                }

                // Verify that the card is in the list
                while (!playerHand.Contains(card))
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid card. Try again:");
                    card = Console.ReadLine();
                }
                valid = true;
            }

            Console.WriteLine("Valid card");
            Console.WriteLine();
            playerHand.Remove(card);
            return card;
        }

        public static int PlayerTally(string cardOne, string cardTwo)
        {
            int tally = PlayerScore(cardOne) + PlayerScore(cardTwo);
            return tally;
        }

        public static int PlayerTally(string card)
        {
            int tally = PlayerScore(card);
            return tally;
        }

        public static void DisplayHand(List<string> playerHand, string playerName)
        {
            Console.WriteLine($"\n{playerName}, here are your cards:");
            foreach (string p in playerHand)
            {
                Console.Write(p);
                Console.WriteLine();
            }
        }
    }
}
