namespace Goals;
using System;

class Eternal : Goal
{
    public Eternal(string type, string name, string description, int points) : base(type, name, description, points){}


    public override void NewGoal(List<Goal> goals)
    {
        Console.WriteLine("What is the name of your goal? ");
        string eternalName = Console.ReadLine(); 
        Console.WriteLine("What is a short description of it? ");
        string eternalDescription = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal? ");
        int eternalPoints = int.Parse(Console.ReadLine());
        Eternal eternalGoal = new Eternal("Eternal Goal", eternalName, eternalDescription, eternalPoints);
        goals.Add(eternalGoal);
    }

    public override bool IsComplete(List<Goal> goals)
    {
        // Eternal goals are never completed
        return false;
    }
    public override int RecordEvent(List<Goal> goals)
    {
        return points;
    }
}