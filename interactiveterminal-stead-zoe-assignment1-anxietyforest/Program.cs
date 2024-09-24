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
        if (playerInput == "Start")
        {
            // Start the game - dialogue
            Console.WriteLine("You are Lexi, a 20 year old girl.");
            Console.WriteLine("You love socializing with people, but you've been having trouble doing so because of your anxiety.");
            Console.WriteLine("You also love going on hikes, and you tell yourself that today is the day to overcome your anxiety.");
            Console.WriteLine("You pack up your stuff and make your way to the Forest of Destiny in the town of New Athens.");
            Console.WriteLine("A bit later, you arrive at the entrance of the Forest of Destiny.");
            Console.WriteLine("As you step past the entrance sign and slowly make your way deeper into the forest, you can't help but notice how calming it is to look at the scenery.");
            Console.WriteLine("You walk past a big boulder, but then you hear something.");
            Console.WriteLine("\"Hey there, young lady!\" A voice speaks to you. You turn and see an elderly woman standing on the boulder. \"Where may you be going?\"");
            Console.WriteLine("\"I'm going to the other side of the forest, to find inner peace within myself.\" You tell the woman.");
            Console.WriteLine("The woman shakes her head in disbelief. \"You don't plan on going further, do you? It's dangerous in there. I don't recommend you do such a thing.\"");
            Console.WriteLine("You pause to think to yourself for a bit. Do you listen to the elderly woman or do you ignore her and continue onward?");

            // Get a response from the player
            playerInput = Console.ReadLine();

            // Compare the events of listening and ignoring the woman
            if (playerInput == "Ignore")
            {
                // Continue the game
                Console.WriteLine("After thinking for a bit, you decide to ignore the woman's warnings.");
            }
            else if (playerInput == "Listen")
            {
                // End the game and give the player the first ending
                Console.WriteLine("You listen to the woman. \"Alright then, I'll head back. Thank you for warning me.\"");
                Console.WriteLine("\"I'm just doing what I can do protect the youth\" The woman responds.");
                Console.WriteLine("You head back on the path that you went entering the forest, and return to your house.");
                Console.WriteLine("Thanks For Playing!");
                Console.WriteLine("Ending 1/7 - \"With Hesitation\" Unlocked!");
                Console.WriteLine("Play again to gain all endings!");
            }
            else
            {
                // Let the player know that what they typed is invalid
                Console.WriteLine($"Your response \"{playerInput}\" is not valid.");
            }
        }
        else if (playerInput == "Quit") 
        {
            // End the program
            Console.WriteLine("Have a nice day!");
        }
        else
        {
            // Let the player know that what they typed is invalid
            Console.WriteLine($"Your response \"{playerInput}\" is not valid.");
        }
    }
}

