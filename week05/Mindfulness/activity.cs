using System;
using System.Threading;

public abstract class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {name}.\n");
        Console.WriteLine(description);
        Console.Write("\nEnter duration in seconds: ");
        duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        PerformActivity();

        Console.WriteLine("\nWell done!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed the {name} for {duration} seconds.");
    }

    public int GetDuration() => duration;

    protected abstract void PerformActivity();

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|"); Thread.Sleep(250); Console.Write("\b");
            Console.Write("/"); Thread.Sleep(250); Console.Write("\b");
            Console.Write("-"); Thread.Sleep(250); Console.Write("\b");
            Console.Write("\\"); Thread.Sleep(250); Console.Write("\b");
        }
        Console.WriteLine();
    }

    protected void Pause(int seconds)
    {
        Thread.Sleep(seconds * 1000);
    }
}
