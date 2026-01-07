using System;

class ReadOnlySpanDemo
{
    static void Main()
    {
        string text = "Hello, Span!";

        ReadOnlySpan<char> readOnlySpan = text.AsSpan();

        Console.WriteLine(readOnlySpan[0]);

        // readOnlySpan[0] = "h";
    }
}