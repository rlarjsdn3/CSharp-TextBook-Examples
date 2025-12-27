using System;

class MaxMinFunction
{
    static int Max(int x, int y)
    {
        return (x > y) ? x : y;
    }

    static int Min(int x, int y)
    {
        return (x > y) ? y : x;
    }

    static void Main()
    {
        Console.WriteLine(Max(3, 5));
        Console.WriteLine(Min(-1, -3));
    }
}