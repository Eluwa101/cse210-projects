using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomNumberGenerator = new Random();
        int magicNum = randomNumberGenerator.Next(1, 101);

        int userGuess = 101;
            while (userGuess != magicNum)
            {
                Console.WriteLine("enter 0 to exit game");
                Console.Write("What is the magic number? ");
                string userGuessString = Console.ReadLine();
                userGuess = int.Parse(userGuessString );
                if (userGuess == 0)
                {
                    break;
                    
                }

                if (magicNum > userGuess)
                {
                    Console.WriteLine("Guess a higher number");
                }
                else if (magicNum < userGuess)
                {
                    Console.WriteLine("Guess lower");
                }
                else
                {
                    Console.WriteLine("Yaay, you guessed it right.");
                }
            }
    }
}