// the waist to hip ratio calculator sub class of health calculator

public class WaistToHipRatioCalculator : HealthCalculatorBase
{
    private double WaistCircumference { get; set; }
    private double HipCircumference { get; set; }
    private double Result {get; set; }

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
        DisplayAdvice();

        Result = waistToHipRatio;
    }
        public double GetWaistToHipRatioResult()
    {
        return Result;
    }
}