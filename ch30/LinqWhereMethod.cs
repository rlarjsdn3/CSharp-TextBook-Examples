using System;
using System.Linq;

class LinqWhereMethod
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        var q = numbers.Where(n => n % 2 == 1);

        foreach (var n in q)
        {
            Console.WriteLine(n);
        }
    }
}