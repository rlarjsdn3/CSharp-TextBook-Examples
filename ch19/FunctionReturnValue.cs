using System;

class FunctionReturnValue
{
    static int SquareFunction(int x)
    {
        int r = x * x;
        return r;
    }

    static void Main()
    {
        int r = SquareFunction(2);
        Console.WriteLine(r);
    }
}