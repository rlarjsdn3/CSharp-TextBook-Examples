using System;
using System.Text;

class StringBuilderPerformance
{
    static void Main()
    {
        DateTime start = DateTime.Now;

        var msg = new StringBuilder();
        for (int i = 0; i < 10_000; i++)
        {
            msg.Append("안녕하세요.");
        }

        DateTime end = DateTime.Now;
        double exec = (end - start).TotalMilliseconds;
        Console.WriteLine(exec);
        
    }
} 