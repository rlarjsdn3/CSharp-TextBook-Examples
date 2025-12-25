using System;

class ReadLineInteger
{
    static void Main()
    {
        Console.Write("정수를 입력하세요 : ");
        string input = Console.ReadLine();
        int number = Convert.ToInt32(input);
        Console.WriteLine($"{number} - {number.GetType()}");
    }
}