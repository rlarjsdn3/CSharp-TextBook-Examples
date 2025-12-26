using System;

class PositivieNegativeZero
{
    static void Main()
    {
        int number = -10;

        if (number > 0)
        {
            Console.WriteLine($"{number}는 양수입니다.");
        }
        else if (number < 0)
        {
            Console.WriteLine($"{number}는 음수입니다.");
        } 
        else
        {
            Console.WriteLine($"{number}는 0입니다.");
        }
    }
}