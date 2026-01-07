using System;
using System.Linq;

class LinqSingle
{
    static void Main()
    {
        List<string> colors = new List<string> { "Red", "Green", "Blue" };
        string red = colors.Single(c => c == "Red");
        Console.WriteLine(red);

        string black = "";
        // System.InvalidOperationException: Sequence contains no matching element
        // black = colors.Single(c => c == "Black");
        Console.WriteLine(black);

        black = colors.SingleOrDefault(c => c == "Black");
        Console.WriteLine(black);
    }
}