using System;
using System.ComponentModel.Design;

public class Fraction
{
    private int top;
    private int bottom;

    //Constructors
    public Fraction()
    {
        top = 1;
        bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        top = wholeNumber;
        bottom = 1;
    }
    public Fraction(int Top, int Bottom)
    {
        top = Top;
        bottom = Bottom;
    }

    //Getters and Setters
    public int GetTop()
    {
        return top;
    }
    public void SetTop(int Top)
        {
            top = Top;
        }
    public int GetBottom()
    {
        return bottom;
    }
    public void SetBottom(int Bottom)
    {
        bottom = Bottom;
    }

    public string GetFractionString()
    {
        string fraction = $"{top}/{bottom}";
        return fraction;
    }
    public double GetDecimalValue()
    {
        double Decimal = (double) top / bottom; //remember to put the double again for this operation
        return Decimal;
    }
}