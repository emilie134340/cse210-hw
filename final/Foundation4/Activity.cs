namespace Foundation4;
using System;

class Activity 
{
    protected DateTime date;
    protected int length;
    protected string type;
    protected double distance;
    protected double speed;
    protected double pace;

    public Activity(DateTime date, int length, string type, double distance, double speed, double pace)
    {
        this.date = date;
        this.length = length;
        this.type = type;
        this.distance = distance;
        this.speed = speed;
        this.pace = pace;
    }

    // getters for distance, speed, and pace that will be overriden in child classes
    public virtual double GetDistance()
    {
        return distance;
    }
    public virtual double GetSpeed()
    {
        return speed;
    }
    public virtual double GetPace()
    {
        return pace;
    }

    public string GetSummary()
    {
        return $"This is the summary";
    }
}
