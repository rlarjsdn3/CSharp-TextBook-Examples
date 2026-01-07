using System;
using System.Linq;

class ContainsNumber
{
    static void Main()
    {
        string input = "Hello123";
        bool containsNumber = input.Any(char.IsDigit);
        Console.WriteLine(containsNumber);
    }
}