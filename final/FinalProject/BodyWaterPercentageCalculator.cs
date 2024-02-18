// class for body water percentage
public class BodyWaterPercentageCalculator : HealthCalculatorBase
{
    private double Weight { get; set; }
    private char Gender { get; set; }
    private double BodyFatPercentage { get; set; }

    public BodyWaterPercentageCalculator(double weight, char gender, double bodyFatPercentage)
    {
        SetCategory("Body Water Percentage");
        Weight = weight;
        Gender = gender;
        BodyFatPercentage = bodyFatPercentage;
    }

    public override void Calculate()
    {
        double bodyWaterPercentage;

        if (Gender == 'M')
        {
            // this calculation is for men
            bodyWaterPercentage = Weight * (1 - BodyFatPercentage / 100) * 0.7;
        }
        else if (Gender == 'F')
        {
            // and this is for women
            bodyWaterPercentage = Weight * (1 - BodyFatPercentage / 100) * 0.6;
        }
        else
        {
            Console.WriteLine("Invalid gender input.");
            return;
        }

        DisplayResults(bodyWaterPercentage);
        DisplayAdvice();

    }
}