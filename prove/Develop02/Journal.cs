using System.Runtime.CompilerServices;

namespace Develop02;

public class Journal
{
    // Create a list to store journal entries
    // List <entry> list
    public List<Entry> Entries = new List<Entry>();

    // Method to export the journal to file manager and program
    // ExportJournal() : string
        public void AddEntry(string prompt, string response, string date)
    {
        Entry entry = new Entry { Prompt = prompt, Response = response, Date = date };
        Entries.Add(entry);
    }
    public Journal()
    {

    }

    public Journal(string import)
    {

    }

    public void DisplayEntries()
    {
        foreach (var entry in Entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}\n");
        }
    }

//     public string ExportJournal()
//     {

//     }
}