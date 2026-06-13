using System;
using System.Collections.Generic; // Required for List<T>
using System.Linq;               // Required for .Where()

class Student
{
    public string? Name {get; set;}

    public int Score {get; set;}
    
}


class WhereProgram
{
    static void Main(string[] args)
    {
        //Where — Filter
        
        // Problem 01

        var numbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        var evenNumbers = numbers.Where(num => num % 2 == 0);

        if(evenNumbers.Any())
        {
            Console.WriteLine($"\nCount of even numbers: {evenNumbers.Count()}");

            foreach(var print in evenNumbers)
            {
                Console.WriteLine(print);
            }
        }
        else
        {
            Console.WriteLine("There is no even numbers.");
        }


        //Problem 02

        var words = new List<string> {"Apple", "Mango", "Jackfruit", "Lichi", "kiwi"};

        var length = words.Where(len => len.Length > 4 );



        if(length.Any())
        {
            Console.WriteLine($"\n\nTotal long words: " + length.Count());

            Console.WriteLine("\nLong Words are: ");

            foreach(var print in length)
            {
                Console.WriteLine(print);
            }
        }
        else
        {
            Console.WriteLine("There are no words which length is greater than 4");
        }


        //Problem 03

        List<Student> studentsList = new List<Student>
        {
            new Student {Name = "Solaiman", Score = 75},
            new Student {Name = "Shakil", Score = 80},
            new Student {Name = "Salam", Score = 85},
            new Student {Name = "Sadia", Score = 78},
            new Student {Name = "Afroze", Score = 90}
        };

        var studentWithScoreMoreThan80 =  studentsList.Where(student => student.Score > 80);

        Console.WriteLine("\n\nStudent With Score More Than 80: ");

        foreach(var print in studentWithScoreMoreThan80)
            {
                Console.WriteLine($"{print.Name} {print.Score}");
            }

    }
}