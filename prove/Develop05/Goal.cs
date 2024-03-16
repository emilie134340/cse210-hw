namespace Goals;
using System;

abstract class Goal
{
    protected int points;
    public string type;
    protected string name;
    protected string description;

    public Goal(string type, string name, string description, int points)
    {
        this.points = points;
        this.type = type;
        this.name = name;
        this.description = description;
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
        List<Goal> goals = new List<Goal>();
        switch(choice)
        {
            case 1:
            Console.Clear();
            // new Simple Goal;
            Simple simpleGoal = new Simple("", "", "", 0); // defaults
            simpleGoal.NewGoal(goals);
            break;

            case 2:
            Console.Clear();
            // new Eternal Goal
            Eternal eternalGoal = new Eternal("", "", "", 0); // defaults
            eternalGoal.NewGoal(goals);
            break;

            case 3:
            Console.Clear();
            // new Checklist Goal;
            Checklist checklistGoal = new Checklist("", "", "", 0, 0, 0); // defaults
            checklistGoal.NewGoal(goals);
            break;

            default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
        }
    }

    // Each new goal will be created and stored in a list of goals
    public abstract void NewGoal(List<Goal> goals);

    // For each goal in the list of goals, format and display them to be printed in a text file
    public static void ListGoals(List<Goal> goals)
    {
        Console.WriteLine("Your goals are: ");

        foreach (Goal goal in goals)
        {
            Console.WriteLine($"[ ] {goal.name}: {goal.description} - {goal.points} points :)");
        }
    }

    // SAVE GOAL !!!!!
    public static void SaveGoal(List<Goal> goals)
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
                    outputFile.WriteLine($"{goal.type}:{goal.name},{goal.description},{goal.points},{checklistGoal.bonusPointsTest}");
                }
                else // simple or eternal
                {
                    outputFile.WriteLine($"{goal.type}:{goal.name},{goal.description},{goal.points}");
                }
            }
        }
    }

    // LOAD GOAL !!!!!
    public static void LoadGoal(List<Goal> goals)
    {
        Console.WriteLine("What is your goal filename? ");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines("goals.txt");
            foreach (string line in lines)
            {
                if (line.StartsWith("totalPoints"))
                {
                    continue; // skip the line with the total points displayed
                }
                string[] parts = line.Split(',');
                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                switch (type)
                {
                    case "Simple":
                        goals.Add(new Simple(type, name, description, points));
                        break;
                    case "Eternal":
                        goals.Add(new Eternal(type, name, description, points));
                        break;
                    case "Checklist":
                        int timesCompleted = int.Parse(parts[4]);
                        int bonusPoints = int.Parse(parts[5]);
                        goals.Add(new Checklist(type, name, description, points, timesCompleted, bonusPoints));
                        break;
                }
            }
    }

    // DISPLAY POINTS ?????
        // Console.WriteLine("The goals are: ");
        // DISPLAY A LIST OF ALL THE GOALS
        // Console.WriteLine("Which goal did you accomplish? ");
        // ALLOW USER TO SELECT A NUMBER FROM THE LIST OF GOALS
        // SHOW POINTS EARNED
        // SHOW TOTAL POINTS ?? HERE OR SOMEWHERE ELSE DEPENDING ON REQS
    public abstract int RecordEvent(List<Goal> goals);

    public abstract bool IsComplete(List<Goal> goals);
}