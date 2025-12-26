using System;
using System.Runtime.InteropServices.Swift;

class Point
{
    public int X { get; set; }
    public int Y  { get; set; }

    public void Move(int x, int y)
    {
        X = this.X + x;
        Y = this.Y + y;
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

class Program
{
    static void Main()
    {
        var point = new Point
        {
            X = 10,
            Y = 20
        };
        point.Move(10, 20);
        Console.WriteLine(point);
    }

    static void ChangePoint(Point point)
    {
        point.X = 100;
        point.Y = 200;
    }
}