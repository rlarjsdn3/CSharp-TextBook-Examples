using System;
using System.Diagnostics;
using System.Linq;

class LinqDistinct
{
    static void Main()
    {
        var data = Enumerable.Repeat(3, 5);
        var result = data.Distinct();
        result.Print();

        int[] arr = { 2, 2, 3, 3, 3 };
        result = arr.Distinct();
        result.Print();
    }
}

static class E
{
    public static void Print<TSource>(this IEnumerable<TSource> source)
    {
        foreach (var e in source)
        {
            Console.Write($"{e}\t");
        }
        Console.WriteLine();
    }
}