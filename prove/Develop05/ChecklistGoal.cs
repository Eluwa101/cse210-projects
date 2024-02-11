// the checklist goal class: a sub class of goal class

class ChecklistGoal : Goal
{
    private int requiredCount;
    private int currentCount;

// checklist goal constructor with parameters
    public ChecklistGoal(string name, int value, int requiredCount, bool completed = false) : base(name, value)
    {
        this.requiredCount = requiredCount;
        this.currentCount = completed ? requiredCount : 0;
        this.completed = completed;
    }

// the override class of record event
    public override void RecordEvent()
    {
        currentCount++;
        completed = (currentCount == requiredCount);
    }

// the override class of display status of goals
    public override void DisplayStatus()
    {
        Console.WriteLine($"{(completed ? $"[X] Completed {currentCount}/{requiredCount}" : $"[ ] {currentCount}/{requiredCount}")} {name}");
    }
}