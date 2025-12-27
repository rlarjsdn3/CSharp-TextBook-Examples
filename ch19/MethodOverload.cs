using System;

class MethodOverload
{
    static void Hi()
    {
        Console.WriteLine("안녕하세요.");
    }

    static void Hi(string message)
    {
        Console.WriteLine(message);
    }

    static void Main()
    {
        Hi();
        Hi("반갑습니다.");
    }
}