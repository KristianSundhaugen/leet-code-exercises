using System;

class Program
{
    static int[] MergeSortedArrays(int[] arr1, int[] arr2)
    {
        int arrLength;
        int count;
        int j;

        if(arr1.Length>arr2.Length){
            arrLength = arr1.Length;
        } else {
            arrLength = arr2.Length;
        }

        return [];
    }

    static void Main(string[] args)
    {
        Console.WriteLine(MergeSortedArrays([0,3,4,31], [4,6,30]));
    }
}