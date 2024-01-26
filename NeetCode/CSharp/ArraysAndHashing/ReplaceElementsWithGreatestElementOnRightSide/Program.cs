class Program
{
    public static void Main()
    {
        int[] result1 = Solution(new int[] { 17, 18, 5, 4, 6, 1 });
        Console.WriteLine("[{0}]", string.Join(", ", result1));
        int[] result2 = Solution(new int[] { 400 });
        Console.WriteLine("[{0}]", string.Join(", ", result2));
    }

    public static int[] Solution(int[] arr)
    {
        int max = -1;
        int temp;
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            temp = arr[i];
            arr[i] = max;
            if(temp>max){
                max = temp;
            }
        }

        return arr;
    }

    /*
    Understand: Go through arr and find each elements gratest value and place it in spot we are at, if end of array, set -1
    Match: Any constraints? No
    Plan: Bruteforce would be to make two loops, one that loops i element we change and one that find grates elemnt to the right. 
            Optimization I would do is to go through array backwards, that way I would know what the last largest value we have passet over is. Also initilize last element with -1 from start
    Implement: Write the code
    Review: Forwards did not work, so backwards might be easier, since we are only looking at the elements to the right
    Evaluate: I first tried doing it from the front, which ended up as a exponential O(n^2) anyways, so by looping backwards we keep it O(n)
    */
}