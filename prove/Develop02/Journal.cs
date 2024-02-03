using System.Runtime.CompilerServices; // this just got added on its own??
namespace Journal;
using System;
using System.Runtime.InteropServices; // this just got added on its own??

public class Journal
{
    // Create a list to store journal entries
    public List<Entry> entries;
    public Journal()
    {
        entries = new List<Entry>();
    }

    // Method to export the journal to program
    // use to string[] importEntries that will import the journal entries from the ReadFile() function
    public Journal(string[] importLines)
    {
        entries = new List<Entry>();
        foreach (var line in importLines)
        {
            var entry = new Entry(line);
            entries.Add(entry);
        }
    }

    // this one will display the entries when asked, as wellas continue the program after the display
    public void DisplayEntries()
    {
        Console.WriteLine("\nYour Entries:");
        Console.WriteLine("------------");
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.DisplayString());
        }
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey(); // returns to main menu options
    }

    // export the list for saving the entry
    public string[] Export()
    {
        var exportLines = new List<string>();
        foreach (var entry in entries)
        {
            exportLines.Add(entry.Export());
        }
        return exportLines.ToArray();
    }

    public void AddEntry()
    {
        // Create a list of prompts
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What accomplishment are you the most proud of today?",
            "What is something you're grateful for today?",
            "Decribe a momement that made you smile or laugh today.",
            "What goal or task did you make progress on today?",
            "In what ways did you show kindness today?",
            "What is something new you've learned today?"
        };

        // Use Random class to randomly select a prompt
        Random random = new Random();
        int randomIndex = random.Next(prompts.Count);
        string selectedPrompt = prompts[randomIndex];
        Console.Clear();
        Console.WriteLine($"Enter your response to: \n{selectedPrompt} ");
        string response = Console.ReadLine();

        // Get the current date and time
        //string date = DateTime.Now.ToString("MM/DD/YYYY");
        DateTime theCurrentTime = DateTime.Now;
        string date = theCurrentTime.ToShortDateString();

        // Create a new Entry and add it to the entries list
        Entry newEntry = new Entry(response, selectedPrompt, date);
        entries.Add(newEntry);
    }
}