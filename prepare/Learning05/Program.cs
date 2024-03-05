namespace Shapes;
using System;

class Program
{
    static void Main(string[] args)
    {
        var shapes = new List<Shape> {
            new Square("blue", 22),
            new Rectangle("Blue", 4, 5),
            new Circle("Yellow", 6)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}.");
        }

    }
}