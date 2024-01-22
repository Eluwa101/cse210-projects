using System;

using System;

// In Program.cs
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

// initiate a while loop here to keep the program running until user says 'Exit'

        while (true)
        {
            
            // Here is the program menu options

            Console.WriteLine("1. Write a journal entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("< ");

            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    string randomPrompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {randomPrompt}");
                    Console.Write("Your response: ");
                    string userResponse = Console.ReadLine();
                    Entry newEntry = new Entry(userResponse, randomPrompt, DateTime.Now);
                    journal.AddEntry(newEntry);
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    Console.Write("Enter file name to save: ");
                    Console.WriteLine("Your file name should be a .txt or .csv file");
                    Console.Write("< ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    break;
                case 4:
                    Console.WriteLine("Enter file name to load: ");
                    Console.Write("< ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}