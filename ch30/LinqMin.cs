using System;
using System.Collections.Generic;
using System.Linq;

class LinqMin 
{
    static void Main()
    {
        var numbers = new List<double> { 1.1, 2.2, 3.3 };

        double min = numbers.Min();

        Console.WriteLine($"{nameof(numbers)} 컬렉션의 최소값 : {min:.00}");
    }
}