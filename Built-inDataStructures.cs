internal class DataStructureProgram
{
    private static void Main(string[] args)
    {   

        //ARRAY 01
        Console.WriteLine("Array Declaration Method 01:");


        int[] numbers = new int[5];

        numbers[0] = 10;
        numbers[1] = 20;
        numbers[3] = 30;
        numbers[4] = 40;

        foreach(int number in numbers)
        {
            Console.WriteLine(number);
        }


        //ARRAY 02

        Console.WriteLine("\n\nArray Declaration Method 02: ");

        int[] initialized = {50,60,70,80,100};

        for(int i=0; i<initialized.Length; i++)
        {
            Console.WriteLine(initialized[i]);
        }


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