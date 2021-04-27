using System;
using System.Collections.Generic;

namespace LincolnCardGame
{
    public class GameSystem : Rules
    {
        // Initialise the classes for storing scores
        Player playerOneID = new Player();
        Player playerTwoID = new Player();

        public void RoundOne(List<string> playerOne, List<string> playerTwo, string playerOneName, string playerTwoName)
        {
            GameSystem game = new GameSystem();
            
            // Write out the structure for the first round
            Console.WriteLine("LINCOLN - ROUND 1");
            Console.WriteLine();
            Console.WriteLine(playerOneName.ToUpper());
            string r1firstVerifyOne = CardRequest(playerOne);
            string r1secondVerifyOne = CardRequest(playerOne);
            int r1tallyOne = PlayerTally(r1firstVerifyOne, r1secondVerifyOne);
            Console.WriteLine(playerTwoName.ToUpper());
            string r1firstVerifyTwo = CardRequest(playerTwo);
            string r1secondVerifyTwo = CardRequest(playerTwo);
            int r1tallyTwo = PlayerTally(r1firstVerifyTwo, r1secondVerifyTwo);
            game.EvaluateWinner(r1tallyOne, r1tallyTwo, playerOneName, playerTwoName);
        }

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
            Console.WriteLine("Please enter your chosen card: ");
            string chosen = Console.ReadLine();
            CardVerification(chosen, playerHand);
            playerHand.Remove(chosen);
            return chosen;
        }        

        public static void CardVerification(string card, List<string> cardList)
        {
            // Verify that the card is in the list
            if (!cardList.Contains(card))
            {
                Console.WriteLine("Invalid card");
                Console.WriteLine();          
            }
            else
            {
                Console.WriteLine("Valid card");
                Console.WriteLine();
            }
        }

        public static int PlayerTally(string cardOne, string cardTwo)
        {
            int tally = PlayerScore(cardOne) + PlayerScore(cardTwo);
            return tally;
        }
    }
}
