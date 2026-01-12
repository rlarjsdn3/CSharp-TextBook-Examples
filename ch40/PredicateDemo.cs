using System;

class PredicateDemo
{
    static void Main()
    {
        Predicate<string> isNullOrEmpty = String.IsNullOrEmpty;
        isNullOrEmpty("Not Null");

        Predicate<Type> isPrimitive = t => t.IsPrimitive;
        isPrimitive(typeof(int));

        var numbers = FindNumbers(f => f % 3 == 0);
        numbers.ToList().ForEach(n => { Console.WriteLine(n); });
    }

    static IEnumerable<int> FindNumbers(Predicate<int> predicate)
    {
        for (int i = 0; i < 100; i++)
        {
            if (predicate(i))
            {
                yield return i;
            }
        }
    }
}