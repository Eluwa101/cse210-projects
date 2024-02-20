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
        DisplayAdvice(bodyWaterPercentage);
    }

    protected virtual void DisplayAdvice(double bodyWaterPercentage)
    {
        Console.WriteLine("Health Advice for Body Water Percentage:");

        if (bodyWaterPercentage < 50)
        {
            Console.WriteLine("Dehydration Risk: Ensure you are staying adequately hydrated by drinking enough water.");
        }
        else if (bodyWaterPercentage >= 50 && bodyWaterPercentage < 60)
        {
            Console.WriteLine("Normal Body Water Percentage: Maintain your current hydration level by drinking water regularly.");
        }
        else
        {
            Console.WriteLine("Hydration Level Above Normal: Ensure you are not overhydrating; consult with a health professional if needed.");
        }
    }
}
