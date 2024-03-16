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
    public void IsComplete()
    {
        if (isComplete == true)
        {
            Console.Write("The goal has been completed, congratulations! "); // add points here??? [x]
        }
        else
        {
            Console.Write("This goal still needs to be completed."); // to earn ___ points ?? [ ]
        }
    }
}