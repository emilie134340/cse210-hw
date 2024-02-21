using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
    }
}

class Vehicle
{
    private string make;
    private string model;
    private int miles;

    public Vehicle(string make, string model, int miles)
    {
        this.make = make;
        this.model = model;
        this.miles = miles;
    }
}

class Car : Vehicle
{
    public Car(string make, string model, int miles) : base(make, model, miles){}
}

class Truck : Vehicle
{
    private int towing;

    public Truck(string make, string model, int miles, int towing) : base(make, model, miles)
    {
        this.towing = towing;
    }
}