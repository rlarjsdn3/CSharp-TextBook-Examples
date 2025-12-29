using System;

class ConsoleColorDemo
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Blue");
        Console.ResetColor();

        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Red");
        Console.ResetColor();
    }
}