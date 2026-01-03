using System;
using System.Collections;

class QueueNote
{
    static void Main()
    {
        var queue = new Queue();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());

        // System.InvalidOperationException: Queue empty.
        Console.WriteLine(queue.Dequeue());
    }
}