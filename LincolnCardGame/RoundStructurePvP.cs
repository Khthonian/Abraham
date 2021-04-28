using System;
using System.Collections.Generic;

namespace LincolnCardGame
{
    public class RoundStructurePvP : GameSystem
    {
        public void FiveRoundsPvP(List<string> playerOne, List<string> playerTwo, string playerOneName, string playerTwoName)
        {
            RoundOne(playerOne, playerTwo, playerOneName, playerTwoName);
            RoundTwo(playerOne, playerTwo, playerOneName, playerTwoName);
            RoundThree(playerOne, playerTwo, playerOneName, playerTwoName);
            RoundFour(playerOne, playerTwo, playerOneName, playerTwoName);
        }

        public void RoundOne(List<string> playerOne, List<string> playerTwo, string playerOneName, string playerTwoName)
        {
            // Write out the structure for the first round
            Console.WriteLine("LINCOLN - ROUND 1");
            Console.WriteLine();
            Console.WriteLine(playerOneName.ToUpper());
            string firstVerifyOne = CardRequest(playerOne, playerOneName);
            string secondVerifyOne = CardRequest(playerOne, playerOneName);
            int tallyOne = PlayerTally(firstVerifyOne, secondVerifyOne);
            Console.WriteLine($"{playerOneName}, your tally is {tallyOne}");
            Console.WriteLine();
            Console.WriteLine(playerTwoName.ToUpper());
            string firstVerifyTwo = CardRequest(playerTwo, playerTwoName);
            string secondVerifyTwo = CardRequest(playerTwo, playerTwoName);
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
                string firstVerifyOne = CardRequest(playerOne, playerOneName);
                string secondVerifyOne = CardRequest(playerOne, playerOneName);
                int tallyOne = PlayerTally(firstVerifyOne, secondVerifyOne);
                Console.WriteLine($"{playerOneName}, your tally is {tallyOne}");
                Console.WriteLine();
                Console.WriteLine(playerTwoName.ToUpper());
                string firstVerifyTwo = CardRequest(playerTwo, playerTwoName);
                string secondVerifyTwo = CardRequest(playerTwo, playerTwoName);
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
                string firstVerifyTwo = CardRequest(playerTwo, playerTwoName);
                string secondVerifyTwo = CardRequest(playerTwo, playerTwoName);
                int tallyTwo = PlayerTally(firstVerifyTwo, secondVerifyTwo);
                Console.WriteLine($"{playerTwoName}, your tally is {tallyTwo}");
                Console.WriteLine();
                Console.WriteLine(playerOneName.ToUpper());
                string firstVerifyOne = CardRequest(playerOne, playerOneName);
                string secondVerifyOne = CardRequest(playerOne, playerOneName);
                int tallyOne = PlayerTally(firstVerifyOne, secondVerifyOne);
                Console.WriteLine($"{playerOneName}, your tally is {tallyOne}");
                Console.WriteLine();
                EvaluateWinner(tallyOne, tallyTwo, playerOneName, playerTwoName);
            }
        }

        public void RoundThree(List<string> playerOne, List<string> playerTwo, string playerOneName, string playerTwoName)
        {
            if (playerOneID.playerTurn == true)
            {
                // Write out the structure for the third round
                Console.WriteLine("LINCOLN - ROUND 3");
                Console.WriteLine();
                Console.WriteLine(playerOneName.ToUpper());
                string firstVerifyOne = CardRequest(playerOne, playerOneName);
                string secondVerifyOne = CardRequest(playerOne, playerOneName);
                int tallyOne = PlayerTally(firstVerifyOne, secondVerifyOne);
                Console.WriteLine($"{playerOneName}, your tally is {tallyOne}");
                Console.WriteLine();
                Console.WriteLine(playerTwoName.ToUpper());
                string firstVerifyTwo = CardRequest(playerTwo, playerTwoName);
                string secondVerifyTwo = CardRequest(playerTwo, playerTwoName);
                int tallyTwo = PlayerTally(firstVerifyTwo, secondVerifyTwo);
                Console.WriteLine($"{playerTwoName}, your tally is {tallyTwo}");
                Console.WriteLine();
                EvaluateWinner(tallyOne, tallyTwo, playerOneName, playerTwoName);
            }
            else if (playerTwoID.playerTurn == true)
            {
                // Write out the structure for the third round
                Console.WriteLine("LINCOLN - ROUND 3");
                Console.WriteLine();
                Console.WriteLine(playerTwoName.ToUpper());
                string firstVerifyTwo = CardRequest(playerTwo, playerTwoName);
                string secondVerifyTwo = CardRequest(playerTwo, playerTwoName);
                int tallyTwo = PlayerTally(firstVerifyTwo, secondVerifyTwo);
                Console.WriteLine($"{playerTwoName}, your tally is {tallyTwo}");
                Console.WriteLine();
                Console.WriteLine(playerOneName.ToUpper());
                string firstVerifyOne = CardRequest(playerOne, playerOneName);
                string secondVerifyOne = CardRequest(playerOne, playerOneName);
                int tallyOne = PlayerTally(firstVerifyOne, secondVerifyOne);
                Console.WriteLine($"{playerOneName}, your tally is {tallyOne}");
                Console.WriteLine();
                EvaluateWinner(tallyOne, tallyTwo, playerOneName, playerTwoName);
            }
        }

        public void RoundFour(List<string> playerOne, List<string> playerTwo, string playerOneName, string playerTwoName)
        {
            CheckGameWinner(playerOneName, playerTwoName);
            if (playerOneID.playerTurn == true)
            {
                // Write out the structure for the fourth round
                Console.WriteLine("LINCOLN - ROUND 4");
                Console.WriteLine();
                Console.WriteLine(playerTwoName.ToUpper());
                string firstVerifyTwo = CardRequest(playerTwo, playerTwoName);
                string secondVerifyTwo = CardRequest(playerTwo, playerTwoName);
                int tallyTwo = PlayerTally(firstVerifyTwo, secondVerifyTwo);
                Console.WriteLine($"{playerTwoName}, your tally is {tallyTwo}");
                Console.WriteLine();
                Console.WriteLine(playerOneName.ToUpper());
                string firstVerifyOne = CardRequest(playerOne, playerOneName);
                string secondVerifyOne = CardRequest(playerOne, playerOneName);
                int tallyOne = PlayerTally(firstVerifyOne, secondVerifyOne);
                Console.WriteLine($"{playerOneName}, your tally is {tallyOne}");
                Console.WriteLine();
                EvaluateWinner(tallyOne, tallyTwo, playerOneName, playerTwoName);
            }
            else if (playerTwoID.playerTurn == true)
            {
                // Write out the structure for the fourth round
                Console.WriteLine("LINCOLN - ROUND 4");
                Console.WriteLine();
                Console.WriteLine(playerTwoName.ToUpper());
                string firstVerifyTwo = CardRequest(playerTwo, playerTwoName);
                string secondVerifyTwo = CardRequest(playerTwo, playerTwoName);
                int tallyTwo = PlayerTally(firstVerifyTwo, secondVerifyTwo);
                Console.WriteLine($"{playerTwoName}, your tally is {tallyTwo}");
                Console.WriteLine();
                Console.WriteLine(playerOneName.ToUpper());
                string firstVerifyOne = CardRequest(playerOne, playerOneName);
                string secondVerifyOne = CardRequest(playerOne, playerOneName);
                int tallyOne = PlayerTally(firstVerifyOne, secondVerifyOne);
                Console.WriteLine($"{playerOneName}, your tally is {tallyOne}");
                Console.WriteLine();
                EvaluateWinner(tallyOne, tallyTwo, playerOneName, playerTwoName);
            }
        }

        public void RoundFive(List<string> playerOne, List<string> playerTwo, string playerOneName, string playerTwoName)
        {
            CheckGameWinner(playerOneName, playerTwoName);
            Console.WriteLine("LINCOLN - FINAL ROUND");
            Console.WriteLine();
            Console.WriteLine("As you have both won two rounds, I shall now draw a random card from each of your hands.\n" +
                "The highest card shall win. If this leads to a draw, your last cards will be drawn and the highest will win.");
            Console.WriteLine();

            // Write out the structure for the fifth and final round, which only comes into play in the event of a tiebreaker
            Console.WriteLine(playerOneName.ToUpper());
            Console.WriteLine("Press any key to choose your random card");
            Console.ReadKey();
            int firstPlayerOneShuffle = random.Next(playerOne.Count);
            string firstVerifyOne = playerOne[firstPlayerOneShuffle];
            Console.WriteLine($"I give you the {firstVerifyOne}");
            int firstTallyOne = PlayerTally(firstVerifyOne);
            Console.WriteLine(playerTwoName.ToUpper());
            Console.WriteLine("Press any key to choose your random card");
            Console.ReadKey();
            int playerTwoShuffle = random.Next(playerTwo.Count);
            string firstVerifyTwo = playerTwo[playerTwoShuffle];
            Console.WriteLine($"I give you the {firstVerifyTwo}");
            int firstTallyTwo = PlayerTally(firstVerifyTwo);
            Console.WriteLine();
            EvaluateWinner(firstTallyOne, firstTallyTwo, playerOneName, playerTwoName);
            CheckGameWinner(playerOneName, playerTwoName);

            // In the event, the selected cards still draw...
            Console.WriteLine(playerOneName.ToUpper());
            Console.WriteLine("Press any key to choose your random card");
            Console.ReadKey();
            int playerOneShuffle = random.Next(playerOne.Count);
            string secondVerifyOne = playerOne[playerOneShuffle];
            Console.WriteLine($"I give you the {secondVerifyOne}");
            int secondTallyOne = PlayerTally(secondVerifyOne);
            Console.WriteLine(playerTwoName.ToUpper());
            Console.WriteLine("Press any key to choose your random card");
            Console.ReadKey();
            int secondPlayerTwoShuffle = random.Next(playerTwo.Count);
            string secondVerifyTwo = playerTwo[secondPlayerTwoShuffle];
            Console.WriteLine($"I give you the {secondVerifyTwo}");
            int secondTallyTwo = PlayerTally(secondVerifyTwo);
            Console.WriteLine();
            EvaluateWinner(secondTallyOne, secondTallyTwo, playerOneName, playerTwoName);
            CheckGameWinner(playerOneName, playerTwoName);
        }
    }
}
