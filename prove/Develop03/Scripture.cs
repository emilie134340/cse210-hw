namespace Scripture;
using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        InitializeWords(text);
    }
    // uses the text from the Program class, turns words into a list
    private void InitializeWords(string text)
    {
        words = new List<Word>();
        string[] wordArray = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string wordStr in wordArray)
        {
            words.Add(new Word(wordStr));
        }
    }

    // Display the scripture, to be called in Program
    public void Display()
    {
        Console.WriteLine($"{reference}: ");
        foreach (Word word in words)
        {
            Console.Write(word.IsHidden() ? new string('_', word.GetWord().Length) : word.GetWord());
            Console.Write(" ");
        }
        Console.WriteLine();
    }

    // a function to hide certain words in the text, using the indexes
    public void HideWords()
    {
        Random random = new Random();
        for (int i = 0; i < 3; i++)
        {
            if (!AreAllWordsHidden())
            {
                int index = 0;
                while (words[index].IsHidden())
                {
                    index = random.Next(words.Count);
                } 

                words[index].SetHidden(true);
            }
        }
    }

    // if the scripture contains underscores, the word is hidden
    public bool AreAllWordsHidden()
    {
        foreach (Word word in words)
        {
            if (!word.IsHidden())
            {
                return false; // If any word is not hidden, return false
            }
        }
        return true; // If all words are hidden, return true
    }
    
}
