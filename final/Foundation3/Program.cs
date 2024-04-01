namespace Foundation3;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create address
        Address address1 = new Address("123 Main St", "Cityville", "ID");
        Address address2 = new Address("9452 Oaks Rd", "Cool City", "TX");
        Address address3 = new Address("3458 Cherry Cv", "Citiest City", "FL");

        // Create events
        Event lectureEvent = new Lecture("Lecture on Whales", "A fascinating talk about whales", new DateTime(2024, 3, 25), "10:00 AM", address1, "Dr. Orca", 50);
        Event receptionEvent = new Reception("Whale Reception", "A celebration of whales", new DateTime(2024, 4, 1), "7:00 PM", address2, "rsvp@whale.com");
        Event outdoorEvent = new Outdoor("Outdoor Whale Watching Event", "Whale watching from a boat", new DateTime(2024, 4, 15), "2:00 PM", address3, "Sunny");

        // Display marketing messages
        // Lecuture
        Console.WriteLine("Lecture Event Details:");
        Console.WriteLine("----------------------");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(lectureEvent.GetShortDescription());
        Console.WriteLine();


        // Reception
        Console.WriteLine("Reception Event Details:");
        Console.WriteLine("------------------------");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine();

        // Outdoor
        Console.WriteLine("Outdoor Event Details:");
        Console.WriteLine("-----------------------");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(outdoorEvent.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(outdoorEvent.GetShortDescription());
    }
}