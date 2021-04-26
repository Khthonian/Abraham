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
                Console.Write(p);
            Console.WriteLine($"\n{playerTwoName}, here are your cards:");
            foreach (string p in playerTwoHand)
                Console.Write(p);

            // Begin the game
            Console.WriteLine("\nLet's begin play\n");
            
        }

        public void OnePlayer()
        {

        }
    }
}
