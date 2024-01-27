using System;
// using System.Reflection.Metadata.Ecma335;
public class Fraction
{
    private int _top;
    private int _bottom;

// constructor with no parameters
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // constructor with one dividend parameter
    public Fraction(int dividend)
    {
        _top = dividend;
        _bottom = 1;

    }
    // constructor having both dividend and divisor parameters
    public Fraction(int dividend, int divisor)
    {
        _top = dividend;
        _bottom = divisor;
    }

    public string GetFractionString()
    {
        string fractionText = $"{_top} / {_bottom}";
        return fractionText;
    }
    public double GetDecimalValue()
    {
        return(double)_top / (double)_bottom;

    }
    
    
}