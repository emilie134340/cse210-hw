namespace Goals;
using System;
using System.Xml.Schema;

class Checklist : Goal
{
    private int timesCompleted;
    private int bonusPoints;
    public int bonusPointsTest => bonusPoints; 

    public Checklist(string type, string name, string description, int points, int timesCompleted, int bonusPoints) : base(type, name, description, points)
    {
        this.timesCompleted = timesCompleted;
        this.bonusPoints = bonusPoints;
    }

    public override void NewGoal(List<Goal> goals)
    {
        Console.WriteLine("What is the name of your goal? ");
        string checklistName = Console.ReadLine(); 
        Console.WriteLine("What is a short description of it? ");
        string checklistDescription = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal? ");
        int checklistPoints = int.Parse(Console.ReadLine());
        Console.WriteLine("How many times does this goal need to be completed for a bonus? ");
        int checklistTimesCompleted = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        int checklistBonusPoints = int.Parse(Console.ReadLine());
        Checklist checklistGoal = new Checklist("Checklist Goal", checklistName, checklistDescription, checklistPoints, checklistTimesCompleted, checklistBonusPoints);
        goals.Add(checklistGoal);
    }
}