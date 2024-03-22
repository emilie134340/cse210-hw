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
    public abstract int RecordEvent(List<Goal> goals); // allow to mark event as complete, add points

    public abstract bool IsComplete(); // store if goal is complete
}