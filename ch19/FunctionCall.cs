using System;

class FunctionCall
{
    static void Hi()
    {
        Console.WriteLine("안녕하세요.");
    }

    static void Main()
    {
        Hi(); Hi(); Hi();
    }
}