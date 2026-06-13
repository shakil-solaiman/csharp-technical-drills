using System;
using System.Linq;
using System.Collections.Generic;


public class Persons
{
    public string? Name {get; set;}

    public int Age {get; set;}
}

public class OrderByProgram
{
    public static void Main()
    {
        // Problem 01

        int[] numbers = {5,1,9,2,3,20,16,15,35,24};

        var sortedNumbers = numbers.OrderBy(num => num);

        Console.WriteLine("Sorted Numbers: ");

        foreach(var items in sortedNumbers)
        {
            Console.Write($"{items} ");
        }

        // Problem 02

        var sortedNumbersDescending = numbers.OrderByDescending(num => num);

        Console.WriteLine("\n\nSorted By Descending Order: ");

        foreach(var items in sortedNumbersDescending)
        {
            Console.Write($"{items} ");
        }

        // Problem 03


        var people = new List<Persons>
        {
            new Persons {Name = "Solaiman", Age = 28},
            new Persons {Name = "Ahmed", Age = 20},
            new Persons {Name = "Kohli", Age = 50}

        };

        var sortedPeople = people.OrderBy(man => man.Name);   
        var sortedAge = people.OrderBy(man => man.Age);

        Console.WriteLine("\n\nSorted by Name: ");

        foreach(var items in sortedPeople)
        {
            Console.WriteLine($"{items.Name} : {items.Age}");
        }

        
        Console.WriteLine("\n\nSorted by Age: ");

        foreach(var items in sortedAge)
        {
            Console.WriteLine($"{items.Age} : {items.Name}");
        }
       
    }
}