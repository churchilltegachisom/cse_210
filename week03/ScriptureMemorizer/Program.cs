// EXCEEDING REQUIREMENTS:
// - Uses encapsulation: Four separate classes (Program, Scripture, Reference, Word).
// - Supports multiple scriptures in a list and selects one at random.
// - Only unhidden words are hidden, avoiding repeats.
// - Code is clean, modular, and follows OOP principles.
// - Easy to extend: you can load scriptures from a file or add a timer challenge.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of scriptures to choose from
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(
                new Reference("Joshua", 1, 9),
                "Have I not commanded you? Be strong and be of good courage " +
                "do not be afraid nor dismayed for the Lord your God is with you wherever you go."
            ),
            new Scripture(
                new Reference("Psalms", 91, 1, 2),
                "He that dwelleth in the secret place of the most High abideth under the shadowns of the almighty.. " +
                "I will say of the Lord, He is my refuge and my fortress, my God in whom I put my trust."
            )
        };

        // Pick a random scripture
        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        // Loop until all words are hidden or the user quits
        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
                break;

            scripture.HideRandomWords(3); // Hide 3 words at a time
        }

        // Final display when all words are hidden
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words hidden. Program ended.");
    }
}
