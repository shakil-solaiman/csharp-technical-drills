using System;

class OutputFormattingProgram
{
    static void Main(string[] args)
    {
        int number1 = 10;
        int number2 = 15;
        int result1, result2, result3;

        //Formatting 01

        Console.WriteLine("Output Formatting 01: ");

        result1 = number1 + number2;

        Console.WriteLine("Addition: " + result1);

        Console.WriteLine($"Addition: " + result1);


        //Formatting 02

        Console.WriteLine("\n\nOutput Formatting 02: ");


        Console.WriteLine("Addition: " + number1 + " + " + number2 + " = " + result1);

        //Formatting 03

        Console.WriteLine("\n\nOutput Formatting 03: ");

        result2 = number2 - number1;

        Console.WriteLine($"Substraction: {number2} - {number1} = {result2}");


        //Formatting 04

        Console.WriteLine("\n\nOutput Formatting 04: ");

        result3 = number1 * number2;

        Console.WriteLine("Multiplication: {0} * {1} = {2}", number1, number2, result3);

    }
}