using System;
using System.Collections.Generic;

namespace LincolnCardGame
{
    public class GameSystem : Rules
    {
        // Initialise the classes for storing scores
        protected Player playerOneID = new();
        protected Player playerTwoID = new();
        protected Random random = new();

        protected void EvaluateWinner(int playerOne, int playerTwo, string playerOneName, string playerTwoName)
        {
            // Create a method that will determine who has won the round
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


        protected void CheckGameWinner(string playerOne, string playerTwo)
        {
            // Create a method that will determine whether a player has won the game
            if (playerOneID.playerWins == 3)
            {
                Console.WriteLine($"{playerOne.ToUpper()} HAS WON THE GAME!");
                Console.WriteLine();
                Console.WriteLine("\nDo you want me to restart or do you want to exit?\nPress ENTER to restart\nInput 'E' then ENTER to exit");
                switch (Console.ReadLine().ToLower())
                {
                    case "":
                        Console.WriteLine();
                        Program.Main();
                        break;
                    case "e":
                        Console.WriteLine();
                        Console.WriteLine("Thank you for using Abraham. Goodbye.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine();
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
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Your input was not recognised. Returning to menu.");
                        Program.Main();
                        break;


                }
            }
        }

        protected static string CardRequest(List<string> playerHand, string playerName)
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

        protected static int PlayerTally(string cardOne, string cardTwo)
        {
            // Create a method that will tally up the card values
            int tally = PlayerScore(cardOne) + PlayerScore(cardTwo);
            return tally;
        }

        protected static int PlayerTally(string card)
        {
            // Create a method that will return the card value
            int tally = PlayerScore(card);
            return tally;
        }

        protected static void DisplayHand(List<string> playerHand, string playerName)
        {
            // Create a method that shows the current cards in the hand
            Console.WriteLine($"\n{playerName}, here are your cards:");
            foreach (string p in playerHand)
            {
                Console.Write(p);
                Console.WriteLine();
            }
        }

        protected string AbrahamShuffle(List<string> abeHand)
        {
            // Create a method that handles Abraham's card selection
            int abeShuffle = random.Next(abeHand.Count);
            string abeCard = abeHand[abeShuffle];
            Console.WriteLine($"I choose the {abeCard}");
            return abeCard;
        }
    }
}
