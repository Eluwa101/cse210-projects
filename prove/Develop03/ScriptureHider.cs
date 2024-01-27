using System;

class ScriptureHider
{
    private readonly Scripture _scripture;

// The Hider Constructor
    public ScriptureHider(Scripture scripture)
    {
        _scripture = scripture;
    }

    public void StartHiding()
    {
        // this loop continues as long as at least one word is visible
        while (!_scripture.Words.All(word => word.IsHidden))
        {
            DisplayScripture();
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            var userInput = Console.ReadLine();

        // condition to break the loop if user types quit
            if (userInput?.ToLower() == "quit")
                break;

            HideRandomWord();
            Console.Clear();
        }
    }

    // this method is the display current state
    private void DisplayScripture()
    {
        Console.WriteLine();
        Console.WriteLine($"{_scripture.Reference}\n");

        foreach (var word in _scripture.Words)
        {
            Console.Write(word.IsHidden ? "___ " : $"{word.Text} ");
        }

        Console.WriteLine();
    }

    // The method is responsible for randomly hiding visible words
    private void HideRandomWord()
    {
        var random = new Random();
        var visibleWords = _scripture.Words.Where(word => !word.IsHidden).ToList();

        if (visibleWords.Any())
        {
            var wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.IsHidden = true;
        }
    }
}
