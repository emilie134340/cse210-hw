namespace Foundation3;
using System;

public class Reception : Event
{
    private string email;

    public Reception(string title, string description, DateTime date, string time, Address address, string email)
        : base(title, description, date, time, address)
    {
        this.email = email;
    }

    // full details message
    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nType: Reception\nRSVP Email: {email}";
    }
}