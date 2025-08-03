using System;
using System.Collections.Generic;
using System.Linq;

public class ListingActivity : Activity
{
    private List<string> prompts = new()
    {
        "List as many things as you can that you're grateful for.",
        "List as many personal strengths you can think of.",
        "List people who have influenced your life positively."
    };

    private List<string> usedPrompts = new();

    public ListingActivity() : base("Listing Activity",
        "This activity will help you focus on the good things in your life.")
    {
    }

    protected override void PerformActivity()
    {
        Random rand = new();

        if (usedPrompts.Count == prompts.Count)
            usedPrompts.Clear();

        string prompt;
        do
        {
            prompt = prompts[rand.Next(prompts.Count)];
        } while (usedPrompts.Contains(prompt));

        usedPrompts.Add(prompt);

        Console.WriteLine($"\nPrompt: {prompt}");
        Console.WriteLine("You may begin listing. Press Enter after each item:");
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        int count = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");
    }
}
