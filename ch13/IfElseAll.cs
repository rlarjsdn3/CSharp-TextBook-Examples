using System;

class IfElseAll
{
    static void Main()
    {
        Console.Write("정수 입력: _\b");
        int a = Convert.ToInt32(Console.ReadLine());

        if (a % 2 == 0)
        {
            Console.WriteLine("짝수");
        }
        
        if (a % 2 != 0)
        {
            Console.WriteLine("홀수");
        }
        else
        {
            Console.WriteLine("짝수");
        }

        if (a % 3 == 0)
        {
            Console.WriteLine("3의 배수");
        } 
        else if (a % 5 == 0)
        {
            Console.WriteLine("5의 배수");
        }
        else if (a % 7 == 0)
        {
            Console.WriteLine("7의 배수");
        }
        else
        {
            Console.WriteLine("3, 5, 7의 배수가 아닌 수");
        }
    }
}