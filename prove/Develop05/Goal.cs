namespace Goals;
using System;

abstract class Goal
{
    protected int points;
    public string type;
    protected string name;
    protected string description;

    public void SetPoints(int points)
    {
        this.points = points;
    }
    public int GetPoints()
    {
        return points;
    }
    public void SetName(string name)
    {
        this.name = name;
    }
    public string GetName()
    {
        return name;
    }
    public void SetDescription(string description)
    {
        this.description = description;
    }
    public string GetDescription()
    {
        return description;
    }

    public Goal(string type, string name, string description, int points)
    {
        this.points = points;
        this.type = type;
        this.name = name;
        this.description = description;
    }    

    // Each new goal will be created and stored in a list of goals
    public abstract void NewGoal();

    // DISPLAY POINTS ?????
        // Console.WriteLine("The goals are: ");
        // DISPLAY A LIST OF ALL THE GOALS
        // Console.WriteLine("Which goal did you accomplish? ");
        // ALLOW USER TO SELECT A NUMBER FROM THE LIST OF GOALS
        // SHOW POINTS EARNED
        // SHOW TOTAL POINTS ?? HERE OR SOMEWHERE ELSE DEPENDING ON REQS
    public abstract int RecordEvent(List<Goal> goals); // doesnt work

    public abstract bool IsComplete(List<Goal> goals); // ???
}