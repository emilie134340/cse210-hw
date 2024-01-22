using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        // new Job instance job1
        Job job1 = new Job();
        // set member variables using the dot notation ex: job1._jobTitle = "Software Engineer";
        job1._jobTitle = "Digital Accessibility Team Lead";
        job1._company = "BYU-Idaho";
        job1._startYear = 2023;
        job1._endYear = 2024;
        // verify the company displays correctly using dot notation to access the member variable
        job1.Display();
        // create another Job instance job2 and display the company on the screen too
        Job job2 = new Job();
        job2._jobTitle = "TA Virtualized Enterprise Systems";
        job2._company = "BYU-Idaho";
        job2._startYear = 2023;
        job2._endYear = 2023;
        // verify the company displays correctly using dot notation to access the member variable
        job2.Display();

        // new instance of Resume class
        Resume resume1 = new Resume();
        resume1._name = "Emilie Mickelsen";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();

        System.Console.WriteLine("This is just the exercise from class:");
        // Car exercise from class
        // this is defined here because it makes more logical sense. Can a single car have a list of cars? No.
        var cars = new List<Car>();

        Car car = new Car();
        
        car._make = "Toyota";
        car._model = "RAV4";
        car._year = 2023;
        car._milesPerGallon = 50;

        var owner = new Owner();
        owner._name = "Rachel";
        owner._phone = "512-417-0646";
        car.owner = owner;
        cars.Add(car);

        car = new Car();
        car._make = "Honda";
        car._model = "Pilot";
        car._year = 2004;
        car._milesPerGallon = 25;

        owner = new Owner();
        owner._name = "Kyle";
        owner._phone = "210-913-3873";
        car.owner = owner;
        cars.Add(car);

        foreach (var c in cars)
        {
            c.Display();
        }

    }
}

// he went fast so this may be wrong/not best practices. But it works.
public class Owner
{
    public string _name;
    public string _phone;
}