namespace Scripture;
using System;

class Program
{
    static void Main(string[] args)
    {
        // reference the Scripture class and store the scripture in a variable
        string text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Console.WriteLine($"{text}");

        Reference reference = new Reference("John", 3, 16, 16);

        Scripture scripture = new Scripture(reference, text);
        
        do
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine().ToLower();
            if (input == "quit")
                break;
            else if (input == "")
                scripture.HideWords();
            else
                Console.WriteLine("Invalid input. Press Enter to continue or type 'quit' to exit.");
        } while (scripture.IsAnyWordHidden());

        Console.WriteLine("All words are hidden. Program ended.");
    }
}