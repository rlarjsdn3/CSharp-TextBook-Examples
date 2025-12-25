using System;

class IntToByte
{
    static void Main()
    {
        int x = 255;
        byte y = (byte)x;
        
        Console.WriteLine($"{x} -> {y}");
    }
}