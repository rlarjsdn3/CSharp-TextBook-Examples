using System;

class ParamsFunctionDemo
{
    static int Sum(params int[] numbers)
    {
        int total = 0;
        foreach (var number in numbers)
        {
            total += number;
        }
        return total;
    }

    static void Main()
    {
        int result = Sum(1, 2, 3, 4);
        Console.WriteLine(result);
    }
}