// class for body fat percentage
public class BodyFatPercentageCalculator : HealthCalculatorBase
{
    private int Age { get; set; }
    private char Gender { get; set; }
    private double Bmi { get; set; }
    private double BodyFatPercentage { get; set; }

    public BodyFatPercentageCalculator(int age, char gender, double bmi)
    {
        SetCategory("Body Fat Percentage");
        Age = age;
        Gender = gender;
        Bmi = bmi;
    }

    public override void Calculate()
    {
        double bodyFatPercentage;

        if (Gender == 'M')
        {
            // this calculation is for a man
            bodyFatPercentage = 1.20 * Bmi + 0.23 * Age - 10.8 - 5.4;
        }
        else if (Gender == 'F')
        {
            // and this is for a woman
            bodyFatPercentage = 1.20 * Bmi + 0.23 * Age - 5.4;
        }
        else
        {
            Console.WriteLine("Invalid gender input.");
            return;
        }

        BodyFatPercentage = bodyFatPercentage; // Save the result for later use
        DisplayResults(bodyFatPercentage);
        DisplayAdvice(bodyFatPercentage);
    }

    public double GetBodyFatPercentage()
    {
        return BodyFatPercentage;
    }

    protected virtual void DisplayAdvice(double bodyFatPercentage)
    {
        // Specific advice for Body Fat Percentage Calculator result
        Console.WriteLine("Health Advice for Body Fat Percentage:");

        if (bodyFatPercentage < 18.5)
        {
            Console.WriteLine("Low Body Fat: Ensure you are maintaining a healthy balance between body fat and muscle mass.");
        }
        else if (bodyFatPercentage >= 18.5 && bodyFatPercentage < 24.9)
        {
            Console.WriteLine("Healthy Body Fat: Keep up with a balanced diet and regular exercise to maintain your current level.");
        }
        else if (bodyFatPercentage >= 25 && bodyFatPercentage < 29.9)
        {
            Console.WriteLine("Overweight: Consider adjusting your diet and exercise to reach a healthy body fat percentage.");
        }
        else
        {
            Console.WriteLine("Obese: Consult with a health professional for personalized advice on weight management.");
        }
    }
}
