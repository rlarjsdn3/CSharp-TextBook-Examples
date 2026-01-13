using System;

class Point
{
    public readonly int x; // readonly 필드
    public readonly int y; 

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public Point MoveBy(int dx, int dy)
    {
        return new Point(x + dx, y + dy);
    }
}

class FunctionalProgramming
{
    static void Main()
    {
        var p = (new Point(0, 0)).MoveBy(10, 10).MoveBy(20, 20).MoveBy(30, 30);
        Console.WriteLine($"X : {p.x}, Y : {p.y}");
    }
}