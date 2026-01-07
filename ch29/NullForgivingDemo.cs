using System;

class NullForgivingDemo
{
    static void PrintName(string? name) => Console.WriteLine(name!.ToUpper());

    static void Main()
    {
        string? name;
        // PrintName(name);

        name = "김문어";
        PrintName(name);
    }
}