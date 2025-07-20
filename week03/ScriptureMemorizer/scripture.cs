using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count)
    {
        List<Word> visibleWords = _words.FindAll(w => !w.IsHidden());

        int hideCount = Math.Min(count, visibleWords.Count);

        for (int i = 0; i < hideCount; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public void RevealOneWord()
    {
        List<Word> hiddenWords = _words.FindAll(w => w.IsHidden());

        if (hiddenWords.Count > 0)
        {
            int index = _random.Next(hiddenWords.Count);
            hiddenWords[index].Reveal();
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string text = string.Join(" ", _words.ConvertAll(w => w.GetDisplayText()));
        return $"{referenceText} {text}";
    }

    public bool AllWordsHidden()
    {
        return _words.TrueForAll(w => w.IsHidden());
    }
}
