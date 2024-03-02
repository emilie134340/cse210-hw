namespace Mindfulness;
using System;

class Program
{
    static void Main(string[] args)
    {
        // int defaultDuration = 10;
        //int duration;
        int choice = 0;
        while (true)
        {
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an activity or press 4 to exit: ");

            choice = int.Parse(Console.ReadLine());

            Activity activity = null;

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    activity = new BreathingActivity(10); //default duration is 10, can/will be overriden with user input. 
                    break;
                case 2:
                    Console.Clear();
                    activity = new ReflectionActivity(10); // default duration ^
                    break;
                case 3:
                    Console.Clear();
                    activity = new ListingActivity(10); // default duration ^
                    break;
                case 4:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            if (activity != null)
            {
                Console.Clear();
                activity.Start();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}