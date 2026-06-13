using System;
using System.Linq;
using System.Collections.Generic;

public class QuantifiersProgram
{
    public static void Main(string[] args)
    {
        // Any / All — Yes/No questions

        var age = new List<int> {17, 18, 25, 30, 36, 20};

        bool allAdults = age.All(n => n>=18);
        Console.WriteLine("All are adults? " + allAdults);


        bool  anyTeenager = age.Any(n => n<20);
        Console.WriteLine($"\nAny Teenager? {anyTeenager}");


        // Count / Sum / Average / Min / Max

        var scores = new List<int> {5,10,15,20,18,17,25};

        int count = scores.Count(n => n>12);

        int sum = scores.Sum();

        double average = scores.Average();

        int min = scores.Min();

        int max = scores.Max();

        Console.WriteLine("\n\nAll results: ");

        Console.WriteLine($"Count: {count}");
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Min: {min}");
        Console.WriteLine($"Max: {max}");


        // First / FirstOrDefault — Get one item

        var digits = new List<int> { 45, 82, 91, 60 };

        var first       = digits.First(s => s > 80);        // 82
        var firstOrNull = digits.FirstOrDefault(s => s > 99); // 0 (default, no crash)

        Console.WriteLine($"\n\nFirst One: {first}");

        
        
        // Take / Skip — Paging

        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

        var firstThree = numbers.Take(3);  // 1, 2, 3
        var skipThree  = numbers.Skip(3);  // 4, 5, 6, 7, 8

        // Great for pagination:
        int page = 2, pageSize = 3;
        var page2 = numbers.Skip((page - 1) * pageSize).Take(pageSize); // 4, 5, 6

    }
}