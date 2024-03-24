namespace Foundation4;
using System;

class Running : Activity
{
    private double distance;

    // constructor
    public Running(DateTime date, string name, int length, double distance) : base(date, name, length)
    {
        this.distance = distance;
    }

    // get distance, speed, pace, and summary for running
    public override double GetDistance()
    {
        return distance;
    }
    public override double GetSpeed()
    {
        return distance / (length / 60.0); // Speed in miles per hour
    }
    public override double GetPace()
    {
        return length / distance; // Pace in minutes per mile
    }
    public override string GetSummary()
    {
        return $"{base.GetSummary()} Running ({length} min) - Distance: {distance:F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}