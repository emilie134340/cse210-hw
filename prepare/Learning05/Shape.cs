namespace Shapes;
using System;

abstract class Shape{
    protected string color;

    public string GetColor()
    {
        return color;
    }

    public void SetColor(string color)
    {
        this.color = color;
    }

    public Shape(string color)
    {
        this.color = color;
    }

    public abstract double GetArea();
}