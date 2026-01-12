using System;

class ActionDemo
{
    static void Main()
    {
        Action<string> printf = Console.WriteLine;
        printf("메서드 대신 호출");
    }
}