using System;

class ReadLineCharacter
{
    static void Main()
    {
        Console.Write("문자를 입력하세요 : ");
        string input = Console.ReadLine();
        char c = Convert.ToChar(input);
        Console.WriteLine(c);
    }
}