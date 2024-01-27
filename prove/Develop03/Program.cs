//The Scripture Memorizer Program 
// Acknowledgements:
// https://learn.microsoft.com/en-us/shows/csharp-101/?wt.mc_id=educationalcsharp-c9-scottha
// Microsoft Tutorials, Internet Resources
// W3schools C# tutorials
// Chegg
// Stake study groups.

using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine();
        Console.WriteLine("____Welcome to the Scripture Memorization program____");
        Console.WriteLine();

        // the user menu option
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Use hardcoded scripture");
        Console.WriteLine("2. Load scripture from a file");
        Console.WriteLine("Enter the option number: ");
        Console.Write(">>> ");

        string option = Console.ReadLine();

        if (option == "1")
        {
            //here calling the hardcoded scripture
            HardcodedScripture();
        }
        else if (option == "2")
        {
            // the method to load from file
            LoadScriptureFile();
        }
        else
        {
            Console.WriteLine("Invalid option. Exiting program.");
        }
    }

    private static void HardcodedScripture()
    {
        // Create a sample hardcoded scripture
        var scripture = new Scripture("John 3:16", "For God so loved the world, that he gave his only begotten Son \n that whosoever believeth in him should not perish but have everlasting life");

        // Create a console-based scripture hider
        var scriptureHider = new ScriptureHider(scripture);

        //calling
        scriptureHider.StartHiding();
    }

    private static void LoadScriptureFile()
    {
        Console.Write("Enter the file name (with extension) or the full path to the scripture file: ");
        string fileNameOrPath = Console.ReadLine();

        // to check if the user entered a full path or just a file name
        string filePath = Path.IsPathRooted(fileNameOrPath)
            ? fileNameOrPath
            : Path.Combine(Directory.GetCurrentDirectory(), fileNameOrPath);

        try
        {
            var scripture = ScriptureLoader.LoadScriptureFile(filePath);

            if (scripture != null)
            {
                // Create a console-based scripture hider
                var scriptureHider = new ScriptureHider(scripture);

                // Start the hiding process
                scriptureHider.StartHiding();
            }
            else
            {
                Console.WriteLine("Failed to load scripture from the file. Exiting program.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}. Exiting program.");
        }
    }
}
