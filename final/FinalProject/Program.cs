using System;
using 

class Program
{
    static void Main()
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.WriteLine("Health Calculator Menu:");
            Console.WriteLine("1. BMI Calculator");
            Console.WriteLine("2. BMR Calculator");
            Console.WriteLine("3. Body Fat Percentage Calculator");
            Console.WriteLine("4. Body Water Percentage Calculator");
            Console.WriteLine("5. Bone Mass Calculator");
            Console.WriteLine("6. Muscle Mass Calculator");
            Console.WriteLine("7. Waist-to-Hip Ratio Calculator");
            Console.WriteLine("8. Quit");

            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                double bodyFatPercentage = 0;
                double waistToHipRatioResult = 0;

                switch (choice)
                {
                    case 1:
                        var bmiCalculator = new BmiCalculator(UserInputHandler.GetWeight(), UserInputHandler.GetHeight());
                        bmiCalculator.Calculate();
                        break;

                    case 2:
                        var bmrCalculator = new BmrCalculator(UserInputHandler.GetWeight(), UserInputHandler.GetHeight(), UserInputHandler.GetAge(), UserInputHandler.GetGender());
                        bmrCalculator.Calculate();
                        break;

                    case 3:
                        var bodyFatCalculator = new BodyFatPercentageCalculator(UserInputHandler.GetAge(), UserInputHandler.GetGender(), UserInputHandler.GetHeight());
                        bodyFatCalculator.Calculate();
                        bodyFatPercentage = bodyFatCalculator.GetBodyFatPercentage();
                        break;

                    case 4:
                        var bodyWaterCalculator = new BodyWaterPercentageCalculator(UserInputHandler.GetWeight(), UserInputHandler.GetGender(), bodyFatPercentage);
                        bodyWaterCalculator.Calculate();
                        break;

                    case 5:
                        var boneMassCalculator = new BoneMassCalculator(UserInputHandler.GetWeight(), UserInputHandler.GetHeight(), UserInputHandler.GetAge(), UserInputHandler.GetGender());
                        boneMassCalculator.Calculate();
                        break;

                    case 6:
                        var muscleMassCalculator = new MuscleMassCalculator(UserInputHandler.GetWeight(), bodyFatPercentage);
                        muscleMassCalculator.Calculate();
                        break;

                    case 7:
                        var waistToHipRatioCalculator = new WaistToHipRatioCalculator(UserInputHandler.GetWaistCircumference(), UserInputHandler.GetHipCircumference());
                        waistToHipRatioCalculator.Calculate();
                        waistToHipRatioResult = waistToHipRatioCalculator.GetWaistToHipRatioResult();
                        break;

                    case 8:
                        continueProgram = false;
                        Console.WriteLine("Exiting the program. Thank you!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric choice.");
            }

            Console.WriteLine();
        }
    }
}
