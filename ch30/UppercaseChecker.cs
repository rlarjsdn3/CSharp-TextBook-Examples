using System;
using System.Linq;

class UppercaseChecker
{
    static void Main()
    {
        string input = "HELLO";
        bool allUppercase = input.All(char.IsUpper);
        Console.WriteLine(allUppercase);
    }
}