using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

internal class Program
{ 
    private static void Main(string[] args)
    {
        // Introduce the player to the game of "Anxiety Forest"
        Console.WriteLine("Welcome to the Anxiety Forest!");
        Console.WriteLine("Type \"start\" to begin the game!");

        // Get a response from the player
        string playerInput;
        playerInput = Console.ReadLine();

        // Compare the events of starting up the game
        if (playerInput == "Start");
        {
            // Start the game - dialogue
            Console.WriteLine("You are Lexi, a 20 year old girl.");
            Console.WriteLine("You love socializing with people, but you've been having trouble doing so because of your anxiety.");
            Console.WriteLine("You also love going on hikes, and you tell yourself that today is the day to overcome your anxiety.");
            Console.WriteLine("You pack up your stuff and make your way to the Forest of Destiny in the town of New Athens");
        }
        else if (playerInput == "Quit") ;
        {
            // End the program
            Console.WriteLine("Have a nice day!");
        }
        else
        {
            // Let the player know that what they typed is invalid
            Console.WriteLine($"Your response is \"{playerInput}\" is not valid.");
        }
    }
}

