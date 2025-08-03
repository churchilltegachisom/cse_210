using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

public class ReflectionActivity : Activity
{
    private List<string> prompts = new()
    {
        "Think of a time you stood up for someone else.",
        "Think of a time you did something really difficult.",
        "Think of a moment you felt peace.",
        "Think of a time you helped someone in need."
    };

    private List<string> usedPrompts = new();

    public ReflectionActivity() : base("Reflection Activity",
        "This activity will help you reflect on times when you showed strength or resilience.")
    {
    }

    protected override void PerformActivity()
    {
        Random rand = new();
        int interval = 10;
        int totalTime = 0;

        while (totalTime < duration)
        {
            if (usedPrompts.Count == prompts.Count)
                usedPrompts.Clear(); // reset for session

            string prompt;
            do
            {
                prompt = prompts[rand.Next(prompts.Count)];
            } while (usedPrompts.Contains(prompt));

            usedPrompts.Add(prompt);

            Console.WriteLine($"\nPrompt: {prompt}");
            Console.Write("Think about it...");
            ShowSpinner(3);

            Console.WriteLine("\nReflect on this question:");
            Console.WriteLine(" - Why was this experience meaningful?");
            Pause(interval);
            totalTime += interval;
        }
    }
}
