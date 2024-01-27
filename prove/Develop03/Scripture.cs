using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    public string Reference { get; }
    public string Text { get; }
    public List<Word> Words { get; }

// the scripture constructor
    public Scripture(string reference, string text)
    {
        // this is representing scripture reference
        Reference = reference;
        // the represents the scripture text
        Text = text;
        // this represents the scripture words
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }
}
