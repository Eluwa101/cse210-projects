// goal class and goal methods
abstract class Goal
{
    protected string name;
    protected int value;
    protected bool completed;

    public Goal(string name, int value)
    {
        this.name = name;
        this.value = value;
        this.completed = false;
    }

    public abstract void RecordEvent();

    public virtual void DisplayStatus()
    {
        Console.WriteLine($"{(completed ? "[X]" : "[ ]")} {name}");
    }

    public string GetName()
    {
        return name;
    }

    public bool IsCompleted()
    {
        return completed;
    }

    public int GetValue()
    {
        return value;
    }

    public static Goal CreateGoalInstance(string name, string goalType, int value, bool completed = false)
    {
    switch (goalType)
    {
        case "1":
            return new SimpleGoal(name, value, completed);
        case "2":
            return new EternalGoal(name, value, completed);
        case "3":
            Console.Write("Enter the required count for Checklist Goal: ");
            int requiredCount = int.Parse(Console.ReadLine());
            return new ChecklistGoal(name, value, requiredCount, completed);
        default:
            throw new ArgumentException("Invalid goal type.");
    }
    }

}