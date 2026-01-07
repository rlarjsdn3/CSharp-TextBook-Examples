using System;
using System.Linq;

class LinqOrderBy
{
    static void Main()
    {
        string[] colors = { "Red", "Green", "Blue" };
        IEnumerable<string> sortedColors = colors.OrderBy(c => c);
        foreach (var c in sortedColors)
        {
            Console.WriteLine(c);
        }

        sortedColors = colors.OrderByDescending(c => c);
        foreach (var c in sortedColors)
        {
            Console.WriteLine(c);
        }
    }
}