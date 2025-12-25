using System;

class BinaryString
{
    static void Main()
    {
        byte x = 10;  // 0000 1010

        Console.WriteLine(  
            $"10진수 : {x} -> 2진수 : {Convert.ToString(x, 2).PadLeft(8, '0')}"
        );
    }
}