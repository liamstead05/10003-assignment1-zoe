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
                Console.WriteLine("\"You'll regret your decisions, kid.\" The elderly woman scoffed.");
                Console.WriteLine("You proceed to your adventure. You take in the beauty of nature, how the leaves of various colours create such a gorgeous scenery.");
                Console.WriteLine("You spot a large piece of stick on the side of the road. You stop to the side and pick it up, keeping hold of it.");
                Console.WriteLine("Your descent down the mountain was nothing short of a minor inconvenience, but that isn't what is going to stop you.");
                Console.WriteLine("Suddenly, you hear strange noises. Ones that sound rather frightening. You brush it off as nothing and proceed to step in something sticky.");
                Console.WriteLine("\"What did I step in?\" You ask yourself. You lift your foot to see that the bottom of it is covered in green goo.");
                Console.WriteLine("\"Ew.\" You mutter in disgust. You hear the noises again, and turn to see that a slime monster was sneaking up behind you, trying to turn you into its next meal.");
                Console.WriteLine("You grab your stick, preparing for a fight. Do you attack the creature or use an item?");

                // Get a response from the player
                playerInput = Console.ReadLine();

                // Compare the events of fighting the slime monster
                if (playerInput == "Attack")
                {
                    // Continue the game
                    Console.WriteLine("You choose to attack the creature.");
                    Console.WriteLine("Using the force that you've got and the stick that you found, you take a massive swing at the slime creature, hitting it in the process.");
                    Console.WriteLine("Somehow, it was enough to scare it away for good. You won the battle");
                    Console.WriteLine("You can't help but notice that you're in pain. You've taken such hits from the battle that you've received cuts and bruises.");
                    Console.WriteLine("\"I'm going to need a medic bag.\" You speak to yourself.");
                    Console.WriteLine("You continue on your journey, even though you are limping in pain.");
                    Console.WriteLine("As you walk deeper into the forest, you encounter a fork in the road.");
                    Console.WriteLine("\"Where do I go now?\" You question.");
                    Console.WriteLine("Do you take the left path or the right path?");

                    // Get a response from the player
                    playerInput = Console.ReadLine();

                    // Compare the events of choosing a path
                    if (playerInput == "Left")
                    {
                        // Continue the game
                        Console.WriteLine("You decide to go left. You walk on the path.");
                        Console.WriteLine("As you proceed, you notice that the trees are becoming more dead and lifeless, having no leaves on them.");
                        Console.WriteLine("Eventually, you spot a house in the distance. It looks abandoned, but it might have something useful in there.");
                        Console.WriteLine("Do you enter the house or continue onward?");

                        // Get a response from the player
                        playerInput = Console.ReadLine();

                        // Compare the events of entering the house
                        if (playerInput == "Enter")
                        {
                            // Continue the game
                            Console.WriteLine("You enter the house. It's dark and rundown. Your suspicions of it being abandoned were true.");
                            Console.WriteLine("In the room, there is a couch and a mirror. What do you check first?");

                            // Get a response from the player
                            playerInput = Console.ReadLine();

                            // Compare the events of checking the couch and checking the mirror
                            if (playerInput == "Couch")
                            {
                                // Continue the game - Endings 5-8
                                Console.WriteLine("You walk over to the couch. You lift up the coushins and discover that there's a key hiding underneath them.");
                                Console.WriteLine("You grab the key and put it in your pocket.");
                                Console.WriteLine("You walk over to the mirror. You stare at yourself in the reflection, taking note of all of the cuts and bruises that your body has held onto.");
                                Console.WriteLine("Suddenly, the colour of your fur changes to a darker colour, and emerges a creature like yourself.");
                                Console.WriteLine("\"Hello, Lexi.\" The creature speaks to you. The sight of the creature startles you a bit.");
                                Console.WriteLine("\"Who are you?\" You ask it. The creature steps out of the mirror and into the real world.");
                                Console.WriteLine("\"I'm the embodiement of your doubts, the voices in your head.\" The creature walks around you, with its tail following pursuit as if it's chasing the body of the creature.");
                                Console.WriteLine("\"That sounds a bit edgy, if I'm gonna be honest.\"");
                                Console.WriteLine("\"But it isn't, trust me.\" The creature stops and frowns before looking at you in the eyes. \"I'm demanding that you stop your journey and go back home. You're achieving nothing by doing this.\"");
                                Console.WriteLine("\"I'm doing this to get Dad back.\"");
                                Console.WriteLine("\"Your father is not coming back. He's long gone and you know it.\"");
                                Console.WriteLine("\"No he's not!\" You yell so loud to a point where the mirror shatters. The creature turns to the mirror before looking back at you.");
                                Console.WriteLine("Without saying a word, the creature walks back into the mirror before turning to face you, now with cuts on its body in the shape of the mirror cracks, then vanishing into thin air.");
                                Console.WriteLine("You head to the next room, which has a chest. However, you can leave if you please.");
                                Console.WriteLine("Do you check the chest or leave?");

                                // Get a response from the player
                                playerInput = Console.ReadLine();

                                // Compare the events of checking the chest and leaving
                                if (playerInput == "Chest")
                                {
                                    Console.WriteLine("You remembered that you found a key in the couch earlier.");
                                    Console.WriteLine("Using the key, you unlock the chest, and to your surprise, the contents that you found are very useful.");
                                    Console.WriteLine("You find at least 100 gold and a medic bag.");
                                    Console.WriteLine("You take everything from the chest and put it into your bag, except for the medic bag, which you use to heal yourself.");
                                    Console.WriteLine("After fifteen minutes of healing your wounds, you decide it's time to leave the house.");
                                    Console.WriteLine("You walk out of the house and back onto the path in the forest.");
                                    Console.WriteLine("As you continue, you can't help but fail to ignore all of the dead trees and nature around the area.");
                                    Console.WriteLine("\"It feels like someone came in and sucked all of the life away from the forest.\" You whisper under your breath.");
                                    Console.WriteLine("Suddenly, you hear rattling in one of the bushes, and out comes a skeleton.");
                                    Console.WriteLine("Do you attack the skeleton or use an item?");

                                    // Get a response from the player
                                    playerInput = Console.ReadLine();

                                    // Compare the events of fighting the slime monster
                                    if (playerInput == "Attack")
                                    {
                                        // Continue the game
                                        Console.WriteLine("You choose to attack the creature.");
                                        Console.WriteLine("Using the force that you've got and the stick that you found, you take a massive swing at the slime creature, hitting it in the process.");
                                        Console.WriteLine("Somehow, it was enough to scare it away for good. You won the battle");
                                        Console.WriteLine("You continue on your journey, and you come across a large river.");
                                        Console.WriteLine("\"How can I get across this river?\" You ask yourself.");
                                        Console.WriteLine("You spot a log nearby, but you remember that you could try and jump over the river on your own.");
                                        Console.WriteLine("Do you jump over the river or use the log to cross the river?");

                                        // Get a response from the player
                                        playerInput = Console.ReadLine();

                                        // Compare the events of crossing the river
                                        if (playerInput == "Jump")
                                        {
                                            // End the game and give the player the fifth ending
                                            Console.WriteLine("You use all of the energy you have within you to jump over the river.");
                                            Console.WriteLine("Unfortunately, you don't make it and proceed to fall into the river.");
                                            Console.WriteLine("Your body submerges into the body of water and you try to swim up to the top, but the currents keep pushing you back.");
                                            Console.WriteLine("The river becomes too much for you that you end up drowning, bringing your journey to an abrupt end.");
                                            Console.WriteLine("Thanks For Playing!");
                                            Console.WriteLine("Ending 5/8 - \"Leap of Fate\" Unlocked!");
                                            Console.WriteLine("Play again to gain all endings!");
                                        }
                                        else if (playerInput == "Log")
                                        {
                                            // Continue the game
                                            Console.WriteLine("You head over to the log that's nearby and begin to roll the log over to the river.");
                                            Console.WriteLine("Eventually, you successfully roll it over the river, creating a makeshift bridge.");
                                            Console.WriteLine("You carefully walk over the log from one side of the river to the other.");
                                            Console.WriteLine("After crossing the river, you make your way into the forest.");
                                            Console.WriteLine("You spot a figure in the distance. It's hard to tell who that figure may be, but you know it's someone.");
                                            Console.WriteLine("You approach them, and you learn that they are a hiker.");
                                            Console.WriteLine("\"Howdy there, traveller!\" The hiker greets you. \"Are you journeying to the other side of the forest?\"");
                                            Console.WriteLine("\"Yes, I am.\" You reply to them. \"Do you know where to go?\"");
                                            Console.WriteLine("\"Yes, I do, you'll have to take the path on the right, as the one on the left is not what you'll want to go down. It contains a lot of dangerous traps.\"");
                                            Console.WriteLine("\"Oh, alright. Thank you for letting me know.\"");
                                            Console.WriteLine("As you begin to walk forward, the hiker taps you on the shoulder. You turn to face them.");
                                            Console.WriteLine("\"By the way, would you like to buy an item from my shop? I've got a couple of things that vary in price.\"");
                                            Console.WriteLine("You nod your head. The hiker lays down a couple of items.");
                                            Console.WriteLine("There is a potion that costs 50 gold, a sword that costs 75 gold, and a diamond that costs 100 gold. What do you buy?");

                                            // Get a response from the player
                                            playerInput = Console.ReadLine();

                                            // Compare the events of purchasing an item
                                            if (playerInput == "Potion")
                                            {
                                                // Continue the game - Ending 6, 7
                                                Console.WriteLine("You purchase the potion.");
                                                Console.WriteLine("\"Do you know what this potion do?\" You ask the hiker.");
                                                Console.WriteLine("\"I don't know to be honest. The person who gave it to me didn't say anything.\" The hiker responds. \"Anyways, take care!\"");
                                                Console.WriteLine("The hiker disappears into thin air. You can't help but feel like you've been scammed.");
                                                Console.WriteLine("You continue on your journey, taking the right path. Suddenly, you stumble upon a portal. Do you enter it or continue onward?");

                                                // Get a response from the player
                                                playerInput = Console.ReadLine();

                                                // Compare the events of entering the portal
                                                if (playerInput == "Enter")
                                                {
                                                    // Continue the game - Ending 7
                                                    Console.WriteLine("You enter the portal, and you end up in a warped environment.");
                                                    Console.WriteLine("\"What the hell is this?\" You ask yourself with confusion.");
                                                    Console.WriteLine("\"Welcome back, Lexi.\" The creature appears in front of you. \"I see that you found my trap.\"");
                                                    Console.WriteLine("\"What do you want from me?\" You bark at the creature.");
                                                    Console.WriteLine("\"I want you to parish, so then I can be set free. Prepare to die!\"");
                                                    Console.WriteLine("A fight ensues. Do you attack or use the potion?");

                                                    // Get a response from the player
                                                    playerInput = Console.ReadLine();

                                                    // Compare the events of attacking and using the potion
                                                    if (playerInput == "Attack")
                                                    {
                                                        // End the game and give the player the seventh ending
                                                        Console.WriteLine("You try to attack, but you don't have anything on you.");
                                                        Console.WriteLine("\"Pathetic!\" The creature mocks. Suddenly, your body begins to grow glowing cracks.");
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            // Let the player know that what they typed is invalid
                                            Console.WriteLine($"Your response \"{playerInput}\" is not valid.");
                                        }
                                    }
                            }
                            else if (playerInput == "Mirror")
                            {
                                // Continue the game - Ending 4
                                Console.WriteLine("You walk over to the mirror. You stare at yourself in the reflection, taking note of all of the cuts and bruises that your body has held onto.");
                                Console.WriteLine("Suddenly, the colour of your fur changes to a darker colour, and emerges a creature like yourself.");
                                Console.WriteLine("\"Hello, Lexi.\" The creature speaks to you. The sight of the creature startles you a bit.");
                                Console.WriteLine("\"Who are you?\" You ask it. The creature steps out of the mirror and into the real world.");
                                Console.WriteLine("\"I'm the embodiement of your doubts, the voices in your head.\" The creature walks around you, with its tail following pursuit as if it's chasing the body of the creature.");
                                Console.WriteLine("\"That sounds a bit edgy, if I'm gonna be honest.\"");
                                Console.WriteLine("\"But it isn't, trust me.\" The creature stops and frowns before looking at you in the eyes. \"I'm demanding that you stop your journey and go back home. You're achieving nothing by doing this.\"");
                                Console.WriteLine("\"I'm doing this to get Dad back.\"");
                                Console.WriteLine("\"Your father is not coming back. He's long gone and you know it.\"");
                                Console.WriteLine("\"No he's not!\" You yell so loud to a point where the mirror shatters. The creature turns to the mirror before looking back at you.");
                                Console.WriteLine("Without saying a word, the creature walks back into the mirror before turning to face you, now with cuts on its body in the shape of the mirror cracks, then vanishing into thin air.");
                                Console.WriteLine("You head to the next room, which has a chest. However, you can leave if you please.");
                                Console.WriteLine("Do you check the chest or leave?");

                                // Get a response from the player
                                playerInput = Console.ReadLine();

                                // Compare the events of checking the chest and leaving
                                if (playerInput == "Chest")
                                {
                                    // End the game and give the player the fourth ending
                                    Console.WriteLine("You try to open the chest, but it's locked.");
                                    Console.WriteLine("Thinking about moving on, you decide to leave the house continue onwards, thinking that it was the best option.");
                                    Console.WriteLine("As you continue, you start to feel dizzy, with your vision getting blurry.");
                                    Console.WriteLine("Suddenly, you drop to the floor in exhaustion, thinking that you have been tired.");
                                    Console.WriteLine("You close your eyes and lay on the ground. You don't realize it, but you have passed away from your wounds. Your journey ends here.");
                                    Console.WriteLine("Thanks For Playing!");
                                    Console.WriteLine("Ending 4/8 - \"Shattered Wounds\" Unlocked!");
                                    Console.WriteLine("Play again to gain all endings!");
                                }
                                else if (playerInput == "Leave")
                                {
                                    // End the game and give the player the fourth ending
                                    Console.WriteLine("Thinking about moving on, you decide to leave the house continue onwards, thinking that it was the best option.");
                                    Console.WriteLine("As you continue, you start to feel dizzy, with your vision getting blurry.");
                                    Console.WriteLine("Suddenly, you drop to the floor in exhaustion, thinking that you have been tired.");
                                    Console.WriteLine("You close your eyes and lay on the ground. You don't realize it, but you have passed away from your wounds. Your journey ends here.");
                                    Console.WriteLine("Thanks For Playing!");
                                    Console.WriteLine("Ending 4/8 - \"Shattered Wounds\" Unlocked!");
                                    Console.WriteLine("Play again to gain all endings!");
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
                        else if (playerInput == "Continue")
                        {
                            // End the game and give the player the fourth ending
                            Console.WriteLine("You ignore the house and continue onwards, thinking that it was the safest option.");
                            Console.WriteLine("As you continue, you start to feel dizzy, with your vision getting blurry.");
                            Console.WriteLine("Suddenly, you drop to the floor in exhaustion, thinking that you have been tired.");
                            Console.WriteLine("You close your eyes and lay on the ground. You don't realize it, but you have passed away from your wounds. Your journey ends here.");
                            Console.WriteLine("Thanks For Playing!");
                            Console.WriteLine("Ending 4/8 - \"Shattered Wounds\" Unlocked!");
                            Console.WriteLine("Play again to gain all endings!");
                        }
                        else
                        {
                            // Let the player know that what they typed is invalid
                            Console.WriteLine($"Your response \"{playerInput}\" is not valid.");
                        }

                    }
                    else if (playerInput == "Right")
                    {
                        // End the game and give the player the third ending
                        Console.WriteLine("You decide to go right. You walk on the path.");
                        Console.WriteLine("You travel down the dirt road. You don't seem to realize that you're lost, because you're oblivious to the fact.");
                        Console.WriteLine("Eventually, you end up hitting a dead end, but it's too late, for you've died from your wounds, ending your journey so soon.");
                        Console.WriteLine("Thanks For Playing!");
                        Console.WriteLine("Ending 3/8 - \"Forever Lost\" Unlocked!");
                        Console.WriteLine("Play again to gain all endings!");
                    }
                    else
                    {
                        // Let the player know that what they typed is invalid
                        Console.WriteLine($"Your response \"{playerInput}\" is not valid.");
                    }
                }
                else if (playerInput == "Item")
                {
                    // End the game and give the player the second ending
                    Console.WriteLine("You look in your bag to see if there's anything you can use.");
                    Console.WriteLine("There's nothing you can use against the slime creature.");
                    Console.WriteLine("The slime creature takes a swing at you, ending you in the process.");
                    Console.WriteLine("You have unfortunately died, and your journey ends here.");
                    Console.WriteLine("Thanks For Playing!");
                    Console.WriteLine("Ending 2/8 - \"Simply Weak\" Unlocked!");
                    Console.WriteLine("Play again to gain all endings!");
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
                Console.WriteLine("You listen to the woman. \"Alright then, I'll head back. Thank you for warning me.\"");
                Console.WriteLine("\"I'm just doing what I can do protect the youth\" The woman responds.");
                Console.WriteLine("You head back on the path that you went entering the forest, and return to your house.");
                Console.WriteLine("Thanks For Playing!");
                Console.WriteLine("Ending 1/8 - \"With Hesitation\" Unlocked!");
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

