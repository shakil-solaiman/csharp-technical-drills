using System;


class StackProgram
{
    static void Main(string[] args)
    {
        //Stack -- LIFO (Last-In, First-Out).

        Console.WriteLine("\n\nStack Declaration 01: ");


        var stack = new Stack<int>();

        stack.Push(5);
        stack.Push(10);
        stack.Push(15);
        stack.Push(20);

        stack.Pop();

        //stack.Peek(); // 1 (doesn't remove)

        foreach(var print in stack)
        {
            Console.WriteLine(print);
        }
    }
}