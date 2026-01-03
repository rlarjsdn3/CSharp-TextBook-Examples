using System;

class Program
{
    static void Main()
    {
        int i = 123;
        object o = i; // 박싱

        int n = Convert.ToInt32(o);
    }
}