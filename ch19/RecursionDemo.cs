using System;

class RecursionDemo
{
    static int Fact(int n)
    {
        return (n > 1) ? n * Fact(n - 1) : 1;
    }

    static int Factorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        return n * Factorial(n - 1);
    }

    static int FactorialFor(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    static void Main()
    {
        Console.WriteLine(FactorialFor(4));
        Console.WriteLine(Fact(4));
        Console.WriteLine(Factorial(4));
    }
}