using System;
using System.Linq;

class LinqAllAny
{
    static void Main()
    {
        bool[] completes = { true, true, true };
        Console.WriteLine(completes.All(c => c == true));

        completes[0] = false;
        Console.WriteLine(completes.Any(c => c == true))
;    }
}