using System;

class Program
{
    static bool ContainCommonItems(char[] arr1, char[] arr2)
    {
        if (arr1.Length == 0 || arr2.Length == 0)
        {
            return false;
        }

        HashSet<char> dict = new(arr2);

        foreach (char item in arr1)
        {
            if (dict.Contains(item))
            {
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