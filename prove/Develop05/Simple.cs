namespace Goals;
using System;

class Simple : Goal
{
    private bool isComplete;
    public Simple(string type, string name, string description, int points) : base(type, name, description, points){}


    public override void NewGoal(List<Goal> goals)
    {
        Console.WriteLine("What is the name of your goal? ");
        string simpleName = Console.ReadLine(); 
        Console.WriteLine("What is a short description of it? ");
        string simpleDescription = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal? ");
        int simplePoints = int.Parse(Console.ReadLine());
        Simple simpleGoal = new Simple("Simple Goal", simpleName, simpleDescription, simplePoints);
        goals.Add(simpleGoal);
    }

    // if the goal has been completed, display
    public override bool IsComplete(List<Goal> goals)
    {
        return isComplete;
    }

    // Override ToString to display the goal's information and completion status
    public override string ToString()
    {
        string status = isComplete ? "[X]" : "[ ]";
        return $"{status} {name}: {description} - {points} points";
    }

    public override int RecordEvent(List<Goal> goals)
    {
        if (!isComplete)
        {
            isComplete = true; // Mark the simple goal as complete
            return points; // Return the point value associated with recording the event
        }
        else
        {
            // If the goal is already complete, return 0 points
            return 0;
        }
    }
}