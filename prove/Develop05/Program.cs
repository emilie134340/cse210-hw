namespace Goals;
using System;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static void Main(string[] args)
    {
        int choice = 0;
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
                    GoalMenu();
                    break;

                // list goals
                case 2:
                    ListGoals();
                    break;

                // save goals
                case 3:
                    SaveGoals();
                    break;

                // load goals
                case 4:
                    LoadGoals();
                    break;

                // record event (??)
                case 5:
                    //goals[0].RecordEvent();
                    break;

                // exit
                case 6:
                    Environment.Exit(0);
                    break;
            }
        }
    } 

    // use this goal menu in program for option 1
    public static void GoalMenu()
    {
        int choice = 0;
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        choice = int.Parse(Console.ReadLine());
        // List<Goal> goals = new List<Goal>();
        switch(choice)
        {
            case 1:
            Console.Clear();
            // new Simple Goal;
            //Simple simpleGoal = new Simple("", "", "", 0); // defaults
            Simple simpleGoal = new Simple("", "", "", 0);
            simpleGoal.NewGoal();
            goals.Add(simpleGoal);
            break;

            case 2:
            Console.Clear();
            // new Eternal Goal
            Eternal eternalGoal = new Eternal("", "", "", 0); // defaults
            //eternalGoal.NewGoal(goals);
            eternalGoal.NewGoal();
            goals.Add(eternalGoal);
            break;

            case 3:
            Console.Clear();
            // new Checklist Goal;
            Checklist checklistGoal = new Checklist("", "", "", 0, 0, 0); // defaults
            //checklistGoal.NewGoal(goals);
            checklistGoal.NewGoal();
            goals.Add(checklistGoal);
            break;

            default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
        }
    }
    // For each goal in the list of goals, format and display them to be printed in a text file
    public static void ListGoals()
    {
        Console.WriteLine("Your goals are: ");
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"[ ] {goal.GetName()}: {goal.GetDescription()} - {goal.GetPoints()} points :)");
        }
    }

    // SAVE GOAL !!!!!
    public static void SaveGoals()
    {
        Console.WriteLine("Write a name for the file (Ex: goals.txt): ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine("totalPoints = "); // HOW TO DISPLAY POINTS ????
            // change the output based on goal type
            foreach (Goal goal in goals)
            {
                if (goal.GetType() == typeof(Checklist)) // checklist
                {
                    Checklist checklistGoal = (Checklist)goal; // to use bonus points
                    outputFile.WriteLine($"{goal.type},{goal.GetName()},{goal.GetDescription()},{goal.GetPoints()},{checklistGoal.bonusPointsTest}");
                }
                else // simple or eternal
                {
                    outputFile.WriteLine($"{goal.type},{goal.GetName()},{goal.GetDescription()},{goal.GetPoints()}");
                }
            }
        }
    }

    // LOAD GOAL !!!!!
    public static void LoadGoals()
    {
        Console.WriteLine("What is your goal filename? ");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                if (line.StartsWith("totalPoints"))
                {
                    continue; // skip the line with the total points displayed
                }
                string[] parts = line.Split(','); // maybe to count points based on index ... ?
                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]); 

                switch (type)
                {
                    case "Simple Goal":
                        goals.Add(new Simple(type, name, description, points));
                        break;
                    case "Eternal Goal":
                        goals.Add(new Eternal(type, name, description, points));
                        break;
                    case "Checklist Goal":
                        int timesCompleted = int.Parse(parts[4]);
                        int bonusPoints = int.Parse(parts[5]); 
                        goals.Add(new Checklist(type, name, description, points, timesCompleted, bonusPoints));
                        break;
                }

                Console.WriteLine(goals);

                // display total points at the top
            }
    }
}