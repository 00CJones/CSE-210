using System;

public class Square : Shape
{
    private double length;
    private double width;
    

    public Square(string color, double length, double width) : base(color)
    {
        this.length = length;
        this.width = width;
    }
    public override double GetArea()
    {
        double area = length * width;
        return area;
    }
}