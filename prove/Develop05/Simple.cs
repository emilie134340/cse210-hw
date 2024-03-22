namespace Goals;
using System;

class Simple : Goal
{
    private bool isComplete;
    public Simple(string type, string name, string description, int points) : base(type, name, description, points){}


    public override void NewGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        string simpleName = Console.ReadLine(); 
        Console.WriteLine("What is a short description of it? ");
        string simpleDescription = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal? ");
        int simplePoints = int.Parse(Console.ReadLine());
        // Simple simpleGoal = new Simple("Simple Goal", simpleName, simpleDescription, simplePoints);
        this.type = "Simple Goal";
        this.name = simpleName;
        this.description = simpleDescription;
        this.points = simplePoints;
        // return simpleGoal;
    }

    // if the goal has been completed, display
    public override bool IsComplete()
    {
        return isComplete = true;
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
            //return 0;
        Console.WriteLine("Select a goal to record an event:");
        int index = 1;
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"{index}. {goal.GetName()} - {(goal.IsComplete() ? "[X]" : "[ ]")}");
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
}