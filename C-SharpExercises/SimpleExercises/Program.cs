using System;

class Program
{
    static void SimpleExercise()
    {
        System.Console.WriteLine("-1 + 4 * 6 = " + (-1 + 4 * 6));
        System.Console.WriteLine("(35+5) % 7 = " + ((35+5) % 7));
        System.Console.WriteLine("14 + -4 * 6 / 11 = " + (14 + -4 * 6 / 11));
        System.Console.WriteLine("2 + 15 / 7 * 1 - 7 % 2 = " + (2 + 15 / 7 * 1 - 7 % 2));
    }

    static void Main(string[] args)
    {
        SimpleExercise();
    }
}