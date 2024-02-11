// the simple goal class
class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value, bool completed = false) : base(name, value)
    {
        this.completed = completed;
    }

    public override void RecordEvent()
    {
        completed = true;
    }
}