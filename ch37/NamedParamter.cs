using System;

class NamedParamter
{
    static int Sum(int first = 10, int second = 20)
    {
        return first + second;
    }

    static void Main()
    {
        Console.WriteLine(Sum());
        Console.WriteLine(Sum(3, 5));
        Console.WriteLine(Sum(first: 3, 5));
        Console.WriteLine(Sum(first: 3, second: 5));
    }
}