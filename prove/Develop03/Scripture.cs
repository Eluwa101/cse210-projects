using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    public string Reference { get; }
    public string Text { get; }
    public List<Word> Words { get; }

    public Scripture(string reference, string text)
    {
        Reference = reference;
        Text = text;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }
}
