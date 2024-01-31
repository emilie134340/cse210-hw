namespace Develop02;
using System;

public class Menu 
{
    // Show the menu and save the user's choice as an int
    // ShowMenu() : int
    // public static List<Items> menuItems;
    // public string ShowMenu()
    // {
    //     List<Items> menuItems = new List<Items>();
    //     {
    //         new Items("1. Write"),
    //         new Items("2. Load"),

    //     };
         
    //     Console.WriteLine("1. Write\n2. Display\n3. Save\n4. Load\n5. Exit");
    //     int write = Console.ReadLine();
    // }

    // Display the user's choice back to them with the choice saved and loop it until they exit
    // DisplayMenu(_choice: int) : int
    // public int DisplayMenu()
    // {

    // }

    public int ShowMenu()
    {
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Exit");
        
        // save the user's choice
        int choice;
        // make sure they choose a valid choice
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
        {
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
        }
        return choice;
    }
}