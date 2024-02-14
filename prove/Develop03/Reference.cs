namespace Scripture;
using System;

public class Reference
{
    // make variables to store components of the Reference
    private string book;
    private int chapter;
    private int verseStart;
    private int verseEnd;

    // Constructor for reference
    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verseStart;
        this.verseEnd = verseEnd;

    }

    // convert the reference to a string that can be used throughout the program
    public override string ToString()
    {
        if (verseStart == verseEnd)
        {
            return $"{book} {chapter}:{verseStart}";
        }
        else
        {
            return $"{book} {chapter}:{verseStart}-{verseEnd}";
        }
}
}