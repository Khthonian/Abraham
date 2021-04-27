using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LincolnCardGame
{
    public class GameSystem : Rules
    {
        // Initialise the classes for storing scores
        protected Player playerOneID = new Player();
        protected Player playerTwoID = new Player();

        protected void EvaluateWinner(int playerOne, int playerTwo, string playerOneName, string playerTwoName)
        {
            int highestScore = Math.Max(playerOne, playerTwo);
            /*if (playerOne == playerTwo)
            {
                Console.WriteLine("Draw");
                //DrawnRound();
            } CHANGE STATEMENT BELOW TO ELSE IF*/
            if (highestScore == playerOne)
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
