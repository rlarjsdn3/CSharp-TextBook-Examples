using System;
using System.Linq;

class LinqTakeSkip
{
    static void Main()
    {
        var data = Enumerable.Range(0, 100);
        
        var r1 = data.Take(5);
        foreach (var e in r1)
        {
            Console.Write($"{e}\t");
        }
        Console.WriteLine();

        var r2 = data.Skip(10).Take(5);
        foreach (var e in r2)
        {
            Console.Write($"{e}\t");
        }
        Console.WriteLine();
    }
}