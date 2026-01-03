using System;

class ClassNote
{
    static void Run()
    {
        Console.WriteLine("ClassNote 클래스의 Run 메서드");
    }

    static void Main()
    {
        Run();
        ClassNote.Run();
    }
}