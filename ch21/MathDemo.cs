using System;

class MathDemo
{
    static void Main()
    {
        Console.WriteLine(Math.PI);
        Console.WriteLine(Math.E);
        Console.WriteLine(Math.Abs(-10));
        Console.WriteLine(Math.Max(3, 5));
        Console.WriteLine(Math.Min(3, 5));
        Console.WriteLine(Math.Pow(2, 10));
        Console.WriteLine(Math.Round(3.15, 1));
        Console.WriteLine(Math.Round(1.1F));
        Console.WriteLine(Math.Ceiling(1.1F));
        Console.WriteLine(Math.Floor(1.1F));
        Console.WriteLine(Math.Sqrt(9));
        Console.WriteLine((new Random()).Next());
    }
}