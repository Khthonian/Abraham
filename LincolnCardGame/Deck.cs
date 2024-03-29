﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LincolnCardGame
{
    public class Deck : Game
    {
        // Add random function, to be used later when shuffling
        private readonly Random randomIndex = new();
        // Create a string list of all the suits in a standard deck of 52 french-style playing cards
        public List<string> Suits = new() { "Diamonds", "Hearts", "Clubs", "Spades" };
        // Create a string list of all the ranks in a standard deck of 52 french style playing cards
        public List<string> Ranks = new() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

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
                    Card card = new()
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
            bool gameActive = true;
            while (gameActive == true)
            {
                Console.WriteLine("PLEASE INPUT:\nA to begin the game against Abraham ~ P to begin the game against another player\nS to Shuffle ~ E to exit\nPress ENTER to confirm");
                // Create a switch menu to handle in-game progression
                switch (Console.ReadLine().ToLower())
                {
                    case "a":
                        List<string> playerHand = Deal();
                        List<string> abrahamHand = Deal();
                        InitiateGamePvCPU(playerHand, abrahamHand);
                        break;
                    case "p":
                        List<string> playerOneHand = Deal();
                        List<string> playerTwoHand = Deal();
                        InitiateGamePvP(playerOneHand, playerTwoHand);
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

        public void Shuffle()
        {
            // Convert the stack into a list in order to shuffle
            List<Card> list = NewDeck.ToList();
            int n = list.Count;
            while (n > 1)
            {
                // Shuffle the list by picking a random available index
                n--;
                int randomItem = randomIndex.Next(n + 1);
                Card value = list[randomItem];
                list[randomItem] = list[n];
                list[n] = value;
            }
            NewDeck = new Stack<Card>(list);
            Console.WriteLine("\nDeck Shuffled");
        }

        public List<string> Deal()
        {
            // Loop through the stack of cards placing 10 cards into a list
            // Return this list as a player's hand of cards
            var DealtCards = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                DealtCards.Add($"{NewDeck.Peek().Rank} of {NewDeck.Peek().Suit}");
                NewDeck.Pop();
            }
            return DealtCards;
        }
    }
}
