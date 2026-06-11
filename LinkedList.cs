using System;


class LinkedListProgram
{
    static void Main(string[] args)
    {
        //LinkedList -- Doubly-linked list; efficient insertions/deletions anywhere.

        Console.WriteLine("\n\nLinked list declaration 01: ");

        var linkedList = new LinkedList<int>();

        linkedList.AddLast(10);
        linkedList.AddFirst(5);

        linkedList.AddAfter(linkedList.First, 15);


        foreach(var number in linkedList)
        {
            Console.WriteLine(number);
        }
    }
}