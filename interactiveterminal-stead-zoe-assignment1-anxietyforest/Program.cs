using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        // Introduce the player to the game of "Anxiety Forest"
        Console.WriteLine("Welcome to the Anxiety Forest! \n");
        Console.WriteLine("Type \"start\" to begin the game! \n");

        // Get a response from the player
        string playerInput;
        playerInput = Console.ReadLine();

        // Compare the events of starting up the game
        if (playerInput == "Start")
        {
            // Start the game - dialogue
            Console.WriteLine("You are Lexi, a 20 year old girl who loves to socialize, but has trouble doing so because of anxiety.\n");
            Console.WriteLine("You also love going on hikes, and you tell yourself that today is the day to overcome your anxiety.\n");
            Console.WriteLine("You head off into the enchanted forest, and all of the sudden you hear an elderly woman who warns you.\n");
            Console.WriteLine("Do you \"listen\" or \"ignore?\" \n");

            // Get a response from the player
            playerInput = Console.ReadLine();

            // Compare the events of listening and ignoring the woman
            if (playerInput == "Ignore")
            {
                // Continue the game
                Console.WriteLine("You continue on your journey, but you've annoyed the woman.\n");
                Console.WriteLine("You proceed to your adventure. You spot a large piece of stick on the side of the road. You stop to the side and pick it up, keeping hold of it.\n");
                Console.WriteLine("Suddenly, you hear strange noises. Ones that sound rather frightening.\n");
                Console.WriteLine("You hear the noises again, and turn to see that a slime monster was sneaking up behind you, trying to turn you into its next meal.\n");
                Console.WriteLine("You grab your stick, preparing for a fight. Do you attack the creature or use an item? \n");

                // Get a response from the player
                playerInput = Console.ReadLine();

                // Compare the events of fighting the slime monster
                if (playerInput == "Attack")
                {
                    // Continue the game
                    Console.WriteLine("You choose to attack the creature.\n");
                    Console.WriteLine("Using the force that you've got and the stick that you found, you take a massive swing at the slime creature, hitting it in the process.\n");
                    Console.WriteLine("Somehow, it was enough to scare it away for good. You won the battle.\n");
                    Console.WriteLine("You can't help but notice that you're in pain. You've taken such hits from the battle that you've received cuts and bruises.\n");
                    Console.WriteLine("You continue on your journey, even though you are limping in pain.\n");
                    Console.WriteLine("As you walk deeper into the forest, you encounter a fork in the road.\n");
                    Console.WriteLine("Do you take the left path or the right path? \n");

                    // Get a response from the player
                    playerInput = Console.ReadLine();

                    // Compare the events of choosing a path
                    if (playerInput == "Left")
                    {
                        // Continue the game
                        Console.WriteLine("You decide to go left. You walk on the path.\n");
                        Console.WriteLine("As you proceed, you notice that the trees are becoming more dead and lifeless, having no leaves on them.\n");
                        Console.WriteLine("Eventually, you spot a house in the distance. It looks abandoned, but it might have something useful in there.\n");
                        Console.WriteLine("Do you enter the house or continue onward? \n");

                        // Get a response from the player
                        playerInput = Console.ReadLine();

                        // Compare the events of entering the house
                        if (playerInput == "Enter")
                        {
                            // Continue the game
                            Console.WriteLine("You enter the house. It's dark and rundown. Your suspicions of it being abandoned were true.\n");
                            Console.WriteLine("In the room, there is a couch and a mirror. What do you check first? \n");

                            // Get a response from the player
                            playerInput = Console.ReadLine();

                            // Compare the events of checking the couch and checking the mirror
                            if (playerInput == "Couch")
                            {
                                // Continue the game - Endings 5-8
                                Console.WriteLine("You walk over to the couch. You lift up the coushins and discover that there's a key hiding underneath them.\n");
                                Console.WriteLine("You grab the key and put it in your pocket.\n");
                                Console.WriteLine("You walk over to the mirror and see a reflection of yourself, but it looks warped and sinister.\n");
                                Console.WriteLine("The reflection taunts you about going on the adventure, and demands that you turn back, but you don't listen.\n");
                                Console.WriteLine("You head to the next room, which has a chest. However, you can leave if you please.\n");
                                Console.WriteLine("Do you check the chest or leave? \n");

                                // Get a response from the player
                                playerInput = Console.ReadLine();

                                // Compare the events of checking the chest and leaving
                                if (playerInput == "Chest")
                                {
                                    Console.WriteLine("You take the key that you found from earlier and put it into the chest.\n");
                                    Console.WriteLine("You open it and find 100 gold and a medic bag.\n");
                                    Console.WriteLine("You take everything and heal your wounds, before going back on your adventure.\n");
                                    Console.WriteLine("You head on your way, but you come across a skeleton. Do you attack the skeleton or use an item? \n");

                                    // Get a response from the player
                                    playerInput = Console.ReadLine();

                                    // Compare the events of fighting the slime monster
                                    if (playerInput == "Attack")
                                    {
                                        // Continue the game
                                        Console.WriteLine("You choose to attack the creature.\n");
                                        Console.WriteLine("Using the force that you've got and the stick that you found, you take a massive swing at the slime creature, hitting it in the process.\n");
                                        Console.WriteLine("Somehow, it was enough to scare it away for good. You won the battle.\n");
                                        Console.WriteLine("You continue on your journey, and you come across a large river.\n");
                                        Console.WriteLine("You spot a log nearby, but you remember that you could try and jump over the river on your own.\n");
                                        Console.WriteLine("Do you jump over the river or use the log to cross the river? \n");

                                        // Get a response from the player
                                        playerInput = Console.ReadLine();

                                        // Compare the events of crossing the river
                                        if (playerInput == "Jump")
                                        {
                                            // End the game
                                            Console.WriteLine("You try to jump over the river, but fail and fall into it, drowning in the process.\n");
                                        }
                                        else if (playerInput == "Log")
                                        {
                                            // Continue the game
                                            Console.WriteLine("You roll the log across the river, creating a bridge between both sides.\n");
                                            Console.WriteLine("You cross the log to the other side and continue your path.\n");
                                            Console.WriteLine("Eventually, you come across a hiker, who offers you a diamond for 100 gold. Do you accept the offer?\n");

                                            // Get a response from the player
                                            playerInput = Console.ReadLine();

                                            // Compare the events of purchasing an item
                                            if (playerInput == "Yes")
                                            {
                                                // Continue the game
                                                Console.WriteLine("You purchase the diamond, which makes the hiker happy.\n");
                                                Console.WriteLine("He shakes your hand before running off into the distance.\n");
                                                Console.WriteLine("You continue on your trip when you come across a portal. Do you enter it?\n");

                                                // Get a response from the player
                                                playerInput = Console.ReadLine();

                                                // Compare the events of entering the portal
                                                if (playerInput == "Yes")
                                                {
                                                    // Continue the game
                                                    Console.WriteLine("You enter the portal, and you end up in a warped environment.\n");
                                                    Console.WriteLine("The creature from before has returned one final time, and it's time to fight.\n");
                                                    Console.WriteLine("Do you attack or use the diamond?\n");

                                                    // Get a response from the player
                                                    playerInput = Console.ReadLine();

                                                    // Compare the events of attacking and using the potion
                                                    if (playerInput == "Attack")
                                                    {
                                                        // End the game
                                                        Console.WriteLine("You use the stick to hit the creature, but it breaks immediately.\n");
                                                        Console.WriteLine("Suddenly, the creature hits you with a swift blow, causing your vision to go black.\n");
                                                    }
                                                    else if (playerInput == "Diamond")
                                                    {
                                                        // End the game and give the player the third ending
                                                        Console.WriteLine("You pull out your diamond and hold it up in the air, which destroys the creature and blinds everything in a white light.\n");
                                                        Console.WriteLine("You wake up in your bed, shocked that it was all just a dream.\n");
                                                        Console.WriteLine("You fall back asleep, excited about the adventure in the forest that you'll be having the next day.\n");
                                                        Console.WriteLine("Thanks For Playing!\n");
                                                        Console.WriteLine("Ending 3/3 - \"All In Le Head...\" Unlocked!\n");
                                                        Console.WriteLine("Play again to gain all endings!\n");
                                                    }
                                                    else
                                                    {
                                                        // Let the player know that what they typed is invalid
                                                        Console.WriteLine($"Your response \"{playerInput}\" is not valid.");
                                                    }
                                                }
                                                else if (playerInput == "No")
                                                {
                                                    // End the game and give the player the second ending
                                                    Console.WriteLine("You continue your adventure when you see a building in the distance.");
                                                    Console.WriteLine("You arrive at the ice cream shack, happy that you survived the entire journey.");
                                                    Console.WriteLine("You sit down and order some ice cream, before receiving it and enjoying your well-earned treat.");
                                                    Console.WriteLine("Thanks For Playing!");
                                                    Console.WriteLine("Ending 2/3 - \"Well Earned Treat\" Unlocked!");
                                                    Console.WriteLine("Play again to gain all endings!");
                                                }
                                                else
                                                {
                                                    // Let the player know that what they typed is invalid
                                                    Console.WriteLine($"Your response \"{playerInput}\" is not valid.");
                                                }
                                            }
                                            else if (playerInput == "No")
                                            {
                                                // Continue the game
                                                Console.WriteLine("You refuse, but the hiker takes your gold and gives you the diamond before running away.\n");
                                                Console.WriteLine("You continue on your trip when you come across a portal. Do you enter it?\n");

                                                // Get a response from the player
                                                playerInput = Console.ReadLine();

                                                // Compare the events of entering the portal
                                                if (playerInput == "Yes")
                                                {
                                                    // Continue the game
                                                    Console.WriteLine("You enter the portal, and you end up in a warped environment.\n");
                                                    Console.WriteLine("The creature from before has returned one final time, and it's time to fight.\n");
                                                    Console.WriteLine("Do you attack or use the diamond?\n");

                                                    // Get a response from the player
                                                    playerInput = Console.ReadLine();

                                                    // Compare the events of attacking and using the potion
                                                    if (playerInput == "Attack")
                                                    {
                                                        // End the game
                                                        Console.WriteLine("You use the stick to hit the creature, but it breaks immediately.\n");
                                                        Console.WriteLine("Suddenly, the creature hits you with a swift blow, causing your vision to go black.\n");
                                                    }
                                                    else if (playerInput == "Diamond")
                                                    {
                                                        // End the game and give the player the third ending
                                                        Console.WriteLine("You pull out your diamond and hold it up in the air, which destroys the creature and blinds everything in a white light.\n");
                                                        Console.WriteLine("You wake up in your bed, shocked that it was all just a dream.\n");
                                                        Console.WriteLine("You fall back asleep, excited about the adventure in the forest that you'll be having the next day.\n");
                                                        Console.WriteLine("Thanks For Playing!\n");
                                                        Console.WriteLine("Ending 3/3 - \"All In Le Head...\" Unlocked!\n");
                                                        Console.WriteLine("Play again to gain all endings!\n");
                                                    }
                                                    else
                                                    {
                                                        // Let the player know that what they typed is invalid
                                                        Console.WriteLine($"Your response \"{playerInput}\" is not valid.");
                                                    }
                                                }
                                                else if (playerInput == "No")
                                                {
                                                    // End the game and give the player the second ending
                                                    Console.WriteLine("You continue your adventure when you see a building in the distance.\n");
                                                    Console.WriteLine("You arrive at the ice cream shack, happy that you survived the entire journey.\n");
                                                    Console.WriteLine("You sit down and order some ice cream, before receiving it and enjoying your well-earned treat.\n");
                                                    Console.WriteLine("Thanks For Playing!\n");
                                                    Console.WriteLine("Ending 2/3 - \"Well Earned Treat\" Unlocked!\n");
                                                    Console.WriteLine("Play again to gain all endings!\n");
                                                }
                                                else
                                                {
                                                    // Let the player know that what they typed is invalid
                                                    Console.WriteLine($"Your response \"{playerInput}\" is not valid.");
                                                }
                                            }
                                            else
                                            {
                                                // Let the player know that what they typed is invalid
                                                Console.WriteLine($"Your response \"{playerInput}\" is not valid.");
                                            }
                                        }
                                        else
                                        {
                                            // Let the player know that what they typed is invalid
                                            Console.WriteLine($"Your response \"{playerInput}\" is not valid.");
                                        }
                                    }
                                    else if (playerInput == "Item")
                                    {
                                        // End the game
                                        Console.WriteLine("You don't have any items.\n");
                                        Console.WriteLine("You die to the skeleton.\n");
                                    }
                                    else
                                    {
                                        // Let the player know that what they typed is invalid
                                        Console.WriteLine($"Your response \"{playerInput}\" is not valid.");
                                    }
                                }
                                else if (playerInput == "Mirror")
                                {
                                    // Continue the game
                                    Console.WriteLine("You walk over to the mirror and see a reflection of yourself, but it looks warped and sinister.\n");
                                    Console.WriteLine("The reflection taunts you about going on the adventure, and demands that you turn back, but you don't listen.\n");
                                    Console.WriteLine("You head to the next room, which has a chest. However, you can leave if you please.\n");
                                    Console.WriteLine("Do you check the chest or leave?\n");

                                    // Get a response from the player
                                    playerInput = Console.ReadLine();

                                    // Compare the events of checking the chest and leaving
                                    if (playerInput == "Chest")
                                    {
                                        // End the game
                                        Console.WriteLine("You try to open the chest, but it's locked.\n");
                                        Console.WriteLine("You leave the house and continue onwards, before you die of your wounds.\n");
                                    }
                                    else if (playerInput == "Leave")
                                    {
                                        // End the game
                                        Console.WriteLine("You leave the house and continue onwards, before you die of your wounds.\n");
                                    }
                                    else
                                    {
                                        // Let the player know that what they typed is invalid
                                        Console.WriteLine($"Your response \"{playerInput}\" is not valid.");
                                    }
                                }
                                else
                                {
                                    // Let the player know that what they typed is invalid
                                    Console.WriteLine($"Your response \"{playerInput}\" is not valid.");
                                }
                            }
                        }
                        else if (playerInput == "Continue")
                        {
                            // End the game
                            Console.WriteLine("You ignore the house and continue onwards, before you die of your wounds.\n");
                        }
                        else
                        {
                            // Let the player know that what they typed is invalid
                            Console.WriteLine($"Your response \"{playerInput}\" is not valid.");
                        }
                    }
                    else if (playerInput == "Right")
                    {
                        // End the game
                        Console.WriteLine("You decide to go right, but you die from your wounds.\n");
                    }
                    else
                    {
                        // Let the player know that what they typed is invalid
                        Console.WriteLine($"Your response \"{playerInput}\" is not valid.");
                    }
                }
                else if (playerInput == "Item")
                {
                    // End the game
                    Console.WriteLine("You don't have any items.\n");
                    Console.WriteLine("You die to the slime.\n");
                }
                else
                {
                    // Let the player know that what they typed is invalid
                    Console.WriteLine($"Your response \"{playerInput}\" is not valid.");
                }
            }
            else if (playerInput == "Listen")
            {
                // End the game and give the player the first ending
                Console.WriteLine("You nod to the woman and head back from where you came from, escaping the fate that you were about to succumb to.\n");
                Console.WriteLine("Thanks For Playing!\n");
                Console.WriteLine("Ending 1/3 - \"With Hesitation\" Unlocked!\n");
                Console.WriteLine("Play again to gain all endings!\n");
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

