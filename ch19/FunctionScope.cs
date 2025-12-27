using System;

class FunctionScope
{
    static string message = "전역 변수";

    static void ShowMessage()
    {
        string message = "지역 변수";
        Console.WriteLine(message);
    }

    static void Main()
    {
        ShowMessage();
        Console.WriteLine(message);
    }
}