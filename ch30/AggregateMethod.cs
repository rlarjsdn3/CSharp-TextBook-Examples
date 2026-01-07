using System;
using System.Linq;

class AggregateMethod
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3 };

        int sumWithSeed = 
            numbers.Aggregate(0, (accumulator, current) => accumulator + current);
        
        int sumWithoutSeed = 
            numbers.Aggregate((accumulator, current) => accumulator + current);

        Console.WriteLine($"Sum with seed(0) : {sumWithSeed}");
        Console.WriteLine($"Sum without seed : {sumWithoutSeed}");
    }
}