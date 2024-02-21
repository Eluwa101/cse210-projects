// this class handles user's input for all thr calculator sub-classes
public class UserInputHandler
{
    public static double GetHeight()
    {
        Console.Write("Enter your height (cm): ");
        return Convert.ToDouble(Console.ReadLine());
    }

    public static double GetWeight()
    {
        Console.Write("Enter your weight (kg): ");
        return Convert.ToDouble(Console.ReadLine());
    }

    public static int GetAge()
    {
        Console.Write("Enter your age: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    public static char GetGender()
    {
        Console.Write("Enter your gender (M/F): ");
        return char.ToUpper(Console.ReadLine()[0]);
    }

    public static double GetWaistCircumference()
    {
        Console.Write("Enter your waist circumference (cm): ");
        return Convert.ToDouble(Console.ReadLine());
    }

    public static double GetHipCircumference()
    {
        Console.Write("Enter your hip circumference (cm): ");
        return Convert.ToDouble(Console.ReadLine());
    }
}