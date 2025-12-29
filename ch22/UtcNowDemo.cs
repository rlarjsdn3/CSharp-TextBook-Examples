using System;

class UtcNowDemo
{
    static void Main()
    {
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.UtcNow);
        Console.WriteLine(DateTime.UtcNow.ToLocalTime());
        Console.WriteLine(DateTimeOffset.UtcNow);
        Console.WriteLine(DateTimeOffset.UtcNow.ToLocalTime());
        Console.WriteLine(DateTimeOffset.Now.DateTime);
    }
}