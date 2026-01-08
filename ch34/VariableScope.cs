using System;

class VariableScope
{
    static string globalVariable = "전역 변수(필드)";

    static void Main()
    {
        string localVariable = "지역 변수";
        Console.WriteLine(globalVariable);
        Console.WriteLine(localVariable);
        Test();
    }

    static void Test() => Console.WriteLine(globalVariable);
}