using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

//  creates the shape instances
        Square redSquare = new Square("Red", 6);
        shapes.Add(redSquare);

        Rectangle blueRectangle = new Rectangle("Blue", 3, 9);
        shapes.Add(blueRectangle);

        Circle greenCircle = new Circle("Green", 2);
        shapes.Add(greenCircle);

// loop through the shape list
        foreach (Shape shape in shapes)
        {
            string shapeColor = shape.GetColor();
            double shapeArea = shape.GetArea();

            Console.WriteLine($"The {shapeColor} shape has an area of {shapeArea}.");
        }
    }
}