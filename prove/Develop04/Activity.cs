using System;
using System.Threading;

// The Activity class is the base or super class
class Activity
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }
// display method for starting current user activity
    public void StartActivity(int duration)
    {
        Console.WriteLine($"\n{Name} - {Description}");
        Console.WriteLine($"Set duration: {duration} seconds");
        Console.WriteLine("Prepare to begin...\n");
        Pause(3);
    }

// display method for ending the current user chosen ativity
    public void EndActivity(int duration)
    {
        Console.WriteLine("\nGreat job!");
        Console.WriteLine($"You have completed {Name} for {duration} seconds.");
        Pause(3);
    }

// The pause method to be called with a parameter of num of seconds
    public void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Thread.Sleep(1000);
            Console.Write(".");
            Console.Out.Flush();
        }
        Console.WriteLine("\n");
    }
}