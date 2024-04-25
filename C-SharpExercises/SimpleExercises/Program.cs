using System;

class Program
{
    static void SimpleExercise()
    {
        int num1, num2;

        System.Console.WriteLine("Write first number:");
        num1 = Convert.ToInt32(System.Console.ReadLine());
        System.Console.WriteLine("Write first second:");
        num2 = Convert.ToInt32(System.Console.ReadLine());

        System.Console.WriteLine("Result: {0} + {1} = {2}", num1, num2, (num1+num2));
        System.Console.WriteLine("Result: {0} - {1} = {2}", num1, num2, (num1-num2));
        System.Console.WriteLine("Result: {0} * {1} = {2}", num1, num2, (num1*num2));
        System.Console.WriteLine("Result: {0} / {1} = {2}", num1, num2, (num1/num2));
        System.Console.WriteLine("Result: {0} mod {1} = {2}", num1, num2, (num1%num2));
    }

    static void Main(string[] args)
    {
        SimpleExercise();
    }
}