using System;

class TypeConversion
{
    static void Main()
    {
        double d = 12.34;
        int i = 1234;

        d = i;
        Console.WriteLine("암시적 형식 변환 = " + d);

        d = 12.34;
        i = (int)d;
        Console.WriteLine("명시적 형식 변환 = " + i);

        string s = "";
        s = Convert.ToString(d);
        Console.WriteLine("형식 변환 = " + s);
    }
}