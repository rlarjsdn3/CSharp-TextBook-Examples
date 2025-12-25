using System;

class ReadLineRealNumber
{
    static void Main()
    {
        Console.Write("실수를 입력하세요 : ");
        string input = Console.ReadLine();
        double PI = Convert.ToDouble(input);
        Console.WriteLine(PI);
    }
}