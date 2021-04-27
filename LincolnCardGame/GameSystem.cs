using System;
using System.Collections.Generic;

namespace LincolnCardGame
{
    public class GameSystem : Rules
    {
        // Initialise the classes for storing scores
        Player playerOneID = new Player();
        Player playerTwoID = new Player();

        protected void EvaluateWinner(int playerOne, int playerTwo, string playerOneName, string playerTwoName)
        {
            int highestScore = Math.Max(playerOne, playerTwo);
            if (highestScore == playerOne)
            {
                Console.WriteLine($"{playerOneName.ToUpper()} WINS!");
                playerOneID.PlayerWin();
                Console.WriteLine();
                Console.WriteLine($"{playerOneName.ToUpper()}:");
                Console.WriteLine(playerOneID.playerWins);
                Console.WriteLine($"{playerTwoName.ToUpper()}:");
                Console.WriteLine(playerTwoID.playerWins);
            }
            else if (highestScore == playerTwo)
            {
                Console.WriteLine($"{playerTwoName.ToUpper()} WINS!");
                playerTwoID.PlayerWin();
                Console.WriteLine();
                Console.WriteLine($"{playerOneName.ToUpper()}:");
                Console.WriteLine(playerOneID.playerWins);
                Console.WriteLine($"{playerTwoName.ToUpper()}:");
                Console.WriteLine(playerTwoID.playerWins);
            }
            else
            {
                Console.WriteLine("Draw");
                //DrawnRound();
            }
        }

        public static string CardRequest(List<string> playerHand)
        {
            // Ask the user to input a card they would like to use
            Console.Write("Please enter your chosen card: ");
            string chosen = Console.ReadLine();
            string chosenVerify = CardVerification(chosen, playerHand);
            playerHand.Remove(chosen);
            return chosenVerify;
        }

        public static string CardVerification(string card, List<string> cardList)
        {
            // Verify that the card is in the list
            string chosenVerify;
            bool systemVerify = false;
            while (systemVerify == false)
            {
                if (cardList.Contains(card))
                {
                    Console.WriteLine("Valid card");
                    systemVerify = true;
                }
                else
                {
                    Console.WriteLine("Invalid card. Reinsert your chosen cards.");
                    Console.WriteLine();
                    CardRequest(cardList);
                }
            }
            chosenVerify = card;
            return chosenVerify;
        }

        public static int PlayerTally(string cardOne, string cardTwo)
        {
            int tally = PlayerScore(cardOne) + PlayerScore(cardTwo);
            return tally;
        }
    }
}
