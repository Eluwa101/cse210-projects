// the circle class
public class Circle : Shape
{
    private double _radius;
    
// the circle constructor
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

// overiding the GetArea in the shsape super class
    public override double GetArea()
    {
        double area =  _radius * _radius * Math.PI;
        return Math.Round(area);
    }
}