// the shape super class
public abstract class Shape
{
    private string _shapeColor;

    public Shape(string color)
    {
        _shapeColor = color;
    }


    public string GetColor()
    {
        return _shapeColor;
    }

    public void SetColor(string color)
    {
        _shapeColor = color;
    }

    public abstract double GetArea();
}