using System;
using System.Collections.Generic;

namespace LincolnCardGame
{
    public class RoundStructurePvCPU : GameSystem
    {
        public void FiveRoundsPvCPU(List<string> playerOne, List<string> abraham, string playerOneName, string abrahamName)
        {
            RoundOne(playerOne, abraham, playerOneName, abrahamName);
            RoundTwo(playerOne, abraham, playerOneName, abrahamName);
            RoundThree(playerOne, abraham, playerOneName, abrahamName);
            RoundFour(playerOne, abraham, playerOneName, abrahamName);
            RoundFive(playerOne, abraham, playerOneName, abrahamName);
        }

        public void RoundOne(List<string> playerOne, List<string> abraham, string playerOneName, string abrahamName)
        {
            // Write out the structure for the first round
            Console.WriteLine("LINCOLN - ROUND 1");
            Console.WriteLine();
            Console.WriteLine(playerOneName.ToUpper());
            string firstVerifyOne = CardRequest(playerOne, playerOneName);
            string secondVerifyOne = CardRequest(playerOne, playerOneName);
            int playerTally = PlayerTally(firstVerifyOne, secondVerifyOne);
            Console.WriteLine($"{playerOneName}, your tally is {playerTally}");
            Console.WriteLine();
            Console.WriteLine(abrahamName.ToUpper());
            string abeCardOne = AbrahamShuffle(abraham);
            string abeCardTwo = AbrahamShuffle(abraham);
            int abeTally = PlayerTally(abeCardOne, abeCardTwo);
            Console.WriteLine($"My tally is {abeTally}");
            Console.WriteLine();
            EvaluateWinner(playerTally, abeTally, playerOneName, abrahamName);
        }

        public void RoundTwo(List<string> playerOne, List<string> abraham, string playerOneName, string abrahamName)
        {
            if (drawnRound == true)
            {
                if (playerOneID.playerTurn == true)
                {
                    // Write out the structure for the second round
                    Console.WriteLine("LINCOLN - ROUND 2");
                    Console.WriteLine();
                    Console.WriteLine(playerOneName.ToUpper());
                    string firstVerifyOne = CardRequest(playerOne, playerOneName);
                    string secondVerifyOne = CardRequest(playerOne, playerOneName);
                    int playerTally = PlayerTally(firstVerifyOne, secondVerifyOne);
                    Console.WriteLine($"{playerOneName}, your tally is {playerTally}");
                    Console.WriteLine();
                    Console.WriteLine(abrahamName.ToUpper());
                    string abeCardOne = AbrahamShuffle(abraham);
                    string abeCardTwo = AbrahamShuffle(abraham);
                    int abeTally = PlayerTally(abeCardOne, abeCardTwo);
                    Console.WriteLine($"My tally is {abeTally}");
                    Console.WriteLine();
                    EvaluateWinner(playerTally, abeTally, playerOneName, abrahamName);
                }
                else if (playerTwoID.playerTurn == true)
                {
                    // Write out the structure for the second round
                    Console.WriteLine("LINCOLN - ROUND 2");
                    Console.WriteLine();
                    Console.WriteLine(abrahamName.ToUpper());
                    string abeCardOne = AbrahamShuffle(abraham);
                    string abeCardTwo = AbrahamShuffle(abraham);
                    int abeTally = PlayerTally(abeCardOne, abeCardTwo);
                    Console.WriteLine($"My tally is {abeTally}");
                    Console.WriteLine();
                    Console.WriteLine(playerOneName.ToUpper());
                    string firstVerifyOne = CardRequest(playerOne, playerOneName);
                    string secondVerifyOne = CardRequest(playerOne, playerOneName);
                    int playerTally = PlayerTally(firstVerifyOne, secondVerifyOne);
                    Console.WriteLine($"{playerOneName}, your tally is {playerTally}");
                    Console.WriteLine();
                    EvaluateWinner(playerTally, abeTally, playerOneName, abrahamName);
                }
            }
            else if (drawnRound == false)
            {
                if (playerOneID.playerTurn == true)
                {
                    // Write out the structure for the second round
                    Console.WriteLine("LINCOLN - ROUND 2");
                    Console.WriteLine();
                    Console.WriteLine(playerOneName.ToUpper());
                    string firstVerifyOne = CardRequest(playerOne, playerOneName);
                    string secondVerifyOne = CardRequest(playerOne, playerOneName);
                    int playerTally = PlayerTally(firstVerifyOne, secondVerifyOne);
                    Console.WriteLine($"{playerOneName}, your tally is {playerTally}");
                    Console.WriteLine();
                    Console.WriteLine(abrahamName.ToUpper());
                    string abeCardOne = AbrahamShuffle(abraham);
                    string abeCardTwo = AbrahamShuffle(abraham);
                    int abeTally = PlayerTally(abeCardOne, abeCardTwo);
                    Console.WriteLine($"My tally is {abeTally}");
                    Console.WriteLine();
                    EvaluateWinner(playerTally, abeTally, playerOneName, abrahamName);
                }
                else if (playerTwoID.playerTurn == true)
                {
                    // Write out the structure for the second round
                    Console.WriteLine("LINCOLN - ROUND 2");
                    Console.WriteLine();
                    Console.WriteLine(abrahamName.ToUpper());
                    string abeCardOne = AbrahamShuffle(abraham);
                    string abeCardTwo = AbrahamShuffle(abraham);
                    int abeTally = PlayerTally(abeCardOne, abeCardTwo);
                    Console.WriteLine($"My tally is {abeTally}");
                    Console.WriteLine();
                    Console.WriteLine(playerOneName.ToUpper());
                    string firstVerifyOne = CardRequest(playerOne, playerOneName);
                    string secondVerifyOne = CardRequest(playerOne, playerOneName);
                    int playerTally = PlayerTally(firstVerifyOne, secondVerifyOne);
                    Console.WriteLine($"{playerOneName}, your tally is {playerTally}");
                    Console.WriteLine();
                    EvaluateWinner(playerTally, abeTally, playerOneName, abrahamName);
                }
            }
        }

        public void RoundThree(List<string> playerOne, List<string> abraham, string playerOneName, string abrahamName)
        {
            if (drawnRound == true)
            {
                if (playerOneID.playerTurn == true)
                {
                    // Write out the structure for the third round
                    Console.WriteLine("LINCOLN - ROUND 3");
                    Console.WriteLine();
                    Console.WriteLine(playerOneName.ToUpper());
                    string firstVerifyOne = CardRequest(playerOne, playerOneName);
                    string secondVerifyOne = CardRequest(playerOne, playerOneName);
                    int playerTally = PlayerTally(firstVerifyOne, secondVerifyOne);
                    Console.WriteLine($"{playerOneName}, your tally is {playerTally}");
                    Console.WriteLine();
                    Console.WriteLine(abrahamName.ToUpper());
                    string abeCardOne = AbrahamShuffle(abraham);
                    string abeCardTwo = AbrahamShuffle(abraham);
                    int abeTally = PlayerTally(abeCardOne, abeCardTwo);
                    Console.WriteLine($"My tally is {abeTally}");
                    Console.WriteLine();
                    EvaluateWinner(playerTally, abeTally, playerOneName, abrahamName);
                }
                else if (playerTwoID.playerTurn == true)
                {
                    // Write out the structure for the third round
                    Console.WriteLine("LINCOLN - ROUND 3");
                    Console.WriteLine();
                    Console.WriteLine(abrahamName.ToUpper());
                    string abeCardOne = AbrahamShuffle(abraham);
                    string abeCardTwo = AbrahamShuffle(abraham);
                    int abeTally = PlayerTally(abeCardOne, abeCardTwo);
                    Console.WriteLine($"My tally is {abeTally}");
                    Console.WriteLine();
                    Console.WriteLine(playerOneName.ToUpper());
                    string firstVerifyOne = CardRequest(playerOne, playerOneName);
                    string secondVerifyOne = CardRequest(playerOne, playerOneName);
                    int playerTally = PlayerTally(firstVerifyOne, secondVerifyOne);
                    Console.WriteLine($"{playerOneName}, your tally is {playerTally}");
                    Console.WriteLine();
                    EvaluateWinner(playerTally, abeTally, playerOneName, abrahamName);
                }
            }
            else if (drawnRound == false)
            {
                if (playerOneID.playerTurn == true)
                {
                    // Write out the structure for the third round
                    Console.WriteLine("LINCOLN - ROUND 3");
                    Console.WriteLine();
                    Console.WriteLine(playerOneName.ToUpper());
                    string firstVerifyOne = CardRequest(playerOne, playerOneName);
                    string secondVerifyOne = CardRequest(playerOne, playerOneName);
                    int playerTally = PlayerTally(firstVerifyOne, secondVerifyOne);
                    Console.WriteLine($"{playerOneName}, your tally is {playerTally}");
                    Console.WriteLine();
                    Console.WriteLine(abrahamName.ToUpper());
                    string abeCardOne = AbrahamShuffle(abraham);
                    string abeCardTwo = AbrahamShuffle(abraham);
                    int abeTally = PlayerTally(abeCardOne, abeCardTwo);
                    Console.WriteLine($"My tally is {abeTally}");
                    Console.WriteLine();
                    EvaluateWinner(playerTally, abeTally, playerOneName, abrahamName);
                }
                else if (playerTwoID.playerTurn == true)
                {
                    // Write out the structure for the third round
                    Console.WriteLine("LINCOLN - ROUND 3");
                    Console.WriteLine();
                    Console.WriteLine(abrahamName.ToUpper());
                    string abeCardOne = AbrahamShuffle(abraham);
                    string abeCardTwo = AbrahamShuffle(abraham);
                    int abeTally = PlayerTally(abeCardOne, abeCardTwo);
                    Console.WriteLine($"My tally is {abeTally}");
                    Console.WriteLine();
                    Console.WriteLine(playerOneName.ToUpper());
                    string firstVerifyOne = CardRequest(playerOne, playerOneName);
                    string secondVerifyOne = CardRequest(playerOne, playerOneName);
                    int playerTally = PlayerTally(firstVerifyOne, secondVerifyOne);
                    Console.WriteLine($"{playerOneName}, your tally is {playerTally}");
                    Console.WriteLine();
                    EvaluateWinner(playerTally, abeTally, playerOneName, abrahamName);
                }
            }
        }

        public void RoundFour(List<string> playerOne, List<string> abraham, string playerOneName, string abrahamName)
        {
            CheckGameWinner(playerOneName, abrahamName);
            if (drawnRound == true)
            {
                if (playerOneID.playerTurn == true)
                {
                    // Write out the structure for the fourth round
                    Console.WriteLine("LINCOLN - ROUND 4");
                    Console.WriteLine();
                    Console.WriteLine(playerOneName.ToUpper());
                    string firstVerifyOne = CardRequest(playerOne, playerOneName);
                    string secondVerifyOne = CardRequest(playerOne, playerOneName);
                    int playerTally = PlayerTally(firstVerifyOne, secondVerifyOne);
                    Console.WriteLine($"{playerOneName}, your tally is {playerTally}");
                    Console.WriteLine();
                    Console.WriteLine(playerOneName.ToUpper());
                    string abeCardOne = AbrahamShuffle(abraham);
                    string abeCardTwo = AbrahamShuffle(abraham);
                    int abeTally = PlayerTally(abeCardOne, abeCardTwo);
                    Console.WriteLine($"My tally is {abeTally}");
                    Console.WriteLine();
                    EvaluateWinner(playerTally, abeTally, playerOneName, abrahamName);
                }
                else if (playerTwoID.playerTurn == true)
                {
                    // Write out the structure for the fourth round
                    Console.WriteLine("LINCOLN - ROUND 4");
                    Console.WriteLine();
                    Console.WriteLine(abrahamName.ToUpper());
                    string abeCardOne = AbrahamShuffle(abraham);
                    string abeCardTwo = AbrahamShuffle(abraham);
                    int abeTally = PlayerTally(abeCardOne, abeCardTwo);
                    Console.WriteLine($"My tally is {abeTally}");
                    Console.WriteLine();
                    Console.WriteLine(playerOneName.ToUpper());
                    string firstVerifyOne = CardRequest(playerOne, playerOneName);
                    string secondVerifyOne = CardRequest(playerOne, playerOneName);
                    int playerTally = PlayerTally(firstVerifyOne, secondVerifyOne);
                    Console.WriteLine($"{playerOneName}, your tally is {playerTally}");
                    Console.WriteLine();
                    EvaluateWinner(playerTally, abeTally, playerOneName, abrahamName);
                }
            }
            else if (drawnRound == false)
            {
                if (playerOneID.playerTurn == true)
                {
                    // Write out the structure for the fourth round
                    Console.WriteLine("LINCOLN - ROUND 4");
                    Console.WriteLine();
                    Console.WriteLine(playerOneName.ToUpper());
                    string firstVerifyOne = CardRequest(playerOne, playerOneName);
                    string secondVerifyOne = CardRequest(playerOne, playerOneName);
                    int playerTally = PlayerTally(firstVerifyOne, secondVerifyOne);
                    Console.WriteLine($"{playerOneName}, your tally is {playerTally}");
                    Console.WriteLine();
                    Console.WriteLine(playerOneName.ToUpper());
                    string abeCardOne = AbrahamShuffle(abraham);
                    string abeCardTwo = AbrahamShuffle(abraham);
                    int abeTally = PlayerTally(abeCardOne, abeCardTwo);
                    Console.WriteLine($"My tally is {abeTally}");
                    Console.WriteLine();
                    EvaluateWinner(playerTally, abeTally, playerOneName, abrahamName);
                }
                else if (playerTwoID.playerTurn == true)
                {
                    // Write out the structure for the fourth round
                    Console.WriteLine("LINCOLN - ROUND 4");
                    Console.WriteLine();
                    Console.WriteLine(abrahamName.ToUpper());
                    string abeCardOne = AbrahamShuffle(abraham);
                    string abeCardTwo = AbrahamShuffle(abraham);
                    int abeTally = PlayerTally(abeCardOne, abeCardTwo);
                    Console.WriteLine($"My tally is {abeTally}");
                    Console.WriteLine();
                    Console.WriteLine(playerOneName.ToUpper());
                    string firstVerifyOne = CardRequest(playerOne, playerOneName);
                    string secondVerifyOne = CardRequest(playerOne, playerOneName);
                    int playerTally = PlayerTally(firstVerifyOne, secondVerifyOne);
                    Console.WriteLine($"{playerOneName}, your tally is {playerTally}");
                    Console.WriteLine();
                    EvaluateWinner(playerTally, abeTally, playerOneName, abrahamName);
                }
            }
        }

        public void RoundFive(List<string> playerOne, List<string> abraham, string playerOneName, string abrahamName)
        {
            CheckGameWinner(playerOneName, abrahamName);
            Console.WriteLine("LINCOLN - FINAL ROUND");
            Console.WriteLine();
            Console.WriteLine("As we have both won two rounds, I shall now draw a random card from each of our hands.\n" +
                "The highest card shall win. If this leads to a draw, your last cards will be drawn and the highest will win.");
            Console.WriteLine();

            // Write out the structure for the fifth and final round, which only comes into play in the event of a tiebreaker
            Console.WriteLine(playerOneName.ToUpper());
            Console.WriteLine("Press any key to choose your random card");
            Console.ReadKey();
            int firstPlayerOneShuffle = random.Next(playerOne.Count);
            string firstVerifyOne = playerOne[firstPlayerOneShuffle];
            Console.WriteLine($"I give you the {firstVerifyOne}");
            int firstplayerTally = PlayerTally(firstVerifyOne);
            Console.WriteLine(abrahamName.ToUpper());
            string abeCardOne = AbrahamShuffle(abraham);
            int firstabeTally = PlayerTally(abeCardOne);
            Console.WriteLine();
            EvaluateWinner(firstplayerTally, firstabeTally, playerOneName, abrahamName);
            CheckGameWinner(playerOneName, abrahamName);

            // In the event, the selected cards still draw...
            Console.WriteLine(playerOneName.ToUpper());
            Console.WriteLine("Press any key to choose your random card");
            Console.ReadKey();
            int playerOneShuffle = random.Next(playerOne.Count);
            string secondVerifyOne = playerOne[playerOneShuffle];
            Console.WriteLine($"I give you the {secondVerifyOne}");
            int secondplayerTally = PlayerTally(secondVerifyOne);
            Console.WriteLine(abrahamName.ToUpper());
            string abeCardTwo = AbrahamShuffle(abraham);
            int secondabeTally = PlayerTally(abeCardTwo);
            Console.WriteLine();
            EvaluateWinner(secondplayerTally, secondabeTally, playerOneName, abrahamName);
            CheckGameWinner(playerOneName, abrahamName);
        }
    }
}
