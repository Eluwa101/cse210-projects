// class for bone mass calculator
public class BoneMassCalculator : HealthCalculatorBase
{
    private double Weight { get; set; }
    private double Height { get; set; }
    private int Age { get; set; }
    private char Gender { get; set; }

    public BoneMassCalculator(double weight, double height, int age, char gender)
    {
        SetCategory("Bone Mass");
        Weight = weight;
        Height = height;
        Age = age;
        Gender = gender;
    }

    public override void Calculate()
    {
        double boneMass;

        if (Gender == 'M')
        {
            // Formula of bone mass for men
            boneMass = 0.180168 * Weight + 0.203553 * Height - 0.0146634 * Age + 2.5;
        }
        else if (Gender == 'F')
        {
            // this one is for women
            boneMass = 0.245691 * Weight + 0.125865 * Height - 0.0854334 * Age + 0.74;
        }
        else
        {
            Console.WriteLine("Invalid gender input.");
            return;
        }

        DisplayResults(boneMass);
        DisplayAdvice();
    }
}