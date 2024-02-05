using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment week4 = new Assignment("kate Mandy", "Indices");
        Console.WriteLine(week4.GetSummary());

        MathAssignment indices = new MathAssignment("Coco Charles", "Algebra", "1.1", "9-17");
        Console.WriteLine(indices.GetSummary());
        Console.WriteLine(indices.GetHomeworkList());

        WritingAssignment essay = new WritingAssignment("Olu Smith", "Pan History", "The Golden Stool, our heritage");
        Console.WriteLine(essay.GetSummary());
        Console.WriteLine(essay.GetWritingInformation());
    }
}