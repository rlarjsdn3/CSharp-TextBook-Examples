using System;

class ParamterValue
{
    static void Do(int num)
    {
        num = 20;
        Console.WriteLine($"[2] {num}");
    }

    static void Main()
    {
        int num = 10;
        Console.WriteLine($"[1] {num}");

        Do(num);

        Console.WriteLine($"[3] {num}");
    }
}