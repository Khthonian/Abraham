using System;

namespace LincolnCardGame
{
    public class Rules
    {
        public bool drawnRound = false;

        protected static int PlayerScore(string playedCard)
        {
            // Evaluate the score for each individual card selected
            int playerScore;
            switch (playedCard)
            {
                case "2 of Diamonds":
                case "2 of Hearts":
                case "2 of Spades":
                case "2 of Clubs":
                    playerScore = 2;
                    Console.WriteLine("2 POINTS AWARDED");
                    break;
                case "3 of Diamonds":
                case "3 of Hearts":
                case "3 of Spades":
                case "3 of Clubs":
                    playerScore = 3;
                    Console.WriteLine("3 POINTS AWARDED");
                    break;
                case "4 of Diamonds":
                case "4 of Hearts":
                case "4 of Spades":
                case "4 of Clubs":
                    playerScore = 4;
                    Console.WriteLine("4 POINTS AWARDED");
                    break;
                case "5 of Diamonds":
                case "5 of Hearts":
                case "5 of Spades":
                case "5 of Clubs":
                    playerScore = 5;
                    Console.WriteLine("5 POINTS AWARDED");
                    break;
                case "6 of Diamonds":
                case "6 of Hearts":
                case "6 of Spades":
                case "6 of Clubs":
                    playerScore = 6;
                    Console.WriteLine("6 POINTS AWARDED");
                    break;
                case "7 of Diamonds":
                case "7 of Hearts":
                case "7 of Spades":
                case "7 of Clubs":
                    playerScore = 7;
                    Console.WriteLine("7 POINTS AWARDED");
                    break;
                case "8 of Diamonds":
                case "8 of Hearts":
                case "8 of Spades":
                case "8 of Clubs":
                    playerScore = 8;
                    Console.WriteLine("8 POINTS AWARDED");
                    break;
                case "9 of Diamonds":
                case "9 of Hearts":
                case "9 of Spades":
                case "9 of Clubs":
                    playerScore = 9;
                    Console.WriteLine("9 POINTS AWARDED");
                    break;
                case "10 of Diamonds":
                case "10 of Hearts":
                case "10 of Spades":
                case "10 of Clubs":
                    playerScore = 10;
                    Console.WriteLine("10 POINTS AWARDED");
                    break;
                case "Jack of Diamonds":
                case "Jack of Hearts":
                case "Jack of Spades":
                case "Jack of Clubs":
                    playerScore = 11;
                    Console.WriteLine("11 POINTS AWARDED");
                    break;
                case "Queen of Diamonds":
                case "Queen of Hearts":
                case "Queen of Spades":
                case "Queen of Clubs":
                    playerScore = 12;
                    Console.WriteLine("12 POINTS AWARDED");
                    break;
                case "King of Diamonds":
                case "King of Hearts":
                case "King of Spades":
                case "King of Clubs":
                    playerScore = 13;
                    Console.WriteLine("13 POINTS AWARDED");
                    break;
                case "Ace of Diamonds":
                case "Ace of Hearts":
                case "Ace of Spades":
                case "Ace of Clubs":
                    playerScore = 14;
                    Console.WriteLine("14 POINTS AWARDED");
                    break;
                default:
                    playerScore = 1;
                    Console.WriteLine("You have entered a false value and shall suffer a 0 point penalty");
                    break;                
            }
            return playerScore;            
        }

        public void DrawnRound()
        {
            drawnRound = true;
        }
    }
}
