using System;


internal class DataStructureProgram
{
    private static void Main(string[] args)
    {   

        //STRING

        Console.WriteLine("STRING PRACTICE:\n");

        Console.WriteLine("Declaration type 01 using for loop:");
        
        string[] nameList = new string[3];

        nameList[0] = "Sadia";
        nameList[1] = "Salam";
        nameList[2] = "Alex";

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(nameList[i]);
        }

        Console.WriteLine("\nDeclaration type 02 using for loop:");

        string[] names = {"Solaiman", "Shakil", "Tarek Rahman", "Hadi"};

        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }

        Console.WriteLine("\nDeclaration type 03 using for each loop:");

        string[] newName = new string[] { "Bill Gates", "Donald Tramp", "Solaiman" };

        foreach(string print in newName)
        {
            Console.WriteLine(print);
        }


        Console.WriteLine("\nDeclaration type 03 using for each loop:");

        string[] shortName = {"Shakil", "Ahmed", "Hossain"};

        foreach(string print in shortName)
        {
            Console.WriteLine(print);
        }

        

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