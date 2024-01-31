namespace Develop02;
using System.IO;

public class FileManager 
{
    // Save the journal to a file
    // SaveJournalToFile(journal : Journal, _filename : string) -> Journal
    // public Journal SaveJournalToFile()
    // {
    // string filename = "";
    // string[] lines = System.IO.File.ReadAllLines(filename);

    // foreach (string line in lines)
    // {
    //     string[] parts = line.Split("~|~");

    //     // fix
    //     string firstName = parts[0];
    //     string lastName = parts[1];
    // }
    // }

        public void SaveJournalToFile(Journal journal, string filename)
    {
        using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename))
        {
            foreach (var entry in journal.Entries)
            {
                file.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    public Journal AddEntryToFile(string filename)
    {
        Journal journal = new Journal();
        // make sure the file is open for appending 
        using (System.IO.StreamReader file = new System.IO.StreamReader(filename))
        {
            while (!file.EndOfStream) 
            {
                string[] entryData = file.ReadLine().Split('~|~');
                if (entryData.Length == 3)
                {
                    journal.AddEntry(entryData[1], entryData[2], entryData[0]);
                }
            }
        }
        return journal;
    }
}