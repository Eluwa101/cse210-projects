// the Bmi class
public class BmiCalculator : HealthCalculatorBase
{
    private double Weight { get; set; }
    private double Height { get; set; }

    public BmiCalculator(double weight, double height)
    {
        SetCategory("BMI");
        Weight = weight;
        Height = height;
    }

    public override void Calculate()
    {
        double bmi = Weight / Math.Pow(Height, 2);
        DisplayResults(bmi);
        DisplayAdvice();
    }
}