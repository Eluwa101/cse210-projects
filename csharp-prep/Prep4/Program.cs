using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numberList = new List<int>();

        int userNum;
        do
        {
            Console.Write("Enter number: ");
            string entry = Console.ReadLine();
            userNum = int.Parse(entry);

            if (userNum != 0)
            {
                numberList.Add(userNum);
            }

        } while (userNum != 0);

        int numbersSum = numberList.Sum();
        double numbersAverage = numberList.Average();
        int largestNumber = numberList.Max();

        Console.WriteLine($"The sum is {numbersSum}");
        Console.WriteLine($"The Average is {numbersAverage}");
        Console.WriteLine($"The largest number is {largestNumber}");


    }
}