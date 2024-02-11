// Acknowledgements:
// Microsoft learn, w3shcools
// programming with Mosh youtube videos, Tim corey youtube videos
// Scott Hanselman and Cherita videos
// Stake and Team study groups. 

// the main program.cs that initialize the program run
using System;
using System.Collections.Generic;
using System.IO;

class EternalQuestApp
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        while (true)
        {
            Console.Clear();
            DisplayMenu();

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice.ToLower())
            {
                case "1":
                    goalManager.CreateGoal();
                    break;
                case "2":
                    goalManager.RecordEvent();
                    break;
                case "3":
                    goalManager.DisplayUserProgress();
                    break;
                case "4":
                    goalManager.SaveAndLoadGoals();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
//  the method that displays the menu
    static void DisplayMenu()
    {
        Console.WriteLine("Eternal Quest Menu");
        Console.WriteLine("1. Create Goal");
        Console.WriteLine("2. Record Event");
        Console.WriteLine("3. Display User Progress");
        Console.WriteLine("4. Save and Load Goals");
        Console.WriteLine("5. Exit");
    }
}