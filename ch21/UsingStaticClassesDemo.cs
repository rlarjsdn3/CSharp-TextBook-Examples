using System;
using static System.Console;
using static System.Math;

class UsingStaticClassesDemo
{
    static void Main()
    {
        WriteLine(Math.Pow(2, 10));

        WriteLine(Pow(2, 10));
        WriteLine(Max(3, 5));
        WriteLine(nameof(System));
    }
}