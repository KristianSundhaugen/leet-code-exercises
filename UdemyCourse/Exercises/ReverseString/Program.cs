using System;

class Program
{
    static string ReverseStrig(string str)
    {
        char[] chars = str.ToCharArray();
        int j = 0;

        //Can use Array.Reverse(chars)
        for (int i = str.Length-1; i >= 0; i--)
        {
            chars[j] = str[i];
            j++;
        } 

        return new string(chars);
    }

    static void Main(string[] args)
    {
        Console.WriteLine(ReverseStrig("Hello world, how are you doing?"));
    }
}