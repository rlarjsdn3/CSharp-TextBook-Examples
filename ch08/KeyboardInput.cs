using System;

class KeyboardInput
{
    static void Main()
    {
        Console.WriteLine("아무키나 누르세요.");
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        Console.WriteLine("{0}", keyInfo.Key);
        Console.WriteLine("{0}", keyInfo.KeyChar);
        Console.WriteLine("{0}", keyInfo.Modifiers);
        if (keyInfo.Key == ConsoleKey.Q)
        {
            Console.WriteLine(" Q를 입력하셨군요...");
        }
    }
}