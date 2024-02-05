// breathing activity, sub class of Activity
class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "Relax by focusing on your breathing") { }

     public void StartBreathingActivity(int duration)
    {
        StartActivity(duration);
        Breathe(duration);
        EndActivity(duration);
    }

// method defining breath timing activity
    public void Breathe(int duration)
    {
        for (int i = 0; i < duration; i++)
        {
            DisplayAndPause("Breathe in...");
            DisplayAndPause("Breathe out...");
        }
    }


    public void DisplayAndPause(string message)
    {
        Console.WriteLine(message);
        Pause(5);
    }
}