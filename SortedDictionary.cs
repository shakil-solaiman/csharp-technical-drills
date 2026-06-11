using System;


class SortedDictionaryProgram
{
    static void Main(string[] args)
    {
        //Sorted Dictionary / Sorted List -- Like Dictionary but sorted by key.
        // Iterates in alphabetical order

        Console.WriteLine("\n\nSorted Dictionary Declaration 01: ");

        var sortedDict = new SortedDictionary<string,int>
        {
            {"Mango", 5},
            {"Apple", 10},
            {"Lichi", 15}
        };

        foreach(var print in sortedDict)
        {
            Console.WriteLine(print);
        }

    }
}