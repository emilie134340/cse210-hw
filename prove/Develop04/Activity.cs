namespace Mindfulness;
using System;
using System.Runtime.CompilerServices;
using System.Threading;

// base class for the program
// source for using abstract class:
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract 
abstract class Activity
{
    protected string activityName;
    protected string activityDescription;
    protected int duration;

    // constructor
    // public Activity(string activityName, string activityDescription)
    // {
    //     this.activityName = activityName;
    //     this.activityDescription = activityDescription;
    // }

    public Activity(string activityName, string activityDescription, int duration)
    {
        this.activityName = activityName;
        this.activityDescription = activityDescription;
        this.duration = duration;
    }

    // set duration
    public void SetDuration(int duration)
    {
        this.duration = duration;
    }

    // this method starts the mindfullness activity and includes the beginning and ending messages.
    public void Start()
    {
        Console.WriteLine($"Welcome to the {activityName} activity!\n");
        Console.WriteLine(activityDescription);
        Console.Write("\nHow long, in seconds, would you like to spend on this activity? ");
        duration = int.Parse(Console.ReadLine());
        SetDuration(duration);
        Console.Clear();
        Console.WriteLine($"Prepare to begin the {activityName} activity.");
        ShowSpinner();
        PerformActivity();
        ShowSpinner();
        Console.WriteLine($"You have completed the {activityName} activity for {duration} seconds. Good job!");
    }

    // method to perform the specific activity. overrides for each child class can be found in their respective files.
    protected abstract void PerformActivity();

    // spinner animation, goes for 4 seconds each time it's called in the program
    public void ShowSpinner()
    {
        List<string> animation = new List<string>();
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(4); // 4 seconds

        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(animation[i]);
            Thread.Sleep(500); // each spinner phase lasts half a second
            Console.Write("\b \b");
            i++;

            if (i >= animation.Count)
            {
                i = 0;
            }

        }
        Console.WriteLine();
    }

}