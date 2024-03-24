namespace Foundation4;
using System;

class Activity 
{
    protected DateTime date;
    protected string name;
    protected int length;

    public Activity(DateTime date, string name, int length)
    {
        this.date = date;
        this.name = name;
        this.length = length;
    }

    // getters for distance, speed, and pace that will be overriden in child classes
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public virtual string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} -";
    }
}
