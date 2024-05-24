using System;

class Program
{
    static void SimpleExercise()
    {
        string longestString = "";

        Console.WriteLine("Write a sentence");
        string inputString = Console.ReadLine();

        foreach (var item in inputString.Split(" ")){
            if(item.Length > longestString.Length){
                longestString = item;
            }    
        }

        System.Console.WriteLine(longestString);
    }


    static void Main(string[] args)
    {
        SimpleExercise();
    } 
}