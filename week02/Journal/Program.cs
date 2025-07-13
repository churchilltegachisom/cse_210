// Program.cs
// ============================================
// Extra Features Added to Exceed Requirements:
// - Mood rating (1–5) added to each journal entry
// - Entries are saved and loaded with mood included
// - Error handling for file loading and parsing
// - Custom delimiter (~|~) avoids format issues in saved data
// ============================================

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option (1-5): ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    int mood;
                    while (true)
                    {
                        Console.Write("Rate your mood today (1-5): ");
                        if (int.TryParse(Console.ReadLine(), out mood) && mood >= 1 && mood <= 5)
                            break;
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                    }

                    string date = DateTime.Now.ToShortDateString();
                    Entry entry = new Entry(date, prompt, response, mood);
                    journal.AddEntry(entry);
                    break;

                case "2":
                    journal.Display();
                    break;

                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "5":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose a number from 1 to 5.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
