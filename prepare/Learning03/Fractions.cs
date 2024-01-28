using System;

public class Fraction
{
    private int _up;
    private int _down;

    public Fraction()
    {
        _up = 1;
        _down = 1;
    }
    public Fraction(int wholeNumber)
    {
        _up = wholeNumber;
        _down = 1;
    }
    public Fraction(int top, int bottom)
    {
        _up = top;
        _down = bottom;
    }
    public string GetFractionString()
    {
        string text = $"{_up}/{_down}";
        return text;
    }
    public double GetDecimalValue()
    {
        return(double)_up / (double)_down;
    }
}