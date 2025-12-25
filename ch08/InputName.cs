using System;

class InputName
{
    static void Main()
    {
        Console.Write("이름을 입력하세요 => ");
        string name = Console.ReadLine();
        Console.WriteLine("안녕하세요. {0}님!", name);
    }
}