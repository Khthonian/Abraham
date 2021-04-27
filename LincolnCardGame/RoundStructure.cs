using System;
using System.Collections.Generic;

namespace LincolnCardGame
{
    public class RoundStructure : GameSystem
    {
        public void RoundOne(List<string> playerOne, List<string> playerTwo, string playerOneName, string playerTwoName)
        {
            // Write out the structure for the first round
            Console.WriteLine("LINCOLN - ROUND 1");
            Console.WriteLine();
            Console.WriteLine(playerOneName.ToUpper());
            string r1firstVerifyOne = CardRequest(playerOne);
            string r1secondVerifyOne = CardRequest(playerOne);
            int r1tallyOne = PlayerTally(r1firstVerifyOne, r1secondVerifyOne);
            Console.WriteLine($"{playerOneName}, your tally is {r1tallyOne}");
            Console.WriteLine();
            Console.WriteLine(playerTwoName.ToUpper());
            string r1firstVerifyTwo = CardRequest(playerTwo);
            string r1secondVerifyTwo = CardRequest(playerTwo);
            int r1tallyTwo = PlayerTally(r1firstVerifyTwo, r1secondVerifyTwo);
            Console.WriteLine($"{playerTwoName}, your tally is {r1tallyTwo}");
            Console.WriteLine();
            EvaluateWinner(r1tallyOne, r1tallyTwo, playerOneName, playerTwoName);                                   
        }

        public void RoundTwo(List<string> playerOne, List<string> playerTwo, string playerOneName, string playerTwoName)
        {
            if (playerOneID.playerTurn == true)
            {
                // Write out the structure for the second round
                Console.WriteLine("LINCOLN - ROUND 2");
                Console.WriteLine();
                Console.WriteLine(playerOneName.ToUpper());
                string r2firstVerifyOne = CardRequest(playerOne);
                string r2secondVerifyOne = CardRequest(playerOne);
                int r2tallyOne = PlayerTally(r2firstVerifyOne, r2secondVerifyOne);
                Console.WriteLine($"{playerOneName}, your tally is {r2tallyOne}");
                Console.WriteLine();
                Console.WriteLine(playerTwoName.ToUpper());
                string r2firstVerifyTwo = CardRequest(playerTwo);
                string r2secondVerifyTwo = CardRequest(playerTwo);
                int r2tallyTwo = PlayerTally(r2firstVerifyTwo, r2secondVerifyTwo);
                Console.WriteLine($"{playerTwoName}, your tally is {r2tallyTwo}");
                Console.WriteLine();
                EvaluateWinner(r2tallyOne, r2tallyTwo, playerOneName, playerTwoName);
            }
            else if (playerTwoID.playerTurn == true)
            {
                // Write out the structure for the second round
                Console.WriteLine("LINCOLN - ROUND 2");
                Console.WriteLine();
                Console.WriteLine(playerTwoName.ToUpper());
                string r2firstVerifyTwo = CardRequest(playerTwo);
                string r2secondVerifyTwo = CardRequest(playerTwo);
                int r2tallyTwo = PlayerTally(r2firstVerifyTwo, r2secondVerifyTwo);
                Console.WriteLine($"{playerTwoName}, your tally is {r2tallyTwo}");
                Console.WriteLine();
                //
                Console.WriteLine(playerOneName.ToUpper());
                string r2firstVerifyOne = CardRequest(playerOne);
                string r2secondVerifyOne = CardRequest(playerTwo);
                int r2tallyOne = PlayerTally(r2firstVerifyOne, r2secondVerifyOne);
                Console.WriteLine($"{playerOneName}, your tally is {r2tallyOne}");
                Console.WriteLine();
                EvaluateWinner(r2tallyOne, r2tallyTwo, playerOneName, playerTwoName);
            }
        }
    }
}
