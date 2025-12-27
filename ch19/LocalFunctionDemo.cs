using System;

class LocalFunctionDemo
{
    static void Main()
    {
        void Display(string message)
        {
            Console.WriteLine(message);
        }

        Display("로컬 함수");
    }
}