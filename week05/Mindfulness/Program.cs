// Mindfulness Program
// CSE 210 Final Project - Mindfulness Activities
// Author: Churchill Tega Chisom
// Date: 3rd August, 2025
// 
// EXTRA FEATURES ADDED:
// - Added a custom activity: GratitudeActivity
// - Tracks how many times each activity is used and total duration
// - Writes to a log file (mindfulness_log.txt) with timestamps
// - Ensures no repeated prompts per session
// - Adds breathing animation with progressive dots
// - Displays session summary at the end

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static Dictionary<string, int> activityCount = new();
    static Dictionary<string, int> activityDuration = new();

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("=====================");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Start Gratitude Activity");
            Console.WriteLine("5. View Session Summary");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option (1-6): ");
            string input = Console.ReadLine();

            Activity activity = null;

            switch (input)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    activity = new GratitudeActivity();
                    break;
                case "5":
                    ShowSessionSummary();
                    continue;
                case "6":
                    running = false;
                    Console.WriteLine("Thanks for using the Mindfulness Program. Stay peaceful!");
                    return;
                default:
                    Console.WriteLine("Invalid input. Try again.");
                    Thread.Sleep(1500);
                    continue;
            }

            activity.Run();
            LogActivity(activity);
        }
    }

    static void LogActivity(Activity activity)
    {
        string activityName = activity.GetType().Name;
        int duration = activity.GetDuration();

        if (!activityCount.ContainsKey(activityName))
        {
            activityCount[activityName] = 0;
            activityDuration[activityName] = 0;
        }

        activityCount[activityName]++;
        activityDuration[activityName] += duration;

        string logLine = $"[{DateTime.Now}] {activityName} for {duration} seconds";
        File.AppendAllText("mindfulness_log.txt", logLine + Environment.NewLine);
    }

    static void ShowSessionSummary()
    {
        Console.Clear();
        Console.WriteLine("Session Summary");
        Console.WriteLine("================");

        if (activityCount.Count == 0)
        {
            Console.WriteLine("No activities have been performed this session.");
        }
        else
        {
            foreach (var name in activityCount.Keys)
            {
                Console.WriteLine($"{name}: Performed {activityCount[name]} time(s), Total Duration: {activityDuration[name]} seconds");
            }
        }

        Console.WriteLine("\nPress Enter to return to the menu.");
        Console.ReadLine();
    }
}
