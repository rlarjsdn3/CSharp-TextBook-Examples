using System;
using System.Linq;

class Filter
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        var nums = numbers.Where(n => n % 2 == 0 && n > 3);

        foreach (var n in nums)
        {
            Console.WriteLine(n);
        }
    }
}