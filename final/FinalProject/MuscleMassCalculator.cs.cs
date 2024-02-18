// class for muscle mass calculation
public class MuscleMassCalculator : HealthCalculatorBase
{
    private double Weight { get; set; }
    private double BodyFatPercentage { get; set; }

    public MuscleMassCalculator(double weight, double bodyFatPercentage)
    {
        SetCategory("Muscle Mass");
        Weight = weight;
        BodyFatPercentage = bodyFatPercentage;
    }

    public override void Calculate()
    {
        double muscleMass = Weight * (1 - BodyFatPercentage / 100);
        DisplayResults(muscleMass);
        DisplayAdvice();
    }
}