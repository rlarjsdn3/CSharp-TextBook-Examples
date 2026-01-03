using System;

class Is
{
    static void Main()
    {
        object x = 1234;

        if (x is int n)
        {
            Console.WriteLine($"{n}은 정수형으로 변환이 가능합니다.");
        }
    }
}