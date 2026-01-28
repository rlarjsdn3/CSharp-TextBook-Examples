using System;

static class DynamicExtensionMethod
{
    static string PreDotNet(this string str) => $"...{str}";

    static void Main()
    {
        string s1 = "DotNet";
        Console.WriteLine(s1.PreDotNet());

        // The following line would cause a runtime binder exception
        dynamic d1 = "Korea";
        Console.WriteLine(d1.PreDotNet());
    }
}