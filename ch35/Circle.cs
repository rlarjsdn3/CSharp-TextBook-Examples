using System;

public class Circle
{
    private int _radius;

    public Circle(int radius)
    {
        _radius = radius;
    }

    public double GetArea()
    {
        // Console.WriteLine(Math.PI * _radius * _radius);
        return Math.PI * _radius * _radius;
    }
}

public class Program
{
    public static void Main()
    {
        var circle1 = new Circle(10);
        circle1.GetArea();

        var circle2 = new Circle(5);
        circle2.GetArea();
    }
}