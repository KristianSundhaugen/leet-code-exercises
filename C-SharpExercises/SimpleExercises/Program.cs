using System;

class Program
{
    static void SimpleExercise()
    {
        Console.WriteLine("Write a string");
        string inputString = Console.ReadLine();
        int stringLength = inputString.Length;

        if (stringLength <= 0)
        {
            Console.WriteLine("String must be 1 or longer");
            return;
        }

        char firstLetter = inputString[0];

        System.Console.WriteLine(firstLetter + inputString + firstLetter);
    }


    static void Main(string[] args)
    {
        SimpleExercise();
    }
}