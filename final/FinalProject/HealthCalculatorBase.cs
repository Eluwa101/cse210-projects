// main health calculator class
public interface IHealthCalculator
{
    void Calculate();
}

public abstract class HealthCalculatorBase : IHealthCalculator
{
    private string Category { get; set; }

    protected void SetCategory(string category)
    {
        Category = category;
    }

    protected void DisplayResults(double result)
    {
        Console.WriteLine($"Your {Category} result is: {result:F2}");
    }

    protected void DisplayAdvice()
    {
        Console.WriteLine("Health Advice: Consider consulting with a health professional for personalized advice.");
    }

    public abstract void Calculate();
}