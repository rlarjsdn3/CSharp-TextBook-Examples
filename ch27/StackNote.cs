using System;
using System.Collections;

class StackNote
{
    static void Main()
    {
        Stack stack = new Stack();

        stack.Push("첫 번째");
        stack.Push("두 번째");
        stack.Push("세 번째");

        Console.WriteLine(stack.Peek());
        Console.WriteLine(stack.Peek());

        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());

        try
        {
            Console.WriteLine(stack.Pop());
        } 
        catch (Exception ex)
        {
            Console.WriteLine($"예외 내용 : {ex.Message}");
        }
    }
}