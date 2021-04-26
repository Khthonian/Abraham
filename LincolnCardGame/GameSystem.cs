using System;

namespace LincolnCardGame
{
    public class GameSystem : Rules
    {
        // Initialise the classes for storing scores
        Player playerOneID = new Player();
        Player playerTwoID = new Player();

        public int PlayerScore(string playedCard)
        {
            // Evaluate the score for each individual card selected
            int playerScore = 0;
            switch (playedCard)
            {
                case "2":
                    playerScore = 2;
                    break;
                case "3":
                    playerScore = 3;
                    break;
                case "4":
                    playerScore = 4;
                    break;
                case "5":
                    playerScore = 5;
                    break;
                case "6":
                    playerScore = 6;
                    break;
                case "7":
                    playerScore = 7;
                    break;
                case "8":
                    playerScore = 8;
                    break;
                case "9":
                    playerScore = 9;
                    break;
                case "10":
                    playerScore = 10;
                    break;
                case "Jack":
                    playerScore = 11;
                    break;
                case "Queen":
                    playerScore = 12;
                    break;
                case "King":
                    playerScore = 13;
                    break;
                case "Ace":
                    playerScore = 14;
                    break;
                default:
                    PlayerScore(playedCard);
                    break;
            }
            return playerScore;
        }

        protected void EvaluateWinner(int playerOne, int playerTwo)
        {
            int highestScore = Math.Max(playerOne, playerTwo);
            if (highestScore == playerOne)
            {
                playerOneID.PlayerWin();
            }
            else if (highestScore == playerTwo)
            {
                playerTwoID.PlayerWin();
            }
            else
            {
                //DrawnRound();
            }
        }
    }
}
