using System;
using static System.Console;

class PatternMatchingWithIf
{
    static void Main()
    {
        PrintStars(null);
        PrintStars("하나");
        PrintStars(5);
    }

    static void PrintStars(object o)
    {
        if (o is null)
        {
            return;
        }

        if (o is string)
        {
            return;
        }

        if (!(o is int number))
        {
            return;
        }
        WriteLine(new string('*', number));
    }
}