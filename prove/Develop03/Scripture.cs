namespace Scripture;
using System;
using System.ComponentModel.DataAnnotations;

public class Scripture
{
    // Use the reference class to make a display function that includes the text and the reference
    Reference reference; 
    // store the text variable in a string
    string text;
    // a constructor for Scripture that uses Reference and the text variable
    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        this.text = text;
    }
    // Display the scripture, to be called in Program
    public void Display()
    {
        Console.WriteLine($"{reference} - {text}");
    }
    // a function to hide certain words in the text, using the indexes

    public void HideWords()
    {
        // foreach (word in words)
        // {
        //     return;
        // }
    }

    public bool IsAnyWordHidden()
    {
        return true; // change
    }
}