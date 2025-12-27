using System;

class ArrayOne4
{
    static void Main()
    {
        int[] intArray = { 1, 2, 3 };

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{i}번째 인덱스 : {intArray[i]}");
        }

        foreach (var intValue in intArray)
        {
            Console.WriteLine("{0}", intValue);
        }
    }
}