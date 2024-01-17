using System;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        // Console.Write("What is the magic number? ");
        // string magicValue = Console.ReadLine();
        // int magicNumber = int.Parse(magicValue);

        int guess = -1; // -1 because this value can't match the random value

        while (magicNumber != guess)
        {
            // Console.Write("What is your guess? ");
            // string guessValue = Console.ReadLine();
            // guess = int.Parse(guessValue);
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } 

    }
}