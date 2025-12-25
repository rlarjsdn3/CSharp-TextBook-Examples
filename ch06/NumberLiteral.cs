using System;

class NumberLiteral
{
    static void Main()
    {
        Console.WriteLine("{0}", 1234); 
        Console.WriteLine("{0}", 0x1234);

        int octalValue = Convert.ToInt32("1234", 8); // 8진수를 10진수로 변환
        Console.WriteLine("{0}", octalValue);

        Console.ReadLine();
    }
}