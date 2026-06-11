using System;


class ListProgram
{
    static void Main(string[] args)
    {
        //LIST 01
        Console.WriteLine("\n\nList Declaration Method 01: ");

        List<int> listNumber = new List<int> {5,10,15,20};

        foreach(var print in listNumber)
        {
            Console.WriteLine(print);
        }

        //LIST 02
        Console.WriteLine("\n\nList Declaration Method 02: ");

        var listing = new List<int> {30,40,80,160};

        listing.Add(4);
        listing.Add(9);
        listing.Add(15);

        listing.Remove(9);


        foreach(var print in listing)
        {
            Console.WriteLine(print);
        }

        
        //listing.Contains(3); // true

        if (listing.Contains(3))
        {
            Console.WriteLine("\nSuccess! The number 3 was found in the data structure.");
        }
        else
        {
            Console.WriteLine("\nError: The number 3 is missing.");
        }
    }
}