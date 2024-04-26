using System;

class Program
{
    static void SimpleExercise()
    {
        Console.WriteLine("Write a string");
        string inputString = Console.ReadLine();
        int stringLength = inputString.Length;

        if (stringLength <= 1)
        {
            Console.WriteLine("First and last letters reversed");
            Console.WriteLine(inputString);
            return;
        }

        char startCharacter = inputString[0];
        char endCharacter = inputString[stringLength - 1];

        inputString = endCharacter + inputString.Substring(1, stringLength - 2) + startCharacter;

        Console.WriteLine("First and last letters reversed");
        Console.WriteLine(inputString);
    }


    static void Main(string[] args)
    {
        SimpleExercise();
    }
}