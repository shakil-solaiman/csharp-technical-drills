using System;
using System.Linq;

class SelectManyProgram
{
    public static void Main(string[] args)
    {
        List<List<int>> nestedList = new List<List<int>>
        {
            new List<int> {2,4,6,8,10},
            new List<int> {5,10,15,20,25},
            new List<int> {3,6,9,12,15}
        };

        var flattedList = nestedList.SelectMany(list => list);

        Console.WriteLine("\n\nPrinting Flatted List: ");

        foreach(var items in flattedList)
        {
            Console.Write($"{items} ");
        }
    }
}