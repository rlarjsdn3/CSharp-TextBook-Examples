using System;

class FunctionParameter
{
    static void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    static void Main()
    {
        ShowMessage("매개변수");
        ShowMessage("Parameter");
    }
}