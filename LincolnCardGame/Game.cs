using System;
using System.Collections.Generic;

namespace LincolnCardGame
{
    public class Game
    {
        public void InitiateGamePvP(List<string> playerOneHand, List<string> playerTwoHand)
        {
            RoundStructurePvP PvP = new RoundStructurePvP();
            // Ask the players for their names
            string playerOneName;
            string playerTwoName;
            Console.WriteLine("\nPLAYER 1, what is your name");
            playerOneName = Console.ReadLine();
            Console.WriteLine("\nPLAYER 2, what is your name");
            playerTwoName = Console.ReadLine();

            // Begin the game
            Console.WriteLine("\nLet's begin play\n");
            PvP.FiveRoundsPvP(playerOneHand, playerTwoHand, playerOneName, playerTwoName);
        }

        public void InitiateGamePvCPU(List<string> playerHand, List<string> abrahamHand)
        {
            RoundStructurePvCPU PvCPU = new RoundStructurePvCPU();
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
