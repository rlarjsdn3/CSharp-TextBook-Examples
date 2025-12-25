using System;

class AdditionalOperator
{
    static void Main() {
        Console.WriteLine("Hello," + " World");
        Console.WriteLine("Hi " + " " + "everyone!");

        Console.WriteLine("123" + "456");
        Console.WriteLine("123" + 456);
        Console.WriteLine(123 + "456");
        Console.WriteLine(123 + 456);
        Console.WriteLine("123" + true);
        // Console.WriteLine("123" - 456);
    }
}