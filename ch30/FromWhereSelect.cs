using System;
using System.Linq;

class FromWhereSelect
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        var evenNumbers = 
            from n in arr
            where n % 2 == 0
            select n;
        
        foreach (var n in evenNumbers)
        {
            Console.WriteLine(n);
        }
    }
}