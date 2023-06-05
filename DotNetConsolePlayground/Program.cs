// This using statement is a way to import namespaces into the current file.
using DotNetConsolePlayground.CardGame;

// Namespaces are a way to organize classes into logical groups.
namespace DotNetConsolePlayground
{
    /*
     * The Main method in the Program.cs file is the entry point for dotnet applications.
     * 
     * It is also possible to use something called top level statements:
     * https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/top-level-statements
     * which omits the main method.
     */
    internal class Program
    {
        // Triple slash comments can be used for XML documentation.
        
        /// <summary>
        /// The entry point for the application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            CardGameHandler cardGame = new CardGameHandler();
            cardGame.Run();
        }
    }
}