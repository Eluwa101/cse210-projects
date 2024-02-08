// the rectangle class
public class Rectangle : Shape
{
    private double _length;
    private double _width;

// the rectangle constructor
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

// overrides the Getarea in the super shape class
    public override double GetArea()
    {
        return _length * _width;
    }
}