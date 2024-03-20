namespace Foundation4;
using System;

class Swimming : Activity
{
    public Swimming(DateTime date, int length, string type, double distance, double speed, double pace) : base(date, length, type, distance, speed, pace){}

    public override double GetDistance()
    {
        return base.GetDistance();
    }

    public override double GetSpeed()
    {
        return base.GetSpeed();
    }

    public override double GetPace()
    {
        return base.GetPace();
    }
}