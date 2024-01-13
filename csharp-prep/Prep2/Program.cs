using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        string letter = "";
        
        Console.Write("Write your grade number here: ");
        string gradeNum = Console.ReadLine();
        float gradeNumber = float.Parse(gradeNum);

        if (gradeNumber >= 90)
        {
                letter = "A";
        }

        else if (gradeNumber >= 80)
        {
            letter = "B";
        }

        else if (gradeNumber >= 70)
        {
            letter = "C";
        }

        else if (gradeNumber >= 60)
        {
            letter = "D";
        }

        else if (gradeNumber < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}");
        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class");
        }

        else
        {
            Console.WriteLine("Sorry, you did not pass the class, try again");
        }    
    }
}