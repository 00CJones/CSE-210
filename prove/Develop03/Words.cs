using System;
class Word
{
    private string Text;
    public bool IsHidden { get; private set; }  // This means that IsHidden is public to get but private to set

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public override string ToString()
    {
        return IsHidden ? new string('_', Text.Length) : Text;  // A shortcut way to evaluate the boolean value associated with IsHidden rather than writing an if-else statement
    }
}
