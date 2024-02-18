// class for bmr
public class BmrCalculator : HealthCalculatorBase
{
    private double Weight { get; set; }
    private double Height { get; set; }
    private int Age { get; set; }
    private char Gender { get; set; }

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
        
        double bmr;
        if (Gender == 'M')
        {
            bmr = 88.362 + (13.397 * Weight) + (4.799 * Height) - (5.677 * Age);
        }
        else if (Gender == 'F')
        {
            bmr = 447.593 + (9.247 * Weight) + (3.098 * Height) - (4.330 * Age);
        }
        else
        {
            Console.WriteLine("Invalid gender input.");
            return;
        }

        DisplayResults(bmr);
        DisplayAdvice();
    }
}
