namespace Scripture;
using System;

public class Word
{
    // create variables to store the individual word and a boolean to know if the word is hidden or not
    string word;
    bool hidden;

    // Constructor to initialize the word and hidden status
    public Word(string word)
    {
        this.word = word;
        hidden = false; // don't hide the word by default
    }

    // Getter and setter for hidden
    public bool IsHidden()
    {
        return hidden;
    }

    public void SetHidden(bool isHidden)
    {
        hidden = isHidden;
    }

    // Getter for the word
    public string GetWord()
    {
        return word;
    }
}