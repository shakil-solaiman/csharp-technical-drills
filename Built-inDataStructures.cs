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

        foreach(var print in listing)
        {
            Console.WriteLine(print);
        }



     }
}