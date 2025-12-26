using System;

class ReturnPreview
{
    static void Main()
    {
        Console.WriteLine("프로그램 시작");

        bool exitProgram = true;

        if (exitProgram)
        {
            Console.WriteLine("조건을 만족하여 프로그램을 종료합니다.");
            return;
        }

        Console.WriteLine("조건이 충족되지 않아 프로그램을 종료합니다.");
    }
}