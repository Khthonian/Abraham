using System;

namespace LincolnCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialise the app with a fresh deck for the player
            Deck deck = new Deck();
            while (true)
            {
                // Welcome the user to the application
                // I have called the application Carreaux, the french phrase for diamonds in realtion to cards
                Console.WriteLine("Hello, I'm Abraham, the Lincoln Card Game\nPress ENTER to begin\nInput 'E' then ENTER to exit");
                switch (Console.ReadLine().ToLower())
                {
                    case "":
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
