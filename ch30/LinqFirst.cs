using System;
using System.Linq;

class LinqFirst
{
    static void Main()
    {
        List<string> colors = new List<string> { "Red", "Blue", "Green" };
        var result = colors.First(c => c == "Green");
        Console.WriteLine(result);

        // System.InvalidOperationException: Sequence contains no matching element
        // result = colors.First(c => c == "Black");

        result = colors.FirstOrDefault(c => c == "Black");
        Console.WriteLine(result);
    }
}