using System;

class VarInput
{
    static void Main()
    {
        var s = Console.ReadLine();
        var c = Convert.ToChar(Console.Read());
        Console.WriteLine($"{s} : {s.GetType()}, {c} : {c.GetType()}");
    }
}