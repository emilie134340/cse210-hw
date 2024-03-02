namespace Mindfulness;
using System;

class BreathingActivity : Activity 
{
    // constructor where there is the activity name and description, with the duration being filled in with user input
    public BreathingActivity(int duration) : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", duration) 
    {
     }

    protected override void PerformActivity()
    {
        int breatheIn = 3; //hard code breathe in 3 seconds
        int breatheOut = (int)Math.Round(breatheIn * 1.1); // just a little longer
        DateTime endTime = DateTime.Now.AddSeconds(duration);

       // DateTime currentTime = DateTime.Now;
        while (DateTime.Now < endTime) 
        {
            Console.Write($"Breathe in...{breatheIn}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write($"\nBreathe out...{breatheOut}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine("\n");
        }

    }
}
