using System;

public class Circle
{
    public int Radius { get; private set; } = 0;
    public Circle(int radius) => Radius = radius;
    public Circle MakeNew(int radius) => new Circle(radius);
}

class ImmutableType
{
    static void Main()
    {
        Circle circle = new Circle(10);
        Console.WriteLine($"{circle.Radius} - {circle.GetHashCode()}");

        circle = circle.MakeNew(20);
        Console.WriteLine($"{circle.Radius} - {circle.GetHashCode()}");
    }
}