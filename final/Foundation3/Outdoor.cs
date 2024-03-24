namespace Foundation3;
using System;

public class Outdoor : Event
{
    private string weather;

    // constructor
    public Outdoor(string title, string description, DateTime date, string time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        this.weather = weather;
    }

    // full details message
    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nType: Outdoor Gathering\nWeather Forecast: {weather}";
    }
}
