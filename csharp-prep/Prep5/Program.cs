using System;
using System.Globalization;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();

        string userName = PromptUserName();
        
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(squaredNumber, userName);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program.");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number");
        string favNumber = Console.ReadLine();
        int number = int.Parse(favNumber);
        return number;
    }

    static int SquareNumber(int number)
    {
        int numberSquared = number * number;
        return numberSquared;
    }

    static void DisplayResult(int number, string name)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }         
}