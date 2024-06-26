namespace Foundation4;
using System;

class Cycling : Activity
{
    private double speed;

    // constructor
    public Cycling(DateTime date, string name, int length, double speed) : base(date, name, length)
    {
        this.speed = speed;
    }

    // get distance
    public override double GetDistance()
    {
        return (speed * length) / 60;
    }

    // get speed, pace, and summary for cycling
    public override double GetSpeed()
    {
        return speed; // mph
    }
    public override double GetPace()
    {
        return 60.0 / speed; // Pace in minutes per mile
    }
    public override string GetSummary()
    {
        return $"{base.GetSummary()} Cycling ({length} min) - Distance: {GetDistance():F2} miles, Speed: {speed:F2} mph, Pace: {GetPace():F2} min per mile";
    }
}