using System;


class DictionaryProgram
{
    static void Main(string[] args)
    {
        //Dictionary 01

        Console.WriteLine("\n\nValues of Dictionary 01:");

        var library = new Dictionary<string,int>();

        library["Apple"] = 5;
        library["Lichi"] = 10;
        library["Mango"] = 15;

        foreach(var lib in library)
        {
            Console.WriteLine(lib);
        }


        // Use TryGetValue inside an IF statement
        if (library.TryGetValue("Apple", out int val))
        {
            Console.WriteLine($"\n\nFound it! The value of apple is: {val}\n\n");
        }
        else
        {
            Console.WriteLine("Key not found in the dictionary.\n\n");
        }


        //Dictionary 02

        Console.WriteLine("\nValues of Dictionary 02:");


        var dic = new Dictionary<String,int>
        {
            {"Coconut", 150},
            {"Jackfruit", 200},
            {"Mango", 80}
        };

        foreach(var print in dic)
        {
            Console.WriteLine(print);
        }

    }
}