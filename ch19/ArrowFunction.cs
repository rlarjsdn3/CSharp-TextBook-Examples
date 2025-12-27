using System;

class ArrowFunction
{
    static void Main()
    {
        Hi();
        Multiply(2, 3);
    }

    static void Hi() => Console.WriteLine("안녕하세요.");
    static void Multiply(int a, int b) => Console.WriteLine(a * b);
}