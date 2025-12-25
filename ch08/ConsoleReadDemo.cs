using System;

class ConsoleReadDemo
{
    static void Main()
    {
        int x = Console.Read();
        Console.WriteLine(x);
        Console.WriteLine(Convert.ToChar(x));
    }
}