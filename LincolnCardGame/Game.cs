using System;
using System.Collections.Generic;

namespace LincolnCardGame
{
    public class Game
    {
        public static void InitiateGamePvCPU(List<string> playerHand, List<string> abrahamHand)
        {
            // Create a pass-through menu to initialise the PvCPU game
            RoundStructurePvCPU PvCPU = new();
            // Ask the players for their names
            string playerOneName;
            string playerTwoName = "Abraham - CPU";
            Console.WriteLine("\nPLAYER 1, what is your name");
            playerOneName = Console.ReadLine();

            // Begin the game
            Console.WriteLine("\nLet's begin play\n");
            PvCPU.FiveRoundsPvCPU(playerHand, abrahamHand, playerOneName, playerTwoName);
        }
    }
}
