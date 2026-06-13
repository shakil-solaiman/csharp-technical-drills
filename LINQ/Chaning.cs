using System;
using System.Linq;
using System.Collections.Generic;

public class ChaningProgram
{
    public static void Main(string[] args)
    {
        var scores = new List<int> { 45, 82, 91, 60, 78, 95, 55 };

        var result = scores
            .Where(s => s >= 60)       // filter: 82, 91, 60, 78, 95
            .OrderByDescending(s => s) // sort:   95, 91, 82, 78, 60
            .Take(3);                  // top 3:  95, 91, 82
            
            
        Console.WriteLine("Top 3 Scores:");

        foreach(var items in result)
        {
            Console.WriteLine(items);
        }               
    }
}