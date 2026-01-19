using System;
using System.Collections;

class IEnumeratorDemo
{
    static void Main()
    {
        string[] names = { "C#", "Swift", "Kotlin" };

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        IEnumerator list = names.GetEnumerator();

        while (list.MoveNext())
        {
            Console.WriteLine(list.Current);
        }
    }
}