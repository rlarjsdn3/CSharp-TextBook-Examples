using System;

class Money
{
    public Money() : this(1_000) { }
    public Money(int money) => Console.WriteLine("Money : {0:#,###}", money);
}

class Program
{
    static void Main()
    {
        var basic = new Money();
        var bonus = new Money(2_000);
    }
}