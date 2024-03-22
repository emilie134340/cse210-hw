namespace Goals;
using System;

class Eternal : Goal
{
    public Eternal(string type, string name, string description, int points) : base(type, name, description, points){}


    public override void NewGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        string eternalName = Console.ReadLine(); 
        Console.WriteLine("What is a short description of it? ");
        string eternalDescription = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal? ");
        int eternalPoints = int.Parse(Console.ReadLine());
        // return ("Eternal Goal", eternalName, eternalDescription, eternalPoints);
        this.type = "Eternal Goal";
        this.name = eternalName;
        this.description = eternalDescription;
        this.points = eternalPoints;
    }

    public override bool IsComplete(List<Goal> goals)
    {
        // Eternal goals are never completed
        return false;
    }
    public override int RecordEvent(List<Goal> goals)
    {
        Console.WriteLine("Select a goal to record an event:");
        int index = 1;
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"{index}. {goal.GetName()} - {(goal.IsComplete(goals) ? "[X]" : "[ ]")}");
            index++;
        }

        Console.Write("Enter the number of the goal: ");
        int selectedIndex = int.Parse(Console.ReadLine()) - 1;

        Goal selectedGoal = goals[selectedIndex];
        int pointsEarned = selectedGoal.RecordEvent(goals);
        return pointsEarned; 
        

        // Show total points
    }
}