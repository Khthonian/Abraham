using System;

namespace LincolnCardGame
{
    class Program
    {
        public static void Main()
        {
            // Initialise the app with a fresh deck for the player
            Console.Title = "Abraham, the Lincoln Card Game";
            Deck deck = new Deck();
            while (true)
            {
                // Welcome the user to the application
                // I have called the application Carreaux, the french phrase for diamonds in realtion to cards
                Console.WriteLine("Hello, I'm Abraham, the Lincoln Card Game\nPress ENTER to begin\nInput 'E' then ENTER to exit");
                switch (Console.ReadLine().ToLower())
                {
                    case "":
                        Console.WriteLine("RULES:\n" +
                            "Each player receives 10 cards.\n" +
                            "Each player plays 2 cards.\n" +
                            "The player with the highest total will win the hand, then will plays first on the next round.\n" +
                            "Card values are: 2,3,4,5,6,7,8,9,10,J(11),Q(12),K(13),A(14)\n" +
                            "If totals are the same, continue to next hand. Winning player gets both hands.\n" +
                            "Player with highest number of hand wins, wins the game.");
                        Console.WriteLine();
                        Console.WriteLine("Let's begin!");
                        deck.FreshDeck();
                        deck.Shuffle();
                        deck.AbrahamMenu();
                        break;
                    case "e":
                        Console.WriteLine("Thanks for using Abraham, the Lincoln Card Game");
                        System.Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
