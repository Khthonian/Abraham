using System;

namespace LincolnCardGame
{
    class Program
    {
        public static void Main()
        {
            // Initialise the app with a fresh deck for the player
            Console.Title = "Abraham, the Lincoln Card Game";
            Deck deck = new();
            while (true)
            {
                // Welcome the user to the application
                // I have called the application Abraham, after Abraham Lincoln
                Console.WriteLine("Hello, I'm Abraham, the Lincoln Card Game\nPress ENTER to begin\nInput 'E' then ENTER to exit");
                switch (Console.ReadLine().ToLower())
                {
                    case "":
                        Console.WriteLine("RULES:\n" +
                            "Each player receives 10 cards.\n" +
                            "Each player plays 2 cards.\n" +
                            "The player with the highest total will win the hand, then will play first on the next round.\n" +
                            "Card values are: 2,3,4,5,6,7,8,9,10,J(11),Q(12),K(13),A(14)\n" +
                            "If totals are the same, continue to next hand. Winning player gets both hands.\n" +
                            "Player with highest number of hand wins, wins the game.\n" +
                            "If the number of hand wins are the same, draw a random card from the remaining cards - highest wins.\n" +
                            "If the final hands are the same value, draw a random card from the remaining cards - highest wins the hand.");
                        Console.WriteLine();
                        Console.WriteLine("Let's begin!");
                        deck.FreshDeck();
                        deck.Shuffle();
                        deck.AbrahamMenu();
                        break;
                    case "e":
                        Console.WriteLine("Thanks for using Abraham, the Lincoln Card Game");
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
