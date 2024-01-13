using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string user_first_name = Console.ReadLine();
        Console.Write("What is your last name? ");
        string user_last_name = Console.ReadLine();
        Console.WriteLine($"Your name is {user_last_name}, {user_first_name} {user_last_name}");
    }
    
}
