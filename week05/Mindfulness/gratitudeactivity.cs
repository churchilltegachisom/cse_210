using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    private List<string> prompts = new()
    {
        "What is something you’re grateful for today?",
        "Who is someone you're thankful to have in your life?",
        "What memory makes you smile?",
        "Name a simple pleasure that brought you joy recently."
    };

    public GratitudeActivity() : base("Gratitude Activity",
        "This activity helps you cultivate gratitude and a positive mindset.")
    {
    }

    protected override void PerformActivity()
    {
        Random rand = new();
        int interval = duration / 2;

        for (int i = 0; i < duration; i += interval)
        {
            string prompt = prompts[rand.Next(prompts.Count)];
            Console.WriteLine($"\n{prompt}");
            Console.Write("Take a moment to reflect...");
            Pause(interval);
        }
    }
}
