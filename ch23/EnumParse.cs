using System;

class EnumParse
{
    static void Main()
    {
        string color = "Red";

        Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);
        Console.WriteLine("Red");
        Console.ResetColor();
    }
}