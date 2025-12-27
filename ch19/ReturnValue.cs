using System;

class ReturnValue
{
    static string GetString()
    {
        return "반환값(Return Value)";
    }

    static void Main()
    {
        string returnValue = GetString();
        Console.WriteLine(returnValue);
    }
}