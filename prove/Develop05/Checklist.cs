namespace Goals;
using System;
using System.Xml.Schema;

class Checklist : Goal
{
    private int timesToComplete;
    private int timesCompleted;
    private int bonusPoints;
    public int bonusPointsTest => bonusPoints; // expose bonusPoints directly

    public Checklist(string type, string name, string description, int points, int timesToComplete, int bonusPoints) : base(type, name, description, points)
    {
        this.timesToComplete = timesToComplete;
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
        int checklistTimesToComplete = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        int checklistBonusPoints = int.Parse(Console.ReadLine());
        Checklist checklistGoal = new Checklist("Checklist Goal", checklistName, checklistDescription, checklistPoints, checklistTimesToComplete, checklistBonusPoints);
        goals.Add(checklistGoal);
    }

    public override bool IsComplete(List<Goal> goals)
    {
        // For checklist goals, check if the required number of times for a bonus has been completed
        return timesToComplete >= timesCompleted;
    }

    public override int RecordEvent(List<Goal> goals)
    {
        // Increment the number of times completed for checklist goals
        timesCompleted++;

        // Check if the goal has been completed the required number of times for a bonus
        if (IsComplete(goals))
        {
            // If so, add bonus points to the total points
            points += bonusPoints;
            // Reset the times completed for the next round
            timesCompleted = 0;
        }

        return points;
    }
}