// Stretching Activity, sub class of Activity

class StretchingActivity : Activity
{
    public StretchingActivity() : base("Stretching Activity", "Engage in basic body stretches for the specified number of times") { }

    public void StartStretchingActivity(int duration)
    {
        StartActivity(duration);
        Stretch(duration);
        EndActivity(duration);
    }

// Activity timig display
    public void Stretch(int duration)
    {
        Console.WriteLine("Follow the prompts and perform basic body stretches:");
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            DisplayAndPause("Reach for the sky");
            if (CheckForEndInput()) return;

            DisplayAndPause("Touch your toes");
            if (CheckForEndInput()) return;

            DisplayAndPause("Rotate your shoulders");
            if (CheckForEndInput()) return;

            DisplayAndPause("Neck stretches");
            if (CheckForEndInput()) return;
        }
    }
// validate and check for user input
    private bool CheckForEndInput()
    {
        Console.Write("Press Enter to Continue. Type 'end' to finish the Stretching Activity: ");
        string userInput = Console.ReadLine().ToLower();

        return userInput == "end";
    }

// display timing 
    public void DisplayAndPause(string message)
    {
        Console.WriteLine(message);
        Pause(7);
    }
}
