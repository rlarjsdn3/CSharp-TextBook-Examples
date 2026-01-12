using System;

class AutoPropertyIntializer
{
    public static string Name { get; set; } = "길벗";
    static void Main()
    {
        Console.WriteLine(Name);
    }
}