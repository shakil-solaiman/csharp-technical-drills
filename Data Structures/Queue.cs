using System;


class QueueProgram
{
    static void Main(string[] args)
    {
        //Queue -- FIFO (First-In, First-Out).
        
        var queue = new Queue<string>();

        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");

        Console.WriteLine("\n\nQueue Declaration 01: After Enqueue - ");

        foreach(var print in queue)
        {
            Console.WriteLine(print);
        }

        queue.Dequeue();

        //queue.Peek();    // "second" (doesn't remove)

        Console.WriteLine("\n\nQueue Declaration 02: After Dequeue - ");

        foreach(var print in queue)
        {
            Console.WriteLine(print);
        }
    }
}