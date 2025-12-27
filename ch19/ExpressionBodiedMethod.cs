using System;
using System.Collections;

class ExpressionBodiedMethod
{
    static void Main()
    {
        Log("함수 축약");
        Console.WriteLine(IsSame("A", "B"));
    }

    static void Log(string message) => Console.WriteLine(message);
    static bool IsSame(string a, string b) => a == b; 
}