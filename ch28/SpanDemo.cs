using System;

class SpanDemo
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        Span<int> span = numbers;

        span[0] = 10;
        Console.WriteLine(string.Join(", ", numbers)); 
    }
}