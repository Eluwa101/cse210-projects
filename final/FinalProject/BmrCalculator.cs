// BMR Calculator
public class BmrCalculator : HealthCalculatorBase
{
    private double Weight { get; set; }
    private double Height { get; set; }
    private int Age { get; set; }
    private char Gender { get; set; }
    private double CalculatedBmr { get; set; }

    public BmrCalculator(double weight, double height, int age, char gender)
    {
        SetCategory("BMR");
        Weight = weight;
        Height = height;
        Age = age;
        Gender = gender;
    }

    public override void Calculate()
    {
        if (Gender == 'M')
        {
            CalculatedBmr = 88.362 + (13.397 * Weight) + (4.799 * Height) - (5.677 * Age);
        }
        else if (Gender == 'F')
        {
            CalculatedBmr = 447.593 + (9.247 * Weight) + (3.098 * Height) - (4.330 * Age);
        }
        else
        {
            Console.WriteLine("Invalid gender input.");
            return;
        }

        DisplayResults(CalculatedBmr);
        DisplayAdvice();
    }

    protected override void DisplayAdvice()
    {
        // Specific advice for BMR Calculator result
        Console.WriteLine("Health Advice for BMR:");

        if (CalculatedBmr < 18.5)
        {
            Console.WriteLine("Underweight: Consider increasing your calorie intake to reach a healthy weight.");
        }
        else if (CalculatedBmr >= 18.5 && CalculatedBmr < 24.9)
        {
            Console.WriteLine("Normal Weight: Maintain a balanced diet to stay in the healthy weight range.");
        }
        else if (CalculatedBmr >= 25 && CalculatedBmr < 29.9)
        {
            Console.WriteLine("Overweight: Consider adjusting your diet and exercise to reach a healthy weight.");
        }
        else
        {
            Console.WriteLine("Obese: Consult with a health professional for personalized advice on weight management.");
        }
    }
}
