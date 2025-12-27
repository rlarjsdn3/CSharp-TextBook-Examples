using System;

class RecursionPower
{
    static int MyPower(int num, int cnt)
    {
        if (cnt == 0)
        {
            return 1;
        }
        return num * MyPower(num, --cnt);
    }

    static void Main()
    {
        Console.WriteLine(MyPower(2, 8));
    }
}