using System;

class ConstructorDemo
{
    public ConstructorDemo()
    {
        Console.WriteLine("생성자가 호출되었습니다.");
    }

    static void Main()
    {
        ConstructorDemo cd = new ConstructorDemo();
    }
}