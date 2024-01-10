using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string gradeValue = Console.ReadLine();
        int grade = int.Parse(gradeValue);

        string letter = "";

        if (grade >= 90) 
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }
        else
        {
            Console.WriteLine("Please enter a valid integer between 0 and 100.");
        }

        Console.WriteLine($"Your grade is: {letter}");
        if (grade >= 70)
        {
            Console.WriteLine("Congrats! You passed the class! :)");
        }
        else
        {
            Console.WriteLine("Better luck next time. :(");
        }
    }
}