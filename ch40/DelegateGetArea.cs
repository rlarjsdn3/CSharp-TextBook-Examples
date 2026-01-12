using System;

class DelegateGetArea
{
    delegate double GetAreaPointer(int r);

    static double GetArea(int r)
    {
        return 3.14 * r * r;
    }

    static void Main()
    {
        GetAreaPointer pointer = new GetAreaPointer(GetArea);

        var result = pointer.Invoke(10);
        Console.WriteLine(result);
    }
}