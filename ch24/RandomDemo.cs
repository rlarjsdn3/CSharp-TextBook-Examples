using System;

class RandomDemo
{
    static void Main()
    {
        Random random = new Random();
        Console.WriteLine(random.Next());
        Console.WriteLine(random.Next(5));
        Console.WriteLine(random.Next(1, 10));
    }
}