public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Hides the word (replaces it with underscores in display)
    public void Hide()
    {
        _isHidden = true;
    }

    // Reveals the word again (removes the underscores)
    public void Reveal()
    {
        _isHidden = false;
    }

    // Returns the display text: either original or hidden with underscores
    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }

    // Returns whether the word is hidden or not
    public bool IsHidden()
    {
        return _isHidden;
    }
}
