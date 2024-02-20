// the waist to hip ratio calculator sub class of health calculator
public class WaistToHipRatioCalculator : HealthCalculatorBase
{
    private double WaistCircumference { get; set; }
    private double HipCircumference { get; set; }
    private double Result { get; set; }

    public WaistToHipRatioCalculator(double waistCircumference, double hipCircumference)
    {
        SetCategory("Waist-to-Hip Ratio");
        WaistCircumference = waistCircumference;
        HipCircumference = hipCircumference;
    }

    public override void Calculate()
    {
        double waistToHipRatio = WaistCircumference / HipCircumference;
        DisplayResults(waistToHipRatio);
        DisplayAdvice(waistToHipRatio);

        Result = waistToHipRatio;
    }

    protected virtual void DisplayAdvice(double waistToHipRatio)
    {
        // Specific advice for Waist-to-Hip Ratio Calculator result
        Console.WriteLine("Health Advice for Waist-to-Hip Ratio:");

        if (waistToHipRatio < 0.9)
        {
            Console.WriteLine("Low Risk: You have a healthy distribution of body fat; continue maintaining a healthy lifestyle.");
        }
        else if (waistToHipRatio >= 0.9 && waistToHipRatio < 1.0)
        {
            Console.WriteLine("Moderate Risk: Pay attention to your lifestyle choices and consider consulting with a health professional.");
        }
        else
        {
            Console.WriteLine("High Risk: Consult with a health professional for personalized advice and intervention.");
        }
    }

    public double GetWaistToHipRatioResult()
    {
        return Result;
    }
}
