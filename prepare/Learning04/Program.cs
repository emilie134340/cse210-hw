using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Samuel Jones", "Math");
        Console.WriteLine(a1.GetSummary());
        
        MathAssignment a2 = new MathAssignment("Rachel Smith", "Fractions", "3.4", "1-4");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Emilie Mickelsen", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}