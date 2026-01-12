using System;

class OptionalParameter
{
    static int Add(int a, int b = 1) => a + b;

    static void Main()
    {
        Console.WriteLine(Add(3));
        Console.WriteLine(Add(3, 5));
    }
}