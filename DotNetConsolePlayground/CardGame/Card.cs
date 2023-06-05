namespace DotNetConsolePlayground.CardGame
{
    public class Card
    {
        public Card(Suit suit, Rank rank)
        {
            Suit = suit;
            Rank = rank;
        }

        // Properties are a way of defining getters and setters for a class:
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }

        // The override keyword is used to override a method in a base class:
        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/override
        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }

    // Enums are a way of defining a set of constants:
    // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    // By default, the first value in an enum is 0, the second is 1, and so on.
    // You can override this behaviour by specifying the value of the first enum.
    public enum Rank
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
}