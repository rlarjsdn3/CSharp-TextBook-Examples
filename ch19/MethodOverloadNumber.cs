using System;

class MethodOverloadNumber
{
    static void GetNumber(int number)
    {
        Console.WriteLine($"Int32 : {number}");
    }

    static void GetNumber(long number)
    {
        Console.WriteLine($"Long : {number}");
    }

    static void Main()
    {
        GetNumber(100);
        GetNumber(1_000L);
    }
}