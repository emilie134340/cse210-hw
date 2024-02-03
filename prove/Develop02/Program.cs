namespace Journal;
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool loopMenu = true;

        // Show the menu options and perform menu operations until the user exits the program
        while (loopMenu)
        {
            Console.Clear();
            int choice = ShowMenu();

            if (choice == 1) // Write a journal entry
            {
                journal.AddEntry();
            }
            else if (choice == 2) // Display the entry
            {
                // Console.Clear();
                journal.DisplayEntries();
            }
            else if (choice == 3) // Save the entry to a file
            {
                var lines = journal.Export();
                WriteFile(lines);
            }
            else if (choice == 4) // Load the file that has the entries
            {
                var lines = ReadFile();
                journal = new Journal(lines);
            }
            else if (choice == 5) // Exit the program
            {
                loopMenu = false;
            }
            else{
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
            }
        }
    }

    static int ShowMenu()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Exit");
        Console.Write("\nWhat would you like to do? ");
        var choice = int.Parse(Console.ReadLine());
        return choice;
    }

    // Ask for a filename
    static string[] ReadFile()
    {
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        return System.IO.File.ReadAllLines(filename);
    }

    // Write to the file with the entries
    static void WriteFile(string[] lines)
    {
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        System.IO.File.WriteAllLines(filename, lines);
    }
}