using System;
using System.Globalization;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3 };
        var r = numbers.Where(number => number % 2 == 0).Sum();
        Console.WriteLine(r);
    }
}