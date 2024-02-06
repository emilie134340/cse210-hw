using System;
using System.Xml.Schema;

class Fraction{
    private int top;
    private int bottom;

    public Fraction()
    {
        top = 1;
        bottom = 1;
    }

    public Fraction(int WholeNumber)
    {
        top = WholeNumber;
        bottom = 1;
    }

    // constructor with two params
    public Fraction(int top, int bottom)
    {
        this.top = top;
        this.bottom = bottom;
    }

    // // getter for top
    // public int GetTop()
    // {
    //     return top;
    // }

    // // setter for top
    // public void SetTop(int NewTop)
    // {
    //     top = NewTop;
    // }

    // // getter for bottom
    // public int GetBottom()
    // {
    //     return bottom;
    // }

    // // setter for bottom 
    // public void SetBottom(int NewBottom)
    // {
    //     bottom = NewBottom;
    // }

    public string GetFractionString()
    {
        string text = $"{top}/{bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)top / (double)bottom;
    }
}