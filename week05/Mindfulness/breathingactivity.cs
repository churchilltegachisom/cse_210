using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", 
        "This activity will help you relax by guiding you through slow breathing.")
    {
    }

    protected override void PerformActivity()
    {
        int cycles = duration / 10;
        for (int i = 0; i < cycles; i++)
        {
            AnimatedText("Breathe in...", 5);
            AnimatedText("Now breathe out...", 5);
        }
    }

    private void AnimatedText(string text, int seconds)
    {
        Console.WriteLine();
        for (int i = 1; i <= seconds; i++)
        {
            Console.Write($"\r{text} {new string('.', i)} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
