using System.Runtime.CompilerServices; // this just got added on its own??
namespace Journal;
using System;
using System.Runtime.InteropServices; // this just got added on its own??

public class Journal
{
    // Create a list to store journal entries
    Entry entry;
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
        // DISPLAY PROMPT AND RANDOMIZED THEM
        Console.WriteLine($"Enter your response to {entry.prompt}. ");
        // HANDLE DATE
        // RESPONSE
    }
}