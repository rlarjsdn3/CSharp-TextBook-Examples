using System;

public class Original { }

public static class OriginalExtensions
{
    public static void NewMethod(this Original original)
    {
        Console.WriteLine("This is an extension method.");
    }
}

class ExtensionMethodNote
{
    static void Main()
    {
        (new Original()).NewMethod();
    }
}