using System;

class Program
{
    static void SimpleExercise()
    {
        int num1, num2, num3;

        System.Console.WriteLine("Write first number:");
        num1 = Convert.ToInt32(System.Console.ReadLine());
        System.Console.WriteLine("Write first second:");
        num2 = Convert.ToInt32(System.Console.ReadLine());
        System.Console.WriteLine("Write first third:");
        num3 = Convert.ToInt32(System.Console.ReadLine());

        int result = num1 * num2 * num3;

        System.Console.WriteLine("Result: {0} * {1} * {2} = {3}", num1, num2, num3, result);
    }

    static void Main(string[] args)
    {
        SimpleExercise();
    }
}