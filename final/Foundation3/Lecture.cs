namespace Foundation3;
using System;

public class Lecture : Event
{
    // lecture variables
    private string speaker;
    private int capacity;

    // constructor
    public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    // full details message
    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nType: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}";
    }
}