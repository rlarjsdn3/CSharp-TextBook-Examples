using Systeml;

class UnsignedInteger
{
    static void Main()
    {
        byte iByte = 255;
        ushort iUInt16 = 65535;
        uint iUInt32 = 4294967295;
        ulong iUInt64 = 18446744073709551615;

        Console.WriteLine("8비트  byte : {0}", iByte);
        Console.WriteLine("16비트 ushort : {0}", iUInt16);
        Console.WriteLine("32비트 uint : {0}", iUInt32);
        Console.WriteLine("64비트 ulong : {0}", iUInt64);
    }
}