using System;
using System.Linq;

class Person
{
    public string? Name {get; set;}

    public int Age {get; set;}

    public string? BloodGroup {get; set;}
}

class SelectProgram
{
    public static void Main(string[] args)
    {
        // Select — Transform

        // Problem 01

        var names = new List<string> {"Solaiman", "Shakil", "Salam", "Sadia"};

        var upperCase = names.Select(name => name.ToUpper());

        Console.WriteLine("Convert names from lowercase to uppercase: ");

        foreach(var items in upperCase)
        {
            Console.Write($"{items}  ");

        }

        // Problem 02

        var numbers = new List<int> {1,5,10,15,20,25};

        var transformNumbers = numbers.Select(num => num*num);

        Console.WriteLine("\n\nTransform Numbers: ");

        foreach(var items in transformNumbers)
        {
            Console.Write($"{items}  ");
        }


        // Problem 03

        var personInfo = new List<Person>
        {
            new Person {Name = "Niloy", Age = 30, BloodGroup = "A+"},
            new Person {Name = "Ahmed", Age = 27, BloodGroup = "O+"}, 
            new Person {Name = "Shakil", Age =28, BloodGroup = "B-"}
        };

        Console.WriteLine("\n\nPerson Information: ");

        foreach(var items in personInfo)
        {
            Console.Write($"{items.Name}  ");
        }

        // We can do the same job with Select (LINQ Extension Methods or LINQ Operators.)

        var nameAndBloodGroup = personInfo.Select(person => (person.Name, person.BloodGroup));

        Console.WriteLine("\n\nPrinting Name and Blood Group with Select operator: ");

        foreach(var items in nameAndBloodGroup)
        {
            Console.WriteLine($"{items.Name} {items.BloodGroup}  ");
        }
        
    }
}
