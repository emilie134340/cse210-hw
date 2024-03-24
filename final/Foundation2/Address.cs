namespace Foundation2;
using System;

public class Address
{
    // variables for address
    private string streetAddress;
    private string city;
    private string state;
    private string country;

    // constructor
    public Address(string streetAddress, string city, string state, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    // is in USA?
    public bool IsInUSA()
    {
        return country == "USA";
    }

    // format address for later in Program
    public string GetFormattedAddress()
    {
        return $"{streetAddress}\n{city}, {state}, {country}";
    }
}