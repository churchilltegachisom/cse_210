using System;

public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }
    public int Mood { get; set; }

    public Entry(string date, string prompt, string response, int mood)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
        Mood = mood;
    }

    public string GetFormattedEntry()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\nMood: {Mood}/5\n";
    }

    public string ToFileString()
    {
        return $"{Date}~|~{Prompt}~|~{Response}~|~{Mood}";
    }

    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split("~|~");
        if (parts.Length == 4)
        {
            return new Entry(parts[0], parts[1], parts[2], int.Parse(parts[3]));
        }
        else
        {
            throw new FormatException("Invalid journal entry format.");
        }
    }
}
