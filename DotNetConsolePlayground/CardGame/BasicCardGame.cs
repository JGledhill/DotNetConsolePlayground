namespace DotNetConsolePlayground.CardGame
{
    internal class BasicCardGame : ICardGame
    {
        /* This class implements the ICardGame interface.
         * For the class to be valid, it must implement all the methods defined in the interface,
         * if it doesn't, the compiler will throw an error.
         * In this case all we need is the StartGame() method .
         */
        public void StartGame()
        {
            Console.WriteLine("Welcome to the basic card game!");
            Console.WriteLine("===============================");
            Console.WriteLine("Press any key to deal a card, press escape to exit.");

            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                Card? card = DeckManager.DealCard();

                if (card == null)
                {
                    Console.WriteLine("No cards left in the deck.");
                    break;
                }

                Console.WriteLine(card.ToString());
            }
        }
    }
}
