namespace DotNetConsolePlayground.CardGame
{
    // A static class cannot be instantiated, it can only contain static members and doesn't require a constructor.
    // Static members are shared across all instances of the class.
    // Static members can be accessed without instantiating the class.
    // Example:
    // Instead of:
    //        var deckManager = new DeckManager();
    //        deckManager.CreateDeck();
    // You can do:
    //        DeckManger.CreateDeck();
    // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/static
    public static class DeckManager
    {
        // We keep class level variables private and expose them through public methods.
        // This allows us to control how the variables are accessed and ensures that they are not modified in unexpected ways.
        private static List<Card> _deck;
        
        public static void CreateDeck()
        {
            _deck = new List<Card>();

            foreach (var suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (var rank in Enum.GetValues(typeof(Rank)))
                {
                    _deck.Add(new Card((Suit)suit, (Rank)rank));
                }
            }
        }
        public static void DisplayDeck()
        {
            // foreach loops are a way to iterate over a collection.
            // They're usful to avoid off by one errors and to make code more readable.
            foreach (var card in _deck)
            {
                Console.WriteLine(card.ToString());
            }
        }

        // The ? after the type name means that the type is nullable.
        public static Card? DealCard()
        {
            Card? card = _deck.FirstOrDefault();
            if (card == null)
                return null;
            
            _deck.Remove(card);
            return card;
        }
    }
}
