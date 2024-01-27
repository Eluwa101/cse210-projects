class Word
{
    public string Text { get; }
    public bool IsHidden { get; set; }

// the constructor for Word
    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }
}
