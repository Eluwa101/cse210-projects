// the square class
public class Square : Shape
{
    private double _side;

// the constructor for square
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

// over rides the Getarea
    public override double GetArea()
    {
        return _side * _side;
    }
}