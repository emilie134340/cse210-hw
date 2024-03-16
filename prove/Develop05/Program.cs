namespace Goals;
using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        List<Goal> goals = new List<Goal>();
        while (choice != 6)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                // create goals
                case 1:
                Console.Clear();
                Goal.GoalMenu();
                break;

                // list goals
                case 2:
                Goal.ListGoals(goals);
                break;

                // save goals
                case 3:
                Goal.SaveGoal(goals);
                break;

                // load goals
                case 4:
                Goal.LoadGoal(goals);
                break;

                // record event (??)
                case 5:
                //Goal.RecordEvent(goals);
                break;

                // exit
                case 6:
                Environment.Exit(0);
                break;
            }
        }
    } 
}