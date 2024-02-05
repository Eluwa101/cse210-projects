// the reflection activity, sub class of Activity
class ReflectionActivity : Activity
{
    private readonly string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> userAnswers;

    public ReflectionActivity() : base("Reflection Activity", "Reflect on times of strength and resilience")
    {
        userAnswers = new List<string>();
    }

// method for starting reflection
    public void StartReflectionActivity(int duration)
    {
        StartActivity(duration);
        Reflect(duration);
        EndActivity(duration);
    }

// the reflect method for random prompts and timing
    public void Reflect(int duration)
    {
        var startTime = DateTime.Now;

        while (DateTime.Now - startTime < TimeSpan.FromSeconds(duration))
        {
            string prompt = prompts[new Random().Next(prompts.Length)];
            Console.WriteLine(prompt);
            Pause(3);

            if (!AskQuestions())
            {
                Console.WriteLine("Reflection Activity terminated by user.");
                return; 
            }

            DisplaySpinner();
        }

        DisplayUserAnswers(); 
    }

// the method for the questions
    public bool AskQuestions()
    {
        string[] questions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

// loop through the prompts for the user
        foreach (var question in questions)
        {
            Console.WriteLine(question);
            string userAnswer = Console.ReadLine();

            if (userAnswer.ToLower() == "done")
            {
                return false; 
            }

            userAnswers.Add(userAnswer); 
            Pause(3);
        }

        return true; 
    }

// reflection activity answers recap method
    public void DisplayUserAnswers()
    {
        Console.WriteLine("\nYour Reflection Activity Answers:");

        for (int i = 0; i < prompts.Length; i++)
        {
            Console.WriteLine($"{prompts[i]}\nAnswer: {userAnswers[i]}\n");
        }
    }
// the spinner method to countdown time for the user
    public void DisplaySpinner()
    {
        Console.Write("...");
        Pause(3);
    }
}
