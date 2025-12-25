using System;

class GetTypeDemo
{
    static void Main()
    {
        int i = 1234;
        string s = "Hello, World!";
        char c = 'A';
        double d = 3.14;
        object o = new Object();

        Console.WriteLine(i.GetType());
        Console.WriteLine(s.GetType());
        Console.WriteLine(c.GetType());
        Console.WriteLine(d.GetType());
        Console.WriteLine(o.GetType());
    }
}