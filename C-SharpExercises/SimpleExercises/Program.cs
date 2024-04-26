using System;

class Program
{
    static void SimpleExercise()
    {
        Console.WriteLine("Write a string");
        string inputString = Console.ReadLine();
        string lowerString = inputString.ToLower();

        System.Console.WriteLine(lowerString);
    }


    static void Main(string[] args)
    {
        SimpleExercise();
    }
}