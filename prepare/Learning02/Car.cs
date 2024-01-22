using System;

public class Car
{
    public string _model;
    public string _make;
    public int _year;
    public int _milesPerGallon;
    public Owner owner;

    // add constructor later? Check the drive


    public void Display()
    {
        System.Console.WriteLine($"A {_make} {_model} from {_year} that gets {_milesPerGallon} miles per gallon. Owned by {owner._name}. Phone: {owner._phone}.");
    }
}