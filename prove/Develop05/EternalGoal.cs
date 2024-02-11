// the eternal goal class
class EternalGoal : Goal
{
    public EternalGoal(string name, int value, bool completed = false) : base(name, value)
    {
        this.completed = completed;
    }

    public override void RecordEvent()
    {
        
        completed = true;
    }
}