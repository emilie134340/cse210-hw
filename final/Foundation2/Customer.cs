namespace Foundation2;
using System;

public class Customer
{
    // get name and address
    private string name;
    private Address address;

    public string GetName()
    {
        return name;
    }

    public Address GetAddress()
    {
        return address;
    }

    // constructor for customer
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    // is the address in the USA?
    public bool IsInUSA()
    {
        return address.IsInUSA();
    }
}