// the goal tracker class
class GoalTracker
{
    private List<Goal> questGoals;
    private ScoreManager scoreManager;

    public GoalTracker()
    {
        questGoals = new List<Goal>();
        scoreManager = new ScoreManager();
    }

// add goal class
    public void AddGoal(Goal goal)
    {
        questGoals.Add(goal);
    }

// adding event method
    public void RecordEvent(Goal goal)
    {
        goal.RecordEvent();
        scoreManager.AddToScore(goal.GetValue());
    }

// display score method for displaying current score
    public void DisplayScore()
    {
        Console.WriteLine($"Your current score: {scoreManager.GetScore()}");
    }

// display goal method
    public void DisplayGoals()
    {
        Console.WriteLine("Your goals:");
        foreach (Goal goal in questGoals)
        {
            goal.DisplayStatus();
        }
    }

    public List<Goal> GetGoals()
    {
        return questGoals;
    }
// save goals method for saving goals to txt
    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in questGoals)
            {
                writer.WriteLine($"{goal.GetType().Name}|{goal.GetName()}|{goal.GetValue()}|{goal.IsCompleted()}");
            }
        }
        Console.WriteLine($"Goals saved to {filename}");
    }
// load goals method for loading goals from directory
    public void LoadGoals(string filename)
    {
        try
        {
            questGoals.Clear();

            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 4)
                    {
                        string goalType = parts[0];
                        string goalName = parts[1];
                        int goalValue = int.Parse(parts[2]);
                        bool goalCompleted = bool.Parse(parts[3]);

                        Goal goal = Goal.CreateGoalInstance(goalName, goalType, goalValue, goalCompleted);
                        questGoals.Add(goal);
                    }
                }
            }
            Console.WriteLine($"Goals loaded from {filename}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }
}