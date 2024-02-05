// listing Activity, sub class os Activity.

class ListingActivity : Activity
{
    private readonly string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "Reflect on the good things in your life by listing items") { }

    public void StartListingActivity(int duration)
    {
        StartActivity(duration);
        ListItems(duration);
        EndActivity(duration);
    }

// Listing Activity prompt waiting
    public void ListItems(int duration)
    {
        string prompt = prompts[new Random().Next(prompts.Length)];
        Console.WriteLine(prompt);
        Pause(5);
        Console.WriteLine("Start listing...\n");

        var items = new List<string>();
        var startTime = DateTime.Now;
        var endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            items.Add(item);
        }

        Console.WriteLine($"\nYou listed {items.Count} items:");
        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {items[i]}");
        }

        Pause(3);
    }

}