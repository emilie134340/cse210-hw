namespace Foundation4;
using System;

class Swimming : Activity
{
    private int laps;

    // constructor
    public Swimming(DateTime date, string name, int length, int laps) : base(date, name, length)
    {
        this.laps = laps;
    }

    // get ditance, speed, pace, and summary for swimming
    public override double GetDistance()
    {
        return laps * 50 / 1000.0; // Distance in km
    }
    public override double GetSpeed()
    {
        return GetDistance() / (length / 60.0); // Speed in kmph
    }
    public override double GetPace()
    {
        return length / GetDistance(); // Pace in minutes per kilometer
    }
    public override string GetSummary()
    {
        return $"{base.GetSummary()} Swimming ({length} min) - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}