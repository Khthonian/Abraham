namespace LincolnCardGame
{
    public class Card : ICard
    {
        // Create to basic automatic properties for the suits and the ranks in the card class
        public string Rank { get; set; }
        public string Suit { get; set; }
    }
}
