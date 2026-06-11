using System;


class HashSetProgram
{
    static void Main(string[] args)
    {
        //Hash Set -- Unordered collection of unique values, O(1) lookups.

        Console.WriteLine("\n\nHash Set Declaration 01: ");

        var hSet = new HashSet<int> {5,2,6,3};

        hSet.Add(10);

        foreach(var print in hSet)
        {
            Console.WriteLine(print);
        }

        if(hSet.Contains(10))
        {
            Console.WriteLine("\nFound it!");
        }

        else
        {
            Console.WriteLine("\nSorry! Not found.");
        }
    }
}