namespace DotNetConsolePlayground.CardGame
{
    /* Suggested tasks:
     * 1. Add a new suit called Emeralds.
     * 2. Write a new method in the DeckManager class that deals a hand of cards,
     *    you should be able to supply the number when calling the method.
     * 3. Write a new method in the DeckManager class that shuffles the deck. Hint: https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-7.0&viewFallbackFrom=net-6#examples
     * 4. Write a new card game class called; BlackJackGame() that implements the ICardGame interface.
     *    Keep it simple, allow the player to hit or stand, if they go over 21 they lose.
     * 5. Edit the Run() method in this class to allow the user to select the game.
     *    Something like: Console.WriteLine("Select a game to play: 1 = Basic, 2 = BlackJack");
     * 6. Write a new card game class called; PokerGame() that implements the ICardGame interface.
     *    Draw cards for the player, 5 at a time, then display the best hand they can make.
     *    e.g. Pair, Flush, Straight, etc: https://en.wikipedia.org/wiki/List_of_poker_hands
     */
    public class CardGameHandler
    {
        /* A constructor, this is called when the class is instantiated.
         * e.g. var cardGameProcess = new CardGameProcess();
         */
        public CardGameHandler()
        {
            Setup();
        }
        
        // A private method, this can only be accessed from within the class.
        private void Setup()
        {
            DeckManager.CreateDeck();
        }

        // A public method, this can be accessed from anywhere in the program.
        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/access-modifiers
        public void Run()
        {
            Console.WriteLine("Display Deck? Y/N");
            if (Console.ReadKey(true).Key == ConsoleKey.Y)
                DeckManager.DisplayDeck();
            
            ICardGame cardGame = new BasicCardGame();
            cardGame.StartGame();
        }
    }
}
