using System;

class ForFactorial
{
    static void Main()
    {
        int factorial = 0;

        for (int i = 1; i <= 4; i++)
        {
            Console.Write($"{i}! -> ");
            factorial = 1;
            for (int j = 1; j <= i; j++)
            {
                factorial *= j;
            }
            Console.WriteLine($"{factorial}");
        }
    }
}