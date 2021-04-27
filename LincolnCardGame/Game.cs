using System;
using System.Collections.Generic;

namespace LincolnCardGame
{
    public class Game : GameSystem
    {
        public void TwoPlayer(List<string> playerOneHand, List<string> playerTwoHand)
        {
            // Ask the players for their names
            string playerOneName;
            string playerTwoName;
            Console.WriteLine("\nPLAYER 1, what is your name");
            playerOneName = Console.ReadLine();
            Console.WriteLine("\nPLAYER 2, what is your name");
            playerTwoName = Console.ReadLine();

            // Show the players their cards
            Console.WriteLine($"\n{playerOneName}, here are your cards:");
            foreach (string p in playerOneHand)
            {
                Console.Write(p);
                Console.WriteLine();
            }
            Console.WriteLine($"\n{playerTwoName}, here are your cards:");
            foreach (string p in playerTwoHand)
            {
                Console.Write(p);
                Console.WriteLine();
            }

            // Begin the game
            Console.WriteLine("\nLet's begin play\n");            
            FiveRounds(playerOneHand, playerTwoHand, playerOneName, playerTwoName);

        }

        public void FiveRounds(List<string> playerOne, List<string> playerTwo, string playerOneName, string playerTwoName)
        {
            RoundOne(playerOne, playerTwo, playerOneName, playerTwoName);
        }

        public void RoundOne(List<string> playerOne, List<string> playerTwo, string playerOneName, string playerTwoName)
        {
            Console.WriteLine("LINCOLN - ROUND 1");
            Console.WriteLine();
            Console.WriteLine(playerOneName.ToUpper());
            string firstVerifyOne = CardRequest(playerOne);
            string secondVerifyOne = CardRequest(playerOne);
            int tallyOne = PlayerTally(firstVerifyOne, secondVerifyOne);
            Console.WriteLine(playerTwoName.ToUpper());
            string firstVerifyTwo = CardRequest(playerTwo);
            string secondVerifyTwo = CardRequest(playerTwo);
            int tallyTwo = PlayerTally(firstVerifyTwo, secondVerifyTwo);
            EvaluateWinner(tallyOne, tallyTwo, playerOneName, playerTwoName);
        } 
        
    }
}
