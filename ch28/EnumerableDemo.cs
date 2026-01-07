using System;
using System.Linq;

class EnumerableDemo
{
    static void Main()
    {
        var numbers = Enumerable.Range(1, 5);
        foreach (var n in numbers)
            Console.Write("{0}\t", n);
        Console.WriteLine();

        var sameNumbers = Enumerable.Repeat(-1, 5);
        foreach (var n in sameNumbers) 
            Console.Write("{0}\t", n);
        Console.WriteLine();
    }
}