using System;

class OutVariableDemo
{
    static void Main()
    {
        if (DateTime.TryParse("2025-12-25", out DateTime xmas))
        {
            Console.WriteLine(xmas);
        }
    }
}