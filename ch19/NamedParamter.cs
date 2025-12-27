using System;

class NamedParamter
{
    static void Sum(int first, int second)
    {
        Console.WriteLine(first + second);
    }

    static void Main()
    {
        Sum(10, 20);
        Sum(first: 10, second: 20);
        Sum(second: 20, first: 10);
    }
}