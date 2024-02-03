namespace Journal;
using System;

public class Entry
{
    // Create entries and their necessary information
    public string response;
    public string prompt;
    public string date;

    // CONSTRUCTOR FOR ENTRY
    public Entry(string response, string prompt, string date)
    {
        this.response = response;
        this.prompt = prompt;
        this.date = date;
    }

    public Entry(string import)
    {
        var entries = import.Split("~|~");
        this.date = entries[0];
        this.prompt = entries[1];
        this.response = entries[2];
    }

    // This is how the prompt and response will be formatted in the text file.
    public string Export()
    {
        return $"{date} ~|~ { prompt} ~|~ {response}";
    }

    // DisplayString() : string
    public string DisplayString()
    {
        return $"Date: {date} - Prompt: {prompt} \n{response}";
    }
}