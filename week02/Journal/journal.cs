using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void Display()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No journal entries to display.");
        }
        else
        {
            foreach (Entry entry in entries)
            {
                Console.WriteLine(entry.GetFormattedEntry());
            }
        }
    }

    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in entries)
                {
                    writer.WriteLine(entry.ToFileString());
                }
            }
            Console.WriteLine("Journal saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        try
        {
            entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                try
                {
                    entries.Add(Entry.FromFileString(line));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Skipped invalid entry in file.");
                }
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }
}
