using System;

class LogicalAnd
{
    static void Main()
    {
        Console.WriteLine($"true && true   : {true && true}");
        Console.WriteLine($"true && false  : {true && false}");
        Console.WriteLine($"false && true  : {false && true}");
        Console.WriteLine($"false && false : {false && false}");
    }
}