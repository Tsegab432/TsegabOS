using System;

public class game1
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the Epic Adventure Game!");
        Console.WriteLine("You find yourself in the mysterious Darkwood Forest. Choose your path wisely:");

        while (true)
        {
            Console.WriteLine("1. Venture into the Enchanted Grove");
            Console.WriteLine("2. Navigate the Treacherous Swamp");
            Console.WriteLine("3. Ascend the Whispering Peaks");
            Console.WriteLine("4. Explore the Hidden Caverns");
            Console.WriteLine("5. Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("You enter the Enchanted Grove, filled with ancient trees and magical creatures.");
                    Console.WriteLine("A. Speak with the mystical Dryad");
                    Console.WriteLine("B. Investigate the glowing mushrooms");

                    string groveAction = Console.ReadLine();

                    if (groveAction.ToUpper() == "A")
                    {
                        Console.WriteLine("The Dryad shares ancient wisdom and grants you the ability to understand the language of nature.");
                        Console.WriteLine("Empowered, you continue your journey.");
                    }
                    else
                    {
                        Console.WriteLine("As you approach the mushrooms, they release a dazzling light, revealing a hidden path.");
                        Console.WriteLine("You follow the path and discover a forgotten temple.");
                    }
                    break;

                case "2":
                    Console.WriteLine("You brave the Treacherous Swamp, a maze of murky waters and twisting vines.");
                    Console.WriteLine("A. Build a makeshift raft");
                    Console.WriteLine("B. Attempt to jump between the floating logs");

                    string swampDecision = Console.ReadLine();

                    if (swampDecision.ToUpper() == "A")
                    {
                        Console.WriteLine("Crafting a raft, you navigate the swamp more safely and reach a small island.");
                        Console.WriteLine("On the island, you find a mysterious artifact.");
                    }
                    else
                    {
                        Console.WriteLine("Trying to jump between logs proves challenging. You slip and fall into the swamp.");
                        Console.WriteLine("After a struggle, you manage to escape, but your clothes are soaked.");
                    }
                    break;

                case "3":
                    Console.WriteLine("You climb the towering Whispering Peaks, shrouded in mist and legends.");
                    Console.WriteLine("A. Meditate at the summit");
                    Console.WriteLine("B. Investigate the ancient cave entrance");

                    string peaksChoice = Console.ReadLine();

                    if (peaksChoice.ToUpper() == "A")
                    {
                        Console.WriteLine("Meditating at the summit, you gain insights into the secrets of the mystical energy.");
                        Console.WriteLine("You feel invigorated and ready for the challenges ahead.");
                    }
                    else
                    {
                        Console.WriteLine("Entering the cave, you discover a hidden chamber with a guardian spirit.");
                        Console.WriteLine("After a respectful conversation, the spirit grants you a magical blessing.");
                    }
                    break;

                case "4":
                    Console.WriteLine("You explore the Hidden Caverns, where echoes of ancient history resonate.");
                    Console.WriteLine("A. Decode the ancient runes on the cavern walls");
                    Console.WriteLine("B. Follow the faint glow deeper into the cavern");

                    string cavernAction = Console.ReadLine();

                    if (cavernAction.ToUpper() == "A")
                    {
                        Console.WriteLine("Decoding the runes reveals a forgotten prophecy about a hero destined to save the realm.");
                        Console.WriteLine("You realize your role in this epic journey.");
                    }
                    else
                    {
                        Console.WriteLine("Following the glow, you discover an underground city of friendly dwarves.");
                        Console.WriteLine("They offer you enchanted armor to aid you on your quest.");
                    }
                    break;

                case "5":
                    Console.WriteLine("Thanks for playing the Epic Adventure Game. Goodbye!");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }
}
