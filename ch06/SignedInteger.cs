using System;

class SignedInteger
{
    static void Main()
    {
        sbyte iSByte = 127;
        short iInt16 = 32767;
        int iInt32 = 2147483647;
        long iInt64 = 9223372036854775807;

        Console.WriteLine("8비트  byte : {0}", iSByte);
        Console.WriteLine("16비트 short : {0}", iInt16);
        Console.WriteLine("32비트 int : {0}", iInt32);
        Console.WriteLine("64비트 long : {0}", iInt64);
    }
}