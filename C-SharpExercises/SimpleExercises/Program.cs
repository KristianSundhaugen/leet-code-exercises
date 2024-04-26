using System;

class Program
{
    static void SimpleExercise()
    {
        Console.WriteLine("Write a number");
        int digit = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= digit; i++){
            if(i==1 || i == digit){
                Console.WriteLine("{0}{0}{0}", digit);
            } else {
                Console.WriteLine("{0} {0}", digit);
            }
        }
    }

    static void Main(string[] args)
    {
        SimpleExercise();
    }
}