namespace Mindfulness;
using System;

class ListingActivity : Activity
{
    // list to store the items listed by the user during the activity
    private List<string> items = new List<string>();
    // listing prompts array, random indexes will be selected
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    // constructor where there is the activity name and description, with the duration being filled in with user input
    public ListingActivity(int duration) : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration) { }

    protected override void PerformActivity()
    {
        Random random = new Random();
        int index = random.Next(prompts.Length);
        Console.WriteLine(prompts[index]);
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        Console.WriteLine("Start listing...");
        // until the user-specified duration is reached, let the user list items. Count the items listed.
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            items.Add(item);
        }
        int itemTotal = items.Count;
        Console.WriteLine($"\nYou listed {itemTotal} items!");
    }
}
