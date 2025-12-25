using System;

class LogicalOperator
{
    static void Main()
    {
        var i = 3;
        var j = 5;
        var r = false;

        r = (i == 3) && (j == 5);
        Console.WriteLine(r);

        r = (i != 3) || (j == 3);
        Console.WriteLine(r);

        r = (i >= 5);
        Console.WriteLine("{0}", !r);

        Console.WriteLine(false && true);
        Console.WriteLine((1 == 1) || (1 != 1));
        Console.WriteLine(!(1 == 1));

    }
}