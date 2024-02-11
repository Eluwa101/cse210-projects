// The goal manager class for managing the goals recording

using System;
using System.Collections.Generic;
class GoalManager
{
    private GoalTracker goalTracker;

    public GoalManager()
    {
        goalTracker = new GoalTracker();
    }

// the create goal class, for creating the goals
    public void CreateGoal()
    {
        Console.WriteLine("Enter goal details:");
        Console.Write("Write your Goal Here: ");
        string goalName = Console.ReadLine();

        Console.Write("Goal Type (1. Simple, 2. Eternal, 3. Checklist): ");
        string goalType = Console.ReadLine();

        Console.Write("Goal point Value: ");
        int goalValue = int.Parse(Console.ReadLine());

        Console.Write("Is Goal Completed? (true/false): ");
        string userInput = Console.ReadLine();

        if (bool.TryParse(userInput, out bool goalCompleted))
        {

            Console.WriteLine($"Goal Completed: {goalCompleted}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter 'true' or 'false'.");
        }


        Goal goal = Goal.CreateGoalInstance(goalName, goalType, goalValue, goalCompleted);

        goalTracker.AddGoal(goal);

        Console.WriteLine($"Goal '{goalName}' created successfully!");
    }


    // the main class for recording the goal events updated
    public void RecordEvent()
    {
        Console.WriteLine("Select a goal to record event:");

        int index = 1;
        foreach (Goal goal in goalTracker.GetGoals())
        {
            Console.WriteLine($"{index}. {goal.GetName()}");
            index++;
        }

        Console.Write("Enter the goal number: ");
        int goalNumber = int.Parse(Console.ReadLine());

        if (goalNumber >= 1 && goalNumber <= goalTracker.GetGoals().Count)
        {
            Goal selectedGoal = goalTracker.GetGoals()[goalNumber - 1];
            goalTracker.RecordEvent(selectedGoal);
            Console.WriteLine($"Event recorded for goal '{selectedGoal.GetName()}'!");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }
    // the main method to display user's progress; scores and goals
    public void DisplayUserProgress()
    {
        Console.WriteLine("User Progress:");
        goalTracker.DisplayScore();
        goalTracker.DisplayGoals();

    }

// the save and load goals method,
    public void SaveAndLoadGoals()
    {
        Console.Write("Enter filename to save/load goals: ");
        string filename = Console.ReadLine();

        Console.Write("Choose an action (1. Save, 2. Load): ");
        int action = int.Parse(Console.ReadLine());

        switch (action)
        {
            case 1:
                goalTracker.SaveGoals(filename);
                break;
            case 2:
                goalTracker.LoadGoals(filename);
                break;
            default:
                Console.WriteLine("Invalid action.");
                break;
        }
    }
    
}
