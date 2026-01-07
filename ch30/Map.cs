using System;
using System.Linq;

class Map
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        
        var nums = numbers.Select(n => n * n);
        
        foreach (var num in nums)
        {
            Console.WriteLine(num);
        }
    }
}