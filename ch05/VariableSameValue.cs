using System;

class VariableSameValue
{
    static void Main()
    {
        int a, b, c;

        a = b = c = 10;

        Console.WriteLine("{0}, {1}, {2}", a, b,c);
    }
}