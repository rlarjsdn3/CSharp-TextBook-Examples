using System;

class FunctionOverload
{
    static void Multi()
    {
        Console.WriteLine("안녕하세요.");
    }

    static void Multi(string message)
    {
        Console.WriteLine(message);
    }
    
    static void Multi(string message, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(message);
        }
    }

    static void Main()
    {
        Multi();
        Multi("반갑습니다.");
        Multi("또 만나요!", 3);
    }
}