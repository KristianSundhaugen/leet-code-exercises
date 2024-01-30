using System;

class Program
{
    static bool ContainCommonItems(char[] arr1, char[] arr2)
    {
        Dictionary<char, int> dict = new();

        foreach(char item in arr2){
            dict.Add(item,1);
        }

        foreach (char item in arr1)
        {
            if(dict.ContainsKey(item)){
                return true;
            }
        }

        return false;
    }

    static void Main(string[] args)
    {
        char[] arr1 = { 'a', 'b', 'c', 'x' };
        char[] arr2 = { 'z', 'y', 'i' };
        Console.WriteLine(ContainCommonItems(arr1, arr2)); // Output: False

        char[] arr3 = { 'a', 'b', 'c', 'x' };
        char[] arr4 = { 'z', 'y', 'x' };
        Console.WriteLine(ContainCommonItems(arr3, arr4)); // Output: True
    }
}