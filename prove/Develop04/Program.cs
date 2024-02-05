// Main program.cs, the main program file of the Activity program
// 

using System;

class Program
{
    static void Main()
    {
        // initiate a while loop to run, until user choose exit
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Stretching Activity");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1-5): ");
            string choice = Console.ReadLine();

// switch choices
            switch (choice)
            {
                case "1":
                    Console.Write("Enter duration in seconds: ");
                    int breathingDuration = int.Parse(Console.ReadLine());
                    new BreathingActivity().StartBreathingActivity(breathingDuration);
                    break;
                case "2":
                    Console.Write("Enter duration in seconds: ");
                    int reflectionDuration = int.Parse(Console.ReadLine());
                    new ReflectionActivity().StartReflectionActivity(reflectionDuration);
                    break;
                case "3":
                    Console.Write("Enter duration in seconds: ");
                    int listingDuration = int.Parse(Console.ReadLine());
                    new ListingActivity().StartListingActivity(listingDuration);
                    break;
                case "4":
                    Console.Write("Enter duration in seconds: ");
                    int stretchingDuration = int.Parse(Console.ReadLine());
                    new StretchingActivity().StartStretchingActivity(stretchingDuration);
                    break;
                case "5":
                    Console.WriteLine("Exiting program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}