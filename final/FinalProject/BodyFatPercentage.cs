// class for body fat percentage
public class BodyFatPercentageCalculator : HealthCalculatorBase
{
    private int Age { get; set; }
    private char Gender { get; set; }
    private double Bmi { get; set; }
    private double BodyFatPercentage {get; set; }

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

        DisplayResults(bodyFatPercentage);
        DisplayAdvice();
    }
        public double GetBodyFatPercentage()
    {
        return BodyFatPercentage;
    }
}