namespace Foundation3;
using System;

public class Address
{
    // address variables
    private string streetAddress;
    private string city;
    private string state;

    // address constructor
    public Address(string streetAddress, string city, string state)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.state = state;
    }

    // format address
    public override string ToString()
    {
        return $"{streetAddress}, {city}, {state}";
    }
}