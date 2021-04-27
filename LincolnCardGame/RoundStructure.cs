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
            string firstVerifyOne = CardRequest(playerOne);
            string secondVerifyOne = CardRequest(playerOne);
            int tallyOne = PlayerTally(firstVerifyOne, secondVerifyOne);
            Console.WriteLine($"{playerOneName}, your tally is {tallyOne}");
            Console.WriteLine();
            Console.WriteLine(playerTwoName.ToUpper());
            string firstVerifyTwo = CardRequest(playerTwo);
            string secondVerifyTwo = CardRequest(playerTwo);
            int tallyTwo = PlayerTally(firstVerifyTwo, secondVerifyTwo);
            Console.WriteLine($"{playerTwoName}, your tally is {tallyTwo}");
            Console.WriteLine();
            EvaluateWinner(tallyOne, tallyTwo, playerOneName, playerTwoName);                                   
        }

        public void RoundTwo(List<string> playerOne, List<string> playerTwo, string playerOneName, string playerTwoName)
        {
            if (playerOneID.playerTurn == true)
            {
                // Write out the structure for the second round
                Console.WriteLine("LINCOLN - ROUND 2");
                Console.WriteLine();
                Console.WriteLine(playerOneName.ToUpper());
                string firstVerifyOne = CardRequest(playerOne);
                string secondVerifyOne = CardRequest(playerOne);
                int tallyOne = PlayerTally(firstVerifyOne, secondVerifyOne);
                Console.WriteLine($"{playerOneName}, your tally is {tallyOne}");
                Console.WriteLine();
                Console.WriteLine(playerTwoName.ToUpper());
                string firstVerifyTwo = CardRequest(playerTwo);
                string secondVerifyTwo = CardRequest(playerTwo);
                int tallyTwo = PlayerTally(firstVerifyTwo, secondVerifyTwo);
                Console.WriteLine($"{playerTwoName}, your tally is {tallyTwo}");
                Console.WriteLine();
                EvaluateWinner(tallyOne, tallyTwo, playerOneName, playerTwoName);
            }
            else if (playerTwoID.playerTurn == true)
            {
                // Write out the structure for the second round
                Console.WriteLine("LINCOLN - ROUND 2");
                Console.WriteLine();
                Console.WriteLine(playerTwoName.ToUpper());
                string firstVerifyTwo = CardRequest(playerTwo);
                string secondVerifyTwo = CardRequest(playerTwo);
                int tallyTwo = PlayerTally(firstVerifyTwo, secondVerifyTwo);
                Console.WriteLine($"{playerTwoName}, your tally is {tallyTwo}");
                Console.WriteLine();
                Console.WriteLine(playerOneName.ToUpper());
                string firstVerifyOne = CardRequest(playerOne);
                string secondVerifyOne = CardRequest(playerTwo);
                int tallyOne = PlayerTally(firstVerifyOne, secondVerifyOne);
                Console.WriteLine($"{playerOneName}, your tally is {tallyOne}");
                Console.WriteLine();
                EvaluateWinner(tallyOne, tallyTwo, playerOneName, playerTwoName);
            }
        }

        public void RoundThree(List<string> playerOne, List<string> playerTwo, string playerOneName, string playerTwoName)
        {
            CheckGameWinner(playerOneName, playerTwoName);
            if (playerOneID.playerTurn == true)
            {
                // Write out the structure for the second round
                Console.WriteLine("LINCOLN - ROUND 3");
                Console.WriteLine();
                Console.WriteLine(playerOneName.ToUpper());
                string firstVerifyOne = CardRequest(playerOne);
                string secondVerifyOne = CardRequest(playerOne);
                int tallyOne = PlayerTally(firstVerifyOne, secondVerifyOne);
                Console.WriteLine($"{playerOneName}, your tally is {tallyOne}");
                Console.WriteLine();
                Console.WriteLine(playerTwoName.ToUpper());
                string firstVerifyTwo = CardRequest(playerTwo);
                string secondVerifyTwo = CardRequest(playerTwo);
                int tallyTwo = PlayerTally(firstVerifyTwo, secondVerifyTwo);
                Console.WriteLine($"{playerTwoName}, your tally is {tallyTwo}");
                Console.WriteLine();
                EvaluateWinner(tallyOne, tallyTwo, playerOneName, playerTwoName);
            }
            else if (playerTwoID.playerTurn == true)
            {
                // Write out the structure for the second round
                Console.WriteLine("LINCOLN - ROUND 3");
                Console.WriteLine();
                Console.WriteLine(playerTwoName.ToUpper());
                string firstVerifyTwo = CardRequest(playerTwo);
                string secondVerifyTwo = CardRequest(playerTwo);
                int tallyTwo = PlayerTally(firstVerifyTwo, secondVerifyTwo);
                Console.WriteLine($"{playerTwoName}, your tally is {tallyTwo}");
                Console.WriteLine();
                //
                Console.WriteLine(playerOneName.ToUpper());
                string firstVerifyOne = CardRequest(playerOne);
                string secondVerifyOne = CardRequest(playerTwo);
                int tallyOne = PlayerTally(firstVerifyOne, secondVerifyOne);
                Console.WriteLine($"{playerOneName}, your tally is {tallyOne}");
                Console.WriteLine();
                EvaluateWinner(tallyOne, tallyTwo, playerOneName, playerTwoName);
            }
        }
    }
}
