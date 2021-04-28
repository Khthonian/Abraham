using System;
using System.Collections.Generic;

namespace LincolnCardGame
{
    public class Game : RoundStructure
    {
        public void InitiateGame(List<string> playerOneHand, List<string> playerTwoHand)
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
            RoundTwo(playerOne, playerTwo, playerOneName, playerTwoName);
            RoundThree(playerOne, playerTwo, playerOneName, playerTwoName);
            RoundFour(playerOne, playerTwo, playerOneName, playerTwoName);
        }
    }
}
