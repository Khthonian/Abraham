using System;
using System.Collections.Generic;
using System.Linq;

namespace LincolnCardGame
{
    public class Deck : Card

    {
        // Add random function, to be used later when shuffling
        private readonly Random random = new Random();
        // Create a string list of all the suits in a standard deck of 52 french-style playing cards
        public List<string> Suits = new List<string> { "♦", "♥", "♣", "♠" };
        // Create a string list of all the ranks in a standard deck of 52 french style playing cards
        public List<string> Ranks = new List<string> { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        // Control the deck with an automatic property
        public Stack<Card> NewDeck { get; set; }
        public void FreshDeck()
        {
            // Deck is set as a brand new stack
            NewDeck = new Stack<Card>();
            // Iterate through each suit, then through each rank respectively
            foreach (string suit in Suits)
            {
                foreach (string rank in Ranks)
                {
                    Card card = new Card
                    {
                        Suit = suit,
                        Rank = rank
                    };
                    // Push the new card onto the stack
                    NewDeck.Push(card);
                }
            }
            Console.WriteLine("I have created a new deck for you.");
        }

        public void AbrahamMenu()
        {
            // Check to see whether the stack is empty or not
            while (IsEmpty() != true)
            {
                Console.WriteLine("Press ENTER to begin the game\nS to Shuffle ~ E to exit\nPress ENTER to confirm");
                // Create a switch menu to handle in-game progression
                switch (Console.ReadLine().ToLower())
                {
                    case "":
                        Game();
                        break;
                    case "s":
                        Shuffle();
                        break;
                    case "e":
                        // Reset and create a fresh stack incase the player decides to play again
                        NewDeck = new Stack<Card>();
                        break;
                    default:
                        break;
                }

            }
        }

        public bool IsEmpty()
        {
            // Check to see whether the stack contains any entities
            if (NewDeck.Count == 0)
            {
                Console.WriteLine("The deck has been completely dealt.");
                Console.WriteLine("\nDo you want me to restart or do you want to exit?\nPress ENTER to restart\nInput 'E' then ENTER to exit");
                switch (Console.ReadLine().ToLower())
                {
                    case "":
                        break;
                    case "e":
                        Console.WriteLine("Thank you for using Abraham. Goodbye.");
                        System.Environment.Exit(0);
                        break;
                    default:
                        break;


                }
                return true;
            }
            return false;
        }
        public void Shuffle()
        {
            // Convert the stack into a list in order to shuffle
            List<Card> list = NewDeck.ToList();
            int n = list.Count;
            while (n > 1)
            {
                // Shuffle the list by picking a random available index
                n--;
                int randomItem = random.Next(n + 1);
                Card value = list[randomItem];
                list[randomItem] = list[n];
                list[n] = value;
            }
            NewDeck = new Stack<Card>(list);
            Console.WriteLine("\nDeck Shuffled");
        }

        protected List<string> Deal()
        {
            var DealtCards = new List<string>();
            Console.WriteLine("I have dealt you:");
            for (int i = 0; i < 10; i++)
            {
                var DealtHand = $"{NewDeck.Peek().Rank} of {NewDeck.Peek().Suit}\n";
                Console.WriteLine(DealtHand);
                DealtCards.Add(DealtHand);
                NewDeck.Pop();                
            } return DealtCards;            
        }

        public void Game()
        {
            // Ask the user if they want to play against a computer or a another player
            Console.WriteLine("Do you wish to play against a player or the CPU");
            Console.WriteLine("Enter P or C respectively");
            switch (Console.ReadLine().ToLower())
            {
                case "p":
                    Game PvP = new Game();
                    PvP.TwoPlayer();
                    break;
                case "c":
                    Game PvCPU = new Game();
                    PvCPU.OnePlayer();
                    break;
                default:
                    Game();
                    break;
            }
                        
            
            List<string> playerOneHand = Deal();
            List<string> playerTwoHand = Deal();

            
            
        }
    }
}
