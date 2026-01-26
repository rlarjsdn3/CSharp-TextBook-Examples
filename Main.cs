using System;

static class EnumerableExtensions
{
    public static void ForEach(
        this IEnumerable<int> source, 
        Action<int> action)
    {
        if (source == null)
        {
            throw new ArgumentException(nameof(source));
        }

        if (action == null)
        {
            throw new ArgumentException(nameof(action));
        }

        foreach (var item in source)
        {
            action(item);
        }
    }
}

public class Counter
{
    public event Action<int>? ValueChanged;

    private int _value;
    public int Value { get; private set; }
    public void Add(int delta)
    {
        _value += delta;
        ValueChanged?.Invoke(_value);
    }
}

public class Program
{
    static void Main()
    {
        var counter = new Counter();

        counter.ValueChanged += v => Console.WriteLine($"Changed: {v}");

        var deltas = new List<int> { 1, 2, -3, 5 };

        deltas.ForEach(x => counter.Add(x));
    }
}