namespace Foundation4;
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 3, 03), "Running", 30, 3.0),
            new Running(new DateTime(2024, 3, 12), "Running", 30, 4.8),
            new Cycling(new DateTime(2024, 2, 03), "Cycling", 45, 15),
            new Swimming(new DateTime(2024, 2, 23), "Swimming", 60, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}