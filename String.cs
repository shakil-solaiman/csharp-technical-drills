internal class Program
{
    private static void Main(string[] args)
    {
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
        
    }
}