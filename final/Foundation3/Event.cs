namespace Foundation3;
using System;

public class Event
{
    private string title;
    private string description;
    private DateTime date;
    private string time; 
    private Address address;

    // constructor
    public Event (string title, string description, DateTime date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    // standard details message
    public string GetStandardDetails()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time}\nAddress: {address}";
    }

    // full details message, can be overridden by child classes
    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDescription()
    {
        return $"{GetType().Name}: {title}\nDate: {date.ToShortDateString()}";
    }
}